[English](README.md) · [한국어](README.ko.md) · [中文](README.zh.md) · [日本語](README.ja.md) · **Bahasa Indonesia** · [Español](README.es.md) · [Português (Brasil)](README.pt-BR.md) · [Tiếng Việt](README.vi.md) · [ไทย](README.th.md) · [Русский](README.ru.md) · [Deutsch](README.de.md) · [Français](README.fr.md) · [Türkçe](README.tr.md)

# ResoCat

Atur resolusi layar khusus untuk setiap aplikasi Android.

[Google Play](https://play.google.com/store/apps/details?id=app.resocat.switcher)

## Unduh

[![Windows Download EXE](https://img.shields.io/badge/Windows-Download_EXE-6b4ca5?style=for-the-badge&labelColor=555555)](https://github.com/Seoki0903-forest/resocat-privacy/raw/refs/heads/main/downloads/ResoCat-ADB-Helper.exe)

**ResoCat USB Permission Helper 1.0.1**

Alat gratis untuk mengatur izin awal ResoCat pada ponsel atau tablet Android melalui USB dari PC Windows. Memerlukan Windows 10/11 64-bit dan .NET Framework 4.5+. ADB sudah ada di EXE; tidak perlu instalasi terpisah atau ekstraksi. Antarmuka alat memakai bahasa Korea pada Windows berbahasa Korea dan bahasa Inggris pada sistem lain. Panduan ini tersedia dalam 13 bahasa ResoCat.

[SHA-256](downloads/SHA256SUMS.txt) · [Kode sumber](usb-helper/source/ResoCatAdbHelper.cs)

## Petunjuk penggunaan

1. Instal ResoCat dari Google Play pada perangkat Android.
2. Aktifkan debugging USB di Opsi developer. Biasanya, ketuk Setelan → Tentang ponsel → Nomor build tujuh kali untuk mengaktifkan Opsi developer. Nama menu berbeda menurut produsen.
3. Hubungkan dengan kabel USB untuk transfer data dan buka kunci perangkat.
4. Izinkan komputer ini pada permintaan debugging USB di perangkat. Jangan pilih “Selalu izinkan” pada PC bersama.
5. Jalankan `ResoCat-ADB-Helper.exe` dari repositori GitHub resmi.
6. Pilih perangkat lalu klik **Set permissions and open ResoCat**. Jika hanya satu perangkat terhubung, perangkat dipilih otomatis.
7. Periksa pesan selesai dan tinjau sendiri ketentuan serta pengaturan lain di ResoCat. Setelah itu USB dapat dilepas.

Masalah koneksi: Untuk `unauthorized`, buka kunci perangkat, izinkan debugging USB, lalu klik **Refresh devices**. Untuk `offline`, sambungkan ulang USB. Jika perangkat tidak muncul, periksa debugging USB, kabel data dan driver USB produsen. Jika hanya sebagian selesai, aktifkan akses penggunaan melalui pengaturan Android yang ditunjukkan ResoCat. Alat tidak melewati pembatasan produsen atau kebijakan perangkat kantor/sekolah.

Peringatan Windows: Program belum ditandatangani dan dapat menampilkan “Windows protected your PC”. Periksa URL unduhan resmi dan SHA-256; pilih “More info → Run anyway” hanya untuk berkas yang Anda percayai.

Perubahan: Hanya `WRITE_SECURE_SETTINGS` dan `GET_USAGE_STATS` untuk ResoCat (`app.resocat.switcher`) pada pengguna Android aktif. Tidak perlu root atau hak administrator PC. Tidak mengubah nilai resolusi/DPI, iklan, pembayaran atau pengaturan baterai, memasang aplikasi, menghapus data, atau mengirim data ke server. TXT dari **Save result** dapat memuat identitas perangkat; kirim sendiri ke dukungan bila perlu. Debugging USB dapat dimatikan setelah pengaturan selesai.

## Kontak

[Situs web](https://seokiapps.com/) · [Hubungi kami](https://seokiapps.com/en/support/)
