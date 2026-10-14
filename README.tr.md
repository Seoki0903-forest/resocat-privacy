[English](README.md) · [한국어](README.ko.md) · [中文](README.zh.md) · [日本語](README.ja.md) · [Bahasa Indonesia](README.id.md) · [Español](README.es.md) · [Português (Brasil)](README.pt-BR.md) · [Tiếng Việt](README.vi.md) · [ไทย](README.th.md) · [Русский](README.ru.md) · [Deutsch](README.de.md) · [Français](README.fr.md) · **Türkçe**

# ResoCat

Her Android uygulaması için ayrı ekran çözünürlüğü ayarlayın.

[Google Play](https://play.google.com/store/apps/details?id=app.resocat.switcher)

## İndir

[![Windows Download EXE](https://img.shields.io/badge/Windows-Download_EXE-6b4ca5?style=for-the-badge&labelColor=555555)](https://github.com/Seoki0903-forest/resocat-privacy/raw/refs/heads/main/downloads/ResoCat-ADB-Helper.exe)

**ResoCat USB Permission Helper 1.0.1**

USB ile Windows bilgisayara bağlanan Android telefon veya tablette ResoCat’in başlangıç izinlerini ayarlayan ücretsiz araç. 64 bit Windows 10/11 ve .NET Framework 4.5+ gerekir. ADB, EXE’ye dahildir; ayrı kurulum veya dosya çıkarma gerekmez. Araç arayüzü Korece Windows’ta Korece, diğer sistemlerde İngilizcedir. Bu kılavuz ResoCat’in 13 dilini kapsar.

[SHA-256](downloads/SHA256SUMS.txt) · [Kaynak kodu](usb-helper/source/ResoCatAdbHelper.cs)

## Kullanım kılavuzu

1. Android cihazınıza Google Play’den ResoCat’i yükleyin.
2. Geliştirici seçeneklerinde USB hata ayıklamayı açın. Bu seçenekler genellikle Ayarlar → Telefon hakkında → Derleme numarasına yedi kez dokunarak açılır. Menü adları üreticiye göre değişir.
3. Veri aktarımını destekleyen USB kablosuyla bağlayın ve cihazın kilidini açın.
4. Cihazdaki USB hata ayıklama isteminde bu bilgisayara izin verin. Ortak bilgisayarda “Her zaman izin ver” seçmeyin.
5. Resmî GitHub deposundan indirdiğiniz `ResoCat-ADB-Helper.exe` dosyasını çalıştırın.
6. Cihazı seçip **Set permissions and open ResoCat** düğmesine basın. Tek cihaz varsa otomatik seçilir.
7. Tamamlanma mesajını kontrol edin; ResoCat’te koşulları ve kalan ayarları kendiniz inceleyin. Sonra USB bağlantısını kesebilirsiniz.

Bağlantı sorunları: `unauthorized` için cihazın kilidini açın, USB hata ayıklamaya izin verin ve **Refresh devices** düğmesine basın. `offline` için USB’yi yeniden bağlayın. Cihaz yoksa USB hata ayıklamayı, veri kablosunu ve üreticinin USB sürücülerini kontrol edin. Kısmen tamamlanırsa ResoCat’in gösterdiği Android ayarlarında kullanım erişimini açın. Üretici kısıtlamaları veya yönetilen cihaz politikaları aşılmaz.

Windows uyarısı: Program dijital olarak imzalanmamıştır; “Windows bilgisayarınızı korudu” uyarısı çıkabilir. Resmî indirme adresini ve SHA-256’yı kontrol edin; yalnızca güvendiğiniz dosya için “Ek bilgi → Yine de çalıştır” seçin.

Değişiklikler: Yalnızca etkin Android kullanıcısının ResoCat’i (`app.resocat.switcher`) için `WRITE_SECURE_SETTINGS` ve `GET_USAGE_STATS` ayarlanır. Root veya bilgisayar yönetici yetkisi gerekmez. Çözünürlük/DPI, reklam, ödeme ve pil ayarları değiştirilmez; uygulama yüklenmez, veri silinmez veya sunucuya gönderilmez. **Save result** ile kaydedilen TXT cihaz kimliklerini içerebilir; gerektiğinde desteğe kendiniz gönderin. Ayarlar bittikten sonra USB hata ayıklamayı kapatabilirsiniz.
