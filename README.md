# BÀI TẬP LỚN: PHẦN MỀM QUẢN LÝ THIẾT BỊ NHÀ K

### Mô tả:

- Phần mềm cho phép người dùng quản lý tài khoản, thiết bị và , mượn/trả thiết bị
- Quản trị viên có toàn quyền điều kiển và quản lý tất cả các chức năng: thêm sửa xóa tài khoản, nhóm người dùng, thiết bị, mượn trả và chức năng chỉ admin có là thống kê và tổng hợp dữ liệu

#### Ưu điểm:

- Phân quyền rõ ràng đối với các kiểu người dùng
- Thống kê trực quan bằng biểu đồ
- Sử dụng mô hình code MVC cơ bản trong C# tổ chức code rõ ràng
- Validate dữ liệu chặt chẽ đối với từng câu lệnh SQL

## Nhóm tác giả:

- Phạm Quang Huy - K68B <backend developer>
- Vũ Thái Dương - K68B <frontend developer>

## Cách cài đặt

- Cấp quyền truy cập cao nhất cho tư mục chứa project
- Import database bằng file .\Bai_Tap_Lon_NET\BackUpDatabase\QuanLyThietBi.bak
- Dẫn lại đường dẫn tới server trong Model\ConnectDatabase\ConnectDatabase.cs
- Chạy thư mục Bai_Tap_Lon_NET\Bài tập lớn .NET - Phần mềm quản lý thiết bị \Bài tập lớn .NET - Phần mềm quản lý thiết bị.cs

## Chức Năng Chính Của Phần Mềm

- Tìm kiếm thiêt bị
- Thống kê số lượng trang thiết bị theo thời gian, theo nhân viên
- Thông tin sử dụng thiết bị của từng nhân viên
- Thống kê danh mục thiết bị thanh lí hàng năm

#### Quản lý tài khoản người dùng

- Thống kê các tài khoản người dùng
- Quản lí quyền truy cập
- Thêm sửa xóa tìm kiếm đối với admin và sửa đối với customer

#### Quản lý nhóm người dùng

- Đưa các người dùng cùng 1 nhóm vào cùng 1 quyền truy cập giúp quản lí quyền truy cập dễ dàng hơn
- Phân biệt rõ ràng admin, người mượn thiết bị ...

#### Quản lý danh mục thiết bị

- Thống kê các thiết bị đang được mượn và trả đối với customer
- Hiển thị toàn bộ danh sách các thiết bị đang mượn và đã trả đối với admin

#### Quản lý nhóm thiết bị

- Đưa ra các nhóm thiêt bị có chung mục đích sử dụng
- Tình trạng hiện tại của từng thiết bị

#### Quản lý việc sử dụng thiết bị

- Thống kê các thiết bị đang được sử dụng
- Thống kê các thiết bị đang được lưu trữ trong kho

#### Quản lý việc thanh lý thiết bị

- Thống kê các thiết bị đã được thanh lí
- thêm thiết bị thanh lý, thêm sửa xóa thanh lý
- áp dụng chức năng này cho admin

## Các thư mục trong project và cấu trúc MVC trong chương trình

### Các Form chính

- login.cs: quản lý đăng nhập hệ thống và phân quyền khi đăng nhập
- MainControl.cs : quản lý menu chính của project, nới chứa tất cả các nút chức năng của chương trình

### Folder Model

- Chứa các class thao tác trực tiếp với cơ sở dữ liệu, ví dụ: AccountManage.cs - quản lý thao tác tới bảng account trong database
- Chứa thư mục ConnectDatabase và class ConnectDatabase.cs để định nghĩa đường dẫn kết nối trực tiếp tới sql server

### Folder View

- Chứa tất cả các form quản lý các bảng của chương trình như quản lý tài khoản, quản lý người dùng, quản lý thiết bị ....
- Chứa tất cả các form thêm mới một field trong sql (thêm mới người dùng, thêm mới thiết bị, ...)

### Folder Controller

- Chứa các class nhận request từ người dùng và xử lý dữ liệu trước khi đưa vào trong model để thực hiện truy vấn
- Thực hiện nhận dữ liệu được trả về từ trong các class tương ứng trong model và trả ra output phù hợp cho người dùng

### Folder Object

- Chứa các class định nghĩa các thuộc tính của từng đối tượng tương ứng với các bảng
- Ví dụ: ObjAccount.cs chứa các đối tượng mô tả trong bảng account như: id, username, password

### Folder Image

- Chứa các ảnh dùng cho toàn bộ project

### Folder HelperData

- Chứa class DataConfig.cs giúp các class trong model lấy dữ liệu theo yêu cầu cho trước với sql server
- ví dụ như: lấy dữ ra dữ liệu trong sql và cập nhật dữ liệu trong sql
