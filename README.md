# ResoCat

Set a custom screen resolution for each Android app.

앱별로 원하는 화면 해상도를 설정하세요.

[Google Play](https://play.google.com/store/apps/details?id=app.resocat.switcher) · [Privacy policy](privacy-policy.html) · [Open-source notices](open-source-licenses.html)

## Windows USB Permission Helper

Connect your Android phone or tablet by USB and set up ResoCat's initial permissions without typing ADB commands. Enable USB debugging and authorize your PC on the device first.

USB로 휴대폰이나 태블릿을 연결해 ResoCat 초기 권한을 설정합니다. ADB 명령어를 직접 입력할 필요가 없습니다. 먼저 기기에서 USB 디버깅을 켜고 PC 연결을 허용하세요.

### Download / 다운로드

[![Windows Download EXE](https://img.shields.io/badge/Windows-Download_EXE-6b4ca5?style=for-the-badge&labelColor=555555)](https://github.com/Seoki0903-forest/resocat-privacy/raw/refs/heads/main/downloads/ResoCat-ADB-Helper.exe)

[![Windows EXE and Guide ZIP](https://img.shields.io/badge/Windows-EXE_%2B_Guide_ZIP-6b4ca5?style=for-the-badge&labelColor=555555)](https://github.com/Seoki0903-forest/resocat-privacy/raw/refs/heads/main/downloads/ResoCat-ADB-Helper-1.0.1-Windows.zip)

**Windows 1.0.1:** 64-bit Windows 10/11, .NET Framework 4.5+. ADB is included in the EXE: download and run it directly. The ZIP also includes the 13-language guide, source code and ADB license notices. No root or PC administrator rights are required.

**Windows 1.0.1:** 64비트 Windows 10/11, .NET Framework 4.5 이상. EXE에 ADB가 포함되어 있어 파일 하나만 다운로드해 실행하면 됩니다. ZIP에는 13개 언어 설명파일, 소스, ADB 라이선스가 함께 포함됩니다. 루팅이나 PC 관리자 권한은 필요하지 않습니다.

[Download instructions TXT / 설명파일 다운로드](https://github.com/Seoki0903-forest/resocat-privacy/raw/refs/heads/main/downloads/ResoCat-USB-Helper-Guide.txt) · [SHA-256 checksums / 파일 검증](downloads/SHA256SUMS.txt) · [Helper source / 도구 소스](usb-helper/source/ResoCatAdbHelper.cs)

**Unsigned executable:** Windows SmartScreen may show “Windows protected your PC.” Check the official download URL and checksum; run only if you trust the file. Signing does not guarantee that a new file avoids this warning.

**서명되지 않은 실행 파일:** Windows SmartScreen의 ‘Windows의 PC 보호’가 표시될 수 있습니다. 공식 다운로드 주소와 체크섬을 확인하고 신뢰하는 파일만 실행하세요. 새 파일은 정식 서명을 하더라도 경고가 표시될 수 있습니다.

### Instructions / 언어별 사용 안내

The guide is available in all 13 languages supported by ResoCat. The Windows helper interface currently uses Korean on Korean Windows and English otherwise.

ResoCat의 모든 지원 언어로 사용 안내를 확인할 수 있습니다. Windows 도구 화면은 한국어 Windows에서 한국어, 그 외에는 영어로 표시됩니다.

| Language | Guide |
| --- | --- |
| 한국어 | [사용 방법 보기](usb-helper/GUIDE.md#ko) |
| English | [Read instructions](usb-helper/GUIDE.md#en) |
| 中文 | [查看使用指南](usb-helper/GUIDE.md#zh) |
| 日本語 | [使い方を見る](usb-helper/GUIDE.md#ja) |
| Bahasa Indonesia | [Baca panduan](usb-helper/GUIDE.md#id) |
| Español | [Ver instrucciones](usb-helper/GUIDE.md#es) |
| Português (Brasil) | [Ver instruções](usb-helper/GUIDE.md#pt-br) |
| Tiếng Việt | [Xem hướng dẫn](usb-helper/GUIDE.md#vi) |
| ไทย | [อ่านคู่มือ](usb-helper/GUIDE.md#th) |
| Русский | [Открыть инструкцию](usb-helper/GUIDE.md#ru) |
| Deutsch | [Anleitung lesen](usb-helper/GUIDE.md#de) |
| Français | [Lire le guide](usb-helper/GUIDE.md#fr) |
| Türkçe | [Kılavuzu okuyun](usb-helper/GUIDE.md#tr) |

### What it changes / 설정하는 권한

Only `WRITE_SECURE_SETTINGS` and the `GET_USAGE_STATS` AppOp for ResoCat (`app.resocat.switcher`) in the active Android user. The helper verifies the result and opens ResoCat. It does not install apps, change resolution/DPI values, accept terms, modify billing/battery settings, delete device data or upload logs. Saved TXT results may contain device identifiers. Manufacturer restrictions and managed-device policies are not bypassed.

현재 Android 사용자의 ResoCat에 해상도 변경 권한과 사용정보 접근만 설정하고 결과를 확인한 뒤 앱을 실행합니다. 앱 설치, 해상도·DPI 값 변경, 약관 동의, 결제·배터리 설정 변경, 기기 데이터 삭제, 로그 자동 전송은 하지 않습니다. 저장한 결과 TXT에는 기기 식별자가 포함될 수 있습니다. 제조사나 관리 기기 정책의 제한은 우회하지 않습니다.

## Helper release notes

**1.0.1**

- Standalone EXE with bundled Android SDK Platform Tools 37.0.1; no adjacent ADB folder needed.
- Instructions in all 13 ResoCat languages, also included as a UTF-8 TXT in the ZIP.
- Detect a UID-level Usage Access restriction instead of reporting package-level permission as complete.

The helper is a separate Windows utility. It does not update the ResoCat Android app.
