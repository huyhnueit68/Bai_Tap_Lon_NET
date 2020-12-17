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

-
-
-

## Chức Năng Chính Của Phần Mềm

#### Quản lý tài khoản người dùng

-
-
-
-

#### Quản lý nhóm người dùng

-
-
-
-

#### Quản lý danh mục thiết bị

-
-
-
-

#### Quản lý nhóm thiết bị

-
-
-
-

#### Quản lý việc sử dụng thiết bị

-
-
-
-

#### Quản lý việc thanh lý thiết bị

-
-
-
-

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
