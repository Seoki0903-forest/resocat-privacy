# ResoCat USB Permission Helper 1.0.3

Download one Windows EXE and follow the [English guide](../README.md) or any of the 12 language links at the top of that page. The interface remains English on every Windows system.

First use requires Internet access. The helper downloads Google's official Android SDK Platform-Tools 37.0.1 over HTTPS, verifies the pinned archive SHA-256 and every extracted file, and caches the five required files under `%LOCALAPPDATA%\ResoCat\platform-tools-37.0.1`. Later runs use the verified cache without downloading again. There are no embedded executable resources, temporary executable extraction, PC administrator prompts or antivirus exclusions. The helper remains unsigned; publisher reputation warnings are separate from malware detection.

The only device changes are WRITE_SECURE_SETTINGS and GET_USAGE_STATS for app.resocat.switcher in the active Android user, followed by verification and launching ResoCat. No apps or user data are deleted, no terms are accepted, and no billing, resolution values or battery settings are changed. Device details and logs are not uploaded. First-use download connects to Google's server, which receives the normal network request. Save result writes a TXT file only to the path selected by the user.

`build.ps1` builds the EXE with the Windows .NET Framework compiler. It does not embed or bundle platform-tools. `--self-test` tests validation and simulated permission flows and runs the verified Google ADB version command without accessing connected devices. `--grant SERIAL` performs the same explicit setup as the main button.

Google release notes: https://developer.android.com/tools/releases/platform-tools
Pinned archive URL: https://dl.google.com/android/repository/platform-tools_r37.0.1-win.zip
Pinned archive SHA-256: 45f4d63113e895ebde0c90f194099a4676b6ac653bd28d54314a9e022bbc1a99

The official tools' NOTICE.txt is retained in the cache. Only ADB-related files are extracted; no fastboot or flashing tools are installed.
