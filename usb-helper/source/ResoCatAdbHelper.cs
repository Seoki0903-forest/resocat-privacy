using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.IO.Compression;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

[assembly: AssemblyTitle("ResoCat USB Permission Helper")]
[assembly: AssemblyProduct("ResoCat USB Permission Helper")]
[assembly: AssemblyVersion("1.0.3.0")]
[assembly: AssemblyFileVersion("1.0.3.0")]

static class ResoCatAdbHelper
{
    const string Package = "app.resocat.switcher";
    const string Permission = "android.permission.WRITE_SECURE_SETTINGS";
    const string ToolsUrl = "https://dl.google.com/android/repository/platform-tools_r37.0.1-win.zip";
    const string ToolsSha256 = "45f4d63113e895ebde0c90f194099a4676b6ac653bd28d54314a9e022bbc1a99";
    static readonly string ToolsDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "ResoCat", "platform-tools-37.0.1");
    static readonly Dictionary<string, string> AdbFiles = new Dictionary<string, string> {
        { "adb.exe", "b4a6b455702684652cccf7b46258b29e653538904359a58fd4931cf3ef286b3f" },
        { "AdbWinApi.dll", "c1d653030b4bde65d3e07e4d0b0979e17be56df1436cdd15528630f27808050d" },
        { "AdbWinUsbApi.dll", "0710e894d9b40f71a670c13c694079d564c92c1279da382cfe4850983aaebe1b" },
        { "libwinpthread-1.dll", "f2044c755e39efc5d47f47c5a942178dd6d79dc8945bb182dc8753d10e2a4269" },
        { "NOTICE.txt", "38ec8c6f5b7799c223ffeab1f9e81c2d5fc67b5e56d6424f649630ca1ee1a811" }
    };

    [STAThread]
    static int Main(string[] args)
    {
        try
        {
            if (args.Length == 1 && args[0] == "--self-test") { SelfTest(); return 0; }
            if (args.Length == 2 && args[0] == "--grant")
            {
                Grant(args[1], Adb, Console.WriteLine);
                return 0;
            }
            if (args.Length == 2 && args[0] == "--preview")
            {
                Application.EnableVisualStyles();
                using (var window = new HelperWindow(true))
                using (var bitmap = new Bitmap(window.Width, window.Height))
                {
                    window.ShowInTaskbar = false;
                    window.StartPosition = FormStartPosition.Manual;
                    window.Location = new Point(-4000, -4000);
                    window.Show();
                    Application.DoEvents();
                    window.DrawToBitmap(bitmap, new Rectangle(Point.Empty, bitmap.Size));
                    bitmap.Save(args[1], System.Drawing.Imaging.ImageFormat.Png);
                }
                return 0;
            }
            if (args.Length != 0) throw new Exception("Usage: ResoCat-ADB-Helper.exe [--self-test | --grant SERIAL]");
            Application.EnableVisualStyles();
            Application.Run(new HelperWindow());
            return 0;
        }
        catch (Exception e) { Console.Error.WriteLine(e.Message); return 1; }
    }

    static string Hash(byte[] bytes)
    {
        using (var hash = SHA256.Create())
            return BitConverter.ToString(hash.ComputeHash(bytes)).Replace("-", "").ToLowerInvariant();
    }

    static bool ToolsVerified()
    {
        foreach (var file in AdbFiles)
        {
            string path = Path.Combine(ToolsDirectory, file.Key);
            if (!File.Exists(path) || Hash(File.ReadAllBytes(path)) != file.Value) return false;
        }
        return true;
    }

    static void InstallTools(byte[] archive)
    {
        if (Hash(archive) != ToolsSha256) throw new Exception("Google platform-tools integrity check failed. No tools were installed or executed.");
        using (var zip = new ZipArchive(new MemoryStream(archive), ZipArchiveMode.Read))
        {
            // Only these fixed names are extracted; archive paths can never choose a destination.
            var verified = new Dictionary<string, byte[]>();
            foreach (var file in AdbFiles)
            {
                var entry = zip.GetEntry("platform-tools/" + file.Key);
                if (entry == null || entry.Length > 20000000) throw new Exception("Invalid official platform-tools archive.");
                using (var input = entry.Open())
                using (var output = new MemoryStream())
                {
                    input.CopyTo(output);
                    byte[] bytes = output.ToArray();
                    if (Hash(bytes) != file.Value) throw new Exception("Platform-tools file verification failed: " + file.Key);
                    verified.Add(file.Key, bytes);
                }
            }
            Directory.CreateDirectory(ToolsDirectory);
            foreach (var file in verified) File.WriteAllBytes(Path.Combine(ToolsDirectory, file.Key), file.Value);
        }
    }

    static string AdbPath()
    {
        if (!ToolsVerified())
        {
            // Fetch the original Google distribution, never an embedded executable or mirror.
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            using (var handler = new HttpClientHandler { AllowAutoRedirect = false })
            using (var client = new HttpClient(handler) { Timeout = TimeSpan.FromSeconds(120) })
            using (var response = client.GetAsync(ToolsUrl, HttpCompletionOption.ResponseHeadersRead).GetAwaiter().GetResult())
            {
                response.EnsureSuccessStatusCode();
                using (var input = response.Content.ReadAsStreamAsync().GetAwaiter().GetResult())
                using (var output = new MemoryStream())
                {
                    var buffer = new byte[65536]; int count;
                    while ((count = input.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        if (output.Length + count > 25000000) throw new Exception("Platform-tools download is larger than expected.");
                        output.Write(buffer, 0, count);
                    }
                    InstallTools(output.ToArray());
                }
            }
        }
        if (!ToolsVerified()) throw new Exception("Platform-tools could not be verified. No ADB command was run.");
        return Path.Combine(ToolsDirectory, "adb.exe");
    }

    internal static string Adb(string args)
    {
        string path = AdbPath();
        var info = new ProcessStartInfo(path, args) {
            UseShellExecute = false, CreateNoWindow = true,
            RedirectStandardOutput = true, RedirectStandardError = true,
            StandardOutputEncoding = Encoding.UTF8, StandardErrorEncoding = Encoding.UTF8
        };
        using (var process = Process.Start(info))
        {
            var output = process.StandardOutput.ReadToEndAsync();
            var error = process.StandardError.ReadToEndAsync();
            if (!process.WaitForExit(15000))
            {
                try { process.Kill(); } catch (InvalidOperationException) { }
                throw new Exception("Connection timed out. Check the USB cable and the authorization prompt on your device.");
            }
            Task.WaitAll(output, error);
            string text = (output.Result + "\n" + error.Result).Trim();
            if (process.ExitCode != 0) throw new Exception("ADB: " + text);
            return text;
        }
    }

    internal static List<string[]> Devices(string text)
    {
        var result = new List<string[]>();
        foreach (string line in text.Split('\n'))
        {
            var match = Regex.Match(line.Trim(), @"^(\S+)\s+(device|unauthorized|offline)\b(.*)$");
            if (match.Success && ValidSerial(match.Groups[1].Value))
                result.Add(new[] { match.Groups[1].Value, match.Groups[2].Value, match.Groups[3].Value.Trim() });
        }
        return result;
    }

    static bool ValidSerial(string serial)
    {
        // Only USB-style serials; do not send grants to emulators or network devices.
        return Regex.IsMatch(serial, @"\A[A-Za-z0-9][A-Za-z0-9._-]{0,127}\z")
            && !serial.StartsWith("emulator-", StringComparison.OrdinalIgnoreCase)
            && serial.IndexOf("_adb-", StringComparison.OrdinalIgnoreCase) < 0;
    }

    internal static bool PermissionGranted(string dump, string user)
    {
        string selected = Regex.Match(dump, @"(?ms)^\s*User " + user + @":.*?(?=^\s*User \d+:|\z)").Value;
        int firstUser = Regex.Match(dump, @"(?m)^\s*User \d+:").Index;
        string installPermissions = dump.Substring(0, firstUser);
        return Regex.IsMatch(installPermissions + "\n" + selected, @"(?m)^\s*" + Regex.Escape(Permission) + @":\s*granted=true\b");
    }

    internal static void Grant(string serial, Func<string, string> run, Action<string> log)
    {
        if (!ValidSerial(serial)) throw new Exception("Invalid USB device serial.");
        var devices = Devices(run("devices -l"));
        string[] device = devices.Find(d => d[0] == serial);
        if (device == null) throw new Exception("Selected device is disconnected. Refresh the device list.");
        if (device[1] != "device") throw new Exception("Unlock your device and allow USB debugging. Reconnect the cable if the device is offline.");
        string prefix = "-s " + serial + " shell ";
        string user = run(prefix + "am get-current-user").Trim();
        if (!Regex.IsMatch(user, @"\A\d+\z")) throw new Exception("Cannot identify the active Android user.");
        string installed = run(prefix + "pm path --user " + user + " " + Package);
        if (!Regex.IsMatch(installed, @"(?m)^package:")) throw new Exception("ResoCat is not installed for the active user. Install it from Google Play first.");
        log("Granting resolution permission…");
        run(prefix + "pm grant --user " + user + " " + Package + " " + Permission);
        if (!PermissionGranted(run(prefix + "dumpsys package " + Package), user))
            throw new Exception("Resolution permission could not be verified. Check manufacturer security settings or device policies.");
        log("Resolution permission verified.");
        log("Enabling Usage Access…");
        string usageFailure = null;
        try
        {
            run(prefix + "appops set --user " + user + " " + Package + " GET_USAGE_STATS allow");
            string usage = run(prefix + "appops get --user " + user + " " + Package + " GET_USAGE_STATS");
            if (!UsageAllowed(usage)) throw new Exception(usage);
            log("Usage Access verified.");
        }
        catch (Exception e) { usageFailure = e.Message; }
        if (run(prefix + "am get-current-user").Trim() != user)
            throw new Exception("The active Android user changed. Refresh and try again.");
        log("Opening ResoCat…");
        string launch = run(prefix + "am start --user " + user + " -n " + Package + "/.MainActivity");
        if (Regex.IsMatch(launch, @"(?im)^\s*(Error:|Exception|SecurityException)")) throw new Exception(launch);
        if (usageFailure != null)
        {
            log("Partially complete: resolution permission is ready. Enable Usage Access in the settings opened by ResoCat.");
            log(usageFailure);
            return;
        }
        log("Done! Check the terms and any remaining settings in ResoCat. You can disconnect USB.");
    }

    static bool UsageAllowed(string text)
    {
        var uid = Regex.Match(text, @"(?im)^\s*Uid mode:\s*(?:GET_USAGE_STATS:\s*)?(\w+)");
        if (uid.Success && uid.Groups[1].Value != "default") return uid.Groups[1].Value == "allow";
        return Regex.IsMatch(text, @"\bGET_USAGE_STATS:\s*allow\b");
    }

    sealed class HelperWindow : Form
    {
        readonly ComboBox devices = new ComboBox { DropDownStyle = ComboBoxStyle.DropDownList, Dock = DockStyle.Top };
        readonly Button refresh = new Button { AutoSize = true, Text = "Refresh devices" };
        readonly Button grant = new Button { AutoSize = true, Text = "Set permissions and open ResoCat" };
        readonly Button save = new Button { AutoSize = true, Text = "Save result" };
        readonly TextBox output = new TextBox { Multiline = true, ReadOnly = true, ScrollBars = ScrollBars.Vertical, Dock = DockStyle.Fill };
        bool busy;

        public HelperWindow(bool preview = false)
        {
            Text = "ResoCat USB Permission Helper 1.0.3";
            ClientSize = new Size(690, 420);
            MinimumSize = new Size(560, 360);
            AutoScaleMode = AutoScaleMode.Font;
            Font = new Font("Segoe UI", 10);
            var layout = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = 1, RowCount = 4, Padding = new Padding(12) };
            layout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            layout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            layout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
            layout.Controls.Add(new Label { AutoSize = true, MaximumSize = new Size(650, 0), Margin = new Padding(0, 0, 0, 12), Text = "Install ResoCat, enable USB debugging and connect with USB.\nAllow this computer on your device's USB debugging prompt.\nFirst use downloads verified Android platform tools directly from Google (Internet required).\nThis tool sets resolution permission and Usage Access for the selected device only." });
            layout.Controls.Add(devices);
            var buttons = new FlowLayoutPanel { AutoSize = true, Dock = DockStyle.Fill, Margin = new Padding(0, 10, 0, 10) };
            buttons.Controls.AddRange(new Control[] { refresh, grant, save });
            layout.Controls.Add(buttons);
            layout.Controls.Add(output);
            Controls.Add(layout);
            grant.Enabled = false;
            refresh.Click += async (s, e) => await RefreshDevices();
            grant.Click += async (s, e) => {
                var item = devices.SelectedItem as DeviceItem;
                if (item == null) { Log("Select the device to configure."); return; }
                await Work(() => Grant(item.Serial, Adb, Log));
            };
            save.Click += (s, e) => {
                using (var dialog = new SaveFileDialog { Filter = "Text file (*.txt)|*.txt", FileName = "resocat-usb-helper-result.txt" })
                    if (dialog.ShowDialog(this) == DialogResult.OK)
                        try { File.WriteAllText(dialog.FileName, output.Text, Encoding.UTF8); }
                        catch (Exception error) { Log(error.Message); }
            };
            if (!preview) Shown += async (s, e) => await RefreshDevices();
            FormClosing += (s, e) => { if (busy) { e.Cancel = true; Log("Please wait until the operation finishes before closing."); } };
        }

        void Log(string text)
        {
            if (InvokeRequired) { Invoke(new Action<string>(Log), text); return; }
            output.AppendText(DateTime.Now.ToString("HH:mm:ss") + " " + text + Environment.NewLine);
        }

        async Task Work(Action action)
        {
            busy = true; refresh.Enabled = grant.Enabled = devices.Enabled = false;
            try { await Task.Run(action); }
            catch (Exception e) { Log("Setup did not complete: " + e.Message); }
            finally { busy = false; refresh.Enabled = devices.Enabled = true; grant.Enabled = devices.Items.Count > 0; }
        }

        async Task RefreshDevices()
        {
            Log("Preparing verified Google platform tools. First use requires an Internet connection.");
            await Work(() => {
                var found = Devices(Adb("devices -l"));
                Invoke(new Action(() => {
                    devices.Items.Clear();
                    foreach (var d in found) devices.Items.Add(new DeviceItem(d));
                    if (devices.Items.Count == 1) devices.SelectedIndex = 0;
                }));
                Log(found.Count == 0 ? "No USB device found. Check USB debugging, the data cable and USB drivers." : "Select your device and click Set permissions and open ResoCat. Unauthorized devices need approval on the device.");
            });
        }
    }

    sealed class DeviceItem
    {
        public readonly string Serial;
        readonly string label;
        public DeviceItem(string[] d) { Serial = d[0]; label = d[0] + " — " + d[1] + " " + d[2]; }
        public override string ToString() { return label; }
    }

    static void SelfTest()
    {
        Action<bool, string> check = (ok, name) => { if (!ok) throw new Exception("FAIL: " + name); Console.WriteLine("PASS: " + name); };
        check(Devices("List of devices attached\nUSB01 device model:Tablet\nUSB02 unauthorized\nemulator-5554 device\n192.168.0.2:5555 device\nadb-USB01-abc._adb-tls-connect._tcp device\ninvalid;serial device").Count == 2, "device filtering");
        check(!ValidSerial("USB;whoami") && !ValidSerial("-s") && !ValidSerial("USB\n01"), "serial validation");
        check(!PermissionGranted("User 0: installed=true\nUser 10: installed=true\n " + Permission + ": granted=true", "0"), "permissions belong to selected user");
        check(UsageAllowed("GET_USAGE_STATS: allow"), "package Usage Access allowed");
        check(!UsageAllowed("Uid mode: GET_USAGE_STATS: ignore\nGET_USAGE_STATS: allow"), "UID override blocks package Usage Access");
        check(UsageAllowed("Uid mode: GET_USAGE_STATS: allow\nGET_USAGE_STATS: ignore"), "UID allow has precedence");
        check(UsageAllowed("Uid mode: GET_USAGE_STATS: default\nGET_USAGE_STATS: allow"), "UID default uses package mode");
        check(Assembly.GetExecutingAssembly().GetManifestResourceNames().Length == 0, "no executable resources embedded");
        bool rejected = false;
        try { InstallTools(new byte[] { 1, 2, 3 }); } catch (Exception) { rejected = true; }
        check(rejected, "reject unverified archive before writing tools");
        check(Adb("version").Contains("Android Debug Bridge version"), "verified official ADB runs");
        check(ToolsVerified(), "all cached tool files match pinned hashes");
        foreach (string scenario in new[] { "success", "user10", "unauthorized", "missing", "denied", "verify-denied", "usage-denied", "launch-failed", "user-changed" })
        {
            var calls = new List<string>(); var logs = new List<string>();
            Func<string, string> fake = command => {
                calls.Add(command);
                if (command == "devices -l") return "USB01 " + (scenario == "unauthorized" ? "unauthorized" : "device");
                if (command.EndsWith("am get-current-user")) return scenario == "user10" ? "10" : scenario == "user-changed" && calls.Count > 3 ? "10" : "0";
                if (command.Contains("pm path")) return scenario == "missing" ? "" : "package:/data/app/base.apk";
                if (command.Contains("pm grant") && scenario == "denied") throw new Exception("SecurityException");
                if (command.Contains("dumpsys package")) return "User " + (scenario == "user10" ? "10" : "0") + ": installed=true\n " + Permission + ": granted=" + (scenario == "verify-denied" ? "false" : "true");
                if (command.Contains("appops set") && scenario == "usage-denied") throw new Exception("AppOps denied");
                if (command.Contains("appops get")) return "GET_USAGE_STATS: allow";
                if (command.Contains("am start")) return scenario == "launch-failed" ? "Error: Activity not found" : "Starting: Intent";
                return "";
            };
            bool failed = false;
            try { Grant("USB01", fake, logs.Add); } catch (Exception) { failed = true; }
            bool expectedSuccess = scenario == "success" || scenario == "user10" || scenario == "usage-denied";
            check(failed != expectedSuccess, scenario);
            if (scenario == "unauthorized" || scenario == "missing") check(!calls.Exists(c => c.Contains("pm grant")), scenario + " does not grant");
            if (scenario == "denied" || scenario == "verify-denied") check(!calls.Exists(c => c.Contains("appops set") || c.Contains("am start")), scenario + " stops before later steps");
            if (scenario == "user10") check(calls.Find(c => c.Contains("pm grant")).Contains("--user 10"), "current-user grant");
            if (scenario == "usage-denied") check(logs.Exists(l => l.Contains("일부 완료") || l.Contains("Partially complete")), "partial completion reported");
        }
    }
}
