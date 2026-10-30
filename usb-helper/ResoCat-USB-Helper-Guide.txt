# ResoCat USB Permission Helper 1.0.3

<a id="en"></a>
## en

Set a custom screen resolution for each Android app.

[Google Play](https://play.google.com/store/apps/details?id=app.resocat.switcher)

## Download

[![Windows Download EXE](https://img.shields.io/badge/Windows-Download_EXE-6b4ca5?style=for-the-badge&labelColor=555555)](https://github.com/Seoki0903-forest/resocat-privacy/raw/refs/heads/main/downloads/ResoCat-ADB-Helper.exe)

**ResoCat USB Permission Helper 1.0.3**

A free tool to set up ResoCat permissions on an Android phone or tablet connected to a Windows PC by USB. Requires 64-bit Windows 10/11 and .NET Framework 4.5+. Download only this EXE. First use requires Internet access: it automatically downloads Android platform-tools 37.0.1 directly from Google and checks SHA-256 before use. Verified tools are cached for later offline use in `%LOCALAPPDATA%\ResoCat\platform-tools-37.0.1`. It no longer embeds or runs ADB from a temporary directory. The program interface is in English on all Windows systems. This guide covers all 13 ResoCat languages.

[SHA-256](downloads/SHA256SUMS.txt) · [Source code](usb-helper/source/ResoCatAdbHelper.cs)

## Usage instructions

1. Install ResoCat from Google Play on your Android device.
2. Enable USB debugging in Developer options. Usually, tap Settings → About phone → Build number seven times to enable Developer options. Menu names vary by manufacturer.
3. Connect with a USB data cable and unlock your device.
4. Allow this computer in the device's USB debugging prompt. Do not select “Always allow” on a shared PC.
5. Run `ResoCat-ADB-Helper.exe` downloaded from the official GitHub repository.
6. Select your device and click **Set permissions and open ResoCat**. A single connected device is selected automatically.
7. Check the completion message and review the terms and remaining settings in ResoCat yourself. You can then disconnect USB.

### Buttons

- **Refresh devices** — Find devices or refresh the list.
- **Set permissions and open ResoCat** — Set permissions on the selected device and launch ResoCat. Click this button to run the setup.
- **Save result** — Save the result log as a TXT file if you need support. This is optional.

Connection issues: For `unauthorized`, unlock the device, allow USB debugging, then click **Refresh devices**. For `offline`, reconnect USB. If no device appears, check USB debugging, the data cable and OEM USB drivers. If the result is partially complete, enable Usage Access in the Android settings indicated by ResoCat. Manufacturer restrictions and managed-device policies are not bypassed.

Windows warning: This program is unsigned and may trigger “Windows protected your PC.” Check the official download URL and SHA-256; choose “More info → Run anyway” only for a file you trust.

Changes: Only `WRITE_SECURE_SETTINGS` and the `GET_USAGE_STATS` AppOp are set for ResoCat (`app.resocat.switcher`) in the active Android user. No root or PC administrator access is required. Resolution/DPI values, ads, billing and battery settings are not changed. No apps are installed or data deleted. No data is sent to a server. **Save result** creates a TXT that may contain device identifiers; send it to support yourself if needed. USB debugging can be disabled after setup.

## Contact

[Website](https://seokiapps.com/) · [Contact us](https://seokiapps.com/en/support/)

---

<a id="ko"></a>
## ko

Android 앱별로 원하는 화면 해상도를 설정하세요.

[Google Play](https://play.google.com/store/apps/details?id=app.resocat.switcher)

## 다운로드

[![Windows Download EXE](https://img.shields.io/badge/Windows-Download_EXE-6b4ca5?style=for-the-badge&labelColor=555555)](https://github.com/Seoki0903-forest/resocat-privacy/raw/refs/heads/main/downloads/ResoCat-ADB-Helper.exe)

**ResoCat USB Permission Helper 1.0.3**

Windows PC에서 USB로 연결한 Android 기기의 ResoCat 초기 권한을 설정하는 무료 도구입니다. 64비트 Windows 10/11과 .NET Framework 4.5 이상이 필요합니다. EXE 하나만 받으면 됩니다. 첫 실행에는 인터넷 연결이 필요하며, Google 공식 서버에서 Android platform-tools 37.0.1을 자동으로 내려받고 사용 전에 SHA-256을 검증합니다. 검증된 도구는 `%LOCALAPPDATA%\ResoCat\platform-tools-37.0.1`에 보관하여 이후 오프라인에서도 사용합니다. EXE에 ADB를 내장하거나 임시 폴더에서 실행하는 구조를 제거했습니다. 프로그램 화면은 모든 Windows에서 영어로 표시됩니다. 이 안내문은 ResoCat의 13개 지원 언어로 제공됩니다.

[SHA-256](downloads/SHA256SUMS.txt) · [소스 코드](usb-helper/source/ResoCatAdbHelper.cs)

## 사용 방법

1. 휴대폰 또는 태블릿에 Google Play의 ResoCat을 설치합니다.
2. 기기의 개발자 옵션에서 USB 디버깅을 켭니다. 개발자 옵션은 보통 설정 → 휴대전화 정보 → 빌드 번호를 7회 누르면 활성화됩니다. 제조사에 따라 메뉴 이름이 다릅니다.
3. 데이터 전송이 가능한 USB 케이블로 PC에 연결하고 기기 잠금을 풉니다.
4. 기기에 뜨는 USB 디버깅 허용 창에서 이 컴퓨터를 허용합니다. 공용 PC에서는 항상 허용을 선택하지 마세요.
5. 공식 GitHub에서 받은 `ResoCat-ADB-Helper.exe`를 실행합니다.
6. 기기를 선택하고 **Set permissions and open ResoCat** (권한 설정 및 ResoCat 실행)을 누릅니다. 한 대만 연결되어 있으면 자동 선택됩니다.
7. 완료 메시지를 확인하고 기기의 ResoCat에서 이용약관과 남은 설정을 직접 확인합니다. 이후 USB 연결을 해제해도 됩니다.

### 버튼 안내

- **Refresh devices** — 기기를 찾거나 목록을 새로고침합니다.
- **Set permissions and open ResoCat** — 선택한 기기의 권한을 설정하고 ResoCat을 실행합니다. 이 버튼을 누르면 설정이 진행됩니다.
- **Save result** — 도움이 필요할 때 결과 로그를 TXT 파일로 저장합니다. 권한 설정에 필수는 아닙니다.

연결 문제: `unauthorized`는 기기 잠금을 풀고 USB 디버깅을 허용한 뒤 **Refresh devices** (기기 새로고침)을 누르세요. `offline`은 USB를 다시 연결하세요. 기기가 없으면 USB 디버깅·데이터 케이블·제조사 USB 드라이버를 확인하세요. 일부 완료 메시지가 나오면 ResoCat이 안내하는 Android 설정에서 사용정보 접근을 직접 허용하세요. 회사·학교 기기 정책이나 제조사 제한은 우회하지 않습니다.

Windows 경고: 이 프로그램은 코드 서명되지 않아 SmartScreen의 ‘Windows의 PC 보호’가 표시될 수 있습니다. 공식 다운로드 주소와 SHA-256을 확인하고 신뢰하는 파일에 한해서 ‘추가 정보 → 실행’을 선택하세요.

변경 항목: 현재 Android 사용자의 ResoCat(`app.resocat.switcher`)에 해상도 변경 권한 `WRITE_SECURE_SETTINGS`와 사용정보 접근 `GET_USAGE_STATS`만 설정합니다. 루팅이나 PC 관리자 권한은 필요하지 않습니다. 해상도·DPI 값, 광고·결제, 배터리 설정은 변경하지 않으며 앱을 설치하거나 데이터를 삭제하지 않습니다. 서버로 데이터를 전송하지 않습니다. **Save result** (결과 저장)을 눌러 저장한 TXT에는 기기 식별자가 포함될 수 있습니다. 문제가 있으면 해당 TXT를 지원 담당자에게 직접 보내세요. USB 디버깅은 설정이 끝난 뒤 꺼도 됩니다.

## 문의

[홈페이지](https://seokiapps.com/) · [문의하기](https://seokiapps.com/en/support/)

---

<a id="zh"></a>
## zh

为每个 Android 应用设置自定义屏幕分辨率。

[Google Play](https://play.google.com/store/apps/details?id=app.resocat.switcher)

## 下载

[![Windows Download EXE](https://img.shields.io/badge/Windows-Download_EXE-6b4ca5?style=for-the-badge&labelColor=555555)](https://github.com/Seoki0903-forest/resocat-privacy/raw/refs/heads/main/downloads/ResoCat-ADB-Helper.exe)

**ResoCat USB Permission Helper 1.0.3**

这是一款免费工具，用于通过 Windows 电脑和 USB 为 Android 手机或平板上的 ResoCat 设置初始权限。需要 64 位 Windows 10/11 和 .NET Framework 4.5 或更高版本。只需下载这一个 EXE。首次使用需要联网：程序会直接从 Google 官方服务器自动下载 Android platform-tools 37.0.1，并在使用前验证 SHA-256。验证后的工具保存在 `%LOCALAPPDATA%\ResoCat\platform-tools-37.0.1`，以后可离线使用。不再将 ADB 内嵌于 EXE 或从临时文件夹运行。程序界面在所有 Windows 系统上均显示英语。本指南提供 ResoCat 支持的全部 13 种语言。

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

---

<a id="ja"></a>
## ja

Android アプリごとに好きな画面解像度を設定できます。

[Google Play](https://play.google.com/store/apps/details?id=app.resocat.switcher)

## ダウンロード

[![Windows Download EXE](https://img.shields.io/badge/Windows-Download_EXE-6b4ca5?style=for-the-badge&labelColor=555555)](https://github.com/Seoki0903-forest/resocat-privacy/raw/refs/heads/main/downloads/ResoCat-ADB-Helper.exe)

**ResoCat USB Permission Helper 1.0.3**

Windows PC と USB 接続した Android スマートフォン・タブレットで、ResoCat の初期権限を設定する無料ツールです。64 ビット版 Windows 10/11 と .NET Framework 4.5 以上が必要です。ダウンロードするのは EXE 1個だけです。初回はインターネット接続が必要です。Google 公式サーバーから Android platform-tools 37.0.1 を自動取得し、使用前に SHA-256 を検証します。検証済みのツールは `%LOCALAPPDATA%\ResoCat\platform-tools-37.0.1` に保存され、次回からオフラインでも使用できます。ADB の EXE への埋め込みと一時フォルダーからの実行を廃止しました。プログラムの表示はすべての Windows で英語です。このガイドは ResoCat の全 13 対応言語で提供しています。

[SHA-256](downloads/SHA256SUMS.txt) · [ソースコード](usb-helper/source/ResoCatAdbHelper.cs)

## 使い方

1. Android 端末に Google Play から ResoCat をインストールします。
2. 開発者向けオプションで USB デバッグを有効にします。通常は設定 → デバイス情報の「ビルド番号」を 7 回タップすると開発者向けオプションが表示されます。名称はメーカーによって異なります。
3. データ転送対応の USB ケーブルで PC に接続し、端末のロックを解除します。
4. 端末の USB デバッグ確認で、この PC を許可します。共有 PC では「常に許可」を選ばないでください。
5. 公式 GitHub からダウンロードした `ResoCat-ADB-Helper.exe` を実行します。
6. 端末を選び、**Set permissions and open ResoCat** を押します。接続端末が 1 台の場合は自動選択されます。
7. 完了メッセージを確認し、端末の ResoCat で利用規約と残りの設定を自分で確認します。その後 USB を取り外せます。

### ボタンの説明

- **Refresh devices** — 端末を検索し、一覧を更新します。
- **Set permissions and open ResoCat** — 選択した端末に権限を設定して ResoCat を起動します。このボタンで設定を開始します。
- **Save result** — サポートが必要な場合に結果ログを TXT として保存します。必須ではありません。

接続の問題：`unauthorized` の場合は端末のロックを解除して USB デバッグを許可し、**Refresh devices** を押してください。`offline` の場合は USB を接続し直してください。端末が表示されない場合は USB デバッグ、ケーブル、メーカーの USB ドライバーを確認します。一部完了の場合は ResoCat の案内に従って Android 設定で使用状況へのアクセスを許可してください。メーカーや管理端末の制限は回避しません。

Windows の警告：コード署名がないため「Windows によって PC が保護されました」が表示される場合があります。公式のダウンロード元と SHA-256 を確認し、信頼できるファイルに限り「詳細情報 → 実行」を選んでください。

変更内容：現在の Android ユーザーの ResoCat（`app.resocat.switcher`）に `WRITE_SECURE_SETTINGS` と `GET_USAGE_STATS` のみを設定します。root や PC 管理者権限は不要です。解像度・DPI、広告・課金、バッテリー設定は変更せず、アプリのインストールやデータ削除、サーバーへの送信もしません。**Save result** の TXT に端末識別情報が含まれる場合があります。必要なら自分でサポート担当者に送ってください。設定後は USB デバッグを無効にできます。

## お問い合わせ

[公式サイト](https://seokiapps.com/) · [お問い合わせフォーム](https://seokiapps.com/en/support/)

---

<a id="id"></a>
## id

Atur resolusi layar khusus untuk setiap aplikasi Android.

[Google Play](https://play.google.com/store/apps/details?id=app.resocat.switcher)

## Unduh

[![Windows Download EXE](https://img.shields.io/badge/Windows-Download_EXE-6b4ca5?style=for-the-badge&labelColor=555555)](https://github.com/Seoki0903-forest/resocat-privacy/raw/refs/heads/main/downloads/ResoCat-ADB-Helper.exe)

**ResoCat USB Permission Helper 1.0.3**

Alat gratis untuk mengatur izin awal ResoCat pada ponsel atau tablet Android melalui USB dari PC Windows. Memerlukan Windows 10/11 64-bit dan .NET Framework 4.5+. Cukup unduh satu EXE ini. Penggunaan pertama memerlukan Internet: program mengunduh Android platform-tools 37.0.1 langsung dari server resmi Google dan memverifikasi SHA-256 sebelum digunakan. Alat yang telah diverifikasi disimpan di `%LOCALAPPDATA%\ResoCat\platform-tools-37.0.1` untuk penggunaan luring berikutnya. ADB tidak lagi disematkan dalam EXE atau dijalankan dari folder sementara. Antarmuka program menggunakan bahasa Inggris pada semua sistem Windows. Panduan ini tersedia dalam 13 bahasa ResoCat.

[SHA-256](downloads/SHA256SUMS.txt) · [Kode sumber](usb-helper/source/ResoCatAdbHelper.cs)

## Petunjuk penggunaan

1. Instal ResoCat dari Google Play pada perangkat Android.
2. Aktifkan debugging USB di Opsi developer. Biasanya, ketuk Setelan → Tentang ponsel → Nomor build tujuh kali untuk mengaktifkan Opsi developer. Nama menu berbeda menurut produsen.
3. Hubungkan dengan kabel USB untuk transfer data dan buka kunci perangkat.
4. Izinkan komputer ini pada permintaan debugging USB di perangkat. Jangan pilih “Selalu izinkan” pada PC bersama.
5. Jalankan `ResoCat-ADB-Helper.exe` dari repositori GitHub resmi.
6. Pilih perangkat lalu klik **Set permissions and open ResoCat**. Jika hanya satu perangkat terhubung, perangkat dipilih otomatis.
7. Periksa pesan selesai dan tinjau sendiri ketentuan serta pengaturan lain di ResoCat. Setelah itu USB dapat dilepas.

### Panduan tombol

- **Refresh devices** — Cari perangkat atau perbarui daftar.
- **Set permissions and open ResoCat** — Atur izin pada perangkat yang dipilih dan buka ResoCat. Klik tombol ini untuk memulai pengaturan.
- **Save result** — Simpan log hasil sebagai TXT jika membutuhkan bantuan. Langkah ini opsional.

Masalah koneksi: Untuk `unauthorized`, buka kunci perangkat, izinkan debugging USB, lalu klik **Refresh devices**. Untuk `offline`, sambungkan ulang USB. Jika perangkat tidak muncul, periksa debugging USB, kabel data dan driver USB produsen. Jika hanya sebagian selesai, aktifkan akses penggunaan melalui pengaturan Android yang ditunjukkan ResoCat. Alat tidak melewati pembatasan produsen atau kebijakan perangkat kantor/sekolah.

Peringatan Windows: Program belum ditandatangani dan dapat menampilkan “Windows protected your PC”. Periksa URL unduhan resmi dan SHA-256; pilih “More info → Run anyway” hanya untuk berkas yang Anda percayai.

Perubahan: Hanya `WRITE_SECURE_SETTINGS` dan `GET_USAGE_STATS` untuk ResoCat (`app.resocat.switcher`) pada pengguna Android aktif. Tidak perlu root atau hak administrator PC. Tidak mengubah nilai resolusi/DPI, iklan, pembayaran atau pengaturan baterai, memasang aplikasi, menghapus data, atau mengirim data ke server. TXT dari **Save result** dapat memuat identitas perangkat; kirim sendiri ke dukungan bila perlu. Debugging USB dapat dimatikan setelah pengaturan selesai.

## Kontak

[Situs web](https://seokiapps.com/) · [Hubungi kami](https://seokiapps.com/en/support/)

---

<a id="es"></a>
## es

Configura una resolución de pantalla para cada aplicación Android.

[Google Play](https://play.google.com/store/apps/details?id=app.resocat.switcher)

## Descargar

[![Windows Download EXE](https://img.shields.io/badge/Windows-Download_EXE-6b4ca5?style=for-the-badge&labelColor=555555)](https://github.com/Seoki0903-forest/resocat-privacy/raw/refs/heads/main/downloads/ResoCat-ADB-Helper.exe)

**ResoCat USB Permission Helper 1.0.3**

Herramienta gratuita para configurar los permisos iniciales de ResoCat en un teléfono o tableta Android conectado por USB a un PC Windows. Requiere Windows 10/11 de 64 bits y .NET Framework 4.5+. Solo tienes que descargar este EXE. El primer uso requiere Internet: descarga automáticamente Android platform-tools 37.0.1 directamente de Google y verifica SHA-256 antes de usarlo. Las herramientas verificadas se guardan en `%LOCALAPPDATA%\ResoCat\platform-tools-37.0.1` para usarlas después sin conexión. ADB ya no se integra en el EXE ni se ejecuta desde una carpeta temporal. La interfaz del programa está en inglés en todos los sistemas Windows. Esta guía cubre los 13 idiomas de ResoCat.

[SHA-256](downloads/SHA256SUMS.txt) · [Código fuente](usb-helper/source/ResoCatAdbHelper.cs)

## Instrucciones de uso

1. Instala ResoCat desde Google Play en el dispositivo Android.
2. Activa la depuración USB en Opciones de desarrollador. Normalmente se habilitan tocando siete veces Ajustes → Información del teléfono → Número de compilación. Los nombres varían según el fabricante.
3. Conecta un cable USB de datos y desbloquea el dispositivo.
4. Autoriza este ordenador en el aviso de depuración USB del dispositivo. No marques “Permitir siempre” en un PC compartido.
5. Ejecuta `ResoCat-ADB-Helper.exe` descargado del repositorio oficial de GitHub.
6. Selecciona el dispositivo y pulsa **Set permissions and open ResoCat**. Si solo hay uno conectado, se selecciona automáticamente.
7. Comprueba el mensaje de finalización y revisa personalmente los términos y ajustes restantes en ResoCat. Después puedes desconectar el USB.

### Botones

- **Refresh devices** — Busca dispositivos o actualiza la lista.
- **Set permissions and open ResoCat** — Configura los permisos del dispositivo seleccionado y abre ResoCat. Pulsa este botón para iniciar la configuración.
- **Save result** — Guarda el registro de resultados en un TXT si necesitas ayuda. Es opcional.

Problemas de conexión: Para `unauthorized`, desbloquea el dispositivo, autoriza la depuración y pulsa **Refresh devices**. Para `offline`, reconecta el USB. Si no aparece ningún dispositivo, comprueba la depuración USB, el cable y los controladores USB del fabricante. Si el resultado es parcial, habilita el acceso de uso en los ajustes Android indicados por ResoCat. No se eluden restricciones del fabricante ni políticas de dispositivos administrados.

Aviso de Windows: El programa no tiene firma digital y puede mostrar “Windows protegió su PC”. Verifica la URL oficial y el SHA-256; elige “Más información → Ejecutar de todas formas” solo si confías en el archivo.

Cambios: Solo configura `WRITE_SECURE_SETTINGS` y `GET_USAGE_STATS` para ResoCat (`app.resocat.switcher`) en el usuario Android activo. No requiere root ni permisos de administrador del PC. No cambia resolución/DPI, anuncios, pagos ni batería; no instala aplicaciones, borra datos ni envía datos a servidores. El TXT de **Save result** puede incluir identificadores del dispositivo; envíalo tú mismo al soporte si lo necesitas. Puedes desactivar la depuración USB al terminar.

## Contacto

[Sitio web](https://seokiapps.com/) · [Contáctanos](https://seokiapps.com/en/support/)

---

<a id="pt-br"></a>
## pt-BR

Defina uma resolução de tela personalizada para cada aplicativo Android.

[Google Play](https://play.google.com/store/apps/details?id=app.resocat.switcher)

## Download

[![Windows Download EXE](https://img.shields.io/badge/Windows-Download_EXE-6b4ca5?style=for-the-badge&labelColor=555555)](https://github.com/Seoki0903-forest/resocat-privacy/raw/refs/heads/main/downloads/ResoCat-ADB-Helper.exe)

**ResoCat USB Permission Helper 1.0.3**

Ferramenta gratuita para configurar as permissões iniciais do ResoCat em um celular ou tablet Android conectado por USB a um PC Windows. Requer Windows 10/11 de 64 bits e .NET Framework 4.5+. Basta baixar este único EXE. O primeiro uso requer Internet: o programa baixa automaticamente o Android platform-tools 37.0.1 diretamente do Google e verifica o SHA-256 antes do uso. As ferramentas verificadas ficam em `%LOCALAPPDATA%\ResoCat\platform-tools-37.0.1` para uso posterior sem conexão. O ADB não é mais incorporado ao EXE nem executado de uma pasta temporária. A interface do programa está em inglês em todos os sistemas Windows. Este guia abrange os 13 idiomas do ResoCat.

[SHA-256](downloads/SHA256SUMS.txt) · [Código-fonte](usb-helper/source/ResoCatAdbHelper.cs)

## Como usar

1. Instale o ResoCat pelo Google Play no dispositivo Android.
2. Ative a depuração USB nas Opções do desenvolvedor. Normalmente, toque sete vezes em Configurações → Sobre o telefone → Número da versão para ativá-las. Os nomes variam conforme o fabricante.
3. Conecte um cabo USB de dados e desbloqueie o dispositivo.
4. Autorize este computador no aviso de depuração USB do dispositivo. Não selecione “Sempre permitir” em um PC compartilhado.
5. Execute `ResoCat-ADB-Helper.exe` baixado do repositório oficial no GitHub.
6. Selecione o dispositivo e clique em **Set permissions and open ResoCat**. Se houver apenas um dispositivo, ele será selecionado automaticamente.
7. Confira a mensagem de conclusão e revise os termos e demais configurações no ResoCat. Depois, pode desconectar o USB.

### Botões

- **Refresh devices** — Procura dispositivos ou atualiza a lista.
- **Set permissions and open ResoCat** — Configura as permissões do dispositivo selecionado e abre o ResoCat. Clique neste botão para iniciar a configuração.
- **Save result** — Salva o registro do resultado em TXT se precisar de suporte. É opcional.

Problemas de conexão: Para `unauthorized`, desbloqueie o dispositivo, autorize a depuração e clique em **Refresh devices**. Para `offline`, reconecte o USB. Se nenhum dispositivo aparecer, confira a depuração USB, o cabo e os drivers USB do fabricante. Se a conclusão for parcial, permita o acesso ao uso nas configurações Android indicadas pelo ResoCat. Restrições do fabricante e políticas de dispositivos gerenciados não são contornadas.

Aviso do Windows: O programa não tem assinatura digital e pode exibir “O Windows protegeu o computador”. Confira a URL oficial e o SHA-256; escolha “Mais informações → Executar assim mesmo” somente para um arquivo em que você confia.

Alterações: Somente `WRITE_SECURE_SETTINGS` e `GET_USAGE_STATS` do ResoCat (`app.resocat.switcher`) no usuário Android ativo. Não exige root nem administrador do PC. Não muda resolução/DPI, anúncios, pagamentos ou bateria, não instala aplicativos, não apaga dados e não envia dados a servidores. O TXT de **Save result** pode incluir identificadores do dispositivo; envie-o ao suporte por conta própria se necessário. A depuração USB pode ser desativada depois da configuração.

## Contato

[Site](https://seokiapps.com/) · [Fale conosco](https://seokiapps.com/en/support/)

---

<a id="vi"></a>
## vi

Đặt độ phân giải màn hình riêng cho từng ứng dụng Android.

[Google Play](https://play.google.com/store/apps/details?id=app.resocat.switcher)

## Tải xuống

[![Windows Download EXE](https://img.shields.io/badge/Windows-Download_EXE-6b4ca5?style=for-the-badge&labelColor=555555)](https://github.com/Seoki0903-forest/resocat-privacy/raw/refs/heads/main/downloads/ResoCat-ADB-Helper.exe)

**ResoCat USB Permission Helper 1.0.3**

Công cụ miễn phí để cấp quyền ban đầu cho ResoCat trên điện thoại hoặc máy tính bảng Android kết nối với máy tính Windows qua USB. Yêu cầu Windows 10/11 64-bit và .NET Framework 4.5 trở lên. Chỉ cần tải một tệp EXE này. Lần đầu cần Internet: chương trình tự tải Android platform-tools 37.0.1 trực tiếp từ máy chủ chính thức của Google và kiểm tra SHA-256 trước khi dùng. Công cụ đã xác minh được lưu tại `%LOCALAPPDATA%\ResoCat\platform-tools-37.0.1` để dùng ngoại tuyến về sau. ADB không còn được nhúng trong EXE hoặc chạy từ thư mục tạm. Giao diện chương trình dùng tiếng Anh trên mọi hệ thống Windows. Hướng dẫn có đủ 13 ngôn ngữ của ResoCat.

[SHA-256](downloads/SHA256SUMS.txt) · [Mã nguồn](usb-helper/source/ResoCatAdbHelper.cs)

## Hướng dẫn sử dụng

1. Cài ResoCat từ Google Play trên thiết bị Android.
2. Bật gỡ lỗi USB trong Tùy chọn nhà phát triển. Thông thường, nhấn bảy lần vào Cài đặt → Giới thiệu điện thoại → Số bản dựng để bật mục này. Tên menu tùy nhà sản xuất.
3. Kết nối bằng cáp USB hỗ trợ truyền dữ liệu và mở khóa thiết bị.
4. Cho phép máy tính này trong hộp thoại gỡ lỗi USB trên thiết bị. Không chọn “Luôn cho phép” trên máy tính dùng chung.
5. Chạy `ResoCat-ADB-Helper.exe` tải từ kho GitHub chính thức.
6. Chọn thiết bị rồi nhấn **Set permissions and open ResoCat**. Nếu chỉ có một thiết bị, công cụ tự chọn.
7. Kiểm tra thông báo hoàn tất, rồi tự xem điều khoản và các cài đặt còn lại trong ResoCat. Sau đó có thể rút USB.

### Hướng dẫn các nút

- **Refresh devices** — Tìm thiết bị hoặc làm mới danh sách.
- **Set permissions and open ResoCat** — Cấp quyền cho thiết bị đã chọn và mở ResoCat. Nhấn nút này để bắt đầu thiết lập.
- **Save result** — Lưu nhật ký kết quả thành tệp TXT nếu cần hỗ trợ. Bước này không bắt buộc.

Lỗi kết nối: Với `unauthorized`, mở khóa, cho phép gỡ lỗi USB rồi nhấn **Refresh devices**. Với `offline`, kết nối lại USB. Nếu không có thiết bị, kiểm tra gỡ lỗi USB, cáp dữ liệu và trình điều khiển USB của nhà sản xuất. Nếu chỉ hoàn tất một phần, bật quyền truy cập dữ liệu sử dụng trong cài đặt Android do ResoCat hướng dẫn. Công cụ không vượt qua giới hạn của nhà sản xuất hoặc chính sách thiết bị được quản lý.

Cảnh báo Windows: Chương trình chưa được ký số và có thể hiện “Windows protected your PC”. Kiểm tra địa chỉ tải chính thức và SHA-256; chỉ chọn “More info → Run anyway” nếu bạn tin cậy tệp.

Thay đổi: Chỉ cấp `WRITE_SECURE_SETTINGS` và `GET_USAGE_STATS` cho ResoCat (`app.resocat.switcher`) của người dùng Android hiện tại. Không cần root hay quyền quản trị máy tính. Không đổi độ phân giải/DPI, quảng cáo, thanh toán hoặc pin, không cài ứng dụng, xóa dữ liệu hay gửi dữ liệu đến máy chủ. TXT từ **Save result** có thể chứa mã nhận dạng thiết bị; hãy tự gửi cho bộ phận hỗ trợ khi cần. Có thể tắt gỡ lỗi USB sau khi hoàn tất.

## Liên hệ

[Trang web](https://seokiapps.com/) · [Liên hệ với chúng tôi](https://seokiapps.com/en/support/)

---

<a id="th"></a>
## th

ตั้งค่าความละเอียดหน้าจอแยกสำหรับแต่ละแอป Android

[Google Play](https://play.google.com/store/apps/details?id=app.resocat.switcher)

## ดาวน์โหลด

[![Windows Download EXE](https://img.shields.io/badge/Windows-Download_EXE-6b4ca5?style=for-the-badge&labelColor=555555)](https://github.com/Seoki0903-forest/resocat-privacy/raw/refs/heads/main/downloads/ResoCat-ADB-Helper.exe)

**ResoCat USB Permission Helper 1.0.3**

เครื่องมือฟรีสำหรับตั้งค่าสิทธิ์เริ่มต้นของ ResoCat บนโทรศัพท์หรือแท็บเล็ต Android ที่เชื่อมต่อกับพีซี Windows ผ่าน USB ต้องใช้ Windows 10/11 แบบ 64 บิต และ .NET Framework 4.5 ขึ้นไป ดาวน์โหลดเพียง EXE ไฟล์เดียว การใช้งานครั้งแรกต้องเชื่อมต่ออินเทอร์เน็ต โปรแกรมจะดาวน์โหลด Android platform-tools 37.0.1 จากเซิร์ฟเวอร์ทางการของ Google โดยตรงและตรวจสอบ SHA-256 ก่อนใช้งาน เครื่องมือที่ตรวจสอบแล้วจะเก็บไว้ใน `%LOCALAPPDATA%\ResoCat\platform-tools-37.0.1` เพื่อใช้งานแบบออฟไลน์ในครั้งต่อไป ไม่มีการฝัง ADB ใน EXE หรือเรียกใช้จากโฟลเดอร์ชั่วคราวอีกต่อไป หน้าจอโปรแกรมเป็นภาษาอังกฤษบน Windows ทุกระบบ คู่มือนี้มีครบทั้ง 13 ภาษาที่ ResoCat รองรับ

[SHA-256](downloads/SHA256SUMS.txt) · [ซอร์สโค้ด](usb-helper/source/ResoCatAdbHelper.cs)

## วิธีใช้งาน

1. ติดตั้ง ResoCat จาก Google Play บนอุปกรณ์ Android
2. เปิดการแก้ไขข้อบกพร่อง USB ในตัวเลือกสำหรับนักพัฒนา โดยทั่วไปให้แตะการตั้งค่า → เกี่ยวกับโทรศัพท์ → หมายเลขบิลด์เจ็ดครั้งเพื่อเปิดตัวเลือกนี้ ชื่อเมนูอาจต่างกันตามผู้ผลิต
3. เชื่อมต่อด้วยสาย USB ที่ส่งข้อมูลได้ แล้วปลดล็อกอุปกรณ์
4. อนุญาตคอมพิวเตอร์นี้ในข้อความขออนุญาตการแก้ไขข้อบกพร่อง USB บนอุปกรณ์ อย่าเลือกอนุญาตเสมอบนพีซีที่ใช้ร่วมกัน
5. เปิด `ResoCat-ADB-Helper.exe` ที่ดาวน์โหลดจาก GitHub ทางการ
6. เลือกอุปกรณ์แล้วกด **Set permissions and open ResoCat** หากเชื่อมต่อเพียงเครื่องเดียวจะเลือกให้อัตโนมัติ
7. ตรวจสอบข้อความเสร็จสิ้น และตรวจสอบข้อกำหนดกับการตั้งค่าที่เหลือใน ResoCat ด้วยตนเอง จากนั้นถอด USB ได้

### คำอธิบายปุ่ม

- **Refresh devices** — ค้นหาอุปกรณ์หรือรีเฟรชรายการ
- **Set permissions and open ResoCat** — ตั้งค่าสิทธิ์บนอุปกรณ์ที่เลือกและเปิด ResoCat กดปุ่มนี้เพื่อเริ่มตั้งค่า
- **Save result** — บันทึกผลลัพธ์เป็นไฟล์ TXT หากต้องการความช่วยเหลือ ขั้นตอนนี้ไม่บังคับ

ปัญหาการเชื่อมต่อ: หากขึ้น `unauthorized` ให้ปลดล็อกและอนุญาตการแก้ไขข้อบกพร่อง USB แล้วกด **Refresh devices** หากขึ้น `offline` ให้เชื่อมต่อ USB ใหม่ หากไม่พบอุปกรณ์ ให้ตรวจสอบการแก้ไขข้อบกพร่อง USB สายข้อมูล และไดรเวอร์ USB ของผู้ผลิต หากเสร็จเพียงบางส่วน ให้เปิดสิทธิ์เข้าถึงข้อมูลการใช้งานในการตั้งค่า Android ตามที่ ResoCat แนะนำ เครื่องมือไม่ข้ามข้อจำกัดของผู้ผลิตหรือนโยบายอุปกรณ์ที่มีผู้ดูแล

คำเตือน Windows: โปรแกรมยังไม่มีลายเซ็นดิจิทัล จึงอาจแสดง “Windows protected your PC” ตรวจสอบ URL ดาวน์โหลดทางการและ SHA-256 แล้วเลือก “More info → Run anyway” เฉพาะไฟล์ที่คุณเชื่อถือ

สิ่งที่เปลี่ยน: ตั้งค่าเฉพาะ `WRITE_SECURE_SETTINGS` และ `GET_USAGE_STATS` ให้ ResoCat (`app.resocat.switcher`) ของผู้ใช้ Android ปัจจุบัน ไม่ต้องรูทหรือใช้สิทธิ์ผู้ดูแลพีซี ไม่เปลี่ยนความละเอียด/DPI โฆษณา การชำระเงิน หรือแบตเตอรี่ ไม่ติดตั้งแอป ลบข้อมูล หรือส่งข้อมูลไปยังเซิร์ฟเวอร์ TXT จาก **Save result** อาจมีรหัสอุปกรณ์ หากต้องการความช่วยเหลือให้ส่งไฟล์เอง หลังตั้งค่าเสร็จสามารถปิดการแก้ไขข้อบกพร่อง USB ได้

## ติดต่อ

[เว็บไซต์](https://seokiapps.com/) · [ติดต่อเรา](https://seokiapps.com/en/support/)

---

<a id="ru"></a>
## ru

Настройте разрешение экрана отдельно для каждого приложения Android.

[Google Play](https://play.google.com/store/apps/details?id=app.resocat.switcher)

## Скачать

[![Windows Download EXE](https://img.shields.io/badge/Windows-Download_EXE-6b4ca5?style=for-the-badge&labelColor=555555)](https://github.com/Seoki0903-forest/resocat-privacy/raw/refs/heads/main/downloads/ResoCat-ADB-Helper.exe)

**ResoCat USB Permission Helper 1.0.3**

Бесплатная утилита для первоначальной настройки разрешений ResoCat на телефоне или планшете Android, подключённом по USB к ПК Windows. Нужны 64-разрядная Windows 10/11 и .NET Framework 4.5+. Достаточно скачать один EXE. При первом использовании нужен Интернет: программа автоматически загружает Android platform-tools 37.0.1 прямо с официального сервера Google и проверяет SHA-256 перед использованием. Проверенные файлы сохраняются в `%LOCALAPPDATA%\ResoCat\platform-tools-37.0.1` для дальнейшей работы без сети. ADB больше не встроен в EXE и не запускается из временной папки. Интерфейс программы на всех системах Windows отображается на английском. Руководство доступно на всех 13 языках ResoCat.

[SHA-256](downloads/SHA256SUMS.txt) · [Исходный код](usb-helper/source/ResoCatAdbHelper.cs)

## Инструкция

1. Установите ResoCat из Google Play на устройство Android.
2. Включите отладку по USB в параметрах разработчика. Обычно для их открытия нужно семь раз нажать Настройки → О телефоне → Номер сборки. Названия зависят от производителя.
3. Подключите USB-кабель для передачи данных и разблокируйте устройство.
4. Разрешите этот компьютер в запросе отладки по USB на устройстве. На общем ПК не выбирайте «Всегда разрешать».
5. Запустите `ResoCat-ADB-Helper.exe`, скачанный из официального репозитория GitHub.
6. Выберите устройство и нажмите **Set permissions and open ResoCat**. Если подключено одно устройство, оно выбирается автоматически.
7. Проверьте сообщение о завершении и самостоятельно ознакомьтесь с условиями и остальными настройками в ResoCat. Затем можно отключить USB.

### Кнопки

- **Refresh devices** — Найти устройства или обновить список.
- **Set permissions and open ResoCat** — Настроить разрешения на выбранном устройстве и открыть ResoCat. Нажмите эту кнопку, чтобы начать настройку.
- **Save result** — Сохранить журнал результата в TXT, если нужна помощь. Это необязательно.

Проблемы подключения: При `unauthorized` разблокируйте устройство, разрешите отладку и нажмите **Refresh devices**. При `offline` переподключите USB. Если устройств нет, проверьте отладку, кабель и USB-драйвер производителя. При частичном завершении разрешите доступ к статистике использования в настройках Android, указанных ResoCat. Ограничения производителя и политики управляемых устройств не обходятся.

Предупреждение Windows: Программа не имеет цифровой подписи и может вызвать «Система Windows защитила ваш компьютер». Проверьте официальный адрес загрузки и SHA-256; выбирайте «Подробнее → Выполнить в любом случае» только для доверенного файла.

Изменения: Только `WRITE_SECURE_SETTINGS` и `GET_USAGE_STATS` для ResoCat (`app.resocat.switcher`) у текущего пользователя Android. Root и права администратора ПК не нужны. Разрешение/DPI, реклама, платежи и батарея не изменяются; приложения не устанавливаются, данные не удаляются и не отправляются на сервер. TXT из **Save result** может содержать идентификаторы устройства; при необходимости отправьте его поддержке самостоятельно. После настройки отладку по USB можно отключить.

## Контакты

[Сайт](https://seokiapps.com/) · [Связаться с нами](https://seokiapps.com/en/support/)

---

<a id="de"></a>
## de

Lege für jede Android-App eine eigene Bildschirmauflösung fest.

[Google Play](https://play.google.com/store/apps/details?id=app.resocat.switcher)

## Download

[![Windows Download EXE](https://img.shields.io/badge/Windows-Download_EXE-6b4ca5?style=for-the-badge&labelColor=555555)](https://github.com/Seoki0903-forest/resocat-privacy/raw/refs/heads/main/downloads/ResoCat-ADB-Helper.exe)

**ResoCat USB Permission Helper 1.0.3**

Kostenloses Werkzeug zum Einrichten der anfänglichen ResoCat-Berechtigungen auf einem Android-Handy oder -Tablet, das per USB mit einem Windows-PC verbunden ist. Benötigt 64-Bit-Windows 10/11 und .NET Framework 4.5+. Du brauchst nur diese eine EXE herunterzuladen. Beim ersten Start ist Internet erforderlich: Android platform-tools 37.0.1 wird automatisch direkt von Google geladen und vor der Nutzung per SHA-256 geprüft. Geprüfte Dateien werden unter `%LOCALAPPDATA%\ResoCat\platform-tools-37.0.1` für die spätere Offline-Nutzung gespeichert. ADB ist nicht mehr in der EXE eingebettet und wird nicht aus einem temporären Ordner gestartet. Die Programmoberfläche ist auf allen Windows-Systemen auf Englisch. Diese Anleitung enthält alle 13 ResoCat-Sprachen.

[SHA-256](downloads/SHA256SUMS.txt) · [Quellcode](usb-helper/source/ResoCatAdbHelper.cs)

## Anleitung

1. Installiere ResoCat über Google Play auf dem Android-Gerät.
2. Aktiviere USB-Debugging in den Entwickleroptionen. Diese werden meist durch siebenmaliges Tippen auf Einstellungen → Über das Telefon → Build-Nummer aktiviert. Menübezeichnungen variieren je nach Hersteller.
3. Verbinde ein USB-Datenkabel und entsperre das Gerät.
4. Erlaube diesen Computer in der USB-Debugging-Abfrage auf dem Gerät. Wähle auf gemeinsam genutzten PCs nicht „Immer zulassen“.
5. Starte `ResoCat-ADB-Helper.exe` aus dem offiziellen GitHub-Repository.
6. Wähle dein Gerät und klicke auf **Set permissions and open ResoCat**. Ein einzelnes verbundenes Gerät wird automatisch ausgewählt.
7. Prüfe die Abschlussmeldung und bestätige die Bedingungen und übrigen Einstellungen selbst in ResoCat. Danach kannst du USB trennen.

### Schaltflächen

- **Refresh devices** — Geräte suchen oder die Liste aktualisieren.
- **Set permissions and open ResoCat** — Berechtigungen auf dem ausgewählten Gerät einrichten und ResoCat starten. Klicke auf diese Schaltfläche, um die Einrichtung zu starten.
- **Save result** — Das Ergebnisprotokoll bei Bedarf als TXT für den Support speichern. Dies ist optional.

Verbindungsprobleme: Bei `unauthorized` Gerät entsperren, USB-Debugging erlauben und **Refresh devices** klicken. Bei `offline` USB neu verbinden. Wenn kein Gerät erscheint, USB-Debugging, Datenkabel und Hersteller-USB-Treiber prüfen. Bei teilweisem Abschluss den Zugriff auf Nutzungsdaten in den von ResoCat angegebenen Android-Einstellungen erlauben. Herstellerbeschränkungen und Richtlinien verwalteter Geräte werden nicht umgangen.

Windows-Warnung: Das Programm ist nicht digital signiert und kann „Der Computer wurde durch Windows geschützt“ auslösen. Offizielle Download-URL und SHA-256 prüfen; „Weitere Informationen → Trotzdem ausführen“ nur für eine vertrauenswürdige Datei wählen.

Änderungen: Nur `WRITE_SECURE_SETTINGS` und `GET_USAGE_STATS` für ResoCat (`app.resocat.switcher`) beim aktiven Android-Benutzer. Root oder PC-Administratorrechte sind nicht nötig. Auflösung/DPI, Werbung, Zahlungen und Akkueinstellungen bleiben unverändert. Keine App-Installation, Datenlöschung oder Übertragung an Server. Die TXT aus **Save result** kann Gerätekennungen enthalten; sende sie bei Bedarf selbst an den Support. USB-Debugging kann danach deaktiviert werden.

## Kontakt

[Website](https://seokiapps.com/) · [Kontakt aufnehmen](https://seokiapps.com/en/support/)

---

<a id="fr"></a>
## fr

Définissez une résolution d’écran pour chaque application Android.

[Google Play](https://play.google.com/store/apps/details?id=app.resocat.switcher)

## Télécharger

[![Windows Download EXE](https://img.shields.io/badge/Windows-Download_EXE-6b4ca5?style=for-the-badge&labelColor=555555)](https://github.com/Seoki0903-forest/resocat-privacy/raw/refs/heads/main/downloads/ResoCat-ADB-Helper.exe)

**ResoCat USB Permission Helper 1.0.3**

Outil gratuit pour configurer les autorisations initiales de ResoCat sur un téléphone ou une tablette Android connecté en USB à un PC Windows. Nécessite Windows 10/11 64 bits et .NET Framework 4.5+. Il suffit de télécharger cet unique EXE. La première utilisation nécessite Internet : le programme télécharge automatiquement Android platform-tools 37.0.1 directement depuis Google et vérifie SHA-256 avant utilisation. Les outils vérifiés sont conservés dans `%LOCALAPPDATA%\ResoCat\platform-tools-37.0.1` pour une utilisation hors ligne ultérieure. ADB n’est plus intégré à l’EXE ni exécuté depuis un dossier temporaire. L’interface du programme est en anglais sur tous les systèmes Windows. Ce guide couvre les 13 langues de ResoCat.

[SHA-256](downloads/SHA256SUMS.txt) · [Code source](usb-helper/source/ResoCatAdbHelper.cs)

## Mode d’emploi

1. Installez ResoCat depuis Google Play sur l’appareil Android.
2. Activez le débogage USB dans les Options pour les développeurs. Généralement, touchez sept fois Paramètres → À propos du téléphone → Numéro de build pour les activer. Les noms varient selon le fabricant.
3. Connectez un câble USB permettant le transfert de données et déverrouillez l’appareil.
4. Autorisez cet ordinateur dans la demande de débogage USB sur l’appareil. Ne cochez pas « Toujours autoriser » sur un PC partagé.
5. Lancez `ResoCat-ADB-Helper.exe` téléchargé depuis le dépôt GitHub officiel.
6. Sélectionnez l’appareil et cliquez sur **Set permissions and open ResoCat**. Un seul appareil connecté est sélectionné automatiquement.
7. Vérifiez le message de fin puis consultez vous-même les conditions et réglages restants dans ResoCat. Vous pouvez ensuite débrancher l’USB.

### Boutons

- **Refresh devices** — Recherche les appareils ou actualise la liste.
- **Set permissions and open ResoCat** — Configure les autorisations de l’appareil sélectionné et ouvre ResoCat. Cliquez sur ce bouton pour lancer la configuration.
- **Save result** — Enregistre le résultat dans un fichier TXT si vous avez besoin d’aide. Cette étape est facultative.

Problèmes de connexion : Pour `unauthorized`, déverrouillez l’appareil, autorisez le débogage et cliquez sur **Refresh devices**. Pour `offline`, reconnectez l’USB. Si aucun appareil n’apparaît, vérifiez le débogage USB, le câble de données et les pilotes USB du fabricant. En cas de résultat partiel, autorisez l’accès aux données d’utilisation dans les paramètres Android indiqués par ResoCat. Les restrictions du fabricant et politiques des appareils gérés ne sont pas contournées.

Avertissement Windows : Ce programme n’est pas signé et peut afficher « Windows a protégé votre ordinateur ». Vérifiez l’URL officielle et le SHA-256 ; choisissez « Informations complémentaires → Exécuter quand même » uniquement pour un fichier de confiance.

Modifications : Uniquement `WRITE_SECURE_SETTINGS` et `GET_USAGE_STATS` pour ResoCat (`app.resocat.switcher`) de l’utilisateur Android actif. Aucun root ni droit administrateur du PC requis. Aucun changement de résolution/DPI, publicité, paiement ou batterie ; aucune installation d’application, suppression de données ou transmission à un serveur. Le TXT de **Save result** peut contenir des identifiants de l’appareil ; envoyez-le vous-même au support si nécessaire. Le débogage USB peut être désactivé après la configuration.

## Contact

[Site web](https://seokiapps.com/) · [Nous contacter](https://seokiapps.com/en/support/)

---

<a id="tr"></a>
## tr

Her Android uygulaması için ayrı ekran çözünürlüğü ayarlayın.

[Google Play](https://play.google.com/store/apps/details?id=app.resocat.switcher)

## İndir

[![Windows Download EXE](https://img.shields.io/badge/Windows-Download_EXE-6b4ca5?style=for-the-badge&labelColor=555555)](https://github.com/Seoki0903-forest/resocat-privacy/raw/refs/heads/main/downloads/ResoCat-ADB-Helper.exe)

**ResoCat USB Permission Helper 1.0.3**

USB ile Windows bilgisayara bağlanan Android telefon veya tablette ResoCat’in başlangıç izinlerini ayarlayan ücretsiz araç. 64 bit Windows 10/11 ve .NET Framework 4.5+ gerekir. Yalnızca bu tek EXE dosyasını indirin. İlk kullanımda İnternet gerekir: program Android platform-tools 37.0.1 dosyalarını doğrudan Google’ın resmî sunucusundan otomatik indirir ve kullanmadan önce SHA-256 ile doğrular. Doğrulanan araçlar, daha sonra çevrimdışı kullanım için `%LOCALAPPDATA%\ResoCat\platform-tools-37.0.1` konumunda saklanır. ADB artık EXE içine gömülmez veya geçici klasörden çalıştırılmaz. Program arayüzü tüm Windows sistemlerinde İngilizcedir. Bu kılavuz ResoCat’in 13 dilini kapsar.

[SHA-256](downloads/SHA256SUMS.txt) · [Kaynak kodu](usb-helper/source/ResoCatAdbHelper.cs)

## Kullanım kılavuzu

1. Android cihazınıza Google Play’den ResoCat’i yükleyin.
2. Geliştirici seçeneklerinde USB hata ayıklamayı açın. Bu seçenekler genellikle Ayarlar → Telefon hakkında → Derleme numarasına yedi kez dokunarak açılır. Menü adları üreticiye göre değişir.
3. Veri aktarımını destekleyen USB kablosuyla bağlayın ve cihazın kilidini açın.
4. Cihazdaki USB hata ayıklama isteminde bu bilgisayara izin verin. Ortak bilgisayarda “Her zaman izin ver” seçmeyin.
5. Resmî GitHub deposundan indirdiğiniz `ResoCat-ADB-Helper.exe` dosyasını çalıştırın.
6. Cihazı seçip **Set permissions and open ResoCat** düğmesine basın. Tek cihaz varsa otomatik seçilir.
7. Tamamlanma mesajını kontrol edin; ResoCat’te koşulları ve kalan ayarları kendiniz inceleyin. Sonra USB bağlantısını kesebilirsiniz.

### Düğmeler

- **Refresh devices** — Cihazları bulur veya listeyi yeniler.
- **Set permissions and open ResoCat** — Seçili cihazın izinlerini ayarlar ve ResoCat’i açar. Kurulumu başlatmak için bu düğmeye basın.
- **Save result** — Desteğe ihtiyaç duyarsanız sonuç günlüğünü TXT olarak kaydeder. Bu adım isteğe bağlıdır.

Bağlantı sorunları: `unauthorized` için cihazın kilidini açın, USB hata ayıklamaya izin verin ve **Refresh devices** düğmesine basın. `offline` için USB’yi yeniden bağlayın. Cihaz yoksa USB hata ayıklamayı, veri kablosunu ve üreticinin USB sürücülerini kontrol edin. Kısmen tamamlanırsa ResoCat’in gösterdiği Android ayarlarında kullanım erişimini açın. Üretici kısıtlamaları veya yönetilen cihaz politikaları aşılmaz.

Windows uyarısı: Program dijital olarak imzalanmamıştır; “Windows bilgisayarınızı korudu” uyarısı çıkabilir. Resmî indirme adresini ve SHA-256’yı kontrol edin; yalnızca güvendiğiniz dosya için “Ek bilgi → Yine de çalıştır” seçin.

Değişiklikler: Yalnızca etkin Android kullanıcısının ResoCat’i (`app.resocat.switcher`) için `WRITE_SECURE_SETTINGS` ve `GET_USAGE_STATS` ayarlanır. Root veya bilgisayar yönetici yetkisi gerekmez. Çözünürlük/DPI, reklam, ödeme ve pil ayarları değiştirilmez; uygulama yüklenmez, veri silinmez veya sunucuya gönderilmez. **Save result** ile kaydedilen TXT cihaz kimliklerini içerebilir; gerektiğinde desteğe kendiniz gönderin. Ayarlar bittikten sonra USB hata ayıklamayı kapatabilirsiniz.

## İletişim

[Web sitesi](https://seokiapps.com/) · [Bize ulaşın](https://seokiapps.com/en/support/)
