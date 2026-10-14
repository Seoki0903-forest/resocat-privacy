[English](README.md) · [한국어](README.ko.md) · **中文** · [日本語](README.ja.md) · [Bahasa Indonesia](README.id.md) · [Español](README.es.md) · [Português (Brasil)](README.pt-BR.md) · [Tiếng Việt](README.vi.md) · [ไทย](README.th.md) · [Русский](README.ru.md) · [Deutsch](README.de.md) · [Français](README.fr.md) · [Türkçe](README.tr.md)

# ResoCat

为每个 Android 应用设置自定义屏幕分辨率。

[Google Play](https://play.google.com/store/apps/details?id=app.resocat.switcher)

## 下载

[![Windows Download EXE](https://img.shields.io/badge/Windows-Download_EXE-6b4ca5?style=for-the-badge&labelColor=555555)](https://github.com/Seoki0903-forest/resocat-privacy/raw/refs/heads/main/downloads/ResoCat-ADB-Helper.exe)

**ResoCat USB Permission Helper 1.0.2**

这是一款免费工具，用于通过 Windows 电脑和 USB 为 Android 手机或平板上的 ResoCat 设置初始权限。需要 64 位 Windows 10/11 和 .NET Framework 4.5 或更高版本。EXE 已包含 ADB，无需另外安装或解压。程序界面在所有 Windows 系统上均显示英语。本指南提供 ResoCat 支持的全部 13 种语言。

[SHA-256](downloads/SHA256SUMS.txt) · [源代码](usb-helper/source/ResoCatAdbHelper.cs)

## 使用指南

1. 在 Android 设备上从 Google Play 安装 ResoCat。
2. 在开发者选项中启用 USB 调试。通常可在设置 → 关于手机中连续点击“版本号”七次，启用开发者选项；菜单名称因厂商而异。
3. 使用支持数据传输的 USB 线连接电脑，并解锁设备。
4. 在设备的 USB 调试提示中允许此电脑。使用公共电脑时不要选择“始终允许”。
5. 运行从官方 GitHub 仓库下载的 `ResoCat-ADB-Helper.exe`。
6. 选择设备，点击 **Set permissions and open ResoCat**。仅连接一台设备时会自动选择。
7. 确认完成提示后，在设备上的 ResoCat 中自行确认条款和剩余设置，然后可断开 USB。

### 按钮说明

- **Refresh devices** — 查找设备或刷新列表。
- **Set permissions and open ResoCat** — 为所选设备设置权限并启动 ResoCat。点击此按钮开始设置。
- **Save result** — 需要帮助时将结果日志保存为 TXT 文件。此操作是可选的。

连接问题：出现 `unauthorized` 时，解锁设备并允许 USB 调试，然后点击 **Refresh devices**。出现 `offline` 时重新连接 USB。没有设备时检查 USB 调试、数据线和厂商 USB 驱动。如果提示部分完成，请按 ResoCat 的指引在 Android 设置中手动允许使用情况访问权限。工具不会绕过厂商限制或单位设备策略。

Windows 提示：程序未进行代码签名，可能显示“Windows 已保护你的电脑”。请核对官方下载地址和 SHA-256，仅对可信文件选择“更多信息 → 仍要运行”。

修改范围：仅为当前 Android 用户的 ResoCat（`app.resocat.switcher`）设置 `WRITE_SECURE_SETTINGS` 和 `GET_USAGE_STATS`。不需要 root 或电脑管理员权限，不修改分辨率、DPI、广告、付款或电池设置，不安装应用或删除数据，也不会向服务器发送数据。**Save result** 保存的 TXT 可能包含设备标识；需要帮助时请自行发送给支持人员。设置完成后可关闭 USB 调试。

## 联系

[官方网站](https://seokiapps.com/) · [联系我们](https://seokiapps.com/en/support/)
