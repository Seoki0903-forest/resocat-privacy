[English](README.md) · [한국어](README.ko.md) · [中文](README.zh.md) · **日本語** · [Bahasa Indonesia](README.id.md) · [Español](README.es.md) · [Português (Brasil)](README.pt-BR.md) · [Tiếng Việt](README.vi.md) · [ไทย](README.th.md) · [Русский](README.ru.md) · [Deutsch](README.de.md) · [Français](README.fr.md) · [Türkçe](README.tr.md)

# ResoCat

Android アプリごとに好きな画面解像度を設定できます。

[Google Play](https://play.google.com/store/apps/details?id=app.resocat.switcher)

## ダウンロード

[![Windows Download EXE](https://img.shields.io/badge/Windows-Download_EXE-6b4ca5?style=for-the-badge&labelColor=555555)](https://github.com/Seoki0903-forest/resocat-privacy/raw/refs/heads/main/downloads/ResoCat-ADB-Helper.exe)

**ResoCat USB Permission Helper 1.0.1**

Windows PC と USB 接続した Android スマートフォン・タブレットで、ResoCat の初期権限を設定する無料ツールです。64 ビット版 Windows 10/11 と .NET Framework 4.5 以上が必要です。ADB は EXE に含まれており、別途インストールや解凍は不要です。ツールの表示は韓国語の Windows では韓国語、それ以外では英語です。このガイドは ResoCat の全 13 対応言語で提供しています。

[SHA-256](downloads/SHA256SUMS.txt) · [ソースコード](usb-helper/source/ResoCatAdbHelper.cs)

## 使い方

1. Android 端末に Google Play から ResoCat をインストールします。
2. 開発者向けオプションで USB デバッグを有効にします。通常は設定 → デバイス情報の「ビルド番号」を 7 回タップすると開発者向けオプションが表示されます。名称はメーカーによって異なります。
3. データ転送対応の USB ケーブルで PC に接続し、端末のロックを解除します。
4. 端末の USB デバッグ確認で、この PC を許可します。共有 PC では「常に許可」を選ばないでください。
5. 公式 GitHub からダウンロードした `ResoCat-ADB-Helper.exe` を実行します。
6. 端末を選び、**Set permissions and open ResoCat** を押します。接続端末が 1 台の場合は自動選択されます。
7. 完了メッセージを確認し、端末の ResoCat で利用規約と残りの設定を自分で確認します。その後 USB を取り外せます。

接続の問題：`unauthorized` の場合は端末のロックを解除して USB デバッグを許可し、**Refresh devices** を押してください。`offline` の場合は USB を接続し直してください。端末が表示されない場合は USB デバッグ、ケーブル、メーカーの USB ドライバーを確認します。一部完了の場合は ResoCat の案内に従って Android 設定で使用状況へのアクセスを許可してください。メーカーや管理端末の制限は回避しません。

Windows の警告：コード署名がないため「Windows によって PC が保護されました」が表示される場合があります。公式のダウンロード元と SHA-256 を確認し、信頼できるファイルに限り「詳細情報 → 実行」を選んでください。

変更内容：現在の Android ユーザーの ResoCat（`app.resocat.switcher`）に `WRITE_SECURE_SETTINGS` と `GET_USAGE_STATS` のみを設定します。root や PC 管理者権限は不要です。解像度・DPI、広告・課金、バッテリー設定は変更せず、アプリのインストールやデータ削除、サーバーへの送信もしません。**Save result** の TXT に端末識別情報が含まれる場合があります。必要なら自分でサポート担当者に送ってください。設定後は USB デバッグを無効にできます。
