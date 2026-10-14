# ResoCat USB Permission Helper — Windows

[Download and instructions in 13 languages](../README.md)

GitHub distributes the standalone EXE. ZIP references below describe only the optional local build package.

## 한국어

PC에서 ResoCat의 초기 권한을 설정하는 도구입니다. 프로그램 화면은 모든 Windows에서 영어로 표시됩니다. ResoCat APK나 Shizuku를 설치하지 않으며, 현재 Android 사용자의 ResoCat에 필요한 두 가지 권한만 설정합니다.

1. 휴대폰에 Google Play의 ResoCat을 설치하고 개발자 옵션에서 USB 디버깅을 켭니다.
2. 데이터 전송이 가능한 USB 케이블로 PC에 연결하고 휴대폰에서 USB 디버깅을 허용합니다.
3. `ResoCat-ADB-Helper.exe`를 다운로드해 실행합니다. ADB가 포함되어 있어 EXE 하나로 실행할 수 있습니다. ZIP에는 설명파일과 소스도 포함됩니다.
4. 기기를 선택하고 **Set permissions and open ResoCat** (권한 설정 및 ResoCat 실행)을 누릅니다. 한 대만 연결되어 있으면 자동 선택됩니다.
5. 완료가 표시되면 휴대폰에서 ResoCat을 사용합니다. 이용약관은 직접 동의해야 합니다. USB 연결은 해제해도 됩니다.

설정하는 항목:

- 해상도·DPI 변경: `android.permission.WRITE_SECURE_SETTINGS`
- 앱별 자동 적용을 위한 사용정보 접근: `GET_USAGE_STATS` AppOp

설정 후 실제 권한 상태를 확인하며, 실패한 경우 완료로 표시하지 않습니다. 제조사가 사용정보 접근 설정을 막는 경우 해상도 권한만 설정하고 앱에서 직접 허용하도록 안내합니다. 해상도 값, DPI 값, 광고·결제·이용약관, 알림 권한, 배터리 최적화 설정은 변경하지 않습니다. 사용자 데이터나 설치된 앱을 삭제하지 않습니다.

### 연결이 안 되는 경우

- `unauthorized`: 휴대폰 잠금을 풀고 USB 디버깅 허용 창을 확인하세요. 허용한 뒤 **Refresh devices** (기기 새로고침)를 누릅니다.
- `offline`: USB 케이블을 다시 연결하세요.
- 기기가 없음: USB 디버깅, 데이터 케이블, [제조사 USB 드라이버](https://developer.android.com/studio/run/oem-usb)를 확인하세요.
- ResoCat 미설치: 현재 Android 사용자에 Play 버전을 설치하세요. 별도 테스트 패키지에는 권한을 부여하지 않습니다.
- 권한 거부: 제조사 보안 옵션이나 회사·학교 기기 정책에 의해 차단될 수 있습니다. 이 도구는 이를 우회하지 않습니다.

루팅이나 PC 관리자 권한은 요구하지 않습니다. 64비트 Windows와 .NET Framework 4.5 이상이 필요하며 일반적인 Windows 10/11에는 포함되어 있습니다. 실행 파일은 현재 코드 서명되지 않았습니다. 도구는 서버에 데이터를 보내지 않습니다. **Save result** (결과 저장)을 누를 때만 사용자가 고른 경로에 TXT를 저장하며 기기 식별자가 포함될 수 있습니다.

## English

1. Install ResoCat from Google Play and enable USB debugging on your Android device.
2. Connect with a USB data cable and authorize this computer on your device.
3. Download and run `ResoCat-ADB-Helper.exe`. ADB is embedded, so the EXE works on its own. The optional ZIP also includes instructions and source.
4. Select your device and click **Set permissions and open ResoCat**.
5. After completion, use ResoCat on your device. Accept its terms yourself. USB can then be disconnected.

The tool grants `WRITE_SECURE_SETTINGS` and enables the `GET_USAGE_STATS` AppOp for ResoCat (`app.resocat.switcher`) in the active Android user, verifies both, then opens the app. It does not install apps, change resolution/DPI values, accept terms, modify billing, change battery/notification settings, delete data or upload logs. If Usage Access cannot be enabled, it reports partial completion and asks you to enable it from the settings opened by ResoCat.

For `unauthorized`, unlock the device and accept its debugging prompt, then refresh. For `offline`, reconnect USB. If no device appears, check USB debugging, a data-capable cable and [OEM USB drivers](https://developer.android.com/studio/run/oem-usb). Manufacturer restrictions or managed-device policies may prevent grants. 64-bit Windows and .NET Framework 4.5+ are required. Root and PC administrator rights are not required. This executable is currently unsigned. Saved TXT results can contain device identifiers.

## Source and bundled software

The 13-language guide is available in `ResoCat-USB-Helper-Guide.txt` and [GUIDE.md](GUIDE.md): 한국어, English, 中文, 日本語, Bahasa Indonesia, Español, Português (Brasil), Tiếng Việt, ไทย, Русский, Deutsch, Français, Türkçe. The helper interface is in English on every Windows system.

`source/ResoCatAdbHelper.cs` is included for inspection. To rebuild on a Windows developer PC with Android SDK Platform Tools installed, run `build.ps1` from the source folder. The executable's `--self-test` option performs simulated permission checks and runs the bundled ADB version command without accessing connected devices. `--grant SERIAL` runs the same permission setup without the window, for verification.

Bundled ADB and supporting libraries come from Android SDK Platform Tools 37.0.1. Their notices and licenses are included in `adb/NOTICE.txt`. Only ADB-related files are included; fastboot and flashing utilities are excluded.

Version 1.0.2 embeds these files in the EXE and extracts them to a unique temporary directory when needed. On closing, it tries to remove its own extracted files without stopping any ADB server. Files held open by ADB may remain temporarily. Deleting the PC helper does not revoke the Android permissions it granted.

Official connection instructions: https://developer.android.com/tools/adb#Enabling
