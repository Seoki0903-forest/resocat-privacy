[English](README.md) · **한국어** · [中文](README.zh.md) · [日本語](README.ja.md) · [Bahasa Indonesia](README.id.md) · [Español](README.es.md) · [Português (Brasil)](README.pt-BR.md) · [Tiếng Việt](README.vi.md) · [ไทย](README.th.md) · [Русский](README.ru.md) · [Deutsch](README.de.md) · [Français](README.fr.md) · [Türkçe](README.tr.md)

# ResoCat

Android 앱별로 원하는 화면 해상도를 설정하세요.

[Google Play](https://play.google.com/store/apps/details?id=app.resocat.switcher)

## 다운로드

[![Windows Download EXE](https://img.shields.io/badge/Windows-Download_EXE-6b4ca5?style=for-the-badge&labelColor=555555)](https://github.com/Seoki0903-forest/resocat-privacy/raw/refs/heads/main/downloads/ResoCat-ADB-Helper.exe)

**ResoCat USB Permission Helper 1.0.1**

Windows PC에서 USB로 연결한 Android 기기의 ResoCat 초기 권한을 설정하는 무료 도구입니다. 64비트 Windows 10/11과 .NET Framework 4.5 이상이 필요합니다. ADB가 EXE에 포함되어 있어 별도 설치나 압축 해제가 필요하지 않습니다. 도구 화면은 한국어 Windows에서 한국어, 그 외에는 영어로 표시됩니다. 이 안내문은 ResoCat의 13개 지원 언어로 제공됩니다.

[SHA-256](downloads/SHA256SUMS.txt) · [소스 코드](usb-helper/source/ResoCatAdbHelper.cs)

## 사용 방법

1. 휴대폰 또는 태블릿에 Google Play의 ResoCat을 설치합니다.
2. 기기의 개발자 옵션에서 USB 디버깅을 켭니다. 개발자 옵션은 보통 설정 → 휴대전화 정보 → 빌드 번호를 7회 누르면 활성화됩니다. 제조사에 따라 메뉴 이름이 다릅니다.
3. 데이터 전송이 가능한 USB 케이블로 PC에 연결하고 기기 잠금을 풉니다.
4. 기기에 뜨는 USB 디버깅 허용 창에서 이 컴퓨터를 허용합니다. 공용 PC에서는 항상 허용을 선택하지 마세요.
5. 공식 GitHub에서 받은 `ResoCat-ADB-Helper.exe`를 실행합니다.
6. 기기를 선택하고 **권한 설정 및 ResoCat 실행**을 누릅니다. 한 대만 연결되어 있으면 자동 선택됩니다.
7. 완료 메시지를 확인하고 기기의 ResoCat에서 이용약관과 남은 설정을 직접 확인합니다. 이후 USB 연결을 해제해도 됩니다.

연결 문제: `unauthorized`는 기기 잠금을 풀고 USB 디버깅을 허용한 뒤 **기기 새로고침**을 누르세요. `offline`은 USB를 다시 연결하세요. 기기가 없으면 USB 디버깅·데이터 케이블·제조사 USB 드라이버를 확인하세요. 일부 완료 메시지가 나오면 ResoCat이 안내하는 Android 설정에서 사용정보 접근을 직접 허용하세요. 회사·학교 기기 정책이나 제조사 제한은 우회하지 않습니다.

Windows 경고: 이 프로그램은 코드 서명되지 않아 SmartScreen의 ‘Windows의 PC 보호’가 표시될 수 있습니다. 공식 다운로드 주소와 SHA-256을 확인하고 신뢰하는 파일에 한해서 ‘추가 정보 → 실행’을 선택하세요.

변경 항목: 현재 Android 사용자의 ResoCat(`app.resocat.switcher`)에 해상도 변경 권한 `WRITE_SECURE_SETTINGS`와 사용정보 접근 `GET_USAGE_STATS`만 설정합니다. 루팅이나 PC 관리자 권한은 필요하지 않습니다. 해상도·DPI 값, 광고·결제, 배터리 설정은 변경하지 않으며 앱을 설치하거나 데이터를 삭제하지 않습니다. 서버로 데이터를 전송하지 않습니다. **결과 저장**을 눌러 저장한 TXT에는 기기 식별자가 포함될 수 있습니다. 문제가 있으면 해당 TXT를 지원 담당자에게 직접 보내세요. USB 디버깅은 설정이 끝난 뒤 꺼도 됩니다.

## 문의

[홈페이지](https://seokiapps.com/) · [문의하기](https://seokiapps.com/en/support/)
