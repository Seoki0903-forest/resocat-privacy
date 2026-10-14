**English** · [한국어](README.ko.md) · [中文](README.zh.md) · [日本語](README.ja.md) · [Bahasa Indonesia](README.id.md) · [Español](README.es.md) · [Português (Brasil)](README.pt-BR.md) · [Tiếng Việt](README.vi.md) · [ไทย](README.th.md) · [Русский](README.ru.md) · [Deutsch](README.de.md) · [Français](README.fr.md) · [Türkçe](README.tr.md)

# ResoCat

Set a custom screen resolution for each Android app.

[Google Play](https://play.google.com/store/apps/details?id=app.resocat.switcher)

## Download

[![Windows Download EXE](https://img.shields.io/badge/Windows-Download_EXE-6b4ca5?style=for-the-badge&labelColor=555555)](https://github.com/Seoki0903-forest/resocat-privacy/raw/refs/heads/main/downloads/ResoCat-ADB-Helper.exe)

**ResoCat USB Permission Helper 1.0.1**

A free tool to set up ResoCat permissions on an Android phone or tablet connected to a Windows PC by USB. Requires 64-bit Windows 10/11 and .NET Framework 4.5+. ADB is included in the EXE; no separate installation or extraction is needed. The tool uses Korean on Korean Windows and English otherwise. This guide covers all 13 ResoCat languages.

[SHA-256](downloads/SHA256SUMS.txt) · [Source code](usb-helper/source/ResoCatAdbHelper.cs)

## Usage instructions

1. Install ResoCat from Google Play on your Android device.
2. Enable USB debugging in Developer options. Usually, tap Settings → About phone → Build number seven times to enable Developer options. Menu names vary by manufacturer.
3. Connect with a USB data cable and unlock your device.
4. Allow this computer in the device's USB debugging prompt. Do not select “Always allow” on a shared PC.
5. Run `ResoCat-ADB-Helper.exe` downloaded from the official GitHub repository.
6. Select your device and click **Set permissions and open ResoCat**. A single connected device is selected automatically.
7. Check the completion message and review the terms and remaining settings in ResoCat yourself. You can then disconnect USB.

Connection issues: For `unauthorized`, unlock the device, allow USB debugging, then click **Refresh devices**. For `offline`, reconnect USB. If no device appears, check USB debugging, the data cable and OEM USB drivers. If the result is partially complete, enable Usage Access in the Android settings indicated by ResoCat. Manufacturer restrictions and managed-device policies are not bypassed.

Windows warning: This program is unsigned and may trigger “Windows protected your PC.” Check the official download URL and SHA-256; choose “More info → Run anyway” only for a file you trust.

Changes: Only `WRITE_SECURE_SETTINGS` and the `GET_USAGE_STATS` AppOp are set for ResoCat (`app.resocat.switcher`) in the active Android user. No root or PC administrator access is required. Resolution/DPI values, ads, billing and battery settings are not changed. No apps are installed or data deleted. No data is sent to a server. **Save result** creates a TXT that may contain device identifiers; send it to support yourself if needed. USB debugging can be disabled after setup.

## Contact

[Website](https://seokiapps.com/) · [Contact us](https://seokiapps.com/en/support/)
