# Website Đặt Tour Du Lịch

Website Đặt Tour Du Lịch là một nền tảng giúp người dùng dễ dàng tìm kiếm, chọn lựa và đặt các tour du lịch cho các chuyến đi của mình. Hệ thống hỗ trợ quản lý các tour du lịch, giúp kết nối khách hàng và các đơn vị cung cấp dịch vụ du lịch.

## Chức năng chính

### 1. Quản lý người dùng
- **Đăng ký tài khoản**: 
  - Nhập thông tin cá nhân (họ tên, email, số điện thoại, mật khẩu).
  - Hoàn tất đăng ký tài khoản.
- **Đăng nhập**: 
  - Nhập email và mật khẩu để đăng nhập vào hệ thống.
- **Quản lý hồ sơ người dùng**:
  - Cập nhật thông tin cá nhân.
  - Xem lịch sử đặt tour.
  - Thay đổi mật khẩu.

### 2. Quản lý tour du lịch
- **Danh sách tour**: 
  - Xem danh sách các tour du lịch hiện có.
  - Tìm kiếm tour theo địa điểm, tên
- **Chi tiết tour**:
  - Xem thông tin chi tiết về tour (địa điểm, lịch trình, giá).
  - Xem các hình ảnh liên quan đến tour.
- **Đặt tour**:
  - Đặt tour du lịch .

### 3. Quản lý thanh toán
- **Chọn phương thức thanh toán**:
  - Thông báo khi thanh toán thành công.
- **Lịch sử thanh toán**: 
  - Xem lại các giao dịch đã thực hiện.

### 4. Phản hồi
- **Phản hồi**:
  - Người dùng có thể gửi phản hồi cho các tour để cải thiện chất lượng dịch vụ.

### 5. Quản trị hệ thống
- **Quản lý tour**:
  - Thêm, sửa, xóa các tour du lịch.
  - Quản lý các hình ảnh và thông tin của tour.
- **Quản lý người dùng**: 
  - Xem thông tin và hoạt động của người dùng.
  - Khóa hoặc xóa tài khoản người dùng.
- **Thống kê và báo cáo**:
  - Xem báo cáo về các giao dịch, doanh thu.

## Yêu cầu hệ thống
- **Ngôn ngữ lập trình**: C# (ASP.NET Core 5 MVC)
- **Cơ sở dữ liệu**: SQL Server
- **Các công nghệ khác**: HTML, CSS, JavaScript, Bootstrap, ajax

## Cách cài đặt

1. **Clone repository**:
    ```bash
    git clone https://github.com/ngokhaihuynh/Web-Travel-.NET-Core.git
    
    ```

2. **Cài đặt dependencies**:
    Mở **Visual Studio** và mở dự án `.sln` trong thư mục đã clone.
    Có thể tải thêm bảng sdk mvc net core 5 nếu thiếu.
3. **Cài đặt cơ sở dữ liệu**:
    - Cấu hình kết nối cơ sở dữ liệu trong file `appsettings.json` hoặc `Web.config`.
    - Chạy migration để tạo bảng trong cơ sở dữ liệu:
      ```bash
      dotnet ef database update
      ```

4. **Chạy server**:
    Mở **terminal** hoặc **command prompt** trong thư mục dự án và chạy lệnh:
    ```bash
    dotnet run
    ```

    Sau đó, mở trình duyệt và truy cập `http://localhost:....` để chạy ứng dụng. có thể nhấn nút run trên Visual studio để chạy.

## Liên hệ
- Email hỗ trợ: nkhuynh145@gmail.com


