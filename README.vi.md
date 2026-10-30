[English](README.md) · [한국어](README.ko.md) · [中文](README.zh.md) · [日本語](README.ja.md) · [Bahasa Indonesia](README.id.md) · [Español](README.es.md) · [Português (Brasil)](README.pt-BR.md) · **Tiếng Việt** · [ไทย](README.th.md) · [Русский](README.ru.md) · [Deutsch](README.de.md) · [Français](README.fr.md) · [Türkçe](README.tr.md)

# ResoCat

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
