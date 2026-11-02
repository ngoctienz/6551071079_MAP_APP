Lập trình trực quan

Ths. Nguyễn Thiện Dương Trang 1

I. Tổng quát bài thực hành

1. Yêu cầu lý thuyết

Sinh viên đã được trang bị các kiến thức sau:

o Ngôn ngữ lập trình C#

o Nguyên lý lập trình hướng đối tượng với ngôn ngữ C#

o Xây dựng ứng dụng winform với các điều khiển phổ biến (giao diện, chức năng)

o Xử lý sự kiện nhập liệu với bàn phím và chuột

o Thu viện đồ họa GDI+

o Xây dựng giao diện MDI

o Kết nối và thao tác với CSDL bằng công nghệ Entity Framework Core

o Tạo báo cáo FastRepor.Net

2. Yêu cầu chuẩn bị

Phần mềm Visual Studio, đã cài package .Net Framework

Phần mềm SQL Server

Trong phần mềm Visual Studio, cài sẵn các Nuget package sau:

o Microsoft.EntityFrameworkCore.Design

o Microsoft.EntityFrameworkCore.SqlServer

o Microsoft.EntityFrameworkCore.Tools

o ClosedXML

o iTextSharp

o FastReport.Net.Demo

3. Nội dung chính bài thực hành

Xây dựng một chương trình hoạt động trên nền tảng window cho việc “Quản lý hoạt

động khách sạn” gồm các chức năng chính sau:

Nhóm chức năng quản lý nghiệp vụ khách sạn

o Quản lý thông tin phòng

o Hiển thị tình trạng các phòng (trống, đang có khách, đang dọn...) trên sơ đồ khách

sạn để dễ theo dõi trực quan.

o Quản lý thông tin các loại phòng: Standard, Deluxe, Suite... với giá, tiện nghi

tương ứng.

o Đặt phòng, hủy đặt, cập nhật tình trạng, kiểm tra lịch đặt phòng.

TRƯỜNG ĐẠI HỌC GIAO THÔNG VẬN TẢI PHÂN HIỆU TẠI TP. HỒ CHÍ MINH Bộ môn: Công nghệ thông tin

### Bài thực hành

Môn học: Lập trình trực quan

Lập trình trực quan

Ths. Nguyễn Thiện Dương Trang 2

o Tạo và quản lý hóa đơn thanh toán cho khách, bao gồm tiền phòng và dịch vụ.

o In hóa đơn ra giấy hoặc file PDF để cung cấp cho khách.

Nhóm chức năng quản lý dịch vụ & tiện nghi

o Quản lý thông tin các dịch vụ đi kèm: ăn uống, giặt ủi, spa, đưa đón sân bay...

o Quản lý thông tin tiện nghi trong phòng (TV, điều hòa, wifi, minibar...) và đảm

bảo cung ứng.

Nhóm chức năng quản lý người dùng và nhân sự

o Quản lý thông tin nhân viên: họ tên, chức vụ, lịch làm việc...

o Quản lý thông tin khách hàng: họ tên, CCCD, số điện thoại, lịch sử lưu trú.

o Quản lý các loại tài khoản người dùng hệ thống: admin, lễ tân, kế toán...

o Phân quyền sử dụng hệ thống dựa trên vai trò (chỉ admin được phép xóa, lễ tân

chỉ được đặt phòng...).

Chức năng hỗ trợ & báo cáo

o Thống kê doanh thu theo ngày, tháng, loại phòng, nhân viên...

o Xuất danh sách phòng, khách, hóa đơn, doanh thu... ra file Excel để lưu trữ hoặc

in báo cáo

o Cho phép người dùng đặt lại mật khẩu nếu quên, hoặc đổi mật khẩu khi cần.

II. Hướng dẫn nộp bài tập thực hành

Để nộp bài thực hành sau mỗi buổi học, các nhóm thực hiện như sau:

- Tạo 1 Repo trên github để lưu trữ mã nguồn của ứng dụng mobile thực hiện được

trong cả buổi LAB 1 và LAB2 (2 lab đều dùng chung repo này)

o Cú pháp tên Repo: <MSSV1>_<MSSV2>_MAP_APP

- Tạo 1 Repo khác trên github để lưu trữ mã nguồn của ứng dụng web thực hiện

được trong buổi LAB 3

o Cú pháp tên Repo: <MSSV1>_<MSSV2>_MAP_WEB

- Tạo 1 link GGdrive/Onedrive lưu trữ video record lại chạy demo chức năng của

app/web thực hiện được sau từng buổi. Mỗi link drive tương ứng cho mỗi buổi.

Đặt tên tương ứng như sau: Video LAB1, Video LAB2, VIdeo LAB3

- Tổng hợp lại link repo github + link GGDrive/OneDrive của video cho từng buổi

và paste vào file template được gửi kèm trên LMS

Lập trình trực quan

Ths. Nguyễn Thiện Dương Trang 3

III. Chi tiết bài thực hành cho buổi 1

1. Tạo cơ sở dữ liệu HotelManagement lưu trữ trong SQL Server

SV truy cập vào LMS để download file “Database.sql” để tạo CSDL tương ứng tên là

“HotelManagement” trong SQL Server. Kết quả sau khi thao tác có được lược đồ như sau:

Mô tả bảng và các thuộc tính trong cơ sở dữ liệu

Bảng: NhanVien

Tên thuộc tính Ý nghĩa Kiểu dữ liệu Ghi chú

MaNV Mã nhân viên NVARCHAR(5) Khóa chính, định danh nhân viên

TenNV Tên nhân viên NVARCHAR(50) Không được để trống

ChucVu Chức vụ NVARCHAR(50) Không được để trống

Luong Lương MONEY Không được để trống

SDT Số điện thoại NVARCHAR(10) Không trùng nhau

CCCD Số CCCD NVARCHAR(12) Không trùng nhau

NgaySinh Ngày sinh DATE Không được để trống

GioiTinh Giới tính NVARCHAR(3) Không được để trống

DiaChi Địa chỉ NVARCHAR(100) Không được để trống

Email Email NVARCHAR(100) Không trùng nhau

DaXoa Đã xóa BIT Trạng thái đã xóa

Bảng: TaiKhoan

Tên thuộc tính Ý nghĩa Kiểu dữ liệu Ghi chú

Lập trình trực quan

Ths. Nguyễn Thiện Dương Trang 4

TenTK Tên tài khoản NVARCHAR(50) Khóa chính

Password Mật khẩu NVARCHAR(1000) Không được để trống

CapDoQuyen Cấp độ quyền INT Không được để trống

MaNV Mã nhân viên NVARCHAR(5) Khóa ngoại đến NhanVien

DaXoa Đã xóa BIT Mặc định là 0

Bảng: KhachHang

Tên thuộc tính Ý nghĩa Kiểu dữ liệu Ghi chú

MaKH Mã khách hàng NVARCHAR(5) Khóa chính

TenKH Tên khách hàng NVARCHAR(50) Không được để trống

SDT Số điện thoại NVARCHAR(10) Tùy chọn

CCCD/Passport CCCD/Passport NVARCHAR(12) Không trùng nhau

QuocTich Quốc tịch NVARCHAR(30) Không được để trống

GioiTinh Giới tính NVARCHAR(3) Không được để trống

DaXoa Đã xóa BIT Trạng thái đã xóa

Bảng: Phong

Tên thuộc tính Ý nghĩa Kiểu dữ liệu Ghi chú

MaPH Mã phòng NVARCHAR(5) Khóa chính

TTPH Trạng thái phòng NVARCHAR(20) Không được để trống

TTDD Tình trạng dọn dẹp NVARCHAR(20) Không được để trống

GhiChu Ghi chú NVARCHAR(100) Tùy chọn

MaLPH Mã loại phòng NVARCHAR(5) Khóa ngoại

DaXoa Đã xóa BIT Trạng thái đã xóa

Bảng: PhieuThue

Tên cột Ý nghĩa Kiểu dữ liệu Ghi chú MaPT Mã phiếu thuê NVARCHAR(5) Khóa chính NgPT Ngày lập phiếu thuê SMALLDATETIME Không null

MaKH Mã khách hàng NVARCHAR(5) Khóa ngoại đến KhachHang MaNV Mã nhân viên NVARCHAR(5) Khóa ngoại đến NhanVien DaXoa Trạng thái xóa mềm BIT Mặc định 0

Bảng: CTDP

Tên cột Ý nghĩa Kiểu dữ liệu Ghi chú

Lập trình trực quan

Ths. Nguyễn Thiện Dương Trang 5

MaCTDP Mã chi tiết đặt phòng NVARCHAR(7) Khóa chính

SoNguoi Số người INT MaPT Mã phiếu thuê NVARCHAR(5) Khóa ngoại đến PhieuThue MaPH Mã phòng NVARCHAR(5) Khóa ngoại đến Phong CheckIn Ngày nhận phòng SMALLDATETIME Không null CheckOut Ngày trả phòng SMALLDATETIME Không null TrangThai Trạng thái đặt phòng NVARCHAR(20)

DonGia Đơn giá MONEY ThanhTien Thành tiền MONEY Mặc định 0 DaXoa Trạng thái xóa mềm BIT Mặc định 0

TheoGio Thuê theo giờ BIT Mặc định 0 Bảng: HoaDon

Tên cột Ý nghĩa Kiểu dữ liệu Ghi chú MaHD Mã hóa đơn NVARCHAR(5) Khóa chính NgHD Ngày lập hóa đơn SMALLDATETIME TriGia Trị giá MONEY Mặc định 0 MaNV Mã nhân viên NVARCHAR(5) Khóa ngoại đến NhanVien TrangThai Trạng thái thanh toán NVARCHAR(20) Không null

MaCTDP Mã chi tiết đặt phòng NVARCHAR(7) Khóa ngoại đến CTDP

DaXoa Trạng thái xóa mềm BIT Mặc định 0

Bảng: LoaiPhong

Tên cột Ý nghĩa Kiểu dữ liệu Ghi chú MaLPH Mã loại phòng NVARCHAR(5) Khóa chính TenLPH Tên loại phòng NVARCHAR(20) Không null SoGiuong Số giường INT Không null SoNguoiToiDa Số người tối đa INT Không null GiaNgay Giá theo ngày MONEY Không null GiaGio Giá theo giờ MONEY Không null Bảng: TienNghi

Tên cột Ý nghĩa Kiểu dữ liệu Ghi chú MaTN Mã tiện nghi NVARCHAR(5) Khóa chính TenTN Tên tiện nghi NVARCHAR(50) Không null DaXoa Trạng thái xóa mềm BIT

Bảng: CTTN

Tên cột Ý nghĩa Kiểu dữ liệu Ghi chú MaLPH Mã loại phòng NVARCHAR(5) Khóa chính, FK đến LoaiPhong

Lập trình trực quan

Ths. Nguyễn Thiện Dương Trang 6

MaTN Mã tiện nghi NVARCHAR(5) Khóa chính, FK đến TienNghi SL Số lượng INT Mặc định -1 DaXoa Trạng thái xóa mềm BIT Mặc định 0

Bảng: DichVu

Tên cột Ý nghĩa Kiểu dữ liệu Ghi chú MaDV Mã dịch vụ NVARCHAR(5) Khóa chính TenDV Tên dịch vụ NVARCHAR(20) Không null DonGia Đơn giá MONEY Không null SLConLai Số lượng còn lại INT Mặc định -1 LoaiDV Loại dịch vụ NVARCHAR(20) Không null DaXoa Trạng thái xóa mềm BIT Bảng: CTDV

Tên cột Ý nghĩa Kiểu dữ liệu Ghi chú MaCTDP Mã chi tiết đặt phòng NVARCHAR(7) Khóa chính, FK đến CTDP MaDV Mã dịch vụ NVARCHAR(5) Khóa chính, FK đến DichVu DonGia Đơn giá MONEY Khóa chính SL Số lượng sử dụng INT Không null DaXoa Trạng thái xóa mềm BIT Mặc định 0 ThanhTien Thành tiền MONEY Mặc định 0

2. Cấu hình kết đối đến cơ sở dữ liệu HotelManagement từ chương trình Winform

Bước 1: Click chuột phải vào tên Project trong cửa sổ Solution Exploer → EF Core

Power Tools → Reverse Engineer

Bước 2: Cửa sổ Choose your data connection hiện ra → click vào Add → chọn Add

Database Connection

Lập trình trực quan

Ths. Nguyễn Thiện Dương Trang 7

Bước 3: Cửa sổ Connection Propertis hiện ra → chọn thông tin Server Name → Tích chọn Trust Server Certificate → Chọn Database vừa tạo xong trong SQL Server → Click OK → Quay lại cửa sổ “Choose your data connection” → Click Next

Lập trình trực quan

Ths. Nguyễn Thiện Dương Trang 8

Bước 4: Trong cửa sổ Choose your database object, chọn hết tất cả các table của

database vừa tạo → click Next → Click Next → Finish

Bước 5: Trong thư mục của Project có tự động tạo thư mục Models và các file .cs chứa

các định nghĩa các class tương ứng với các table của Database

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 9

### Bước 6: Click chuột phải vào thư mục Models → chọn Add → Class → tạo file đặt

### tên là Hotelmanagementcontext.custom.cs, có nội dung như sau:

using Microsoft.EntityFrameworkCore;

namespace HotelManagement.Models;

// File riêng (partial) để khi scaffold lại DB, EF Core Power Tools ghi đè HotelManagementContext.cs // thì cấu hình kết nối này không bị mất. public partial class HotelManagementContext { // Đổi Server cho đúng máy của bạn: "." | "localhost" | ". \ \ SQLEXPRESS" | "(localdb) \ \ MSSQLLocalDB" private const string ConnectionString =

"Server=(localdb) \ \ MSSQLLocalDB;Database=HotelManagement;Trusted_Connection=True;TrustS erverCertificate=True;";

// Constructor không tham số để dùng: new HotelManagementContext() public HotelManagementContext () { }

protected override void OnConfiguring ( DbContextOptionsBuilder optionsBuilder) { if (! optionsBuilder.IsConfigured) optionsBuilder. UseSqlServer (ConnectionString); } }

Lập trình trực quan

Ths. Nguyễn Thiện Dương Trang 10

3. Cấu hình tạo tự động thư mục Resource chứa các file tài nguyên của ứng dụng

Bước 1: Click chuột phải vào thư mục Project → Properties → tìm đến tab Resource

Bước 2: Click vào Create or open assembly resources → tab Resources.resx hiện ra → Click vào icon “+” ở góc trái trên cùng → cửa số Add new resource to Resources

hiện ra → cấu hình thông tin như hình và lần lượt thêm vào hết các icon/symbol/images

được cung cấp

Bước 3: Sau khi thêm xong, trong thư mục Project ở cửa sổ Solution Exploer sẽ có thư

mục Resources tự động tạo ra chứa các file images/icons/symbols vừa tạo

Lập trình trực quan

Ths. Nguyễn Thiện Dương Trang 11

4. Xây dựng giao diện và chức năng đăng nhập vào ứng dụng

Bước 1: Click chuột phải vào thư mục Project → Add → New Folder → Đặt tên

“DangNhap” Bước 2: Click chuột phải vào thư mục DangNhap → Add → Form (Windows Forms) → tạo mới một form đặt tên là FormDangNhap.cs

Bước 3: SV xây dựng giao diện form đăng nhập, có thể tham khảo mẫu và mã nguồn

sau:

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 12

### Mã nguồn trong file FormDangNhap.Designer.cs

namespace HotelManagement.DangNhap { partial class FormDangNhap { /// <summary> /// Required designer variable. /// </summary> private System.ComponentModel. IContainer components = null;

/// <summary> /// Clean up any resources being used. /// </summary> /// <param name=" disposing "> true if managed resources should be disposed; otherwise, false. </param> protected override void Dispose ( bool disposing) { if ( disposing && (components != null)) { components. Dispose (); } base. Dispose ( disposing); }

#region Windows Form Designer generated code

/// <summary> /// Required method for Designer support - do not modify /// the contents of this method with the code editor. /// </summary> private void InitializeComponent () { panel2 = new Panel (); label1 = new Label (); txtMatKhau = new TextBox (); txtTenDangNhap = new TextBox (); pictureBox2 = new PictureBox (); btnDangNhap = new Button (); linkLabel1 = new LinkLabel (); label2 = new Label (); panel1 = new Panel (); pictureBox1 = new PictureBox (); panel2. SuspendLayout ();

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 13

((System.ComponentModel. ISupportInitialize)pictureBox2). BeginInit (); ((System.ComponentModel. ISupportInitialize)pictureBox1). BeginInit (); SuspendLayout (); // // panel2 // panel2.Controls. Add(label1); panel2.Controls. Add(txtMatKhau); panel2.Controls. Add(txtTenDangNhap); panel2.Controls. Add(pictureBox2); panel2.Controls. Add(btnDangNhap); panel2.Controls. Add(linkLabel1); panel2.Controls. Add(label2); panel2.Location = new Point (448, 16); panel2.Margin = new Padding (3, 4, 3, 4); panel2.Name = "panel2"; panel2.Size = new Size (395, 531); panel2.TabIndex = 4; // // label1 // label1.AutoSize = true; label1.Font = new Font ( "Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0); label1.ForeColor = Color. FromArgb (192, 0, 0); label1.Location = new Point (19, 182); label1.Name = "label1"; label1.Size = new Size (141, 24); label1.TabIndex = 9; label1.Text = "Tên đăng nhập"; // // txtMatKhau // txtMatKhau.Font = new Font ( "Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0); txtMatKhau.Location = new Point (177, 255); txtMatKhau.Margin = new Padding (3, 4, 3, 4); txtMatKhau.Name = "txtMatKhau"; txtMatKhau.PasswordChar = '*'; txtMatKhau.Size = new Size (192, 34); txtMatKhau.TabIndex = 8; txtMatKhau.KeyDown += txtMatKhau_KeyDown; // // txtTenDangNhap // txtTenDangNhap.Font = new Font ( "Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0); txtTenDangNhap.Location = new Point (177, 170); txtTenDangNhap.Margin = new Padding (3, 4, 3, 4); txtTenDangNhap.Name = "txtTenDangNhap"; txtTenDangNhap.Size = new Size (192, 34); txtTenDangNhap.TabIndex = 14; // // pictureBox2 // pictureBox2.Image = Properties. Resources.DangNhap; pictureBox2.Location = new Point (97, 44); pictureBox2.Margin = new Padding (3, 4, 3, 4); pictureBox2.Name = "pictureBox2"; pictureBox2.Size = new Size (203, 75); pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage; pictureBox2.TabIndex = 6; pictureBox2.TabStop = false; // // btnDangNhap //

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 14

btnDangNhap.BackColor = Color. FromArgb (192, 192, 255); btnDangNhap.Font = new Font ( "Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0); btnDangNhap.Location = new Point (117, 380); btnDangNhap.Margin = new Padding (3, 4, 3, 4); btnDangNhap.Name = "btnDangNhap"; btnDangNhap.Size = new Size (134, 66); btnDangNhap.TabIndex = 5; btnDangNhap.Text = "Đăng nhập"; btnDangNhap.UseVisualStyleBackColor = false; btnDangNhap.Click += btnDangNhap_Click; // // linkLabel1 // linkLabel1.AutoSize = true; linkLabel1.Font = new Font ( "Microsoft Sans Serif", 13F, FontStyle.Italic, GraphicsUnit.Point, 0); linkLabel1.Location = new Point (222, 328); linkLabel1.Name = "linkLabel1"; linkLabel1.Size = new Size (161, 26); linkLabel1.TabIndex = 4; linkLabel1.TabStop = true; linkLabel1.Text = "Quên mật khẩu"; // // label2 // label2.AutoSize = true; label2.Font = new Font( "Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0); label2.ForeColor = Color.FromArgb(192, 0, 0); label2.Location = new Point(62, 265); label2.Name = "label2"; label2.Size = new Size(86, 24); label2.TabIndex = 2; label2.Text = "Mật khẩu"; // // panel1 // panel1.Location = new Point( - 22, 16); panel1.Margin = new Padding(3, 4, 3, 4); panel1.Name = "panel1"; panel1.Size = new Size(414, 531); panel1.TabIndex = 3; // // pictureBox1 // pictureBox1.Image = Properties.Resources.pictureIcon; pictureBox1.Location = new Point( - 16, 20); pictureBox1.Margin = new Padding(3, 4, 3, 4); pictureBox1.Name = "pictureBox1"; pictureBox1.Size = new Size(458, 524); pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; pictureBox1.TabIndex = 2; pictureBox1.TabStop = false; // // FormDangNhap // AutoScaleDimensions = new SizeF(8F, 20F); AutoScaleMode = AutoScaleMode.Font; BackColor = Color.Beige; ClientSize = new Size(855, 562); Controls.Add(pictureBox1); Controls.Add(panel2); Controls.Add(panel1); Margin = new Padding(3, 4, 3, 4); Name = "FormDangNhap";

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 15

StartPosition = FormStartPosition.CenterScreen; Text = "FormDangNhap"; panel2. ResumeLayout ( false); panel2. PerformLayout (); ((System.ComponentModel. ISupportInitialize)pictureBox2). EndInit (); ((System.ComponentModel. ISupportInitialize)pictureBox1). EndInit (); ResumeLayout ( false);

}

#endregion private System.Windows.Forms. PictureBox pictureBox1; private System.Windows.Forms. Panel panel2; private System.Windows.Forms. PictureBox pictureBox2; private System.Windows.Forms. Button btnDangNhap; private System.Windows.Forms. LinkLabel linkLabel1; private System.Windows.Forms. Label label2; private System.Windows.Forms. Panel panel1; private System.Windows.Forms. TextBox txtMatKhau; private System.Windows.Forms. TextBox txtTenDangNhap; private System.Windows.Forms. Label label1; } }

### Bước 4: SV sử dụng mã nguồn sau để xử lý chức năng đăng nhập trong file

### FormDangNhap.cs

using HotelManagement.Models; using Microsoft.EntityFrameworkCore;

namespace HotelManagement.DangNhap { public partial class FormDangNhap: Form { // Thông tin phiên đăng nhập – các form khác đọc trực tiếp, ví dụ: FormDangNhap.MaNV_DangNhap public static string MaNV_DangNhap = string.Empty; public static string TenNV_DangNhap = string.Empty; public static int CapDoQuyen_DangNhap; // 1: Nhân viên, 2: Quản lý, 3: Admin (theo dữ liệu mẫu)

public FormDangNhap () { InitializeComponent (); ActiveControl = txtTenDangNhap; // Focus() trong constructor không có tác dụng vì form chưa hiện }

private async void btnDangNhap_Click ( object sender, EventArgs e) { string tenDangNhap = txtTenDangNhap.Text. Trim (); string matKhau = txtMatKhau.Text;

if ( tenDangNhap.Length == 0 || matKhau.Length == 0) { MessageBox. Show( "Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

btnDangNhap.Enabled = false; // tránh bấm nhiều lần khi đang chờ CSDL try {

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 16

bool hopLe = await KiemTraDangNhapAsync(tenDangNhap, matKhau);

if (hopLe) { DialogResult = DialogResult.OK; // Program.cs sẽ mở form chính, không Show ở đây } else { MessageBox.Show( "Sai tên đăng nhập hoặc mật khẩu.", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error); txtMatKhau.Clear(); txtMatKhau.Focus(); } } catch (Exception ex) { MessageBox.Show( "Lỗi kết nối CSDL: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); } finally { btnDangNhap.Enabled = true; } }

private async Task< bool > KiemTraDangNhapAsync ( string tenDangNhap, string matKhau) { await using var db = new HotelManagementContext();

// 1 câu truy vấn duy nhất: lấy tài khoản + tên nhân viên (JOIN qua navigation property) // DaXoa là bool? nên dùng "!= true" để chấp nhận cả giá trị NULL lẫn false var tk = await db.TaiKhoans .AsNoTracking() .Where( t => t.TenTk == tenDangNhap && t.DaXoa != true) .Select( t => new { t.Password, t.MaNv, t.CapDoQuyen, TenNv = t.MaNvNavigation.TenNv, NhanVienDaXoa = t.MaNvNavigation.DaXoa }) . FirstOrDefaultAsync ();

if ( tk == null || tk.NhanVienDaXoa == true) return false;

// So sánh mật khẩu phía C# (phân biệt hoa/thường) vì collation mặc định của SQL Server không phân biệt if (! string. Equals ( tk.Password, matKhau, StringComparison.Ordinal)) return false;

MaNV_DangNhap = tk.MaNv; TenNV_DangNhap = tk.TenNv; CapDoQuyen_DangNhap = tk.CapDoQuyen; Tag = tk.TenNv; // giữ cách cũ: truyền tên nhân viên qua Tag return true; }

private void txtMatKhau_KeyDown ( object sender, KeyEventArgs e) {

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 17

if ( e.KeyCode == Keys.Enter) { e.SuppressKeyPress = true; // bỏ tiếng "ding" khi nhấn Enter btnDangNhap. PerformClick (); } } } }

### Bước 5: SV mở file Program.cs, sửa lại nội dung tạm thời như sau:

using HotelManagement.DangNhap;

namespace HotelManagement { internal static class Program { /// <summary> /// The main entry point for the application. /// </summary> [ STAThread] static void Main () { // To customize application configuration such as set high DPI settings or default font, // see https://aka.ms/applicationconfiguration. ApplicationConfiguration. Initialize ();

// Hiện form đăng nhập trước; đăng nhập thành công (DialogResult.OK) mới mở form chính using ( var formDangNhap = new FormDangNhap ()) { if ( formDangNhap. ShowDialog () != DialogResult.OK) return; }

Application. Run( new Form1 ()); } } }

### 5. Xây dựng giao diện trang chủ của ứng dụng

### Bước 1: SV đổi tên file Form1.cs thành FormMain.cs

### Bước 2: SV xây dựng giao diện form trang chủ chính của ứng dụng tạm thời như

### sau:

Lập trình trực quan

Ths. Nguyễn Thiện Dương Trang 18

Mã nguồn tương ứng trong file FormMain.Designer.cs như sau:

namespace HotelManagement

{

partial class FormMain

{

/// <summary>

/// Required designer variable.

/// </summary>

private System.ComponentModel.IContainer components = null;

/// <summary>

/// Clean up any resources being used.

/// </summary>

/// <param name="disposing">true if managed resources should be disposed; otherwise,

false.</param>

protected override void Dispose(bool disposing)

{

if (disposing && (components != null))

{

components.Dispose();

}

base.Dispose(disposing);

}

#region Windows Form Designer generated code

/// <summary>

/// Required method for Designer support - do not modify

/// the contents of this method with the code editor.

/// </summary>

private void InitializeComponent()

{

panel1 = new Panel();

Lập trình trực quan

Ths. Nguyễn Thiện Dương Trang 19

labelTenKhachSan = new Label();

pictureBox1 = new PictureBox();

panel2 = new Panel();

lblTenNguoiDung = new Label();

pictureBox2 = new PictureBox();

linkLabel1 = new LinkLabel();

panelMain = new Panel();

panel4 = new Panel();

button13 = new Button();

btnTrangChu = new Button();

button5 = new Button();

button4 = new Button();

button7 = new Button();

button6 = new Button();

btnQuanLyPhong = new Button();

button12 = new Button();

button11 = new Button();

btnSoDoPhong = new Button();

button9 = new Button();

button10 = new Button();

panel1.SuspendLayout();

((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();

panel2.SuspendLayout();

((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();

panel4.SuspendLayout();

SuspendLayout();

//

// panel1

//

panel1.BackColor = Color.SeaGreen;

panel1.Controls.Add(labelTenKhachSan);

panel1.Controls.Add(pictureBox1);

panel1.Location = new Point(1, 4);

panel1.Margin = new Padding(3, 4, 3, 4);

Lập trình trực quan

Ths. Nguyễn Thiện Dương Trang 20

panel1.Name = "panel1";

panel1.Size = new Size(1834, 92);

panel1.TabIndex = 0;

//

// labelTenKhachSan

//

labelTenKhachSan.AutoSize = true;

labelTenKhachSan.BackColor = Color.Transparent;

labelTenKhachSan.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold,

GraphicsUnit.Point, 0);

labelTenKhachSan.ForeColor = Color.LightSalmon;

labelTenKhachSan.Location = new Point(66, 19);

labelTenKhachSan.Name = "labelTenKhachSan";

labelTenKhachSan.Size = new Size(285, 41);

labelTenKhachSan.TabIndex = 3;

labelTenKhachSan.Text = "Hotel Management";

//

// pictureBox1

//

pictureBox1.Image = Properties.Resources.Menu;

pictureBox1.Location = new Point(3, 4);

pictureBox1.Margin = new Padding(3, 4, 3, 4);

pictureBox1.Name = "pictureBox1";

pictureBox1.Size = new Size(48, 78);

pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

pictureBox1.TabIndex = 0;

pictureBox1.TabStop = false;

//

// panel2

//

panel2.BackColor = Color.MediumSeaGreen;

panel2.Controls.Add(lblTenNguoiDung);

panel2.Controls.Add(pictureBox2);

panel2.Controls.Add(linkLabel1);

Lập trình trực quan

Ths. Nguyễn Thiện Dương Trang 21

panel2.Location = new Point(1, 94);

panel2.Margin = new Padding(3, 4, 3, 4);

panel2.Name = "panel2";

panel2.Size = new Size(304, 198);

panel2.TabIndex = 1;

//

// lblTenNguoiDung

//

lblTenNguoiDung.AutoSize = true;

lblTenNguoiDung.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold,

GraphicsUnit.Point, 0);

lblTenNguoiDung.Location = new Point(28, 159);

lblTenNguoiDung.Name = "lblTenNguoiDung";

lblTenNguoiDung.Size = new Size(76, 26);

lblTenNguoiDung.TabIndex = 2;

lblTenNguoiDung.Text = "label1";

lblTenNguoiDung.TextAlign = ContentAlignment.MiddleCenter;

//

// pictureBox2

//

pictureBox2.BackgroundImageLayout = ImageLayout.None;

pictureBox2.Image = Properties.Resources.user;

pictureBox2.Location = new Point(101, 48);

pictureBox2.Margin = new Padding(3, 4, 3, 4);

pictureBox2.Name = "pictureBox2";

pictureBox2.Size = new Size(87, 108);

pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

pictureBox2.TabIndex = 1;

pictureBox2.TabStop = false;

//

// linkLabel1

//

linkLabel1.AutoSize = true;

Lập trình trực quan

Ths. Nguyễn Thiện Dương Trang 22

linkLabel1.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular,

GraphicsUnit.Point, 0);

linkLabel1.ForeColor = Color.MidnightBlue;

linkLabel1.Location = new Point(4, 11);

linkLabel1.Name = "linkLabel1";

linkLabel1.Size = new Size(111, 26);

linkLabel1.TabIndex = 0;

linkLabel1.TabStop = true;

linkLabel1.Text = "Đăng xuất";

//

// panelMain

//

panelMain.AutoScroll = true;

panelMain.BackColor = Color.Honeydew;

panelMain.Location = new Point(312, 105);

panelMain.Margin = new Padding(3, 4, 3, 4);

panelMain.Name = "panelMain";

panelMain.Size = new Size(1647, 1349);

panelMain.TabIndex = 2;

//

// panel4

//

panel4.BackColor = Color.DarkCyan;

panel4.Controls.Add(button13);

panel4.Controls.Add(btnTrangChu);

panel4.Controls.Add(button5);

panel4.Controls.Add(button4);

panel4.Controls.Add(button7);

panel4.Controls.Add(button6);

panel4.Controls.Add(btnQuanLyPhong);

panel4.Controls.Add(button12);

panel4.Controls.Add(button11);

panel4.Controls.Add(btnSoDoPhong);

panel4.Controls.Add(button9);

Lập trình trực quan

Ths. Nguyễn Thiện Dương Trang 23

panel4.Controls.Add(button10);

panel4.Location = new Point(1, 289);

panel4.Margin = new Padding(3, 4, 3, 4);

panel4.Name = "panel4";

panel4.Size = new Size(304, 1161);

panel4.TabIndex = 4;

//

// button13

//

button13.BackColor = Color.DarkCyan;

button13.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular,

GraphicsUnit.Point, 0);

button13.ForeColor = SystemColors.ButtonHighlight;

button13.Image = Properties.Resources.MenuThongKe;

button13.ImageAlign = ContentAlignment.MiddleLeft;

button13.Location = new Point(-1, 662);

button13.Margin = new Padding(3, 4, 3, 4);

button13.Name = "button13";

button13.Size = new Size(307, 51);

button13.TabIndex = 16;

button13.Text = "Thống kê";

button13.UseVisualStyleBackColor = false;

//

// btnTrangChu

//

btnTrangChu.BackColor = Color.DarkCyan;

btnTrangChu.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular,

GraphicsUnit.Point, 0);

btnTrangChu.ForeColor = SystemColors.ButtonHighlight;

btnTrangChu.Image = Properties.Resources.MenuTrangChu;

btnTrangChu.ImageAlign = ContentAlignment.MiddleLeft;

btnTrangChu.Location = new Point(0, 0);

btnTrangChu.Margin = new Padding(3, 4, 3, 4);

btnTrangChu.Name = "btnTrangChu";

Lập trình trực quan

Ths. Nguyễn Thiện Dương Trang 24

btnTrangChu.Size = new Size(304, 69);

btnTrangChu.TabIndex = 3;

btnTrangChu.Text = "Trang chủ";

btnTrangChu.UseVisualStyleBackColor = false;

//

// button5

//

button5.BackColor = Color.DarkCyan;

button5.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular,

GraphicsUnit.Point, 0);

button5.ForeColor = SystemColors.ButtonHighlight;

button5.Image = Properties.Resources.MenuQuanLyTaiKhoan;

button5.ImageAlign = ContentAlignment.MiddleLeft;

button5.Location = new Point(-2, 605);

button5.Margin = new Padding(3, 4, 3, 4);

button5.Name = "button5";

button5.Size = new Size(307, 51);

button5.TabIndex = 8;

button5.Text = "Danh sách tài khoản";

button5.UseVisualStyleBackColor = false;

//

// button4

//

button4.BackColor = Color.DarkCyan;

button4.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular,

GraphicsUnit.Point, 0);

button4.ForeColor = SystemColors.ButtonHighlight;

button4.Image = Properties.Resources.MenuLoaiPhong;

button4.ImageAlign = ContentAlignment.MiddleLeft;

button4.Location = new Point(-2, 194);

button4.Margin = new Padding(3, 4, 3, 4);

button4.Name = "button4";

button4.Size = new Size(307, 51);

button4.TabIndex = 7;

Lập trình trực quan

Ths. Nguyễn Thiện Dương Trang 25

button4.Text = "Loại phòng";

button4.UseVisualStyleBackColor = false;

//

// button7

//

button7.BackColor = Color.DarkCyan;

button7.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular,

GraphicsUnit.Point, 0);

button7.ForeColor = SystemColors.ButtonHighlight;

button7.Image = Properties.Resources.MenuQuanLyNhanVien;

button7.ImageAlign = ContentAlignment.MiddleLeft;

button7.Location = new Point(0, 546);

button7.Margin = new Padding(3, 4, 3, 4);

button7.Name = "button7";

button7.Size = new Size(301, 51);

button7.TabIndex = 10;

button7.Text = "Danh sách nhân viên";

button7.UseVisualStyleBackColor = false;

//

// button6

//

button6.BackColor = Color.DarkCyan;

button6.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular,

GraphicsUnit.Point, 0);

button6.ForeColor = SystemColors.ButtonHighlight;

button6.Image = Properties.Resources.MenuQuanLyKhachHang;

button6.ImageAlign = ContentAlignment.MiddleLeft;

button6.Location = new Point(-2, 488);

button6.Margin = new Padding(3, 4, 3, 4);

button6.Name = "button6";

button6.Size = new Size(307, 51);

button6.TabIndex = 9;

button6.Text = "Danh sách khách hàng";

button6.UseVisualStyleBackColor = false;

Lập trình trực quan

Ths. Nguyễn Thiện Dương Trang 26

//

// btnQuanLyPhong

//

btnQuanLyPhong.BackColor = Color.DarkCyan;

btnQuanLyPhong.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular,

GraphicsUnit.Point, 0);

btnQuanLyPhong.ForeColor = SystemColors.ButtonHighlight;

btnQuanLyPhong.Image = Properties.Resources.MenuPhong;

btnQuanLyPhong.ImageAlign = ContentAlignment.MiddleLeft;

btnQuanLyPhong.Location = new Point(0, 135);

btnQuanLyPhong.Margin = new Padding(3, 4, 3, 4);

btnQuanLyPhong.Name = "btnQuanLyPhong";

btnQuanLyPhong.Size = new Size(304, 51);

btnQuanLyPhong.TabIndex = 6;

btnQuanLyPhong.Text = "Phòng";

btnQuanLyPhong.UseVisualStyleBackColor = false;

//

// button12

//

button12.BackColor = Color.DarkCyan;

button12.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular,

GraphicsUnit.Point, 0);

button12.ForeColor = SystemColors.ButtonHighlight;

button12.Image = Properties.Resources.MenuTienNghi;

button12.ImageAlign = ContentAlignment.MiddleLeft;

button12.Location = new Point(-2, 429);

button12.Margin = new Padding(3, 4, 3, 4);

button12.Name = "button12";

button12.Size = new Size(306, 51);

button12.TabIndex = 15;

button12.Text = "Danh sách tiện nghi";

button12.UseVisualStyleBackColor = false;

//

// button11

Lập trình trực quan

Ths. Nguyễn Thiện Dương Trang 27

//

button11.BackColor = Color.DarkCyan;

button11.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular,

GraphicsUnit.Point, 0);

button11.ForeColor = SystemColors.ButtonHighlight;

button11.Image = Properties.Resources.MenuQuanLyDichVu;

button11.ImageAlign = ContentAlignment.MiddleLeft;

button11.Location = new Point(-2, 370);

button11.Margin = new Padding(3, 4, 3, 4);

button11.Name = "button11";

button11.Size = new Size(305, 51);

button11.TabIndex = 14;

button11.Text = "Danh sách dịch vụ";

button11.UseVisualStyleBackColor = false;

//

// btnSoDoPhong

//

btnSoDoPhong.AllowDrop = true;

btnSoDoPhong.BackColor = Color.DarkCyan;

btnSoDoPhong.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular,

GraphicsUnit.Point, 0);

btnSoDoPhong.ForeColor = SystemColors.ButtonHighlight;

btnSoDoPhong.Image = Properties.Resources.MenuSoDoPhong;

btnSoDoPhong.ImageAlign = ContentAlignment.MiddleLeft;

btnSoDoPhong.Location = new Point(0, 76);

btnSoDoPhong.Margin = new Padding(3, 4, 3, 4);

btnSoDoPhong.Name = "btnSoDoPhong";

btnSoDoPhong.Size = new Size(304, 51);

btnSoDoPhong.TabIndex = 5;

btnSoDoPhong.Text = "Sơ đồ phòng";

btnSoDoPhong.UseVisualStyleBackColor = false;

//

// button9

//

Lập trình trực quan

Ths. Nguyễn Thiện Dương Trang 28

button9.BackColor = Color.DarkCyan;

button9.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular,

GraphicsUnit.Point, 0);

button9.ForeColor = SystemColors.ButtonHighlight;

button9.Image = Properties.Resources.MenuDatPhong;

button9.ImageAlign = ContentAlignment.MiddleLeft;

button9.Location = new Point(-1, 252);

button9.Margin = new Padding(3, 4, 3, 4);

button9.Name = "button9";

button9.Size = new Size(305, 51);

button9.TabIndex = 12;

button9.Text = "Danh sách đặt phòng";

button9.UseVisualStyleBackColor = false;

//

// button10

//

button10.BackColor = Color.DarkCyan;

button10.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular,

GraphicsUnit.Point, 0);

button10.ForeColor = SystemColors.ButtonHighlight;

button10.Image = Properties.Resources.MenuDanhSachHoaDon;

button10.ImageAlign = ContentAlignment.MiddleLeft;

button10.Location = new Point(-1, 311);

button10.Margin = new Padding(3, 4, 3, 4);

button10.Name = "button10";

button10.Size = new Size(306, 51);

button10.TabIndex = 13;

button10.Text = "Danh sách hóa đơn";

button10.UseVisualStyleBackColor = false;

//

// FormMain

//

AutoScaleDimensions = new SizeF(8F, 20F);

AutoScaleMode = AutoScaleMode.Font;

Lập trình trực quan

Ths. Nguyễn Thiện Dương Trang 29

AutoScroll = true;

BackColor = Color.White;

BackgroundImageLayout = ImageLayout.None;

ClientSize = new Size(1745, 1055);

Controls.Add(panel4);

Controls.Add(panelMain);

Controls.Add(panel2);

Controls.Add(panel1);

Margin = new Padding(3, 4, 3, 4);

Name = "FormMain";

StartPosition = FormStartPosition.CenterScreen;

panel1.ResumeLayout(false);

panel1.PerformLayout();

((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();

panel2.ResumeLayout(false);

panel2.PerformLayout();

((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();

panel4.ResumeLayout(false);

ResumeLayout(false);

}

#endregion

private System.Windows.Forms.Panel panel1;

private System.Windows.Forms.PictureBox pictureBox1;

private System.Windows.Forms.Label labelTenKhachSan;

private System.Windows.Forms.Panel panel2;

private System.Windows.Forms.PictureBox pictureBox2;

private System.Windows.Forms.LinkLabel linkLabel1;

private System.Windows.Forms.Label lblTenNguoiDung;

private System.Windows.Forms.Panel panelMain;

private System.Windows.Forms.Button btnTrangChu;

private System.Windows.Forms.Panel panel4;

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 30

### private System.Windows.Forms.Button button5;

### private System.Windows.Forms.Button button4;

### private System.Windows.Forms.Button button7;

### private System.Windows.Forms.Button button6;

### private System.Windows.Forms.Button btnQuanLyPhong;

### private System.Windows.Forms.Button btnSoDoPhong;

### private System.Windows.Forms.Button button9;

### private System.Windows.Forms.Button button12;

### private System.Windows.Forms.Button button11;

### private System.Windows.Forms.Button button10;

### private System.Windows.Forms.Button button13;

### }

### }

### Bước 3: SV sử dụng mã nguồn tạm thời sau để xử lý chức năng trong file FormMain.cs

using HotelManagement.DangNhap;

namespace HotelManagement { public partial class FormMain: Form { public FormMain () { InitializeComponent(); HienThiThongTinNguoiDung(); }

private void linkLabel1_LinkClicked ( object sender, LinkLabelLinkClickedEventArgs e) { if (MessageBox.Show( "Bạn có chắc muốn đăng xuất?", "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

this.Hide(); using ( var formLogin = new FormDangNhap()) { if (formLogin.ShowDialog() == DialogResult.OK) { HienThiThongTinNguoiDung(); HienThiTrangChu(); this.Show(); } else { this.Close(); } } }

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 31

private void button13_Click ( object sender, EventArgs e) { HienThiDangPhatTrien ( "Thống kê"); }

private void btnTrangChu_Click ( object sender, EventArgs e) { HienThiTrangChu (); }

private void button5_Click ( object sender, EventArgs e) { HienThiDangPhatTrien ( "Danh sách tài khoản"); }

private void button4_Click ( object sender, EventArgs e) { HienThiDangPhatTrien ( "Loại phòng"); }

private void button7_Click ( object sender, EventArgs e) { HienThiDangPhatTrien ( "Danh sách nhân viên"); }

private void button6_Click ( object sender, EventArgs e) { HienThiDangPhatTrien ( "Danh sách khách hàng"); }

private void btnQuanLyPhong_Click ( object sender, EventArgs e) { HienThiDangPhatTrien ( "Phòng"); }

private void button12_Click ( object sender, EventArgs e) { HienThiDangPhatTrien ( "Danh sách tiện nghi"); }

private void button11_Click ( object sender, EventArgs e) { HienThiDangPhatTrien ( "Danh sách dịch vụ"); }

private void btnSoDoPhong_Click ( object sender, EventArgs e) { HienThiDangPhatTrien ( "Sơ đồ phòng"); }

private void button9_Click ( object sender, EventArgs e) { HienThiDangPhatTrien ( "Danh sách đặt phòng"); }

private void button10_Click ( object sender, EventArgs e) { HienThiDangPhatTrien ( "Danh sách hóa đơn"); }

private void FormMain_Load ( object sender, EventArgs e) { HienThiTrangChu (); }

private void HienThiThongTinNguoiDung ()

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 32

{ lblTenNguoiDung.Text = FormDangNhap.TenNV_DangNhap; lblTenNguoiDung.Left = (panel2.Width - lblTenNguoiDung.PreferredWidth) / 2; }

private void XoaNoiDungPanelMain () { foreach ( Control c in panelMain.Controls. Cast <Control >(). ToList ()) { panelMain.Controls. Remove ( c); c. Dispose (); } }

private void LoadUserControl ( UserControl uc) { XoaNoiDungPanelMain (); uc.Dock = DockStyle.Fill; panelMain.Controls. Add( uc); uc. BringToFront (); }

private void LoadFormCon ( Form formCon) { XoaNoiDungPanelMain (); formCon.TopLevel = false; formCon.FormBorderStyle = FormBorderStyle.None; formCon.Dock = DockStyle.Fill; panelMain.Controls. Add( formCon); formCon. Show(); }

private void HienThiTrangChu () { HienThiDangPhatTrien ( "Trang chủ"); }

private void HienThiDangPhatTrien ( string tenChucNang) { XoaNoiDungPanelMain (); panelMain.Controls. Add( new Label { Dock = DockStyle.Fill, Text = tenChucNang + Environment.NewLine + "(chức năng đang được xây dựng)", Font = new Font ( "Microsoft Sans Serif", 16F, FontStyle.Italic), ForeColor = Color.DarkCyan, TextAlign = ContentAlignment.MiddleCenter }); } } }

### Bước 4: Kết quả giao diện và chức năng sau khi chạy như hình sau:

Lập trình trực quan

Ths. Nguyễn Thiện Dương Trang 33

Bước 5: Tạo màn hình chào ở trang chủ. Click chuột phải vào thư mục Project → Add

→ Users Control (Windows Forms) → thêm mới form con đặt tên là FormTrangChu.cs

Bước 6: Xây dựng giao diện form màn hình chào trang chủ như sau:

Mã nguồn tương ứng trong file FormTrangChu.Designer.cs như sau: namespace HotelManagement { partial class FormTrangChu { /// <summary> /// Required designer variable. /// </summary> private System.ComponentModel. IContainer components = null;

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 34

/// <summary> /// Clean up any resources being used. /// </summary> /// <param name=" disposing "> true if managed resources should be disposed; otherwise, false. </param> protected override void Dispose ( bool disposing) { if ( disposing && (components != null)) { components. Dispose (); } base. Dispose ( disposing); }

#region Component Designer generated code

/// <summary> /// Required method for Designer support - do not modify /// the contents of this method with the code editor. /// </summary> private void InitializeComponent () { System.ComponentModel. ComponentResourceManager resources = new System.ComponentModel. ComponentResourceManager ( typeof ( FormTrangChu)); pictureBox1 = new PictureBox (); ((System.ComponentModel. ISupportInitialize)pictureBox1). BeginInit (); SuspendLayout (); // // pictureBox1 // pictureBox1.Dock = DockStyle.Fill; pictureBox1.Image = ( Image) resources. GetObject ( "pictureBox1.Image"); pictureBox1.Location = new Point (0, 0); pictureBox1.Margin = new Padding (3, 4, 3, 4); pictureBox1.Name = "pictureBox1"; pictureBox1.Size = new Size (843, 889); pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; pictureBox1.TabIndex = 1; pictureBox1.TabStop = false; // // FormTrangChu // AutoScaleDimensions = new SizeF (8F, 20F); AutoScaleMode = AutoScaleMode.Font; Controls. Add(pictureBox1); Margin = new Padding (3, 4, 3, 4); Name = "FormTrangChu"; Size = new Size (843, 889); ((System.ComponentModel. ISupportInitialize)pictureBox1). EndInit (); ResumeLayout ( false);

}

#endregion

private System.Windows.Forms. PictureBox pictureBox1; } }

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 35

### Bước7: SV sử dụng mã nguồn tạm thời sau để xử lý chức năng trong file FormMain.cs

using HotelManagement.DangNhap;

namespace HotelManagement { public partial class FormMain: Form { public FormMain () { InitializeComponent (); HienThiThongTinNguoiDung (); }

private void linkLabel1_LinkClicked ( object sender, LinkLabelLinkClickedEventArgs e) { if ( MessageBox. Show( "Bạn có chắc muốn đăng xuất?", "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

this. Hide (); using ( var formLogin = new FormDangNhap ()) { if ( formLogin. ShowDialog () == DialogResult.OK) { HienThiThongTinNguoiDung (); HienThiTrangChu (); this. Show(); } else { this. Close (); } } }

private void button13_Click ( object sender, EventArgs e) { HienThiDangPhatTrien ( "Thống kê"); }

private void btnTrangChu_Click ( object sender, EventArgs e) { HienThiTrangChu (); // Bấm "Trang chủ" thì quay lại màn hình UserControl FormTrangChu }

private void button5_Click ( object sender, EventArgs e) { HienThiDangPhatTrien ( "Danh sách tài khoản"); }

private void button4_Click ( object sender, EventArgs e) { HienThiDangPhatTrien ( "Loại phòng"); }

private void button7_Click ( object sender, EventArgs e) { HienThiDangPhatTrien ( "Danh sách nhân viên"); }

private void button6_Click ( object sender, EventArgs e) {

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 36

HienThiDangPhatTrien ( "Danh sách khách hàng"); }

private void btnQuanLyPhong_Click ( object sender, EventArgs e) { HienThiDangPhatTrien ( "Phòng"); }

private void button12_Click ( object sender, EventArgs e) { HienThiDangPhatTrien ( "Danh sách tiện nghi"); }

private void button11_Click ( object sender, EventArgs e) { HienThiDangPhatTrien ( "Danh sách dịch vụ"); }

private void btnSoDoPhong_Click ( object sender, EventArgs e) { HienThiDangPhatTrien ( "Sơ đồ phòng"); }

private void button9_Click ( object sender, EventArgs e) { HienThiDangPhatTrien ( "Danh sách đặt phòng"); }

private void button10_Click ( object sender, EventArgs e) { HienThiDangPhatTrien ( "Danh sách hóa đơn"); }

private void FormMain_Load ( object sender, EventArgs e) { HienThiTrangChu (); }

private void HienThiThongTinNguoiDung () { lblTenNguoiDung.Text = FormDangNhap.TenNV_DangNhap; lblTenNguoiDung.Left = (panel2.Width - lblTenNguoiDung.PreferredWidth) / 2; }

private void XoaNoiDungPanelMain () { foreach ( Control c in panelMain.Controls. Cast <Control >(). ToList ()) { panelMain.Controls. Remove ( c); c. Dispose (); } }

private void LoadUserControl ( UserControl uc) { XoaNoiDungPanelMain (); uc.Dock = DockStyle.Fill; panelMain.Controls. Add( uc); uc. BringToFront (); }

private void LoadFormCon ( Form formCon) { XoaNoiDungPanelMain (); formCon.TopLevel = false; formCon.FormBorderStyle = FormBorderStyle.None;

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 37

formCon.Dock = DockStyle.Fill; panelMain.Controls. Add( formCon); formCon. Show(); }

private void HienThiTrangChu () { if (panelMain.Controls.Count == 1 && panelMain.Controls[0] is FormTrangChu) return;

LoadUserControl ( new FormTrangChu ()); }

private void HienThiDangPhatTrien ( string tenChucNang) { XoaNoiDungPanelMain (); panelMain.Controls. Add( new Label { Dock = DockStyle.Fill, Text = tenChucNang + Environment.NewLine + "(chức năng đang được xây dựng)", Font = new Font ( "Microsoft Sans Serif", 16F, FontStyle.Italic), ForeColor = Color.DarkCyan, TextAlign = ContentAlignment.MiddleCenter }); } } }

### 6. Xây dựng giao diện và chức năng thể hiện sơ đồ thông tin phòng khách sạn

### Bước 1: Click chuột phải vào thư mục project → Add → New Folder → Đặt tên

### folder là SoDoPhong

## Bước 2: Click chuột phải vào folder SoDoPhong → Add → Forms( Windows

### Forms) → tạo một form thể hiện sơ đồ phòng khách sạn là FormSoDoPhong.cs

### Bước 3: Thiết kế giao diện FormSoDoPhong.cs theo mẫu như sau:

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 38

### Mã nguồn tham khảo trong file FormSoDoPhong.Designer.cs tạm thời như sau:

namespace HotelManagement.SoDoPhong { partial class FormSoDoPhong { /// <summary> /// Required designer variable. /// </summary> private System.ComponentModel.IContainer components = null;

/// <summary> /// Clean up any resources being used. /// </summary> /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param> protected override void Dispose(bool disposing) { if (disposing && (components != null)) { components.Dispose(); } base.Dispose(disposing); }

#region Windows Form Designer generated code

/// <summary> /// Required method for Designer support - do not modify /// the contents of this method with the code editor. /// </summary> private void InitializeComponent() { components = new System.ComponentModel.Container(); panel1 = new Panel(); panel4 = new Panel(); rdbTatCaPhong = new RadioButton(); rdbPhongChuaDon = new RadioButton(); rdbPhongDaDonDep = new RadioButton(); label2 = new Label(); panel3 = new Panel(); rdbTatCaLoaiPhong = new RadioButton(); rdbPhongVipDoi = new RadioButton(); rdbPhongVipDon = new RadioButton(); rdbPhongThuongDoi = new RadioButton(); rdbPhongThuongDon = new RadioButton(); label1 = new Label(); panel2 = new Panel(); rdbTatCaTrangThaiPhong = new RadioButton(); rdbPhongDangSuaChua = new RadioButton(); rdbPhongDangThue = new RadioButton(); rdbPhongDaDat = new RadioButton(); rdbPhongTrong = new RadioButton(); LabelTrangThaiPhong = new Label(); panel5 = new Panel(); pictureBox1 = new PictureBox(); txtSearchMaPhong = new TextBox(); label4 = new Label(); dateTimePicker2 = new DateTimePicker(); label3 = new Label(); dtNgayChon = new DateTimePicker(); toolTip1 = new ToolTip(components); btnDatPhong = new Button(); dataGridViewPhong = new DataGridView(); panel1.SuspendLayout(); panel4.SuspendLayout();

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 39

panel3.SuspendLayout(); panel2.SuspendLayout(); panel5.SuspendLayout(); ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit(); ((System.ComponentModel.ISupportInitialize)dataGridViewPhong).BeginInit(); SuspendLayout(); // // panel1 // panel1.BackColor = Color.GreenYellow; panel1.Controls.Add(panel4); panel1.Controls.Add(panel3); panel1.Controls.Add(panel2); panel1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); panel1.Location = new Point(0, - 1); panel1.Margin = new Padding(3, 4, 3, 4); panel1.Name = "panel1"; panel1.Size = new Size(267, 788); panel1.TabIndex = 0; // // panel4 // panel4.Controls.Add(rdbTatCaPhong); panel4.Controls.Add(rdbPhongChuaDon); panel4.Controls.Add(rdbPhongDaDonDep); panel4.Controls.Add(label2); panel4.Location = new Point(12, 595); panel4.Margin = new Padding(3, 4, 3, 4); panel4.Name = "panel4"; panel4.Size = new Size(246, 188); panel4.TabIndex = 8; // // rdbTatCaPhong // rdbTatCaPhong.AutoSize = true; rdbTatCaPhong.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); rdbTatCaPhong.Location = new Point(9, 149); rdbTatCaPhong.Margin = new Padding(3, 4, 3, 4); rdbTatCaPhong.Name = "rdbTatCaPhong"; rdbTatCaPhong.Size = new Size(88, 29); rdbTatCaPhong.TabIndex = 4; rdbTatCaPhong.TabStop = true; rdbTatCaPhong.Text = "Tất cả"; rdbTatCaPhong.UseVisualStyleBackColor = true; // // rdbPhongChuaDon // rdbPhongChuaDon.AutoSize = true; rdbPhongChuaDon.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); rdbPhongChuaDon.Location = new Point(9, 105); rdbPhongChuaDon.Margin = new Padding(3, 4, 3, 4); rdbPhongChuaDon.Name = "rdbPhongChuaDon"; rdbPhongChuaDon.Size = new Size(157, 29); rdbPhongChuaDon.TabIndex = 3; rdbPhongChuaDon.TabStop = true; rdbPhongChuaDon.Text = "Chưa dọn dẹp"; rdbPhongChuaDon.UseVisualStyleBackColor = true; // // rdbPhongDaDonDep // rdbPhongDaDonDep.AutoSize = true; rdbPhongDaDonDep.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 40

rdbPhongDaDonDep.Location = new Point(9, 61); rdbPhongDaDonDep.Margin = new Padding(3, 4, 3, 4); rdbPhongDaDonDep.Name = "rdbPhongDaDonDep"; rdbPhongDaDonDep.Size = new Size(134, 29); rdbPhongDaDonDep.TabIndex = 2; rdbPhongDaDonDep.TabStop = true; rdbPhongDaDonDep.Text = "Đã dọn dẹp"; rdbPhongDaDonDep.UseVisualStyleBackColor = true; // // label2 // label2.AutoSize = true; label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0); label2.Location = new Point(11, 18); label2.Name = "label2"; label2.Size = new Size(235, 32); label2.TabIndex = 1; label2.Text = "Tình trạng dọn dẹp"; // // panel3 // panel3.Controls.Add(rdbTatCaLoaiPhong); panel3.Controls.Add(rdbPhongVipDoi); panel3.Controls.Add(rdbPhongVipDon); panel3.Controls.Add(rdbPhongThuongDoi); panel3.Controls.Add(rdbPhongThuongDon); panel3.Controls.Add(label1); panel3.Location = new Point(6, 298); panel3.Margin = new Padding(3, 4, 3, 4); panel3.Name = "panel3"; panel3.Size = new Size(255, 279); panel3.TabIndex = 7; // // rdbTatCaLoaiPhong // rdbTatCaLoaiPhong.AutoSize = true; rdbTatCaLoaiPhong.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); rdbTatCaLoaiPhong.Location = new Point(9, 236); rdbTatCaLoaiPhong.Margin = new Padding(3, 4, 3, 4); rdbTatCaLoaiPhong.Name = "rdbTatCaLoaiPhong"; rdbTatCaLoaiPhong.Size = new Size(148, 29); rdbTatCaLoaiPhong.TabIndex = 7; rdbTatCaLoaiPhong.TabStop = true; rdbTatCaLoaiPhong.Text = "Tất cả phòng"; rdbTatCaLoaiPhong.UseVisualStyleBackColor = true; // // rdbPhongVipDoi // rdbPhongVipDoi.AutoSize = true; rdbPhongVipDoi.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); rdbPhongVipDoi.Location = new Point(9, 192); rdbPhongVipDoi.Margin = new Padding(3, 4, 3, 4); rdbPhongVipDoi.Name = "rdbPhongVipDoi"; rdbPhongVipDoi.Size = new Size(158, 29); rdbPhongVipDoi.TabIndex = 5; rdbPhongVipDoi.TabStop = true; rdbPhongVipDoi.Text = "Phòng VIP đôi"; rdbPhongVipDoi.UseVisualStyleBackColor = true; // // rdbPhongVipDon // rdbPhongVipDon.AutoSize = true;

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 41

rdbPhongVipDon.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); rdbPhongVipDon.Location = new Point(9, 149); rdbPhongVipDon.Margin = new Padding(3, 4, 3, 4); rdbPhongVipDon.Name = "rdbPhongVipDon"; rdbPhongVipDon.Size = new Size(165, 29); rdbPhongVipDon.TabIndex = 4; rdbPhongVipDon.TabStop = true; rdbPhongVipDon.Text = "Phòng VIP đơn"; rdbPhongVipDon.UseVisualStyleBackColor = true; // // rdbPhongThuongDoi // rdbPhongThuongDoi.AutoSize = true; rdbPhongThuongDoi.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); rdbPhongThuongDoi.Location = new Point(9, 105); rdbPhongThuongDoi.Margin = new Padding(3, 4, 3, 4); rdbPhongThuongDoi.Name = "rdbPhongThuongDoi"; rdbPhongThuongDoi.Size = new Size(186, 29); rdbPhongThuongDoi.TabIndex = 3; rdbPhongThuongDoi.TabStop = true; rdbPhongThuongDoi.Text = "Phòng thường đôi"; rdbPhongThuongDoi.UseVisualStyleBackColor = true; // // rdbPhongThuongDon // rdbPhongThuongDon.AutoSize = true; rdbPhongThuongDon.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); rdbPhongThuongDon.Location = new Point(9, 61); rdbPhongThuongDon.Margin = new Padding(3, 4, 3, 4); rdbPhongThuongDon.Name = "rdbPhongThuongDon"; rdbPhongThuongDon.Size = new Size(193, 29); rdbPhongThuongDon.TabIndex = 2; rdbPhongThuongDon.TabStop = true; rdbPhongThuongDon.Text = "Phòng thường đơn"; rdbPhongThuongDon.UseVisualStyleBackColor = true; // // label1 // label1.AutoSize = true; label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0); label1.Location = new Point(24, 12); label1.Name = "label1"; label1.Size = new Size(142, 32); label1.TabIndex = 1; label1.Text = "Loại phòng"; // // panel2 // panel2.Controls.Add(rdbTatCaTrangThaiPhong); panel2.Controls.Add(rdbPhongDangSuaChua); panel2.Controls.Add(rdbPhongDangThue); panel2.Controls.Add(rdbPhongDaDat); panel2.Controls.Add(rdbPhongTrong); panel2.Controls.Add(LabelTrangThaiPhong); panel2.Location = new Point(3, 0); panel2.Margin = new Padding(3, 4, 3, 4); panel2.Name = "panel2"; panel2.Size = new Size(255, 279); panel2.TabIndex = 1; // // rdbTatCaTrangThaiPhong //

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 42

rdbTatCaTrangThaiPhong.AutoSize = true; rdbTatCaTrangThaiPhong.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); rdbTatCaTrangThaiPhong.Location = new Point(9, 236); rdbTatCaTrangThaiPhong.Margin = new Padding(3, 4, 3, 4); rdbTatCaTrangThaiPhong.Name = "rdbTatCaTrangThaiPhong"; rdbTatCaTrangThaiPhong.Size = new Size(148, 29); rdbTatCaTrangThaiPhong.TabIndex = 6; rdbTatCaTrangThaiPhong.TabStop = true; rdbTatCaTrangThaiPhong.Text = "Tất cả phòng"; rdbTatCaTrangThaiPhong.UseVisualStyleBackColor = true; // // rdbPhongDangSuaChua // rdbPhongDangSuaChua.AutoSize = true; rdbPhongDangSuaChua.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); rdbPhongDangSuaChua.Location = new Point(9, 192); rdbPhongDangSuaChua.Margin = new Padding(3, 4, 3, 4); rdbPhongDangSuaChua.Name = "rdbPhongDangSuaChua"; rdbPhongDangSuaChua.Size = new Size(224, 29); rdbPhongDangSuaChua.TabIndex = 5; rdbPhongDangSuaChua.TabStop = true; rdbPhongDangSuaChua.Text = "Phòng đang sửa chữa"; rdbPhongDangSuaChua.UseVisualStyleBackColor = true; // // rdbPhongDangThue // rdbPhongDangThue.AutoSize = true; rdbPhongDangThue.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); rdbPhongDangThue.Location = new Point(9, 149); rdbPhongDangThue.Margin = new Padding(3, 4, 3, 4); rdbPhongDangThue.Name = "rdbPhongDangThue"; rdbPhongDangThue.Size = new Size(182, 29); rdbPhongDangThue.TabIndex = 4; rdbPhongDangThue.TabStop = true; rdbPhongDangThue.Text = "Phòng đang thuê"; rdbPhongDangThue.UseVisualStyleBackColor = true; // // rdbPhongDaDat // rdbPhongDaDat.AutoSize = true; rdbPhongDaDat.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); rdbPhongDaDat.Location = new Point(9, 105); rdbPhongDaDat.Margin = new Padding(3, 4, 3, 4); rdbPhongDaDat.Name = "rdbPhongDaDat"; rdbPhongDaDat.Size = new Size(149, 29); rdbPhongDaDat.TabIndex = 3; rdbPhongDaDat.TabStop = true; rdbPhongDaDat.Text = "Phòng đã đặt"; rdbPhongDaDat.UseVisualStyleBackColor = true; // // rdbPhongTrong // rdbPhongTrong.AutoSize = true; rdbPhongTrong.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); rdbPhongTrong.Location = new Point(9, 61); rdbPhongTrong.Margin = new Padding(3, 4, 3, 4); rdbPhongTrong.Name = "rdbPhongTrong"; rdbPhongTrong.Size = new Size(139, 29); rdbPhongTrong.TabIndex = 2; rdbPhongTrong.TabStop = true; rdbPhongTrong.Text = "Phòng trống";

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 43

rdbPhongTrong.UseVisualStyleBackColor = true; // // LabelTrangThaiPhong // LabelTrangThaiPhong.AutoSize = true; LabelTrangThaiPhong.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0); LabelTrangThaiPhong.Location = new Point(24, 12); LabelTrangThaiPhong.Name = "LabelTrangThaiPhong"; LabelTrangThaiPhong.Size = new Size(210, 32); LabelTrangThaiPhong.TabIndex = 1; LabelTrangThaiPhong.Text = "Trạng thái phòng"; // // panel5 // panel5.Controls.Add(pictureBox1); panel5.Controls.Add(txtSearchMaPhong); panel5.Controls.Add(label4); panel5.Controls.Add(dateTimePicker2); panel5.Controls.Add(label3); panel5.Controls.Add(dtNgayChon); panel5.Location = new Point(274, - 1); panel5.Margin = new Padding(3, 4, 3, 4); panel5.Name = "panel5"; panel5.Size = new Size(724, 66); panel5.TabIndex = 1; // // pictureBox1 // pictureBox1.Image = Properties.Resources.search; pictureBox1.Location = new Point(522, 16); pictureBox1.Margin = new Padding(3, 4, 3, 4); pictureBox1.Name = "pictureBox1"; pictureBox1.Size = new Size(30, 40); pictureBox1.TabIndex = 5; pictureBox1.TabStop = false; // // txtSearchMaPhong // txtSearchMaPhong.Location = new Point(563, 25); txtSearchMaPhong.Margin = new Padding(3, 4, 3, 4); txtSearchMaPhong.Name = "txtSearchMaPhong"; txtSearchMaPhong.Size = new Size(149, 27); txtSearchMaPhong.TabIndex = 4; // // label4 // label4.AutoSize = true; label4.Location = new Point(323, 11); label4.Name = "label4"; label4.Size = new Size(69, 20); label4.TabIndex = 3; label4.Text = "Chọn giờ"; // // dateTimePicker2 // dateTimePicker2.Location = new Point(269, 35); dateTimePicker2.Margin = new Padding(3, 4, 3, 4); dateTimePicker2.Name = "dateTimePicker2"; dateTimePicker2.Size = new Size(200, 27); dateTimePicker2.TabIndex = 2; // // label3 // label3.AutoSize = true; label3.Location = new Point(85, 11);

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 44

label3.Name = "label3"; label3.Size = new Size(79, 20); label3.TabIndex = 1; label3.Text = "Chọn ngày"; // // dtNgayChon // dtNgayChon.Location = new Point(31, 35); dtNgayChon.Margin = new Padding(3, 4, 3, 4); dtNgayChon.Name = "dtNgayChon"; dtNgayChon.Size = new Size(200, 27); dtNgayChon.TabIndex = 0; // // toolTip1 // toolTip1.ToolTipTitle = "Nhập số phòng"; // // btnDatPhong // btnDatPhong.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 0); btnDatPhong.ForeColor = Color.Blue; btnDatPhong.Location = new Point(1031, 10); btnDatPhong.Margin = new Padding(3, 4, 3, 4); btnDatPhong.Name = "btnDatPhong"; btnDatPhong.Size = new Size(166, 54); btnDatPhong.TabIndex = 3; btnDatPhong.Text = "Đặt phòng"; btnDatPhong.UseVisualStyleBackColor = true; // // dataGridViewPhong // dataGridViewPhong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize; dataGridViewPhong.Location = new Point(274, 74); dataGridViewPhong.Margin = new Padding(3, 4, 3, 4); dataGridViewPhong.Name = "dataGridViewPhong"; dataGridViewPhong.RowHeadersWidth = 51; dataGridViewPhong.RowTemplate.Height = 24; dataGridViewPhong.Size = new Size(990, 713); dataGridViewPhong.TabIndex = 4; // // FormSoDoPhong // AutoScaleDimensions = new SizeF(8F, 20F); AutoScaleMode = AutoScaleMode.Font; BackColor = Color.Honeydew; ClientSize = new Size(1276, 851); Controls.Add(dataGridViewPhong); Controls.Add(btnDatPhong); Controls.Add(panel5); Controls.Add(panel1); Margin = new Padding(3, 4, 3, 4); Name = "FormSoDoPhong"; StartPosition = FormStartPosition.CenterScreen; Text = "Sơ đồ phòng"; panel1.ResumeLayout(false); panel4.ResumeLayout(false); panel4.PerformLayout(); panel3.ResumeLayout(false); panel3.PerformLayout(); panel2.ResumeLayout(false); panel2.PerformLayout(); panel5.ResumeLayout(false); panel5.PerformLayout(); ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 45

((System.ComponentModel.ISupportInitialize)dataGridViewPhong).EndInit(); ResumeLayout(false);

}

#endregion

private System.Windows.Forms.Panel panel1; private System.Windows.Forms.Panel panel2; private System.Windows.Forms.Label LabelTrangThaiPhong; private System.Windows.Forms.RadioButton rdbPhongDangSuaChua; private System.Windows.Forms.RadioButton rdbPhongDangThue; private System.Windows.Forms.RadioButton rdbPhongDaDat; private System.Windows.Forms.RadioButton rdbPhongTrong; private System.Windows.Forms.Panel panel4; private System.Windows.Forms.RadioButton rdbTatCaPhong; private System.Windows.Forms.RadioButton rdbPhongChuaDon; private System.Windows.Forms.RadioButton rdbPhongDaDonDep; private System.Windows.Forms.Label label2; private System.Windows.Forms.Panel panel3; private System.Windows.Forms.RadioButton rdbPhongVipDoi; private System.Windows.Forms.RadioButton rdbPhongVipDon; private System.Windows.Forms.RadioButton rdbPhongThuongDoi; private System.Windows.Forms.RadioButton rdbPhongThuongDon; private System.Windows.Forms.Label label1; private System.Windows.Forms.RadioButton rdbTatCaTrangThaiPhong; private System.Windows.Forms.Panel panel5; private System.Windows.Forms.PictureBox pictureBox1; private System.Windows.Forms.TextBox txtSearchMaPhong; private System.Windows.Forms.Label label4; private System.Windows.Forms.DateTimePicker dateTimePicker2; private System.Windows.Forms.Label label3; private System.Windows.Forms.DateTimePicker dtNgayChon; private System.Windows.Forms.RadioButton rdbTatCaLoaiPhong; private System.Windows.Forms.ToolTip toolTip1; private System.Windows.Forms.Button btnDatPhong; private System.Windows.Forms.DataGridView dataGridViewPhong; } }

### Bước 4: SV sử dụng mã nguồn tạm thời sau để xử lý chức năng trong file

### FormSoDoPhong.cs

using System; using System.Collections.Generic; using System.ComponentModel; using System.Data; using System.Drawing; using System.Text; using System.Windows.Forms; using HotelManagement.Models; using Microsoft.EntityFrameworkCore;

namespace HotelManagement.SoDoPhong { public partial class FormSoDoPhong : Form { public FormSoDoPhong() { InitializeComponent(); }

private void FormSoDoPhong_Load(object sender, EventArgs e) {

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 46

// Đặt trạng thái ban đầu của các control, trong lúc này chưa cho các sự kiện lọc chạy _dangKhoiTao = true;

// Mỗi nhóm lọc mặc định chọn "Tất cả" rdbTatCaTrangThaiPhong.Checked = true; rdbTatCaLoaiPhong.Checked = true; rdbTatCaPhong.Checked = true;

// Ô chọn ngày có thêm checkbox: tick mới lọc "phòng còn trống theo ngày", bỏ tick thì xem tất cả dtNgayChon.ShowCheckBox = true; dtNgayChon.Checked = false;

// Gợi ý cho ô tìm kiếm (toolTip1 đã có sẵn trong Designer) toolTip1.SetToolTip(txtSearchMaPhong, "Ví dụ: 101, P20...");

// Cấu hình lưới dataGridViewPhong.ReadOnly = true; dataGridViewPhong.AllowUserToAddRows = false; dataGridViewPhong.AllowUserToDeleteRows = false; dataGridViewPhong.MultiSelect = false; dataGridViewPhong.SelectionMode = DataGridViewSelectionMode.FullRowSelect; dataGridViewPhong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

_dangKhoiTao = false; TaiLaiDanhSach(); // Load dữ liệu khi form được mở }

// ===== 13 radio button: cùng gọi LocTheoRadio, mọi tiêu chí được gom lại trong TaiLaiDanhSach() =====

private void rdbTatCaPhong_CheckedChanged(object sender, EventArgs e) { LocTheoRadio(sender); }

private void rdbPhongChuaDon_CheckedChanged(object sender, EventArgs e) { LocTheoRadio(sender); }

private void rdbPhongDaDonDep_CheckedChanged(object sender, EventArgs e) { LocTheoRadio(sender); }

private void rdbTatCaLoaiPhong_CheckedChanged(object sender, EventArgs e) { LocTheoRadio(sender); }

private void rdbPhongVipDoi_CheckedChanged(object sender, EventArgs e) { LocTheoRadio(sender); }

private void rdbPhongVipDon_CheckedChanged(object sender, EventArgs e) { LocTheoRadio(sender); }

private void rdbPhongThuongDoi_CheckedChanged(object sender, EventArgs e) { LocTheoRadio(sender);

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 47

}

private void rdbPhongThuongDon_CheckedChanged(object sender, EventArgs e) { LocTheoRadio(sender); }

private void rdbTatCaTrangThaiPhong_CheckedChanged(object sender, EventArgs e) { LocTheoRadio(sender); }

private void rdbPhongDangSuaChua_CheckedChanged(object sender, EventArgs e) { LocTheoRadio(sender); }

private void rdbPhongDangThue_CheckedChanged(object sender, EventArgs e) { LocTheoRadio(sender); }

private void rdbPhongDaDat_CheckedChanged(object sender, EventArgs e) { LocTheoRadio(sender); }

private void rdbPhongTrong_CheckedChanged(object sender, EventArgs e) { LocTheoRadio(sender); }

private void txtSearchMaPhong_TextChanged(object sender, EventArgs e) { // Gõ tới đâu lọc tới đó; ô rỗng thì tự hiện lại danh sách theo các tiêu chí đang chọn if (_dangKhoiTao) return; TaiLaiDanhSach(); }

private void dtNgayChon_ValueChanged(object sender, EventArgs e) { // Đổi ngày hoặc tick/bỏ tick checkbox đều chạy vào đây if (_dangKhoiTao) return; TaiLaiDanhSach(); }

private void btnDatPhong_Click(object sender, EventArgs e) { string? maPhong = MaPhongDangChon(); // Phòng đang chọn trong lưới (có thể null)

// Khi đã tạo FormDatPhong, thay MessageBox bên dưới bằng: // using (var fDatPhong = new FormDatPhong()) // { // // fDatPhong.MaPhong = maPhong; // nếu cần truyền mã phòng đang chọn // fDatPhong.ShowDialog(); //} // TaiLaiDanhSach(); // đặt xong thì tải lại trạng thái các phòng MessageBox.Show( "Chức năng đặt phòng đang được xây dựng." + (maPhong != null ? Environment.NewLine + "Phòng đang chọn: " + maPhong : ""), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 48

}

// ================= Các hàm hỗ trợ (viết thêm) =================

// true trong lúc khởi tạo giá trị mặc định ở Load, để các sự kiện không chạy truy vấn nhiều lần private bool _dangKhoiTao;

// Mỗi lần đổi radio, CheckedChanged chạy 2 lần (bỏ chọn nút cũ + chọn nút mới) => chỉ xử lý khi nút được chọn private void LocTheoRadio(object sender) { if (_dangKhoiTao) return; if (sender is RadioButton rdb && !rdb.Checked) return; TaiLaiDanhSach(); }

// Nhóm "Trạng thái phòng" - > giá trị cột TTPH (null = tất cả) private string? TrangThaiPhongDangChon() { if (rdbPhongTrong.Checked) return "Bình thường"; if (rdbPhongDaDat.Checked) return "Đã đặt"; if (rdbPhongDangThue.Checked) return "Đang thuê"; if (rdbPhongDangSuaChua.Checked) return "Đang sửa chữa"; return null; }

// Nhóm "Loại phòng" - > mã loại phòng MaLPH (null = tất cả) private string? MaLoaiPhongDangChon() { if (rdbPhongThuongDon.Checked) return "NOR01"; if (rdbPhongThuongDoi.Checked) return "NOR02"; if (rdbPhongVipDon.Checked) return "VIP01"; if (rdbPhongVipDoi.Checked) return "VIP02"; return null; }

// Nhóm "Tình trạng dọn dẹp" - > giá trị cột TTDD (null = tất cả) private string? TinhTrangDonDepDangChon() { if (rdbPhongDaDonDep.Checked) return "Đã dọn dẹp"; if (rdbPhongChuaDon.Checked) return "Chưa dọn dẹp"; return null; }

// Mã phòng của dòng đang chọn trong lưới private string? MaPhongDangChon() { return dataGridViewPhong.CurrentRow?.Cells["MaPH"].Value?.ToString(); }

// Tải lại lưới theo TẤT CẢ tiêu chí đang chọn: 3 nhóm radio + ô tìm mã phòng + (nếu tick) ngày còn trống private void TaiLaiDanhSach() { try { string? ttph = TrangThaiPhongDangChon(); string? maLph = MaLoaiPhongDangChon(); string? ttdd = TinhTrangDonDepDangChon(); string maPhong = txtSearchMaPhong.Text.Trim();

using var db = new HotelManagementContext();

// Phòng chưa bị xóa mềm (DaXoa là bool? nên "!= true" nhận cả NULL lẫn false)

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 49

var query = db.Phongs.AsNoTracking().Where(p => p.DaXoa != true);

if (ttph != null) query = query.Where(p => p.Ttph == ttph); if (maLph != null) query = query.Where(p => p.MaLph == maLph); if (ttdd != null) query = query.Where(p => p.Ttdd == ttdd); if (maPhong.Length > 0) query = query.Where(p => p.MaPh.Contains(maPhong));

// Lọc phòng còn trống vào ngày đã chọn: phòng "Bình thường" và không có phiếu đặt nào bao trùm ngày đó if (dtNgayChon.Checked) { DateTime ngayChon = dtNgayChon.Value.Date; query = query.Where(p => p.Ttph == "Bình thường" && !p.Ctdps.Any(c => c.DaXoa != true && ngayChon >= c.CheckIn.Date && ngayChon < c.CheckOut.Date)); }

var dsPhong = query .OrderBy(p => p.MaPh) .Select(p => new { p.MaPh, TenLph = p.MaLphNavigation.TenLph, p.Ttph, p.Ttdd, p.GhiChu }) .ToList();

// Tầng = ký tự thứ 2 của mã phòng (P101 - > 1), giống SUBSTRING(MaPH, 2, 1) ở bản cũ dataGridViewPhong.DataSource = dsPhong .Select(p => new { MaPH = p.MaPh, Tang = p.MaPh.Length > 1 ? p.MaPh.Substring(1, 1) : "", TenLPH = p.TenLph, TTPH = p.Ttph, TTDD = p.Ttdd, GhiChu = p.GhiChu }) .ToList();

// Cập nhật tên cột hiển thị DatTieuDeCot("MaPH", "Mã phòng"); DatTieuDeCot("Tang", "Tầng"); DatTieuDeCot("TenLPH", "Loại phòng"); DatTieuDeCot("TTPH", "Trạng thái phòng"); DatTieuDeCot("TTDD", "Tình trạng dọn dẹp"); DatTieuDeCot("GhiChu", "Ghi chú"); } catch (Exception ex) { MessageBox.Show("Lỗi tải danh sách phòng: " + ex.Message); } }

private void DatTieuDeCot(string tenCot, string tieuDe) { if (dataGridViewPhong.Columns.Contains(tenCot)) dataGridViewPhong.Columns[tenCot].HeaderText = tieuDe; } } }

Lập trình trực quan

Ths. Nguyễn Thiện Dương Trang 50

Bước 5: Chỉnh sửa lại hàm private void btnSoDoPhong_Click(object

sender, EventArgs e) trong file FormMain.cs theo nội dung như sau:

private void btnSoDoPhong_Click ( object sender, EventArgs e) { Form formCon = new SoDoPhong. FormSoDoPhong (); formCon.TopLevel = false; formCon.FormBorderStyle = FormBorderStyle.None; formCon.Dock = DockStyle.Fill; XoaNoiDungPanelMain (); // hàm có trong bản FormMain mình gửi trước; nếu chưa có, dùng panelMain.Controls.Clear(); panelMain.Controls. Add( formCon); formCon. Show(); }

Bước 6: Kết quả sau khi chạy như sau:

7. Xây dựng giao diện và chức năng quản lý thông tin phòng khách sạn

Bước 1: Click chuột phải vào thư mục project → Add → New Folder→ Đặt tên folder

là “Phong”

Bước 2: Click chuột phải vào folder Phong → Add → Forms( Windows Forms) → tạo

một form thể hiện sơ đồ phòng khách sạn là FormDanhSachPhong.cs

Bước 3: Thiết kế giao diện FormDanhSachPhong.cs theo mẫu như sau:

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 51

### Mã nguồn tham khảo trong file FormDanhSachPhong.Designer.cs tạm thời như sau:

namespace HotelManagement.Phong { partial class FormDanhSachPhong { /// <summary> /// Required designer variable. /// </summary> private System.ComponentModel. IContainer components = null;

/// <summary> /// Clean up any resources being used. /// </summary> /// <param name=" disposing "> true if managed resources should be disposed; otherwise, false. </param> protected override void Dispose ( bool disposing) { if ( disposing && (components != null)) { components. Dispose (); } base. Dispose ( disposing); }

#region Windows Form Designer generated code

/// <summary> /// Required method for Designer support - do not modify /// the contents of this method with the code editor. /// </summary> private void InitializeComponent () { this.txtTimKiem = new System.Windows.Forms. TextBox (); this.btnXuatExcel = new System.Windows.Forms. Button (); this.btnThemMoiPhong = new System.Windows.Forms. Button (); this.dtgDanhSachPhong = new System.Windows.Forms. DataGridView (); this.pictureBox1 = new System.Windows.Forms. PictureBox ();

((System.ComponentModel. ISupportInitialize)( this.dtgDanhSachPhong)). BeginInit (); ((System.ComponentModel. ISupportInitialize)( this.pictureBox1)). BeginInit (); this. SuspendLayout (); //

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 52

// txtTimKiem // this.txtTimKiem.Font = new System.Drawing. Font ( "Microsoft Sans Serif", 13F, System.Drawing. FontStyle.Regular, System.Drawing. GraphicsUnit.Point, (( byte)(0))); this.txtTimKiem.Location = new System.Drawing. Point (130, 12); this.txtTimKiem.Name = "txtTimKiem"; this.txtTimKiem.Size = new System.Drawing. Size (187, 32); this.txtTimKiem.TabIndex = 0; //this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged); // // btnXuatExcel // this.btnXuatExcel.BackColor = System.Drawing. Color.DarkTurquoise; this.btnXuatExcel.Font = new System.Drawing. Font ( "Microsoft Sans Serif", 12F, System.Drawing. FontStyle.Bold, System.Drawing. GraphicsUnit.Point, (( byte)(0))); this.btnXuatExcel.Location = new System.Drawing. Point (560, 12); this.btnXuatExcel.Name = "btnXuatExcel"; this.btnXuatExcel.Size = new System.Drawing. Size (167, 37); this.btnXuatExcel.TabIndex = 2; this.btnXuatExcel.Text = "Xuất file Excel"; this.btnXuatExcel.UseVisualStyleBackColor = false; //this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click); // // btnThemMoiPhong // this.btnThemMoiPhong.BackColor = System.Drawing. Color.MediumSpringGreen; this.btnThemMoiPhong.Font = new System.Drawing. Font ( "Microsoft Sans Serif", 12F, System.Drawing. FontStyle.Bold, System.Drawing. GraphicsUnit.Point, (( byte)(0))); this.btnThemMoiPhong.Location = new System.Drawing. Point (803, 12); this.btnThemMoiPhong.Name = "btnThemMoiPhong"; this.btnThemMoiPhong.Size = new System.Drawing. Size (188, 37); this.btnThemMoiPhong.TabIndex = 3; this.btnThemMoiPhong.Text = "Thêm mới phòng"; this.btnThemMoiPhong.UseVisualStyleBackColor = false; //this.btnThemMoiPhong.Click += new System.EventHandler(this.btnThemMoiPhong_Click); // // dtgDanhSachPhong // this.dtgDanhSachPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms. DataGridViewColumnHeadersHeightSizeMode.AutoSize; this.dtgDanhSachPhong.Location = new System.Drawing. Point (12, 72); this.dtgDanhSachPhong.Name = "dtgDanhSachPhong"; this.dtgDanhSachPhong.RowHeadersWidth = 51; this.dtgDanhSachPhong.RowTemplate.Height = 24; this.dtgDanhSachPhong.Size = new System.Drawing. Size (1015, 615); this.dtgDanhSachPhong.TabIndex = 4; //this.dtgDanhSachPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDanhSachPhong_CellClick); // // pictureBox1 // this.pictureBox1.Image = global::HotelManagement.Properties. Resources.search; this.pictureBox1.Location = new System.Drawing. Point (85, 7); this.pictureBox1.Name = "pictureBox1"; this.pictureBox1.Size = new System.Drawing. Size (39, 37); this.pictureBox1.TabIndex = 1; this.pictureBox1.TabStop = false; // // FormDanhSachPhong // this.AutoScaleDimensions = new System.Drawing. SizeF (8F, 16F); this.AutoScaleMode = System.Windows.Forms. AutoScaleMode.Font;

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 53

this.ClientSize = new System.Drawing. Size (1039, 699); this.Controls. Add( this.dtgDanhSachPhong); this.Controls. Add( this.btnThemMoiPhong); this.Controls. Add( this.btnXuatExcel); this.Controls. Add( this.pictureBox1); this.Controls. Add( this.txtTimKiem); this.Name = "FormDanhSachPhong"; this.StartPosition = System.Windows.Forms. FormStartPosition.CenterScreen; this.Text = "Quản lý thông tin phòng"; //this.Load += new System.EventHandler(this.FormDanhSachPhong_Load);

((System.ComponentModel. ISupportInitialize)( this.dtgDanhSachPhong)). EndInit (); ((System.ComponentModel. ISupportInitialize)( this.pictureBox1)). EndInit (); this. ResumeLayout ( false); this. PerformLayout ();

}

#endregion

private System.Windows.Forms. TextBox txtTimKiem; private System.Windows.Forms. PictureBox pictureBox1; private System.Windows.Forms. Button btnXuatExcel; private System.Windows.Forms. Button btnThemMoiPhong; private System.Windows.Forms. DataGridView dtgDanhSachPhong; } }

### Bước 4: SV sử dụng mã nguồn tạm thời sau để xử lý chức năng trong file

### FormDanhSachPhong.cs

using ClosedXML.Excel; using HotelManagement.Models; using Microsoft.EntityFrameworkCore; using System; using System.Collections.Generic; using System.ComponentModel; using System.Data; using System.Drawing; using System.Text; using System.Windows.Forms;

namespace HotelManagement.Phong { public partial class FormDanhSachPhong: Form { private readonly Image _iconPhong = Properties.Resources.Phong; private readonly Image _iconSua = Properties.Resources.edit; private readonly Image _iconXoa = Properties.Resources.delete;

public FormDanhSachPhong () { InitializeComponent(); }

private void txtTimKiem_TextChanged ( object sender, EventArgs e) { LocTheoTuKhoa(); }

private void btnXuatExcel_Click ( object sender, EventArgs e) { var cacDong = dtgDanhSachPhong.Rows.Cast<DataGridViewRow>() .Where( r => r.Visible && !r.IsNewRow) .ToList();

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 54

if (cacDong.Count == 0) { MessageBox.Show( "Không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

using ( var hopLuu = new SaveFileDialog()) { hopLuu.Title = "Xuất danh sách phòng"; hopLuu.Filter = "Excel Workbook (*.xlsx)|*.xlsx"; hopLuu.FileName = $"DanhSachPhong_ {DateTime.Now: yyyyMMdd_HHmm}.xlsx";

if (hopLuu.ShowDialog() != DialogResult.OK) return;

try { using ( var wb = new XLWorkbook()) { var ws = wb.Worksheets.Add( "Danh sách phòng");

string [] tenCot = { "MaPH", "TTPH", "TTDD", "TenLPH"}; string [] tieuDe = { "Mã phòng", "Tình trạng phòng", "Dọn dẹp", "Loại phòng"};

for ( int c = 0; c < tenCot.Length; c++) ws.Cell(1, c + 1).Value = tieuDe[c]; ws.Row(1).Style.Font.Bold = true;

for ( int i = 0; i < cacDong.Count; i++) { for ( int c = 0; c < tenCot.Length; c++) ws.Cell(i + 2, c + 1).Value = cacDong[i].Cells[tenCot[c]].Value?.ToString() ?? ""; }

ws.Columns().AdjustToContents(); wb.SaveAs(hopLuu.FileName); }

var traLoi = MessageBox.Show( "Xuất dữ liệu thành công! \ nBạn có muốn mở file ngay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information); if (traLoi == DialogResult.Yes) { System.Diagnostics.Process.Start( new System.Diagnostics.ProcessStartInfo(hopLuu.FileName) { UseShellExecute = true}); } } catch (IOException) { MessageBox.Show( "Không ghi được file. Có thể file đang được mở trong Excel, hãy đóng lại rồi thử lần nữa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); } catch (Exception ex) { MessageBox.Show( "Lỗi khi xuất Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); } } }

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 55

private void btnThemMoiPhong_Click ( object sender, EventArgs e) { using ( var form = new FormThemPhong()) { form.ShowDialog(); }

LoadDanhSachPhong(); }

private void dtgDanhSachPhong_CellClick ( object sender, DataGridViewCellEventArgs e) { if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

string? maPhong = dtgDanhSachPhong.Rows[e.RowIndex].Cells[ "MaPH"].Value?.ToString(); if ( string.IsNullOrEmpty(maPhong)) return;

string tenCot = dtgDanhSachPhong.Columns[e.ColumnIndex].Name;

if (tenCot == "colSua") { using ( var formSua = new FormSuaPhong()) { formSua.ShowDialog(); } LoadDanhSachPhong(); } else if (tenCot == "colXoa") { DialogResult result = MessageBox.Show( $"Bạn có chắc muốn xóa phòng {maPhong} không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning); if (result == DialogResult.Yes) { XoaPhong(maPhong); LoadDanhSachPhong(); } } }

private void FormDanhSachPhong_Load ( object sender, EventArgs e) { CauHinhLuoi(); LoadDanhSachPhong(); }

private void CauHinhLuoi () { if (dtgDanhSachPhong.Columns.Count > 0) return;

dtgDanhSachPhong.ReadOnly = true; dtgDanhSachPhong.AllowUserToAddRows = false; dtgDanhSachPhong.AllowUserToDeleteRows = false; dtgDanhSachPhong.AllowUserToResizeRows = false; dtgDanhSachPhong.MultiSelect = false; dtgDanhSachPhong.SelectionMode = DataGridViewSelectionMode.FullRowSelect; dtgDanhSachPhong.RowHeadersVisible = false; dtgDanhSachPhong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; dtgDanhSachPhong.RowTemplate.Height = 40;

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 56

dtgDanhSachPhong.Columns. Add( TaoCotAnh ( "colIcon", "", _iconPhong)); dtgDanhSachPhong.Columns. Add( "MaPH", "Mã phòng"); dtgDanhSachPhong.Columns. Add( "TTPH", "Tình trạng phòng"); dtgDanhSachPhong.Columns. Add( "TTDD", "Dọn dẹp"); dtgDanhSachPhong.Columns. Add( "TenLPH", "Loại phòng"); dtgDanhSachPhong.Columns. Add( TaoCotAnh ( "colSua", "Sửa", _iconSua)); dtgDanhSachPhong.Columns. Add( TaoCotAnh ( "colXoa", "Xóa", _iconXoa)); }

private DataGridViewImageColumn TaoCotAnh ( string ten, string tieuDe, Image anh) { return new DataGridViewImageColumn { Name = ten, HeaderText = tieuDe, Image = anh, ImageLayout = DataGridViewImageCellLayout.Zoom, AutoSizeMode = DataGridViewAutoSizeColumnMode.None, Width = 50, Resizable = DataGridViewTriState.False, SortMode = DataGridViewColumnSortMode.NotSortable }; }

private void LoadDanhSachPhong () { try { using var db = new HotelManagementContext ();

var dsPhong = db.Phongs . AsNoTracking () . Where( p => p.DaXoa != true) . OrderBy ( p => p.MaPh) . Select ( p => new { p.MaPh, p.Ttph, p.Ttdd, TenLph = p.MaLphNavigation.TenLph }) . ToList ();

dtgDanhSachPhong.Rows. Clear ();

foreach ( var p in dsPhong) { dtgDanhSachPhong.Rows. Add( _iconPhong, p.MaPh, p.Ttph, p.Ttdd, p.TenLph, _iconSua, _iconXoa ); }

LocTheoTuKhoa (); } catch ( Exception ex) { MessageBox. Show( "Lỗi tải danh sách phòng: " + ex.Message); } }

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 57

private void LocTheoTuKhoa () { string keyword = txtTimKiem.Text. Trim ();

dtgDanhSachPhong.CurrentCell = null;

foreach ( DataGridViewRow row in dtgDanhSachPhong.Rows) { string maPhong = row.Cells[ "MaPH"].Value?. ToString () ?? ""; row.Visible = keyword.Length == 0 || maPhong. Contains ( keyword, StringComparison.OrdinalIgnoreCase); } }

private void XoaPhong ( string maPhong) { try { using var db = new HotelManagementContext ();

var phong = db.Phongs. FirstOrDefault ( p => p.MaPh == maPhong && p.DaXoa != true);

if ( phong == null) { MessageBox. Show( "Không tìm thấy phòng để xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

if ( phong.Ttph == "Đang thuê" || phong.Ttph == "Đã đặt") { MessageBox. Show( $"Phòng { maPhong} đang ở trạng thái \ " { phong.Ttph} \ " nên không thể xóa.", "Không thể xóa", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

phong.DaXoa = true; db. SaveChanges ();

MessageBox. Show( "Đã xóa phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); } catch ( Exception ex) { MessageBox. Show( "Lỗi khi xóa phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); } } } }

### Bước 5: Chỉnh sửa lại hàm private void btnQuanLyPhong_Click(object

### sender, EventArgs e)trong file FormMain.cs theo nội dung như sau:

private void btnQuanLyPhong_Click ( object sender, EventArgs e) { Form formCon = new Phong. FormDanhSachPhong (); formCon.TopLevel = false; formCon.FormBorderStyle = FormBorderStyle.None; formCon.Dock = DockStyle.Fill; XoaNoiDungPanelMain (); panelMain.Controls. Add( formCon);

Lập trình trực quan

Ths. Nguyễn Thiện Dương Trang 58

formCon. Show(); }

Bước 6: Click chuột phải vào folder Phong → Add → Forms( Windows Forms) → tạo

một form để xây dựng giao diện và chức năng thêm mới thông tin 1 phòng là

FormThemPhong.cs

Bước 7: Thiết kế giao diện FormThemPhong.cs theo mẫu như sau:

Mã nguồn tham khảo trong file FormThemPhong.Designer.cs tạm thời như sau: namespace HotelManagement.Phong { partial class FormThemPhong { /// <summary> /// Required designer variable. /// </summary> private System.ComponentModel. IContainer components = null;

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 59

/// <summary> /// Clean up any resources being used. /// </summary> /// <param name=" disposing "> true if managed resources should be disposed; otherwise, false. </param> protected override void Dispose ( bool disposing) { if ( disposing && (components != null)) { components. Dispose (); } base. Dispose ( disposing); }

#region Windows Form Designer generated code

/// <summary> /// Required method for Designer support - do not modify /// the contents of this method with the code editor. /// </summary> private void InitializeComponent () { btnThoat = new Button (); btnThemMoi = new Button (); panel1 = new Panel (); txtMaPhong = new TextBox (); label5 = new Label(); txtGhiChu = new RichTextBox(); label4 = new Label(); cbLoaiPhong = new ComboBox(); label3 = new Label(); cbTinhTrangDonDep = new ComboBox(); label2 = new Label(); cbTrangThaiPhong = new ComboBox(); label1 = new Label(); panel1.SuspendLayout(); SuspendLayout(); // // btnThoat // btnThoat.BackColor = SystemColors.GradientActiveCaption; btnThoat.Font = new Font( "Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); btnThoat.Location = new Point(332, 502); btnThoat.Margin = new Padding(3, 4, 3, 4); btnThoat.Name = "btnThoat"; btnThoat.Size = new Size(137, 59); btnThoat.TabIndex = 13; btnThoat.Text = "Thoát"; btnThoat.UseVisualStyleBackColor = false; btnThoat.Click += btnThoat_Click; // // btnThemMoi // btnThemMoi.BackColor = Color.Moccasin; btnThemMoi.Font = new Font( "Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); btnThemMoi.Location = new Point(132, 502); btnThemMoi.Margin = new Padding(3, 4, 3, 4); btnThemMoi.Name = "btnThemMoi"; btnThemMoi.Size = new Size(137, 59); btnThemMoi.TabIndex = 12; btnThemMoi.Text = "Thêm mới"; btnThemMoi.UseVisualStyleBackColor = false; btnThemMoi.Click += btnThemMoi_Click; //

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 60

// panel1 // panel1.Controls.Add(txtMaPhong); panel1.Controls.Add(label5); panel1.Controls.Add(txtGhiChu); panel1.Controls.Add(label4); panel1.Controls.Add(cbLoaiPhong); panel1.Controls.Add(label3); panel1.Controls.Add(cbTinhTrangDonDep); panel1.Controls.Add(label2); panel1.Controls.Add(cbTrangThaiPhong); panel1.Controls.Add(label1); panel1.Location = new Point(44, 38); panel1.Margin = new Padding(3, 4, 3, 4); panel1.Name = "panel1"; panel1.Size = new Size(507, 458); panel1.TabIndex = 11; // // txtMaPhong // txtMaPhong.Font = new Font( "Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); txtMaPhong.Location = new Point(203, 69); txtMaPhong.Margin = new Padding(3, 4, 3, 4); txtMaPhong.Name = "txtMaPhong"; txtMaPhong.Size = new Size(211, 30); txtMaPhong.TabIndex = 17; // // label5 // label5.AutoSize = true; label5.Font = new Font( "Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0); label5.Location = new Point(60, 65); label5.Name = "label5"; label5.Size = new Size(137, 26); label5.TabIndex = 16; label5.Text = "Mã số phòng"; // // txtGhiChu // txtGhiChu.Location = new Point(203, 319); txtGhiChu.Margin = new Padding(3, 4, 3, 4); txtGhiChu.Name = "txtGhiChu"; txtGhiChu.Size = new Size(275, 119); txtGhiChu.TabIndex = 15; txtGhiChu.Text = ""; // // label4 // label4.AutoSize = true; label4.Font = new Font( "Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0); label4.Location = new Point(110, 319); label4.Name = "label4"; label4.Size = new Size(87, 26); label4.TabIndex = 14; label4.Text = "Ghi chú"; // // cbLoaiPhong // cbLoaiPhong.Font = new Font( "Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); cbLoaiPhong.FormattingEnabled = true; cbLoaiPhong.Items.AddRange( new object [] { "Đã dọn dẹp", "Chưa dọn dẹp"}); cbLoaiPhong.Location = new Point(203, 190);

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 61

cbLoaiPhong.Margin = new Padding(3, 4, 3, 4); cbLoaiPhong.Name = "cbLoaiPhong"; cbLoaiPhong.Size = new Size(275, 33); cbLoaiPhong.TabIndex = 13; // // label3 // label3.AutoSize = true; label3.Font = new Font( "Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0); label3.Location = new Point(78, 190); label3.Name = "label3"; label3.Size = new Size(119, 26); label3.TabIndex = 12; label3.Text = "Loại phòng"; // // cbTinhTrangDonDep // cbTinhTrangDonDep.Font = new Font( "Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); cbTinhTrangDonDep.FormattingEnabled = true; cbTinhTrangDonDep.Items.AddRange( new object [] { "Đã dọn dẹp", "Chưa dọn dẹp"}); cbTinhTrangDonDep.Location = new Point(203, 256); cbTinhTrangDonDep.Margin = new Padding(3, 4, 3, 4); cbTinhTrangDonDep.Name = "cbTinhTrangDonDep"; cbTinhTrangDonDep.Size = new Size(275, 33); cbTinhTrangDonDep.TabIndex = 11; // // label2 // label2.AutoSize = true; label2.Font = new Font( "Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0); label2.Location = new Point(5, 259); label2.Name = "label2"; label2.Size = new Size(192, 26); label2.TabIndex = 10; label2.Text = "Tình trạng dọn dẹp"; // // cbTrangThaiPhong // cbTrangThaiPhong.Font = new Font( "Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); cbTrangThaiPhong.FormattingEnabled = true; cbTrangThaiPhong.Items.AddRange( new object [] { "Bình thường", "Đang sửa chữa"}); cbTrangThaiPhong.Location = new Point(203, 125); cbTrangThaiPhong.Margin = new Padding(3, 4, 3, 4); cbTrangThaiPhong.Name = "cbTrangThaiPhong"; cbTrangThaiPhong.Size = new Size(275, 33); cbTrangThaiPhong.TabIndex = 9; // // label1 // label1.AutoSize = true; label1.Font = new Font( "Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0); label1.Location = new Point(23, 128); label1.Name = "label1"; label1.Size = new Size(174, 26); label1.TabIndex = 8; label1.Text = "Trạng thái phòng"; // // FormThemPhong //

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 62

AutoScaleDimensions = new SizeF(8F, 20F); AutoScaleMode = AutoScaleMode.Font; ClientSize = new Size(595, 588); Controls.Add(btnThoat); Controls.Add(btnThemMoi); Controls.Add(panel1); Margin = new Padding(3, 4, 3, 4); Name = "FormThemPhong"; Text = "FormThemPhong"; Load += FormThemPhong_Load; panel1. ResumeLayout ( false); panel1. PerformLayout (); ResumeLayout ( false);

}

#endregion

private System.Windows.Forms. Button btnThoat; private System.Windows.Forms. Button btnThemMoi; private System.Windows.Forms. Panel panel1; private System.Windows.Forms. RichTextBox txtGhiChu; private System.Windows.Forms. Label label4; private System.Windows.Forms. ComboBox cbLoaiPhong; private System.Windows.Forms. Label label3; private System.Windows.Forms. ComboBox cbTinhTrangDonDep; private System.Windows.Forms. Label label2; private System.Windows.Forms. ComboBox cbTrangThaiPhong; private System.Windows.Forms. Label label1; private System.Windows.Forms. TextBox txtMaPhong; private System.Windows.Forms. Label label5; } }

### Bước 8: SV sử dụng mã nguồn tạm thời sau để xử lý chức năng trong file

### FormThemPhong.cs

using System; using System.Collections.Generic; using System.ComponentModel; using System.Data; using System.Drawing; using System.Text; using System.Windows.Forms; using HotelManagement.Models; using Microsoft.EntityFrameworkCore;

namespace HotelManagement.Phong { public partial class FormThemPhong: Form { public FormThemPhong () { InitializeComponent ();

Text = "Thêm mới phòng"; StartPosition = FormStartPosition.CenterParent; FormBorderStyle = FormBorderStyle.FixedDialog; MaximizeBox = false; MinimizeBox = false; AcceptButton = btnThemMoi; CancelButton = btnThoat; }

private void FormThemPhong_Load ( object sender, EventArgs e)

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 63

{ txtMaPhong.MaxLength = 5; txtGhiChu.MaxLength = 100;

cbTrangThaiPhong.DropDownStyle = ComboBoxStyle.DropDownList; cbTinhTrangDonDep.DropDownStyle = ComboBoxStyle.DropDownList; cbLoaiPhong.DropDownStyle = ComboBoxStyle.DropDownList;

try { using var db = new HotelManagementContext ();

var dsLoaiPhong = db.LoaiPhongs . AsNoTracking () . OrderBy ( l => l.MaLph) . Select ( l => new { l.MaLph, l.TenLph }) . ToList ();

cbLoaiPhong.Items. Clear (); cbLoaiPhong.DisplayMember = "TenLph"; cbLoaiPhong.ValueMember = "MaLph"; cbLoaiPhong.DataSource = dsLoaiPhong; } catch ( Exception ex) { MessageBox. Show( "Lỗi tải danh sách loại phòng: " + ex.Message); }

if (cbTrangThaiPhong.Items.Count > 0) cbTrangThaiPhong.SelectedIndex = 0; if (cbTinhTrangDonDep.Items.Count > 0) cbTinhTrangDonDep.SelectedIndex = 0;

txtMaPhong. Focus (); }

private void btnThemMoi_Click ( object sender, EventArgs e) { string maPH = txtMaPhong.Text. Trim (). ToUpper (); string trangThai = cbTrangThaiPhong.Text; string donDep = cbTinhTrangDonDep.Text; string? maLPH = cbLoaiPhong.SelectedValue?. ToString (); string ghiChu = txtGhiChu.Text. Trim ();

if ( maPH.Length == 0) { MessageBox. Show( "Vui lòng nhập mã phòng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtMaPhong. Focus (); return; }

if ( string. IsNullOrEmpty ( maLPH)) { MessageBox. Show( "Vui lòng chọn loại phòng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); cbLoaiPhong. Focus (); return; }

if ( trangThai.Length == 0 || donDep.Length == 0) { MessageBox. Show( "Vui lòng chọn trạng thái phòng và tình trạng dọn dẹp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 64

try { using var db = new HotelManagementContext ();

var tonTai = db.Phongs. FirstOrDefault ( p => p.MaPh == maPH);

if ( tonTai!= null) { if ( tonTai.DaXoa != true) { MessageBox. Show( "Mã phòng đã tồn tại. Vui lòng nhập mã khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtMaPhong. Focus (); return; }

var traLoi = MessageBox. Show( $"Mã phòng { maPH} từng bị xóa trước đây. \ nBạn có muốn khôi phục phòng này với thông tin vừa nhập không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question); if ( traLoi!= DialogResult.Yes) return;

tonTai.Ttph = trangThai; tonTai.Ttdd = donDep; tonTai.GhiChu = ghiChu.Length == 0 ? null: ghiChu; tonTai.MaLph = maLPH; tonTai.DaXoa = false; } else { db.Phongs. Add( new Models. Phong { MaPh = maPH, Ttph = trangThai, Ttdd = donDep, GhiChu = ghiChu.Length == 0 ? null: ghiChu, MaLph = maLPH, DaXoa = false }); }

int result = db. SaveChanges (); if ( result > 0) { MessageBox. Show( "Thêm phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); DialogResult = DialogResult.OK; this. Close (); } else { MessageBox. Show( "Không thể thêm phòng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); } } catch ( DbUpdateException ex) { MessageBox. Show( "Lỗi khi thêm phòng: " + ( ex.InnerException?.Message ?? ex.Message), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); } catch ( Exception ex) {

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 65

MessageBox. Show( "Lỗi khi thêm phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); } }

private void btnThoat_Click ( object sender, EventArgs e) { DialogResult = DialogResult.Cancel; this. Close (); } } }

### Bước 9: Click chuột phải vào folder Phong → Add → Forms( Windows Forms) → tạo

### một form để xây dựng giao diện và chức năng cập nhật thông tin 1 phòng đang có là

### FormSuaPhong.cs

### Bước 10: Thiết kế giao diện FormSuaPhong.cs theo mẫu như sau:

### Mã nguồn tham khảo trong file FormSuaPhong.Designer.cs tạm thời như sau:

namespace HotelManagement.Phong { partial class FormSuaPhong { /// <summary> /// Required designer variable. /// </summary> private System.ComponentModel. IContainer components = null;

/// <summary>

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 66

/// Clean up any resources being used. /// </summary> /// <param name=" disposing "> true if managed resources should be disposed; otherwise, false. </param> protected override void Dispose ( bool disposing) { if ( disposing && (components != null)) { components. Dispose (); } base. Dispose ( disposing); }

#region Windows Form Designer generated code

/// <summary> /// Required method for Designer support - do not modify /// the contents of this method with the code editor. /// </summary> private void InitializeComponent () { cbTrangThaiPhong = new ComboBox (); label2 = new Label (); cbTinhTrangDonDep = new ComboBox (); label3 = new Label(); cbLoaiPhong = new ComboBox(); label4 = new Label(); txtGhiChu = new RichTextBox(); panel1 = new Panel(); label1 = new Label(); btnCapNhat = new Button(); btnThoat = new Button(); label5 = new Label(); panel1.SuspendLayout(); SuspendLayout(); // // cbTrangThaiPhong // cbTrangThaiPhong.Font = new Font( "Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); cbTrangThaiPhong.FormattingEnabled = true; cbTrangThaiPhong.Items.AddRange( new object [] { "Bình thường", "Đã đặt", "Đang thuê", "Đang sửa chữa"}); cbTrangThaiPhong.Location = new Point(208, 36); cbTrangThaiPhong.Margin = new Padding(3, 4, 3, 4); cbTrangThaiPhong.Name = "cbTrangThaiPhong"; cbTrangThaiPhong.Size = new Size(275, 33); cbTrangThaiPhong.TabIndex = 9; // // label2 // label2.AutoSize = true; label2.Font = new Font( "Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0); label2.Location = new Point(10, 170); label2.Name = "label2"; label2.Size = new Size(192, 26); label2.TabIndex = 10; label2.Text = "Tình trạng dọn dẹp"; // // cbTinhTrangDonDep // cbTinhTrangDonDep.Font = new Font( "Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); cbTinhTrangDonDep.FormattingEnabled = true;

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 67

cbTinhTrangDonDep.Items.AddRange( new object [] { "Đã dọn dẹp", "Chưa dọn dẹp"}); cbTinhTrangDonDep.Location = new Point(208, 168); cbTinhTrangDonDep.Margin = new Padding(3, 4, 3, 4); cbTinhTrangDonDep.Name = "cbTinhTrangDonDep"; cbTinhTrangDonDep.Size = new Size(275, 33); cbTinhTrangDonDep.TabIndex = 11; // // label3 // label3.AutoSize = true; label3.Font = new Font( "Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0); label3.Location = new Point(83, 101); label3.Name = "label3"; label3.Size = new Size(119, 26); label3.TabIndex = 12; label3.Text = "Loại phòng"; // // cbLoaiPhong // cbLoaiPhong.Font = new Font( "Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); cbLoaiPhong.FormattingEnabled = true; cbLoaiPhong.Items.AddRange( new object [] { "Đã dọn dẹp", "Chưa dọn dẹp"}); cbLoaiPhong.Location = new Point(208, 101); cbLoaiPhong.Margin = new Padding(3, 4, 3, 4); cbLoaiPhong.Name = "cbLoaiPhong"; cbLoaiPhong.Size = new Size(275, 33); cbLoaiPhong.TabIndex = 13; // // label4 // label4.AutoSize = true; label4.Font = new Font( "Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0); label4.Location = new Point(115, 230); label4.Name = "label4"; label4.Size = new Size(87, 26); label4.TabIndex = 14; label4.Text = "Ghi chú"; // // txtGhiChu // txtGhiChu.Location = new Point(208, 230); txtGhiChu.Margin = new Padding(3, 4, 3, 4); txtGhiChu.Name = "txtGhiChu"; txtGhiChu.Size = new Size(275, 119); txtGhiChu.TabIndex = 15; txtGhiChu.Text = ""; // // panel1 // panel1.Controls.Add(txtGhiChu); panel1.Controls.Add(label4); panel1.Controls.Add(cbLoaiPhong); panel1.Controls.Add(label3); panel1.Controls.Add(cbTinhTrangDonDep); panel1.Controls.Add(label2); panel1.Controls.Add(cbTrangThaiPhong); panel1.Controls.Add(label1); panel1.Location = new Point(65, 100); panel1.Margin = new Padding(3, 4, 3, 4); panel1.Name = "panel1"; panel1.Size = new Size(507, 375); panel1.TabIndex = 8;

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 68

// // label1 // label1.AutoSize = true; label1.Font = new Font( "Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0); label1.Location = new Point(28, 39); label1.Name = "label1"; label1.Size = new Size(174, 26); label1.TabIndex = 8; label1.Text = "Trạng thái phòng"; // // btnCapNhat // btnCapNhat.BackColor = Color.Moccasin; btnCapNhat.Font = new Font( "Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); btnCapNhat.Location = new Point(153, 498); btnCapNhat.Margin = new Padding(3, 4, 3, 4); btnCapNhat.Name = "btnCapNhat"; btnCapNhat.Size = new Size(137, 59); btnCapNhat.TabIndex = 9; btnCapNhat.Text = "Cập nhật"; btnCapNhat.UseVisualStyleBackColor = false; btnCapNhat.Click += btnCapNhat_Click; // // btnThoat // btnThoat.BackColor = SystemColors.GradientActiveCaption; btnThoat.Font = new Font( "Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); btnThoat.Location = new Point(353, 498); btnThoat.Margin = new Padding(3, 4, 3, 4); btnThoat.Name = "btnThoat"; btnThoat.Size = new Size(137, 59); btnThoat.TabIndex = 10; btnThoat.Text = "Thoát"; btnThoat.UseVisualStyleBackColor = false; btnThoat.Click += btnThoat_Click; // // label5 // label5.AutoSize = true; label5.Font = new Font( "Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, 0); label5.ForeColor = Color.FromArgb(192, 64, 0); label5.Location = new Point(123, 30); label5.Name = "label5"; label5.Size = new Size(341, 31); label5.TabIndex = 15; label5.Text = "Cập nhật thông tin phòng"; // // FormSuaPhong // AutoScaleDimensions = new SizeF(8F, 20F); AutoScaleMode = AutoScaleMode.Font; ClientSize = new Size(626, 615); Controls.Add(label5); Controls.Add(btnThoat); Controls.Add(btnCapNhat); Controls.Add(panel1); Margin = new Padding(3, 4, 3, 4); Name = "FormSuaPhong"; Text = "FormSuaPhong"; panel1. ResumeLayout ( false); panel1. PerformLayout ();

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 69

ResumeLayout ( false); PerformLayout ();

}

#endregion

private System.Windows.Forms. ComboBox cbTrangThaiPhong; private System.Windows.Forms. Label label2; private System.Windows.Forms. ComboBox cbTinhTrangDonDep; private System.Windows.Forms. Label label3; private System.Windows.Forms. ComboBox cbLoaiPhong; private System.Windows.Forms. Label label4; private System.Windows.Forms. RichTextBox txtGhiChu; private System.Windows.Forms. Panel panel1; private System.Windows.Forms. Label label1; private System.Windows.Forms. Button btnCapNhat; private System.Windows.Forms. Button btnThoat; private System.Windows.Forms. Label label5; } }

### Bước 11: SV sử dụng mã nguồn tạm thời sau để xử lý chức năng trong file

### FormSuaPhong.cs

using System; using System.Collections.Generic; using System.ComponentModel; using System.Data; using System.Drawing; using System.Text; using System.Windows.Forms; using HotelManagement.Models; using Microsoft.EntityFrameworkCore;

namespace HotelManagement.Phong { public partial class FormSuaPhong: Form { private string? maPhong;

public FormSuaPhong () { InitializeComponent();

Text = "Cập nhật thông tin phòng"; StartPosition = FormStartPosition.CenterParent; FormBorderStyle = FormBorderStyle.FixedDialog; MaximizeBox = false; MinimizeBox = false; AcceptButton = btnCapNhat; CancelButton = btnThoat;

txtGhiChu.MaxLength = 100;

cbTrangThaiPhong.DropDownStyle = ComboBoxStyle.DropDownList; cbTinhTrangDonDep.DropDownStyle = ComboBoxStyle.DropDownList; cbLoaiPhong.DropDownStyle = ComboBoxStyle.DropDownList; }

public FormSuaPhong ( string maPhong) : this () { this.maPhong = maPhong;

Text = $"Cập nhật phòng {maPhong} ";

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 70

label5.Text = $"Cập nhật thông tin phòng {maPhong} ";

LoadLoaiPhong(); LoadThongTinPhong(); }

private void btnCapNhat_Click ( object sender, EventArgs e) { if ( string.IsNullOrEmpty(maPhong)) { MessageBox.Show( "Chưa xác định được phòng cần cập nhật.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

string trangThai = cbTrangThaiPhong.Text; string donDep = cbTinhTrangDonDep.Text; string? maLPH = cbLoaiPhong.SelectedValue?. ToString (); string ghiChu = txtGhiChu.Text. Trim ();

if ( string. IsNullOrEmpty ( maLPH)) { MessageBox. Show( "Vui lòng chọn loại phòng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); cbLoaiPhong. Focus (); return; }

if ( trangThai.Length == 0 || donDep.Length == 0) { MessageBox. Show( "Vui lòng chọn trạng thái phòng và tình trạng dọn dẹp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

try { using var db = new HotelManagementContext ();

var phong = db.Phongs. FirstOrDefault ( p => p.MaPh == maPhong && p.DaXoa != true);

if ( phong == null) { MessageBox. Show( "Không tìm thấy phòng cần cập nhật (có thể đã bị xóa).", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

phong.Ttph = trangThai; phong.Ttdd = donDep; phong.MaLph = maLPH; phong.GhiChu = ghiChu.Length == 0 ? null: ghiChu;

int rows = db. SaveChanges ();

if ( rows > 0) { MessageBox. Show( "Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); DialogResult = DialogResult.OK; this. Close (); } else

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 71

{ MessageBox. Show( "Thông tin không thay đổi nên không có gì để cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); } } catch ( DbUpdateException ex) { MessageBox. Show( "Lỗi khi cập nhật phòng: " + ( ex.InnerException?.Message ?? ex.Message), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); } catch ( Exception ex) { MessageBox. Show( "Lỗi khi cập nhật phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); } }

private void btnThoat_Click ( object sender, EventArgs e) { DialogResult = DialogResult.Cancel; this. Close (); }

private void LoadLoaiPhong () { try { using var db = new HotelManagementContext ();

var dsLoaiPhong = db.LoaiPhongs . AsNoTracking () . OrderBy ( l => l.MaLph) . Select ( l => new { l.MaLph, l.TenLph }) . ToList ();

cbLoaiPhong.Items. Clear (); cbLoaiPhong.DisplayMember = "TenLph"; cbLoaiPhong.ValueMember = "MaLph"; cbLoaiPhong.DataSource = dsLoaiPhong; } catch ( Exception ex) { MessageBox. Show( "Lỗi tải danh sách loại phòng: " + ex.Message); } }

private void LoadThongTinPhong () { try { using var db = new HotelManagementContext ();

var thongTin = db.Phongs . AsNoTracking () . Where( p => p.MaPh == maPhong && p.DaXoa != true) . Select ( p => new { p.Ttph, p.Ttdd, p.MaLph, p.GhiChu }) . FirstOrDefault ();

if ( thongTin == null) { MessageBox. Show( "Không tìm thấy phòng " + maPhong + ".", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); btnCapNhat.Enabled = false; return;

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 72

}

cbTrangThaiPhong.SelectedIndex = cbTrangThaiPhong. FindStringExact ( thongTin.Ttph); cbTinhTrangDonDep.SelectedIndex = cbTinhTrangDonDep. FindStringExact ( thongTin.Ttdd); cbLoaiPhong.SelectedValue = thongTin.MaLph; txtGhiChu.Text = thongTin.GhiChu ?? ""; } catch ( Exception ex) { MessageBox. Show( "Lỗi tải thông tin phòng: " + ex.Message); btnCapNhat.Enabled = false; } } } }

### Bước 11: SV sử dụng mã nguồn sau để cập nhật lại chọn chức năng “Sửa” hoặc “Xóa”

### trong file FormDanhSachPhong.cs

using ClosedXML.Excel; using HotelManagement.Models; using Microsoft.EntityFrameworkCore; using System; using System.Collections.Generic; using System.ComponentModel; using System.Data; using System.Drawing; using System.Text; using System.Windows.Forms;

namespace HotelManagement.Phong { public partial class FormDanhSachPhong: Form { private readonly Image _iconPhong = Properties. Resources.Phong; private readonly Image _iconSua = Properties. Resources.edit; private readonly Image _iconXoa = Properties. Resources.delete;

public FormDanhSachPhong () { InitializeComponent (); }

private void txtTimKiem_TextChanged ( object sender, EventArgs e) { LocTheoTuKhoa (); }

private void btnXuatExcel_Click ( object sender, EventArgs e) { var cacDong = dtgDanhSachPhong.Rows. Cast <DataGridViewRow >() . Where( r => r.Visible && ! r.IsNewRow) . ToList ();

if ( cacDong.Count == 0) { MessageBox. Show( "Không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

using ( var hopLuu = new SaveFileDialog ()) {

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 73

hopLuu.Title = "Xuất danh sách phòng"; hopLuu.Filter = "Excel Workbook (*.xlsx)|*.xlsx"; hopLuu.FileName = $"DanhSachPhong_ { DateTime.Now: yyyyMMdd_HHmm}.xlsx";

if ( hopLuu. ShowDialog () != DialogResult.OK) return;

try { using ( var wb = new XLWorkbook ()) { var ws = wb.Worksheets. Add( "Danh sách phòng");

string [] tenCot = { "MaPH", "TTPH", "TTDD", "TenLPH"}; string [] tieuDe = { "Mã phòng", "Tình trạng phòng", "Dọn dẹp", "Loại phòng"};

for ( int c = 0; c < tenCot.Length; c++) ws. Cell (1, c + 1).Value = tieuDe [ c]; ws. Row(1).Style.Font.Bold = true;

for ( int i = 0; i < cacDong.Count; i ++) { for ( int c = 0; c < tenCot.Length; c++) ws. Cell ( i + 2, c + 1).Value = cacDong [ i].Cells[ tenCot [ c]].Value?. ToString () ?? ""; }

ws. Columns (). AdjustToContents (); wb. SaveAs ( hopLuu.FileName); }

var traLoi = MessageBox. Show( "Xuất dữ liệu thành công! \ nBạn có muốn mở file ngay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information); if ( traLoi == DialogResult.Yes) { System.Diagnostics. Process. Start ( new System.Diagnostics. ProcessStartInfo ( hopLuu.FileName) { UseShellExecute = true}); } } catch ( IOException) { MessageBox. Show( "Không ghi được file. Có thể file đang được mở trong Excel, hãy đóng lại rồi thử lần nữa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); } catch ( Exception ex) { MessageBox. Show( "Lỗi khi xuất Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); } } }

private void btnThemMoiPhong_Click ( object sender, EventArgs e) { using ( var form = new FormThemPhong ()) { form. ShowDialog (); }

LoadDanhSachPhong (); }

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 74

private void dtgDanhSachPhong_CellClick ( object sender, DataGridViewCellEventArgs e) { if ( e.RowIndex < 0 || e.ColumnIndex < 0) return;

string? maPhong = dtgDanhSachPhong.Rows[ e.RowIndex].Cells[ "MaPH"].Value?. ToString (); if ( string. IsNullOrEmpty ( maPhong)) return;

string tenCot = dtgDanhSachPhong.Columns[ e.ColumnIndex].Name;

if ( tenCot == "colSua") { using ( var formSua = new FormSuaPhong ( maPhong)) { formSua. ShowDialog (); } LoadDanhSachPhong (); } else if ( tenCot == "colXoa") { DialogResult result = MessageBox. Show( $"Bạn có chắc muốn xóa phòng { maPhong} không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning); if ( result == DialogResult.Yes) { XoaPhong ( maPhong); LoadDanhSachPhong (); } } }

private void FormDanhSachPhong_Load ( object sender, EventArgs e) { CauHinhLuoi (); LoadDanhSachPhong (); }

private void CauHinhLuoi () { if (dtgDanhSachPhong.Columns.Count > 0) return;

dtgDanhSachPhong.ReadOnly = true; dtgDanhSachPhong.AllowUserToAddRows = false; dtgDanhSachPhong.AllowUserToDeleteRows = false; dtgDanhSachPhong.AllowUserToResizeRows = false; dtgDanhSachPhong.MultiSelect = false; dtgDanhSachPhong.SelectionMode = DataGridViewSelectionMode.FullRowSelect; dtgDanhSachPhong.RowHeadersVisible = false; dtgDanhSachPhong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; dtgDanhSachPhong.RowTemplate.Height = 40;

dtgDanhSachPhong.Columns. Add( TaoCotAnh ( "colIcon", "", _iconPhong)); dtgDanhSachPhong.Columns. Add( "MaPH", "Mã phòng"); dtgDanhSachPhong.Columns. Add( "TTPH", "Tình trạng phòng"); dtgDanhSachPhong.Columns. Add( "TTDD", "Dọn dẹp"); dtgDanhSachPhong.Columns. Add( "TenLPH", "Loại phòng"); dtgDanhSachPhong.Columns. Add( TaoCotAnh ( "colSua", "Sửa", _iconSua)); dtgDanhSachPhong.Columns. Add( TaoCotAnh ( "colXoa", "Xóa", _iconXoa)); }

private DataGridViewImageColumn TaoCotAnh ( string ten, string tieuDe, Image anh)

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 75

{ return new DataGridViewImageColumn { Name = ten, HeaderText = tieuDe, Image = anh, ImageLayout = DataGridViewImageCellLayout.Zoom, AutoSizeMode = DataGridViewAutoSizeColumnMode.None, Width = 50, Resizable = DataGridViewTriState.False, SortMode = DataGridViewColumnSortMode.NotSortable }; }

private void LoadDanhSachPhong () { try { using var db = new HotelManagementContext ();

var dsPhong = db.Phongs . AsNoTracking () . Where( p => p.DaXoa != true) . OrderBy ( p => p.MaPh) . Select ( p => new { p.MaPh, p.Ttph, p.Ttdd, TenLph = p.MaLphNavigation.TenLph }) . ToList ();

dtgDanhSachPhong.Rows. Clear ();

foreach ( var p in dsPhong) { dtgDanhSachPhong.Rows. Add( _iconPhong, p.MaPh, p.Ttph, p.Ttdd, p.TenLph, _iconSua, _iconXoa ); }

LocTheoTuKhoa (); } catch ( Exception ex) { MessageBox. Show( "Lỗi tải danh sách phòng: " + ex.Message); } }

private void LocTheoTuKhoa () { string keyword = txtTimKiem.Text. Trim ();

dtgDanhSachPhong.CurrentCell = null;

foreach ( DataGridViewRow row in dtgDanhSachPhong.Rows) { string maPhong = row.Cells[ "MaPH"].Value?. ToString () ?? ""; row.Visible = keyword.Length == 0

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 76

|| maPhong. Contains ( keyword, StringComparison.OrdinalIgnoreCase); } }

private void XoaPhong ( string maPhong) { try { using var db = new HotelManagementContext ();

var phong = db.Phongs. FirstOrDefault ( p => p.MaPh == maPhong && p.DaXoa != true);

if ( phong == null) { MessageBox. Show( "Không tìm thấy phòng để xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

if ( phong.Ttph == "Đang thuê" || phong.Ttph == "Đã đặt") { MessageBox. Show( $"Phòng { maPhong} đang ở trạng thái \ " { phong.Ttph} \ " nên không thể xóa.", "Không thể xóa", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

phong.DaXoa = true; db. SaveChanges ();

MessageBox. Show( "Đã xóa phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); } catch ( Exception ex) { MessageBox. Show( "Lỗi khi xóa phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); } } } }

### 8. Xây dựng giao diện và chức năng quản lý thông tin loại phòng khách sạn

### Bước 1: Click chuột phải vào thư mục project → Add → New Folder→ Đặt tên folder

### là “LoaiPhong”

### Bước 2: Click chuột phải vào folder LoaiPhong → Add → Forms( Windows Forms)

### → tạo một form thể hiện danh sách loại phòng khách sạn là

### FormDanhSachLoaiPhong.cs

### Bước 3: Thiết kế giao diện FormDanhSachLoaiPhong.cs theo mẫu như sau:

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 77

### Mã nguồn tham khảo trong file FormDanhSachLoaiPhong.Designer.cs tạm thời như

### sau:

namespace HotelManagement.LoaiPhong { partial class FormDanhSachLoaiPhong { /// <summary> /// Required designer variable. /// </summary> private System.ComponentModel. IContainer components = null;

/// <summary> /// Clean up any resources being used. /// </summary> /// <param name=" disposing "> true if managed resources should be disposed; otherwise, false. </param> protected override void Dispose ( bool disposing) { if ( disposing && (components != null)) { components. Dispose (); } base. Dispose ( disposing); }

#region Windows Form Designer generated code

/// <summary> /// Required method for Designer support - do not modify /// the contents of this method with the code editor. /// </summary> private void InitializeComponent () { this.dtgDanhSachLoaiPhong = new System.Windows.Forms. DataGridView (); this.btnXuatExcel = new System.Windows.Forms. Button (); this.txtTimKiem = new System.Windows.Forms. TextBox (); this.pictureBox1 = new System.Windows.Forms. PictureBox (); this.btnThemMoi = new System.Windows.Forms. Button ();

((System.ComponentModel. ISupportInitialize)( this.dtgDanhSachLoaiPhong)). BeginInit (); ((System.ComponentModel. ISupportInitialize)( this.pictureBox1)). BeginInit (); this. SuspendLayout (); // // dtgDanhSachLoaiPhong //

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 78

this.dtgDanhSachLoaiPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms. DataGridViewColumnHeadersHeightSizeMode.AutoSize; this.dtgDanhSachLoaiPhong.Location = new System.Drawing. Point ( - 71, 66); this.dtgDanhSachLoaiPhong.Name = "dtgDanhSachLoaiPhong"; this.dtgDanhSachLoaiPhong.RowHeadersWidth = 51; this.dtgDanhSachLoaiPhong.RowTemplate.Height = 24; this.dtgDanhSachLoaiPhong.Size = new System.Drawing. Size (1015, 615); this.dtgDanhSachLoaiPhong.TabIndex = 9; //this.dtgDanhSachLoaiPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDanhSachLoaiPhong_CellClick); // // btnXuatExcel // this.btnXuatExcel.BackColor = System.Drawing. Color.DarkTurquoise; this.btnXuatExcel.Font = new System.Drawing. Font ( "Microsoft Sans Serif", 12F, System.Drawing. FontStyle.Bold, System.Drawing. GraphicsUnit.Point, (( byte)(0))); this.btnXuatExcel.Location = new System.Drawing. Point (546, 12); this.btnXuatExcel.Name = "btnXuatExcel"; this.btnXuatExcel.Size = new System.Drawing. Size (167, 37); this.btnXuatExcel.TabIndex = 7; this.btnXuatExcel.Text = "Xuất file Excel"; this.btnXuatExcel.UseVisualStyleBackColor = false; //this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click); // // txtTimKiem // this.txtTimKiem.Font = new System.Drawing. Font ( "Microsoft Sans Serif", 13F, System.Drawing. FontStyle.Regular, System.Drawing. GraphicsUnit.Point, (( byte)(0))); this.txtTimKiem.Location = new System.Drawing. Point (105, 17); this.txtTimKiem.Name = "txtTimKiem"; this.txtTimKiem.Size = new System.Drawing. Size (187, 32); this.txtTimKiem.TabIndex = 5; //this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged); // // pictureBox1 // this.pictureBox1.Image = global::HotelManagement.Properties. Resources.search; this.pictureBox1.Location = new System.Drawing. Point (60, 12); this.pictureBox1.Name = "pictureBox1"; this.pictureBox1.Size = new System.Drawing. Size (39, 37); this.pictureBox1.TabIndex = 6; this.pictureBox1.TabStop = false; // // btnThemMoi // this.btnThemMoi.BackColor = System.Drawing. Color.LightPink; this.btnThemMoi.Font = new System.Drawing. Font ( "Microsoft Sans Serif", 12F, System.Drawing. FontStyle.Bold, System.Drawing. GraphicsUnit.Point, (( byte)(0))); this.btnThemMoi.Location = new System.Drawing. Point (747, 12); this.btnThemMoi.Name = "btnThemMoi"; this.btnThemMoi.Size = new System.Drawing. Size (167, 37); this.btnThemMoi.TabIndex = 10; this.btnThemMoi.Text = "Thêm mới"; this.btnThemMoi.UseVisualStyleBackColor = false; //this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click); // // FormDanhSachLoaiPhong // this.AutoScaleDimensions = new System.Drawing. SizeF (8F, 16F); this.AutoScaleMode = System.Windows.Forms. AutoScaleMode.Font; this.ClientSize = new System.Drawing. Size (948, 683); this.Controls. Add( this.btnThemMoi); this.Controls. Add( this.dtgDanhSachLoaiPhong);

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 79

this.Controls. Add( this.btnXuatExcel); this.Controls. Add( this.pictureBox1); this.Controls. Add( this.txtTimKiem); this.Name = "FormDanhSachLoaiPhong"; this.StartPosition = System.Windows.Forms. FormStartPosition.CenterScreen; this.Text = "Quản lý thông tin loại phòng"; //this.Load += new System.EventHandler(this.FormDanhSachLoaiPhong_Load);

((System.ComponentModel. ISupportInitialize)( this.dtgDanhSachLoaiPhong)). EndInit (); ((System.ComponentModel. ISupportInitialize)( this.pictureBox1)). EndInit (); this. ResumeLayout ( false); this. PerformLayout ();

}

#endregion

private System.Windows.Forms. DataGridView dtgDanhSachLoaiPhong; private System.Windows.Forms. Button btnXuatExcel; private System.Windows.Forms. PictureBox pictureBox1; private System.Windows.Forms. TextBox txtTimKiem; private System.Windows.Forms. Button btnThemMoi; } }

### Bước 4: SV sử dụng mã nguồn tạm thời sau để xử lý chức năng trong file

### FormDanhSachLoaiPhong.cs

using System; using System.Collections.Generic; using System.ComponentModel; using System.Data; using System.Drawing; using System.Text; using System.Windows.Forms; using ClosedXML.Excel; using HotelManagement.Models; using Microsoft.EntityFrameworkCore;

namespace HotelManagement.LoaiPhong { public partial class FormDanhSachLoaiPhong : Form { private readonly Image _iconGiuong = Properties.Resources.Giuong; private readonly Image _iconTienNghi = Properties.Resources.details; private readonly Image _iconSua = Properties.Resources.edit;

public FormDanhSachLoaiPhong() { InitializeComponent(); Load += FormDanhSachLoaiPhong_Load; }

private void txtTimKiem_TextChanged(object sender, EventArgs e) { LocTheoTuKhoa(); }

private void btnXuatExcel_Click(object sender, EventArgs e) { var cacDong = dtgDanhSachLoaiPhong.Rows.Cast<DataGridViewRow>() .Where(r => r.Visible && !r.IsNewRow) .ToList();

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 80

if (cacDong.Count == 0) { MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

using (var hopLuu = new SaveFileDialog()) { hopLuu.Title = "Xuất danh sách loại phòng"; hopLuu.Filter = "Excel Workbook (*.xlsx)|*.xlsx"; hopLuu.FileName = $"DanhSachLoaiPhong_{DateTime.Now:yyyyMMdd_HHmm}.xlsx";

if (hopLuu.ShowDialog() != DialogResult.OK) return;

try { using (var wb = new XLWorkbook()) { var ws = wb.Worksheets.Add("Danh sách loại phòng");

string[] tenCot = { "MaLPH", "TenLPH", "SoGiuong", "SoNguoiToiDa", "GiaNgay", "GiaGio" };

for (int c = 0; c < tenCot.Length; c++) ws.Cell(1, c + 1).Value = dtgDanhSachLoaiPhong.Columns[tenCot[c]].HeaderText; ws.Row(1).Style.Font.Bold = true;

for (int i = 0; i < cacDong.Count; i++) { for (int c = 0; c < tenCot.Length; c++) { var o = ws.Cell(i + 2, c + 1); object? giaTri = cacDong[i].Cells[tenCot[c]].Value;

switch (giaTri) { case decimal d: o.Value = d; o.Style.NumberFormat.Format = "#,##0"; break; case int n: o.Value = n; break; default: o.Value = giaTri?.ToString() ?? ""; break; } } }

ws.Columns().AdjustToContents(); wb.SaveAs(hopLuu.FileName); }

var traLoi = MessageBox.Show("Xuất dữ liệu thành công! \ nBạn có muốn mở file ngay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information); if (traLoi == DialogResult.Yes) { System.Diagnostics.Process.Start( new System.Diagnostics.ProcessStartInfo(hopLuu.FileName) { UseShellExecute = true });

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 81

} } catch (IOException) { MessageBox.Show("Không ghi được file. Có thể file đang được mở trong Excel, hãy đóng lại rồi thử lần nữa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); } catch (Exception ex) { MessageBox.Show("Lỗi khi xuất Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); } } }

private void btnThemMoi_Click(object sender, EventArgs e) { using (var formThemLoaiPhong = new FormThemLoaiPhong()) { formThemLoaiPhong.ShowDialog(); }

LoadLoaiPhong(); }

private void dtgDanhSachLoaiPhong_CellClick(object sender, DataGridViewCellEventArgs e) { if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

var dong = dtgDanhSachLoaiPhong.Rows[e.RowIndex]; string? maLPH = dong.Cells["MaLPH"].Value?.ToString(); string? tenLPH = dong.Cells["TenLPH"].Value?.ToString();

if (string.IsNullOrEmpty(maLPH)) return;

string tenCot = dtgDanhSachLoaiPhong.Columns[e.ColumnIndex].Name;

if (tenCot == "colSua") { using (var formSua = new FormSuaLoaiPhong()) { formSua.Tag = maLPH; formSua.ShowDialog(); }

LoadLoaiPhong(); } else if (tenCot == "colTienNghi") { MessageBox.Show( $"Chức năng chi tiết tiện nghi của loại phòng {tenLPH} ({maLPH}) đang được xây dựng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); } }

private void FormDanhSachLoaiPhong_Load(object sender, EventArgs e) { CauHinhLuoi(); LoadLoaiPhong(); }

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 82

private void CauHinhLuoi() { if (dtgDanhSachLoaiPhong.Columns.Count > 0) return;

dtgDanhSachLoaiPhong.ReadOnly = true; dtgDanhSachLoaiPhong.AllowUserToAddRows = false; dtgDanhSachLoaiPhong.AllowUserToDeleteRows = false; dtgDanhSachLoaiPhong.AllowUserToResizeRows = false; dtgDanhSachLoaiPhong.MultiSelect = false; dtgDanhSachLoaiPhong.SelectionMode = DataGridViewSelectionMode.FullRowSelect; dtgDanhSachLoaiPhong.RowHeadersVisible = false; dtgDanhSachLoaiPhong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; dtgDanhSachLoaiPhong.RowTemplate.Height = 40;

dtgDanhSachLoaiPhong.Columns.Add(TaoCotAnh("colIcon", "", _iconGiuong,

50. );

dtgDanhSachLoaiPhong.Columns.Add("MaLPH", "Mã loại"); dtgDanhSachLoaiPhong.Columns.Add("TenLPH", "Tên loại"); dtgDanhSachLoaiPhong.Columns.Add("SoGiuong", "Số giường"); dtgDanhSachLoaiPhong.Columns.Add("SoNguoiToiDa", "Số người tối đa"); dtgDanhSachLoaiPhong.Columns.Add("GiaNgay", "Giá ngày"); dtgDanhSachLoaiPhong.Columns.Add("GiaGio", "Giá giờ");

dtgDanhSachLoaiPhong.Columns["GiaNgay"]!.DefaultCellStyle.Format = "N0"; dtgDanhSachLoaiPhong.Columns["GiaGio"]!.DefaultCellStyle.Format = "N0"; dtgDanhSachLoaiPhong.Columns["GiaNgay"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; dtgDanhSachLoaiPhong.Columns["GiaGio"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

dtgDanhSachLoaiPhong.Columns.Add(TaoCotAnh("colTienNghi", "Tiện nghi", _iconTienNghi, 60)); dtgDanhSachLoaiPhong.Columns.Add(TaoCotAnh("colSua", "Cập nhật", _iconSua,

70. );

}

private DataGridViewImageColumn TaoCotAnh(string ten, string tieuDe, Image anh, int doRong) { return new DataGridViewImageColumn { Name = ten, HeaderText = tieuDe, Image = anh, ImageLayout = DataGridViewImageCellLayout.Zoom, AutoSizeMode = DataGridViewAutoSizeColumnMode.None, Width = doRong, Resizable = DataGridViewTriState.False, SortMode = DataGridViewColumnSortMode.NotSortable }; }

private void LoadLoaiPhong() { try { using var db = new HotelManagementContext();

var dsLoaiPhong = db.LoaiPhongs .AsNoTracking() .OrderBy(l => l.MaLph) .Select(l => new

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 83

{ l.MaLph, l.TenLph, l.SoGiuong, l.SoNguoiToiDa, l.GiaNgay, l.GiaGio }) .ToList();

dtgDanhSachLoaiPhong.Rows.Clear();

foreach (var l in dsLoaiPhong) { dtgDanhSachLoaiPhong.Rows.Add( _iconGiuong, l.MaLph, l.TenLph, l.SoGiuong, l.SoNguoiToiDa, l.GiaNgay, l.GiaGio, _iconTienNghi, _iconSua ); }

LocTheoTuKhoa(); } catch (Exception ex) { MessageBox.Show("Lỗi khi tải loại phòng: " + ex.Message); } }

private void LocTheoTuKhoa() { string keyword = txtTimKiem.Text.Trim();

dtgDanhSachLoaiPhong.CurrentCell = null;

foreach (DataGridViewRow row in dtgDanhSachLoaiPhong.Rows) { string ma = row.Cells["MaLPH"].Value?.ToString() ?? ""; string ten = row.Cells["TenLPH"].Value?.ToString() ?? "";

row.Visible = keyword.Length == 0 || ma.Contains(keyword, StringComparison.OrdinalIgnoreCase) || ten.Contains(keyword, StringComparison.OrdinalIgnoreCase); } } } }

### Bước 5: Chỉnh sửa lại hàm private void button4_Click(object sender,

### EventArgs e)trong file FormMain.cs theo nội dung như sau:

private void button4_Click ( object sender, EventArgs e) { Form formCon = new LoaiPhong. FormDanhSachLoaiPhong (); formCon.TopLevel = false; formCon.FormBorderStyle = FormBorderStyle.None; formCon.Dock = DockStyle.Fill; XoaNoiDungPanelMain ();

Lập trình trực quan

Ths. Nguyễn Thiện Dương Trang 84

panelMain.Controls. Add( formCon); formCon. Show(); }

Bước 5: Click chuột phải vào folder LoaiPhong → Add → Forms( Windows Forms)

→ tạo một form để xây dựng giao diện và chức năng thêm mới thông tin 1 loại phòng

là FormThemLoaiPhong.cs

Bước 7: Thiết kế giao diện FormThemLoaiPhong.cs theo mẫu như sau:

Mã nguồn tham khảo trong file FormThemLoaiPhong.Designer.cs tạm thời như sau: namespace HotelManagement.LoaiPhong { partial class FormThemLoaiPhong { /// <summary> /// Required designer variable. /// </summary> private System.ComponentModel.IContainer components = null;

/// <summary> /// Clean up any resources being used. /// </summary>

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 85

/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param> protected override void Dispose(bool disposing) { if (disposing && (components != null)) { components.Dispose(); } base.Dispose(disposing); }

#region Windows Form Designer generated code

/// <summary> /// Required method for Designer support - do not modify /// the contents of this method with the code editor. /// </summary> private void InitializeComponent() { label5 = new Label(); btnThoat = new Button(); btnThemMoi = new Button(); panel1 = new Panel(); txtMaLoaiPhong = new TextBox(); label6 = new Label(); txtGiaGio = new TextBox(); labell = new Label(); txtGiaNgay = new TextBox(); label4 = new Label(); txtSoNguoiToiDa = new TextBox(); label3 = new Label(); txtSoGiuong = new TextBox(); label2 = new Label(); txtTenLP = new TextBox(); label1 = new Label(); panel1.SuspendLayout(); SuspendLayout(); // // label5 // label5.AutoSize = true; label5.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, 0); label5.ForeColor = Color.FromArgb(192, 64, 0); label5.Location = new Point(72, 31); label5.Name = "label5"; label5.Size = new Size(404, 31); label5.TabIndex = 18; label5.Text = "Thêm mới thông tin loại phòng"; // // btnThoat // btnThoat.BackColor = SystemColors.GradientActiveCaption; btnThoat.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); btnThoat.Location = new Point(297, 548); btnThoat.Margin = new Padding(3, 4, 3, 4); btnThoat.Name = "btnThoat"; btnThoat.Size = new Size(137, 59); btnThoat.TabIndex = 17; btnThoat.Text = "Thoát"; btnThoat.UseVisualStyleBackColor = false; btnThoat.Click += btnThoat_Click; // // btnThemMoi //

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 86

btnThemMoi.BackColor = Color.Moccasin; btnThemMoi.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); btnThemMoi.Location = new Point(97, 548); btnThemMoi.Margin = new Padding(3, 4, 3, 4); btnThemMoi.Name = "btnThemMoi"; btnThemMoi.Size = new Size(137, 59); btnThemMoi.TabIndex = 16; btnThemMoi.Text = "Thêm mới"; btnThemMoi.UseVisualStyleBackColor = false; btnThemMoi.Click += btnThemMoi_Click; // // panel1 // panel1.Controls.Add(txtMaLoaiPhong); panel1.Controls.Add(label6); panel1.Controls.Add(txtGiaGio); panel1.Controls.Add(labell); panel1.Controls.Add(txtGiaNgay); panel1.Controls.Add(label4); panel1.Controls.Add(txtSoNguoiToiDa); panel1.Controls.Add(label3); panel1.Controls.Add(txtSoGiuong); panel1.Controls.Add(label2); panel1.Controls.Add(txtTenLP); panel1.Controls.Add(label1); panel1.Location = new Point(21, 101); panel1.Margin = new Padding(3, 4, 3, 4); panel1.Name = "panel1"; panel1.Size = new Size(507, 439); panel1.TabIndex = 15; // // txtMaLoaiPhong // txtMaLoaiPhong.AcceptsReturn = true; txtMaLoaiPhong.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); txtMaLoaiPhong.Location = new Point(198, 29); txtMaLoaiPhong.Margin = new Padding(3, 4, 3, 4); txtMaLoaiPhong.Name = "txtMaLoaiPhong"; txtMaLoaiPhong.Size = new Size(275, 30); txtMaLoaiPhong.TabIndex = 26; // // label6 // label6.AutoSize = true; label6.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0); label6.Location = new Point(29, 29); label6.Name = "label6"; label6.Size = new Size(148, 26); label6.TabIndex = 25; label6.Text = "Mã loại phòng"; // // txtGiaGio // txtGiaGio.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); txtGiaGio.Location = new Point(201, 358); txtGiaGio.Margin = new Padding(3, 4, 3, 4); txtGiaGio.Name = "txtGiaGio"; txtGiaGio.Size = new Size(275, 30); txtGiaGio.TabIndex = 24; // // labell //

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 87

labell.AutoSize = true; labell.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0); labell.Location = new Point(102, 362); labell.Name = "labell"; labell.Size = new Size(81, 26); labell.TabIndex = 23; labell.Text = "Giá giờ"; // // txtGiaNgay // txtGiaNgay.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); txtGiaNgay.Location = new Point(198, 294); txtGiaNgay.Margin = new Padding(3, 4, 3, 4); txtGiaNgay.Name = "txtGiaNgay"; txtGiaNgay.Size = new Size(275, 30); txtGiaNgay.TabIndex = 22; // // label4 // label4.AutoSize = true; label4.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0); label4.Location = new Point(84, 294); label4.Name = "label4"; label4.Size = new Size(99, 26); label4.TabIndex = 21; label4.Text = "Giá ngày"; // // txtSoNguoiToiDa // txtSoNguoiToiDa.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); txtSoNguoiToiDa.Location = new Point(198, 229); txtSoNguoiToiDa.Margin = new Padding(3, 4, 3, 4); txtSoNguoiToiDa.Name = "txtSoNguoiToiDa"; txtSoNguoiToiDa.Size = new Size(275, 30); txtSoNguoiToiDa.TabIndex = 20; // // label3 // label3.AutoSize = true; label3.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0); label3.Location = new Point(29, 229); label3.Name = "label3"; label3.Size = new Size(157, 26); label3.TabIndex = 19; label3.Text = "Số người tối đa"; // // txtSoGiuong // txtSoGiuong.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); txtSoGiuong.Location = new Point(198, 160); txtSoGiuong.Margin = new Padding(3, 4, 3, 4); txtSoGiuong.Name = "txtSoGiuong"; txtSoGiuong.Size = new Size(275, 30); txtSoGiuong.TabIndex = 18; // // label2 // label2.AutoSize = true; label2.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 88

label2.Location = new Point(71, 160); label2.Name = "label2"; label2.Size = new Size(110, 26); label2.TabIndex = 17; label2.Text = "Số giường"; // // txtTenLP // txtTenLP.AcceptsReturn = true; txtTenLP.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); txtTenLP.Location = new Point(198, 95); txtTenLP.Margin = new Padding(3, 4, 3, 4); txtTenLP.Name = "txtTenLP"; txtTenLP.Size = new Size(275, 30); txtTenLP.TabIndex = 16; // // label1 // label1.AutoSize = true; label1.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0); label1.Location = new Point(29, 95); label1.Name = "label1"; label1.Size = new Size(154, 26); label1.TabIndex = 8; label1.Text = "Tên loại phòng"; // // FormThemLoaiPhong // AutoScaleDimensions = new SizeF(8F, 20F); AutoScaleMode = AutoScaleMode.Font; ClientSize = new Size(548, 639); Controls.Add(label5); Controls.Add(btnThoat); Controls.Add(btnThemMoi); Controls.Add(panel1); Margin = new Padding(3, 4, 3, 4); Name = "FormThemLoaiPhong"; Text = "FormThemLoaiPhong"; panel1.ResumeLayout(false); panel1.PerformLayout(); ResumeLayout(false); PerformLayout();

}

#endregion

private System.Windows.Forms.Label label5; private System.Windows.Forms.Button btnThoat; private System.Windows.Forms.Button btnThemMoi; private System.Windows.Forms.Panel panel1; private System.Windows.Forms.TextBox txtMaLoaiPhong; private System.Windows.Forms.Label label6; private System.Windows.Forms.TextBox txtGiaGio; private System.Windows.Forms.Label labell; private System.Windows.Forms.TextBox txtGiaNgay; private System.Windows.Forms.Label label4; private System.Windows.Forms.TextBox txtSoNguoiToiDa; private System.Windows.Forms.Label label3; private System.Windows.Forms.TextBox txtSoGiuong; private System.Windows.Forms.Label label2; private System.Windows.Forms.TextBox txtTenLP; private System.Windows.Forms.Label label1; }

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 89

}

### Bước 8: SV sử dụng mã nguồn tạm thời sau để xử lý chức năng trong file

### FormThemLoaiPhong.cs

using System; using System.Collections.Generic; using System.ComponentModel; using System.Data; using System.Drawing; using System.Text; using System.Windows.Forms; using HotelManagement.Models; using Microsoft.EntityFrameworkCore;

namespace HotelManagement.LoaiPhong { public partial class FormThemLoaiPhong: Form { public FormThemLoaiPhong () { InitializeComponent ();

Text = "Thêm mới loại phòng"; StartPosition = FormStartPosition.CenterParent; FormBorderStyle = FormBorderStyle.FixedDialog; MaximizeBox = false; MinimizeBox = false; AcceptButton = btnThemMoi; CancelButton = btnThoat;

txtMaLoaiPhong.MaxLength = 5; txtTenLP.MaxLength = 20; txtSoGiuong.MaxLength = 2; txtSoNguoiToiDa.MaxLength = 2;

txtSoGiuong.KeyPress += ChiChoNhapSo; txtSoNguoiToiDa.KeyPress += ChiChoNhapSo; }

private void btnThemMoi_Click ( object sender, EventArgs e) { string maLPH = txtMaLoaiPhong.Text. Trim (). ToUpper (); string tenLPH = txtTenLP.Text. Trim ();

if ( maLPH.Length == 0) { MessageBox. Show( "Vui lòng nhập mã loại phòng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtMaLoaiPhong. Focus (); return; }

if ( tenLPH.Length == 0) { MessageBox. Show( "Vui lòng nhập tên loại phòng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtTenLP. Focus (); return; }

if (! int. TryParse (txtSoGiuong.Text. Trim (), out int soGiuong) || soGiuong <= 0) {

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 90

MessageBox. Show( "Số giường không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtSoGiuong. Focus (); return; }

if (! int. TryParse (txtSoNguoiToiDa.Text. Trim (), out int soNguoiToiDa) || soNguoiToiDa <= 0) { MessageBox. Show( "Số người tối đa không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtSoNguoiToiDa. Focus (); return; }

if (! decimal. TryParse (txtGiaNgay.Text. Trim (), out decimal giaNgay) || giaNgay <= 0) { MessageBox. Show( "Giá ngày không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtGiaNgay. Focus (); return; }

if (! decimal. TryParse (txtGiaGio.Text. Trim (), out decimal giaGio) || giaGio <= 0) { MessageBox. Show( "Giá giờ không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtGiaGio. Focus (); return; }

try { using var db = new HotelManagementContext ();

if ( db.LoaiPhongs. Any ( l => l.MaLph == maLPH)) { MessageBox. Show( "Mã loại phòng đã tồn tại. Vui lòng nhập mã khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtMaLoaiPhong. Focus (); return; }

db.LoaiPhongs. Add( new Models. LoaiPhong { MaLph = maLPH, TenLph = tenLPH, SoGiuong = soGiuong, SoNguoiToiDa = soNguoiToiDa, GiaNgay = giaNgay, GiaGio = giaGio });

int rows = db. SaveChanges (); if ( rows > 0) { MessageBox. Show( "Thêm loại phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); DialogResult = DialogResult.OK; this. Close (); } else {

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 91

MessageBox. Show( "Không thể thêm loại phòng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); } } catch ( DbUpdateException ex) { MessageBox. Show( "Lỗi: " + ( ex.InnerException?.Message ?? ex.Message), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); } catch ( Exception ex) { MessageBox. Show( "Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); } }

private void btnThoat_Click ( object sender, EventArgs e) { DialogResult = DialogResult.Cancel; this. Close (); }

private void ChiChoNhapSo ( object? sender, KeyPressEventArgs e) { if (! char. IsControl ( e.KeyChar) && ! char. IsDigit ( e.KeyChar)) e.Handled = true; } } }

### Bước 9: Click chuột phải vào folder LoaiPhong → Add → Forms( Windows Forms)

### → tạo một form để xây dựng giao diện và chức năng cập nhật thông tin 1 loại phòng

### đang có là FormSuaLoaiPhong.cs

### Bước 10: Thiết kế giao diện FormSuaLoaiPhong.cs theo mẫu như sau:

### Mã nguồn tham khảo trong file FormSuaLoaiPhong.Designer.cs tạm thời như sau:

namespace HotelManagement.LoaiPhong

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 92

{ partial class FormSuaLoaiPhong { /// <summary> /// Required designer variable. /// </summary> private System.ComponentModel. IContainer components = null;

/// <summary> /// Clean up any resources being used. /// </summary> /// <param name=" disposing "> true if managed resources should be disposed; otherwise, false. </param> protected override void Dispose ( bool disposing) { if ( disposing && (components != null)) { components. Dispose (); } base. Dispose ( disposing); }

#region Windows Form Designer generated code

/// <summary> /// Required method for Designer support - do not modify /// the contents of this method with the code editor. /// </summary> private void InitializeComponent () { btnThoat = new Button (); btnCapNhat = new Button (); panel1 = new Panel (); txtGiaGio = new TextBox(); labell = new Label(); txtGiaNgay = new TextBox(); label4 = new Label(); txtSoNguoiToiDa = new TextBox(); label3 = new Label(); txtSoGiuong = new TextBox(); label2 = new Label(); txtTenLP = new TextBox(); label1 = new Label(); label5 = new Label(); panel1.SuspendLayout(); SuspendLayout(); // // btnThoat // btnThoat.BackColor = SystemColors.GradientActiveCaption; btnThoat.Font = new Font( "Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); btnThoat.Location = new Point(336, 519); btnThoat.Margin = new Padding(3, 4, 3, 4); btnThoat.Name = "btnThoat"; btnThoat.Size = new Size(137, 59); btnThoat.TabIndex = 13; btnThoat.Text = "Thoát"; btnThoat.UseVisualStyleBackColor = false; btnThoat.Click += btnThoat_Click; // // btnCapNhat // btnCapNhat.BackColor = Color.Moccasin; btnCapNhat.Font = new Font( "Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 93

btnCapNhat.Location = new Point(136, 519); btnCapNhat.Margin = new Padding(3, 4, 3, 4); btnCapNhat.Name = "btnCapNhat"; btnCapNhat.Size = new Size(137, 59); btnCapNhat.TabIndex = 12; btnCapNhat.Text = "Cập nhật"; btnCapNhat.UseVisualStyleBackColor = false; btnCapNhat.Click += btnCapNhat_Click; // // panel1 // panel1.Controls.Add(txtGiaGio); panel1.Controls.Add(labell); panel1.Controls.Add(txtGiaNgay); panel1.Controls.Add(label4); panel1.Controls.Add(txtSoNguoiToiDa); panel1.Controls.Add(label3); panel1.Controls.Add(txtSoGiuong); panel1.Controls.Add(label2); panel1.Controls.Add(txtTenLP); panel1.Controls.Add(label1); panel1.Location = new Point(48, 121); panel1.Margin = new Padding(3, 4, 3, 4); panel1.Name = "panel1"; panel1.Size = new Size(507, 375); panel1.TabIndex = 11; // // txtGiaGio // txtGiaGio.Font = new Font( "Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); txtGiaGio.Location = new Point(211, 308); txtGiaGio.Margin = new Padding(3, 4, 3, 4); txtGiaGio.Name = "txtGiaGio"; txtGiaGio.Size = new Size(275, 30); txtGiaGio.TabIndex = 24; // // labell // labell.AutoSize = true; labell.Font = new Font( "Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0); labell.Location = new Point(112, 312); labell.Name = "labell"; labell.Size = new Size(81, 26); labell.TabIndex = 23; labell.Text = "Giá giờ"; // // txtGiaNgay // txtGiaNgay.Font = new Font( "Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); txtGiaNgay.Location = new Point(208, 244); txtGiaNgay.Margin = new Padding(3, 4, 3, 4); txtGiaNgay.Name = "txtGiaNgay"; txtGiaNgay.Size = new Size(275, 30); txtGiaNgay.TabIndex = 22; // // label4 // label4.AutoSize = true; label4.Font = new Font( "Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0); label4.Location = new Point(94, 244); label4.Name = "label4"; label4.Size = new Size(99, 26);

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 94

label4.TabIndex = 21; label4.Text = "Giá ngày"; // // txtSoNguoiToiDa // txtSoNguoiToiDa.Font = new Font( "Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); txtSoNguoiToiDa.Location = new Point(208, 179); txtSoNguoiToiDa.Margin = new Padding(3, 4, 3, 4); txtSoNguoiToiDa.Name = "txtSoNguoiToiDa"; txtSoNguoiToiDa.Size = new Size(275, 30); txtSoNguoiToiDa.TabIndex = 20; // // label3 // label3.AutoSize = true; label3.Font = new Font( "Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0); label3.Location = new Point(39, 179); label3.Name = "label3"; label3.Size = new Size(157, 26); label3.TabIndex = 19; label3.Text = "Số người tối đa"; // // txtSoGiuong // txtSoGiuong.Font = new Font( "Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); txtSoGiuong.Location = new Point(208, 110); txtSoGiuong.Margin = new Padding(3, 4, 3, 4); txtSoGiuong.Name = "txtSoGiuong"; txtSoGiuong.Size = new Size(275, 30); txtSoGiuong.TabIndex = 18; // // label2 // label2.AutoSize = true; label2.Font = new Font( "Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0); label2.Location = new Point(81, 110); label2.Name = "label2"; label2.Size = new Size(110, 26); label2.TabIndex = 17; label2.Text = "Số giường"; // // txtTenLP // txtTenLP.AcceptsReturn = true; txtTenLP.Font = new Font( "Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); txtTenLP.Location = new Point(208, 45); txtTenLP.Margin = new Padding(3, 4, 3, 4); txtTenLP.Name = "txtTenLP"; txtTenLP.Size = new Size(275, 30); txtTenLP.TabIndex = 16; // // label1 // label1.AutoSize = true; label1.Font = new Font( "Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0); label1.Location = new Point(39, 45); label1.Name = "label1"; label1.Size = new Size(154, 26); label1.TabIndex = 8; label1.Text = "Tên loại phòng";

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 95

// // label5 // label5.AutoSize = true; label5.Font = new Font( "Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, 0); label5.ForeColor = Color.FromArgb(192, 64, 0); label5.Location = new Point(113, 49); label5.Name = "label5"; label5.Size = new Size(395, 31); label5.TabIndex = 14; label5.Text = "Cập nhật thông tin loại phòng"; // // FormSuaLoaiPhong // AutoScaleDimensions = new SizeF(8F, 20F); AutoScaleMode = AutoScaleMode.Font; ClientSize = new Size(604, 626); Controls.Add(label5); Controls.Add(btnThoat); Controls.Add(btnCapNhat); Controls.Add(panel1); Margin = new Padding(3, 4, 3, 4); Name = "FormSuaLoaiPhong"; Text = "FormSuaLoaiPhong"; panel1. ResumeLayout ( false); panel1. PerformLayout (); ResumeLayout ( false); PerformLayout ();

}

#endregion

private System.Windows.Forms. Button btnThoat; private System.Windows.Forms. Button btnCapNhat; private System.Windows.Forms. Panel panel1; private System.Windows.Forms. Label label1; private System.Windows.Forms. TextBox txtGiaGio; private System.Windows.Forms. Label labell; private System.Windows.Forms. TextBox txtGiaNgay; private System.Windows.Forms. Label label4; private System.Windows.Forms. TextBox txtSoNguoiToiDa; private System.Windows.Forms. Label label3; private System.Windows.Forms. TextBox txtSoGiuong; private System.Windows.Forms. Label label2; private System.Windows.Forms. TextBox txtTenLP; private System.Windows.Forms. Label label5; } }

### Bước 11: SV sử dụng mã nguồn tạm thời sau để xử lý chức năng trong file

### FormSuaLoaiPhong.cs

using System; using System.Collections.Generic; using System.ComponentModel; using System.Data; using System.Drawing; using System.Text; using System.Windows.Forms; using HotelManagement.Models; using Microsoft.EntityFrameworkCore;

namespace HotelManagement.LoaiPhong

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 96

{ public partial class FormSuaLoaiPhong: Form { [Browsable( false)] [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)] public string? MaLoaiPhong { get; set; }

public FormSuaLoaiPhong () { InitializeComponent();

Text = "Cập nhật thông tin loại phòng"; StartPosition = FormStartPosition.CenterParent; FormBorderStyle = FormBorderStyle.FixedDialog; MaximizeBox = false; MinimizeBox = false; AcceptButton = btnCapNhat; CancelButton = btnThoat;

txtTenLP.MaxLength = 20; txtSoGiuong.MaxLength = 2; txtSoNguoiToiDa.MaxLength = 2;

txtSoGiuong.KeyPress += ChiChoNhapSo; txtSoNguoiToiDa.KeyPress += ChiChoNhapSo;

Load += FormSuaLoaiPhong_Load; }

private void FormSuaLoaiPhong_Load ( object sender, EventArgs e) { string? ma = MaLoaiPhong;

if ( string.IsNullOrEmpty(ma)) { MessageBox.Show( "Chưa xác định được loại phòng cần cập nhật.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); btnCapNhat.Enabled = false; return; }

Text = "Cập nhật loại phòng " + ma;

try { using var db = new HotelManagementContext();

var thongTin = db.LoaiPhongs .AsNoTracking() .Where( l => l.MaLph == ma) .Select( l => new { l.TenLph, l.SoGiuong, l.SoNguoiToiDa, l.GiaNgay, l.GiaGio }) .FirstOrDefault();

if (thongTin == null) { MessageBox.Show( "Không tìm thấy loại phòng " + ma + ".", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); btnCapNhat.Enabled = false; return; }

txtTenLP.Text = thongTin.TenLph; txtSoGiuong.Text = thongTin.SoGiuong. ToString (); txtSoNguoiToiDa.Text = thongTin.SoNguoiToiDa. ToString (); txtGiaNgay.Text = thongTin.GiaNgay. ToString ( "0.##");

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 97

txtGiaGio.Text = thongTin.GiaGio. ToString ( "0.##"); } catch ( Exception ex) { MessageBox. Show( "Lỗi tải thông tin loại phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); btnCapNhat.Enabled = false; } }

private void btnCapNhat_Click ( object sender, EventArgs e) { string? ma = MaLoaiPhong;

if ( string. IsNullOrEmpty ( ma)) { MessageBox. Show( "Chưa xác định được loại phòng cần cập nhật.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

string tenLPH = txtTenLP.Text. Trim ();

if ( tenLPH.Length == 0) { MessageBox. Show( "Vui lòng nhập tên loại phòng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtTenLP. Focus (); return; }

if (! int. TryParse (txtSoGiuong.Text. Trim (), out int soGiuong) || soGiuong <= 0) { MessageBox. Show( "Số giường không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtSoGiuong. Focus (); return; }

if (! int. TryParse (txtSoNguoiToiDa.Text. Trim (), out int soNguoiToiDa) || soNguoiToiDa <= 0) { MessageBox. Show( "Số người tối đa không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtSoNguoiToiDa. Focus (); return; }

if (! decimal. TryParse (txtGiaNgay.Text. Trim (), out decimal giaNgay) || giaNgay <= 0) { MessageBox. Show( "Giá ngày không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtGiaNgay. Focus (); return; }

if (! decimal. TryParse (txtGiaGio.Text. Trim (), out decimal giaGio) || giaGio <= 0) { MessageBox. Show( "Giá giờ không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtGiaGio. Focus (); return; }

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 98

try { using var db = new HotelManagementContext ();

var loaiPhong = db.LoaiPhongs. FirstOrDefault ( l => l.MaLph == ma);

if ( loaiPhong == null) { MessageBox. Show( "Không tìm thấy loại phòng cần cập nhật.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

loaiPhong.TenLph = tenLPH; loaiPhong.SoGiuong = soGiuong; loaiPhong.SoNguoiToiDa = soNguoiToiDa; loaiPhong.GiaNgay = giaNgay; loaiPhong.GiaGio = giaGio;

int rows = db. SaveChanges (); if ( rows > 0) { MessageBox. Show( "Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); DialogResult = DialogResult.OK; this. Close (); } else { MessageBox. Show( "Thông tin không thay đổi nên không có gì để cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); } } catch ( DbUpdateException ex) { MessageBox. Show( "Lỗi khi cập nhật: " + ( ex.InnerException?.Message ?? ex.Message), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); } catch ( Exception ex) { MessageBox. Show( "Lỗi khi cập nhật: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); } }

private void btnThoat_Click ( object sender, EventArgs e) { DialogResult = DialogResult.Cancel; this. Close (); }

private void ChiChoNhapSo ( object? sender, KeyPressEventArgs e) { if (! char. IsControl ( e.KeyChar) && ! char. IsDigit ( e.KeyChar)) e.Handled = true; } } }

### Bước 11: SV sử dụng mã nguồn sau để cập nhật lại chọn chức năng “Sửa” hoặc “Xóa”

### trong file FormDanhSachLoaiPhong.cs

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 99

using System; using System.Collections.Generic; using System.ComponentModel; using System.Data; using System.Drawing; using System.Text; using System.Windows.Forms; using ClosedXML.Excel; using HotelManagement.Models; using Microsoft.EntityFrameworkCore;

namespace HotelManagement.LoaiPhong { public partial class FormDanhSachLoaiPhong : Form { private readonly Image _iconGiuong = Properties.Resources.Giuong; private readonly Image _iconTienNghi = Properties.Resources.details; private readonly Image _iconSua = Properties.Resources.edit;

public FormDanhSachLoaiPhong() { InitializeComponent(); Load += FormDanhSachLoaiPhong_Load; }

private void txtTimKiem_TextChanged(object sender, EventArgs e) { LocTheoTuKhoa(); }

private void btnXuatExcel_Click(object sender, EventArgs e) { var cacDong = dtgDanhSachLoaiPhong.Rows.Cast<DataGridViewRow>() .Where(r => r.Visible && !r.IsNewRow) .ToList();

if (cacDong.Count == 0) { MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

using (var hopLuu = new SaveFileDialog()) { hopLuu.Title = "Xuất danh sách loại phòng"; hopLuu.Filter = "Excel Workbook (*.xlsx)|*.xlsx"; hopLuu.FileName = $"DanhSachLoaiPhong_{DateTime.Now:yyyyMMdd_HHmm}.xlsx";

if (hopLuu.ShowDialog() != DialogResult.OK) return;

try { using (var wb = new XLWorkbook()) { var ws = wb.Worksheets.Add("Danh sách loại phòng");

string[] tenCot = { "MaLPH", "TenLPH", "SoGiuong", "SoNguoiToiDa", "GiaNgay", "GiaGio" };

for (int c = 0; c < tenCot.Length; c++) ws.Cell(1, c + 1).Value = dtgDanhSachLoaiPhong.Columns[tenCot[c]].HeaderText; ws.Row(1).Style.Font.Bold = true;

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 100

for (int i = 0; i < cacDong.Count; i++) { for (int c = 0; c < tenCot.Length; c++) { var o = ws.Cell(i + 2, c + 1); object? giaTri = cacDong[i].Cells[tenCot[c]].Value;

switch (giaTri) { case decimal d: o.Value = d; o.Style.NumberFormat.Format = "#,##0"; break; case int n: o.Value = n; break; default: o.Value = giaTri?.ToString() ?? ""; break; } } }

ws.Columns().AdjustToContents(); wb.SaveAs(hopLuu.FileName); }

var traLoi = MessageBox.Show("Xuất dữ liệu thành công! \ nBạn có muốn mở file ngay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information); if (traLoi == DialogResult.Yes) { System.Diagnostics.Process.Start( new System.Diagnostics.ProcessStartInfo(hopLuu.FileName) { UseShellExecute = true }); } } catch (IOException) { MessageBox.Show("Không ghi được file. Có thể file đang được mở trong Excel, hãy đóng lại rồi thử lần nữa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); } catch (Exception ex) { MessageBox.Show("Lỗi khi xuất Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); } } }

private void btnThemMoi_Click(object sender, EventArgs e) { using (var formThemLoaiPhong = new FormThemLoaiPhong()) { formThemLoaiPhong.ShowDialog(); }

LoadLoaiPhong(); }

private void dtgDanhSachLoaiPhong_CellClick(object sender, DataGridViewCellEventArgs e) { if (e.RowIndex < 0 || e.ColumnIndex < 0)

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 101

return;

var dong = dtgDanhSachLoaiPhong.Rows[e.RowIndex]; string? maLPH = dong.Cells["MaLPH"].Value?.ToString(); string? tenLPH = dong.Cells["TenLPH"].Value?.ToString();

if (string.IsNullOrEmpty(maLPH)) return;

string tenCot = dtgDanhSachLoaiPhong.Columns[e.ColumnIndex].Name;

if (tenCot == "colSua") { using (var formSua = new FormSuaLoaiPhong()) { formSua.MaLoaiPhong = maLPH; formSua.ShowDialog(); }

LoadLoaiPhong(); } else if (tenCot == "colTienNghi") { MessageBox.Show( $"Chức năng chi tiết tiện nghi của loại phòng {tenLPH} ({maLPH}) đang được xây dựng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); } }

private void FormDanhSachLoaiPhong_Load(object sender, EventArgs e) { CauHinhLuoi(); LoadLoaiPhong(); }

private void CauHinhLuoi() { if (dtgDanhSachLoaiPhong.Columns.Count > 0) return;

dtgDanhSachLoaiPhong.ReadOnly = true; dtgDanhSachLoaiPhong.AllowUserToAddRows = false; dtgDanhSachLoaiPhong.AllowUserToDeleteRows = false; dtgDanhSachLoaiPhong.AllowUserToResizeRows = false; dtgDanhSachLoaiPhong.MultiSelect = false; dtgDanhSachLoaiPhong.SelectionMode = DataGridViewSelectionMode.FullRowSelect; dtgDanhSachLoaiPhong.RowHeadersVisible = false; dtgDanhSachLoaiPhong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; dtgDanhSachLoaiPhong.RowTemplate.Height = 40;

dtgDanhSachLoaiPhong.Columns.Add(TaoCotAnh("colIcon", "", _iconGiuong,

50. );

dtgDanhSachLoaiPhong.Columns.Add("MaLPH", "Mã loại"); dtgDanhSachLoaiPhong.Columns.Add("TenLPH", "Tên loại"); dtgDanhSachLoaiPhong.Columns.Add("SoGiuong", "Số giường"); dtgDanhSachLoaiPhong.Columns.Add("SoNguoiToiDa", "Số người tối đa"); dtgDanhSachLoaiPhong.Columns.Add("GiaNgay", "Giá ngày"); dtgDanhSachLoaiPhong.Columns.Add("GiaGio", "Giá giờ");

dtgDanhSachLoaiPhong.Columns["GiaNgay"]!.DefaultCellStyle.Format = "N0"; dtgDanhSachLoaiPhong.Columns["GiaGio"]!.DefaultCellStyle.Format = "N0";

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 102

dtgDanhSachLoaiPhong.Columns["GiaNgay"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; dtgDanhSachLoaiPhong.Columns["GiaGio"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

dtgDanhSachLoaiPhong.Columns.Add(TaoCotAnh("colTienNghi", "Tiện nghi", _iconTienNghi, 60)); dtgDanhSachLoaiPhong.Columns.Add(TaoCotAnh("colSua", "Cập nhật", _iconSua,

70. );

}

private DataGridViewImageColumn TaoCotAnh(string ten, string tieuDe, Image anh, int doRong) { return new DataGridViewImageColumn { Name = ten, HeaderText = tieuDe, Image = anh, ImageLayout = DataGridViewImageCellLayout.Zoom, AutoSizeMode = DataGridViewAutoSizeColumnMode.None, Width = doRong, Resizable = DataGridViewTriState.False, SortMode = DataGridViewColumnSortMode.NotSortable }; }

private void LoadLoaiPhong() { try { using var db = new HotelManagementContext();

var dsLoaiPhong = db.LoaiPhongs .AsNoTracking() .OrderBy(l => l.MaLph) .Select(l => new { l.MaLph, l.TenLph, l.SoGiuong, l.SoNguoiToiDa, l.GiaNgay, l.GiaGio }) .ToList();

dtgDanhSachLoaiPhong.Rows.Clear();

foreach (var l in dsLoaiPhong) { dtgDanhSachLoaiPhong.Rows.Add( _iconGiuong, l.MaLph, l.TenLph, l.SoGiuong, l.SoNguoiToiDa, l.GiaNgay, l.GiaGio, _iconTienNghi, _iconSua ); }

LocTheoTuKhoa(); }

Lập trình trực quan

Ths. Nguyễn Thiện Dương Trang 103

catch (Exception ex) { MessageBox.Show("Lỗi khi tải loại phòng: " + ex.Message); } }

private void LocTheoTuKhoa() { string keyword = txtTimKiem.Text.Trim();

dtgDanhSachLoaiPhong.CurrentCell = null;

foreach (DataGridViewRow row in dtgDanhSachLoaiPhong.Rows) { string ma = row.Cells["MaLPH"].Value?.ToString() ?? ""; string ten = row.Cells["TenLPH"].Value?.ToString() ?? "";

row.Visible = keyword.Length == 0 || ma.Contains(keyword, StringComparison.OrdinalIgnoreCase) || ten.Contains(keyword, StringComparison.OrdinalIgnoreCase); } } } }

IV. Chi tiết bài thực hành cho buổi 2

1. Xây dựng giao diện và chức năng quản lý thông tin dịch vụ khách sạn

Bước 1: Click chuột phải vào thư mục project → Add → New Folder→ Đặt tên folder

là “DichVu”

Bước 2: Click chuột phải vào folder DichVu → Add → Forms( Windows Forms) →

tạo một form thể hiện danh sách loại phòng khách sạn là FormDanhSachDichVu.cs

Bước 3: Thiết kế giao diện FormDanhSachDichVu.cs theo mẫu như sau:

Mã nguồn tham khảo trong file FormDanhSachDichVu.Designer.cs tạm thời như sau: namespace HotelManagement.DichVu { partial class FormDanhSachDichVu { /// <summary> /// Required designer variable. /// </summary> private System.ComponentModel. IContainer components = null;

/// <summary> /// Clean up any resources being used. /// </summary>

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 104

/// <param name=" disposing "> true if managed resources should be disposed; otherwise, false. </param> protected override void Dispose ( bool disposing) { if ( disposing && (components != null)) { components. Dispose (); } base. Dispose ( disposing); }

#region Windows Form Designer generated code

/// <summary> /// Required method for Designer support - do not modify /// the contents of this method with the code editor. /// </summary> private void InitializeComponent () { btnThemMoi = new Button (); dtgDanhSachDichVu = new DataGridView (); btnXuatExcel = new Button (); txtTimKiem = new TextBox (); pictureBox1 = new PictureBox (); ((System.ComponentModel. ISupportInitialize)dtgDanhSachDichVu). BeginInit (); ((System.ComponentModel. ISupportInitialize)pictureBox1). BeginInit (); SuspendLayout (); // // btnThemMoi // btnThemMoi.BackColor = Color.LightPink; btnThemMoi.Font = new Font ( "Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0); btnThemMoi.Location = new Point (673, 28); btnThemMoi.Margin = new Padding (3, 4, 3, 4); btnThemMoi.Name = "btnThemMoi"; btnThemMoi.Size = new Size (167, 46); btnThemMoi.TabIndex = 15; btnThemMoi.Text = "Thêm mới"; btnThemMoi.UseVisualStyleBackColor = false; btnThemMoi.Click += btnThemMoi_Click; // // dtgDanhSachDichVu // dtgDanhSachDichVu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize; dtgDanhSachDichVu.Location = new Point (12, 90); dtgDanhSachDichVu.Margin = new Padding (3, 4, 3, 4); dtgDanhSachDichVu.Name = "dtgDanhSachDichVu"; dtgDanhSachDichVu.RowHeadersWidth = 51; dtgDanhSachDichVu.RowTemplate.Height = 24; dtgDanhSachDichVu.Size = new Size (945, 679); dtgDanhSachDichVu.TabIndex = 14; dtgDanhSachDichVu.CellClick += dtgDanhSachDichVu_CellClick; // // btnXuatExcel // btnXuatExcel.BackColor = Color.DarkTurquoise; btnXuatExcel.Font = new Font ( "Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0); btnXuatExcel.Location = new Point (475, 28); btnXuatExcel.Margin = new Padding (3, 4, 3, 4); btnXuatExcel.Name = "btnXuatExcel"; btnXuatExcel.Size = new Size (167, 46); btnXuatExcel.TabIndex = 13; btnXuatExcel.Text = "Xuất file Excel";

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 105

btnXuatExcel.UseVisualStyleBackColor = false; btnXuatExcel.Click += btnXuatExcel_Click; // // txtTimKiem // txtTimKiem.Font = new Font ( "Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0); txtTimKiem.Location = new Point (73, 34); txtTimKiem.Margin = new Padding (3, 4, 3, 4); txtTimKiem.Name = "txtTimKiem"; txtTimKiem.Size = new Size (187, 32); txtTimKiem.TabIndex = 11; txtTimKiem.TextChanged += txtTimKiem_TextChanged; // // pictureBox1 // pictureBox1.Image = Properties. Resources.search; pictureBox1.Location = new Point (28, 28); pictureBox1.Margin = new Padding (3, 4, 3, 4); pictureBox1.Name = "pictureBox1"; pictureBox1.Size = new Size (39, 46); pictureBox1.TabIndex = 12; pictureBox1.TabStop = false; // // FormDanhSachDichVu // AutoScaleDimensions = new SizeF (8F, 20F); AutoScaleMode = AutoScaleMode.Font; ClientSize = new Size (961, 784); Controls. Add(btnThemMoi); Controls. Add(dtgDanhSachDichVu); Controls. Add(btnXuatExcel); Controls. Add(pictureBox1); Controls. Add(txtTimKiem); Margin = new Padding (3, 4, 3, 4); Name = "FormDanhSachDichVu"; StartPosition = FormStartPosition.CenterScreen; Text = "Quản lý thông tin dịch vụ"; ((System.ComponentModel. ISupportInitialize)dtgDanhSachDichVu). EndInit (); ((System.ComponentModel. ISupportInitialize)pictureBox1). EndInit (); ResumeLayout ( false); PerformLayout ();

}

#endregion

private System.Windows.Forms. Button btnThemMoi; private System.Windows.Forms. DataGridView dtgDanhSachDichVu; private System.Windows.Forms. Button btnXuatExcel; private System.Windows.Forms. PictureBox pictureBox1; private System.Windows.Forms. TextBox txtTimKiem; } }

### Bước 4: SV sử dụng mã nguồn tạm thời sau để xử lý chức năng trong file

### FormDanhSachDichVu.cs

using System; using System.Collections.Generic; using System.ComponentModel; using System.Data; using System.Drawing; using System.Text; using System.Windows.Forms;

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 106

using ClosedXML.Excel; using HotelManagement.Models; using Microsoft.EntityFrameworkCore;

namespace HotelManagement.DichVu { public partial class FormDanhSachDichVu : Form { private readonly Image _iconDichVu = Properties.Resources.DichVu; private readonly Image _iconSua = Properties.Resources.edit; private readonly Image _iconXoa = Properties.Resources.delete;

public FormDanhSachDichVu() { InitializeComponent(); Load += FormDanhSachDichVu_Load; }

private void FormDanhSachDichVu_Load(object? sender, EventArgs e) { CauHinhLuoi(); LoadDanhSachDichVu(); }

private void txtTimKiem_TextChanged(object sender, EventArgs e) { LocTheoTuKhoa(); }

private void btnXuatExcel_Click(object sender, EventArgs e) { var cacDong = dtgDanhSachDichVu.Rows.Cast<DataGridViewRow>() .Where(r => r.Visible && !r.IsNewRow) .ToList();

if (cacDong.Count == 0) { MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

using (var hopLuu = new SaveFileDialog()) { hopLuu.Title = "Xuất danh sách dịch vụ"; hopLuu.Filter = "Excel Workbook (*.xlsx)|*.xlsx"; hopLuu.FileName = $"DanhSachDichVu_{DateTime.Now:yyyyMMdd_HHmm}.xlsx";

if (hopLuu.ShowDialog() != DialogResult.OK) return;

try { using (var wb = new XLWorkbook()) { var ws = wb.Worksheets.Add("Danh sách dịch vụ");

string[] tenCot = { "MaDV", "TenDV", "DonGia", "SLConLai", "LoaiDV" };

for (int c = 0; c < tenCot.Length; c++) ws.Cell(1, c + 1).Value = dtgDanhSachDichVu.Columns[tenCot[c]].HeaderText; ws.Row(1).Style.Font.Bold = true;

for (int i = 0; i < cacDong.Count; i++)

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 107

{ for (int c = 0; c < tenCot.Length; c++) { var o = ws.Cell(i + 2, c + 1); object? giaTri = cacDong[i].Cells[tenCot[c]].Value;

switch (giaTri) { case decimal d: o.Value = d; o.Style.NumberFormat.Format = "#,##0"; break; case int n: o.Value = n; break; default: o.Value = giaTri?.ToString() ?? ""; break; } } }

ws.Columns().AdjustToContents(); wb.SaveAs(hopLuu.FileName); }

var traLoi = MessageBox.Show("Xuất dữ liệu thành công! \ nBạn có muốn mở file ngay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information); if (traLoi == DialogResult.Yes) { System.Diagnostics.Process.Start( new System.Diagnostics.ProcessStartInfo(hopLuu.FileName) { UseShellExecute = true }); } } catch (IOException) { MessageBox.Show("Không ghi được file. Có thể file đang được mở trong Excel, hãy đóng lại rồi thử lần nữa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); } catch (Exception ex) { MessageBox.Show("Lỗi khi xuất Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); } } }

private void btnThemMoi_Click(object sender, EventArgs e) { using (var formThem = new FormThemDichVu()) { formThem.ShowDialog(); }

LoadDanhSachDichVu(); }

private void dtgDanhSachDichVu_CellClick(object sender, DataGridViewCellEventArgs e) { if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 108

string? maDV = dtgDanhSachDichVu.Rows[e.RowIndex].Cells["MaDV"].Value?.ToString(); string? tenDV = dtgDanhSachDichVu.Rows[e.RowIndex].Cells["TenDV"].Value?.ToString();

if (string.IsNullOrEmpty(maDV)) return;

string tenCot = dtgDanhSachDichVu.Columns[e.ColumnIndex].Name;

if (tenCot == "colSua") { using (var formSua = new FormSuaDichVu()) { formSua.MaDichVu = maDV; formSua.ShowDialog(); }

LoadDanhSachDichVu(); } else if (tenCot == "colXoa") { DialogResult result = MessageBox.Show($"Bạn có chắc muốn xóa dịch vụ {tenDV} ({maDV}) không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

if (result == DialogResult.Yes) { XoaDichVu(maDV); LoadDanhSachDichVu(); } } }

private void CauHinhLuoi() { if (dtgDanhSachDichVu.Columns.Count > 0) return;

dtgDanhSachDichVu.ReadOnly = true; dtgDanhSachDichVu.AllowUserToAddRows = false; dtgDanhSachDichVu.AllowUserToDeleteRows = false; dtgDanhSachDichVu.AllowUserToResizeRows = false; dtgDanhSachDichVu.MultiSelect = false; dtgDanhSachDichVu.SelectionMode = DataGridViewSelectionMode.FullRowSelect; dtgDanhSachDichVu.RowHeadersVisible = false; dtgDanhSachDichVu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; dtgDanhSachDichVu.RowTemplate.Height = 40;

dtgDanhSachDichVu.Columns.Add(TaoCotAnh("colIcon", "", _iconDichVu, 50));

dtgDanhSachDichVu.Columns.Add("MaDV", "Mã DV"); dtgDanhSachDichVu.Columns.Add("TenDV", "Tên dịch vụ"); dtgDanhSachDichVu.Columns.Add("DonGia", "Đơn giá"); dtgDanhSachDichVu.Columns.Add("SLConLai", "Số lượng còn lại"); dtgDanhSachDichVu.Columns.Add("LoaiDV", "Loại dịch vụ");

dtgDanhSachDichVu.Columns["DonGia"]!.DefaultCellStyle.Format = "#,##0' VNĐ'"; dtgDanhSachDichVu.Columns["DonGia"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; dtgDanhSachDichVu.Columns["SLConLai"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

dtgDanhSachDichVu.Columns.Add(TaoCotAnh("colSua", "Sửa", _iconSua, 50));

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 109

dtgDanhSachDichVu.Columns.Add(TaoCotAnh("colXoa", "Xóa", _iconXoa, 50)); }

private DataGridViewImageColumn TaoCotAnh(string ten, string tieuDe, Image anh, int doRong) { return new DataGridViewImageColumn { Name = ten, HeaderText = tieuDe, Image = anh, ImageLayout = DataGridViewImageCellLayout.Zoom, AutoSizeMode = DataGridViewAutoSizeColumnMode.None, Width = doRong, Resizable = DataGridViewTriState.False, SortMode = DataGridViewColumnSortMode.NotSortable }; }

private void LoadDanhSachDichVu() { try { using var db = new HotelManagementContext();

var dsDichVu = db.DichVus .AsNoTracking() .Where(d => d.DaXoa != true) .OrderBy(d => d.MaDv) .Select(d => new { d.MaDv, d.TenDv, d.DonGia, d.SlconLai, d.LoaiDv }) .ToList();

dtgDanhSachDichVu.Rows.Clear();

foreach (var d in dsDichVu) { string soLuong = d.SlconLai == null || d.SlconLai < 0 ? "Không giới hạn" : d.SlconLai.Value.ToString();

dtgDanhSachDichVu.Rows.Add( _iconDichVu, d.MaDv, d.TenDv, d.DonGia, soLuong, d.LoaiDv, _iconSua, _iconXoa ); }

LocTheoTuKhoa(); } catch (Exception ex) { MessageBox.Show("Lỗi tải danh sách dịch vụ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 110

}

private void LocTheoTuKhoa() { string keyword = txtTimKiem.Text.Trim();

dtgDanhSachDichVu.CurrentCell = null;

foreach (DataGridViewRow row in dtgDanhSachDichVu.Rows) { string ma = row.Cells["MaDV"].Value?.ToString() ?? ""; string ten = row.Cells["TenDV"].Value?.ToString() ?? "";

row.Visible = keyword.Length == 0 || ma.Contains(keyword, StringComparison.OrdinalIgnoreCase) || ten.Contains(keyword, StringComparison.OrdinalIgnoreCase); } }

private void XoaDichVu(string maDV) { try { using var db = new HotelManagementContext();

var dichVu = db.DichVus.FirstOrDefault(d => d.MaDv == maDV && d.DaXoa != true);

if (dichVu == null) { MessageBox.Show("Không tìm thấy dịch vụ để xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

dichVu.DaXoa = true; db.SaveChanges();

MessageBox.Show("Đã xóa dịch vụ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); } catch (Exception ex) { MessageBox.Show("Lỗi khi xóa dịch vụ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); } } } }

### Bước 5: Chỉnh sửa lại hàm private void button11_Click(object sender,

### EventArgs e)trong file FormMain.cs theo nội dung như sau:

private void button11_Click ( object sender, EventArgs e) { Form formCon = new DichVu. FormDanhSachDichVu (); formCon.TopLevel = false; formCon.FormBorderStyle = FormBorderStyle.None; formCon.Dock = DockStyle.Fill; XoaNoiDungPanelMain (); // hàm có trong bản FormMain mình gửi trước; nếu chưa có, dùng panelMain.Controls.Clear(); panelMain.Controls. Add( formCon); formCon. Show(); }

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 111

### Bước 5: Click chuột phải vào folder DichVu → Add → Forms( Windows Forms) →

### tạo một form để xây dựng giao diện và chức năng thêm mới thông tin 1 dịch vụ là

### FormThemDichVu.cs

### Bước 6: Thiết kế giao diện FormThemDichVu.cs theo mẫu như sau:

### Mã nguồn tham khảo trong file FormThemDichVu.Designer.cs tạm thời như sau:

namespace HotelManagement.DichVu { partial class FormThemDichVu { /// <summary> /// Required designer variable. /// </summary> private System.ComponentModel. IContainer components = null;

/// <summary> /// Clean up any resources being used. /// </summary> /// <param name=" disposing "> true if managed resources should be disposed; otherwise, false. </param> protected override void Dispose ( bool disposing) { if ( disposing && (components != null)) { components. Dispose (); } base. Dispose ( disposing); }

#region Windows Form Designer generated code

/// <summary> /// Required method for Designer support - do not modify /// the contents of this method with the code editor. /// </summary> private void InitializeComponent () {

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 112

btnThoat = new Button (); btnThemMoi = new Button(); panel1 = new Panel(); cbLoaiDV = new ComboBox(); label7 = new Label(); txtSoLuongConLai = new TextBox(); label3 = new Label(); txtDonGia = new TextBox(); label2 = new Label(); txtTenDV = new TextBox(); label1 = new Label(); txtMaDV = new TextBox(); label5 = new Label(); label6 = new Label(); panel1.SuspendLayout(); SuspendLayout(); // // btnThoat // btnThoat.BackColor = SystemColors.GradientActiveCaption; btnThoat.Font = new Font( "Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); btnThoat.Location = new Point(342, 488); btnThoat.Margin = new Padding(3, 4, 3, 4); btnThoat.Name = "btnThoat"; btnThoat.Size = new Size(137, 59); btnThoat.TabIndex = 16; btnThoat.Text = "Thoát"; btnThoat.UseVisualStyleBackColor = false; btnThoat.Click += btnThoat_Click; // // btnThemMoi // btnThemMoi.BackColor = Color.Moccasin; btnThemMoi.Font = new Font( "Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); btnThemMoi.Location = new Point(142, 488); btnThemMoi.Margin = new Padding(3, 4, 3, 4); btnThemMoi.Name = "btnThemMoi"; btnThemMoi.Size = new Size(137, 59); btnThemMoi.TabIndex = 15; btnThemMoi.Text = "Thêm mới"; btnThemMoi.UseVisualStyleBackColor = false; btnThemMoi.Click += btnThemMoi_Click; // // panel1 // panel1.Controls.Add(cbLoaiDV); panel1.Controls.Add(label7); panel1.Controls.Add(txtSoLuongConLai); panel1.Controls.Add(label3); panel1.Controls.Add(txtDonGia); panel1.Controls.Add(label2); panel1.Controls.Add(txtTenDV); panel1.Controls.Add(label1); panel1.Controls.Add(txtMaDV); panel1.Controls.Add(label5); panel1.Location = new Point(66, 114); panel1.Margin = new Padding(3, 4, 3, 4); panel1.Name = "panel1"; panel1.Size = new Size(507, 340); panel1.TabIndex = 14; // // cbLoaiDV //

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 113

cbLoaiDV.Font = new Font( "Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0); cbLoaiDV.FormattingEnabled = true; cbLoaiDV.Items.AddRange( new object [] { "Dịch vụ giặt ủi quần áo", "Dịch vụ xe đưa đón ", "Dịch vụ cho thuê xe máy tự lái", "Dịch vụ đặt vé máy bay, tour du lịch", "Dịch vụ trông trẻ", "Bơi 4 mùa ", "Dịch vụ karaoke", "Dịch vụ phục vụ phòng 24/24", "Dịch vụ thu đổi ngoại tệ", "Nhà hàng", "Dịch vụ hội họp, văn phòng", "Dịch vụ Spa"}); cbLoaiDV.Location = new Point(202, 152); cbLoaiDV.Margin = new Padding(3, 4, 3, 4); cbLoaiDV.Name = "cbLoaiDV"; cbLoaiDV.Size = new Size(290, 30); cbLoaiDV.TabIndex = 25; // // label7 // label7.AutoSize = true; label7.Font = new Font( "Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0); label7.Location = new Point(48, 151); label7.Name = "label7"; label7.Size = new Size(128, 26); label7.TabIndex = 24; label7.Text = "Loại dịch vụ"; // // txtSoLuongConLai // txtSoLuongConLai.Font = new Font( "Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); txtSoLuongConLai.Location = new Point(202, 276); txtSoLuongConLai.Margin = new Padding(3, 4, 3, 4); txtSoLuongConLai.Name = "txtSoLuongConLai"; txtSoLuongConLai.Size = new Size(290, 30); txtSoLuongConLai.TabIndex = 23; txtSoLuongConLai.KeyPress += txtSoLuongConLai_KeyPress; // // label3 // label3.AutoSize = true; label3.Font = new Font( "Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0); label3.Location = new Point(15, 279); label3.Name = "label3"; label3.Size = new Size(167, 26); label3.TabIndex = 22; label3.Text = "Số lượng còn lại"; // // txtDonGia // txtDonGia.Font = new Font( "Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); txtDonGia.Location = new Point(202, 214); txtDonGia.Margin = new Padding(3, 4, 3, 4); txtDonGia.Name = "txtDonGia"; txtDonGia.Size = new Size(290, 30); txtDonGia.TabIndex = 21; txtDonGia.KeyPress += txtDonGia_KeyPress; // // label2 // label2.AutoSize = true; label2.Font = new Font( "Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0); label2.Location = new Point(89, 214); label2.Name = "label2"; label2.Size = new Size(87, 26); label2.TabIndex = 20;

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 114

label2.Text = "Đơn giá"; // // txtTenDV // txtTenDV.Font = new Font( "Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); txtTenDV.Location = new Point(202, 82); txtTenDV.Margin = new Padding(3, 4, 3, 4); txtTenDV.Name = "txtTenDV"; txtTenDV.Size = new Size(290, 30); txtTenDV.TabIndex = 19; // // label1 // label1.AutoSize = true; label1.Font = new Font( "Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0); label1.Location = new Point(59, 79); label1.Name = "label1"; label1.Size = new Size(123, 26); label1.TabIndex = 18; label1.Text = "Tên dịch vụ"; // // txtMaDV // txtMaDV.Font = new Font( "Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); txtMaDV.Location = new Point(202, 22); txtMaDV.Margin = new Padding(3, 4, 3, 4); txtMaDV.Name = "txtMaDV"; txtMaDV.Size = new Size(290, 30); txtMaDV.TabIndex = 17; // // label5 // label5.AutoSize = true; label5.Font = new Font( "Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0); label5.Location = new Point(59, 19); label5.Name = "label5"; label5.Size = new Size(117, 26); label5.TabIndex = 16; label5.Text = "Mã dịch vụ"; // // label6 // label6.AutoSize = true; label6.Font = new Font( "Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 0); label6.ForeColor = Color.FromArgb(192, 0, 0); label6.Location = new Point(175, 45); label6.Name = "label6"; label6.Size = new Size(292, 29); label6.TabIndex = 17; label6.Text = "Thêm thông tin dịch vụ"; // // FormThemDichVu // AutoScaleDimensions = new SizeF(8F, 20F); AutoScaleMode = AutoScaleMode.Font; ClientSize = new Size(602, 561); Controls.Add(label6); Controls.Add(btnThoat); Controls.Add(btnThemMoi); Controls.Add(panel1); Margin = new Padding(3, 4, 3, 4);

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 115

Name = "FormThemDichVu"; Text = "FormThemDichVu"; panel1.ResumeLayout( false); panel1. PerformLayout (); ResumeLayout ( false); PerformLayout ();

}

#endregion

private System.Windows.Forms. Button btnThoat; private System.Windows.Forms. Button btnThemMoi; private System.Windows.Forms. Panel panel1; private System.Windows.Forms. TextBox txtMaDV; private System.Windows.Forms. Label label5; private System.Windows.Forms. Label label6; private System.Windows.Forms. TextBox txtSoLuongConLai; private System.Windows.Forms. Label label3; private System.Windows.Forms. TextBox txtDonGia; private System.Windows.Forms. Label label2; private System.Windows.Forms. TextBox txtTenDV; private System.Windows.Forms. Label label1; private System.Windows.Forms. ComboBox cbLoaiDV; private System.Windows.Forms. Label label7; } }

### Bước 7: SV sử dụng mã nguồn tạm thời sau để xử lý chức năng trong file

### FormThemDichVu.cs

using System; using System.Collections.Generic; using System.ComponentModel; using System.Data; using System.Drawing; using System.Text; using System.Windows.Forms; using HotelManagement.Models; using Microsoft.EntityFrameworkCore;

namespace HotelManagement.DichVu { public partial class FormThemDichVu: Form { private static readonly string [] LoaiMacDinh = { "Thức uống", "Đồ ăn", "Dịch vụ"};

public FormThemDichVu () { InitializeComponent();

Text = "Thêm mới dịch vụ"; StartPosition = FormStartPosition.CenterParent; FormBorderStyle = FormBorderStyle.FixedDialog; MaximizeBox = false; MinimizeBox = false; AcceptButton = btnThemMoi; CancelButton = btnThoat;

txtMaDV.MaxLength = 5; txtTenDV.MaxLength = 20; txtDonGia.MaxLength = 12; txtSoLuongConLai.MaxLength = 6; txtSoLuongConLai.PlaceholderText = "Để trống = không giới hạn"; cbLoaiDV.DropDownStyle = ComboBoxStyle.DropDownList;

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 116

Load += FormThemDichVu_Load; }

private void FormThemDichVu_Load ( object? sender, EventArgs e) { var dsLoai = new List< string >(LoaiMacDinh);

try { using var db = new HotelManagementContext();

var loaiTrongCsdl = db.DichVus .AsNoTracking() .Select( d => d.LoaiDv) .Distinct() .ToList();

foreach (var loai in loaiTrongCsdl) { string ten = (loai ?? "").Trim();

if (ten.Length > 0 && !dsLoai.Contains(ten, StringComparer.OrdinalIgnoreCase)) dsLoai.Add(ten); } } catch (Exception ex) { MessageBox.Show( "Lỗi tải loại dịch vụ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }

cbLoaiDV.Items.Clear(); cbLoaiDV.Items.AddRange(dsLoai.ToArray()); cbLoaiDV.SelectedIndex = - 1; }

private void txtDonGia_KeyPress ( object sender, KeyPressEventArgs e) { if (! char. IsControl ( e.KeyChar) && ! char. IsDigit ( e.KeyChar)) { e.Handled = true; } }

private void txtSoLuongConLai_KeyPress ( object sender, KeyPressEventArgs e) { if (! char. IsControl ( e.KeyChar) && ! char. IsDigit ( e.KeyChar)) { e.Handled = true; } }

private void btnThemMoi_Click ( object sender, EventArgs e) { string maDV = txtMaDV.Text. Trim (). ToUpper (); string tenDV = txtTenDV.Text. Trim (); string donGiaText = txtDonGia.Text. Trim (); string soLuongText = txtSoLuongConLai.Text. Trim (); string loaiDV = cbLoaiDV.SelectedItem?. ToString ()?. Trim () ?? "";

if ( maDV.Length == 0) { MessageBox. Show( "Vui lòng nhập mã dịch vụ.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 117

txtMaDV. Focus (); return; }

if ( tenDV.Length == 0) { MessageBox. Show( "Vui lòng nhập tên dịch vụ.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtTenDV. Focus (); return; }

if ( loaiDV.Length == 0) { MessageBox. Show( "Vui lòng chọn loại dịch vụ.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning); cbLoaiDV. Focus (); return; }

if ( loaiDV.Length > 20) { MessageBox. Show( "Tên loại dịch vụ tối đa 20 ký tự.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); cbLoaiDV. Focus (); return; }

if (! decimal. TryParse ( donGiaText, out decimal donGia) || donGia <= 0) { MessageBox. Show( "Đơn giá không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtDonGia. Focus (); return; }

int soLuongConLai = - 1;

if ( soLuongText.Length > 0 && (! int. TryParse ( soLuongText, out soLuongConLai) || soLuongConLai < 0)) { MessageBox. Show( "Số lượng còn lại không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtSoLuongConLai. Focus (); return; }

try { using var db = new HotelManagementContext ();

var daCo = db.DichVus. FirstOrDefault ( d => d.MaDv == maDV);

if ( daCo!= null) { if ( daCo.DaXoa != true) { MessageBox. Show( "Mã dịch vụ đã tồn tại. Vui lòng nhập mã khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtMaDV. Focus (); return; }

var traLoi = MessageBox. Show(

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 118

$"Mã { maDV} từng thuộc dịch vụ \ " { daCo.TenDv} \ " đã bị xóa. \ nBạn có muốn khôi phục mã này với thông tin vừa nhập không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

if ( traLoi!= DialogResult.Yes) { txtMaDV. Focus (); return; }

daCo.TenDv = tenDV; daCo.DonGia = donGia; daCo.SlconLai = soLuongConLai; daCo.LoaiDv = loaiDV; daCo.DaXoa = false; } else { db.DichVus. Add( new Models. DichVu { MaDv = maDV, TenDv = tenDV, DonGia = donGia, SlconLai = soLuongConLai, LoaiDv = loaiDV, DaXoa = false }); }

int rows = db. SaveChanges (); if ( rows > 0) { MessageBox. Show( "Thêm dịch vụ thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information); DialogResult = DialogResult.OK; this. Close (); } else { MessageBox. Show( "Thêm thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); } } catch ( DbUpdateException ex) { MessageBox. Show( "Lỗi: " + ( ex.InnerException?.Message ?? ex.Message), "Lỗi khi thêm", MessageBoxButtons.OK, MessageBoxIcon.Error); } catch ( Exception ex) { MessageBox. Show( "Lỗi: " + ex.Message, "Lỗi khi thêm", MessageBoxButtons.OK, MessageBoxIcon.Error); } }

private void btnThoat_Click ( object sender, EventArgs e) { DialogResult = DialogResult.Cancel; this. Close (); } } }

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 119

### Bước 8: Click chuột phải vào folder DichVu → Add → Forms( Windows Forms) →

### tạo một form để xây dựng giao diện và chức năng cập nhật thông tin 1 dịch vụ đang có

### là FormSuaDichVu.cs

### Bước 10: Thiết kế giao diện FormSuaDichVu.cs theo mẫu như sau:

### Mã nguồn tham khảo trong file FormSuaDichVu.Designer.cs tạm thời như sau:

namespace HotelManagement.DichVu { partial class FormSuaDichVu { /// <summary> /// Required designer variable. /// </summary> private System.ComponentModel. IContainer components = null;

/// <summary> /// Clean up any resources being used. /// </summary> /// <param name=" disposing "> true if managed resources should be disposed; otherwise, false. </param> protected override void Dispose ( bool disposing) { if ( disposing && (components != null)) { components. Dispose (); } base. Dispose ( disposing); }

#region Windows Form Designer generated code

/// <summary> /// Required method for Designer support - do not modify /// the contents of this method with the code editor. /// </summary> private void InitializeComponent () { label6 = new Label (); btnThoat = new Button(); btnCapNhat = new Button(); panel1 = new Panel();

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 120

cbLoaiDV = new ComboBox(); label7 = new Label(); txtSoLuongConLai = new TextBox(); label3 = new Label(); txtDonGia = new TextBox(); label2 = new Label(); txtTenDV = new TextBox(); label1 = new Label(); panel1.SuspendLayout(); SuspendLayout(); // // label6 // label6.AutoSize = true; label6.Font = new Font( "Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 0); label6.ForeColor = Color.FromArgb(192, 0, 0); label6.Location = new Point(124, 29); label6.Name = "label6"; label6.Size = new Size(333, 29); label6.TabIndex = 21; label6.Text = "Cập nhật thông tin dịch vụ"; // // btnThoat // btnThoat.BackColor = SystemColors.GradientActiveCaption; btnThoat.Font = new Font( "Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); btnThoat.Location = new Point(323, 429); btnThoat.Margin = new Padding(3, 4, 3, 4); btnThoat.Name = "btnThoat"; btnThoat.Size = new Size(137, 59); btnThoat.TabIndex = 20; btnThoat.Text = "Thoát"; btnThoat.UseVisualStyleBackColor = false; btnThoat.Click += btnThoat_Click; // // btnCapNhat // btnCapNhat.BackColor = Color.Moccasin; btnCapNhat.Font = new Font( "Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); btnCapNhat.Location = new Point(123, 429); btnCapNhat.Margin = new Padding(3, 4, 3, 4); btnCapNhat.Name = "btnCapNhat"; btnCapNhat.Size = new Size(137, 59); btnCapNhat.TabIndex = 19; btnCapNhat.Text = "Cập nhật"; btnCapNhat.UseVisualStyleBackColor = false; btnCapNhat.Click += btnCapNhat_Click; // // panel1 // panel1.Controls.Add(cbLoaiDV); panel1.Controls.Add(label7); panel1.Controls.Add(txtSoLuongConLai); panel1.Controls.Add(label3); panel1.Controls.Add(txtDonGia); panel1.Controls.Add(label2); panel1.Controls.Add(txtTenDV); panel1.Controls.Add(label1); panel1.Location = new Point(35, 94); panel1.Margin = new Padding(3, 4, 3, 4); panel1.Name = "panel1"; panel1.Size = new Size(507, 288); panel1.TabIndex = 18;

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 121

// // cbLoaiDV // cbLoaiDV.Font = new Font( "Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0); cbLoaiDV.FormattingEnabled = true; cbLoaiDV.Items.AddRange( new object [] { "Dịch vụ giặt ủi quần áo", "Dịch vụ xe đưa đón ", "Dịch vụ cho thuê xe máy tự lái", "Dịch vụ đặt vé máy bay, tour du lịch", "Dịch vụ trông trẻ", "Bơi 4 mùa ", "Dịch vụ karaoke", "Dịch vụ phục vụ phòng 24/24", "Dịch vụ thu đổi ngoại tệ", "Nhà hàng", "Dịch vụ hội họp, văn phòng", "Dịch vụ Spa"}); cbLoaiDV.Location = new Point(202, 95); cbLoaiDV.Margin = new Padding(3, 4, 3, 4); cbLoaiDV.Name = "cbLoaiDV"; cbLoaiDV.Size = new Size(284, 30); cbLoaiDV.TabIndex = 25; // // label7 // label7.AutoSize = true; label7.Font = new Font( "Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0); label7.Location = new Point(48, 94); label7.Name = "label7"; label7.Size = new Size(128, 26); label7.TabIndex = 24; label7.Text = "Loại dịch vụ"; // // txtSoLuongConLai // txtSoLuongConLai.Font = new Font( "Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); txtSoLuongConLai.Location = new Point(202, 219); txtSoLuongConLai.Margin = new Padding(3, 4, 3, 4); txtSoLuongConLai.Name = "txtSoLuongConLai"; txtSoLuongConLai.Size = new Size(284, 30); txtSoLuongConLai.TabIndex = 23; txtSoLuongConLai.KeyPress += txtSoLuongConLai_KeyPress; // // label3 // label3.AutoSize = true; label3.Font = new Font( "Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0); label3.Location = new Point(15, 221); label3.Name = "label3"; label3.Size = new Size(167, 26); label3.TabIndex = 22; label3.Text = "Số lượng còn lại"; // // txtDonGia // txtDonGia.Font = new Font( "Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); txtDonGia.Location = new Point(202, 156); txtDonGia.Margin = new Padding(3, 4, 3, 4); txtDonGia.Name = "txtDonGia"; txtDonGia.Size = new Size(284, 30); txtDonGia.TabIndex = 21; txtDonGia.KeyPress += txtDonGia_KeyPress; // // label2 // label2.AutoSize = true; label2.Font = new Font( "Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0); label2.Location = new Point(89, 156);

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 122

label2.Name = "label2"; label2.Size = new Size(87, 26); label2.TabIndex = 20; label2.Text = "Đơn giá"; // // txtTenDV // txtTenDV.Font = new Font( "Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); txtTenDV.Location = new Point(202, 25); txtTenDV.Margin = new Padding(3, 4, 3, 4); txtTenDV.Name = "txtTenDV"; txtTenDV.Size = new Size(284, 30); txtTenDV.TabIndex = 19; // // label1 // label1.AutoSize = true; label1.Font = new Font( "Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0); label1.Location = new Point(59, 21); label1.Name = "label1"; label1.Size = new Size(123, 26); label1.TabIndex = 18; label1.Text = "Tên dịch vụ"; // // FormSuaDichVu // AutoScaleDimensions = new SizeF(8F, 20F); AutoScaleMode = AutoScaleMode.Font; ClientSize = new Size(540, 522); Controls.Add(label6); Controls.Add(btnThoat); Controls.Add(btnCapNhat); Controls.Add(panel1); Margin = new Padding(3, 4, 3, 4); Name = "FormSuaDichVu"; Text = "FormSuaDichVu"; panel1. ResumeLayout ( false); panel1. PerformLayout (); ResumeLayout ( false); PerformLayout ();

}

#endregion

private System.Windows.Forms. Label label6; private System.Windows.Forms. Button btnThoat; private System.Windows.Forms. Button btnCapNhat; private System.Windows.Forms. Panel panel1; private System.Windows.Forms. ComboBox cbLoaiDV; private System.Windows.Forms. Label label7; private System.Windows.Forms. TextBox txtSoLuongConLai; private System.Windows.Forms. Label label3; private System.Windows.Forms. TextBox txtDonGia; private System.Windows.Forms. Label label2; private System.Windows.Forms. TextBox txtTenDV; private System.Windows.Forms. Label label1; } }

### Bước 10: SV sử dụng mã nguồn tạm thời sau để xử lý chức năng trong file

### FormSuaDichVu.cs

using System;

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 123

using System.Collections.Generic; using System.ComponentModel; using System.Data; using System.Drawing; using System.Text; using System.Windows.Forms; using HotelManagement.Models; using Microsoft.EntityFrameworkCore;

namespace HotelManagement.DichVu { public partial class FormSuaDichVu: Form { private static readonly string [] LoaiMacDinh = { "Thức uống", "Đồ ăn", "Dịch vụ"};

[ Browsable ( false)] [ DesignerSerializationVisibility ( DesignerSerializationVisibility.Hidden)] public string? MaDichVu { get; set; }

public FormSuaDichVu () { InitializeComponent ();

Text = "Cập nhật thông tin dịch vụ"; StartPosition = FormStartPosition.CenterParent; FormBorderStyle = FormBorderStyle.FixedDialog; MaximizeBox = false; MinimizeBox = false; AcceptButton = btnCapNhat; CancelButton = btnThoat;

txtTenDV.MaxLength = 20; txtDonGia.MaxLength = 12; txtSoLuongConLai.MaxLength = 6; txtSoLuongConLai.PlaceholderText = "Để trống = không giới hạn"; cbLoaiDV.DropDownStyle = ComboBoxStyle.DropDownList;

Load += FormSuaDichVu_Load; }

private void FormSuaDichVu_Load ( object? sender, EventArgs e) { string? ma = MaDichVu;

if ( string. IsNullOrEmpty ( ma)) { MessageBox. Show( "Chưa xác định được dịch vụ cần cập nhật.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); btnCapNhat.Enabled = false; return; }

Text = "Cập nhật dịch vụ " + ma;

try { using var db = new HotelManagementContext ();

var dsLoai = new List <string >(LoaiMacDinh);

var loaiTrongCsdl = db.DichVus . AsNoTracking () . Select ( d => d.LoaiDv) . Distinct () . ToList ();

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 124

foreach ( var loai in loaiTrongCsdl) { string ten = ( loai?? ""). Trim ();

if ( ten.Length > 0 && ! dsLoai. Contains ( ten, StringComparer.OrdinalIgnoreCase)) dsLoai. Add( ten); }

cbLoaiDV.Items. Clear (); cbLoaiDV.Items. AddRange ( dsLoai. ToArray ());

var thongTin = db.DichVus . AsNoTracking () . Where( d => d.MaDv == ma && d.DaXoa != true) . Select ( d => new { d.TenDv, d.DonGia, d.SlconLai, d.LoaiDv }) . FirstOrDefault ();

if ( thongTin == null) { MessageBox. Show( "Không tìm thấy dịch vụ " + ma + ".", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); btnCapNhat.Enabled = false; return; }

txtTenDV.Text = thongTin.TenDv; txtDonGia.Text = thongTin.DonGia. ToString ( "0"); txtSoLuongConLai.Text = thongTin.SlconLai == null || thongTin.SlconLai < 0 ? "" : thongTin.SlconLai.Value. ToString (); cbLoaiDV.SelectedIndex = cbLoaiDV. FindStringExact (( thongTin.LoaiDv ?? ""). Trim ()); } catch ( Exception ex) { MessageBox. Show( "Lỗi tải thông tin dịch vụ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); btnCapNhat.Enabled = false; } }

private void btnCapNhat_Click ( object sender, EventArgs e) { string? ma = MaDichVu;

if ( string. IsNullOrEmpty ( ma)) { MessageBox. Show( "Chưa xác định được dịch vụ cần cập nhật.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

string tenDV = txtTenDV.Text. Trim (); string donGiaText = txtDonGia.Text. Trim (); string soLuongText = txtSoLuongConLai.Text. Trim (); string loaiDV = cbLoaiDV.SelectedItem?. ToString ()?. Trim () ?? "";

if ( tenDV.Length == 0) { MessageBox. Show( "Vui lòng nhập tên dịch vụ.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtTenDV. Focus (); return;

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 125

}

if ( loaiDV.Length == 0) { MessageBox. Show( "Vui lòng chọn loại dịch vụ.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning); cbLoaiDV. Focus (); return; }

if (! decimal. TryParse ( donGiaText, out decimal donGia) || donGia <= 0) { MessageBox. Show( "Đơn giá không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtDonGia. Focus (); return; }

int soLuongConLai = - 1;

if ( soLuongText.Length > 0 && (! int. TryParse ( soLuongText, out soLuongConLai) || soLuongConLai < 0)) { MessageBox. Show( "Số lượng còn lại không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtSoLuongConLai. Focus (); return; }

try { using var db = new HotelManagementContext ();

var dichVu = db.DichVus. FirstOrDefault ( d => d.MaDv == ma && d.DaXoa != true);

if ( dichVu == null) { MessageBox. Show( "Không tìm thấy dịch vụ cần cập nhật.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

dichVu.TenDv = tenDV; dichVu.DonGia = donGia; dichVu.SlconLai = soLuongConLai; dichVu.LoaiDv = loaiDV;

int rows = db. SaveChanges (); if ( rows > 0) { MessageBox. Show( "Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); DialogResult = DialogResult.OK; this. Close (); } else { MessageBox. Show( "Thông tin không thay đổi nên không có gì để cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); } } catch ( DbUpdateException ex) {

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 126

MessageBox. Show( "Lỗi khi cập nhật: " + ( ex.InnerException?.Message ?? ex.Message), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); } catch ( Exception ex) { MessageBox. Show( "Lỗi khi cập nhật: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); } }

private void txtSoLuongConLai_KeyPress ( object sender, KeyPressEventArgs e) { if (! char. IsControl ( e.KeyChar) && ! char. IsDigit ( e.KeyChar)) { e.Handled = true; } }

private void txtDonGia_KeyPress ( object sender, KeyPressEventArgs e) { if (! char. IsControl ( e.KeyChar) && ! char. IsDigit ( e.KeyChar)) { e.Handled = true; } }

private void btnThoat_Click ( object sender, EventArgs e) { DialogResult = DialogResult.Cancel; this. Close (); } } }

### 2. Xây dựng giao diện và chức năng quản lý thông tin dịch vụ khách sạn

### Bước 1: Click chuột phải vào thư mục project → Add → New Folder→ Đặt tên folder

### là “TienNghi”

### Bước 2: Click chuột phải vào folder TienNghi → Add → Forms( Windows Forms) →

### tạo một form thể hiện danh sách các tiện ích có trong khách sạn là

### FormDanhSachTienNghi.cs

### Bước 3: Thiết kế giao diện FormDanhSachTienNghi.cs theo mẫu như sau:

### Mã nguồn tham khảo trong file FormDanhSachTienNghi.Designer.cs tạm thời như

### sau:

namespace HotelManagement.TienNghi {

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 127

partial class FormDanhSachTienNghi { /// <summary> /// Required designer variable. /// </summary> private System.ComponentModel. IContainer components = null;

/// <summary> /// Clean up any resources being used. /// </summary> /// <param name=" disposing "> true if managed resources should be disposed; otherwise, false. </param> protected override void Dispose ( bool disposing) { if ( disposing && (components != null)) { components. Dispose (); } base. Dispose ( disposing); }

#region Windows Form Designer generated code

/// <summary> /// Required method for Designer support - do not modify /// the contents of this method with the code editor. /// </summary> private void InitializeComponent () { this.btnThemMoi = new System.Windows.Forms. Button (); this.dtgDanhSachTienNghi = new System.Windows.Forms. DataGridView (); this.btnXuatExcel = new System.Windows.Forms. Button (); this.txtTimKiem = new System.Windows.Forms. TextBox (); this.pictureBox1 = new System.Windows.Forms. PictureBox ();

((System.ComponentModel. ISupportInitialize)( this.dtgDanhSachTienNghi)). BeginInit (); ((System.ComponentModel. ISupportInitialize)( this.pictureBox1)). BeginInit (); this. SuspendLayout (); // // btnThemMoi // this.btnThemMoi.BackColor = System.Drawing. Color.LightPink; this.btnThemMoi.Font = new System.Drawing. Font ( "Microsoft Sans Serif", 12F, System.Drawing. FontStyle.Bold, System.Drawing. GraphicsUnit.Point, (( byte)(0))); this.btnThemMoi.Location = new System.Drawing. Point (841, 8); this.btnThemMoi.Name = "btnThemMoi"; this.btnThemMoi.Size = new System.Drawing. Size (167, 37); this.btnThemMoi.TabIndex = 15; this.btnThemMoi.Text = "Thêm mới"; this.btnThemMoi.UseVisualStyleBackColor = false; // this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click); // // dtgDanhSachTienNghi // this.dtgDanhSachTienNghi.ColumnHeadersHeightSizeMode = System.Windows.Forms. DataGridViewColumnHeadersHeightSizeMode.AutoSize; this.dtgDanhSachTienNghi.Location = new System.Drawing. Point (3, 62); this.dtgDanhSachTienNghi.Name = "dtgDanhSachTienNghi"; this.dtgDanhSachTienNghi.RowHeadersWidth = 51; this.dtgDanhSachTienNghi.RowTemplate.Height = 24; this.dtgDanhSachTienNghi.Size = new System.Drawing. Size (1035, 615); this.dtgDanhSachTienNghi.TabIndex = 14; // this.dtgDanhSachTienNghi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDanhSachTienNghi_CellClick); // // btnXuatExcel

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 128

// this.btnXuatExcel.BackColor = System.Drawing. Color.DarkTurquoise; this.btnXuatExcel.Font = new System.Drawing. Font ( "Microsoft Sans Serif", 12F, System.Drawing. FontStyle.Bold, System.Drawing. GraphicsUnit.Point, (( byte)(0))); this.btnXuatExcel.Location = new System.Drawing. Point (640, 8); this.btnXuatExcel.Name = "btnXuatExcel"; this.btnXuatExcel.Size = new System.Drawing. Size (167, 37); this.btnXuatExcel.TabIndex = 13; this.btnXuatExcel.Text = "Xuất file Excel"; this.btnXuatExcel.UseVisualStyleBackColor = false; // this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click); // // txtTimKiem // this.txtTimKiem.Font = new System.Drawing. Font ( "Microsoft Sans Serif", 13F, System.Drawing. FontStyle.Regular, System.Drawing. GraphicsUnit.Point, (( byte)(0))); this.txtTimKiem.Location = new System.Drawing. Point (199, 13); this.txtTimKiem.Name = "txtTimKiem"; this.txtTimKiem.Size = new System.Drawing. Size (187, 32); this.txtTimKiem.TabIndex = 11; // this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged); // // pictureBox1 // this.pictureBox1.Image = global::HotelManagement.Properties. Resources.search; this.pictureBox1.Location = new System.Drawing. Point (154, 8); this.pictureBox1.Name = "pictureBox1"; this.pictureBox1.Size = new System.Drawing. Size (39, 37); this.pictureBox1.TabIndex = 12; this.pictureBox1.TabStop = false; // // FormDanhSachTienNghi // this.AutoScaleDimensions = new System.Drawing. SizeF (8F, 16F); this.AutoScaleMode = System.Windows.Forms. AutoScaleMode.Font; this.ClientSize = new System.Drawing. Size (1043, 685); this.Controls. Add( this.btnThemMoi); this.Controls. Add( this.dtgDanhSachTienNghi); this.Controls. Add( this.btnXuatExcel); this.Controls. Add( this.pictureBox1); this.Controls. Add( this.txtTimKiem); this.Name = "FormDanhSachTienNghi"; this.StartPosition = System.Windows.Forms. FormStartPosition.CenterScreen; this.Text = "Quản lý thông tin tiện nghi"; // this.Load += new System.EventHandler(this.FormDanhSachTienNghi_Load);

((System.ComponentModel. ISupportInitialize)( this.dtgDanhSachTienNghi)). EndInit (); ((System.ComponentModel. ISupportInitialize)( this.pictureBox1)). EndInit (); this. ResumeLayout ( false); this. PerformLayout ();

}

#endregion

private System.Windows.Forms. Button btnThemMoi; private System.Windows.Forms. DataGridView dtgDanhSachTienNghi; private System.Windows.Forms. Button btnXuatExcel; private System.Windows.Forms. PictureBox pictureBox1; private System.Windows.Forms. TextBox txtTimKiem; } }

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 129

### Bước 4: SV sử dụng mã nguồn tạm thời sau để xử lý chức năng trong file

### FormDanhSachTienNghi.cs

using System; using System.Collections.Generic; using System.ComponentModel; using System.Data; using System.Drawing; using System.Text; using System.Windows.Forms; using ClosedXML.Excel; using HotelManagement.Models; using Microsoft.EntityFrameworkCore;

namespace HotelManagement.TienNghi { public partial class FormDanhSachTienNghi: Form { public FormDanhSachTienNghi () { InitializeComponent (); }

private void FormDanhSachTienNghi_Load ( object sender, EventArgs e) { LoadDanhSachTienNghi (); }

private void KhoiTaoBangDuLieu () { dtgDanhSachTienNghi.AllowUserToAddRows = false; dtgDanhSachTienNghi.AllowUserToDeleteRows = false; dtgDanhSachTienNghi.AllowUserToResizeRows = false; dtgDanhSachTienNghi.ReadOnly = true; dtgDanhSachTienNghi.MultiSelect = false; dtgDanhSachTienNghi.RowHeadersVisible = false; dtgDanhSachTienNghi.SelectionMode = DataGridViewSelectionMode.FullRowSelect; dtgDanhSachTienNghi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; dtgDanhSachTienNghi.RowTemplate.Height = 40;

DataGridViewImageColumn iconCol = new DataGridViewImageColumn (); iconCol.Name = "Icon"; iconCol.HeaderText = ""; iconCol.ImageLayout = DataGridViewImageCellLayout.Zoom; iconCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.None; iconCol.Width = 50; dtgDanhSachTienNghi.Columns. Add( iconCol);

dtgDanhSachTienNghi.Columns. Add( "MaTN", "Mã tiện nghi"); dtgDanhSachTienNghi.Columns. Add( "TenTN", "Tên tiện nghi"); dtgDanhSachTienNghi.Columns[ "MaTN"].FillWeight = 30; dtgDanhSachTienNghi.Columns[ "TenTN"].FillWeight = 70;

DataGridViewImageColumn suaCol = new DataGridViewImageColumn (); suaCol.Name = "Sua"; suaCol.HeaderText = "Sửa"; suaCol.ImageLayout = DataGridViewImageCellLayout.Zoom; suaCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.None; suaCol.Width = 50; dtgDanhSachTienNghi.Columns. Add( suaCol);

DataGridViewImageColumn xoaCol = new DataGridViewImageColumn (); xoaCol.Name = "Xoa";

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 130

xoaCol.HeaderText = "Xóa"; xoaCol.ImageLayout = DataGridViewImageCellLayout.Zoom; xoaCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.None; xoaCol.Width = 50; dtgDanhSachTienNghi.Columns. Add( xoaCol); }

private void LoadDanhSachTienNghi ( string tuKhoa = "") { try { if (dtgDanhSachTienNghi.Columns.Count == 0) { KhoiTaoBangDuLieu (); }

using var db = new HotelManagementContext ();

var query = db.TienNghis . AsNoTracking () . Where( t => t.DaXoa != true);

if (! string. IsNullOrWhiteSpace ( tuKhoa)) { query = query. Where( t => t.TenTn. Contains ( tuKhoa)); }

var danhSach = query . OrderBy ( t => t.MaTn) . Select ( t => new { t.MaTn, t.TenTn }) . ToList ();

Image iconTienNghi = Properties. Resources.TienNghi; Image iconSua = Properties. Resources.edit; Image iconXoa = Properties. Resources.delete;

dtgDanhSachTienNghi.Rows. Clear (); foreach ( var tn in danhSach) { dtgDanhSachTienNghi.Rows. Add( iconTienNghi, tn.MaTn, tn.TenTn, iconSua, iconXoa ); }

dtgDanhSachTienNghi. ClearSelection (); } catch ( Exception ex) { MessageBox. Show( "Lỗi khi load tiện nghi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); } }

private void txtTimKiem_TextChanged ( object sender, EventArgs e) { LoadDanhSachTienNghi (txtTimKiem.Text. Trim ()); }

private void btnXuatExcel_Click ( object sender, EventArgs e) { if (dtgDanhSachTienNghi.Rows.Count == 0) {

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 131

MessageBox. Show( "Không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

using SaveFileDialog saveDialog = new SaveFileDialog (); saveDialog.Title = "Xuất danh sách tiện nghi"; saveDialog.Filter = "Excel Workbook (*.xlsx)|*.xlsx"; saveDialog.FileName = "DanhSachTienNghi_" + DateTime.Now. ToString ( "yyyyMMdd_HHmmss") + ".xlsx";

if ( saveDialog. ShowDialog () != DialogResult.OK) { return; }

try { using ( XLWorkbook workbook = new XLWorkbook ()) { IXLWorksheet worksheet = workbook.Worksheets. Add( "Danh sách tiện nghi");

worksheet. Cell (1, 1).Value = "Mã tiện nghi"; worksheet. Cell (1, 2).Value = "Tên tiện nghi"; worksheet. Range (1, 1, 1, 2).Style.Font.Bold = true;

for ( int i = 0; i < dtgDanhSachTienNghi.Rows.Count; i ++) { worksheet. Cell ( i + 2, 1).Value = dtgDanhSachTienNghi.Rows[ i].Cells[ "MaTN"].Value?. ToString () ?? ""; worksheet. Cell ( i + 2, 2).Value = dtgDanhSachTienNghi.Rows[ i].Cells[ "TenTN"].Value?. ToString () ?? ""; }

worksheet. Columns (). AdjustToContents (); workbook. SaveAs ( saveDialog.FileName); }

DialogResult moFile = MessageBox. Show( "Xuất dữ liệu thành công! \ nBạn có muốn mở file vừa xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

if ( moFile == DialogResult.Yes) { System.Diagnostics. Process. Start ( new System.Diagnostics. ProcessStartInfo ( saveDialog.FileName) { UseShellExecute = true }); } } catch ( Exception ex) { MessageBox. Show( "Lỗi khi xuất file Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); } }

private void btnThemMoi_Click ( object sender, EventArgs e) { using ( FormThemTienNghi f = new FormThemTienNghi ()) { if ( f. ShowDialog () == DialogResult.OK)

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 132

{ LoadDanhSachTienNghi (txtTimKiem.Text. Trim ()); } } }

private void dtgDanhSachTienNghi_CellClick ( object sender, DataGridViewCellEventArgs e) { if ( e.RowIndex < 0 || e.ColumnIndex < 0) { return; }

string tenCot = dtgDanhSachTienNghi.Columns[ e.ColumnIndex].Name; if ( tenCot!= "Sua" && tenCot!= "Xoa") { return; }

string maTN = dtgDanhSachTienNghi.Rows[ e.RowIndex].Cells[ "MaTN"].Value?. ToString (); if ( string. IsNullOrEmpty ( maTN)) { return; }

if (tenCot == "Sua") { using (FormSuaTienNghi f = new FormSuaTienNghi(maTN)) { if (f.ShowDialog() == DialogResult.OK) { LoadDanhSachTienNghi(txtTimKiem.Text.Trim()); } } return; }

if ( MessageBox. Show( "Bạn có chắc chắn muốn xóa tiện nghi này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) { return; }

try { using var db = new HotelManagementContext ();

var tienNghi = db.TienNghis. FirstOrDefault ( t => t.MaTn == maTN); if ( tienNghi == null) { MessageBox. Show( "Không tìm thấy tiện nghi cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); } else { tienNghi.DaXoa = true; int kq = db. SaveChanges ();

if ( kq > 0) { MessageBox. Show( "Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); } else

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 133

{ MessageBox. Show( "Xóa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); } } } catch ( Exception ex) { MessageBox. Show( "Lỗi khi xóa tiện nghi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }

LoadDanhSachTienNghi (txtTimKiem.Text. Trim ()); } } }

### Bước 5: Chỉnh sửa lại hàm private void button12_Click(object sender,

### EventArgs e)trong file FormMain.cs theo nội dung như sau:

private void button12_Click ( object sender, EventArgs e) { Form formCon = new TienNghi. FormDanhSachTienNghi (); formCon.TopLevel = false; formCon.FormBorderStyle = FormBorderStyle.None; formCon.Dock = DockStyle.Fill; XoaNoiDungPanelMain (); panelMain.Controls. Add( formCon); formCon. Show(); }

### Bước 5: Click chuột phải vào folder TienNghi → Add → Forms( Windows Forms) →

### tạo một form để xây dựng giao diện và chức năng thêm mới thông tin 1 tiện nghi trong

### khách sạn là FormThemTienNghi.cs

### Bước 6: Thiết kế giao diện FormThemTienNghi.cs theo mẫu như sau:

### Mã nguồn tham khảo trong file FormThemTienNghi.Designer.cs tạm thời như sau:

namespace HotelManagement.TienNghi { partial class FormThemTienNghi { /// <summary> /// Required designer variable. /// </summary>

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 134

private System.ComponentModel. IContainer components = null;

/// <summary> /// Clean up any resources being used. /// </summary> /// <param name=" disposing "> true if managed resources should be disposed; otherwise, false. </param> protected override void Dispose ( bool disposing) { if ( disposing && (components != null)) { components. Dispose (); } base. Dispose ( disposing); }

#region Windows Form Designer generated code

/// <summary> /// Required method for Designer support - do not modify /// the contents of this method with the code editor. /// </summary> private void InitializeComponent () { LabelThemTienNghi = new Label (); label1 = new Label (); txtTenTN = new TextBox (); btnThoat = new Button (); btnThemMoi = new Button (); txtMaTN = new TextBox (); label2 = new Label (); SuspendLayout (); // // LabelThemTienNghi // LabelThemTienNghi.AutoSize = true; LabelThemTienNghi.Font = new Font ( "Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0); LabelThemTienNghi.ForeColor = Color. FromArgb (192, 0, 0); LabelThemTienNghi.Location = new Point (122, 22); LabelThemTienNghi.Margin = new Padding (4, 0, 4, 0); LabelThemTienNghi.Name = "LabelThemTienNghi"; LabelThemTienNghi.Size = new Size (261, 46); LabelThemTienNghi.TabIndex = 1; LabelThemTienNghi.Text = "Thêm tiện nghi"; // // label1 // label1.AutoSize = true; label1.Font = new Font ( "Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0); label1.Location = new Point (56, 198); label1.Name = "label1"; label1.Size = new Size (136, 26); label1.TabIndex = 2; label1.Text = "Tên tiện nghi"; // // txtTenTN // txtTenTN.Font = new Font ( "Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0); txtTenTN.Location = new Point (210, 191); txtTenTN.Margin = new Padding (3, 4, 3, 4); txtTenTN.Name = "txtTenTN"; txtTenTN.Size = new Size (298, 34); txtTenTN.TabIndex = 3;

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 135

// // btnThoat // btnThoat.BackColor = SystemColors.GradientActiveCaption; btnThoat.Font = new Font ( "Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); btnThoat.Location = new Point (330, 261); btnThoat.Margin = new Padding (3, 4, 3, 4); btnThoat.Name = "btnThoat"; btnThoat.Size = new Size (137, 59); btnThoat.TabIndex = 15; btnThoat.Text = "Thoát"; btnThoat.UseVisualStyleBackColor = false; btnThoat.Click += btnThoat_Click; // // btnThemMoi // btnThemMoi.BackColor = Color.Moccasin; btnThemMoi.Font = new Font ( "Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); btnThemMoi.Location = new Point (130, 261); btnThemMoi.Margin = new Padding (3, 4, 3, 4); btnThemMoi.Name = "btnThemMoi"; btnThemMoi.Size = new Size (137, 59); btnThemMoi.TabIndex = 14; btnThemMoi.Text = "Thêm mới"; btnThemMoi.UseVisualStyleBackColor = false; btnThemMoi.Click += btnThemMoi_Click; // // txtMaTN // txtMaTN.Font = new Font ( "Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0); txtMaTN.Location = new Point (210, 100); txtMaTN.Margin = new Padding (3, 4, 3, 4); txtMaTN.Name = "txtMaTN"; txtMaTN.Size = new Size (298, 34); txtMaTN.TabIndex = 17; // // label2 // label2.AutoSize = true; label2.Font = new Font ( "Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0); label2.Location = new Point (56, 110); label2.Name = "label2"; label2.Size = new Size (130, 26); label2.TabIndex = 16; label2.Text = "Mả tiện nghi"; // // FormThemTienNghi // AutoScaleDimensions = new SizeF (8F, 20F); AutoScaleMode = AutoScaleMode.Font; ClientSize = new Size (520, 380); Controls. Add(txtMaTN); Controls. Add(label2); Controls. Add(btnThoat); Controls. Add(btnThemMoi); Controls. Add(txtTenTN); Controls. Add(label1); Controls. Add(LabelThemTienNghi); Margin = new Padding (3, 4, 3, 4); Name = "FormThemTienNghi"; ResumeLayout ( false); PerformLayout ();

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 136

}

#endregion

private System.Windows.Forms. Label LabelThemTienNghi; private System.Windows.Forms. Label label1; private System.Windows.Forms. TextBox txtTenTN; private System.Windows.Forms. Button btnThoat; private System.Windows.Forms. Button btnThemMoi; private System.Windows.Forms. TextBox txtMaTN; private System.Windows.Forms. Label label2; } } }

### Bước 10: SV sử dụng mã nguồn tạm thời sau để xử lý chức năng trong file

### FormThemTienNghi.cs

using System; using System.Collections.Generic; using System.ComponentModel; using System.Data; using System.Drawing; using System.Text; using System.Windows.Forms; using HotelManagement.Models;

namespace HotelManagement.TienNghi { public partial class FormThemTienNghi: Form { public FormThemTienNghi () { InitializeComponent (); }

private void btnThemMoi_Click ( object sender, EventArgs e) { string maTN = txtMaTN.Text. Trim (). ToUpper (); string tenTN = txtTenTN.Text. Trim ();

if ( string. IsNullOrEmpty ( maTN)) { MessageBox. Show( "Vui lòng nhập mã tiện nghi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtMaTN. Focus (); return; }

if ( maTN.Length > 5) { MessageBox. Show( "Mã tiện nghi tối đa 5 ký tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtMaTN. Focus (); return; }

if ( string. IsNullOrEmpty ( tenTN)) { MessageBox. Show( "Vui lòng nhập tên tiện nghi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtTenTN. Focus (); return; }

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 137

if ( tenTN.Length > 50) { MessageBox. Show( "Tên tiện nghi tối đa 50 ký tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtTenTN. Focus (); return; }

try { using var db = new HotelManagementContext ();

if ( db.TienNghis. Any ( t => t.MaTn == maTN)) { MessageBox. Show( "Mã tiện nghi đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtMaTN. Focus (); return; }

if ( db.TienNghis. Any ( t => t.DaXoa != true && t.TenTn == tenTN)) { MessageBox. Show( "Tên tiện nghi đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtTenTN. Focus (); return; }

var tienNghi = new Models. TienNghi { MaTn = maTN, TenTn = tenTN, DaXoa = false };

db.TienNghis. Add( tienNghi); int kq = db. SaveChanges ();

if ( kq > 0) { MessageBox. Show( "Thêm tiện nghi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); DialogResult = DialogResult.OK; Close (); } else { MessageBox. Show( "Thêm tiện nghi thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); } } catch ( Exception ex) { MessageBox. Show( "Lỗi khi thêm tiện nghi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); } }

private void btnThoat_Click ( object sender, EventArgs e) { DialogResult = DialogResult.Cancel; Close (); } } }

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 138

### Bước 11: Click chuột phải vào folder TienNghi → Add → Forms( Windows Forms)

### → tạo một form để xây dựng giao diện và chức năng cập nhật thông tin 1 tiện nghi

### đang có là FormSuaTienNghi.cs

### Bước 12: Thiết kế giao diện FormSuaTienNghi.cs theo mẫu như sau:

### Mã nguồn tham khảo trong file FormSuaDichVu.Designer.cs tạm thời như sau:

namespace HotelManagement.TienNghi { partial class FormSuaTienNghi { /// <summary> /// Required designer variable. /// </summary> private System.ComponentModel. IContainer components = null;

/// <summary> /// Clean up any resources being used. /// </summary> /// <param name=" disposing "> true if managed resources should be disposed; otherwise, false. </param> protected override void Dispose ( bool disposing) { if ( disposing && (components != null)) { components. Dispose (); } base. Dispose ( disposing); }

#region Windows Form Designer generated code

/// <summary> /// Required method for Designer support - do not modify /// the contents of this method with the code editor. /// </summary> private void InitializeComponent () { btnThoat = new Button (); btnCapNhat = new Button (); txtTenTN = new TextBox (); label1 = new Label (); LabelThemTienNghi = new Label (); SuspendLayout (); // // btnThoat // btnThoat.BackColor = SystemColors.GradientActiveCaption;

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 139

btnThoat.Font = new Font( "Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); btnThoat.Location = new Point(333, 234); btnThoat.Margin = new Padding(3, 4, 3, 4); btnThoat.Name = "btnThoat"; btnThoat.Size = new Size(137, 59); btnThoat.TabIndex = 22; btnThoat.Text = "Thoát"; btnThoat.UseVisualStyleBackColor = false; btnThoat.Click += btnThoat_Click; // // btnCapNhat // btnCapNhat.BackColor = Color.Moccasin; btnCapNhat.Font = new Font( "Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); btnCapNhat.Location = new Point(133, 234); btnCapNhat.Margin = new Padding(3, 4, 3, 4); btnCapNhat.Name = "btnCapNhat"; btnCapNhat.Size = new Size(137, 59); btnCapNhat.TabIndex = 21; btnCapNhat.Text = "Cập nhật"; btnCapNhat.UseVisualStyleBackColor = false; btnCapNhat.Click += btnCapNhat_Click; // // txtTenTN // txtTenTN.Font = new Font( "Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0); txtTenTN.Location = new Point(213, 164); txtTenTN.Margin = new Padding(3, 4, 3, 4); txtTenTN.Name = "txtTenTN"; txtTenTN.Size = new Size(298, 34); txtTenTN.TabIndex = 20; // // label1 // label1.AutoSize = true; label1.Font = new Font( "Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0); label1.Location = new Point(59, 170); label1.Name = "label1"; label1.Size = new Size(136, 26); label1.TabIndex = 19; label1.Text = "Tên tiện nghi"; // // LabelThemTienNghi // LabelThemTienNghi.AutoSize = true; LabelThemTienNghi.Font = new Font( "Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0); LabelThemTienNghi.ForeColor = Color. FromArgb (192, 0, 0); LabelThemTienNghi.Location = new Point (136, 51); LabelThemTienNghi.Margin = new Padding (4, 0, 4, 0); LabelThemTienNghi.Name = "LabelThemTienNghi"; LabelThemTienNghi.Size = new Size (313, 46); LabelThemTienNghi.TabIndex = 18; LabelThemTienNghi.Text = "Cập nhật tiện nghi"; // // FormSuaTienNghi // AutoScaleDimensions = new SizeF (8F, 20F); AutoScaleMode = AutoScaleMode.Font; ClientSize = new Size (549, 400); Controls. Add(btnThoat); Controls. Add(btnCapNhat);

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 140

Controls. Add(txtTenTN); Controls. Add(label1); Controls. Add(LabelThemTienNghi); Margin = new Padding (3, 4, 3, 4); Name = "FormSuaTienNghi"; Text = "FormSuaTienNghi"; Load += FormSuaTienNghi_Load; ResumeLayout ( false); PerformLayout ();

}

#endregion private System.Windows.Forms. Button btnThoat; private System.Windows.Forms. Button btnCapNhat; private System.Windows.Forms. TextBox txtTenTN; private System.Windows.Forms. Label label1; private System.Windows.Forms. Label LabelThemTienNghi; } }

### Bước 13: SV sử dụng mã nguồn tạm thời sau để xử lý chức năng trong file

### FormSuaTienNghi.cs

using System; using System.Collections.Generic; using System.ComponentModel; using System.Data; using System.Drawing; using System.Text; using System.Windows.Forms; using HotelManagement.Models;

namespace HotelManagement.TienNghi { public partial class FormSuaTienNghi: Form { private string maTN = string.Empty;

public FormSuaTienNghi () { InitializeComponent (); }

public FormSuaTienNghi ( string maTN) : this () { this.maTN = maTN; }

private void FormSuaTienNghi_Load ( object sender, EventArgs e) { if ( string. IsNullOrEmpty (maTN)) { MessageBox. Show( "Không xác định được tiện nghi cần cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); DialogResult = DialogResult.Cancel; Close (); return; }

try { using var db = new HotelManagementContext ();

var tienNghi = db.TienNghis . Where( t => t.MaTn == maTN && t.DaXoa != true)

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 141

. Select ( t => new { t.TenTn }) . FirstOrDefault ();

if ( tienNghi == null) { MessageBox. Show( "Không tìm thấy tiện nghi cần cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); DialogResult = DialogResult.Cancel; Close (); return; }

txtTenTN.Text = tienNghi.TenTn; txtTenTN. Focus (); txtTenTN. SelectAll (); } catch ( Exception ex) { MessageBox. Show( "Lỗi khi load tiện nghi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); DialogResult = DialogResult.Cancel; Close (); } }

private void btnCapNhat_Click ( object sender, EventArgs e) { string tenTN = txtTenTN.Text. Trim ();

if ( string. IsNullOrEmpty ( tenTN)) { MessageBox. Show( "Vui lòng nhập tên tiện nghi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtTenTN. Focus (); return; }

if ( tenTN.Length > 50) { MessageBox. Show( "Tên tiện nghi tối đa 50 ký tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtTenTN. Focus (); return; }

try { using var db = new HotelManagementContext ();

var tienNghi = db.TienNghis. FirstOrDefault ( t => t.MaTn == maTN && t.DaXoa != true); if ( tienNghi == null) { MessageBox. Show( "Không tìm thấy tiện nghi cần cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); DialogResult = DialogResult.Cancel; Close (); return; }

if ( db.TienNghis. Any ( t => t.MaTn != maTN && t.DaXoa != true && t.TenTn == tenTN)) { MessageBox. Show( "Tên tiện nghi đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtTenTN. Focus ();

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 142

return; }

tienNghi.TenTn = tenTN; int kq = db. SaveChanges ();

if ( kq > 0) { MessageBox. Show( "Cập nhật tiện nghi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); DialogResult = DialogResult.OK; Close (); } else { MessageBox. Show( "Không có thay đổi nào để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); } } catch ( Exception ex) { MessageBox. Show( "Lỗi khi cập nhật tiện nghi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); } }

private void btnThoat_Click ( object sender, EventArgs e) { DialogResult = DialogResult.Cancel; Close (); } } }

### 3. Xây dựng giao diện và chức năng quản lý thông tin khách hàng tại khách sạn

### Bước 1: Click chuột phải vào thư mục project → Add → New Folder→ Đặt tên folder

### là “KhachHang”

### Bước 2: Click chuột phải vào folder KhachHang → Add → Forms( Windows Forms)

### → tạo một form thể hiện danh sách các khách hàng đã và đang thuê phòng trong khách

### sạn là FormDanhSachKhachHang.cs

### Bước 3: Thiết kế giao diện FormDanhSachKhachHang.cs theo mẫu như sau:

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 143

### Mã nguồn tham khảo trong file FormDanhSachKhachHang.Designer.cs tạm thời như

### sau:

namespace HotelManagement.KhachHang { partial class FormDanhSachKhachHang { /// <summary> /// Required designer variable. /// </summary> private System.ComponentModel. IContainer components = null;

/// <summary> /// Clean up any resources being used. /// </summary> /// <param name=" disposing "> true if managed resources should be disposed; otherwise, false. </param> protected override void Dispose ( bool disposing) { if ( disposing && (components != null)) { components. Dispose (); } base. Dispose ( disposing); }

#region Windows Form Designer generated code

/// <summary> /// Required method for Designer support - do not modify /// the contents of this method with the code editor. /// </summary> private void InitializeComponent () { this.btnThemMoi = new System.Windows.Forms. Button (); this.dtgDanhSachKhachHang = new System.Windows.Forms. DataGridView (); this.btnXuatExcel = new System.Windows.Forms. Button (); this.txtTimKiem = new System.Windows.Forms. TextBox (); this.pictureBox1 = new System.Windows.Forms. PictureBox ();

((System.ComponentModel. ISupportInitialize)( this.dtgDanhSachKhachHang)). BeginInit (); ((System.ComponentModel. ISupportInitialize)( this.pictureBox1)). BeginInit (); this. SuspendLayout (); // // btnThemMoi // this.btnThemMoi.BackColor = System.Drawing. Color.LightPink; this.btnThemMoi.Font = new System.Drawing. Font ( "Microsoft Sans Serif", 12F, System.Drawing. FontStyle.Bold, System.Drawing. GraphicsUnit.Point, (( byte)(0))); this.btnThemMoi.Location = new System.Drawing. Point (687, 22); this.btnThemMoi.Name = "btnThemMoi"; this.btnThemMoi.Size = new System.Drawing. Size (167, 37); this.btnThemMoi.TabIndex = 20; this.btnThemMoi.Text = "Thêm mới"; this.btnThemMoi.UseVisualStyleBackColor = false; //this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click); // // dtgDanhSachKhachHang // this.dtgDanhSachKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms. DataGridViewColumnHeadersHeightSizeMode.AutoSize; this.dtgDanhSachKhachHang.Location = new System.Drawing. Point (26, 72); this.dtgDanhSachKhachHang.Name = "dtgDanhSachKhachHang"; this.dtgDanhSachKhachHang.RowHeadersWidth = 51; this.dtgDanhSachKhachHang.RowTemplate.Height = 24;

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 144

this.dtgDanhSachKhachHang.Size = new System.Drawing. Size (945, 543); this.dtgDanhSachKhachHang.TabIndex = 19; //this.dtgDanhSachKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDanhSachKhachHang_CellClick); // // btnXuatExcel // this.btnXuatExcel.BackColor = System.Drawing. Color.DarkTurquoise; this.btnXuatExcel.Font = new System.Drawing. Font ( "Microsoft Sans Serif", 12F, System.Drawing. FontStyle.Bold, System.Drawing. GraphicsUnit.Point, (( byte)(0))); this.btnXuatExcel.Location = new System.Drawing. Point (489, 22); this.btnXuatExcel.Name = "btnXuatExcel"; this.btnXuatExcel.Size = new System.Drawing. Size (167, 37); this.btnXuatExcel.TabIndex = 18; this.btnXuatExcel.Text = "Xuất file Excel"; this.btnXuatExcel.UseVisualStyleBackColor = false; // this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click); // // txtTimKiem // this.txtTimKiem.Font = new System.Drawing. Font ( "Microsoft Sans Serif", 13F, System.Drawing. FontStyle.Regular, System.Drawing. GraphicsUnit.Point, (( byte)(0))); this.txtTimKiem.Location = new System.Drawing. Point (87, 27); this.txtTimKiem.Name = "txtTimKiem"; this.txtTimKiem.Size = new System.Drawing. Size (187, 32); this.txtTimKiem.TabIndex = 16; //this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged); // // pictureBox1 // this.pictureBox1.Image = global::HotelManagement.Properties. Resources.search; this.pictureBox1.Location = new System.Drawing. Point (42, 22); this.pictureBox1.Name = "pictureBox1"; this.pictureBox1.Size = new System.Drawing. Size (39, 37); this.pictureBox1.TabIndex = 17; this.pictureBox1.TabStop = false; // // FormDanhSachKhachHang // this.AutoScaleDimensions = new System.Drawing. SizeF (8F, 16F); this.AutoScaleMode = System.Windows.Forms. AutoScaleMode.Font; this.ClientSize = new System.Drawing. Size (983, 620); this.Controls. Add( this.btnThemMoi); this.Controls. Add( this.dtgDanhSachKhachHang); this.Controls. Add( this.btnXuatExcel); this.Controls. Add( this.pictureBox1); this.Controls. Add( this.txtTimKiem); this.Name = "FormDanhSachKhachHang"; this.StartPosition = System.Windows.Forms. FormStartPosition.CenterScreen; this.Text = "FormDanhSachKhachHang"; // this.Load += new System.EventHandler(this.FormDanhSachKhachHang_Load);

((System.ComponentModel. ISupportInitialize)( this.dtgDanhSachKhachHang)). EndInit (); ((System.ComponentModel. ISupportInitialize)( this.pictureBox1)). EndInit (); this. ResumeLayout ( false); this. PerformLayout ();

}

#endregion

private System.Windows.Forms. Button btnThemMoi; private System.Windows.Forms. DataGridView dtgDanhSachKhachHang;

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 145

private System.Windows.Forms. Button btnXuatExcel; private System.Windows.Forms. PictureBox pictureBox1; private System.Windows.Forms. TextBox txtTimKiem; } }

### Bước 4: SV sử dụng mã nguồn tạm thời sau để xử lý chức năng trong file

### FormDanhSachKhachHang.cs

using System; using System.Collections.Generic; using System.ComponentModel; using System.Data; using System.Drawing; using System.Text; using System.Windows.Forms; using ClosedXML.Excel; using HotelManagement.Models; using Microsoft.EntityFrameworkCore;

namespace HotelManagement.KhachHang { public partial class FormDanhSachKhachHang : Form { public FormDanhSachKhachHang() { InitializeComponent(); }

private void FormDanhSachKhachHang_Load(object sender, EventArgs e) { LoadDanhSachKhachHang(); }

private void KhoiTaoBangDuLieu() { dtgDanhSachKhachHang.AllowUserToAddRows = false; dtgDanhSachKhachHang.AllowUserToDeleteRows = false; dtgDanhSachKhachHang.AllowUserToResizeRows = false; dtgDanhSachKhachHang.ReadOnly = true; dtgDanhSachKhachHang.MultiSelect = false; dtgDanhSachKhachHang.RowHeadersVisible = false; dtgDanhSachKhachHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect; dtgDanhSachKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; dtgDanhSachKhachHang.RowTemplate.Height = 40;

DataGridViewImageColumn iconCol = new DataGridViewImageColumn(); iconCol.Name = "Icon"; iconCol.HeaderText = ""; iconCol.ImageLayout = DataGridViewImageCellLayout.Zoom; iconCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.None; iconCol.Width = 40; dtgDanhSachKhachHang.Columns.Add(iconCol);

dtgDanhSachKhachHang.Columns.Add("MaKH", "Mã KH"); dtgDanhSachKhachHang.Columns.Add("TenKH", "Tên khách hàng"); dtgDanhSachKhachHang.Columns.Add("SDT", "SĐT"); dtgDanhSachKhachHang.Columns.Add("CCCD", "CCCD/Passport"); dtgDanhSachKhachHang.Columns.Add("QuocTich", "Quốc tịch"); dtgDanhSachKhachHang.Columns.Add("GioiTinh", "Giới tính");

dtgDanhSachKhachHang.Columns["MaKH"].FillWeight = 10; dtgDanhSachKhachHang.Columns["TenKH"].FillWeight = 25;

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 146

dtgDanhSachKhachHang.Columns["SDT"].FillWeight = 15; dtgDanhSachKhachHang.Columns["CCCD"].FillWeight = 20; dtgDanhSachKhachHang.Columns["QuocTich"].FillWeight = 15; dtgDanhSachKhachHang.Columns["GioiTinh"].FillWeight = 10;

DataGridViewImageColumn suaCol = new DataGridViewImageColumn(); suaCol.Name = "Sua"; suaCol.HeaderText = "Sửa"; suaCol.ImageLayout = DataGridViewImageCellLayout.Zoom; suaCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.None; suaCol.Width = 50; dtgDanhSachKhachHang.Columns.Add(suaCol);

DataGridViewImageColumn xoaCol = new DataGridViewImageColumn(); xoaCol.Name = "Xoa"; xoaCol.HeaderText = "Xóa"; xoaCol.ImageLayout = DataGridViewImageCellLayout.Zoom; xoaCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.None; xoaCol.Width = 50; dtgDanhSachKhachHang.Columns.Add(xoaCol); }

private void LoadDanhSachKhachHang(string tuKhoa = "") { try { if (dtgDanhSachKhachHang.Columns.Count == 0) { KhoiTaoBangDuLieu(); }

using var db = new HotelManagementContext();

var query = db.KhachHangs .AsNoTracking() .Where(k => k.DaXoa != true);

if (!string.IsNullOrWhiteSpace(tuKhoa)) { query = query.Where(k => k.MaKh.Contains(tuKhoa) || k.TenKh.Contains(tuKhoa) || k.Sdt.Contains(tuKhoa) || k.CccdPassport.Contains(tuKhoa)); }

var danhSach = query .OrderBy(k => k.MaKh) .Select(k => new { k.MaKh, k.TenKh, k.Sdt, k.CccdPassport, k.QuocTich, k.GioiTinh }) .ToList();

Image iconKhachHang = Properties.Resources.KhachHang; Image iconSua = Properties.Resources.edit; Image iconXoa = Properties.Resources.delete;

dtgDanhSachKhachHang.Rows.Clear(); foreach (var kh in danhSach) {

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 147

dtgDanhSachKhachHang.Rows.Add( iconKhachHang, kh.MaKh, kh.TenKh, kh.Sdt, kh.CccdPassport, kh.QuocTich, kh.GioiTinh, iconSua, iconXoa ); }

dtgDanhSachKhachHang.ClearSelection(); } catch (Exception ex) { MessageBox.Show("Lỗi khi load khách hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); } }

private void txtTimKiem_TextChanged(object sender, EventArgs e) { LoadDanhSachKhachHang(txtTimKiem.Text.Trim()); }

private void btnXuatExcel_Click(object sender, EventArgs e) { if (dtgDanhSachKhachHang.Rows.Count == 0) { MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

using SaveFileDialog saveDialog = new SaveFileDialog(); saveDialog.Title = "Xuất danh sách khách hàng"; saveDialog.Filter = "Excel Workbook (*.xlsx)|*.xlsx"; saveDialog.FileName = "DanhSachKhachHang_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".xlsx";

if (saveDialog.ShowDialog() != DialogResult.OK) { return; }

try { string[] tenCot = { "MaKH", "TenKH", "SDT", "CCCD", "QuocTich", "GioiTinh" };

using (XLWorkbook workbook = new XLWorkbook()) { IXLWorksheet worksheet = workbook.Worksheets.Add("Danh sách khách hàng");

for (int j = 0; j < tenCot.Length; j++) { worksheet.Cell(1, j + 1).Value = dtgDanhSachKhachHang.Columns[tenCot[j]].HeaderText; } worksheet.Range(1, 1, 1, tenCot.Length).Style.Font.Bold = true;

for (int i = 0; i < dtgDanhSachKhachHang.Rows.Count; i++) {

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 148

for (int j = 0; j < tenCot.Length; j++) { worksheet.Cell(i + 2, j + 1).Value = dtgDanhSachKhachHang.Rows[i].Cells[tenCot[j]].Value?.ToString() ?? ""; } }

worksheet.Columns().AdjustToContents(); workbook.SaveAs(saveDialog.FileName); }

DialogResult moFile = MessageBox.Show( "Xuất dữ liệu thành công! \ nBạn có muốn mở file vừa xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

if (moFile == DialogResult.Yes) { System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(saveDialog.FileName) { UseShellExecute = true }); } } catch (Exception ex) { MessageBox.Show("Lỗi khi xuất file Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); } }

private void btnThemMoi_Click(object sender, EventArgs e) { using (FormThemKhachHang f = new FormThemKhachHang()) { if (f.ShowDialog() == DialogResult.OK) { LoadDanhSachKhachHang(txtTimKiem.Text.Trim()); } } }

private void dtgDanhSachKhachHang_CellClick(object sender, DataGridViewCellEventArgs e) { if (e.RowIndex < 0 || e.ColumnIndex < 0) { return; }

string tenCot = dtgDanhSachKhachHang.Columns[e.ColumnIndex].Name; if (tenCot != "Sua" && tenCot != "Xoa") { return; }

string maKH = dtgDanhSachKhachHang.Rows[e.RowIndex].Cells["MaKH"].Value?.ToString(); if (string.IsNullOrEmpty(maKH)) { return; }

if (tenCot == "Sua")

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 149

{ using (FormSuaKhachHang f = new FormSuaKhachHang(maKH)) { if (f.ShowDialog() == DialogResult.OK) { LoadDanhSachKhachHang(txtTimKiem.Text.Trim()); } } return; }

if (MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) { return; }

try { using var db = new HotelManagementContext();

var khachHang = db.KhachHangs.FirstOrDefault(k => k.MaKh == maKH); if (khachHang == null) { MessageBox.Show("Không tìm thấy khách hàng cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); } else { khachHang.DaXoa = true; int kq = db.SaveChanges();

if (kq > 0) { MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); } else { MessageBox.Show("Xóa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); } } } catch (Exception ex) { MessageBox.Show("Lỗi khi xóa khách hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }

LoadDanhSachKhachHang(txtTimKiem.Text.Trim()); } } }

### Bước 5: Chỉnh sửa lại hàm private void button6_Click(object sender,

### EventArgs e)trong file FormMain.cs theo nội dung như sau:

private void button6_Click ( object sender, EventArgs e) { Form formCon = new KhachHang. FormDanhSachKhachHang (); formCon.TopLevel = false; formCon.FormBorderStyle = FormBorderStyle.None; formCon.Dock = DockStyle.Fill; XoaNoiDungPanelMain ();

Lập trình trực quan

Ths. Nguyễn Thiện Dương Trang 150

panelMain.Controls. Add( formCon); formCon. Show(); }

Bước 6: Click chuột phải vào folder KhachHang → Add → Forms( Windows Forms)

→ tạo một form để xây dựng giao diện và chức năng thêm mới thông tin 1 khách hàng

trong khách sạn là FormThemKhachHang.cs

Bước 7: Thiết kế giao diện FormThemKhachHang.cs theo mẫu như sau:

Mã nguồn tham khảo trong file FormThemKhachHang.Designer.cs tạm thời như sau: namespace HotelManagement.KhachHang { partial class FormThemKhachHang { /// <summary> /// Required designer variable. /// </summary> private System.ComponentModel.IContainer components = null;

/// <summary> /// Clean up any resources being used. /// </summary> /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param> protected override void Dispose(bool disposing) { if (disposing && (components != null)) { components.Dispose(); } base.Dispose(disposing); }

#region Windows Form Designer generated code

/// <summary> /// Required method for Designer support - do not modify /// the contents of this method with the code editor. /// </summary> private void InitializeComponent()

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 151

{ label6 = new Label(); btnThoat = new Button(); btnThemMoi = new Button(); panel1 = new Panel(); txtMaKH = new TextBox(); label4 = new Label(); cbGioiTinh = new ComboBox(); label7 = new Label(); txtSoDienThoai = new TextBox(); label3 = new Label(); txtQuocTich = new TextBox(); label2 = new Label(); txtCCCD = new TextBox(); label1 = new Label(); txtHoVaTen = new TextBox(); label5 = new Label(); panel1.SuspendLayout(); SuspendLayout(); // // label6 // label6.AutoSize = true; label6.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 0); label6.ForeColor = Color.FromArgb(192, 0, 0); label6.Location = new Point(152, 36); label6.Name = "label6"; label6.Size = new Size(345, 29); label6.TabIndex = 21; label6.Text = "Thêm thông tin khách hàng"; // // btnThoat // btnThoat.BackColor = SystemColors.GradientActiveCaption; btnThoat.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); btnThoat.Location = new Point(317, 536); btnThoat.Margin = new Padding(3, 4, 3, 4); btnThoat.Name = "btnThoat"; btnThoat.Size = new Size(137, 59); btnThoat.TabIndex = 20; btnThoat.Text = "Thoát"; btnThoat.UseVisualStyleBackColor = false; // // btnThemMoi // btnThemMoi.BackColor = Color.Moccasin; btnThemMoi.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); btnThemMoi.Location = new Point(117, 536); btnThemMoi.Margin = new Padding(3, 4, 3, 4); btnThemMoi.Name = "btnThemMoi"; btnThemMoi.Size = new Size(137, 59); btnThemMoi.TabIndex = 19; btnThemMoi.Text = "Thêm mới"; btnThemMoi.UseVisualStyleBackColor = false; btnThemMoi.Click += btnThemMoi_Click; // // panel1 // panel1.Controls.Add(txtMaKH); panel1.Controls.Add(label4); panel1.Controls.Add(cbGioiTinh); panel1.Controls.Add(label7); panel1.Controls.Add(txtSoDienThoai);

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 152

panel1.Controls.Add(label3); panel1.Controls.Add(txtQuocTich); panel1.Controls.Add(label2); panel1.Controls.Add(txtCCCD); panel1.Controls.Add(label1); panel1.Controls.Add(txtHoVaTen); panel1.Controls.Add(label5); panel1.Location = new Point(12, 102); panel1.Margin = new Padding(3, 4, 3, 4); panel1.Name = "panel1"; panel1.Size = new Size(548, 426); panel1.TabIndex = 18; // // txtMaKH // txtMaKH.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); txtMaKH.Location = new Point(243, 30); txtMaKH.Margin = new Padding(3, 4, 3, 4); txtMaKH.Name = "txtMaKH"; txtMaKH.ReadOnly = true; txtMaKH.Size = new Size(290, 30); txtMaKH.TabIndex = 27; // // label4 // label4.AutoSize = true; label4.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0); label4.Location = new Point(104, 32); label4.Name = "label4"; label4.Size = new Size(79, 26); label4.TabIndex = 26; label4.Text = "Mã KH"; // // cbGioiTinh // cbGioiTinh.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0); cbGioiTinh.FormattingEnabled = true; cbGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" }); cbGioiTinh.Location = new Point(243, 348); cbGioiTinh.Margin = new Padding(3, 4, 3, 4); cbGioiTinh.Name = "cbGioiTinh"; cbGioiTinh.Size = new Size(290, 30); cbGioiTinh.TabIndex = 25; // // label7 // label7.AutoSize = true; label7.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0); label7.Location = new Point(83, 226); label7.Name = "label7"; label7.Size = new Size(139, 26); label7.TabIndex = 24; label7.Text = "Số điện thoại"; // // txtSoDienThoai // txtSoDienThoai.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); txtSoDienThoai.Location = new Point(243, 221); txtSoDienThoai.Margin = new Padding(3, 4, 3, 4); txtSoDienThoai.Name = "txtSoDienThoai"; txtSoDienThoai.Size = new Size(290, 30);

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 153

txtSoDienThoai.TabIndex = 23; // // label3 // label3.AutoSize = true; label3.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0); label3.Location = new Point(130, 352); label3.Name = "label3"; label3.Size = new Size(92, 26); label3.TabIndex = 22; label3.Text = "Giới tính"; // // txtQuocTich // txtQuocTich.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); txtQuocTich.Location = new Point(243, 288); txtQuocTich.Margin = new Padding(3, 4, 3, 4); txtQuocTich.Name = "txtQuocTich"; txtQuocTich.Size = new Size(290, 30); txtQuocTich.TabIndex = 21; // // label2 // label2.AutoSize = true; label2.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0); label2.Location = new Point(124, 288); label2.Name = "label2"; label2.Size = new Size(104, 26); label2.TabIndex = 20; label2.Text = "Quốc tịch"; // // txtCCCD // txtCCCD.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); txtCCCD.Location = new Point(243, 156); txtCCCD.Margin = new Padding(3, 4, 3, 4); txtCCCD.Name = "txtCCCD"; txtCCCD.Size = new Size(290, 30); txtCCCD.TabIndex = 19; // // label1 // label1.AutoSize = true; label1.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0); label1.Location = new Point(14, 159); label1.Name = "label1"; label1.Size = new Size(201, 26); label1.TabIndex = 18; label1.Text = "Số CCCD/Passport"; // // txtHoVaTen // txtHoVaTen.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); txtHoVaTen.Location = new Point(243, 96); txtHoVaTen.Margin = new Padding(3, 4, 3, 4); txtHoVaTen.Name = "txtHoVaTen"; txtHoVaTen.Size = new Size(290, 30); txtHoVaTen.TabIndex = 17; // // label5

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 154

// label5.AutoSize = true; label5.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0); label5.Location = new Point(104, 99); label5.Name = "label5"; label5.Size = new Size(105, 26); label5.TabIndex = 16; label5.Text = "Họ và tên"; // // FormThemKhachHang // AutoScaleDimensions = new SizeF(8F, 20F); AutoScaleMode = AutoScaleMode.Font; ClientSize = new Size(608, 645); Controls.Add(label6); Controls.Add(btnThoat); Controls.Add(btnThemMoi); Controls.Add(panel1); Margin = new Padding(3, 4, 3, 4); Name = "FormThemKhachHang"; Text = "FormThemKhachHang"; Load += FormThemKhachHang_Load; panel1.ResumeLayout(false); panel1.PerformLayout(); ResumeLayout(false); PerformLayout();

}

#endregion

private System.Windows.Forms.Label label6; private System.Windows.Forms.Button btnThoat; private System.Windows.Forms.Button btnThemMoi; private System.Windows.Forms.Panel panel1; private System.Windows.Forms.ComboBox cbGioiTinh; private System.Windows.Forms.Label label7; private System.Windows.Forms.TextBox txtSoDienThoai; private System.Windows.Forms.Label label3; private System.Windows.Forms.TextBox txtQuocTich; private System.Windows.Forms.Label label2; private System.Windows.Forms.TextBox txtCCCD; private System.Windows.Forms.Label label1; private System.Windows.Forms.TextBox txtHoVaTen; private System.Windows.Forms.Label label5; private System.Windows.Forms.TextBox txtMaKH; private System.Windows.Forms.Label label4; } }

### Bước 8: SV sử dụng mã nguồn tạm thời sau để xử lý chức năng trong file

### FormThemKhachHang.cs

using System; using System.Collections.Generic; using System.ComponentModel; using System.Data; using System.Drawing; using System.Text; using System.Windows.Forms; using HotelManagement.Models; using Microsoft.EntityFrameworkCore;

namespace HotelManagement.KhachHang

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 155

{ public partial class FormThemKhachHang: Form { public FormThemKhachHang () { InitializeComponent(); btnThoat.DialogResult = DialogResult.Cancel; }

private string GenerateMaKH () { using var db = new HotelManagementContext();

var danhSachMa = db.KhachHangs .AsNoTracking() .Select( k => k.MaKh) .ToList();

int max = 0; foreach ( string ma in danhSachMa) { if ( ma!= null && ma.Length > 2 && int. TryParse ( ma. Substring (2), out int so) && so > max) { max = so; } }

return "KH" + ( max + 1). ToString ( "D3"); }

private void FormThemKhachHang_Load ( object sender, EventArgs e) { txtHoVaTen.MaxLength = 50; txtCCCD.MaxLength = 12; txtSoDienThoai.MaxLength = 10; txtQuocTich.MaxLength = 30; cbGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList; txtSoDienThoai.KeyPress += OnlyAllowDigits;

try { txtMaKH.Text = GenerateMaKH (); } catch ( Exception ex) { MessageBox. Show( "Lỗi khi tạo mã khách hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }

cbGioiTinh.SelectedIndex = 0; }

private void OnlyAllowDigits ( object sender, KeyPressEventArgs e) { if (! char. IsControl ( e.KeyChar) && ! char. IsDigit ( e.KeyChar)) { e.Handled = true; } }

private void btnThemMoi_Click ( object sender, EventArgs e) { string maKH = txtMaKH.Text. Trim (); string tenKH = txtHoVaTen.Text. Trim (); string sdt = txtSoDienThoai.Text. Trim ();

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 156

string cccd = txtCCCD.Text. Trim (); string quocTich = txtQuocTich.Text. Trim (); string gioiTinh = cbGioiTinh.Text. Trim ();

if ( string. IsNullOrEmpty ( maKH)) { MessageBox. Show( "Chưa có mã khách hàng, vui lòng mở lại form!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

if ( string. IsNullOrEmpty ( tenKH)) { MessageBox. Show( "Vui lòng nhập họ và tên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtHoVaTen. Focus (); return; }

if ( string. IsNullOrEmpty ( cccd)) { MessageBox. Show( "Vui lòng nhập số CCCD/Passport!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtCCCD. Focus (); return; }

if ( string. IsNullOrEmpty ( quocTich)) { MessageBox. Show( "Vui lòng nhập quốc tịch!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtQuocTich. Focus (); return; }

if ( string. IsNullOrEmpty ( gioiTinh)) { MessageBox. Show( "Vui lòng chọn giới tính!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); cbGioiTinh. Focus (); return; }

try { using var db = new HotelManagementContext ();

if ( db.KhachHangs. Any ( k => k.CccdPassport == cccd)) { MessageBox. Show( "Số CCCD/Passport đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtCCCD. Focus (); return; }

if ( db.KhachHangs. Any ( k => k.MaKh == maKH)) { maKH = GenerateMaKH (); txtMaKH.Text = maKH; }

var khachHang = new Models. KhachHang { MaKh = maKH, TenKh = tenKH, Sdt = string. IsNullOrEmpty ( sdt) ? null: sdt,

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 157

CccdPassport = cccd, QuocTich = quocTich, GioiTinh = gioiTinh, DaXoa = false };

db.KhachHangs. Add( khachHang); int kq = db. SaveChanges ();

if ( kq > 0) { MessageBox. Show( "Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); DialogResult = DialogResult.OK; Close (); } else { MessageBox. Show( "Thêm khách hàng thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); } } catch ( Exception ex) { MessageBox. Show( "Lỗi khi thêm khách hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); } } } }

### Bước 11: Click chuột phải vào folder KhachHang → Add → Forms( Windows Forms)

### → tạo một form để xây dựng giao diện và chức năng cập nhật thông tin 1 khách hàng

### đang có là FormSuaKhachHang.cs

### Bước 12: Thiết kế giao diện FormSuaKhachHang.cs theo mẫu như sau:

### Mã nguồn tham khảo trong file FormSuaKhachHang.Designer.cs tạm thời như sau:

namespace HotelManagement.KhachHang { partial class FormSuaKhachHang {

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 158

/// <summary> /// Required designer variable. /// </summary> private System.ComponentModel.IContainer components = null;

/// <summary> /// Clean up any resources being used. /// </summary> /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param> protected override void Dispose(bool disposing) { if (disposing && (components != null)) { components.Dispose(); } base.Dispose(disposing); }

#region Windows Form Designer generated code

/// <summary> /// Required method for Designer support - do not modify /// the contents of this method with the code editor. /// </summary> private void InitializeComponent() { label6 = new Label(); btnThoat = new Button(); btnCapNhat = new Button(); panel1 = new Panel(); txtMaKH = new TextBox(); label4 = new Label(); cbGioiTinh = new ComboBox(); label7 = new Label(); txtSoDienThoai = new TextBox(); label3 = new Label(); txtQuocTich = new TextBox(); label2 = new Label(); txtCCCD = new TextBox(); label1 = new Label(); txtHoVaTen = new TextBox(); label5 = new Label(); panel1.SuspendLayout(); SuspendLayout(); // // label6 // label6.AutoSize = true; label6.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 0); label6.ForeColor = Color.FromArgb(192, 0, 0); label6.Location = new Point(144, 31); label6.Name = "label6"; label6.Size = new Size(386, 29); label6.TabIndex = 25; label6.Text = "Cập nhật thông tin khách hàng"; // // btnThoat // btnThoat.BackColor = SystemColors.GradientActiveCaption; btnThoat.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); btnThoat.Location = new Point(345, 531); btnThoat.Margin = new Padding(3, 4, 3, 4); btnThoat.Name = "btnThoat";

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 159

btnThoat.Size = new Size(137, 59); btnThoat.TabIndex = 24; btnThoat.Text = "Thoát"; btnThoat.UseVisualStyleBackColor = false; btnThoat.Click += btnThoat_Click; // // btnCapNhat // btnCapNhat.BackColor = Color.Moccasin; btnCapNhat.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); btnCapNhat.Location = new Point(145, 531); btnCapNhat.Margin = new Padding(3, 4, 3, 4); btnCapNhat.Name = "btnCapNhat"; btnCapNhat.Size = new Size(137, 59); btnCapNhat.TabIndex = 23; btnCapNhat.Text = "Cập nhật"; btnCapNhat.UseVisualStyleBackColor = false; btnCapNhat.Click += btnCapNhat_Click; // // panel1 // panel1.Controls.Add(txtMaKH); panel1.Controls.Add(label4); panel1.Controls.Add(cbGioiTinh); panel1.Controls.Add(label7); panel1.Controls.Add(txtSoDienThoai); panel1.Controls.Add(label3); panel1.Controls.Add(txtQuocTich); panel1.Controls.Add(label2); panel1.Controls.Add(txtCCCD); panel1.Controls.Add(label1); panel1.Controls.Add(txtHoVaTen); panel1.Controls.Add(label5); panel1.Location = new Point(40, 98); panel1.Margin = new Padding(3, 4, 3, 4); panel1.Name = "panel1"; panel1.Size = new Size(548, 426); panel1.TabIndex = 22; // // txtMaKH // txtMaKH.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); txtMaKH.Location = new Point(243, 30); txtMaKH.Margin = new Padding(3, 4, 3, 4); txtMaKH.Name = "txtMaKH"; txtMaKH.ReadOnly = true; txtMaKH.Size = new Size(290, 30); txtMaKH.TabIndex = 27; // // label4 // label4.AutoSize = true; label4.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0); label4.Location = new Point(104, 32); label4.Name = "label4"; label4.Size = new Size(79, 26); label4.TabIndex = 26; label4.Text = "Mã KH"; // // cbGioiTinh // cbGioiTinh.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 160

cbGioiTinh.FormattingEnabled = true; cbGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" }); cbGioiTinh.Location = new Point(243, 348); cbGioiTinh.Margin = new Padding(3, 4, 3, 4); cbGioiTinh.Name = "cbGioiTinh"; cbGioiTinh.Size = new Size(290, 30); cbGioiTinh.TabIndex = 25; // // label7 // label7.AutoSize = true; label7.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0); label7.Location = new Point(83, 226); label7.Name = "label7"; label7.Size = new Size(139, 26); label7.TabIndex = 24; label7.Text = "Số điện thoại"; // // txtSoDienThoai // txtSoDienThoai.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); txtSoDienThoai.Location = new Point(243, 221); txtSoDienThoai.Margin = new Padding(3, 4, 3, 4); txtSoDienThoai.Name = "txtSoDienThoai"; txtSoDienThoai.Size = new Size(290, 30); txtSoDienThoai.TabIndex = 23; // // label3 // label3.AutoSize = true; label3.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0); label3.Location = new Point(130, 352); label3.Name = "label3"; label3.Size = new Size(92, 26); label3.TabIndex = 22; label3.Text = "Giới tính"; // // txtQuocTich // txtQuocTich.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); txtQuocTich.Location = new Point(243, 288); txtQuocTich.Margin = new Padding(3, 4, 3, 4); txtQuocTich.Name = "txtQuocTich"; txtQuocTich.Size = new Size(290, 30); txtQuocTich.TabIndex = 21; // // label2 // label2.AutoSize = true; label2.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0); label2.Location = new Point(124, 288); label2.Name = "label2"; label2.Size = new Size(104, 26); label2.TabIndex = 20; label2.Text = "Quốc tịch"; // // txtCCCD // txtCCCD.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); txtCCCD.Location = new Point(243, 156);

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 161

txtCCCD.Margin = new Padding(3, 4, 3, 4); txtCCCD.Name = "txtCCCD"; txtCCCD.Size = new Size(290, 30); txtCCCD.TabIndex = 19; // // label1 // label1.AutoSize = true; label1.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0); label1.Location = new Point(14, 159); label1.Name = "label1"; label1.Size = new Size(201, 26); label1.TabIndex = 18; label1.Text = "Số CCCD/Passport"; // // txtHoVaTen // txtHoVaTen.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); txtHoVaTen.Location = new Point(243, 96); txtHoVaTen.Margin = new Padding(3, 4, 3, 4); txtHoVaTen.Name = "txtHoVaTen"; txtHoVaTen.Size = new Size(290, 30); txtHoVaTen.TabIndex = 17; // // label5 // label5.AutoSize = true; label5.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0); label5.Location = new Point(104, 99); label5.Name = "label5"; label5.Size = new Size(105, 26); label5.TabIndex = 16; label5.Text = "Họ và tên"; // // FormSuaKhachHang // AutoScaleDimensions = new SizeF(8F, 20F); AutoScaleMode = AutoScaleMode.Font; ClientSize = new Size(628, 620); Controls.Add(label6); Controls.Add(btnThoat); Controls.Add(btnCapNhat); Controls.Add(panel1); Margin = new Padding(3, 4, 3, 4); Name = "FormSuaKhachHang"; Text = "FormSuaKhachHang"; Load += FormSuaKhachHang_Load; panel1.ResumeLayout(false); panel1.PerformLayout(); ResumeLayout(false); PerformLayout();

}

#endregion

private System.Windows.Forms.Label label6; private System.Windows.Forms.Button btnThoat; private System.Windows.Forms.Button btnCapNhat; private System.Windows.Forms.Panel panel1; private System.Windows.Forms.TextBox txtMaKH; private System.Windows.Forms.Label label4; private System.Windows.Forms.ComboBox cbGioiTinh;

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 162

private System.Windows.Forms.Label label7; private System.Windows.Forms.TextBox txtSoDienThoai; private System.Windows.Forms.Label label3; private System.Windows.Forms.TextBox txtQuocTich; private System.Windows.Forms.Label label2; private System.Windows.Forms.TextBox txtCCCD; private System.Windows.Forms.Label label1; private System.Windows.Forms.TextBox txtHoVaTen; private System.Windows.Forms.Label label5; } }

### Bước 8: SV sử dụng mã nguồn tạm thời sau để xử lý chức năng trong file

### FormSuaKhachHang.cs

using System; using System.Collections.Generic; using System.ComponentModel; using System.Data; using System.Drawing; using System.Text; using System.Windows.Forms; using HotelManagement.Models;

namespace HotelManagement.KhachHang { public partial class FormSuaKhachHang: Form { private string maKH = string.Empty;

public FormSuaKhachHang () { InitializeComponent (); }

public FormSuaKhachHang ( string maKH) : this () { this.maKH = maKH; }

private void FormSuaKhachHang_Load ( object sender, EventArgs e) { txtHoVaTen.MaxLength = 50; txtCCCD.MaxLength = 12; txtSoDienThoai.MaxLength = 10; txtQuocTich.MaxLength = 30; cbGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList; txtSoDienThoai.KeyPress += OnlyAllowDigits;

if ( string. IsNullOrEmpty (maKH)) { MessageBox. Show( "Không xác định được khách hàng cần cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); DialogResult = DialogResult.Cancel; Close (); return; }

try { using var db = new HotelManagementContext ();

var khachHang = db.KhachHangs . Where( k => k.MaKh == maKH && k.DaXoa != true) . Select ( k => new

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 163

{ k.MaKh, k.TenKh, k.Sdt, k.CccdPassport, k.QuocTich, k.GioiTinh }) . FirstOrDefault ();

if ( khachHang == null) { MessageBox. Show( "Không tìm thấy khách hàng cần cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); DialogResult = DialogResult.Cancel; Close (); return; }

txtMaKH.Text = khachHang.MaKh; txtHoVaTen.Text = khachHang.TenKh; txtSoDienThoai.Text = khachHang.Sdt ?? ""; txtCCCD.Text = khachHang.CccdPassport; txtQuocTich.Text = khachHang.QuocTich;

int viTri = cbGioiTinh. FindStringExact ( khachHang.GioiTinh); cbGioiTinh.SelectedIndex = viTri >= 0 ? viTri: 0; } catch ( Exception ex) { MessageBox. Show( "Lỗi khi load khách hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); DialogResult = DialogResult.Cancel; Close (); } }

private void btnCapNhat_Click ( object sender, EventArgs e) { string tenKH = txtHoVaTen.Text. Trim (); string sdt = txtSoDienThoai.Text. Trim (); string cccd = txtCCCD.Text. Trim (); string quocTich = txtQuocTich.Text. Trim (); string gioiTinh = cbGioiTinh.Text. Trim ();

if ( string. IsNullOrEmpty ( tenKH)) { MessageBox. Show( "Vui lòng nhập họ và tên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtHoVaTen. Focus (); return; }

if ( string. IsNullOrEmpty ( cccd)) { MessageBox. Show( "Vui lòng nhập số CCCD/Passport!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtCCCD. Focus (); return; }

if ( string. IsNullOrEmpty ( quocTich)) { MessageBox. Show( "Vui lòng nhập quốc tịch!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtQuocTich. Focus ();

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 164

return; }

if ( string. IsNullOrEmpty ( gioiTinh)) { MessageBox. Show( "Vui lòng chọn giới tính!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); cbGioiTinh. Focus (); return; }

try { using var db = new HotelManagementContext ();

var khachHang = db.KhachHangs. FirstOrDefault ( k => k.MaKh == maKH && k.DaXoa != true); if ( khachHang == null) { MessageBox. Show( "Không tìm thấy khách hàng cần cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); DialogResult = DialogResult.Cancel; Close (); return; }

if ( db.KhachHangs. Any ( k => k.MaKh != maKH && k.CccdPassport == cccd)) { MessageBox. Show( "Số CCCD/Passport đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtCCCD. Focus (); return; }

khachHang.TenKh = tenKH; khachHang.Sdt = string. IsNullOrEmpty ( sdt) ? null: sdt; khachHang.CccdPassport = cccd; khachHang.QuocTich = quocTich; khachHang.GioiTinh = gioiTinh;

int kq = db. SaveChanges ();

if ( kq > 0) { MessageBox. Show( "Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); DialogResult = DialogResult.OK; Close (); } else { MessageBox. Show( "Không có thay đổi nào để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); } } catch ( Exception ex) { MessageBox. Show( "Lỗi khi cập nhật khách hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); } }

private void btnThoat_Click ( object sender, EventArgs e) { DialogResult = DialogResult.Cancel; Close ();

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 165

}

private void OnlyAllowDigits ( object sender, KeyPressEventArgs e) { if (! char. IsControl ( e.KeyChar) && ! char. IsDigit ( e.KeyChar)) { e.Handled = true; } } } }

### 4. Xây dựng giao diện và chức năng quản lý thông tin nhân viên tại khách sạn

### Bước 1: Click chuột phải vào thư mục project → Add → New Folder→ Đặt tên folder

### là “NhanVien”

### Bước 2: Click chuột phải vào folder NhanVien → Add → Forms( Windows Forms) →

### tạo một form thể hiện danh sách các nhân viên đang có trong khách sạn là

### FormDanhSachNhanVien.cs

### Bước 3: Thiết kế giao diện FormDanhSachNhanVien.cs theo mẫu như sau:

### Mã nguồn tham khảo trong file FormDanhSachNhanVien.Designer.cs tạm thời như

### sau:

namespace HotelManagement.NhanVien { partial class FormDanhSachNhanVien { /// <summary> /// Required designer variable. /// </summary> private System.ComponentModel. IContainer components = null;

/// <summary> /// Clean up any resources being used. /// </summary> /// <param name=" disposing "> true if managed resources should be disposed; otherwise, false. </param> protected override void Dispose ( bool disposing) { if ( disposing && (components != null)) { components. Dispose (); } base. Dispose ( disposing); }

#region Windows Form Designer generated code

/// <summary>

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 166

/// Required method for Designer support - do not modify /// the contents of this method with the code editor. /// </summary> private void InitializeComponent () { btnThemMoi = new Button (); dtgDanhSachNhanVien = new DataGridView (); btnXuatExcel = new Button (); txtTimKiem = new TextBox (); pictureBox1 = new PictureBox ();

((System.ComponentModel. ISupportInitialize)dtgDanhSachNhanVien). BeginInit (); ((System.ComponentModel. ISupportInitialize)pictureBox1). BeginInit (); SuspendLayout (); // // btnThemMoi // btnThemMoi.BackColor = Color.LightPink; btnThemMoi.Font = new Font ( "Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0); btnThemMoi.Location = new Point (692, 31); btnThemMoi.Margin = new Padding (3, 4, 3, 4); btnThemMoi.Name = "btnThemMoi"; btnThemMoi.Size = new Size (167, 46); btnThemMoi.TabIndex = 25; btnThemMoi.Text = "Thêm mới"; btnThemMoi.UseVisualStyleBackColor = false; // // dtgDanhSachNhanVien // dtgDanhSachNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize; dtgDanhSachNhanVien.Location = new Point (31, 94); dtgDanhSachNhanVien.Margin = new Padding (3, 4, 3, 4); dtgDanhSachNhanVien.Name = "dtgDanhSachNhanVien"; dtgDanhSachNhanVien.RowHeadersWidth = 51; dtgDanhSachNhanVien.RowTemplate.Height = 24; dtgDanhSachNhanVien.Size = new Size (945, 679); dtgDanhSachNhanVien.TabIndex = 24; dtgDanhSachNhanVien.CellClick += dtgDanhSachNhanVien_CellClick; // // btnXuatExcel // btnXuatExcel.BackColor = Color.DarkTurquoise; btnXuatExcel.Font = new Font ( "Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0); btnXuatExcel.Location = new Point (494, 31); btnXuatExcel.Margin = new Padding (3, 4, 3, 4); btnXuatExcel.Name = "btnXuatExcel"; btnXuatExcel.Size = new Size (167, 46); btnXuatExcel.TabIndex = 23; btnXuatExcel.Text = "Xuất file Excel"; btnXuatExcel.UseVisualStyleBackColor = false; btnXuatExcel.Click += btnXuatExcel_Click; // // txtTimKiem // txtTimKiem.Font = new Font ( "Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0); txtTimKiem.Location = new Point (92, 38); txtTimKiem.Margin = new Padding (3, 4, 3, 4); txtTimKiem.Name = "txtTimKiem"; txtTimKiem.Size = new Size (187, 32); txtTimKiem.TabIndex = 21; txtTimKiem.TextChanged += txtTimKiem_TextChanged; //

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 167

// pictureBox1 // pictureBox1.Image = Properties. Resources.search; pictureBox1.Location = new Point (47, 31); pictureBox1.Margin = new Padding (3, 4, 3, 4); pictureBox1.Name = "pictureBox1"; pictureBox1.Size = new Size (39, 46); pictureBox1.TabIndex = 22; pictureBox1.TabStop = false; // // FormDanhSachNhanVien // AutoScaleDimensions = new SizeF (8F, 20F); AutoScaleMode = AutoScaleMode.Font; ClientSize = new Size (989, 806); Controls. Add(btnThemMoi); Controls. Add(dtgDanhSachNhanVien); Controls. Add(btnXuatExcel); Controls. Add(pictureBox1); Controls. Add(txtTimKiem); Margin = new Padding (3, 4, 3, 4); Name = "FormDanhSachNhanVien"; StartPosition = FormStartPosition.CenterScreen; Text = "FormDanhSachNhanVien"; Load += FormDanhSachNhanVien_Load; ((System.ComponentModel. ISupportInitialize)dtgDanhSachNhanVien). EndInit (); ((System.ComponentModel. ISupportInitialize)pictureBox1). EndInit (); ResumeLayout ( false); PerformLayout ();

}

#endregion

private System.Windows.Forms. Button btnThemMoi; private System.Windows.Forms. DataGridView dtgDanhSachNhanVien; private System.Windows.Forms. Button btnXuatExcel; private System.Windows.Forms. PictureBox pictureBox1; private System.Windows.Forms. TextBox txtTimKiem; } }

### Bước 4: SV sử dụng mã nguồn tạm thời sau để xử lý chức năng trong file

### FormDanhSachNhanVien.cs

using System; using System.Collections.Generic; using System.ComponentModel; using System.Data; using System.Drawing; using System.Text; using System.Windows.Forms; using ClosedXML.Excel; using HotelManagement.Models; using Microsoft.EntityFrameworkCore;

namespace HotelManagement.NhanVien { public partial class FormDanhSachNhanVien : Form { public FormDanhSachNhanVien() { InitializeComponent(); }

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 168

private void FormDanhSachNhanVien_Load(object sender, EventArgs e) { btnThemMoi.Click += btnThemMoi_Click; LoadDanhSachNhanVien(); }

private void KhoiTaoBangDuLieu() { dtgDanhSachNhanVien.AllowUserToAddRows = false; dtgDanhSachNhanVien.AllowUserToDeleteRows = false; dtgDanhSachNhanVien.AllowUserToResizeRows = false; dtgDanhSachNhanVien.ReadOnly = true; dtgDanhSachNhanVien.MultiSelect = false; dtgDanhSachNhanVien.RowHeadersVisible = false; dtgDanhSachNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect; dtgDanhSachNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; dtgDanhSachNhanVien.RowTemplate.Height = 40;

DataGridViewImageColumn iconCol = new DataGridViewImageColumn(); iconCol.Name = "Icon"; iconCol.HeaderText = ""; iconCol.ImageLayout = DataGridViewImageCellLayout.Zoom; iconCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.None; iconCol.Width = 40; dtgDanhSachNhanVien.Columns.Add(iconCol);

dtgDanhSachNhanVien.Columns.Add("MaNV", "Mã NV"); dtgDanhSachNhanVien.Columns.Add("TenNV", "Tên nhân viên"); dtgDanhSachNhanVien.Columns.Add("ChucVu", "Chức vụ"); dtgDanhSachNhanVien.Columns.Add("Luong", "Lương"); dtgDanhSachNhanVien.Columns.Add("SDT", "Số điện thoại"); dtgDanhSachNhanVien.Columns.Add("Email", "Email"); dtgDanhSachNhanVien.Columns.Add("DiaChi", "Địa chỉ");

dtgDanhSachNhanVien.Columns["MaNV"].FillWeight = 8; dtgDanhSachNhanVien.Columns["TenNV"].FillWeight = 17; dtgDanhSachNhanVien.Columns["ChucVu"].FillWeight = 12; dtgDanhSachNhanVien.Columns["Luong"].FillWeight = 13; dtgDanhSachNhanVien.Columns["SDT"].FillWeight = 12; dtgDanhSachNhanVien.Columns["Email"].FillWeight = 19; dtgDanhSachNhanVien.Columns["DiaChi"].FillWeight = 25; dtgDanhSachNhanVien.Columns["Luong"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

DataGridViewImageColumn suaCol = new DataGridViewImageColumn(); suaCol.Name = "Sua"; suaCol.HeaderText = "Sửa"; suaCol.ImageLayout = DataGridViewImageCellLayout.Zoom; suaCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.None; suaCol.Width = 50; dtgDanhSachNhanVien.Columns.Add(suaCol);

DataGridViewImageColumn xoaCol = new DataGridViewImageColumn(); xoaCol.Name = "Xoa"; xoaCol.HeaderText = "Xóa"; xoaCol.ImageLayout = DataGridViewImageCellLayout.Zoom; xoaCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.None; xoaCol.Width = 50; dtgDanhSachNhanVien.Columns.Add(xoaCol); }

private void LoadDanhSachNhanVien(string tuKhoa = "") { try

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 169

{ if (dtgDanhSachNhanVien.Columns.Count == 0) { KhoiTaoBangDuLieu(); }

using var db = new HotelManagementContext();

var query = db.NhanViens .AsNoTracking() .Where(n => n.DaXoa != true);

if (!string.IsNullOrWhiteSpace(tuKhoa)) { query = query.Where(n => n.MaNv.Contains(tuKhoa) || n.TenNv.Contains(tuKhoa) || n.Sdt.Contains(tuKhoa) || n.Cccd.Contains(tuKhoa)); }

var danhSach = query .OrderBy(n => n.MaNv) .Select(n => new { n.MaNv, n.TenNv, n.ChucVu, n.Luong, n.Sdt, n.Email, n.DiaChi }) .ToList();

Image iconNhanVien = Properties.Resources.NhanVien; Image iconSua = Properties.Resources.edit; Image iconXoa = Properties.Resources.delete; System.Globalization.CultureInfo viVN = new System.Globalization.CultureInfo("vi - VN");

dtgDanhSachNhanVien.Rows.Clear(); foreach (var nv in danhSach) { dtgDanhSachNhanVien.Rows.Add( iconNhanVien, nv.MaNv, nv.TenNv, nv.ChucVu, nv.Luong.ToString("C0", viVN), nv.Sdt, nv.Email ?? "", nv.DiaChi, iconSua, iconXoa ); }

dtgDanhSachNhanVien.ClearSelection(); } catch (Exception ex) { MessageBox.Show("Lỗi khi load nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); } }

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 170

private void txtTimKiem_TextChanged(object sender, EventArgs e) { LoadDanhSachNhanVien(txtTimKiem.Text.Trim()); }

private void dtgDanhSachNhanVien_CellClick(object sender, DataGridViewCellEventArgs e) { if (e.RowIndex < 0 || e.ColumnIndex < 0) { return; }

string tenCot = dtgDanhSachNhanVien.Columns[e.ColumnIndex].Name; if (tenCot != "Sua" && tenCot != "Xoa") { return; }

string maNV = dtgDanhSachNhanVien.Rows[e.RowIndex].Cells["MaNV"].Value?.ToString(); if (string.IsNullOrEmpty(maNV)) { return; }

if (tenCot == "Sua") { using (FormSuaNhanVien f = new FormSuaNhanVien(maNV)) { if (f.ShowDialog() == DialogResult.OK) { LoadDanhSachNhanVien(txtTimKiem.Text.Trim()); } } return; }

if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) { XoaNhanVien(maNV); } }

private void XoaNhanVien(string maNV) { try { using var db = new HotelManagementContext();

var nhanVien = db.NhanViens .Include(n => n.TaiKhoans) .FirstOrDefault(n => n.MaNv == maNV);

if (nhanVien == null) { MessageBox.Show("Không tìm thấy nhân viên cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); } else { nhanVien.DaXoa = true; foreach (var taiKhoan in nhanVien.TaiKhoans) {

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 171

taiKhoan.DaXoa = true; }

int kq = db.SaveChanges();

if (kq > 0) { MessageBox.Show("Xóa nhân viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); } else { MessageBox.Show("Xóa nhân viên thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); } } } catch (Exception ex) { MessageBox.Show("Lỗi khi xóa nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }

LoadDanhSachNhanVien(txtTimKiem.Text.Trim()); }

private void btnXuatExcel_Click(object sender, EventArgs e) { if (dtgDanhSachNhanVien.Rows.Count == 0) { MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

using SaveFileDialog saveDialog = new SaveFileDialog(); saveDialog.Title = "Xuất danh sách nhân viên"; saveDialog.Filter = "Excel Workbook (*.xlsx)|*.xlsx"; saveDialog.FileName = "DanhSachNhanVien_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".xlsx";

if (saveDialog.ShowDialog() != DialogResult.OK) { return; }

try { string[] tenCot = { "MaNV", "TenNV", "ChucVu", "Luong", "SDT", "Email", "DiaChi" };

using (XLWorkbook workbook = new XLWorkbook()) { IXLWorksheet worksheet = workbook.Worksheets.Add("Danh sách nhân viên");

for (int j = 0; j < tenCot.Length; j++) { worksheet.Cell(1, j + 1).Value = dtgDanhSachNhanVien.Columns[tenCot[j]].HeaderText; } worksheet.Range(1, 1, 1, tenCot.Length).Style.Font.Bold = true;

for (int i = 0; i < dtgDanhSachNhanVien.Rows.Count; i++) { for (int j = 0; j < tenCot.Length; j++)

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 172

{ worksheet.Cell(i + 2, j + 1).Value = dtgDanhSachNhanVien.Rows[i].Cells[tenCot[j]].Value?.ToString() ?? ""; } }

worksheet.Columns().AdjustToContents(); workbook.SaveAs(saveDialog.FileName); }

DialogResult moFile = MessageBox.Show( "Xuất dữ liệu thành công! \ nBạn có muốn mở file vừa xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

if (moFile == DialogResult.Yes) { System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(saveDialog.FileName) { UseShellExecute = true }); } } catch (Exception ex) { MessageBox.Show("Lỗi khi xuất file Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); } }

private void btnThemMoi_Click(object sender, EventArgs e) { using (FormThemNhanVien f = new FormThemNhanVien()) { if (f.ShowDialog() == DialogResult.OK) { LoadDanhSachNhanVien(txtTimKiem.Text.Trim()); } } } } }

### Bước 5: Chỉnh sửa lại hàm private void button7_Click(object sender,

### EventArgs e)trong file FormMain.cs theo nội dung như sau:

private void button7_Click ( object sender, EventArgs e) {

Form formCon = new NhanVien. FormDanhSachNhanVien (); formCon.TopLevel = false; formCon.FormBorderStyle = FormBorderStyle.None; formCon.Dock = DockStyle.Fill; XoaNoiDungPanelMain (); panelMain.Controls. Add( formCon); formCon. Show(); }

### Bước 6: Click chuột phải vào folder NhanVien → Add → Forms( Windows Forms) →

### tạo một form để xây dựng giao diện và chức năng thêm mới thông tin 1 nhân viên trong

### khách sạn là FormThemNhanVien.cs

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 173

### Bước 7: Thiết kế giao diện FormThemNhanVien.cs theo mẫu như sau:

### Mã nguồn tham khảo trong file FormThemNhanVien.Designer.cs tạm thời như sau:

namespace HotelManagement.NhanVien { partial class FormThemNhanVien { /// <summary> /// Required designer variable. /// </summary> private System.ComponentModel.IContainer components = null;

/// <summary> /// Clean up any resources being used. /// </summary> /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param> protected override void Dispose(bool disposing) { if (disposing && (components != null)) { components.Dispose(); } base.Dispose(disposing); }

#region Windows Form Designer generated code

/// <summary> /// Required method for Designer support - do not modify /// the contents of this method with the code editor. /// </summary> private void InitializeComponent() { label6 = new Label(); btnThoat = new Button(); btnThemMoi = new Button(); panel1 = new Panel(); txtMaNV = new TextBox(); label11 = new Label(); cbGioiTinh = new ComboBox(); label10 = new Label(); txtEmail = new TextBox(); label9 = new Label(); txtDiaChi = new TextBox(); label8 = new Label(); txtSoCCCD = new TextBox(); label4 = new Label(); dtNgaySinh = new DateTimePicker();

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 174

txtLuong = new TextBox(); cbChucVu = new ComboBox(); label7 = new Label(); label3 = new Label(); txtSoDT = new TextBox(); label2 = new Label(); label1 = new Label(); txtHoTenNV = new TextBox(); label5 = new Label(); panel1.SuspendLayout(); SuspendLayout(); // // label6 // label6.AutoSize = true; label6.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 0); label6.ForeColor = Color.FromArgb(192, 0, 0); label6.Location = new Point(400, 31); label6.Name = "label6"; label6.Size = new Size(323, 29); label6.TabIndex = 21; label6.Text = "Thêm thông tin nhân viên"; // // btnThoat // btnThoat.BackColor = SystemColors.GradientActiveCaption; btnThoat.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); btnThoat.Location = new Point(555, 475); btnThoat.Margin = new Padding(3, 4, 3, 4); btnThoat.Name = "btnThoat"; btnThoat.Size = new Size(137, 59); btnThoat.TabIndex = 20; btnThoat.Text = "Thoát"; btnThoat.UseVisualStyleBackColor = false; btnThoat.Click += btnThoat_Click; // // btnThemMoi // btnThemMoi.BackColor = Color.Moccasin; btnThemMoi.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); btnThemMoi.Location = new Point(355, 475); btnThemMoi.Margin = new Padding(3, 4, 3, 4); btnThemMoi.Name = "btnThemMoi"; btnThemMoi.Size = new Size(137, 59); btnThemMoi.TabIndex = 19; btnThemMoi.Text = "Thêm mới"; btnThemMoi.UseVisualStyleBackColor = false; btnThemMoi.Click += btnThemMoi_Click; // // panel1 // panel1.Controls.Add(txtMaNV); panel1.Controls.Add(label11); panel1.Controls.Add(cbGioiTinh); panel1.Controls.Add(label10); panel1.Controls.Add(txtEmail); panel1.Controls.Add(label9); panel1.Controls.Add(txtDiaChi); panel1.Controls.Add(label8); panel1.Controls.Add(txtSoCCCD); panel1.Controls.Add(label4); panel1.Controls.Add(dtNgaySinh); panel1.Controls.Add(txtLuong);

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 175

panel1.Controls.Add(cbChucVu); panel1.Controls.Add(label7); panel1.Controls.Add(label3); panel1.Controls.Add(txtSoDT); panel1.Controls.Add(label2); panel1.Controls.Add(label1); panel1.Controls.Add(txtHoTenNV); panel1.Controls.Add(label5); panel1.Location = new Point(12, 84); panel1.Margin = new Padding(3, 4, 3, 4); panel1.Name = "panel1"; panel1.Size = new Size(1020, 355); panel1.TabIndex = 18; // // txtMaNV // txtMaNV.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); txtMaNV.Location = new Point(696, 289); txtMaNV.Margin = new Padding(3, 4, 3, 4); txtMaNV.Name = "txtMaNV"; txtMaNV.Size = new Size(290, 30); txtMaNV.TabIndex = 38; // // label11 // label11.AutoSize = true; label11.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0); label11.Location = new Point(601, 291); label11.Name = "label11"; label11.Size = new Size(79, 26); label11.TabIndex = 37; label11.Text = "Mã NV"; // // cbGioiTinh // cbGioiTinh.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0); cbGioiTinh.FormattingEnabled = true; cbGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" }); cbGioiTinh.Location = new Point(202, 294); cbGioiTinh.Margin = new Padding(3, 4, 3, 4); cbGioiTinh.Name = "cbGioiTinh"; cbGioiTinh.Size = new Size(290, 30); cbGioiTinh.TabIndex = 36; // // label10 // label10.AutoSize = true; label10.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0); label10.Location = new Point(72, 294); label10.Name = "label10"; label10.Size = new Size(92, 26); label10.TabIndex = 35; label10.Text = "Giới tính"; // // txtEmail // txtEmail.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); txtEmail.Location = new Point(696, 211); txtEmail.Margin = new Padding(3, 4, 3, 4); txtEmail.Name = "txtEmail"; txtEmail.Size = new Size(290, 30);

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 176

txtEmail.TabIndex = 34; // // label9 // label9.AutoSize = true; label9.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0); label9.Location = new Point(612, 214); label9.Name = "label9"; label9.Size = new Size(68, 26); label9.TabIndex = 33; label9.Text = "Email"; // // txtDiaChi // txtDiaChi.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); txtDiaChi.Location = new Point(696, 152); txtDiaChi.Margin = new Padding(3, 4, 3, 4); txtDiaChi.Name = "txtDiaChi"; txtDiaChi.Size = new Size(290, 30); txtDiaChi.TabIndex = 32; // // label8 // label8.AutoSize = true; label8.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0); label8.Location = new Point(601, 152); label8.Name = "label8"; label8.Size = new Size(79, 26); label8.TabIndex = 31; label8.Text = "Địa chỉ"; // // txtSoCCCD // txtSoCCCD.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); txtSoCCCD.Location = new Point(696, 80); txtSoCCCD.Margin = new Padding(3, 4, 3, 4); txtSoCCCD.Name = "txtSoCCCD"; txtSoCCCD.Size = new Size(290, 30); txtSoCCCD.TabIndex = 30; // // label4 // label4.AutoSize = true; label4.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0); label4.Location = new Point(571, 88); label4.Name = "label4"; label4.Size = new Size(109, 26); label4.TabIndex = 29; label4.Text = "Số CCCD"; // // dtNgaySinh // dtNgaySinh.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0); dtNgaySinh.Location = new Point(696, 19); dtNgaySinh.Margin = new Padding(3, 4, 3, 4); dtNgaySinh.Name = "dtNgaySinh"; dtNgaySinh.Size = new Size(290, 28); dtNgaySinh.TabIndex = 28; // // txtLuong

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 177

// txtLuong.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); txtLuong.Location = new Point(202, 150); txtLuong.Margin = new Padding(3, 4, 3, 4); txtLuong.Name = "txtLuong"; txtLuong.Size = new Size(290, 30); txtLuong.TabIndex = 27; // // cbChucVu // cbChucVu.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0); cbChucVu.FormattingEnabled = true; cbChucVu.Items.AddRange(new object[] { "Người quản trị hệ thống", "Quản lý khách sạn", "Nhân viên" }); cbChucVu.Location = new Point(202, 82); cbChucVu.Margin = new Padding(3, 4, 3, 4); cbChucVu.Name = "cbChucVu"; cbChucVu.Size = new Size(290, 30); cbChucVu.TabIndex = 26; // // label7 // label7.AutoSize = true; label7.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0); label7.Location = new Point(89, 152); label7.Name = "label7"; label7.Size = new Size(72, 26); label7.TabIndex = 24; label7.Text = "Lương"; // // label3 // label3.AutoSize = true; label3.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0); label3.Location = new Point(571, 21); label3.Name = "label3"; label3.Size = new Size(109, 26); label3.TabIndex = 22; label3.Text = "Ngày sinh"; // // txtSoDT // txtSoDT.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); txtSoDT.Location = new Point(202, 214); txtSoDT.Margin = new Padding(3, 4, 3, 4); txtSoDT.Name = "txtSoDT"; txtSoDT.Size = new Size(290, 30); txtSoDT.TabIndex = 21; // // label2 // label2.AutoSize = true; label2.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0); label2.Location = new Point(25, 216); label2.Name = "label2"; label2.Size = new Size(139, 26); label2.TabIndex = 20; label2.Text = "Số điện thoại"; // // label1

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 178

// label1.AutoSize = true; label1.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0); label1.Location = new Point(72, 82); label1.Name = "label1"; label1.Size = new Size(92, 26); label1.TabIndex = 18; label1.Text = "Chức vụ"; // // txtHoTenNV // txtHoTenNV.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); txtHoTenNV.Location = new Point(202, 22); txtHoTenNV.Margin = new Padding(3, 4, 3, 4); txtHoTenNV.Name = "txtHoTenNV"; txtHoTenNV.Size = new Size(290, 30); txtHoTenNV.TabIndex = 17; // // label5 // label5.AutoSize = true; label5.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0); label5.Location = new Point(59, 19); label5.Name = "label5"; label5.Size = new Size(105, 26); label5.TabIndex = 16; label5.Text = "Họ và tên"; // // FormThemNhanVien // AutoScaleDimensions = new SizeF(8F, 20F); AutoScaleMode = AutoScaleMode.Font; ClientSize = new Size(1076, 558); Controls.Add(label6); Controls.Add(btnThoat); Controls.Add(btnThemMoi); Controls.Add(panel1); Margin = new Padding(3, 4, 3, 4); Name = "FormThemNhanVien"; Text = "FormThemNhanVien"; Load += FormThemNhanVien_Load; panel1.ResumeLayout(false); panel1.PerformLayout(); ResumeLayout(false); PerformLayout();

}

#endregion

private System.Windows.Forms.Label label6; private System.Windows.Forms.Button btnThoat; private System.Windows.Forms.Button btnThemMoi; private System.Windows.Forms.Panel panel1; private System.Windows.Forms.Label label7; private System.Windows.Forms.Label label3; private System.Windows.Forms.TextBox txtSoDT; private System.Windows.Forms.Label label2; private System.Windows.Forms.Label label1; private System.Windows.Forms.TextBox txtHoTenNV; private System.Windows.Forms.Label label5; private System.Windows.Forms.TextBox txtEmail; private System.Windows.Forms.Label label9;

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 179

private System.Windows.Forms.TextBox txtDiaChi; private System.Windows.Forms.Label label8; private System.Windows.Forms.TextBox txtSoCCCD; private System.Windows.Forms.Label label4; private System.Windows.Forms.DateTimePicker dtNgaySinh; private System.Windows.Forms.TextBox txtLuong; private System.Windows.Forms.ComboBox cbChucVu; private System.Windows.Forms.TextBox txtMaNV; private System.Windows.Forms.Label label11; private System.Windows.Forms.ComboBox cbGioiTinh; private System.Windows.Forms.Label label10; } }

### Bước 8: SV sử dụng mã nguồn tạm thời sau để xử lý chức năng trong file

### FormThemNhanVien.cs

using System; using System.Collections.Generic; using System.ComponentModel; using System.Data; using System.Drawing; using System.Globalization; using System.Text; using System.Text.RegularExpressions; using System.Windows.Forms; using HotelManagement.Models;

namespace HotelManagement.NhanVien { public partial class FormThemNhanVien: Form { public FormThemNhanVien () { InitializeComponent(); }

private void FormThemNhanVien_Load ( object sender, EventArgs e) { txtMaNV.MaxLength = 5; txtHoTenNV.MaxLength = 50; txtLuong.MaxLength = 15; txtSoDT.MaxLength = 10; txtSoCCCD.MaxLength = 12; txtDiaChi.MaxLength = 100; txtEmail.MaxLength = 100;

cbChucVu.DropDownStyle = ComboBoxStyle.DropDownList; cbGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList; cbGioiTinh.SelectedIndex = 0;

dtNgaySinh.Format = DateTimePickerFormat.Short; dtNgaySinh.Value = DateTime.Today.AddYears( - 18);

txtLuong.KeyPress += ChiNhapSo; txtSoDT.KeyPress += ChiNhapSo; txtSoCCCD.KeyPress += ChiNhapSo; }

private void ChiNhapSo ( object sender, KeyPressEventArgs e) { if (! char.IsControl(e.KeyChar) && ! char.IsDigit(e.KeyChar)) { e.Handled = true; }

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 180

}

private bool IsValidEmail ( string email) { return Regex.IsMatch(email, @"^[^@\ s]+@[^@ \ s]+ \.[^@ \ s]+$"); }

private bool ToanChuSo ( string chuoi) { foreach ( char c in chuoi) { if (! char.IsDigit(c)) { return false; } } return true; }

private void btnThemMoi_Click ( object sender, EventArgs e) { string maNV = txtMaNV.Text. Trim (). ToUpper (); string tenNV = txtHoTenNV.Text. Trim (); string chucVu = cbChucVu.SelectedItem?. ToString () ?? ""; string luong = txtLuong.Text. Trim (); string sdt = txtSoDT.Text. Trim (); string cccd = txtSoCCCD.Text. Trim (); DateTime ngaySinh = dtNgaySinh.Value.Date; string gioiTinh = cbGioiTinh.SelectedItem?. ToString () ?? ""; string diaChi = txtDiaChi.Text. Trim (); string email = txtEmail.Text. Trim ();

if ( maNV == "" || tenNV == "" || chucVu == "" || luong == "" || sdt == "" || cccd == "" || diaChi == "" || email == "") { MessageBox. Show( "Vui lòng điền đầy đủ thông tin bắt buộc.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

if (! decimal. TryParse ( luong, NumberStyles.None, CultureInfo.InvariantCulture, out decimal luongSo) || luongSo <= 0) { MessageBox. Show( "Lương phải là số lớn hơn 0.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtLuong. Focus (); return; }

if (! ToanChuSo ( sdt) || sdt.Length < 9) { MessageBox. Show( "Số điện thoại phải gồm 9 đến 10 chữ số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtSoDT. Focus (); return; }

if (! ToanChuSo ( cccd) || cccd.Length != 12) { MessageBox. Show( "Số CCCD phải gồm đúng 12 chữ số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtSoCCCD. Focus (); return; }

if (! IsValidEmail ( email))

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 181

{ MessageBox. Show( "Email không đúng định dạng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtEmail. Focus (); return; }

if ( ngaySinh > DateTime.Today. AddYears ( - 18)) { MessageBox. Show( "Nhân viên phải đủ 18 tuổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); dtNgaySinh. Focus (); return; }

try { using var db = new HotelManagementContext ();

if ( db.NhanViens. Any ( n => n.MaNv == maNV)) { MessageBox. Show( "Mã nhân viên đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtMaNV. Focus (); return; }

if ( db.NhanViens. Any ( n => n.Sdt == sdt)) { MessageBox. Show( "Số điện thoại đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtSoDT. Focus (); return; }

if ( db.NhanViens. Any ( n => n.Cccd == cccd)) { MessageBox. Show( "Số CCCD đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtSoCCCD. Focus (); return; }

if ( db.NhanViens. Any ( n => n.Email == email)) { MessageBox. Show( "Email đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtEmail. Focus (); return; }

var nhanVien = new Models. NhanVien { MaNv = maNV, TenNv = tenNV, ChucVu = chucVu, Luong = luongSo, Sdt = sdt, Cccd = cccd, NgaySinh = DateOnly. FromDateTime ( ngaySinh), GioiTinh = gioiTinh, DiaChi = diaChi, Email = email, DaXoa = false };

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 182

db.NhanViens. Add( nhanVien); int kq = db. SaveChanges ();

if ( kq > 0) { MessageBox. Show( "Thêm nhân viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); DialogResult = DialogResult.OK; Close (); } else { MessageBox. Show( "Thêm nhân viên thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); } } catch ( Exception ex) { MessageBox. Show( "Lỗi khi thêm nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); } }

private void btnThoat_Click ( object sender, EventArgs e) { DialogResult = DialogResult.Cancel; Close (); } } }

### Bước 11: Click chuột phải vào folder NhanVien → Add → Forms( Windows Forms)

### → tạo một form để xây dựng giao diện và chức năng cập nhật thông tin 1 nhân viên

### đang có là FormSuaNhanVien.cs

### Bước 12: Thiết kế giao diện FormSuaNhanVien.cs theo mẫu như sau:

### Mã nguồn tham khảo trong file FormSuaNhanVien.Designer.cs tạm thời như sau:

namespace HotelManagement.NhanVien { partial class FormSuaNhanVien { /// <summary> /// Required designer variable. /// </summary> private System.ComponentModel.IContainer components = null;

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 183

/// <summary> /// Clean up any resources being used. /// </summary> /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param> protected override void Dispose(bool disposing) { if (disposing && (components != null)) { components.Dispose(); } base.Dispose(disposing); }

#region Windows Form Designer generated code

/// <summary> /// Required method for Designer support - do not modify /// the contents of this method with the code editor. /// </summary> private void InitializeComponent() { label6 = new Label(); btnThoat = new Button(); btnCapNhat = new Button(); panel1 = new Panel(); txtMaNV = new TextBox(); label11 = new Label(); cbGioiTinh = new ComboBox(); label10 = new Label(); txtEmail = new TextBox(); label9 = new Label(); txtDiaChi = new TextBox(); label8 = new Label(); txtSoCCCD = new TextBox(); label4 = new Label(); dtNgaySinh = new DateTimePicker(); txtLuong = new TextBox(); cbChucVu = new ComboBox(); label7 = new Label(); label3 = new Label(); txtSoDT = new TextBox(); label2 = new Label(); label1 = new Label(); txtHoTenNV = new TextBox(); label5 = new Label(); panel1.SuspendLayout(); SuspendLayout(); // // label6 // label6.AutoSize = true; label6.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 0); label6.ForeColor = Color.FromArgb(192, 0, 0); label6.Location = new Point(358, 26); label6.Name = "label6"; label6.Size = new Size(364, 29); label6.TabIndex = 25; label6.Text = "Cập nhật thông tin nhân viên"; // // btnThoat // btnThoat.BackColor = SystemColors.GradientActiveCaption; btnThoat.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 184

btnThoat.Location = new Point(563, 476); btnThoat.Margin = new Padding(3, 4, 3, 4); btnThoat.Name = "btnThoat"; btnThoat.Size = new Size(137, 59); btnThoat.TabIndex = 24; btnThoat.Text = "Thoát"; btnThoat.UseVisualStyleBackColor = false; btnThoat.Click += btnThoat_Click; // // btnCapNhat // btnCapNhat.BackColor = Color.Moccasin; btnCapNhat.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); btnCapNhat.Location = new Point(363, 476); btnCapNhat.Margin = new Padding(3, 4, 3, 4); btnCapNhat.Name = "btnCapNhat"; btnCapNhat.Size = new Size(137, 59); btnCapNhat.TabIndex = 23; btnCapNhat.Text = "Cập nhật"; btnCapNhat.UseVisualStyleBackColor = false; btnCapNhat.Click += btnCapNhat_Click; // // panel1 // panel1.Controls.Add(txtMaNV); panel1.Controls.Add(label11); panel1.Controls.Add(cbGioiTinh); panel1.Controls.Add(label10); panel1.Controls.Add(txtEmail); panel1.Controls.Add(label9); panel1.Controls.Add(txtDiaChi); panel1.Controls.Add(label8); panel1.Controls.Add(txtSoCCCD); panel1.Controls.Add(label4); panel1.Controls.Add(dtNgaySinh); panel1.Controls.Add(txtLuong); panel1.Controls.Add(cbChucVu); panel1.Controls.Add(label7); panel1.Controls.Add(label3); panel1.Controls.Add(txtSoDT); panel1.Controls.Add(label2); panel1.Controls.Add(label1); panel1.Controls.Add(txtHoTenNV); panel1.Controls.Add(label5); panel1.Location = new Point(20, 85); panel1.Margin = new Padding(3, 4, 3, 4); panel1.Name = "panel1"; panel1.Size = new Size(1020, 355); panel1.TabIndex = 22; // // txtMaNV // txtMaNV.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); txtMaNV.Location = new Point(696, 289); txtMaNV.Margin = new Padding(3, 4, 3, 4); txtMaNV.Name = "txtMaNV"; txtMaNV.ReadOnly = true; txtMaNV.Size = new Size(290, 30); txtMaNV.TabIndex = 38; // // label11 // label11.AutoSize = true;

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 185

label11.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0); label11.Location = new Point(601, 291); label11.Name = "label11"; label11.Size = new Size(79, 26); label11.TabIndex = 37; label11.Text = "Mã NV"; // // cbGioiTinh // cbGioiTinh.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0); cbGioiTinh.FormattingEnabled = true; cbGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" }); cbGioiTinh.Location = new Point(202, 294); cbGioiTinh.Margin = new Padding(3, 4, 3, 4); cbGioiTinh.Name = "cbGioiTinh"; cbGioiTinh.Size = new Size(290, 30); cbGioiTinh.TabIndex = 36; // // label10 // label10.AutoSize = true; label10.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0); label10.Location = new Point(72, 294); label10.Name = "label10"; label10.Size = new Size(92, 26); label10.TabIndex = 35; label10.Text = "Giới tính"; // // txtEmail // txtEmail.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); txtEmail.Location = new Point(696, 211); txtEmail.Margin = new Padding(3, 4, 3, 4); txtEmail.Name = "txtEmail"; txtEmail.Size = new Size(290, 30); txtEmail.TabIndex = 34; // // label9 // label9.AutoSize = true; label9.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0); label9.Location = new Point(612, 214); label9.Name = "label9"; label9.Size = new Size(68, 26); label9.TabIndex = 33; label9.Text = "Email"; // // txtDiaChi // txtDiaChi.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); txtDiaChi.Location = new Point(696, 152); txtDiaChi.Margin = new Padding(3, 4, 3, 4); txtDiaChi.Name = "txtDiaChi"; txtDiaChi.Size = new Size(290, 30); txtDiaChi.TabIndex = 32; // // label8 // label8.AutoSize = true;

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 186

label8.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0); label8.Location = new Point(601, 152); label8.Name = "label8"; label8.Size = new Size(79, 26); label8.TabIndex = 31; label8.Text = "Địa chỉ"; // // txtSoCCCD // txtSoCCCD.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); txtSoCCCD.Location = new Point(696, 80); txtSoCCCD.Margin = new Padding(3, 4, 3, 4); txtSoCCCD.Name = "txtSoCCCD"; txtSoCCCD.Size = new Size(290, 30); txtSoCCCD.TabIndex = 30; // // label4 // label4.AutoSize = true; label4.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0); label4.Location = new Point(571, 88); label4.Name = "label4"; label4.Size = new Size(109, 26); label4.TabIndex = 29; label4.Text = "Số CCCD"; // // dtNgaySinh // dtNgaySinh.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0); dtNgaySinh.Location = new Point(696, 19); dtNgaySinh.Margin = new Padding(3, 4, 3, 4); dtNgaySinh.Name = "dtNgaySinh"; dtNgaySinh.Size = new Size(290, 28); dtNgaySinh.TabIndex = 28; // // txtLuong // txtLuong.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); txtLuong.Location = new Point(202, 150); txtLuong.Margin = new Padding(3, 4, 3, 4); txtLuong.Name = "txtLuong"; txtLuong.Size = new Size(290, 30); txtLuong.TabIndex = 27; // // cbChucVu // cbChucVu.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0); cbChucVu.FormattingEnabled = true; cbChucVu.Items.AddRange(new object[] { "Người quản trị hệ thống", "Quản lý khách sạn", "Nhân viên" }); cbChucVu.Location = new Point(202, 82); cbChucVu.Margin = new Padding(3, 4, 3, 4); cbChucVu.Name = "cbChucVu"; cbChucVu.Size = new Size(290, 30); cbChucVu.TabIndex = 26; // // label7 // label7.AutoSize = true;

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 187

label7.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0); label7.Location = new Point(89, 152); label7.Name = "label7"; label7.Size = new Size(72, 26); label7.TabIndex = 24; label7.Text = "Lương"; // // label3 // label3.AutoSize = true; label3.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0); label3.Location = new Point(571, 21); label3.Name = "label3"; label3.Size = new Size(109, 26); label3.TabIndex = 22; label3.Text = "Ngày sinh"; // // txtSoDT // txtSoDT.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); txtSoDT.Location = new Point(202, 214); txtSoDT.Margin = new Padding(3, 4, 3, 4); txtSoDT.Name = "txtSoDT"; txtSoDT.Size = new Size(290, 30); txtSoDT.TabIndex = 21; // // label2 // label2.AutoSize = true; label2.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0); label2.Location = new Point(25, 216); label2.Name = "label2"; label2.Size = new Size(139, 26); label2.TabIndex = 20; label2.Text = "Số điện thoại"; // // label1 // label1.AutoSize = true; label1.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0); label1.Location = new Point(72, 82); label1.Name = "label1"; label1.Size = new Size(92, 26); label1.TabIndex = 18; label1.Text = "Chức vụ"; // // txtHoTenNV // txtHoTenNV.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); txtHoTenNV.Location = new Point(202, 22); txtHoTenNV.Margin = new Padding(3, 4, 3, 4); txtHoTenNV.Name = "txtHoTenNV"; txtHoTenNV.Size = new Size(290, 30); txtHoTenNV.TabIndex = 17; // // label5 // label5.AutoSize = true; label5.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 188

label5.Location = new Point(59, 19); label5.Name = "label5"; label5.Size = new Size(105, 26); label5.TabIndex = 16; label5.Text = "Họ và tên"; // // FormSuaNhanVien // AutoScaleDimensions = new SizeF(8F, 20F); AutoScaleMode = AutoScaleMode.Font; ClientSize = new Size(1053, 559); Controls.Add(label6); Controls.Add(btnThoat); Controls.Add(btnCapNhat); Controls.Add(panel1); Margin = new Padding(3, 4, 3, 4); Name = "FormSuaNhanVien"; Text = "FormSuaNhanVien"; Load += FormSuaNhanVien_Load; panel1.ResumeLayout(false); panel1.PerformLayout(); ResumeLayout(false); PerformLayout();

}

#endregion

private System.Windows.Forms.Label label6; private System.Windows.Forms.Button btnThoat; private System.Windows.Forms.Button btnCapNhat; private System.Windows.Forms.Panel panel1; private System.Windows.Forms.TextBox txtMaNV; private System.Windows.Forms.Label label11; private System.Windows.Forms.ComboBox cbGioiTinh; private System.Windows.Forms.Label label10; private System.Windows.Forms.TextBox txtEmail; private System.Windows.Forms.Label label9; private System.Windows.Forms.TextBox txtDiaChi; private System.Windows.Forms.Label label8; private System.Windows.Forms.TextBox txtSoCCCD; private System.Windows.Forms.Label label4; private System.Windows.Forms.DateTimePicker dtNgaySinh; private System.Windows.Forms.TextBox txtLuong; private System.Windows.Forms.ComboBox cbChucVu; private System.Windows.Forms.Label label7; private System.Windows.Forms.Label label3; private System.Windows.Forms.TextBox txtSoDT; private System.Windows.Forms.Label label2; private System.Windows.Forms.Label label1; private System.Windows.Forms.TextBox txtHoTenNV; private System.Windows.Forms.Label label5; } }

### Bước 13: SV sử dụng mã nguồn tạm thời sau để xử lý chức năng trong file

### FormSuaNhanVien.cs

using System; using System.Collections.Generic; using System.ComponentModel; using System.Data; using System.Drawing; using System.Globalization; using System.Text;

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 189

using System.Text.RegularExpressions; using System.Windows.Forms; using HotelManagement.Models;

namespace HotelManagement.NhanVien { public partial class FormSuaNhanVien: Form { private string maNV = string.Empty;

public FormSuaNhanVien () { InitializeComponent(); }

public FormSuaNhanVien ( string maNV) : this () { this.maNV = maNV; }

private void FormSuaNhanVien_Load ( object sender, EventArgs e) { txtHoTenNV.MaxLength = 50; txtLuong.MaxLength = 15; txtSoDT.MaxLength = 10; txtSoCCCD.MaxLength = 12; txtDiaChi.MaxLength = 100; txtEmail.MaxLength = 100;

cbChucVu.DropDownStyle = ComboBoxStyle.DropDownList; cbGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList; dtNgaySinh.Format = DateTimePickerFormat.Short;

txtLuong.KeyPress += ChiNhapSo; txtSoDT.KeyPress += ChiNhapSo; txtSoCCCD.KeyPress += ChiNhapSo;

if ( string.IsNullOrEmpty(maNV)) { MessageBox.Show( "Không xác định được nhân viên cần cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); DialogResult = DialogResult.Cancel; Close(); return; }

LoadThongTinNhanVien(); }

private void LoadThongTinNhanVien () { try { using var db = new HotelManagementContext();

var nhanVien = db.NhanViens .Where( n => n.MaNv == maNV && n.DaXoa != true) .Select( n => new { n.MaNv, n.TenNv, n.ChucVu, n.Luong, n.Sdt, n.Cccd, n.NgaySinh,

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 190

n.GioiTinh, n.DiaChi, n.Email }) .FirstOrDefault();

if (nhanVien == null) { MessageBox.Show( "Không tìm thấy nhân viên cần cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); DialogResult = DialogResult.Cancel; Close(); return; }

txtMaNV.Text = nhanVien.MaNv; txtHoTenNV.Text = nhanVien.TenNv; ChonGiaTri(cbChucVu, nhanVien.ChucVu); txtLuong.Text = nhanVien.Luong.ToString( "0", CultureInfo.InvariantCulture); txtSoDT.Text = nhanVien.Sdt; txtSoCCCD.Text = nhanVien.Cccd; dtNgaySinh.Value = nhanVien.NgaySinh.ToDateTime(TimeOnly.MinValue); ChonGiaTri(cbGioiTinh, nhanVien.GioiTinh); txtDiaChi.Text = nhanVien.DiaChi; txtEmail.Text = nhanVien.Email ?? ""; } catch (Exception ex) { MessageBox.Show( "Lỗi khi load nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); DialogResult = DialogResult.Cancel; Close(); } }

private void ChonGiaTri (ComboBox comboBox, string giaTri) { if ( string.IsNullOrEmpty(giaTri)) { return; }

int viTri = comboBox.FindStringExact(giaTri); if (viTri < 0) { viTri = comboBox.Items.Add(giaTri); } comboBox.SelectedIndex = viTri; }

private void ChiNhapSo ( object sender, KeyPressEventArgs e) { if (! char.IsControl(e.KeyChar) && ! char.IsDigit(e.KeyChar)) { e.Handled = true; } }

private bool IsValidEmail ( string email) { return Regex.IsMatch(email, @"^[^@\ s]+@[^@ \ s]+ \.[^@ \ s]+$"); }

private bool ToanChuSo ( string chuoi) {

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 191

foreach ( char c in chuoi) { if (! char.IsDigit(c)) { return false; } } return true; }

private void btnCapNhat_Click ( object sender, EventArgs e) { string tenNV = txtHoTenNV.Text. Trim (); string chucVu = cbChucVu.SelectedItem?. ToString () ?? ""; string luong = txtLuong.Text. Trim (); string sdt = txtSoDT.Text. Trim (); string cccd = txtSoCCCD.Text. Trim (); DateTime ngaySinh = dtNgaySinh.Value.Date; string gioiTinh = cbGioiTinh.SelectedItem?. ToString () ?? ""; string diaChi = txtDiaChi.Text. Trim (); string email = txtEmail.Text. Trim ();

if ( tenNV == "" || chucVu == "" || luong == "" || sdt == "" || cccd == "" || gioiTinh == "" || diaChi == "" || email == "") { MessageBox. Show( "Vui lòng điền đầy đủ thông tin bắt buộc.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

if (! decimal. TryParse ( luong, NumberStyles.None, CultureInfo.InvariantCulture, out decimal luongSo) || luongSo <= 0) { MessageBox. Show( "Lương phải là số lớn hơn 0.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtLuong. Focus (); return; }

if (! ToanChuSo ( sdt) || sdt.Length < 9) { MessageBox. Show( "Số điện thoại phải gồm 9 đến 10 chữ số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtSoDT. Focus (); return; }

if (! ToanChuSo ( cccd) || cccd.Length != 12) { MessageBox. Show( "Số CCCD phải gồm đúng 12 chữ số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtSoCCCD. Focus (); return; }

if (! IsValidEmail ( email)) { MessageBox. Show( "Email không đúng định dạng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtEmail. Focus (); return; }

if ( ngaySinh > DateTime.Today. AddYears ( - 18)) {

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 192

MessageBox. Show( "Nhân viên phải đủ 18 tuổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); dtNgaySinh. Focus (); return; }

try { using var db = new HotelManagementContext ();

var nhanVien = db.NhanViens. FirstOrDefault ( n => n.MaNv == maNV && n.DaXoa != true); if ( nhanVien == null) { MessageBox. Show( "Không tìm thấy nhân viên cần cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); DialogResult = DialogResult.Cancel; Close (); return; }

if ( db.NhanViens. Any ( n => n.MaNv != maNV && n.Sdt == sdt)) { MessageBox. Show( "Số điện thoại đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtSoDT. Focus (); return; }

if ( db.NhanViens. Any ( n => n.MaNv != maNV && n.Cccd == cccd)) { MessageBox. Show( "Số CCCD đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtSoCCCD. Focus (); return; }

if ( db.NhanViens. Any ( n => n.MaNv != maNV && n.Email == email)) { MessageBox. Show( "Email đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtEmail. Focus (); return; }

nhanVien.TenNv = tenNV; nhanVien.ChucVu = chucVu; nhanVien.Luong = luongSo; nhanVien.Sdt = sdt; nhanVien.Cccd = cccd; nhanVien.NgaySinh = DateOnly. FromDateTime ( ngaySinh); nhanVien.GioiTinh = gioiTinh; nhanVien.DiaChi = diaChi; nhanVien.Email = email;

int kq = db. SaveChanges ();

if ( kq > 0) { MessageBox. Show( "Cập nhật nhân viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); DialogResult = DialogResult.OK; Close (); } else {

Lập trình trực quan

Ths. Nguyễn Thiện Dương Trang 193

MessageBox. Show( "Không có thay đổi nào để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); } } catch ( Exception ex) { MessageBox. Show( "Lỗi khi cập nhật nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); } }

private void btnThoat_Click ( object sender, EventArgs e) { DialogResult = DialogResult.Cancel; Close (); } } }

5. Xây dựng giao diện và chức năng quản lý thông tin tiện nghi cho các loại phòng

trong khách sạn

Bước 1: Click chuột phải vào thư mục project → Add → New Folder→ Đặt tên folder

là “ChiTietTienNghi”

Bước 2: Click chuột phải vào folder ChiTietTienNghi → Add → Forms( Windows

Forms) → tạo một form thể hiện danh sách các nhân viên đang có trong khách sạn là

FormDanhSachChiTietTienNghi.cs

Bước 3: Thiết kế giao diện FormDanhSachChiTietTienNghi.cs theo mẫu như sau:

Mã nguồn tham khảo trong file FormDanhSachChiTietTienNghi.Designer.cs tạm thời

như sau:

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 194

namespace HotelManagement.ChiTietTienNghi { partial class FormDanhSachChiTietTienNghi { /// <summary> /// Required designer variable. /// </summary> private System.ComponentModel. IContainer components = null;

/// <summary> /// Clean up any resources being used. /// </summary> /// <param name=" disposing "> true if managed resources should be disposed; otherwise, false. </param> protected override void Dispose ( bool disposing) { if ( disposing && (components != null)) { components. Dispose (); } base. Dispose ( disposing); }

#region Windows Form Designer generated code

/// <summary> /// Required method for Designer support - do not modify /// the contents of this method with the code editor. /// </summary> private void InitializeComponent () { dtgDanhSachTienNghiTheoLoaiPhong = new DataGridView (); label1 = new Label (); lblTenLoaiPhong = new Label (); btnThoat = new Button (); btnCapNhat = new Button ();

((System.ComponentModel. ISupportInitialize)dtgDanhSachTienNghiTheoLoaiPhong). BeginInit ( ); SuspendLayout (); // // dtgDanhSachTienNghiTheoLoaiPhong // dtgDanhSachTienNghiTheoLoaiPhong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize; dtgDanhSachTienNghiTheoLoaiPhong.Location = new Point (12, 141); dtgDanhSachTienNghiTheoLoaiPhong.Margin = new Padding (3, 4, 3, 4); dtgDanhSachTienNghiTheoLoaiPhong.Name = "dtgDanhSachTienNghiTheoLoaiPhong"; dtgDanhSachTienNghiTheoLoaiPhong.RowHeadersWidth = 51; dtgDanhSachTienNghiTheoLoaiPhong.RowTemplate.Height = 24; dtgDanhSachTienNghiTheoLoaiPhong.Size = new Size (776, 415); dtgDanhSachTienNghiTheoLoaiPhong.TabIndex = 0; // // label1 // label1.AutoSize = true; label1.Font = new Font ( "Microsoft Sans Serif", 17F, FontStyle.Bold, GraphicsUnit.Point, 0); label1.ForeColor = Color.Red; label1.Location = new Point (157, 26); label1.Name = "label1"; label1.Size = new Size (496, 33); label1.TabIndex = 1; label1.Text = "DANH SÁCH TIỆN NGHI HIỆN CÓ"; // // lblTenLoaiPhong

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 195

// lblTenLoaiPhong.AutoSize = true; lblTenLoaiPhong.Font = new Font ( "Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 0); lblTenLoaiPhong.ForeColor = Color.Blue; lblTenLoaiPhong.Location = new Point (306, 90); lblTenLoaiPhong.Name = "lblTenLoaiPhong"; lblTenLoaiPhong.Size = new Size (194, 29); lblTenLoaiPhong.TabIndex = 2; lblTenLoaiPhong.Text = "Tên loai phòng"; // // btnThoat // btnThoat.BackColor = SystemColors.GradientActiveCaption; btnThoat.Font = new Font ( "Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); btnThoat.Location = new Point (435, 587); btnThoat.Margin = new Padding(3, 4, 3, 4); btnThoat.Name = "btnThoat"; btnThoat.Size = new Size (137, 59); btnThoat.TabIndex = 17; btnThoat.Text = "Thoát"; btnThoat.UseVisualStyleBackColor = false; // // btnCapNhat // btnCapNhat.BackColor = Color.Moccasin; btnCapNhat.Font = new Font ( "Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); btnCapNhat.Location = new Point (227, 587); btnCapNhat.Margin = new Padding (3, 4, 3, 4); btnCapNhat.Name = "btnCapNhat"; btnCapNhat.Size = new Size (137, 59); btnCapNhat.TabIndex = 16; btnCapNhat.Text = "Thêm mới"; btnCapNhat.UseVisualStyleBackColor = false; // // FormDanhSachChiTietTienNghi // AutoScaleDimensions = new SizeF (8F, 20F); AutoScaleMode = AutoScaleMode.Font; ClientSize = new Size (800, 656); Controls. Add(btnThoat); Controls. Add(btnCapNhat); Controls. Add(lblTenLoaiPhong); Controls. Add(label1); Controls. Add(dtgDanhSachTienNghiTheoLoaiPhong); Margin = new Padding (3, 4, 3, 4); Name = "FormDanhSachChiTietTienNghi"; StartPosition = FormStartPosition.CenterScreen; Text = "Quản lý các tiện nghi theo loại phòng";

((System.ComponentModel. ISupportInitialize)dtgDanhSachTienNghiTheoLoaiPhong). EndInit (); ResumeLayout ( false); PerformLayout ();

}

#endregion

private System.Windows.Forms. DataGridView dtgDanhSachTienNghiTheoLoaiPhong; private System.Windows.Forms. Label label1; private System.Windows.Forms. Label lblTenLoaiPhong; private System.Windows.Forms. Button btnThoat; private System.Windows.Forms. Button btnCapNhat; }

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 196

}

### Bước 5: SV sử dụng mã nguồn tạm thời sau để xử lý chức năng trong file

### FormDanhSachChiTietTienNghi.cs

using System; using System.Collections.Generic; using System.ComponentModel; using System.Data; using System.Drawing; using System.Text; using System.Windows.Forms; using HotelManagement.Models; using Microsoft.EntityFrameworkCore;

namespace HotelManagement.ChiTietTienNghi { public partial class FormDanhSachChiTietTienNghi: Form { private string maLPH = string.Empty; private string tenLoaiPhong = string.Empty;

public FormDanhSachChiTietTienNghi () { InitializeComponent(); }

public FormDanhSachChiTietTienNghi ( string maLPH, string tenLoaiPhong) : this () { this.maLPH = maLPH; this.tenLoaiPhong = tenLoaiPhong; }

private void FormDanhSachChiTietTienNghi_Load ( object sender, EventArgs e) { if ( string.IsNullOrEmpty(maLPH)) { MessageBox.Show( "Không xác định được loại phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); Close(); return; }

lblTenLoaiPhong.Text = $"Loại phòng: {tenLoaiPhong} "; LoadChiTietTienNghi(); }

private void KhoiTaoBangDuLieu () { dtgDanhSachTienNghiTheoLoaiPhong.AllowUserToAddRows = false; dtgDanhSachTienNghiTheoLoaiPhong.AllowUserToDeleteRows = false; dtgDanhSachTienNghiTheoLoaiPhong.AllowUserToResizeRows = false; dtgDanhSachTienNghiTheoLoaiPhong.ReadOnly = true; dtgDanhSachTienNghiTheoLoaiPhong.MultiSelect = false; dtgDanhSachTienNghiTheoLoaiPhong.RowHeadersVisible = false; dtgDanhSachTienNghiTheoLoaiPhong.SelectionMode = DataGridViewSelectionMode.FullRowSelect; dtgDanhSachTienNghiTheoLoaiPhong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; dtgDanhSachTienNghiTheoLoaiPhong.RowTemplate.Height = 36;

dtgDanhSachTienNghiTheoLoaiPhong.Columns.Add( "MaTN", "Mã tiện nghi"); dtgDanhSachTienNghiTheoLoaiPhong.Columns[ "MaTN"].Visible = false;

dtgDanhSachTienNghiTheoLoaiPhong.Columns.Add( "TenTN", "Tên tiện nghi");

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 197

dtgDanhSachTienNghiTheoLoaiPhong.Columns.Add( "SL", "Số lượng"); dtgDanhSachTienNghiTheoLoaiPhong.Columns.Add( "GhiChu", "Ghi chú");

dtgDanhSachTienNghiTheoLoaiPhong.Columns[ "TenTN"].FillWeight = 45; dtgDanhSachTienNghiTheoLoaiPhong.Columns[ "SL"].FillWeight = 15; dtgDanhSachTienNghiTheoLoaiPhong.Columns[ "GhiChu"].FillWeight = 40; dtgDanhSachTienNghiTheoLoaiPhong.Columns[ "SL"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

DataGridViewImageColumn suaCol = new DataGridViewImageColumn(); suaCol.Name = "Sua"; suaCol.HeaderText = "Sửa"; suaCol.ImageLayout = DataGridViewImageCellLayout.Zoom; suaCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.None; suaCol.Width = 50; dtgDanhSachTienNghiTheoLoaiPhong.Columns.Add(suaCol);

DataGridViewImageColumn xoaCol = new DataGridViewImageColumn(); xoaCol.Name = "Xoa"; xoaCol.HeaderText = "Xóa"; xoaCol.ImageLayout = DataGridViewImageCellLayout.Zoom; xoaCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.None; xoaCol.Width = 50; dtgDanhSachTienNghiTheoLoaiPhong.Columns.Add(xoaCol); }

private void LoadChiTietTienNghi () { try { if (dtgDanhSachTienNghiTheoLoaiPhong.Columns.Count == 0) { KhoiTaoBangDuLieu (); }

using var db = new HotelManagementContext ();

var danhSach = db.Cttns . AsNoTracking () . Where( c => c.MaLph == maLPH && c.DaXoa != true && c.MaTnNavigation.DaXoa != true) . OrderBy ( c => c.MaTn) . Select ( c => new { c.MaTn, c.MaTnNavigation.TenTn, c.Sl }) . ToList ();

Image iconSua = Properties. Resources.edit; Image iconXoa = Properties. Resources.delete;

dtgDanhSachTienNghiTheoLoaiPhong.Rows. Clear (); foreach ( var tn in danhSach) { int soLuong = tn.Sl ?? 0; bool dungDuoc = soLuong >= 1;

int viTri = dtgDanhSachTienNghiTheoLoaiPhong.Rows. Add( tn.MaTn, tn.TenTn, soLuong, dungDuoc? "Có thể sử dụng tốt": "Đang không sử dụng được", iconSua, iconXoa

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 198

);

if (! dungDuoc) {

dtgDanhSachTienNghiTheoLoaiPhong.Rows[ viTri].Cells[ "GhiChu"].Style.ForeColor = Color.Red; } }

dtgDanhSachTienNghiTheoLoaiPhong. ClearSelection (); } catch ( Exception ex) { MessageBox. Show( "Lỗi khi load tiện nghi của loại phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); } }

private void dtgDanhSachTienNghiTheoLoaiPhong_CellClick ( object sender, DataGridViewCellEventArgs e) { if ( e.RowIndex < 0 || e.ColumnIndex < 0) { return; }

string tenCot = dtgDanhSachTienNghiTheoLoaiPhong.Columns[ e.ColumnIndex].Name; if ( tenCot!= "Sua" && tenCot!= "Xoa") { return; }

DataGridViewRow dong = dtgDanhSachTienNghiTheoLoaiPhong.Rows[ e.RowIndex]; string maTN = dong.Cells[ "MaTN"].Value?. ToString (); string tenTN = dong.Cells[ "TenTN"].Value?. ToString () ?? ""; if ( string. IsNullOrEmpty ( maTN)) { return; }

if ( tenCot == "Sua") { int. TryParse ( dong.Cells[ "SL"].Value?. ToString (), out int sl);

using ( FormSuaChiTietTienNghi f = new FormSuaChiTietTienNghi (maLPH, maTN, tenTN, sl)) { if ( f. ShowDialog () == DialogResult.OK) { LoadChiTietTienNghi (); } } return; }

if ( MessageBox. Show( $"Bạn có chắc muốn xóa tiện nghi ' { tenTN} '?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) { return; }

try { using var db = new HotelManagementContext ();

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 199

var chiTiet = db.Cttns. FirstOrDefault ( c => c.MaLph == maLPH && c.MaTn == maTN); if ( chiTiet == null) { MessageBox. Show( "Không tìm thấy tiện nghi cần xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); } else { db.Cttns. Remove ( chiTiet); int kq = db. SaveChanges ();

if ( kq > 0) { MessageBox. Show( "Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); } else { MessageBox. Show( "Xóa thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); } } } catch ( Exception ex) { MessageBox. Show( "Lỗi khi xóa tiện nghi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }

LoadChiTietTienNghi (); }

private void btnCapNhat_Click ( object sender, EventArgs e) { using ( FormThemChiTietTienNghi f = new FormThemChiTietTienNghi (maLPH)) { f. ShowDialog (); }

LoadChiTietTienNghi (); }

private void btnThoat_Click ( object sender, EventArgs e) { Close (); } } }

### Bước 6: Click chuột phải vào folder ChiTietTienNghi → Add → Forms( Windows

### Forms) → tạo một form để xây dựng giao diện và chức năng thêm mới thông tin 1 tiện

### nghi cho một loại phòng trong khách sạn là FormThemChiTietTienNghi.cs

### Bước 7: Thiết kế giao diện FormThemChiTietTienNghi.cs theo mẫu như sau:

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 200

### Mã nguồn tham khảo trong file FormThemChiTietTienNghi.Designer.cs tạm thời như

### sau:

namespace HotelManagement.ChiTietTienNghi { partial class FormThemChiTietTienNghi { /// <summary> /// Required designer variable. /// </summary> private System.ComponentModel. IContainer components = null;

/// <summary> /// Clean up any resources being used. /// </summary> /// <param name=" disposing "> true if managed resources should be disposed; otherwise, false. </param> protected override void Dispose ( bool disposing) { if ( disposing && (components != null)) { components. Dispose (); } base. Dispose ( disposing); }

#region Windows Form Designer generated code

/// <summary> /// Required method for Designer support - do not modify /// the contents of this method with the code editor. /// </summary> private void InitializeComponent () { txtSoLuong = new TextBox (); label2 = new Label (); label1 = new Label (); label5 = new Label (); btnThoat = new Button (); btnCapNhat = new Button (); cbTenTN = new ComboBox (); SuspendLayout (); // // txtSoLuong //

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 201

txtSoLuong.Font = new Font ( "Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); txtSoLuong.Location = new Point (242, 271); txtSoLuong.Margin = new Padding(3, 4, 3, 4); txtSoLuong.Name = "txtSoLuong"; txtSoLuong.Size = new Size (275, 30); txtSoLuong.TabIndex = 29; // // label2 // label2.AutoSize = true; label2.Font = new Font ( "Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0); label2.Location = new Point (115, 271); label2.Name = "label2"; label2.Size = new Size (98, 26); label2.TabIndex = 28; label2.Text = "Số lượng"; // // label1 // label1.AutoSize = true; label1.Font = new Font ( "Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0); label1.Location = new Point (73, 148); label1.Name = "label1"; label1.Size = new Size (136, 26); label1.TabIndex = 26; label1.Text = "Tên tiện nghi"; // // label5 // label5.AutoSize = true; label5.Font = new Font ( "Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, 0); label5.ForeColor = Color. FromArgb (192, 64, 0); label5.Location = new Point (29, 39); label5.Name = "label5"; label5.Size = new Size (578, 31); label5.TabIndex = 25; label5.Text = "Thêm mới thông tin tiện nghi của loại phòng"; // // btnThoat // btnThoat.BackColor = SystemColors.GradientActiveCaption; btnThoat.Font = new Font ( "Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); btnThoat.Location = new Point (361, 371); btnThoat.Margin = new Padding (3, 4, 3, 4); btnThoat.Name = "btnThoat"; btnThoat.Size = new Size (137, 59); btnThoat.TabIndex = 24; btnThoat.Text = "Thoát"; btnThoat.UseVisualStyleBackColor = false; btnThoat.Click += btnThoat_Click; // // btnCapNhat // btnCapNhat.BackColor = Color.Moccasin; btnCapNhat.Font = new Font ( "Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); btnCapNhat.Location = new Point (161, 371); btnCapNhat.Margin = new Padding (3, 4, 3, 4); btnCapNhat.Name = "btnCapNhat"; btnCapNhat.Size = new Size (137, 59); btnCapNhat.TabIndex = 23;

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 202

btnCapNhat.Text = "Thêm mới"; btnCapNhat.UseVisualStyleBackColor = false; btnCapNhat.Click += btnCapNhat_Click; // // cbTenTN // cbTenTN.Font = new Font ( "Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0); cbTenTN.FormattingEnabled = true; cbTenTN.Location = new Point (242, 149); cbTenTN.Margin = new Padding (3, 4, 3, 4); cbTenTN.Name = "cbTenTN"; cbTenTN.Size = new Size (275, 34); cbTenTN.TabIndex = 30; // // FormThemChiTietTienNghi // AutoScaleDimensions = new SizeF (8F, 20F); AutoScaleMode = AutoScaleMode.Font; ClientSize = new Size (610, 445); Controls. Add(cbTenTN); Controls. Add(txtSoLuong); Controls. Add(label2); Controls. Add(label1); Controls. Add(label5); Controls. Add(btnThoat); Controls. Add(btnCapNhat); Margin = new Padding (3, 4, 3, 4); Name = "FormThemChiTietTienNghi"; StartPosition = FormStartPosition.CenterScreen; Text = "FormThemChiTietTienNghi"; Load += FormThemChiTietTienNghi_Load; ResumeLayout ( false); PerformLayout ();

}

#endregion

private System.Windows.Forms. TextBox txtSoLuong; private System.Windows.Forms. Label label2; private System.Windows.Forms. Label label1; private System.Windows.Forms. Label label5; private System.Windows.Forms. Button btnThoat; private System.Windows.Forms. Button btnCapNhat; private System.Windows.Forms. ComboBox cbTenTN; } }

### Bước 8: SV sử dụng mã nguồn tạm thời sau để xử lý chức năng trong file

### FormThemChiTietTienNghi.cs

using System; using System.Collections.Generic; using System.ComponentModel; using System.Data; using System.Drawing; using System.Text; using System.Windows.Forms; using HotelManagement.Models; using Microsoft.EntityFrameworkCore;

namespace HotelManagement.ChiTietTienNghi { public partial class FormThemChiTietTienNghi: Form

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 203

{ private string maLPH = string.Empty;

public FormThemChiTietTienNghi () { InitializeComponent(); }

public FormThemChiTietTienNghi ( string maLPH) : this () { this.maLPH = maLPH; }

private void FormThemChiTietTienNghi_Load ( object sender, EventArgs e) { cbTenTN.DropDownStyle = ComboBoxStyle.DropDownList; txtSoLuong.MaxLength = 4; txtSoLuong.KeyPress += ChiNhapSo;

if ( string.IsNullOrEmpty(maLPH)) { MessageBox.Show( "Không xác định được loại phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); DialogResult = DialogResult.Cancel; Close(); return; }

LoadTienNghiChuaThem (); }

private void ChiNhapSo ( object sender, KeyPressEventArgs e) { if (! char. IsControl ( e.KeyChar) && ! char. IsDigit ( e.KeyChar)) { e.Handled = true; } }

private void LoadTienNghiChuaThem () { try { using var db = new HotelManagementContext ();

var daCo = db.Cttns . AsNoTracking () . Where( c => c.MaLph == maLPH && c.DaXoa != true) . Select ( c => c.MaTn);

var danhSach = db.TienNghis . AsNoTracking () . Where( t => t.DaXoa != true && ! daCo. Contains ( t.MaTn)) . OrderBy ( t => t.TenTn) . Select ( t => new { t.MaTn, t.TenTn }) . ToList ();

if ( danhSach.Count == 0) { MessageBox. Show( "Loại phòng này đã có đầy đủ các tiện nghi, không còn tiện nghi nào để thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 204

DialogResult = DialogResult.Cancel; Close (); return; }

cbTenTN.DataSource = danhSach; cbTenTN.DisplayMember = "TenTn"; cbTenTN.ValueMember = "MaTn"; cbTenTN.SelectedIndex = 0; } catch ( Exception ex) { MessageBox. Show( "Lỗi khi load danh sách tiện nghi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); DialogResult = DialogResult.Cancel; Close (); } }

private void btnCapNhat_Click ( object sender, EventArgs e) { if ( string. IsNullOrWhiteSpace (txtSoLuong.Text) || cbTenTN.SelectedIndex ==

- 1)

{ MessageBox. Show( "Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

if (! int. TryParse (txtSoLuong.Text. Trim (), out int soLuong) || soLuong < 0) { MessageBox. Show( "Số lượng không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); txtSoLuong. Focus (); return; }

string maTN = cbTenTN.SelectedValue?. ToString () ?? ""; if ( maTN == "") { MessageBox. Show( "Vui lòng chọn tiện nghi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

try { using var db = new HotelManagementContext ();

var chiTiet = db.Cttns. FirstOrDefault ( c => c.MaLph == maLPH && c.MaTn == maTN);

if ( chiTiet == null) { db.Cttns. Add( new Cttn { MaLph = maLPH, MaTn = maTN, Sl = soLuong, DaXoa = false }); } else if ( chiTiet.DaXoa == true) { chiTiet.Sl = soLuong; chiTiet.DaXoa = false;

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 205

} else { MessageBox. Show( "Tiện nghi này đã có trong loại phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); LoadTienNghiChuaThem (); return; }

int kq = db. SaveChanges ();

if ( kq > 0) { MessageBox. Show( "Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); DialogResult = DialogResult.OK; Close (); } else { MessageBox. Show( "Thêm thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); } } catch ( Exception ex) { MessageBox. Show( "Lỗi khi thêm tiện nghi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); } }

private void btnThoat_Click ( object sender, EventArgs e) { DialogResult = DialogResult.Cancel; Close (); } } }

### Bước 9: Click chuột phải vào folder ChiTietTienNghi → Add → Forms( Windows

### Forms) → tạo một form để xây dựng giao diện và chức năng cập nhật thông tin 1 tiện

### nghi cho một loại phòng trong khách sạn là FormSuaChiTietTienNghi.cs

### Bước 10: Thiết kế giao diện FormSuaChiTietTienNghi.cs theo mẫu như sau:

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 206

### Mã nguồn tham khảo trong file FormSuaChiTietTienNghi.Designer.cs tạm thời như

### sau:

namespace HotelManagement.ChiTietTienNghi { partial class FormSuaChiTietTienNghi { /// <summary> /// Required designer variable. /// </summary> private System.ComponentModel. IContainer components = null;

/// <summary> /// Clean up any resources being used. /// </summary> /// <param name=" disposing "> true if managed resources should be disposed; otherwise, false. </param> protected override void Dispose ( bool disposing) { if ( disposing && (components != null)) { components. Dispose (); } base. Dispose ( disposing); }

#region Windows Form Designer generated code

/// <summary> /// Required method for Designer support - do not modify /// the contents of this method with the code editor. /// </summary> private void InitializeComponent () { btnThoat = new Button (); btnCapNhat = new Button (); label5 = new Label (); txtSoLuong = new TextBox (); label2 = new Label (); txtTenTN = new TextBox (); label1 = new Label (); SuspendLayout ();

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 207

// // btnThoat // btnThoat.BackColor = SystemColors.GradientActiveCaption; btnThoat.Font = new Font ( "Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); btnThoat.Location = new Point (327, 431); btnThoat.Margin = new Padding (3, 4, 3, 4); btnThoat.Name = "btnThoat"; btnThoat.Size = new Size (137, 59); btnThoat.TabIndex = 15; btnThoat.Text = "Thoát"; btnThoat.UseVisualStyleBackColor = false; btnThoat.Click += btnThoat_Click; // // btnCapNhat // btnCapNhat.BackColor = Color.Moccasin; btnCapNhat.Font = new Font ( "Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); btnCapNhat.Location = new Point (127, 431); btnCapNhat.Margin = new Padding (3, 4, 3, 4); btnCapNhat.Name = "btnCapNhat"; btnCapNhat.Size = new Size (137, 59); btnCapNhat.TabIndex = 14; btnCapNhat.Text = "Cập nhật"; btnCapNhat.UseVisualStyleBackColor = false; btnCapNhat.Click += btnCapNhat_Click; // // label5 // label5.AutoSize = true; label5.Font = new Font ( "Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, 0); label5.ForeColor = Color. FromArgb (192, 64, 0); label5.Location = new Point (12, 45); label5.Name = "label5"; label5.Size = new Size (569, 31); label5.TabIndex = 16; label5.Text = "Cập nhật thông tin tiện nghi của loại phòng"; // // txtSoLuong // txtSoLuong.Font = new Font ( "Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); txtSoLuong.Location = new Point (253, 294); txtSoLuong.Margin = new Padding (3, 4, 3, 4); txtSoLuong.Name = "txtSoLuong"; txtSoLuong.Size = new Size (275, 30); txtSoLuong.TabIndex = 22; // // label2 // label2.AutoSize = true; label2.Font = new Font ( "Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0); label2.Location = new Point (126, 294); label2.Name = "label2"; label2.Size = new Size (98, 26); label2.TabIndex = 21; label2.Text = "Số lượng"; // // txtTenTN // txtTenTN.AcceptsReturn = true;

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 208

txtTenTN.Font = new Font ( "Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); txtTenTN.Location = new Point (253, 170); txtTenTN.Margin = new Padding(3, 4, 3, 4); txtTenTN.Name = "txtTenTN"; txtTenTN.ReadOnly = true; txtTenTN.Size = new Size (275, 30); txtTenTN.TabIndex = 20; // // label1 // label1.AutoSize = true; label1.Font = new Font ( "Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0); label1.Location = new Point (84, 170); label1.Name = "label1"; label1.Size = new Size (136, 26); label1.TabIndex = 19; label1.Text = "Tên tiện nghi"; // // FormSuaChiTietTienNghi // AutoScaleDimensions = new SizeF (8F, 20F); AutoScaleMode = AutoScaleMode.Font; ClientSize = new Size (613, 576); Controls. Add(txtSoLuong); Controls. Add(label2); Controls. Add(txtTenTN); Controls. Add(label1); Controls. Add(label5); Controls. Add(btnThoat); Controls. Add(btnCapNhat); Margin = new Padding(3, 4, 3, 4); Name = "FormSuaChiTietTienNghi"; StartPosition = FormStartPosition.CenterScreen; Text = "FormSuaChiTietTienNghi"; Load += FormSuaChiTietTienNghi_Load; ResumeLayout ( false); PerformLayout ();

}

#endregion

private System.Windows.Forms. Button btnThoat; private System.Windows.Forms. Button btnCapNhat; private System.Windows.Forms. Label label5; private System.Windows.Forms. TextBox txtSoLuong; private System.Windows.Forms. Label label2; private System.Windows.Forms. TextBox txtTenTN; private System.Windows.Forms. Label label1; } }

### Bước 11: SV sử dụng mã nguồn tạm thời sau để xử lý chức năng trong file

### FormSuaChiTietTienNghi.cs

using System; using System.Collections.Generic; using System.ComponentModel; using System.Data; using System.Drawing; using System.Text; using System.Windows.Forms; using HotelManagement.Models;

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 209

namespace HotelManagement.ChiTietTienNghi { public partial class FormSuaChiTietTienNghi: Form { private string maLPH = string.Empty; private string maTN = string.Empty; private string tenTN = string.Empty; private int soLuongHienTai;

public FormSuaChiTietTienNghi () { InitializeComponent (); }

public FormSuaChiTietTienNghi ( string maLPH, string maTN, string tenTN, int soLuong) : this () { this.maLPH = maLPH; this.maTN = maTN; this.tenTN = tenTN; soLuongHienTai = soLuong; }

private void FormSuaChiTietTienNghi_Load ( object sender, EventArgs e) { txtTenTN.ReadOnly = true; txtSoLuong.MaxLength = 4; txtSoLuong.KeyPress += ChiNhapSo;

if ( string. IsNullOrEmpty (maLPH) || string. IsNullOrEmpty (maTN)) { MessageBox. Show( "Không xác định được tiện nghi cần cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); DialogResult = DialogResult.Cancel; Close (); return; }

txtTenTN.Text = tenTN; txtSoLuong.Text = soLuongHienTai. ToString (); txtSoLuong. Focus (); txtSoLuong. SelectAll (); }

private void ChiNhapSo ( object sender, KeyPressEventArgs e) { if (! char. IsControl ( e.KeyChar) && ! char. IsDigit ( e.KeyChar)) { e.Handled = true; } }

private void btnCapNhat_Click ( object sender, EventArgs e) { if ( string. IsNullOrWhiteSpace (txtSoLuong.Text)) { MessageBox. Show( "Vui lòng nhập số lượng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtSoLuong. Focus (); return; }

if (! int. TryParse (txtSoLuong.Text. Trim (), out int soLuongMoi) || soLuongMoi < 0) {

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 210

MessageBox. Show( "Vui lòng nhập số hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); txtSoLuong. Focus (); return; }

try { using var db = new HotelManagementContext ();

var chiTiet = db.Cttns. FirstOrDefault ( c => c.MaLph == maLPH && c.MaTn == maTN && c.DaXoa != true); if ( chiTiet == null) { MessageBox. Show( "Không tìm thấy tiện nghi cần cập nhật!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); DialogResult = DialogResult.Cancel; Close (); return; }

chiTiet.Sl = soLuongMoi;

int kq = db. SaveChanges ();

if ( kq > 0) { MessageBox. Show( "Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); DialogResult = DialogResult.OK; Close (); } else { MessageBox. Show( "Không có thay đổi nào để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); } } catch ( Exception ex) { MessageBox. Show( "Lỗi khi cập nhật tiện nghi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); } }

private void btnThoat_Click ( object sender, EventArgs e) { DialogResult = DialogResult.Cancel; Close (); } } }

### Bước 12: SV sử dụng mã nguồn sau cập nhật lại mã nguồn trong file

### FormDanhSachLoaiPhong.cs để bổ sung thêm chức năng xem chi tiết các tiện nghi

### đang có trong loại phòng

using System; using System.Collections.Generic; using System.ComponentModel; using System.Data; using System.Drawing; using System.Text; using System.Windows.Forms;

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 211

using ClosedXML.Excel; using HotelManagement.ChiTietTienNghi; using HotelManagement.Models; using Microsoft.EntityFrameworkCore;

namespace HotelManagement.LoaiPhong { public partial class FormDanhSachLoaiPhong : Form { private readonly Image _iconGiuong = Properties.Resources.Giuong; private readonly Image _iconTienNghi = Properties.Resources.details; private readonly Image _iconSua = Properties.Resources.edit;

public FormDanhSachLoaiPhong() { InitializeComponent(); Load += FormDanhSachLoaiPhong_Load; }

private void txtTimKiem_TextChanged(object sender, EventArgs e) { LocTheoTuKhoa(); }

private void btnXuatExcel_Click(object sender, EventArgs e) { var cacDong = dtgDanhSachLoaiPhong.Rows.Cast<DataGridViewRow>() .Where(r => r.Visible && !r.IsNewRow) .ToList();

if (cacDong.Count == 0) { MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

using (var hopLuu = new SaveFileDialog()) { hopLuu.Title = "Xuất danh sách loại phòng"; hopLuu.Filter = "Excel Workbook (*.xlsx)|*.xlsx"; hopLuu.FileName = $"DanhSachLoaiPhong_{DateTime.Now:yyyyMMdd_HHmm}.xlsx";

if (hopLuu.ShowDialog() != DialogResult.OK) return;

try { using (var wb = new XLWorkbook()) { var ws = wb.Worksheets.Add("Danh sách loại phòng");

string[] tenCot = { "MaLPH", "TenLPH", "SoGiuong", "SoNguoiToiDa", "GiaNgay", "GiaGio" };

for (int c = 0; c < tenCot.Length; c++) ws.Cell(1, c + 1).Value = dtgDanhSachLoaiPhong.Columns[tenCot[c]].HeaderText; ws.Row(1).Style.Font.Bold = true;

for (int i = 0; i < cacDong.Count; i++) { for (int c = 0; c < tenCot.Length; c++) { var o = ws.Cell(i + 2, c + 1);

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 212

object? giaTri = cacDong[i].Cells[tenCot[c]].Value;

switch (giaTri) { case decimal d: o.Value = d; o.Style.NumberFormat.Format = "#,##0"; break; case int n: o.Value = n; break; default: o.Value = giaTri?.ToString() ?? ""; break; } } }

ws.Columns().AdjustToContents(); wb.SaveAs(hopLuu.FileName); }

var traLoi = MessageBox.Show("Xuất dữ liệu thành công! \ nBạn có muốn mở file ngay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information); if (traLoi == DialogResult.Yes) { System.Diagnostics.Process.Start( new System.Diagnostics.ProcessStartInfo(hopLuu.FileName) { UseShellExecute = true }); } } catch (IOException) { MessageBox.Show("Không ghi được file. Có thể file đang được mở trong Excel, hãy đóng lại rồi thử lần nữa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); } catch (Exception ex) { MessageBox.Show("Lỗi khi xuất Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); } } }

private void btnThemMoi_Click(object sender, EventArgs e) { using (var formThemLoaiPhong = new FormThemLoaiPhong()) { formThemLoaiPhong.ShowDialog(); }

LoadLoaiPhong(); }

private void dtgDanhSachLoaiPhong_CellClick(object sender, DataGridViewCellEventArgs e) { if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

var dong = dtgDanhSachLoaiPhong.Rows[e.RowIndex]; string? maLPH = dong.Cells["MaLPH"].Value?.ToString(); string? tenLPH = dong.Cells["TenLPH"].Value?.ToString();

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 213

if (string.IsNullOrEmpty(maLPH)) return;

string tenCot = dtgDanhSachLoaiPhong.Columns[e.ColumnIndex].Name;

if (tenCot == "colSua") { using (var formSua = new FormSuaLoaiPhong()) { formSua.MaLoaiPhong = maLPH; formSua.ShowDialog(); }

LoadLoaiPhong(); } else if (tenCot == "colTienNghi") { using (var formTienNghi = new FormDanhSachChiTietTienNghi(maLPH, tenLPH ?? "")) { formTienNghi.ShowDialog(); } } }

private void FormDanhSachLoaiPhong_Load(object sender, EventArgs e) { CauHinhLuoi(); LoadLoaiPhong(); }

private void CauHinhLuoi() { if (dtgDanhSachLoaiPhong.Columns.Count > 0) return;

dtgDanhSachLoaiPhong.ReadOnly = true; dtgDanhSachLoaiPhong.AllowUserToAddRows = false; dtgDanhSachLoaiPhong.AllowUserToDeleteRows = false; dtgDanhSachLoaiPhong.AllowUserToResizeRows = false; dtgDanhSachLoaiPhong.MultiSelect = false; dtgDanhSachLoaiPhong.SelectionMode = DataGridViewSelectionMode.FullRowSelect; dtgDanhSachLoaiPhong.RowHeadersVisible = false; dtgDanhSachLoaiPhong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; dtgDanhSachLoaiPhong.RowTemplate.Height = 40;

dtgDanhSachLoaiPhong.Columns.Add(TaoCotAnh("colIcon", "", _iconGiuong,

50. );

dtgDanhSachLoaiPhong.Columns.Add("MaLPH", "Mã loại"); dtgDanhSachLoaiPhong.Columns.Add("TenLPH", "Tên loại"); dtgDanhSachLoaiPhong.Columns.Add("SoGiuong", "Số giường"); dtgDanhSachLoaiPhong.Columns.Add("SoNguoiToiDa", "Số người tối đa"); dtgDanhSachLoaiPhong.Columns.Add("GiaNgay", "Giá ngày"); dtgDanhSachLoaiPhong.Columns.Add("GiaGio", "Giá giờ");

dtgDanhSachLoaiPhong.Columns["GiaNgay"]!.DefaultCellStyle.Format = "N0"; dtgDanhSachLoaiPhong.Columns["GiaGio"]!.DefaultCellStyle.Format = "N0"; dtgDanhSachLoaiPhong.Columns["GiaNgay"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; dtgDanhSachLoaiPhong.Columns["GiaGio"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 214

dtgDanhSachLoaiPhong.Columns.Add(TaoCotAnh("colTienNghi", "Tiện nghi", _iconTienNghi, 60)); dtgDanhSachLoaiPhong.Columns.Add(TaoCotAnh("colSua", "Cập nhật", _iconSua,

70. );

}

private DataGridViewImageColumn TaoCotAnh(string ten, string tieuDe, Image anh, int doRong) { return new DataGridViewImageColumn { Name = ten, HeaderText = tieuDe, Image = anh, ImageLayout = DataGridViewImageCellLayout.Zoom, AutoSizeMode = DataGridViewAutoSizeColumnMode.None, Width = doRong, Resizable = DataGridViewTriState.False, SortMode = DataGridViewColumnSortMode.NotSortable }; }

private void LoadLoaiPhong() { try { using var db = new HotelManagementContext();

var dsLoaiPhong = db.LoaiPhongs .AsNoTracking() .OrderBy(l => l.MaLph) .Select(l => new { l.MaLph, l.TenLph, l.SoGiuong, l.SoNguoiToiDa, l.GiaNgay, l.GiaGio }) .ToList();

dtgDanhSachLoaiPhong.Rows.Clear();

foreach (var l in dsLoaiPhong) { dtgDanhSachLoaiPhong.Rows.Add( _iconGiuong, l.MaLph, l.TenLph, l.SoGiuong, l.SoNguoiToiDa, l.GiaNgay, l.GiaGio, _iconTienNghi, _iconSua ); }

LocTheoTuKhoa(); } catch (Exception ex) { MessageBox.Show("Lỗi khi tải loại phòng: " + ex.Message); } }

Lập trình trực quan

Ths. Nguyễn Thiện Dương Trang 215

private void LocTheoTuKhoa() { string keyword = txtTimKiem.Text.Trim();

dtgDanhSachLoaiPhong.CurrentCell = null;

foreach (DataGridViewRow row in dtgDanhSachLoaiPhong.Rows) { string ma = row.Cells["MaLPH"].Value?.ToString() ?? ""; string ten = row.Cells["TenLPH"].Value?.ToString() ?? "";

row.Visible = keyword.Length == 0 || ma.Contains(keyword, StringComparison.OrdinalIgnoreCase) || ten.Contains(keyword, StringComparison.OrdinalIgnoreCase); } } } }

6. Xây dựng giao diện và chức năng quản lý thông tin đặt phòng tại khách sạn

Bước 1: Click chuột phải vào folder SoDoPhong → Add → Forms( Windows Forms)

→ tạo một form cho phép tạo thông tin đặt/thuê phòngtrong khách sạn là

FormDatPhong.cs

Bước 2: Thiết kế giao diện FormDatPhong.cs theo mẫu như sau:

Mã nguồn tham khảo trong file FormDatPhong.Designer.cs tạm thời như sau: namespace HotelManagement.SoDoPhong { partial class FormDatPhong { /// <summary> /// Required designer variable. /// </summary> private System.ComponentModel.IContainer components = null;

/// <summary> /// Clean up any resources being used. /// </summary> /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 216

protected override void Dispose(bool disposing) { if (disposing && (components != null)) { components.Dispose(); } base.Dispose(disposing); }

#region Windows Form Designer generated code

/// <summary> /// Required method for Designer support - do not modify /// the contents of this method with the code editor. /// </summary> private void InitializeComponent() { this.label6 = new System.Windows.Forms.Label(); this.panel1 = new System.Windows.Forms.Panel(); this.label4 = new System.Windows.Forms.Label(); this.cbGioiTinh = new System.Windows.Forms.ComboBox(); this.label7 = new System.Windows.Forms.Label(); this.txtSoDienThoai = new System.Windows.Forms.TextBox(); this.label3 = new System.Windows.Forms.Label(); this.txtQuocTich = new System.Windows.Forms.TextBox(); this.label2 = new System.Windows.Forms.Label(); this.txtCCCD = new System.Windows.Forms.TextBox(); this.label1 = new System.Windows.Forms.Label(); this.txtHoVaTen = new System.Windows.Forms.TextBox(); this.label5 = new System.Windows.Forms.Label(); this.panel2 = new System.Windows.Forms.Panel(); this.label14 = new System.Windows.Forms.Label(); this.label13 = new System.Windows.Forms.Label(); this.dtgDanhSachPhongDaChon = new System.Windows.Forms.DataGridView(); this.dtgDanhSachPhongTrong = new System.Windows.Forms.DataGridView(); this.cbDangGioDi = new System.Windows.Forms.ComboBox(); this.cbGioDi = new System.Windows.Forms.ComboBox(); this.cbDangGioDen = new System.Windows.Forms.ComboBox(); this.cbGioDen = new System.Windows.Forms.ComboBox(); this.label12 = new System.Windows.Forms.Label(); this.label11 = new System.Windows.Forms.Label(); this.dtpNgayKT = new System.Windows.Forms.DateTimePicker(); this.dtpNgayBD = new System.Windows.Forms.DateTimePicker(); this.label10 = new System.Windows.Forms.Label(); this.label9 = new System.Windows.Forms.Label(); this.label8 = new System.Windows.Forms.Label(); this.btnDatPhong = new System.Windows.Forms.Button(); this.button2 = new System.Windows.Forms.Button(); this.panel1.SuspendLayout(); this.panel2.SuspendLayout();

((System.ComponentModel.ISupportInitialize)(this.dtgDanhSachPhongDaChon)).BeginInit();

((System.ComponentModel.ISupportInitialize)(this.dtgDanhSachPhongTrong)).BeginInit(); this.SuspendLayout(); // // label6 // this.label6.AutoSize = true; this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))); this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192))))); this.label6.Location = new System.Drawing.Point(515, 9); this.label6.Name = "label6";

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 217

this.label6.Size = new System.Drawing.Size(138, 29); this.label6.TabIndex = 22; this.label6.Text = "Đặt phòng"; // // panel1 // this.panel1.Controls.Add(this.label4); this.panel1.Controls.Add(this.cbGioiTinh); this.panel1.Controls.Add(this.label7); this.panel1.Controls.Add(this.txtSoDienThoai); this.panel1.Controls.Add(this.label3); this.panel1.Controls.Add(this.txtQuocTich); this.panel1.Controls.Add(this.label2); this.panel1.Controls.Add(this.txtCCCD); this.panel1.Controls.Add(this.label1); this.panel1.Controls.Add(this.txtHoVaTen); this.panel1.Controls.Add(this.label5); this.panel1.Location = new System.Drawing.Point(12, 49); this.panel1.Name = "panel1"; this.panel1.Size = new System.Drawing.Size(465, 413); this.panel1.TabIndex = 23; // // label4 // this.label4.AutoSize = true; this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))); this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))); this.label4.Location = new System.Drawing.Point(119, 23); this.label4.Name = "label4"; this.label4.Size = new System.Drawing.Size(276, 29); this.label4.TabIndex = 24; this.label4.Text = "Thông tin khách hàng"; // // cbGioiTinh // this.cbGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); this.cbGioiTinh.FormattingEnabled = true; this.cbGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ"}); this.cbGioiTinh.Location = new System.Drawing.Point(236, 288); this.cbGioiTinh.Name = "cbGioiTinh"; this.cbGioiTinh.Size = new System.Drawing.Size(199, 30); this.cbGioiTinh.TabIndex = 25; // // label7 // this.label7.AutoSize = true; this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); this.label7.Location = new System.Drawing.Point(68, 191); this.label7.Name = "label7"; this.label7.Size = new System.Drawing.Size(139, 26); this.label7.TabIndex = 24; this.label7.Text = "Số điện thoại"; // // txtSoDienThoai // this.txtSoDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); this.txtSoDienThoai.Location = new System.Drawing.Point(236, 187); this.txtSoDienThoai.Name = "txtSoDienThoai";

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 218

this.txtSoDienThoai.Size = new System.Drawing.Size(199, 30); this.txtSoDienThoai.TabIndex = 23; // // label3 // this.label3.AutoSize = true; this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); this.label3.Location = new System.Drawing.Point(115, 292); this.label3.Name = "label3"; this.label3.Size = new System.Drawing.Size(92, 26); this.label3.TabIndex = 22; this.label3.Text = "Giới tính"; // // txtQuocTich // this.txtQuocTich.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); this.txtQuocTich.Location = new System.Drawing.Point(236, 240); this.txtQuocTich.Name = "txtQuocTich"; this.txtQuocTich.Size = new System.Drawing.Size(199, 30); this.txtQuocTich.TabIndex = 21; // // label2 // this.label2.AutoSize = true; this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); this.label2.Location = new System.Drawing.Point(109, 240); this.label2.Name = "label2"; this.label2.Size = new System.Drawing.Size(104, 26); this.label2.TabIndex = 20; this.label2.Text = "Quốc tịch"; // // txtCCCD // this.txtCCCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); this.txtCCCD.Location = new System.Drawing.Point(236, 135); this.txtCCCD.Name = "txtCCCD"; this.txtCCCD.Size = new System.Drawing.Size(199, 30); this.txtCCCD.TabIndex = 19; // // label1 // this.label1.AutoSize = true; this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); this.label1.Location = new System.Drawing.Point( - 1, 137); this.label1.Name = "label1"; this.label1.Size = new System.Drawing.Size(201, 26); this.label1.TabIndex = 18; this.label1.Text = "Số CCCD/Passport"; // // txtHoVaTen // this.txtHoVaTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); this.txtHoVaTen.Location = new System.Drawing.Point(236, 87); this.txtHoVaTen.Name = "txtHoVaTen"; this.txtHoVaTen.Size = new System.Drawing.Size(199, 30); this.txtHoVaTen.TabIndex = 17; // // label5 // this.label5.AutoSize = true;

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 219

this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); this.label5.Location = new System.Drawing.Point(89, 89); this.label5.Name = "label5"; this.label5.Size = new System.Drawing.Size(105, 26); this.label5.TabIndex = 16; this.label5.Text = "Họ và tên"; // // panel2 // this.panel2.Controls.Add(this.label14); this.panel2.Controls.Add(this.label13); this.panel2.Controls.Add(this.dtgDanhSachPhongDaChon); this.panel2.Controls.Add(this.dtgDanhSachPhongTrong); this.panel2.Controls.Add(this.cbDangGioDi); this.panel2.Controls.Add(this.cbGioDi); this.panel2.Controls.Add(this.cbDangGioDen); this.panel2.Controls.Add(this.cbGioDen); this.panel2.Controls.Add(this.label12); this.panel2.Controls.Add(this.label11); this.panel2.Controls.Add(this.dtpNgayKT); this.panel2.Controls.Add(this.dtpNgayBD); this.panel2.Controls.Add(this.label10); this.panel2.Controls.Add(this.label9); this.panel2.Controls.Add(this.label8); this.panel2.Location = new System.Drawing.Point(483, 49); this.panel2.Name = "panel2"; this.panel2.Size = new System.Drawing.Size(796, 521); this.panel2.TabIndex = 26; // // label14 // this.label14.AutoSize = true; this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))); this.label14.ForeColor = System.Drawing.Color.Green; this.label14.Location = new System.Drawing.Point(440, 199); this.label14.Name = "label14"; this.label14.Size = new System.Drawing.Size(331, 29); this.label14.TabIndex = 38; this.label14.Text = "Danh sách phòng đã chọn"; // // label13 // this.label13.AutoSize = true; this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))); this.label13.ForeColor = System.Drawing.Color.Green; this.label13.Location = new System.Drawing.Point(43, 199); this.label13.Name = "label13"; this.label13.Size = new System.Drawing.Size(296, 29); this.label13.TabIndex = 26; this.label13.Text = "Danh sách phòng trống"; // // dtgDanhSachPhongDaChon // this.dtgDanhSachPhongDaChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize; this.dtgDanhSachPhongDaChon.Location = new System.Drawing.Point(396, 235); this.dtgDanhSachPhongDaChon.Name = "dtgDanhSachPhongDaChon"; this.dtgDanhSachPhongDaChon.RowHeadersWidth = 51; this.dtgDanhSachPhongDaChon.RowTemplate.Height = 24; this.dtgDanhSachPhongDaChon.Size = new System.Drawing.Size(397, 276); this.dtgDanhSachPhongDaChon.TabIndex = 37;

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 220

//this.dtgDanhSachPhongDaChon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDanhSachPhongDaChon_CellClick ); // // dtgDanhSachPhongTrong // this.dtgDanhSachPhongTrong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize; this.dtgDanhSachPhongTrong.Location = new System.Drawing.Point(3, 235); this.dtgDanhSachPhongTrong.Name = "dtgDanhSachPhongTrong"; this.dtgDanhSachPhongTrong.RowHeadersWidth = 51; this.dtgDanhSachPhongTrong.RowTemplate.Height = 24; this.dtgDanhSachPhongTrong.Size = new System.Drawing.Size(373, 276); this.dtgDanhSachPhongTrong.TabIndex = 36; //this.dtgDanhSachPhongTrong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDanhSachPhongTrong_CellClick) ; // // cbDangGioDi // this.cbDangGioDi.FormattingEnabled = true; this.cbDangGioDi.Items.AddRange(new object[] { "AM", "PM"}); this.cbDangGioDi.Location = new System.Drawing.Point(634, 138); this.cbDangGioDi.Name = "cbDangGioDi"; this.cbDangGioDi.Size = new System.Drawing.Size(55, 24); this.cbDangGioDi.TabIndex = 35; // // cbGioDi // this.cbGioDi.FormattingEnabled = true; this.cbGioDi.Items.AddRange(new object[] { "01:00", "01:30", "02:00", "02:30", "03:00", "03:30", "04:00", "04:30", "05:00", "05:30", "06:00", "06:30", "07:00", "07:30", "08:00", "08:30", "09:00", "09:30", "10:00", "10:30", "11:00", "11:30", "12:00", "12:30"}); this.cbGioDi.Location = new System.Drawing.Point(536, 138); this.cbGioDi.Name = "cbGioDi"; this.cbGioDi.Size = new System.Drawing.Size(101, 24); this.cbGioDi.TabIndex = 34; // // cbDangGioDen // this.cbDangGioDen.FormattingEnabled = true; this.cbDangGioDen.Items.AddRange(new object[] {

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 221

"AM", "PM"}); this.cbDangGioDen.Location = new System.Drawing.Point(634, 69); this.cbDangGioDen.Name = "cbDangGioDen"; this.cbDangGioDen.Size = new System.Drawing.Size(55, 24); this.cbDangGioDen.TabIndex = 33; // // cbGioDen // this.cbGioDen.FormattingEnabled = true; this.cbGioDen.Items.AddRange(new object[] { "01:00", "01:30", "02:00", "02:30", "03:00", "03:30", "04:00", "04:30", "05:00", "05:30", "06:00", "06:30", "07:00", "07:30", "08:00", "08:30", "09:00", "09:30", "10:00", "10:30", "11:00", "11:30", "12:00", "12:30"}); this.cbGioDen.Location = new System.Drawing.Point(536, 69); this.cbGioDen.Name = "cbGioDen"; this.cbGioDen.Size = new System.Drawing.Size(101, 24); this.cbGioDen.TabIndex = 32; // // label12 // this.label12.AutoSize = true; this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); this.label12.Location = new System.Drawing.Point(463, 138); this.label12.Name = "label12"; this.label12.Size = new System.Drawing.Size(53, 20); this.label12.TabIndex = 31; this.label12.Text = "Giờ đi"; // // label11 // this.label11.AutoSize = true; this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); this.label11.Location = new System.Drawing.Point(463, 72); this.label11.Name = "label11"; this.label11.Size = new System.Drawing.Size(67, 20); this.label11.TabIndex = 30; this.label11.Text = "Giờ đến"; // // dtpNgayKT // this.dtpNgayKT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 222

this.dtpNgayKT.Location = new System.Drawing.Point(145, 133); this.dtpNgayKT.Name = "dtpNgayKT"; this.dtpNgayKT.Size = new System.Drawing.Size(267, 26); this.dtpNgayKT.TabIndex = 29; // // dtpNgayBD // this.dtpNgayBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); this.dtpNgayBD.Location = new System.Drawing.Point(145, 67); this.dtpNgayBD.Name = "dtpNgayBD"; this.dtpNgayBD.Size = new System.Drawing.Size(267, 26); this.dtpNgayBD.TabIndex = 28; // // label10 // this.label10.AutoSize = true; this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); this.label10.Location = new System.Drawing.Point(32, 133); this.label10.Name = "label10"; this.label10.Size = new System.Drawing.Size(111, 20); this.label10.TabIndex = 27; this.label10.Text = "Ngày kết thúc"; // // label9 // this.label9.AutoSize = true; this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); this.label9.Location = new System.Drawing.Point(32, 72); this.label9.Name = "label9"; this.label9.Size = new System.Drawing.Size(107, 20); this.label9.TabIndex = 26; this.label9.Text = "Ngày bắt đầu"; // // label8 // this.label8.AutoSize = true; this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))); this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))); this.label8.Location = new System.Drawing.Point(306, 8); this.label8.Name = "label8"; this.label8.Size = new System.Drawing.Size(210, 29); this.label8.TabIndex = 24; this.label8.Text = "Thông tin phòng"; // // btnDatPhong // this.btnDatPhong.BackColor = System.Drawing.SystemColors.ActiveCaption; this.btnDatPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))); this.btnDatPhong.ForeColor = System.Drawing.Color.ForestGreen; this.btnDatPhong.Location = new System.Drawing.Point(45, 496); this.btnDatPhong.Name = "btnDatPhong"; this.btnDatPhong.Size = new System.Drawing.Size(167, 42); this.btnDatPhong.TabIndex = 27; this.btnDatPhong.Text = "Đặt trước"; this.btnDatPhong.UseVisualStyleBackColor = false; // this.btnDatPhong.Click += new System.EventHandler(this.btnDatPhong_Click); // // button2

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 223

// this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); this.button2.Location = new System.Drawing.Point(227, 496); this.button2.Name = "button2"; this.button2.Size = new System.Drawing.Size(129, 42); this.button2.TabIndex = 28; this.button2.Text = "Hủy"; this.button2.UseVisualStyleBackColor = true; // // FormDatPhong // this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F); this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font; this.ClientSize = new System.Drawing.Size(1291, 575); this.Controls.Add(this.button2); this.Controls.Add(this.btnDatPhong); this.Controls.Add(this.panel2); this.Controls.Add(this.panel1); this.Controls.Add(this.label6); this.Name = "FormDatPhong"; this.Text = "Đặt phòng trước"; // this.Load += new System.EventHandler(this.FormDatPhong_Load); this.panel1.ResumeLayout(false); this.panel1.PerformLayout(); this.panel2.ResumeLayout(false); this.panel2.PerformLayout();

((System.ComponentModel.ISupportInitialize)(this.dtgDanhSachPhongDaChon)).EndInit();

((System.ComponentModel.ISupportInitialize)(this.dtgDanhSachPhongTrong)).EndInit(); this.ResumeLayout(false); this.PerformLayout();

}

#endregion private System.Windows.Forms.Label label6; private System.Windows.Forms.Panel panel1; private System.Windows.Forms.Label label4; private System.Windows.Forms.ComboBox cbGioiTinh; private System.Windows.Forms.Label label7; private System.Windows.Forms.TextBox txtSoDienThoai; private System.Windows.Forms.Label label3; private System.Windows.Forms.TextBox txtQuocTich; private System.Windows.Forms.Label label2; private System.Windows.Forms.TextBox txtCCCD; private System.Windows.Forms.Label label1; private System.Windows.Forms.TextBox txtHoVaTen; private System.Windows.Forms.Label label5; private System.Windows.Forms.Panel panel2; private System.Windows.Forms.ComboBox cbDangGioDi; private System.Windows.Forms.ComboBox cbGioDi; private System.Windows.Forms.ComboBox cbDangGioDen; private System.Windows.Forms.ComboBox cbGioDen; private System.Windows.Forms.Label label12; private System.Windows.Forms.Label label11; private System.Windows.Forms.DateTimePicker dtpNgayKT; private System.Windows.Forms.DateTimePicker dtpNgayBD; private System.Windows.Forms.Label label10; private System.Windows.Forms.Label label9; private System.Windows.Forms.Label label8; private System.Windows.Forms.DataGridView dtgDanhSachPhongDaChon; private System.Windows.Forms.DataGridView dtgDanhSachPhongTrong; private System.Windows.Forms.Button btnDatPhong; private System.Windows.Forms.Button button2;

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 224

private System.Windows.Forms.Label label14; private System.Windows.Forms.Label label13; } }

### Bước 3: SV sử dụng mã nguồn tạm thời sau để xử lý chức năng trong file

### FormDatPhong.cs

using System; using System.Collections.Generic; using System.ComponentModel; using System.Data; using System.Drawing; using System.Text; using System.Windows.Forms; using HotelManagement.DangNhap; using HotelManagement.Models; using Microsoft.EntityFrameworkCore;

namespace HotelManagement.SoDoPhong { public partial class FormDatPhong : Form { private readonly Image _iconThem = Properties.Resources.Add; private readonly Image _iconHuy = Properties.Resources.delete;

private bool _dangKhoiTao;

public FormDatPhong() { InitializeComponent();

StartPosition = FormStartPosition.CenterParent; FormBorderStyle = FormBorderStyle.FixedDialog; MaximizeBox = false; MinimizeBox = false; CancelButton = button2;

txtHoVaTen.MaxLength = 50; txtCCCD.MaxLength = 12; txtSoDienThoai.MaxLength = 10; txtQuocTich.MaxLength = 30;

cbGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList; cbGioDen.DropDownStyle = ComboBoxStyle.DropDownList; cbGioDi.DropDownStyle = ComboBoxStyle.DropDownList; cbDangGioDen.DropDownStyle = ComboBoxStyle.DropDownList; cbDangGioDi.DropDownStyle = ComboBoxStyle.DropDownList;

txtSoDienThoai.KeyPress += txtSoDienThoai_KeyPress; txtCCCD.TextChanged += txtCCCD_TextChanged;

dtpNgayBD.ValueChanged += dtpNgayBD_ValueChanged; dtpNgayKT.ValueChanged += ThayDoiThoiGian; cbGioDen.SelectedIndexChanged += ThayDoiThoiGian; cbDangGioDen.SelectedIndexChanged += ThayDoiThoiGian; cbGioDi.SelectedIndexChanged += ThayDoiThoiGian; cbDangGioDi.SelectedIndexChanged += ThayDoiThoiGian;

button2.Click += button2_Click; }

private void FormDatPhong_Load(object sender, EventArgs e) { _dangKhoiTao = true;

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 225

dtpNgayBD.MinDate = DateTime.Today; CapNhatNgayKetThucToiThieu();

cbGioDen.SelectedIndex = cbGioDen.FindStringExact("02:00"); cbDangGioDen.SelectedIndex = cbDangGioDen.FindStringExact("PM"); cbGioDi.SelectedIndex = cbGioDi.FindStringExact("12:00"); cbDangGioDi.SelectedIndex = cbDangGioDi.FindStringExact("PM");

KhoiTaoGridPhongTrong(); KhoiTaoGridPhongDaChon();

_dangKhoiTao = false;

LoadDanhSachPhongTrong(); }

private void KhoiTaoGridPhongTrong() { if (dtgDanhSachPhongTrong.Columns.Count > 0) return;

dtgDanhSachPhongTrong.ReadOnly = true; dtgDanhSachPhongTrong.AllowUserToAddRows = false; dtgDanhSachPhongTrong.AllowUserToDeleteRows = false; dtgDanhSachPhongTrong.AllowUserToResizeRows = false; dtgDanhSachPhongTrong.MultiSelect = false; dtgDanhSachPhongTrong.SelectionMode = DataGridViewSelectionMode.FullRowSelect; dtgDanhSachPhongTrong.RowHeadersVisible = false; dtgDanhSachPhongTrong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; dtgDanhSachPhongTrong.RowTemplate.Height = 32;

dtgDanhSachPhongTrong.Columns.Add("MaPH", "Mã phòng"); dtgDanhSachPhongTrong.Columns.Add("TenLPH", "Loại phòng"); dtgDanhSachPhongTrong.Columns.Add("SoNguoiToiDa", "Số người tối đa"); dtgDanhSachPhongTrong.Columns["SoNguoiToiDa"]!.Visible = false; dtgDanhSachPhongTrong.Columns.Add(TaoCotAnh("Them", "Thêm", _iconThem,

50. );

}

private void KhoiTaoGridPhongDaChon() { if (dtgDanhSachPhongDaChon.Columns.Count > 0) return;

dtgDanhSachPhongDaChon.ReadOnly = true; dtgDanhSachPhongDaChon.AllowUserToAddRows = false; dtgDanhSachPhongDaChon.AllowUserToDeleteRows = false; dtgDanhSachPhongDaChon.AllowUserToResizeRows = false; dtgDanhSachPhongDaChon.MultiSelect = false; dtgDanhSachPhongDaChon.SelectionMode = DataGridViewSelectionMode.FullRowSelect; dtgDanhSachPhongDaChon.RowHeadersVisible = false; dtgDanhSachPhongDaChon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; dtgDanhSachPhongDaChon.RowTemplate.Height = 32; dtgDanhSachPhongDaChon.AutoGenerateColumns = false;

dtgDanhSachPhongDaChon.Columns.Add("MaPhong", "Mã phòng"); dtgDanhSachPhongDaChon.Columns.Add("SoNguoiToiDa", "Số người tối đa"); dtgDanhSachPhongDaChon.Columns.Add("NgayBatDau", "Ngày bắt đầu"); dtgDanhSachPhongDaChon.Columns.Add("NgayKetThuc", "Ngày kết thúc"); dtgDanhSachPhongDaChon.Columns["NgayBatDau"]!.DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 226

dtgDanhSachPhongDaChon.Columns["NgayKetThuc"]!.DefaultCellStyle.Format = "dd/MM/yyyy HH:mm"; dtgDanhSachPhongDaChon.Columns.Add(TaoCotAnh("Huy", "Hủy", _iconHuy, 45)); }

private DataGridViewImageColumn TaoCotAnh(string ten, string tieuDe, Image anh, int doRong) { return new DataGridViewImageColumn { Name = ten, HeaderText = tieuDe, Image = anh, ImageLayout = DataGridViewImageCellLayout.Zoom, AutoSizeMode = DataGridViewAutoSizeColumnMode.None, Width = doRong, Resizable = DataGridViewTriState.False, SortMode = DataGridViewColumnSortMode.NotSortable }; }

private void CapNhatNgayKetThucToiThieu() { DateTime toiThieu = dtpNgayBD.Value.Date.AddDays(1);

if (dtpNgayKT.Value.Date < toiThieu) dtpNgayKT.Value = toiThieu;

dtpNgayKT.MinDate = toiThieu; }

private void dtpNgayBD_ValueChanged(object? sender, EventArgs e) { if (_dangKhoiTao) return;

CapNhatNgayKetThucToiThieu(); LoadDanhSachPhongTrong(); }

private void ThayDoiThoiGian(object? sender, EventArgs e) { if (_dangKhoiTao) return;

LoadDanhSachPhongTrong(); }

private void LoadDanhSachPhongTrong() { if (_dangKhoiTao) return;

try { DateTime checkIn = LayThoiGian(dtpNgayBD, cbGioDen, cbDangGioDen) ?? dtpNgayBD.Value.Date; DateTime checkOut = LayThoiGian(dtpNgayKT, cbGioDi, cbDangGioDi) ?? dtpNgayKT.Value.Date;

using var db = new HotelManagementContext();

var dsPhongTrong = db.Phongs .AsNoTracking() .Where(p => p.DaXoa != true && p.Ttph == "Bình thường" && !p.Ctdps.Any(c => c.DaXoa != true && c.CheckIn < checkOut && c.CheckOut > checkIn))

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 227

.OrderBy(p => p.MaPh) .Select(p => new { p.MaPh, TenLph = p.MaLphNavigation.TenLph, SoNguoiToiDa = p.MaLphNavigation.SoNguoiToiDa }) .ToList();

dtgDanhSachPhongTrong.Rows.Clear();

foreach (var p in dsPhongTrong) { dtgDanhSachPhongTrong.Rows.Add(p.MaPh, p.TenLph, p.SoNguoiToiDa, _iconThem); }

dtgDanhSachPhongTrong.CurrentCell = null; } catch (Exception ex) { MessageBox.Show("Lỗi tải danh sách phòng trống: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); } }

private void dtgDanhSachPhongTrong_CellClick(object sender, DataGridViewCellEventArgs e) { if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

if (dtgDanhSachPhongTrong.Columns[e.ColumnIndex].Name != "Them") return;

var dong = dtgDanhSachPhongTrong.Rows[e.RowIndex]; string? maPhong = dong.Cells["MaPH"].Value?.ToString();

if (string.IsNullOrEmpty(maPhong)) return;

foreach (DataGridViewRow daChon in dtgDanhSachPhongDaChon.Rows) { if (string.Equals(daChon.Cells["MaPhong"].Value?.ToString(), maPhong, StringComparison.OrdinalIgnoreCase)) { MessageBox.Show($"Phòng {maPhong} đã có trong danh sách phòng đã chọn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); return; } }

DateTime? checkIn = LayThoiGian(dtpNgayBD, cbGioDen, cbDangGioDen); DateTime? checkOut = LayThoiGian(dtpNgayKT, cbGioDi, cbDangGioDi);

if (checkIn == null || checkOut == null) { MessageBox.Show("Vui lòng chọn đầy đủ giờ đến và giờ đi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

if (checkOut.Value.Date <= checkIn.Value.Date) {

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 228

MessageBox.Show("Ngày trả phòng phải sau ngày nhận phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

int soNguoiToiDa = Convert.ToInt32(dong.Cells["SoNguoiToiDa"].Value);

dtgDanhSachPhongDaChon.Rows.Add(maPhong, soNguoiToiDa, checkIn.Value, checkOut.Value, _iconHuy); }

private DateTime? LayThoiGian(DateTimePicker dtp, ComboBox cbGio, ComboBox cbAMPM) { string? gio = cbGio.SelectedItem?.ToString(); string? ampm = cbAMPM.SelectedItem?.ToString();

if (string.IsNullOrEmpty(gio) || string.IsNullOrEmpty(ampm)) return null;

string[] phan = gio.Split(':');

if (phan.Length != 2 || !int.TryParse(phan[0], out int hour) || !int.TryParse(phan[1], out int minute)) return null;

if (ampm == "PM" && hour < 12) hour += 12; if (ampm == "AM" && hour == 12) hour = 0;

return dtp.Value.Date.AddHours(hour).AddMinutes(minute); }

private void dtgDanhSachPhongDaChon_CellClick(object sender, DataGridViewCellEventArgs e) { if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

if (dtgDanhSachPhongDaChon.Columns[e.ColumnIndex].Name == "Huy") { dtgDanhSachPhongDaChon.Rows.RemoveAt(e.RowIndex); } }

private void txtSoDienThoai_KeyPress(object? sender, KeyPressEventArgs e) { if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true; }

private void txtCCCD_TextChanged(object? sender, EventArgs e) { if (txtHoVaTen.Enabled) return;

txtHoVaTen.Clear(); txtSoDienThoai.Clear(); txtQuocTich.Clear(); cbGioiTinh.SelectedIndex = - 1; DatChoPhepNhapThongTinKhach(true); }

private void DatChoPhepNhapThongTinKhach(bool choPhep) { txtHoVaTen.Enabled = choPhep; txtSoDienThoai.Enabled = choPhep;

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 229

txtQuocTich.Enabled = choPhep; cbGioiTinh.Enabled = choPhep; }

private void button2_Click(object? sender, EventArgs e) { DialogResult = DialogResult.Cancel; this.Close(); }

private bool KiemTraVaDienThongTinKH(string cccd) { if (cccd.Length == 0) return false;

try { using var db = new HotelManagementContext();

var khachHang = db.KhachHangs .AsNoTracking() .Where(k => k.CccdPassport == cccd && k.DaXoa != true) .Select(k => new { k.TenKh, k.Sdt, k.QuocTich, k.GioiTinh }) .FirstOrDefault();

if (khachHang == null) return false;

txtHoVaTen.Text = khachHang.TenKh; txtSoDienThoai.Text = khachHang.Sdt; txtQuocTich.Text = khachHang.QuocTich; cbGioiTinh.SelectedIndex = cbGioiTinh.FindStringExact(khachHang.GioiTinh ?? "");

DatChoPhepNhapThongTinKhach(false);

return true; } catch (Exception ex) { MessageBox.Show("Lỗi kiểm tra thông tin khách hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return false; } }

private static string TaoMaTiepTheo(IEnumerable<string> cacMa, string tienTo, int soChuSo, int doDaiToiDa) { int lonNhat = 0;

foreach (string ma in cacMa) { if (ma.Length > tienTo.Length && ma.StartsWith(tienTo, StringComparison.OrdinalIgnoreCase) && int.TryParse(ma.Substring(tienTo.Length), out int so) && so > lonNhat) { lonNhat = so; } }

string maMoi = tienTo + (lonNhat + 1).ToString("D" + soChuSo);

if (maMoi.Length > doDaiToiDa)

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 230

throw new InvalidOperationException($"Đã hết mã có tiền tố {tienTo} (tối đa {doDaiToiDa} ký tự).");

return maMoi; }

private bool LuuPhieuThue() { string maNV = FormDangNhap.MaNV_DangNhap;

if (string.IsNullOrWhiteSpace(maNV)) { MessageBox.Show("Chưa xác định được nhân viên đang đăng nhập. Vui lòng đăng nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return false; }

string tenKH = txtHoVaTen.Text.Trim(); string cccd = txtCCCD.Text.Trim(); string sdt = txtSoDienThoai.Text.Trim(); string quocTich = txtQuocTich.Text.Trim(); string gioiTinh = cbGioiTinh.SelectedItem?.ToString() ?? "";

var cacPhongChon = new List<(string MaPH, int SoNguoi, DateTime CheckIn, DateTime CheckOut)>();

foreach (DataGridViewRow row in dtgDanhSachPhongDaChon.Rows) { if (row.IsNewRow) continue;

cacPhongChon.Add(( row.Cells["MaPhong"].Value?.ToString() ?? "", Convert.ToInt32(row.Cells["SoNguoiToiDa"].Value), Convert.ToDateTime(row.Cells["NgayBatDau"].Value), Convert.ToDateTime(row.Cells["NgayKetThuc"].Value))); }

try { using var db = new HotelManagementContext(); using var giaoDich = db.Database.BeginTransaction(IsolationLevel.Serializable);

var khachHang = db.KhachHangs.FirstOrDefault(k => k.CccdPassport == cccd); string maKH;

if (khachHang == null) { maKH = TaoMaTiepTheo(db.KhachHangs.Select(k => k.MaKh).ToList(), "KH", 3, 5);

db.KhachHangs.Add(new Models.KhachHang { MaKh = maKH, TenKh = tenKH, Sdt = sdt, CccdPassport = cccd, QuocTich = quocTich, GioiTinh = gioiTinh, DaXoa = false }); } else {

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 231

maKH = khachHang.MaKh;

if (khachHang.DaXoa == true) { khachHang.TenKh = tenKH; khachHang.Sdt = sdt; khachHang.QuocTich = quocTich; khachHang.GioiTinh = gioiTinh; khachHang.DaXoa = false; } }

string maPT = TaoMaTiepTheo(db.PhieuThues.Select(p => p.MaPt).ToList(), "PT", 3, 5);

db.PhieuThues.Add(new Models.PhieuThue { MaPt = maPT, NgPt = DateTime.Now, MaKh = maKH, MaNv = maNV, DaXoa = false });

db.SaveChanges();

var cacMaCtdp = db.Ctdps.Select(c => c.MaCtdp).ToList(); var cacPhongCapNhat = new List<Models.Phong>();

foreach (var phongChon in cacPhongChon) { string maPH = phongChon.MaPH; DateTime checkIn = phongChon.CheckIn; DateTime checkOut = phongChon.CheckOut;

var phong = db.Phongs .Include(p => p.MaLphNavigation) .FirstOrDefault(p => p.MaPh == maPH && p.DaXoa != true);

if (phong == null) { MessageBox.Show($"Không tìm thấy phòng {maPH}.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return false; }

if (phong.Ttph != "Bình thường") { MessageBox.Show($"Phòng {maPH} hiện ở trạng thái \ "{phong.Ttph} \ " nên không thể đặt.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }

bool biTrung = db.Ctdps.Any(c => c.MaPh == maPH && c.DaXoa != true && c.CheckIn < checkOut && c.CheckOut > checkIn);

if (biTrung) { MessageBox.Show($"Phòng {maPH} đã có người đặt trong khoảng thời gian này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 232

decimal donGia = phong.MaLphNavigation.GiaNgay; int soNgay = Math.Max(1, (checkOut.Date - checkIn.Date).Days);

string maCTDP = TaoMaTiepTheo(cacMaCtdp, "CTDP", 3, 7); cacMaCtdp.Add(maCTDP);

db.Ctdps.Add(new Models.Ctdp { MaCtdp = maCTDP, SoNguoi = phongChon.SoNguoi, MaPt = maPT, MaPh = maPH, CheckIn = checkIn, CheckOut = checkOut, TrangThai = "Đã đặt", DonGia = donGia, ThanhTien = donGia * soNgay, DaXoa = false, TheoGio = false });

db.SaveChanges();

if (!cacPhongCapNhat.Contains(phong)) cacPhongCapNhat.Add(phong); }

foreach (var phong in cacPhongCapNhat) { phong.Ttph = "Đã đặt"; }

db.SaveChanges(); giaoDich.Commit();

return true; } catch (DbUpdateException ex) { MessageBox.Show("Có lỗi xảy ra khi lưu phiếu thuê: " + (ex.InnerException?.Message ?? ex.Message), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return false; } catch (Exception ex) { MessageBox.Show("Có lỗi xảy ra khi lưu phiếu thuê: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return false; } }

private void btnDatPhong_Click(object sender, EventArgs e) { bool khachHangTonTai = KiemTraVaDienThongTinKH(txtCCCD.Text.Trim());

if (khachHangTonTai) { DialogResult result = MessageBox.Show( "Khách hàng đã tồn tại trong hệ thống. Thông tin sẽ được tự động điền và không thể sửa. \ nBạn có muốn tiếp tục đặt phòng không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

if (result == DialogResult.No) return; }

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 233

if (txtHoVaTen.Text.Trim().Length == 0) { MessageBox.Show("Vui lòng nhập họ và tên khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtHoVaTen.Focus(); return; }

if (txtCCCD.Text.Trim().Length == 0) { MessageBox.Show("Vui lòng nhập số CCCD/Passport!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtCCCD.Focus(); return; }

string sdt = txtSoDienThoai.Text.Trim();

if (sdt.Length == 0 || !sdt.All(char.IsDigit)) { MessageBox.Show("Vui lòng nhập số điện thoại hợp lệ (chỉ gồm chữ số)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtSoDienThoai.Focus(); return; }

if (txtQuocTich.Text.Trim().Length == 0) { MessageBox.Show("Vui lòng nhập quốc tịch!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtQuocTich.Focus(); return; }

if (cbGioiTinh.SelectedIndex == - 1) { MessageBox.Show("Vui lòng chọn giới tính!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); cbGioiTinh.Focus(); return; }

if (dtgDanhSachPhongDaChon.Rows.Count == 0) { MessageBox.Show("Vui lòng chọn ít nhất 1 phòng để đặt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

bool thanhCong = LuuPhieuThue();

if (thanhCong) { MessageBox.Show("Đặt phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); DialogResult = DialogResult.OK; this.Close(); } } } }

Lập trình trực quan

Ths. Nguyễn Thiện Dương Trang 234

Bước 4: SV sử dụng mã nguồn tạm thời sau để xử lý chức năng nút đặt phòng thuộc

hàm private void btnDatPhong_Click(object sender, EventArgs e)

trong file FormSoDoPhong.cs

private void btnDatPhong_Click ( object sender, EventArgs e) { string? maPhong = MaPhongDangChon (); // Phòng đang chọn trong lưới (có thể null)

using ( var fDatPhong = new FormDatPhong ()) { fDatPhong. ShowDialog (); }

TaiLaiDanhSach (); }

V. Chi tiết bài thực hành cho buổi 3

1. Xây dựng giao diện và chức năng quản lý thông tin dịch vụ sử dụng bởi khách

hàng khi đang thuê phòng

Bước 1: Click chuột phải vào thư mục project → Add → New Folder→ Đặt tên folder

là “PhieuThue”

Bước 2: Click chuột phải vào folder PhieuThue → Add → Forms( Windows Forms)

→ tạo một form cho phép xem lại thông tin đặt/thuê phòng trong khách sạn là

FormThemDichVuPhongDaDung.cs

Bước 3: Thiết kế giao diện FormThemDichVuPhongDaDung.cs theo mẫu như sau:

Mã nguồn tham khảo trong file FormThemDichVuPhongDaDung.Designer.cs tạm

thời như sau: namespace HotelManagement.PhieuThue { partial class FormThemDichVuPhongDaDung {

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 235

/// <summary> /// Required designer variable. /// </summary> private System.ComponentModel.IContainer components = null;

/// <summary> /// Clean up any resources being used. /// </summary> /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param> protected override void Dispose(bool disposing) { if (disposing && (components != null)) { components.Dispose(); } base.Dispose(disposing); }

#region Windows Form Designer generated code

/// <summary> /// Required method for Designer support - do not modify /// the contents of this method with the code editor. /// </summary> private void InitializeComponent() { btnThoat = new Button(); btnThemDV = new Button(); lbSoCTPhieu = new Label(); lbSoPhong = new Label(); pictureBox2 = new PictureBox(); pictureBox1 = new PictureBox(); LabelThemTienNghi = new Label(); label1 = new Label(); txtMaDV = new TextBox(); label2 = new Label(); cbTenDV = new ComboBox(); label3 = new Label(); txtSoLuong = new TextBox(); txtDonGia = new TextBox(); label4 = new Label(); lbThanhTien = new Label(); panel1 = new Panel(); ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit(); ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit(); SuspendLayout(); // // btnThoat // btnThoat.BackColor = SystemColors.GradientActiveCaption; btnThoat.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); btnThoat.Location = new Point(492, 548); btnThoat.Margin = new Padding(3, 4, 3, 4); btnThoat.Name = "btnThoat"; btnThoat.Size = new Size(137, 59); btnThoat.TabIndex = 34; btnThoat.Text = "OK"; btnThoat.UseVisualStyleBackColor = false; btnThoat.Click += btnThoat_Click; // // btnThemDV // btnThemDV.BackColor = Color.Orchid;

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 236

btnThemDV.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); btnThemDV.Location = new Point(238, 548); btnThemDV.Margin = new Padding(3, 4, 3, 4); btnThemDV.Name = "btnThemDV"; btnThemDV.Size = new Size(193, 59); btnThemDV.TabIndex = 33; btnThemDV.Text = "Thêm dịch vụ"; btnThemDV.UseVisualStyleBackColor = false; btnThemDV.Click += btnThemDV_Click; // // lbSoCTPhieu // lbSoCTPhieu.AutoSize = true; lbSoCTPhieu.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold, GraphicsUnit.Point, 0); lbSoCTPhieu.ForeColor = Color.Green; lbSoCTPhieu.Location = new Point(487, 101); lbSoCTPhieu.Name = "lbSoCTPhieu"; lbSoCTPhieu.Size = new Size(76, 26); lbSoCTPhieu.TabIndex = 31; lbSoCTPhieu.Text = "label2"; // // lbSoPhong // lbSoPhong.AutoSize = true; lbSoPhong.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold, GraphicsUnit.Point, 0); lbSoPhong.ForeColor = Color.FromArgb(192, 64, 0); lbSoPhong.Location = new Point(86, 101); lbSoPhong.Name = "lbSoPhong"; lbSoPhong.Size = new Size(76, 26); lbSoPhong.TabIndex = 30; lbSoPhong.Text = "label1"; // // pictureBox2 // pictureBox2.Image = Properties.Resources.PhieuThue; pictureBox2.Location = new Point(438, 84); pictureBox2.Margin = new Padding(3, 4, 3, 4); pictureBox2.Name = "pictureBox2"; pictureBox2.Size = new Size(43, 59); pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage; pictureBox2.TabIndex = 29; pictureBox2.TabStop = false; // // pictureBox1 // pictureBox1.Image = Properties.Resources.Phong; pictureBox1.Location = new Point(16, 84); pictureBox1.Margin = new Padding(3, 4, 3, 4); pictureBox1.Name = "pictureBox1"; pictureBox1.Size = new Size(64, 59); pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; pictureBox1.TabIndex = 28; pictureBox1.TabStop = false; // // LabelThemTienNghi // LabelThemTienNghi.AutoSize = true; LabelThemTienNghi.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0); LabelThemTienNghi.ForeColor = Color.FromArgb(192, 0, 0); LabelThemTienNghi.Location = new Point(218, 11); LabelThemTienNghi.Margin = new Padding(4, 0, 4, 0); LabelThemTienNghi.Name = "LabelThemTienNghi";

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 237

LabelThemTienNghi.Size = new Size(346, 46); LabelThemTienNghi.TabIndex = 27; LabelThemTienNghi.Text = "Thêm dịch vụ phòng"; // // label1 // label1.AutoSize = true; label1.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0); label1.Location = new Point(107, 195); label1.Name = "label1"; label1.Size = new Size(117, 26); label1.TabIndex = 35; label1.Text = "Mã dịch vụ"; // // txtMaDV // txtMaDV.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0); txtMaDV.Location = new Point(230, 191); txtMaDV.Margin = new Padding(3, 4, 3, 4); txtMaDV.Name = "txtMaDV"; txtMaDV.ReadOnly = true; txtMaDV.Size = new Size(147, 32); txtMaDV.TabIndex = 36; // // label2 // label2.AutoSize = true; label2.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0); label2.Location = new Point(447, 199); label2.Name = "label2"; label2.Size = new Size(123, 26); label2.TabIndex = 37; label2.Text = "Tên dịch vụ"; // // cbTenDV // cbTenDV.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0); cbTenDV.FormattingEnabled = true; cbTenDV.Location = new Point(577, 196); cbTenDV.Margin = new Padding(3, 4, 3, 4); cbTenDV.Name = "cbTenDV"; cbTenDV.Size = new Size(220, 34); cbTenDV.TabIndex = 38; cbTenDV.SelectedIndexChanged += cbTenDV_SelectedIndexChanged; // // label3 // label3.AutoSize = true; label3.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0); label3.Location = new Point(126, 309); label3.Name = "label3"; label3.Size = new Size(98, 26); label3.TabIndex = 39; label3.Text = "Số lượng"; // // txtSoLuong // txtSoLuong.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0); txtSoLuong.Location = new Point(230, 309); txtSoLuong.Margin = new Padding(3, 4, 3, 4);

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 238

txtSoLuong.Name = "txtSoLuong"; txtSoLuong.Size = new Size(147, 32); txtSoLuong.TabIndex = 40; txtSoLuong.TextChanged += txtSoLuong_TextChanged; // // txtDonGia // txtDonGia.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0); txtDonGia.Location = new Point(577, 309); txtDonGia.Margin = new Padding(3, 4, 3, 4); txtDonGia.Name = "txtDonGia"; txtDonGia.ReadOnly = true; txtDonGia.Size = new Size(220, 32); txtDonGia.TabIndex = 42; // // label4 // label4.AutoSize = true; label4.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0); label4.Location = new Point(476, 316); label4.Name = "label4"; label4.Size = new Size(87, 26); label4.TabIndex = 41; label4.Text = "Đơn giá"; // // lbThanhTien // lbThanhTien.AutoSize = true; lbThanhTien.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0); lbThanhTien.ForeColor = Color.FromArgb(192, 0, 0); lbThanhTien.Location = new Point(269, 432); lbThanhTien.Margin = new Padding(4, 0, 4, 0); lbThanhTien.Name = "lbThanhTien"; lbThanhTien.Size = new Size(208, 46); lbThanhTien.TabIndex = 43; lbThanhTien.Text = "Thành tiền: "; // // panel1 // panel1.Location = new Point(13, 168); panel1.Margin = new Padding(3, 4, 3, 4); panel1.Name = "panel1"; panel1.Size = new Size(862, 361); panel1.TabIndex = 44; // // FormThemDichVuPhongDaDung // AutoScaleDimensions = new SizeF(8F, 20F); AutoScaleMode = AutoScaleMode.Font; ClientSize = new Size(887, 621); Controls.Add(lbThanhTien); Controls.Add(txtDonGia); Controls.Add(label4); Controls.Add(txtSoLuong); Controls.Add(label3); Controls.Add(cbTenDV); Controls.Add(label2); Controls.Add(txtMaDV); Controls.Add(label1); Controls.Add(btnThoat); Controls.Add(btnThemDV); Controls.Add(lbSoCTPhieu); Controls.Add(lbSoPhong);

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 239

Controls.Add(pictureBox2); Controls.Add(pictureBox1); Controls.Add(LabelThemTienNghi); Controls.Add(panel1); Margin = new Padding(3, 4, 3, 4); Name = "FormThemDichVuPhongDaDung"; Text = "Thêm dịch vụ đã dùng theo phòng"; Load += FormThemDichVuPhongDaDung_Load; ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit(); ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit(); ResumeLayout(false); PerformLayout();

}

#endregion

private System.Windows.Forms.Button btnThoat; private System.Windows.Forms.Button btnThemDV; private System.Windows.Forms.Label lbSoCTPhieu; private System.Windows.Forms.Label lbSoPhong; private System.Windows.Forms.PictureBox pictureBox2; private System.Windows.Forms.PictureBox pictureBox1; private System.Windows.Forms.Label LabelThemTienNghi; private System.Windows.Forms.Label label1; private System.Windows.Forms.TextBox txtMaDV; private System.Windows.Forms.Label label2; private System.Windows.Forms.ComboBox cbTenDV; private System.Windows.Forms.Label label3; private System.Windows.Forms.TextBox txtSoLuong; private System.Windows.Forms.TextBox txtDonGia; private System.Windows.Forms.Label label4; private System.Windows.Forms.Label lbThanhTien; private System.Windows.Forms.Panel panel1; } }

### Bước 4: SV sử dụng mã nguồn tạm thời sau để xử lý chức năng trong file

### FormThemDichVuPhongDaDung.cs

using System; using System.Collections.Generic; using System.ComponentModel; using System.Data; using System.Drawing; using System.Linq; using System.Text; using System.Windows.Forms; using HotelManagement.Models; using Microsoft.EntityFrameworkCore;

namespace HotelManagement.PhieuThue { public partial class FormThemDichVuPhongDaDung: Form { private sealed class MucDichVu { public string MaDV { get; set; } = ""; public string TenDV { get; set; } = ""; public decimal DonGia { get; set; } public int? SLConLai { get; set; } }

private List<MucDichVu> _danhSachDichVu = new List<MucDichVu>(); private bool _dangNapDuLieu;

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 240

[Browsable( false)] [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)] public string? MaChiTietDatPhong { get; set; }

[Browsable( false)] [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)] public string? MaPhong { get; set; }

public FormThemDichVuPhongDaDung () { InitializeComponent();

StartPosition = FormStartPosition.CenterParent; FormBorderStyle = FormBorderStyle.FixedDialog; MaximizeBox = false; MinimizeBox = false; AcceptButton = btnThemDV; CancelButton = btnThoat;

cbTenDV.DropDownStyle = ComboBoxStyle.DropDownList; txtSoLuong.MaxLength = 6; txtSoLuong.KeyPress += txtSoLuong_KeyPress; }

private void FormThemDichVuPhongDaDung_Load ( object sender, EventArgs e) { if ( string.IsNullOrEmpty(MaChiTietDatPhong) || string.IsNullOrEmpty(MaPhong)) { MessageBox.Show( "Chưa xác định được chi tiết phiếu thuê cần thêm dịch vụ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); btnThemDV.Enabled = false; return; }

lbSoCTPhieu.Text = "Mã CTDP: " + MaChiTietDatPhong; lbSoPhong.Text = "Số phòng: " + MaPhong; lbThanhTien.Text = "Thành tiền: 0";

try { using var db = new HotelManagementContext();

_danhSachDichVu = db.DichVus .AsNoTracking() .Where( d => d.DaXoa != true) .OrderBy( d => d.TenDv) .Select( d => new MucDichVu { MaDV = d.MaDv, TenDV = d.TenDv, DonGia = d.DonGia, SLConLai = d.SlconLai }) .ToList();

_dangNapDuLieu = true; cbTenDV.DataSource = null; cbTenDV.DisplayMember = "TenDV"; cbTenDV.ValueMember = "MaDV"; cbTenDV.DataSource = _danhSachDichVu; cbTenDV.SelectedIndex = - 1; _dangNapDuLieu = false;

txtMaDV.Text = "";

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 241

txtDonGia.Text = ""; } catch (Exception ex) { _dangNapDuLieu = false; MessageBox.Show( "Lỗi tải danh sách dịch vụ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); btnThemDV.Enabled = false; } }

private MucDichVu? LayDichVuDangChon () { return cbTenDV.SelectedItem as MucDichVu; }

private void cbTenDV_SelectedIndexChanged ( object sender, EventArgs e) { if (_dangNapDuLieu) return;

var dv = LayDichVuDangChon();

if (dv == null) { txtMaDV.Text = ""; txtDonGia.Text = ""; } else { txtMaDV.Text = dv.MaDV; txtDonGia.Text = dv.DonGia.ToString( "N0"); }

TinhThanhTien(); }

private void txtSoLuong_KeyPress ( object? sender, KeyPressEventArgs e) { if (! char.IsControl(e.KeyChar) && ! char.IsDigit(e.KeyChar)) e.Handled = true; }

private void txtSoLuong_TextChanged ( object sender, EventArgs e) { TinhThanhTien(); }

private void TinhThanhTien () { var dv = LayDichVuDangChon();

if (dv != null && int.TryParse(txtSoLuong.Text, out int soLuong) && soLuong > 0) { decimal thanhTien = soLuong * dv.DonGia; lbThanhTien.Text = "Thành tiền: " + thanhTien. ToString ( "N0"); } else { lbThanhTien.Text = "Thành tiền: 0"; } }

private void btnThemDV_Click ( object sender, EventArgs e) {

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 242

string? maCTDP = MaChiTietDatPhong;

if ( string. IsNullOrEmpty ( maCTDP)) { MessageBox. Show( "Chưa xác định được chi tiết phiếu thuê.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

var dichVuChon = LayDichVuDangChon ();

if ( dichVuChon == null) { MessageBox. Show( "Vui lòng chọn dịch vụ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); cbTenDV. Focus (); return; }

if (! int. TryParse (txtSoLuong.Text, out int soLuong) || soLuong <= 0) { MessageBox. Show( "Số lượng không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtSoLuong. Focus (); return; }

string maDV = dichVuChon.MaDV;

try { using var db = new HotelManagementContext ();

var chiTietPhong = db.Ctdps . AsNoTracking () . Where( c => c.MaCtdp == maCTDP && c.DaXoa != true) . Select ( c => new { c.TrangThai }) . FirstOrDefault ();

if ( chiTietPhong == null) { MessageBox. Show( "Không tìm thấy chi tiết phiếu thuê " + maCTDP + ".", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

if ( chiTietPhong.TrangThai != "Đang thuê") { MessageBox. Show( "Chỉ có thể thêm dịch vụ cho phòng đang thuê!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

var dichVu = db.DichVus. FirstOrDefault ( d => d.MaDv == maDV && d.DaXoa != true);

if ( dichVu == null) { MessageBox. Show( "Dịch vụ không còn tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

bool gioiHanSoLuong = dichVu.SlconLai.HasValue && dichVu.SlconLai.Value >= 0;

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 243

if ( gioiHanSoLuong && soLuong > dichVu.SlconLai!.Value) { MessageBox. Show( $"Dịch vụ \ " { dichVu.TenDv} \ " chỉ còn { dichVu.SlconLai.Value} phần.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtSoLuong. Focus (); return; }

var daCo = db.Ctdvs. FirstOrDefault ( v => v.MaCtdp == maCTDP && v.MaDv == maDV);

if ( daCo == null) { db.Ctdvs. Add( new Ctdv { MaCtdp = maCTDP, MaDv = maDV, Sl = soLuong, ThanhTien = soLuong * dichVu.DonGia, DaXoa = false }); } else if ( daCo.DaXoa == true) { daCo.Sl = soLuong; daCo.ThanhTien = soLuong * dichVu.DonGia; daCo.DaXoa = false; } else { daCo.Sl += soLuong; daCo.ThanhTien = daCo.Sl * dichVu.DonGia; }

if ( gioiHanSoLuong) dichVu.SlconLai = dichVu.SlconLai!.Value - soLuong;

db. SaveChanges ();

MessageBox. Show( "Thêm dịch vụ thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

DialogResult = DialogResult.OK; this. Close (); } catch ( DbUpdateException ex) { MessageBox. Show( "Thêm thất bại: " + ( ex.InnerException?.Message ?? ex.Message), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); } catch ( Exception ex) { MessageBox. Show( "Thêm thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); } }

private void btnThoat_Click ( object sender, EventArgs e) { DialogResult = DialogResult.Cancel; this. Close (); } } }

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 244

### 2. Xây dựng giao diện và chức năng quản lý thông tin đặt phiếu đặt phòng/thuê

### phòng tại khách sạn

### Bước 1: Click chuột phải vào folder PhieuThue → Add → Forms( Windows Forms)

### → tạo một form cho phép xem lại thông tin đặt/thuê phòng trong khách sạn là

### FormSuaChiTietPhieuThue.cs

### Bước 2: Thiết kế giao diện FormSuaChiTietPhieuThue.cs theo mẫu như sau:

### Mã nguồn tham khảo trong file FormSuaChiTietPhieuThue.Designer.cs tạm thời như

### sau:

namespace HotelManagement.PhieuThue { partial class FormSuaChiTietPhieuThue { /// <summary> /// Required designer variable. /// </summary> private System.ComponentModel. IContainer components = null;

/// <summary> /// Clean up any resources being used. /// </summary> /// <param name=" disposing "> true if managed resources should be disposed; otherwise, false. </param> protected override void Dispose ( bool disposing) { if ( disposing && (components != null)) { components. Dispose (); } base. Dispose ( disposing); }

#region Windows Form Designer generated code

/// <summary> /// Required method for Designer support - do not modify /// the contents of this method with the code editor. /// </summary> private void InitializeComponent () { lbMaCTDP = new Label (); btnThoat = new Button (); btnCapNhat = new Button (); cbTrangThaiCTDP = new ComboBox ();

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 245

label1 = new Label (); SuspendLayout (); // // lbMaCTDP // lbMaCTDP.AutoSize = true; lbMaCTDP.Font = new Font( "Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, 0); lbMaCTDP.ForeColor = Color.FromArgb(192, 64, 0); lbMaCTDP.Location = new Point(145, 30); lbMaCTDP.Name = "lbMaCTDP"; lbMaCTDP.Size = new Size(718, 31); lbMaCTDP.TabIndex = 19; lbMaCTDP.Text = "Cập nhật thông chi tiết phiếu thuê {mã CT phiếu thuê}"; // // btnThoat // btnThoat.BackColor = SystemColors.GradientActiveCaption; btnThoat.Font = new Font( "Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); btnThoat.Location = new Point(512, 232); btnThoat.Margin = new Padding(3, 4, 3, 4); btnThoat.Name = "btnThoat"; btnThoat.Size = new Size(137, 59); btnThoat.TabIndex = 18; btnThoat.Text = "Thoát"; btnThoat.UseVisualStyleBackColor = false; btnThoat.Click += btnThoat_Click; // // btnCapNhat // btnCapNhat.BackColor = Color.Moccasin; btnCapNhat.Font = new Font( "Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); btnCapNhat.Location = new Point(301, 232); btnCapNhat.Margin = new Padding(3, 4, 3, 4); btnCapNhat.Name = "btnCapNhat"; btnCapNhat.Size = new Size(137, 59); btnCapNhat.TabIndex = 17; btnCapNhat.Text = "Cập nhật"; btnCapNhat.UseVisualStyleBackColor = false; btnCapNhat.Click += btnCapNhat_Click; // // cbTrangThaiCTDP // cbTrangThaiCTDP.Font = new Font( "Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); cbTrangThaiCTDP.FormattingEnabled = true; cbTrangThaiCTDP.Items.AddRange( new object [] { "Đang thuê", "Đã thanh toán" }); cbTrangThaiCTDP.Location = new Point(411, 116); cbTrangThaiCTDP.Margin = new Padding(3, 4, 3, 4); cbTrangThaiCTDP.Name = "cbTrangThaiCTDP"; cbTrangThaiCTDP.Size = new Size(275, 33); cbTrangThaiCTDP.TabIndex = 21; // // label1 // label1.AutoSize = true; label1.Font = new Font ( "Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0); label1.Location = new Point (281, 125); label1.Name = "label1"; label1.Size = new Size (108, 26); label1.TabIndex = 20; label1.Text = "Trạng thái";

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 246

// // FormSuaChiTietPhieuThue // AutoScaleDimensions = new SizeF (8F, 20F); AutoScaleMode = AutoScaleMode.Font; ClientSize = new Size (959, 345); Controls. Add(cbTrangThaiCTDP); Controls. Add(label1); Controls. Add(lbMaCTDP); Controls. Add(btnThoat); Controls. Add(btnCapNhat); Margin = new Padding (3, 4, 3, 4); Name = "FormSuaChiTietPhieuThue"; Text = "FormSuaChiTietPhieuThue"; ResumeLayout ( false); PerformLayout ();

}

#endregion

private System.Windows.Forms. Label lbMaCTDP; private System.Windows.Forms. Button btnThoat; private System.Windows.Forms. Button btnCapNhat; private System.Windows.Forms. ComboBox cbTrangThaiCTDP; private System.Windows.Forms. Label label1; } }

### Bước 3: SV sử dụng mã nguồn tạm thời sau để xử lý chức năng trong file

### FormSuaChiTietPhieuThue.cs

using System; using System.Collections.Generic; using System.ComponentModel; using System.Data; using System.Drawing; using System.Linq; using System.Text; using System.Windows.Forms; using HotelManagement.Models; using Microsoft.EntityFrameworkCore;

namespace HotelManagement.PhieuThue { public partial class FormSuaChiTietPhieuThue: Form { private string? _maCtdp; private string? _trangThaiHienTai;

[Browsable( false)] [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)] public string? MaPhieuThue { get; set; }

[Browsable( false)] [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)] public string? MaPhong { get; set; }

public FormSuaChiTietPhieuThue () { InitializeComponent();

StartPosition = FormStartPosition.CenterParent; FormBorderStyle = FormBorderStyle.FixedDialog; MaximizeBox = false;

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 247

MinimizeBox = false; AcceptButton = btnCapNhat; CancelButton = btnThoat;

cbTrangThaiCTDP.DropDownStyle = ComboBoxStyle.DropDownList; if (cbTrangThaiCTDP.Items.Count > 0) cbTrangThaiCTDP.SelectedIndex = 0;

Load += FormSuaChiTietPhieuThue_Load; }

private void FormSuaChiTietPhieuThue_Load ( object? sender, EventArgs e) { string? maPT = MaPhieuThue; string? maPH = MaPhong;

if ( string. IsNullOrEmpty ( maPT) || string. IsNullOrEmpty ( maPH)) { MessageBox. Show( "Chưa xác định được chi tiết phiếu thuê cần cập nhật.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); btnCapNhat.Enabled = false; return; }

try { using var db = new HotelManagementContext ();

var chiTiet = db.Ctdps . AsNoTracking () . Where( c => c.MaPt == maPT && c.MaPh == maPH && c.DaXoa != true) . OrderByDescending ( c => c.MaCtdp) . Select ( c => new { c.MaCtdp, c.TrangThai }) . FirstOrDefault ();

if ( chiTiet == null) { MessageBox. Show( "Không tìm thấy chi tiết phiếu thuê của phòng " + maPH + ".", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); btnCapNhat.Enabled = false; return; }

_maCtdp = chiTiet.MaCtdp; _trangThaiHienTai = chiTiet.TrangThai;

lbMaCTDP.Text = "Cập nhật trạng thái CTDP " + _maCtdp;

int viTri = cbTrangThaiCTDP.Items. IndexOf (_trangThaiHienTai ?? ""); cbTrangThaiCTDP.SelectedIndex = viTri >= 0 ? viTri: 0; } catch ( Exception ex) { MessageBox. Show( "Lỗi tải thông tin chi tiết phiếu thuê: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); btnCapNhat.Enabled = false; } }

private void btnCapNhat_Click ( object sender, EventArgs e) { if ( string. IsNullOrEmpty (_maCtdp)) { MessageBox. Show( "Chưa xác định được chi tiết phiếu thuê cần cập nhật.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 248

return; }

string? trangThaiMoi = cbTrangThaiCTDP.SelectedItem?. ToString ();

if ( string. IsNullOrEmpty ( trangThaiMoi)) { MessageBox. Show( "Vui lòng chọn trạng thái!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); cbTrangThaiCTDP. Focus (); return; }

try { using var db = new HotelManagementContext ();

var chiTiet = db.Ctdps. FirstOrDefault ( c => c.MaCtdp == _maCtdp && c.DaXoa != true);

if ( chiTiet == null) { MessageBox. Show( "Không tìm thấy chi tiết phiếu thuê cần cập nhật.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

if ( chiTiet.TrangThai != "Đã đặt" && chiTiet.TrangThai != "Đang thuê") { MessageBox. Show( "Chỉ có thể cập nhật chi tiết phiếu đang ở trạng thái \ " Đã đặt \ " hoặc \ "Đang thuê \ "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

if ( chiTiet.TrangThai == trangThaiMoi) { MessageBox. Show( "Trạng thái không thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }

chiTiet.TrangThai = trangThaiMoi;

var phong = db.Phongs. FirstOrDefault ( p => p.MaPh == chiTiet.MaPh);

if ( phong!= null) { if ( trangThaiMoi == "Đang thuê") { phong.Ttph = "Đang thuê"; } else if ( trangThaiMoi == "Đã thanh toán") { bool conPhieuKhac = db.Ctdps. Any ( c => c.MaPh == chiTiet.MaPh && c.MaCtdp != chiTiet.MaCtdp && c.DaXoa != true && ( c.TrangThai == "Đã đặt" || c.TrangThai == "Đang thuê"));

if (! conPhieuKhac && ( phong.Ttph == "Đang thuê" || phong.Ttph == "Đã đặt")) phong.Ttph = "Bình thường"; } }

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 249

db. SaveChanges ();

MessageBox. Show( "Cập nhật trạng thái thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

DialogResult = DialogResult.OK; this. Close (); } catch ( DbUpdateException ex) { MessageBox. Show( "Lỗi khi cập nhật: " + ( ex.InnerException?.Message ?? ex.Message), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); } catch ( Exception ex) { MessageBox. Show( "Lỗi khi cập nhật: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); } }

private void btnThoat_Click ( object sender, EventArgs e) { DialogResult = DialogResult.Cancel; this. Close (); } } }

### Bước 3: Chỉnh sửa lại hàm private void button9_Click(object sender,

### EventArgs e)trong file FormMain.cs theo nội dung như sau:

private void button9_Click ( object sender, EventArgs e) { Form formCon = new PhieuThue. FormDanhSachPhieuThue (); formCon.TopLevel = false; formCon.FormBorderStyle = FormBorderStyle.None; formCon.Dock = DockStyle.Fill; XoaNoiDungPanelMain (); panelMain.Controls. Add( formCon); formCon. Show(); }

### Bước 4: Click chuột phải vào folder PhieuThue → Add → Forms( Windows Forms)

### → tạo một form cho phép xem lại thông tin đặt/thuê phòng trong khách sạn là

### FormDanhSachDichVuPhongDaDung.cs

### Bước 5: Thiết kế giao diện FormDanhSachDichVuPhongDaDung.cs theo mẫu như

### sau:

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 250

### Mã nguồn tham khảo trong file FormDanhSachDichVuPhongDaDung.Designer.cs

### tạm thời như sau:

namespace HotelManagement.PhieuThue { partial class FormDanhSachDichVuPhongDaDung { /// <summary> /// Required designer variable. /// </summary> private System.ComponentModel. IContainer components = null;

/// <summary> /// Clean up any resources being used. /// </summary> /// <param name=" disposing "> true if managed resources should be disposed; otherwise, false. </param> protected override void Dispose ( bool disposing) { if ( disposing && (components != null)) { components. Dispose (); } base. Dispose ( disposing); }

#region Windows Form Designer generated code

/// <summary> /// Required method for Designer support - do not modify /// the contents of this method with the code editor. /// </summary> private void InitializeComponent () { LabelThemTienNghi = new Label (); lbSoPhong = new Label (); lbSoCTPhieu = new Label (); dtgDanhSachDichVu = new DataGridView (); btnThemDV = new Button (); btnThoat = new Button (); pictureBox2 = new PictureBox (); pictureBox1 = new PictureBox (); ((System.ComponentModel. ISupportInitialize)dtgDanhSachDichVu). BeginInit ();

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 251

((System.ComponentModel. ISupportInitialize)pictureBox2). BeginInit (); ((System.ComponentModel. ISupportInitialize)pictureBox1). BeginInit (); SuspendLayout (); // // LabelThemTienNghi // LabelThemTienNghi.AutoSize = true; LabelThemTienNghi.Font = new Font ( "Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0); LabelThemTienNghi.ForeColor = Color. FromArgb (192, 0, 0); LabelThemTienNghi.Location = new Point (214, 11); LabelThemTienNghi.Margin = new Padding (4, 0, 4, 0); LabelThemTienNghi.Name = "LabelThemTienNghi"; LabelThemTienNghi.Size = new Size (448, 46); LabelThemTienNghi.TabIndex = 19; LabelThemTienNghi.Text = "Danh sách dịch vụ đã dùng"; // // lbSoPhong // lbSoPhong.AutoSize = true; lbSoPhong.Font = new Font ( "Microsoft Sans Serif", 13F, FontStyle.Bold, GraphicsUnit.Point, 0); lbSoPhong.ForeColor = Color. FromArgb (192, 64, 0); lbSoPhong.Location = new Point (82, 101); lbSoPhong.Name = "lbSoPhong"; lbSoPhong.Size = new Size (76, 26); lbSoPhong.TabIndex = 22; lbSoPhong.Text = "label1"; // // lbSoCTPhieu // lbSoCTPhieu.AutoSize = true; lbSoCTPhieu.Font = new Font ( "Microsoft Sans Serif", 13F, FontStyle.Bold, GraphicsUnit.Point, 0); lbSoCTPhieu.ForeColor = Color.Green; lbSoCTPhieu.Location = new Point (483, 101); lbSoCTPhieu.Name = "lbSoCTPhieu"; lbSoCTPhieu.Size = new Size (76, 26); lbSoCTPhieu.TabIndex = 23; lbSoCTPhieu.Text = "label2"; // // dtgDanhSachDichVu // dtgDanhSachDichVu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize; dtgDanhSachDichVu.Location = new Point (12, 166); dtgDanhSachDichVu.Margin = new Padding (3, 4, 3, 4); dtgDanhSachDichVu.Name = "dtgDanhSachDichVu"; dtgDanhSachDichVu.RowHeadersWidth = 51; dtgDanhSachDichVu.RowTemplate.Height = 24; dtgDanhSachDichVu.Size = new Size (859, 391); dtgDanhSachDichVu.TabIndex = 24; // // btnThemDV // btnThemDV.BackColor = Color.Orchid; btnThemDV.Font = new Font ( "Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); btnThemDV.Location = new Point (180, 584); btnThemDV.Margin = new Padding (3, 4, 3, 4); btnThemDV.Name = "btnThemDV"; btnThemDV.Size = new Size (193, 59); btnThemDV.TabIndex = 25; btnThemDV.Text = "Thêm dịch vụ"; btnThemDV.UseVisualStyleBackColor = false; btnThemDV.Click += btnThemDV_Click;

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 252

// // btnThoat // btnThoat.BackColor = SystemColors.GradientActiveCaption; btnThoat.Font = new Font ( "Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); btnThoat.Location = new Point (434, 584); btnThoat.Margin = new Padding (3, 4, 3, 4); btnThoat.Name = "btnThoat"; btnThoat.Size = new Size (137, 59); btnThoat.TabIndex = 26; btnThoat.Text = "OK"; btnThoat.UseVisualStyleBackColor = false; btnThoat.Click += btnThoat_Click; // // pictureBox2 // pictureBox2.Image = Properties. Resources.PhieuThue; pictureBox2.Location = new Point (434, 84); pictureBox2.Margin = new Padding (3, 4, 3, 4); pictureBox2.Name = "pictureBox2"; pictureBox2.Size = new Size (43, 59); pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage; pictureBox2.TabIndex = 21; pictureBox2.TabStop = false; // // pictureBox1 // pictureBox1.Image = Properties. Resources.Phong; pictureBox1.Location = new Point (12, 84); pictureBox1.Margin = new Padding (3, 4, 3, 4); pictureBox1.Name = "pictureBox1"; pictureBox1.Size = new Size (64, 59); pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; pictureBox1.TabIndex = 20; pictureBox1.TabStop = false; // // FormDanhSachDichVuPhongDaDung // AutoScaleDimensions = new SizeF (8F, 20F); AutoScaleMode = AutoScaleMode.Font; ClientSize = new Size (883, 658); Controls. Add(btnThoat); Controls. Add(btnThemDV); Controls. Add(dtgDanhSachDichVu); Controls. Add(lbSoCTPhieu); Controls. Add(lbSoPhong); Controls. Add(pictureBox2); Controls. Add(pictureBox1); Controls. Add(LabelThemTienNghi); Margin = new Padding (3, 4, 3, 4); Name = "FormDanhSachDichVuPhongDaDung"; StartPosition = FormStartPosition.CenterScreen; Text = "Quản lý dịch vụ đã dùng theo phòng"; ((System.ComponentModel. ISupportInitialize)dtgDanhSachDichVu). EndInit (); ((System.ComponentModel. ISupportInitialize)pictureBox2). EndInit (); ((System.ComponentModel. ISupportInitialize)pictureBox1). EndInit (); ResumeLayout ( false); PerformLayout ();

}

#endregion

private System.Windows.Forms. Label LabelThemTienNghi; private System.Windows.Forms. PictureBox pictureBox1;

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 253

private System.Windows.Forms. PictureBox pictureBox2; private System.Windows.Forms. Label lbSoPhong; private System.Windows.Forms. Label lbSoCTPhieu; private System.Windows.Forms. DataGridView dtgDanhSachDichVu; private System.Windows.Forms. Button btnThemDV; private System.Windows.Forms. Button btnThoat; } }

### Bước 6: SV sử dụng mã nguồn tạm thời sau để xử lý chức năng trong file

### FormDanhSachDichVuPhongDaDung.cs

using System; using System.Collections.Generic; using System.ComponentModel; using System.Data; using System.Drawing; using System.Linq; using System.Text; using System.Windows.Forms; using HotelManagement.Models; using Microsoft.EntityFrameworkCore;

namespace HotelManagement.PhieuThue { public partial class FormDanhSachDichVuPhongDaDung: Form { private sealed class DongDichVu { public string MaDV { get; set; } = ""; public string TenDV { get; set; } = ""; public decimal DonGia { get; set; } public int SL { get; set; } public decimal ThanhTien { get; set; } }

[ Browsable ( false)] [ DesignerSerializationVisibility ( DesignerSerializationVisibility.Hidden)] public string? MaChiTietDatPhong { get; set; }

[ Browsable ( false)] [ DesignerSerializationVisibility ( DesignerSerializationVisibility.Hidden)] public string? MaPhong { get; set; }

public FormDanhSachDichVuPhongDaDung () { InitializeComponent ();

StartPosition = FormStartPosition.CenterParent; FormBorderStyle = FormBorderStyle.FixedDialog; MaximizeBox = false; MinimizeBox = false; AcceptButton = btnThoat; CancelButton = btnThoat;

Load += FormDanhSachDichVuPhongDaDung_Load; }

private void FormDanhSachDichVuPhongDaDung_Load ( object? sender, EventArgs e) { if ( string. IsNullOrEmpty (MaChiTietDatPhong) || string. IsNullOrEmpty (MaPhong)) { MessageBox. Show( "Chưa xác định được chi tiết phiếu thuê cần xem.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 254

btnThemDV.Enabled = false; return; }

lbSoCTPhieu.Text = "Mã chi tiết phiếu: " + MaChiTietDatPhong; lbSoPhong.Text = "Số phòng: " + MaPhong;

CauHinhLuoi (); LoadDanhSachDichVu (); }

private void CauHinhLuoi () { if (dtgDanhSachDichVu.Columns.Count > 0) return;

dtgDanhSachDichVu.AutoGenerateColumns = false; dtgDanhSachDichVu.ReadOnly = true; dtgDanhSachDichVu.AllowUserToAddRows = false; dtgDanhSachDichVu.AllowUserToDeleteRows = false; dtgDanhSachDichVu.AllowUserToResizeRows = false; dtgDanhSachDichVu.MultiSelect = false; dtgDanhSachDichVu.SelectionMode = DataGridViewSelectionMode.FullRowSelect; dtgDanhSachDichVu.RowHeadersVisible = false; dtgDanhSachDichVu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

dtgDanhSachDichVu.Columns. Add( new DataGridViewTextBoxColumn { Name = "MaDV", DataPropertyName = "MaDV", HeaderText = "Mã dịch vụ" });

dtgDanhSachDichVu.Columns. Add( new DataGridViewTextBoxColumn { Name = "TenDV", DataPropertyName = "TenDV", HeaderText = "Tên dịch vụ" });

var cotDonGia = new DataGridViewTextBoxColumn { Name = "DonGia", DataPropertyName = "DonGia", HeaderText = "Đơn giá" }; cotDonGia.DefaultCellStyle.Format = "N0"; cotDonGia.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; dtgDanhSachDichVu.Columns. Add( cotDonGia);

var cotSoLuong = new DataGridViewTextBoxColumn { Name = "SL", DataPropertyName = "SL", HeaderText = "Số lượng" }; cotSoLuong.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; dtgDanhSachDichVu.Columns. Add( cotSoLuong);

var cotThanhTien = new DataGridViewTextBoxColumn { Name = "ThanhTien", DataPropertyName = "ThanhTien",

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 255

HeaderText = "Thành tiền" }; cotThanhTien.DefaultCellStyle.Format = "N0"; cotThanhTien.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; dtgDanhSachDichVu.Columns. Add( cotThanhTien); }

private void LoadDanhSachDichVu () { string? maCTDP = MaChiTietDatPhong;

try { using var db = new HotelManagementContext ();

var danhSach = db.Ctdvs . AsNoTracking () . Where( v => v.MaCtdp == maCTDP && v.DaXoa != true) . OrderBy ( v => v.MaDv) . Select ( v => new DongDichVu { MaDV = v.MaDv, TenDV = v.MaDvNavigation.TenDv, DonGia = v.MaDvNavigation.DonGia, SL = v.Sl, ThanhTien = v.ThanhTien ?? ( v.Sl * v.MaDvNavigation.DonGia) }) . ToList ();

dtgDanhSachDichVu.DataSource = null; dtgDanhSachDichVu.DataSource = danhSach; dtgDanhSachDichVu. ClearSelection (); } catch ( Exception ex) { MessageBox. Show( "Lỗi tải danh sách dịch vụ đã dùng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); } }

private void btnThemDV_Click ( object sender, EventArgs e) { using ( var frm = new FormThemDichVuPhongDaDung ()) { frm.MaChiTietDatPhong = MaChiTietDatPhong; frm.MaPhong = MaPhong; frm. ShowDialog (); }

LoadDanhSachDichVu (); }

private void btnThoat_Click ( object sender, EventArgs e) { DialogResult = DialogResult.OK; this. Close (); } } }

### Bước 7: Click chuột phải vào folder PhieuThue → Add → Forms( Windows Forms)

### → tạo một form cho phép xem lại thông tin đặt/thuê phòng trong khách sạn là

### FormChiTietPhieuThue.cs

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 256

### Bước 8: Thiết kế giao diện FormChiTietPhieuThue.cs theo mẫu như sau:

### Mã nguồn tham khảo trong file FormChiTietPhieuThue.Designer.cs tạm thời như

### sau:

namespace HotelManagement.PhieuThue { partial class FormChiTietPhieuThue { /// <summary> /// Required designer variable. /// </summary> private System.ComponentModel. IContainer components = null;

/// <summary> /// Clean up any resources being used. /// </summary> /// <param name=" disposing "> true if managed resources should be disposed; otherwise, false. </param> protected override void Dispose ( bool disposing) { if ( disposing && (components != null)) { components. Dispose (); } base. Dispose ( disposing); }

#region Windows Form Designer generated code

/// <summary> /// Required method for Designer support - do not modify /// the contents of this method with the code editor. /// </summary> private void InitializeComponent () { lbSoPhieu = new Label (); lbHoTenKH = new Label (); lbThoiGianLP = new Label (); lbHoTenNV = new Label (); dtgDanhSachCTPT = new DataGridView (); btnThoat = new Button (); pictureBox3 = new PictureBox (); pictureBox2 = new PictureBox (); pictureBox1 = new PictureBox (); ((System.ComponentModel. ISupportInitialize)dtgDanhSachCTPT). BeginInit ();

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 257

((System.ComponentModel. ISupportInitialize)pictureBox3). BeginInit (); ((System.ComponentModel. ISupportInitialize)pictureBox2). BeginInit (); ((System.ComponentModel. ISupportInitialize)pictureBox1). BeginInit (); SuspendLayout (); // // lbSoPhieu // lbSoPhieu.AutoSize = true; lbSoPhieu.BackColor = Color.Transparent; lbSoPhieu.Font = new Font ( "Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0); lbSoPhieu.Location = new Point (351, 29); lbSoPhieu.Margin = new Padding (4, 0, 4, 0); lbSoPhieu.Name = "lbSoPhieu"; lbSoPhieu.Size = new Size (484, 46); lbSoPhieu.TabIndex = 6; lbSoPhieu.Text = "Chi tiết phiếu thuê {số phiếu}"; // // lbHoTenKH // lbHoTenKH.AutoSize = true; lbHoTenKH.Font = new Font ( "Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0); lbHoTenKH.ForeColor = Color. FromArgb (0, 0, 192); lbHoTenKH.Location = new Point (83, 141); lbHoTenKH.Name = "lbHoTenKH"; lbHoTenKH.Size = new Size (194, 26); lbHoTenKH.TabIndex = 8; lbHoTenKH.Text = "Họ tên khách hàng"; // // lbThoiGianLP // lbThoiGianLP.AutoSize = true; lbThoiGianLP.Font = new Font ( "Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0); lbThoiGianLP.ForeColor = Color. FromArgb (0, 0, 192); lbThoiGianLP.Location = new Point (515, 141); lbThoiGianLP.Name = "lbThoiGianLP"; lbThoiGianLP.Size = new Size (194, 26); lbThoiGianLP.TabIndex = 10; lbThoiGianLP.Text = "Thời gian lập phiếu"; // // lbHoTenNV // lbHoTenNV.AutoSize = true; lbHoTenNV.Font = new Font ( "Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0); lbHoTenNV.ForeColor = Color. FromArgb (0, 0, 192); lbHoTenNV.Location = new Point (905, 141); lbHoTenNV.Name = "lbHoTenNV"; lbHoTenNV.Size = new Size (176, 26); lbHoTenNV.TabIndex = 12; lbHoTenNV.Text = "Họ tên nhân viên"; // // dtgDanhSachCTPT // dtgDanhSachCTPT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize; dtgDanhSachCTPT.Location = new Point (12, 221); dtgDanhSachCTPT.Margin = new Padding (3, 4, 3, 4); dtgDanhSachCTPT.Name = "dtgDanhSachCTPT"; dtgDanhSachCTPT.RowHeadersWidth = 51; dtgDanhSachCTPT.RowTemplate.Height = 24; dtgDanhSachCTPT.Size = new Size (1150, 554); dtgDanhSachCTPT.TabIndex = 13; //

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 258

// btnThoat // btnThoat.BackColor = SystemColors.GradientActiveCaption; btnThoat.Font = new Font ( "Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); btnThoat.Location = new Point (499, 808); btnThoat.Margin = new Padding (3, 4, 3, 4); btnThoat.Name = "btnThoat"; btnThoat.Size = new Size (137, 59); btnThoat.TabIndex = 15; btnThoat.Text = "OK"; btnThoat.UseVisualStyleBackColor = false; // // pictureBox3 // pictureBox3.Image = Properties. Resources.NhanVien1; pictureBox3.Location = new Point (834, 124); pictureBox3.Margin = new Padding (3, 4, 3, 4); pictureBox3.Name = "pictureBox3"; pictureBox3.Size = new Size (55, 62); pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage; pictureBox3.TabIndex = 11; pictureBox3.TabStop = false; // // pictureBox2 // pictureBox2.Image = Properties. Resources.CalendarPick; pictureBox2.Location = new Point (444, 124); pictureBox2.Margin = new Padding (3, 4, 3, 4); pictureBox2.Name = "pictureBox2"; pictureBox2.Size = new Size (55, 62); pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage; pictureBox2.TabIndex = 9; pictureBox2.TabStop = false; // // pictureBox1 // pictureBox1.Image = Properties. Resources.Name; pictureBox1.Location = new Point (12, 124); pictureBox1.Margin = new Padding (3, 4, 3, 4); pictureBox1.Name = "pictureBox1"; pictureBox1.Size = new Size (55, 62); pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; pictureBox1.TabIndex = 7; pictureBox1.TabStop = false; // // FormChiTietPhieuThue // AutoScaleDimensions = new SizeF (8F, 20F); AutoScaleMode = AutoScaleMode.Font; ClientSize = new Size (1174, 881); Controls. Add(btnThoat); Controls. Add(dtgDanhSachCTPT); Controls. Add(lbHoTenNV); Controls. Add(pictureBox3); Controls. Add(lbThoiGianLP); Controls. Add(pictureBox2); Controls. Add(lbHoTenKH); Controls. Add(pictureBox1); Controls. Add(lbSoPhieu); Margin = new Padding (3, 4, 3, 4); Name = "FormChiTietPhieuThue"; StartPosition = FormStartPosition.CenterScreen; Text = "Chi tiết phiếu thuê"; ((System.ComponentModel. ISupportInitialize)dtgDanhSachCTPT). EndInit (); ((System.ComponentModel. ISupportInitialize)pictureBox3). EndInit ();

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 259

((System.ComponentModel. ISupportInitialize)pictureBox2). EndInit (); ((System.ComponentModel. ISupportInitialize)pictureBox1). EndInit (); ResumeLayout ( false); PerformLayout ();

}

#endregion

private System.Windows.Forms. Label lbSoPhieu; private System.Windows.Forms. PictureBox pictureBox1; private System.Windows.Forms. Label lbHoTenKH; private System.Windows.Forms. Label lbThoiGianLP; private System.Windows.Forms. PictureBox pictureBox2; private System.Windows.Forms. Label lbHoTenNV; private System.Windows.Forms. PictureBox pictureBox3; private System.Windows.Forms. DataGridView dtgDanhSachCTPT; private System.Windows.Forms. Button btnThoat; } }

### Bước 9: SV sử dụng mã nguồn tạm thời sau để xử lý chức năng trong file

### FormChiTietPhieuThue.cs

using System; using System.Collections.Generic; using System.ComponentModel; using System.Data; using System.Drawing; using System.Text; using System.Windows.Forms; using HotelManagement.DangNhap; using HotelManagement.Models; using Microsoft.EntityFrameworkCore;

namespace HotelManagement.PhieuThue { public partial class FormChiTietPhieuThue : Form { private readonly Image _iconHuy = Properties.Resources.delete; private readonly Image _iconSua = Properties.Resources.edit; private readonly Image _iconDichVu = Properties.Resources.DichVu1; private readonly Image _iconThanhToan = Properties.Resources.money;

[Browsable(false)] [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)] public string? MaPhieuThue { get; set; }

public FormChiTietPhieuThue() { InitializeComponent();

StartPosition = FormStartPosition.CenterParent; FormBorderStyle = FormBorderStyle.FixedDialog; MaximizeBox = false; MinimizeBox = false; AcceptButton = btnThoat; CancelButton = btnThoat; }

private void FormChiTietPhieuThue_Load(object sender, EventArgs e) { if (string.IsNullOrEmpty(MaPhieuThue)) {

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 260

MessageBox.Show("Chưa xác định được phiếu thuê cần xem.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

CauHinhLuoi(); LoadThongTinPhieuThue(); LoadDanhSachChiTietPhieuThue(); }

private void LoadThongTinPhieuThue() { string? maPT = MaPhieuThue;

try { using var db = new HotelManagementContext();

var phieu = db.PhieuThues .AsNoTracking() .Where(p => p.MaPt == maPT) .Select(p => new { p.MaPt, TenKh = p.MaKhNavigation.TenKh, p.NgPt, TenNv = p.MaNvNavigation.TenNv }) .FirstOrDefault();

if (phieu == null) { MessageBox.Show("Không tìm thấy phiếu thuê " + maPT + ".", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

lbSoPhieu.Text = "Chi tiết phiếu thuê " + phieu.MaPt; lbHoTenKH.Text = phieu.TenKh; lbThoiGianLP.Text = phieu.NgPt.ToString("dd/MM/yyyy"); lbHoTenNV.Text = phieu.TenNv; } catch (Exception ex) { MessageBox.Show("Lỗi tải thông tin phiếu thuê: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); } }

private void CauHinhLuoi() { if (dtgDanhSachCTPT.Columns.Count > 0) return;

dtgDanhSachCTPT.ReadOnly = true; dtgDanhSachCTPT.AllowUserToAddRows = false; dtgDanhSachCTPT.AllowUserToDeleteRows = false; dtgDanhSachCTPT.AllowUserToResizeRows = false; dtgDanhSachCTPT.MultiSelect = false; dtgDanhSachCTPT.SelectionMode = DataGridViewSelectionMode.FullRowSelect; dtgDanhSachCTPT.RowHeadersVisible = false; dtgDanhSachCTPT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; dtgDanhSachCTPT.RowTemplate.Height = 40;

dtgDanhSachCTPT.Columns.Add("maCTDP", "Mã CT Phiếu"); dtgDanhSachCTPT.Columns.Add("MapH", "Số phòng");

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 261

dtgDanhSachCTPT.Columns.Add("CheckIn", "Ngày đến KS"); dtgDanhSachCTPT.Columns.Add("CheckOut", "Ngày đi"); dtgDanhSachCTPT.Columns.Add("TrangThai", "Trạng thái"); dtgDanhSachCTPT.Columns.Add("ThanhTien", "Thành tiền");

dtgDanhSachCTPT.Columns["CheckIn"]!.DefaultCellStyle.Format = "dd/MM/yyyy HH:mm"; dtgDanhSachCTPT.Columns["CheckOut"]!.DefaultCellStyle.Format = "dd/MM/yyyy HH:mm"; dtgDanhSachCTPT.Columns["ThanhTien"]!.DefaultCellStyle.Format = "N0"; dtgDanhSachCTPT.Columns["ThanhTien"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

dtgDanhSachCTPT.Columns.Add(TaoCotAnh("Huy", "", "Hủy thông tin chi tiết phiếu", 60)); dtgDanhSachCTPT.Columns.Add(TaoCotAnh("Sua", "", "Cập nhật trạng thái của chi tiết phiếu", 60)); dtgDanhSachCTPT.Columns.Add(TaoCotAnh("DichVu", "Dịch vụ đã dùng", "Quản lý dịch vụ đã dùng của phòng", 110)); dtgDanhSachCTPT.Columns.Add(TaoCotAnh("ThanhToan", "Thanh toán", "Thanh toán hóa đơn cho phòng này", 100)); }

private DataGridViewImageColumn TaoCotAnh(string ten, string tieuDe, string goiY, int doRong) { var cot = new DataGridViewImageColumn { Name = ten, HeaderText = tieuDe, ToolTipText = goiY, ImageLayout = DataGridViewImageCellLayout.Zoom, AutoSizeMode = DataGridViewAutoSizeColumnMode.None, Width = doRong, Resizable = DataGridViewTriState.False, SortMode = DataGridViewColumnSortMode.NotSortable };

cot.DefaultCellStyle.NullValue = null;

return cot; }

private void LoadDanhSachChiTietPhieuThue() { string? maPT = MaPhieuThue;

try { using var db = new HotelManagementContext();

var dsChiTiet = db.Ctdps .AsNoTracking() .Where(c => c.MaPt == maPT && c.DaXoa != true) .OrderBy(c => c.MaCtdp) .Select(c => new { c.MaCtdp, c.MaPh, c.CheckIn, c.CheckOut, c.TrangThai, c.ThanhTien }) .ToList();

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 262

dtgDanhSachCTPT.Rows.Clear();

foreach (var c in dsChiTiet) { bool daDat = c.TrangThai == "Đã đặt"; bool dangThue = c.TrangThai == "Đang thuê";

dtgDanhSachCTPT.Rows.Add( c.MaCtdp, c.MaPh, c.CheckIn, c.CheckOut, c.TrangThai, c.ThanhTien, daDat ? _iconHuy : null, daDat ? _iconSua : null, dangThue ? _iconDichVu : null, dangThue ? _iconThanhToan : null ); }

dtgDanhSachCTPT.CurrentCell = null; } catch (Exception ex) { MessageBox.Show("Lỗi tải danh sách chi tiết phiếu thuê: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); } }

private void btnThoat_Click(object sender, EventArgs e) { DialogResult = DialogResult.OK; this.Close(); }

private void dtgDanhSachCTPT_CellClick(object sender, DataGridViewCellEventArgs e) { if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

var dong = dtgDanhSachCTPT.Rows[e.RowIndex]; string? maPH = dong.Cells["MapH"].Value?.ToString(); string? trangThai = dong.Cells["TrangThai"].Value?.ToString(); string? maCTDP = dong.Cells["maCTDP"].Value?.ToString();

if (string.IsNullOrEmpty(maPH) || string.IsNullOrEmpty(maCTDP)) return;

string tenCot = dtgDanhSachCTPT.Columns[e.ColumnIndex].Name;

if (tenCot == "Huy") { if (trangThai != "Đã đặt") { MessageBox.Show("Chỉ có thể huỷ những phòng đã đặt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn huỷ phòng {maPH} không?", "Xác nhận huỷ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

if (result == DialogResult.Yes)

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 263

{ if (HuyChiTietDatPhong(maCTDP, maPH)) LoadDanhSachChiTietPhieuThue(); } } else if (tenCot == "Sua") { if (trangThai != "Đã đặt") return;

using (var frm = new FormSuaChiTietPhieuThue()) { frm.MaPhieuThue = MaPhieuThue; frm.MaPhong = maPH; frm.ShowDialog(); }

LoadDanhSachChiTietPhieuThue(); } else if (tenCot == "DichVu") { if (trangThai != "Đang thuê") return;

using (var frmDV = new FormDanhSachDichVuPhongDaDung()) { frmDV.MaChiTietDatPhong = maCTDP; frmDV.MaPhong = maPH; frmDV.ShowDialog(); }

LoadDanhSachChiTietPhieuThue(); } else if (tenCot == "ThanhToan") { if (trangThai != "Đang thuê") return;

DialogResult result = MessageBox.Show($"Xác nhận thanh toán cho phòng {maPH}?", "Xác nhận thanh toán", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

if (result == DialogResult.Yes) { TinhTienVaThanhToanHoaDon(maCTDP); LoadDanhSachChiTietPhieuThue(); } } }

private bool HuyChiTietDatPhong(string maCTDP, string maPH) { try { using var db = new HotelManagementContext();

var chiTiet = db.Ctdps.FirstOrDefault(c => c.MaCtdp == maCTDP && c.DaXoa != true);

if (chiTiet == null) { MessageBox.Show("Không tìm thấy chi tiết phiếu cần huỷ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return false; }

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 264

if (chiTiet.TrangThai != "Đã đặt") { MessageBox.Show("Chỉ có thể huỷ những phòng đã đặt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }

chiTiet.DaXoa = true;

bool conPhieuKhac = db.Ctdps.Any(c => c.MaPh == maPH && c.MaCtdp != maCTDP && c.DaXoa != true && (c.TrangThai == "Đã đặt" || c.TrangThai == "Đang thuê"));

if (!conPhieuKhac) { var phong = db.Phongs.FirstOrDefault(p => p.MaPh == maPH);

if (phong != null && phong.Ttph == "Đã đặt") phong.Ttph = "Bình thường"; }

db.SaveChanges();

MessageBox.Show($"Phòng {maPH} đã được huỷ.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information); return true; } catch (DbUpdateException ex) { MessageBox.Show("Lỗi khi huỷ phòng: " + (ex.InnerException?.Message ?? ex.Message), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return false; } catch (Exception ex) { MessageBox.Show("Lỗi khi huỷ phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return false; } }

private static string TaoMaTiepTheo(IEnumerable<string> cacMa, string tienTo, int soChuSo, int doDaiToiDa) { int lonNhat = 0;

foreach (string ma in cacMa) { if (ma.Length > tienTo.Length && ma.StartsWith(tienTo, StringComparison.OrdinalIgnoreCase) && int.TryParse(ma.Substring(tienTo.Length), out int so) && so > lonNhat) { lonNhat = so; } }

string maMoi = tienTo + (lonNhat + 1).ToString("D" + soChuSo);

if (maMoi.Length > doDaiToiDa) throw new InvalidOperationException($"Đã hết mã có tiền tố {tienTo} (tối đa {doDaiToiDa} ký tự).");

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 265

return maMoi; }

private void TinhTienVaThanhToanHoaDon(string maCTDP) { string maNV = FormDangNhap.MaNV_DangNhap;

if (string.IsNullOrWhiteSpace(maNV)) { MessageBox.Show("Chưa xác định được nhân viên đang đăng nhập. Vui lòng đăng nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

try { using var db = new HotelManagementContext(); using var giaoDich = db.Database.BeginTransaction(IsolationLevel.Serializable);

var chiTiet = db.Ctdps.FirstOrDefault(c => c.MaCtdp == maCTDP && c.DaXoa != true);

if (chiTiet == null) { MessageBox.Show("Không tìm thấy chi tiết phiếu cần thanh toán.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

if (chiTiet.TrangThai != "Đang thuê") { MessageBox.Show("Chỉ có thể thanh toán những phòng đang thuê!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

string maPhong = chiTiet.MaPh; decimal tienPhong = chiTiet.ThanhTien ?? 0m;

decimal tienDV = db.Ctdvs .Where(v => v.MaCtdp == maCTDP && v.DaXoa != true) .Sum(v => v.ThanhTien ?? 0m);

decimal tongTien = tienPhong + tienDV;

string maHD = TaoMaTiepTheo(db.HoaDons.Select(h => h.MaHd).ToList(), "HD", 3, 5);

db.HoaDons.Add(new Models.HoaDon { MaHd = maHD, NgHd = DateTime.Now, TriGia = tongTien, MaNv = maNV, TrangThai = "Chờ KH xác nhận", MaCtdp = maCTDP, DaXoa = false });

chiTiet.TrangThai = "Đã thanh toán";

var phong = db.Phongs.FirstOrDefault(p => p.MaPh == maPhong);

if (phong != null)

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 266

phong.Ttph = "Bình thường";

db.SaveChanges(); giaoDich.Commit();

MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); } catch (DbUpdateException ex) { MessageBox.Show("Lỗi thanh toán: " + (ex.InnerException?.Message ?? ex.Message), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); } catch (Exception ex) { MessageBox.Show("Lỗi thanh toán: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); } } } }

### Bước 10: Click chuột phải vào folder PhieuThue → Add → Forms( Windows Forms)

### → tạo một form cho phép xem lại thông tin đặt/thuê phòng trong khách sạn là

### FormDanhSachPhieuThue.cs

### Bước 11: Thiết kế giao diện FormDanhSachPhieuThue.cs theo mẫu như sau:

### Mã nguồn tham khảo trong file FormDanhSachPhieuThue.Designer.cs tạm thời như

### sau:

namespace HotelManagement.PhieuThue { partial class FormDanhSachPhieuThue { /// <summary> /// Required designer variable. /// </summary> private System.ComponentModel. IContainer components = null;

/// <summary> /// Clean up any resources being used. /// </summary> /// <param name=" disposing "> true if managed resources should be disposed; otherwise, false. </param> protected override void Dispose ( bool disposing) { if ( disposing && (components != null)) { components. Dispose (); } base. Dispose ( disposing); }

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 267

#region Windows Form Designer generated code

/// <summary> /// Required method for Designer support - do not modify /// the contents of this method with the code editor. /// </summary> private void InitializeComponent () { dtgDanhSachPhieuThue = new DataGridView (); btnDatPhong = new Button (); btnXuatExcel = new Button (); txtTimKiem = new TextBox (); pictureBox1 = new PictureBox ();

((System.ComponentModel. ISupportInitialize)dtgDanhSachPhieuThue). BeginInit (); ((System.ComponentModel. ISupportInitialize)pictureBox1). BeginInit (); SuspendLayout (); // // dtgDanhSachPhieuThue // dtgDanhSachPhieuThue.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize; dtgDanhSachPhieuThue.Location = new Point (12, 66); dtgDanhSachPhieuThue.Margin = new Padding (3, 4, 3, 4); dtgDanhSachPhieuThue.Name = "dtgDanhSachPhieuThue"; dtgDanhSachPhieuThue.RowHeadersWidth = 51; dtgDanhSachPhieuThue.RowTemplate.Height = 24; dtgDanhSachPhieuThue.Size = new Size (1128, 769); dtgDanhSachPhieuThue.TabIndex = 9; dtgDanhSachPhieuThue.CellContentClick += dtgDanhSachPhieuThue_CellContentClick; // // btnDatPhong // btnDatPhong.BackColor = Color.MediumSpringGreen; btnDatPhong.Font = new Font ( "Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0); btnDatPhong.Location = new Point (839, 6); btnDatPhong.Margin = new Padding (3, 4, 3, 4); btnDatPhong.Name = "btnDatPhong"; btnDatPhong.Size = new Size (188, 46); btnDatPhong.TabIndex = 8; btnDatPhong.Text = "Đặt phòng"; btnDatPhong.UseVisualStyleBackColor = false; btnDatPhong.Click += btnDatPhong_Click; // // btnXuatExcel // btnXuatExcel.BackColor = Color.DarkTurquoise; btnXuatExcel.Font = new Font ( "Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0); btnXuatExcel.Location = new Point (513, 9); btnXuatExcel.Margin = new Padding (3, 4, 3, 4); btnXuatExcel.Name = "btnXuatExcel"; btnXuatExcel.Size = new Size (167, 46); btnXuatExcel.TabIndex = 7; btnXuatExcel.Text = "Xuất file Excel"; btnXuatExcel.UseVisualStyleBackColor = false; btnXuatExcel.Click += btnXuatExcel_Click; // // txtTimKiem // txtTimKiem.Font = new Font ( "Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0); txtTimKiem.Location = new Point (69, 9);

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 268

txtTimKiem.Margin = new Padding (3, 4, 3, 4); txtTimKiem.Name = "txtTimKiem"; txtTimKiem.Size = new Size (187, 32); txtTimKiem.TabIndex = 5; txtTimKiem.TextChanged += txtTimKiem_TextChanged; // // pictureBox1 // pictureBox1.Image = Properties. Resources.search; pictureBox1.Location = new Point (12, 6); pictureBox1.Margin = new Padding (3, 4, 3, 4); pictureBox1.Name = "pictureBox1"; pictureBox1.Size = new Size (39, 46); pictureBox1.TabIndex = 6; pictureBox1.TabStop = false; // // FormDanhSachPhieuThue // AutoScaleDimensions = new SizeF (8F, 20F); AutoScaleMode = AutoScaleMode.Font; ClientSize = new Size (1152, 850); Controls. Add(dtgDanhSachPhieuThue); Controls. Add(btnDatPhong); Controls. Add(btnXuatExcel); Controls. Add(pictureBox1); Controls. Add(txtTimKiem); Margin = new Padding (3, 4, 3, 4); Name = "FormDanhSachPhieuThue"; StartPosition = FormStartPosition.CenterScreen; Text = "FormDanhSachPhieuThue"; Load += FormDanhSachPhieuThue_Load; ((System.ComponentModel. ISupportInitialize)dtgDanhSachPhieuThue). EndInit (); ((System.ComponentModel. ISupportInitialize)pictureBox1). EndInit (); ResumeLayout ( false); PerformLayout ();

}

#endregion

private System.Windows.Forms. DataGridView dtgDanhSachPhieuThue; private System.Windows.Forms. Button btnDatPhong; private System.Windows.Forms. Button btnXuatExcel; private System.Windows.Forms. PictureBox pictureBox1; private System.Windows.Forms. TextBox txtTimKiem; } }

### Bước 12: SV sử dụng mã nguồn tạm thời sau để xử lý chức năng trong file

### FormDanhSachPhieuThue.cs

using System; using System.Collections.Generic; using System.ComponentModel; using System.Data; using System.Drawing; using System.Linq; using System.Text; using System.Windows.Forms; using ClosedXML.Excel; using HotelManagement.Models; using HotelManagement.SoDoPhong; using Microsoft.EntityFrameworkCore;

namespace HotelManagement.PhieuThue

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 269

{ public partial class FormDanhSachPhieuThue: Form { private sealed class DongPhieuThue { public string MaPT { get; set; } = ""; public string TenKH { get; set; } = ""; public DateTime NgPT { get; set; } public string TenNV { get; set; } = ""; }

private List <DongPhieuThue > _danhSach = new List <DongPhieuThue >(); private List <DongPhieuThue > _dangHienThi = new List <DongPhieuThue >();

public FormDanhSachPhieuThue () { InitializeComponent (); }

private void FormDanhSachPhieuThue_Load ( object sender, EventArgs e) { CauHinhLuoi (); LoadDanhSachPhieuThue (); }

private void CauHinhLuoi () { if (dtgDanhSachPhieuThue.Columns.Count > 0) return;

dtgDanhSachPhieuThue.AutoGenerateColumns = false; dtgDanhSachPhieuThue.ReadOnly = true; dtgDanhSachPhieuThue.AllowUserToAddRows = false; dtgDanhSachPhieuThue.AllowUserToDeleteRows = false; dtgDanhSachPhieuThue.AllowUserToResizeRows = false; dtgDanhSachPhieuThue.MultiSelect = false; dtgDanhSachPhieuThue.SelectionMode = DataGridViewSelectionMode.FullRowSelect; dtgDanhSachPhieuThue.RowHeadersVisible = false; dtgDanhSachPhieuThue.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

dtgDanhSachPhieuThue.Columns. Add( new DataGridViewTextBoxColumn { Name = "MaPT", DataPropertyName = "MaPT", HeaderText = "Mã phiếu thuê" });

dtgDanhSachPhieuThue.Columns. Add( new DataGridViewTextBoxColumn { Name = "TenKH", DataPropertyName = "TenKH", HeaderText = "Tên khách hàng" });

var cotNgayLap = new DataGridViewTextBoxColumn { Name = "NgPT", DataPropertyName = "NgPT", HeaderText = "Ngày lập phiếu" }; cotNgayLap.DefaultCellStyle.Format = "dd/MM/yyyy"; dtgDanhSachPhieuThue.Columns. Add( cotNgayLap);

dtgDanhSachPhieuThue.Columns. Add( new DataGridViewTextBoxColumn

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 270

{ Name = "TenNV", DataPropertyName = "TenNV", HeaderText = "Nhân viên lập" });

var imgCol = new DataGridViewImageColumn { Name = "ChiTiet", HeaderText = "Chi tiết", Image = Properties. Resources.details, ToolTipText = "Xem chi tiết", ImageLayout = DataGridViewImageCellLayout.Zoom, AutoSizeMode = DataGridViewAutoSizeColumnMode.None, Width = 80, Resizable = DataGridViewTriState.False }; dtgDanhSachPhieuThue.Columns. Add( imgCol); }

private void LoadDanhSachPhieuThue () { try { using var db = new HotelManagementContext ();

_danhSach = db.PhieuThues . AsNoTracking () . Where( p => p.DaXoa != true) . OrderBy ( p => p.MaPt) . Select ( p => new DongPhieuThue { MaPT = p.MaPt, TenKH = p.MaKhNavigation.TenKh, NgPT = p.NgPt, TenNV = p.MaNvNavigation.TenNv }) . ToList ();

HienThiDanhSach (); } catch ( Exception ex) { MessageBox. Show( "Lỗi tải danh sách phiếu thuê: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); } }

private void HienThiDanhSach () { string tuKhoa = txtTimKiem.Text. Trim ();

_dangHienThi = string. IsNullOrEmpty ( tuKhoa) ? _danhSach. ToList () : _danhSach . Where( d => d.MaPT. Contains ( tuKhoa, StringComparison.OrdinalIgnoreCase) || d.TenKH. Contains ( tuKhoa, StringComparison.OrdinalIgnoreCase)) . ToList ();

dtgDanhSachPhieuThue.DataSource = null; dtgDanhSachPhieuThue.DataSource = _dangHienThi; dtgDanhSachPhieuThue. ClearSelection (); }

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 271

private void txtTimKiem_TextChanged ( object sender, EventArgs e) { HienThiDanhSach (); }

private void btnXuatExcel_Click ( object sender, EventArgs e) { if (_dangHienThi.Count == 0) { MessageBox. Show( "Không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

using var hopLuu = new SaveFileDialog { Filter = "Excel Workbook (*.xlsx)|*.xlsx", FileName = "DanhSachPhieuThue_" + DateTime.Now. ToString ( "yyyyMMdd_HHmmss") + ".xlsx", Title = "Lưu danh sách phiếu thuê" };

if ( hopLuu. ShowDialog () != DialogResult.OK) return;

try { using var workbook = new XLWorkbook (); var worksheet = workbook.Worksheets. Add( "Danh sách phiếu thuê");

string [] tieuDe = { "Mã phiếu thuê", "Tên khách hàng", "Ngày lập phiếu", "Nhân viên lập"};

for ( int i = 0; i < tieuDe.Length; i ++) { var o = worksheet. Cell (1, i + 1); o.Value = tieuDe [ i]; o.Style.Font.Bold = true; o.Style.Fill.BackgroundColor = XLColor.LightGray; }

int dong = 2;

foreach ( var d in _dangHienThi) { worksheet. Cell ( dong, 1).Value = d.MaPT; worksheet. Cell ( dong, 2).Value = d.TenKH; worksheet. Cell ( dong, 3).Value = d.NgPT; worksheet. Cell ( dong, 3).Style.DateFormat.Format = "dd/MM/yyyy"; worksheet. Cell ( dong, 4).Value = d.TenNV; dong ++; }

worksheet. Columns (). AdjustToContents (); workbook. SaveAs ( hopLuu.FileName);

MessageBox. Show( "Xuất dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); } catch ( IOException ex) { MessageBox. Show( "Không thể ghi file, hãy kiểm tra file có đang được mở không: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); } catch ( Exception ex)

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 272

{ MessageBox. Show( "Lỗi xuất Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); } }

private void btnDatPhong_Click ( object sender, EventArgs e) { using ( var formDatPhong = new FormDatPhong ()) { formDatPhong. ShowDialog (); }

LoadDanhSachPhieuThue (); }

private void dtgDanhSachPhieuThue_CellContentClick ( object sender, DataGridViewCellEventArgs e) { if ( e.RowIndex < 0 || e.ColumnIndex < 0) return;

if (dtgDanhSachPhieuThue.Columns[ e.ColumnIndex].Name != "ChiTiet") return;

string? maPT = dtgDanhSachPhieuThue.Rows[ e.RowIndex].Cells[ "MaPT"].Value?. ToString ();

if ( string. IsNullOrEmpty ( maPT)) return;

using ( var formChiTiet = new FormChiTietPhieuThue ()) { formChiTiet.MaPhieuThue = maPT; formChiTiet. ShowDialog (); }

LoadDanhSachPhieuThue (); } } }

### 3. Xây dựng giao diện và chức năng quản lý thông tin hóa đơn thuê phòng cho

### khách hàng

### Bước 1: Click chuột phải vào thư mục project → Add → New Folder→ Đặt tên folder

### là “HoaDon”

### Bước 2: Click chuột phải vào folder HoaDon → Add → Forms( Windows Forms) →

### tạo một form cho phép xem lại thông tin đặt/thuê phòng trong khách sạn là

### FormHoaDon.cs

### Bước 3: Thiết kế giao diện FormHoaDon.cs theo mẫu như sau:

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 273

### Mã nguồn tham khảo trong file FormHoaDon.Designer.cs tạm thời như sau:

namespace HotelManagement.HoaDon { partial class FormHoaDon { /// <summary> /// Required designer variable. /// </summary> private System.ComponentModel.IContainer components = null;

/// <summary> /// Clean up any resources being used. /// </summary> /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param> protected override void Dispose(bool disposing) { if (disposing && (components != null)) { components.Dispose(); } base.Dispose(disposing); }

#region Windows Form Designer generated code

/// <summary> /// Required method for Designer support - do not modify /// the contents of this method with the code editor. /// </summary> private void InitializeComponent() { System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle(); System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle(); System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle(); this.panel1 = new System.Windows.Forms.Panel(); this.dtgDichVuDaDung = new System.Windows.Forms.DataGridView(); this.txtTienThuePhong = new System.Windows.Forms.TextBox(); this.label2 = new System.Windows.Forms.Label(); this.dtpNgayHD = new System.Windows.Forms.DateTimePicker();

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 274

this.pictureBox2 = new System.Windows.Forms.PictureBox(); this.label8 = new System.Windows.Forms.Label(); this.lbTongTriGia = new System.Windows.Forms.Label(); this.txtTenNV = new System.Windows.Forms.TextBox(); this.txtSoNgayThuePhong = new System.Windows.Forms.TextBox(); this.txtTenLP = new System.Windows.Forms.TextBox(); this.txtMaPhong = new System.Windows.Forms.TextBox(); this.txtMaHoaDon = new System.Windows.Forms.TextBox(); this.txtTenKH = new System.Windows.Forms.TextBox(); this.label4 = new System.Windows.Forms.Label(); this.label3 = new System.Windows.Forms.Label(); this.label7 = new System.Windows.Forms.Label(); this.label6 = new System.Windows.Forms.Label(); this.label5 = new System.Windows.Forms.Label(); this.LabelNgayHD = new System.Windows.Forms.Label(); this.LabelTenKH = new System.Windows.Forms.Label(); this.Printer = new System.Windows.Forms.PictureBox(); this.label1 = new System.Windows.Forms.Label(); this.pictureBox1 = new System.Windows.Forms.PictureBox(); this.panel1.SuspendLayout();

((System.ComponentModel.ISupportInitialize)(this.dtgDichVuDaDung)).BeginInit(); ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit(); ((System.ComponentModel.ISupportInitialize)(this.Printer)).BeginInit(); ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit(); this.SuspendLayout(); // // panel1 // this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight; this.panel1.Controls.Add(this.dtgDichVuDaDung); this.panel1.Controls.Add(this.txtTienThuePhong); this.panel1.Controls.Add(this.label2); this.panel1.Controls.Add(this.dtpNgayHD); this.panel1.Controls.Add(this.pictureBox2); this.panel1.Controls.Add(this.label8); this.panel1.Controls.Add(this.lbTongTriGia); this.panel1.Controls.Add(this.txtTenNV); this.panel1.Controls.Add(this.txtSoNgayThuePhong); this.panel1.Controls.Add(this.txtTenLP); this.panel1.Controls.Add(this.txtMaPhong); this.panel1.Controls.Add(this.txtMaHoaDon); this.panel1.Controls.Add(this.txtTenKH); this.panel1.Controls.Add(this.label4); this.panel1.Controls.Add(this.label3); this.panel1.Controls.Add(this.label7); this.panel1.Controls.Add(this.label6); this.panel1.Controls.Add(this.label5); this.panel1.Controls.Add(this.LabelNgayHD); this.panel1.Controls.Add(this.LabelTenKH); this.panel1.Controls.Add(this.Printer); this.panel1.Controls.Add(this.label1); this.panel1.Controls.Add(this.pictureBox1); this.panel1.Location = new System.Drawing.Point(1, 1); this.panel1.Name = "panel1"; this.panel1.Size = new System.Drawing.Size(880, 667); this.panel1.TabIndex = 0; // // dtgDichVuDaDung // this.dtgDichVuDaDung.AllowUserToAddRows = false; this.dtgDichVuDaDung.AllowUserToDeleteRows = false; this.dtgDichVuDaDung.AllowUserToResizeColumns = false; this.dtgDichVuDaDung.AllowUserToResizeRows = false; this.dtgDichVuDaDung.Anchor = System.Windows.Forms.AnchorStyles.None;

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 275

this.dtgDichVuDaDung.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill; this.dtgDichVuDaDung.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders; this.dtgDichVuDaDung.BackgroundColor = System.Drawing.Color.White; this.dtgDichVuDaDung.BorderStyle = System.Windows.Forms.BorderStyle.None; this.dtgDichVuDaDung.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None; this.dtgDichVuDaDung.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None; dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft; dataGridViewCellStyle1.BackColor = System.Drawing.Color.White; dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText; dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White; dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText; dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True; this.dtgDichVuDaDung.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1; this.dtgDichVuDaDung.ColumnHeadersHeight = 40; this.dtgDichVuDaDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing; dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft; dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window; dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText; dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Window; dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText; dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True; this.dtgDichVuDaDung.DefaultCellStyle = dataGridViewCellStyle2; this.dtgDichVuDaDung.EnableHeadersVisualStyles = false; this.dtgDichVuDaDung.Location = new System.Drawing.Point(25, 329); this.dtgDichVuDaDung.Name = "dtgDichVuDaDung"; this.dtgDichVuDaDung.ReadOnly = true; this.dtgDichVuDaDung.RowHeadersVisible = false; this.dtgDichVuDaDung.RowHeadersWidth = 40; this.dtgDichVuDaDung.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing; dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True; this.dtgDichVuDaDung.RowsDefaultCellStyle = dataGridViewCellStyle3; this.dtgDichVuDaDung.RowTemplate.Height = 25; this.dtgDichVuDaDung.RowTemplate.ReadOnly = true; this.dtgDichVuDaDung.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False; this.dtgDichVuDaDung.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal; this.dtgDichVuDaDung.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect; this.dtgDichVuDaDung.Size = new System.Drawing.Size(800, 221); this.dtgDichVuDaDung.TabIndex = 60; // // txtTienThuePhong // this.txtTienThuePhong.BackColor = System.Drawing.Color.White; this.txtTienThuePhong.BorderStyle = System.Windows.Forms.BorderStyle.None;

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 276

this.txtTienThuePhong.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); this.txtTienThuePhong.ForeColor = System.Drawing.Color.Red; this.txtTienThuePhong.Location = new System.Drawing.Point(205, 294); this.txtTienThuePhong.Name = "txtTienThuePhong"; this.txtTienThuePhong.ReadOnly = true; this.txtTienThuePhong.Size = new System.Drawing.Size(135, 29); this.txtTienThuePhong.TabIndex = 59; this.txtTienThuePhong.Text = "0 ngày"; // // label2 // this.label2.AutoSize = true; this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))); this.label2.Location = new System.Drawing.Point(20, 294); this.label2.Name = "label2"; this.label2.Size = new System.Drawing.Size(165, 28); this.label2.TabIndex = 58; this.label2.Text = "Tiền thuê phòng"; // // dtpNgayHD // this.dtpNgayHD.CalendarForeColor = System.Drawing.SystemColors.ButtonHighlight; this.dtpNgayHD.Enabled = false; this.dtpNgayHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); this.dtpNgayHD.Format = System.Windows.Forms.DateTimePickerFormat.Short; this.dtpNgayHD.Location = new System.Drawing.Point(205, 164); this.dtpNgayHD.Name = "dtpNgayHD"; this.dtpNgayHD.Size = new System.Drawing.Size(189, 30); this.dtpNgayHD.TabIndex = 57; // // pictureBox2 // this.pictureBox2.BackColor = System.Drawing.Color.Transparent; this.pictureBox2.Image = global::HotelManagement.Properties.Resources.heart; this.pictureBox2.Location = new System.Drawing.Point(530, 623); this.pictureBox2.Name = "pictureBox2"; this.pictureBox2.Size = new System.Drawing.Size(30, 30); this.pictureBox2.TabIndex = 56; this.pictureBox2.TabStop = false; // // label8 // this.label8.AutoSize = true; this.label8.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))); this.label8.Location = new System.Drawing.Point(206, 607); this.label8.Name = "label8"; this.label8.Size = new System.Drawing.Size(323, 46); this.label8.TabIndex = 55; this.label8.Text = "Cảm ơn quý khách!"; // // lbTongTriGia // this.lbTongTriGia.AutoSize = true; this.lbTongTriGia.BackColor = System.Drawing.Color.White; this.lbTongTriGia.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))); this.lbTongTriGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(176)))), ((int)(((byte)(32))))); this.lbTongTriGia.Location = new System.Drawing.Point(19, 553);

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 277

this.lbTongTriGia.Name = "lbTongTriGia"; this.lbTongTriGia.Size = new System.Drawing.Size(142, 35); this.lbTongTriGia.TabIndex = 54; this.lbTongTriGia.Text = "Tổng tiền: "; // // txtTenNV // this.txtTenNV.BackColor = System.Drawing.Color.White; this.txtTenNV.BorderStyle = System.Windows.Forms.BorderStyle.None; this.txtTenNV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); this.txtTenNV.Location = new System.Drawing.Point(170, 247); this.txtTenNV.Name = "txtTenNV"; this.txtTenNV.ReadOnly = true; this.txtTenNV.Size = new System.Drawing.Size(199, 27); this.txtTenNV.TabIndex = 51; this.txtTenNV.Text = "Họ tên nhân viên"; // // txtSoNgayThuePhong // this.txtSoNgayThuePhong.BackColor = System.Drawing.Color.White; this.txtSoNgayThuePhong.BorderStyle = System.Windows.Forms.BorderStyle.None; this.txtSoNgayThuePhong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); this.txtSoNgayThuePhong.Location = new System.Drawing.Point(595, 247); this.txtSoNgayThuePhong.Name = "txtSoNgayThuePhong"; this.txtSoNgayThuePhong.ReadOnly = true; this.txtSoNgayThuePhong.Size = new System.Drawing.Size(72, 27); this.txtSoNgayThuePhong.TabIndex = 50; this.txtSoNgayThuePhong.Text = "0 ngày"; // // txtTenLP // this.txtTenLP.BackColor = System.Drawing.Color.White; this.txtTenLP.BorderStyle = System.Windows.Forms.BorderStyle.None; this.txtTenLP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); this.txtTenLP.Location = new System.Drawing.Point(595, 206); this.txtTenLP.Name = "txtTenLP"; this.txtTenLP.ReadOnly = true; this.txtTenLP.Size = new System.Drawing.Size(151, 27); this.txtTenLP.TabIndex = 49; this.txtTenLP.Text = "Phòng đơn"; // // txtMaPhong // this.txtMaPhong.BackColor = System.Drawing.Color.White; this.txtMaPhong.BorderStyle = System.Windows.Forms.BorderStyle.None; this.txtMaPhong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); this.txtMaPhong.Location = new System.Drawing.Point(595, 126); this.txtMaPhong.Name = "txtMaPhong"; this.txtMaPhong.ReadOnly = true; this.txtMaPhong.Size = new System.Drawing.Size(72, 27); this.txtMaPhong.TabIndex = 48; this.txtMaPhong.Text = "P000"; // // txtMaHoaDon // this.txtMaHoaDon.BackColor = System.Drawing.Color.White; this.txtMaHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.None; this.txtMaHoaDon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); this.txtMaHoaDon.Location = new System.Drawing.Point(170, 207); this.txtMaHoaDon.Name = "txtMaHoaDon";

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 278

this.txtMaHoaDon.ReadOnly = true; this.txtMaHoaDon.Size = new System.Drawing.Size(72, 27); this.txtMaHoaDon.TabIndex = 47; this.txtMaHoaDon.Text = "Số HD"; // // txtTenKH // this.txtTenKH.BackColor = System.Drawing.Color.White; this.txtTenKH.BorderStyle = System.Windows.Forms.BorderStyle.None; this.txtTenKH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); this.txtTenKH.Location = new System.Drawing.Point(150, 127); this.txtTenKH.Name = "txtTenKH"; this.txtTenKH.ReadOnly = true; this.txtTenKH.Size = new System.Drawing.Size(201, 27); this.txtTenKH.TabIndex = 46; this.txtTenKH.Text = "Tên khách hàng"; // // label4 // this.label4.AutoSize = true; this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))); this.label4.Location = new System.Drawing.Point(20, 246); this.label4.Name = "label4"; this.label4.Size = new System.Drawing.Size(110, 28); this.label4.TabIndex = 45; this.label4.Text = "Nhân viên:"; // // label3 // this.label3.AutoSize = true; this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))); this.label3.Location = new System.Drawing.Point(20, 206); this.label3.Name = "label3"; this.label3.Size = new System.Drawing.Size(122, 28); this.label3.TabIndex = 44; this.label3.Text = "Số hóa đơn:"; // // label7 // this.label7.AutoSize = true; this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))); this.label7.Location = new System.Drawing.Point(456, 246); this.label7.Name = "label7"; this.label7.Size = new System.Drawing.Size(90, 28); this.label7.TabIndex = 43; this.label7.Text = "Số ngày:"; // // label6 // this.label6.AutoSize = true; this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))); this.label6.Location = new System.Drawing.Point(457, 205); this.label6.Name = "label6"; this.label6.Size = new System.Drawing.Size(120, 28); this.label6.TabIndex = 42; this.label6.Text = "Loại phòng:"; // // label5 // this.label5.AutoSize = true;

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 279

this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))); this.label5.Location = new System.Drawing.Point(466, 124); this.label5.Name = "label5"; this.label5.Size = new System.Drawing.Size(111, 28); this.label5.TabIndex = 41; this.label5.Text = "Mã phòng:"; // // LabelNgayHD // this.LabelNgayHD.AutoSize = true; this.LabelNgayHD.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))); this.LabelNgayHD.Location = new System.Drawing.Point(20, 166); this.LabelNgayHD.Name = "LabelNgayHD"; this.LabelNgayHD.Size = new System.Drawing.Size(179, 28); this.LabelNgayHD.TabIndex = 40; this.LabelNgayHD.Text = "Ngày lập hóa đơn:"; // // LabelTenKH // this.LabelTenKH.AutoSize = true; this.LabelTenKH.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))); this.LabelTenKH.Location = new System.Drawing.Point(20, 126); this.LabelTenKH.Name = "LabelTenKH"; this.LabelTenKH.Size = new System.Drawing.Size(124, 28); this.LabelTenKH.TabIndex = 39; this.LabelTenKH.Text = "Khách hàng:"; // // Printer // this.Printer.Cursor = System.Windows.Forms.Cursors.Hand; this.Printer.Image = global::HotelManagement.Properties.Resources.printer; this.Printer.Location = new System.Drawing.Point(776, 11); this.Printer.Name = "Printer"; this.Printer.Size = new System.Drawing.Size(56, 48); this.Printer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage; this.Printer.TabIndex = 38; this.Printer.TabStop = false; // this.Printer.Click += new System.EventHandler(this.Printer_Click); // // label1 // this.label1.AutoSize = true; this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))); this.label1.ForeColor = System.Drawing.Color.Olive; this.label1.Location = new System.Drawing.Point(346, 11); this.label1.Name = "label1"; this.label1.Size = new System.Drawing.Size(183, 48); this.label1.TabIndex = 1; this.label1.Text = "Hóa đơn"; // // pictureBox1 // this.pictureBox1.Image = global::HotelManagement.Properties.Resources.pictureIconNoneBackGroundResize55; this.pictureBox1.Location = new System.Drawing.Point(25, 11); this.pictureBox1.Name = "pictureBox1"; this.pictureBox1.Size = new System.Drawing.Size(79, 79); this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage; this.pictureBox1.TabIndex = 0; this.pictureBox1.TabStop = false;

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 280

// // FormHoaDon // this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F); this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font; this.ClientSize = new System.Drawing.Size(838, 670); this.Controls.Add(this.panel1); this.Name = "FormHoaDon"; this.Text = "InPhiếu hóa đơn khách hàng"; // this.Load += new System.EventHandler(this.FormHoaDon_Load); this.panel1.ResumeLayout(false); this.panel1.PerformLayout();

((System.ComponentModel.ISupportInitialize)(this.dtgDichVuDaDung)).EndInit(); ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit(); ((System.ComponentModel.ISupportInitialize)(this.Printer)).EndInit(); ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit(); this.ResumeLayout(false);

}

#endregion

private System.Windows.Forms.Panel panel1; private System.Windows.Forms.PictureBox pictureBox1; private System.Windows.Forms.TextBox txtTenNV; private System.Windows.Forms.TextBox txtSoNgayThuePhong; private System.Windows.Forms.TextBox txtTenLP; private System.Windows.Forms.TextBox txtMaPhong; private System.Windows.Forms.TextBox txtMaHoaDon; private System.Windows.Forms.TextBox txtTenKH; private System.Windows.Forms.Label label4; private System.Windows.Forms.Label label3; private System.Windows.Forms.Label label7; private System.Windows.Forms.Label label6; private System.Windows.Forms.Label label5; private System.Windows.Forms.Label LabelNgayHD; private System.Windows.Forms.Label LabelTenKH; private System.Windows.Forms.PictureBox Printer; private System.Windows.Forms.Label label1; private System.Windows.Forms.PictureBox pictureBox2; private System.Windows.Forms.Label label8; private System.Windows.Forms.Label lbTongTriGia; private System.Windows.Forms.DateTimePicker dtpNgayHD; private System.Windows.Forms.TextBox txtTienThuePhong; private System.Windows.Forms.Label label2; private System.Windows.Forms.DataGridView dtgDichVuDaDung; } }

### Bước 4: SV sử dụng mã nguồn tạm thời sau để xử lý chức năng trong file

### FormHoaDon.cs

using System; using System.Collections.Generic; using System.ComponentModel; using System.Data; using System.Drawing; using System.Globalization; using System.Text; using System.Windows.Forms; using HotelManagement.Models; using iTextSharp.text; using iTextSharp.text.pdf; using Microsoft.EntityFrameworkCore;

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 281

namespace HotelManagement.HoaDon { public partial class FormHoaDon : Form { private string maHD = string.Empty; private readonly CultureInfo viVN = new CultureInfo("vi - VN");

public FormHoaDon() { InitializeComponent(); }

public FormHoaDon(string maHD) : this() { this.maHD = maHD; }

private void FormHoaDon_Load(object sender, EventArgs e) { if (string.IsNullOrEmpty(maHD)) { MessageBox.Show("Không xác định được hóa đơn cần xem!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); DialogResult = DialogResult.Cancel; Close(); return; }

LoadThongTinHoaDon(); }

private string DinhDangTien(decimal soTien) { return soTien.ToString("N0", viVN) + " VND"; }

private void LoadThongTinHoaDon() { try { using var db = new HotelManagementContext();

var hoaDon = db.HoaDons .AsNoTracking() .Where(h => h.MaHd == maHD && h.DaXoa != true) .Select(h => new { h.MaHd, h.NgHd, h.MaCtdp, TenNV = h.MaNvNavigation.TenNv, TenKH = h.MaCtdpNavigation.MaPtNavigation.MaKhNavigation.TenKh, MaPH = h.MaCtdpNavigation.MaPh, TenLPH = h.MaCtdpNavigation.MaPhNavigation.MaLphNavigation.TenLph, h.MaCtdpNavigation.ThanhTien, h.MaCtdpNavigation.CheckIn, h.MaCtdpNavigation.CheckOut, h.MaCtdpNavigation.TheoGio }) .FirstOrDefault();

if (hoaDon == null) {

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 282

MessageBox.Show("Không tìm thấy hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); DialogResult = DialogResult.Cancel; Close(); return; }

var dichVu = db.Ctdvs .AsNoTracking() .Where(c => c.MaCtdp == hoaDon.MaCtdp && c.DaXoa != true) .OrderBy(c => c.MaDv) .Select(c => new { TenDV = c.MaDvNavigation.TenDv, DonGia = c.MaDvNavigation.DonGia, SL = c.Sl, ThanhTien = c.MaDvNavigation.DonGia * c.Sl }) .ToList();

decimal tienPhong = hoaDon.ThanhTien ?? 0; decimal tienDichVu = dichVu.Sum(d => d.ThanhTien); decimal tongTien = tienPhong + tienDichVu;

txtMaHoaDon.Text = hoaDon.MaHd; dtpNgayHD.Value = hoaDon.NgHd ?? DateTime.Today; txtTenNV.Text = hoaDon.TenNV ?? ""; txtTenKH.Text = hoaDon.TenKH ?? ""; txtMaPhong.Text = hoaDon.MaPH; txtTenLP.Text = hoaDon.TenLPH ?? ""; txtTienThuePhong.Text = DinhDangTien(tienPhong); lbTongTriGia.Text = "Tổng tiền: " + DinhDangTien(tongTien);

TimeSpan thoiGianThue = hoaDon.CheckOut - hoaDon.CheckIn; if (hoaDon.TheoGio == true || thoiGianThue.Days < 1) { txtSoNgayThuePhong.Text = Math.Max(1, (int)Math.Ceiling(thoiGianThue.TotalHours)) + " giờ"; } else { txtSoNgayThuePhong.Text = thoiGianThue.Days.ToString(); }

dtgDichVuDaDung.DataSource = dichVu;

dtgDichVuDaDung.Columns["TenDV"].HeaderText = "Tên dịch vụ"; dtgDichVuDaDung.Columns["DonGia"].HeaderText = "Đơn giá"; dtgDichVuDaDung.Columns["SL"].HeaderText = "Số lượng"; dtgDichVuDaDung.Columns["ThanhTien"].HeaderText = "Thành tiền";

dtgDichVuDaDung.Columns["DonGia"].DefaultCellStyle.Format = "N0"; dtgDichVuDaDung.Columns["DonGia"].DefaultCellStyle.FormatProvider = viVN; dtgDichVuDaDung.Columns["DonGia"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; dtgDichVuDaDung.Columns["SL"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; dtgDichVuDaDung.Columns["ThanhTien"].DefaultCellStyle.Format = "N0"; dtgDichVuDaDung.Columns["ThanhTien"].DefaultCellStyle.FormatProvider = viVN; dtgDichVuDaDung.Columns["ThanhTien"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

dtgDichVuDaDung.ClearSelection(); }

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 283

catch (Exception ex) { MessageBox.Show("Lỗi khi load hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); DialogResult = DialogResult.Cancel; Close(); } }

private void Printer_Click(object sender, EventArgs e) { if (!XuatHoaDonRaPDF()) { return; }

try { using var db = new HotelManagementContext();

db.HoaDons .Where(h => h.MaHd == maHD && h.DaXoa != true) .ExecuteUpdate(s => s.SetProperty(h => h.TrangThai, "Đã thanh toán")); } catch (Exception ex) { MessageBox.Show("Đã xuất PDF nhưng không cập nhật được trạng thái thanh toán: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning); } }

private BaseFont TaoFontTiengViet() { string thuMucFont = Environment.GetFolderPath(Environment.SpecialFolder.Fonts); string[] danhSachFont = { "arial.ttf", "tahoma.ttf", "segoeui.ttf", "times.ttf" };

foreach (string tenFile in danhSachFont) { string duongDan = Path.Combine(thuMucFont, tenFile); if (File.Exists(duongDan)) { return BaseFont.CreateFont(duongDan, BaseFont.IDENTITY_H, BaseFont.EMBEDDED); } }

throw new FileNotFoundException("Không tìm thấy font hỗ trợ tiếng Việt trong thư mục Fonts của Windows."); }

private PdfPCell TaoO(string noiDung, iTextSharp.text.Font font, int canLe, bool coVien) { PdfPCell o = new PdfPCell(new Phrase(noiDung, font)); o.HorizontalAlignment = canLe; o.VerticalAlignment = Element.ALIGN_MIDDLE; o.Padding = 5; if (!coVien) { o.Border = iTextSharp.text.Rectangle.NO_BORDER; } return o; }

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 284

private bool XuatHoaDonRaPDF() { using SaveFileDialog save = new SaveFileDialog(); save.Title = "Xuất hóa đơn"; save.Filter = "PDF files (*.pdf)|*.pdf"; save.FileName = "HoaDon_" + txtMaHoaDon.Text + ".pdf";

if (save.ShowDialog() != DialogResult.OK) { return false; }

try { BaseFont baseFont = TaoFontTiengViet(); iTextSharp.text.Font fontTieuDe = new iTextSharp.text.Font(baseFont, 18, iTextSharp.text.Font.BOLD); iTextSharp.text.Font fontDam = new iTextSharp.text.Font(baseFont, 12, iTextSharp.text.Font.BOLD); iTextSharp.text.Font fontThuong = new iTextSharp.text.Font(baseFont, 12, iTextSharp.text.Font.NORMAL); iTextSharp.text.Font fontNghieng = new iTextSharp.text.Font(baseFont, 12, iTextSharp.text.Font.ITALIC); iTextSharp.text.Font fontTong = new iTextSharp.text.Font(baseFont, 14, iTextSharp.text.Font.BOLD);

Document doc = new Document(PageSize.A4, 25, 25, 30, 30);

using (FileStream stream = new FileStream(save.FileName, FileMode.Create)) { PdfWriter.GetInstance(doc, stream); doc.Open();

Paragraph title = new Paragraph("HÓA ĐƠN THANH TOÁN", fontTieuDe); title.Alignment = Element.ALIGN_CENTER; title.SpacingAfter = 20; doc.Add(title);

PdfPTable tableInfo = new PdfPTable(2); tableInfo.WidthPercentage = 100; tableInfo.SetWidths(new float[] { 1.2f, 2.8f });

string[,] thongTin = { { "Mã hóa đơn:", txtMaHoaDon.Text }, { "Ngày lập:", dtpNgayHD.Value.ToString("dd/MM/yyyy") }, { "Khách hàng:", txtTenKH.Text }, { "Nhân viên lập:", txtTenNV.Text }, { "Phòng:", txtMaPhong.Text }, { "Loại phòng:", txtTenLP.Text }, { "Thời gian thuê:", txtSoNgayThuePhong.Text }, { "Tiền thuê phòng:", txtTienThuePhong.Text } };

for (int i = 0; i < thongTin.GetLength(0); i++) { tableInfo.AddCell(TaoO(thongTin[i, 0], fontDam, Element.ALIGN_LEFT, false)); tableInfo.AddCell(TaoO(thongTin[i, 1], fontThuong, Element.ALIGN_LEFT, false)); } doc.Add(tableInfo);

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 285

Paragraph tieuDeDichVu = new Paragraph("DỊCH VỤ ĐÃ SỬ DỤNG:", fontNghieng); tieuDeDichVu.SpacingBefore = 15; tieuDeDichVu.SpacingAfter = 8; doc.Add(tieuDeDichVu);

PdfPTable tableDV = new PdfPTable(4); tableDV.WidthPercentage = 100; tableDV.SetWidths(new float[] { 3, 2, 1.5f, 2 });

BaseColor mauTieuDe = new BaseColor(230, 230, 230); string[] tieuDeCot = { "Tên dịch vụ", "Đơn giá", "Số lượng", "Thành tiền" }; foreach (string tieuDeCotDV in tieuDeCot) { PdfPCell oTieuDe = TaoO(tieuDeCotDV, fontDam, Element.ALIGN_CENTER, true); oTieuDe.BackgroundColor = mauTieuDe; tableDV.AddCell(oTieuDe); }

int soDong = 0; foreach (DataGridViewRow row in dtgDichVuDaDung.Rows) { if (row.IsNewRow) { continue; }

decimal donGia = Convert.ToDecimal(row.Cells["DonGia"].Value ??

0. ;

decimal thanhTien = Convert.ToDecimal(row.Cells["ThanhTien"].Value ?? 0);

tableDV.AddCell(TaoO(row.Cells["TenDV"].Value?.ToString() ?? "", fontThuong, Element.ALIGN_LEFT, true)); tableDV.AddCell(TaoO(donGia.ToString("N0", viVN), fontThuong, Element.ALIGN_RIGHT, true)); tableDV.AddCell(TaoO(row.Cells["SL"].Value?.ToString() ?? "", fontThuong, Element.ALIGN_CENTER, true)); tableDV.AddCell(TaoO(thanhTien.ToString("N0", viVN), fontThuong, Element.ALIGN_RIGHT, true)); soDong++; }

if (soDong == 0) { PdfPCell oTrong = TaoO("Không sử dụng dịch vụ", fontNghieng, Element.ALIGN_CENTER, true); oTrong.Colspan = 4; tableDV.AddCell(oTrong); }

doc.Add(tableDV);

Paragraph total = new Paragraph(lbTongTriGia.Text, fontTong); total.Alignment = Element.ALIGN_RIGHT; total.SpacingBefore = 15; doc.Add(total);

Paragraph camOn = new Paragraph("Cảm ơn quý khách!", fontNghieng); camOn.Alignment = Element.ALIGN_CENTER; camOn.SpacingBefore = 30; doc.Add(camOn);

doc.Close();

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 286

}

MessageBox.Show("Xuất hóa đơn PDF thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); return true; } catch (IOException) { MessageBox.Show("Không ghi được file. Có thể file đang được mở, hãy đóng lại rồi thử lần nữa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return false; } catch (Exception ex) { MessageBox.Show("Lỗi khi xuất hóa đơn PDF: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return false; } } } }

### Bước 5: Click chuột phải vào folder HoaDon → Add → Forms( Windows Forms) →

### tạo một form cho phép xem lại thông tin đặt/thuê phòng trong khách sạn là

### FormDanhSachHoaDon.cs

### Bước 6: Thiết kế giao diện FormDanhSachHoaDon.cs theo mẫu như sau:

### Mã nguồn tham khảo trong file FormDanhSachHoaDon.Designer.cs tạm thời như

### sau:

namespace HotelManagement.HoaDon { partial class FormDanhSachHoaDon { /// <summary> /// Required designer variable. /// </summary> private System.ComponentModel. IContainer components = null;

/// <summary> /// Clean up any resources being used. /// </summary> /// <param name=" disposing "> true if managed resources should be disposed; otherwise, false. </param> protected override void Dispose ( bool disposing) { if ( disposing && (components != null)) { components. Dispose (); } base. Dispose ( disposing); }

#region Windows Form Designer generated code

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 287

/// <summary> /// Required method for Designer support - do not modify /// the contents of this method with the code editor. /// </summary> private void InitializeComponent () { dtgDanhSachHoaDon = new DataGridView (); txtTimKiem = new TextBox (); pictureBox1 = new PictureBox (); btnXuatExcel = new Button (); dtpNgayLap = new DateTimePicker (); ((System.ComponentModel. ISupportInitialize)dtgDanhSachHoaDon). BeginInit (); ((System.ComponentModel. ISupportInitialize)pictureBox1). BeginInit (); SuspendLayout (); // // dtgDanhSachHoaDon // dtgDanhSachHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize; dtgDanhSachHoaDon.Location = new Point (13, 118); dtgDanhSachHoaDon.Margin = new Padding (3, 4, 3, 4); dtgDanhSachHoaDon.Name = "dtgDanhSachHoaDon"; dtgDanhSachHoaDon.RowHeadersWidth = 51; dtgDanhSachHoaDon.RowTemplate.Height = 24; dtgDanhSachHoaDon.Size = new Size (1187, 624); dtgDanhSachHoaDon.TabIndex = 0; // // txtTimKiem // txtTimKiem.Font = new Font ( "Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0); txtTimKiem.Location = new Point (138, 29); txtTimKiem.Margin = new Padding (3, 4, 3, 4); txtTimKiem.Name = "txtTimKiem"; txtTimKiem.Size = new Size (187, 32); txtTimKiem.TabIndex = 26; txtTimKiem.TextChanged += txtTimKiem_TextChanged; // // pictureBox1 // pictureBox1.Image = Properties. Resources.search; pictureBox1.Location = new Point (93, 22); pictureBox1.Margin = new Padding (3, 4, 3, 4); pictureBox1.Name = "pictureBox1"; pictureBox1.Size = new Size (39, 46); pictureBox1.TabIndex = 27; pictureBox1.TabStop = false; // // btnXuatExcel // btnXuatExcel.BackColor = Color.DarkTurquoise; btnXuatExcel.Font = new Font ( "Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0); btnXuatExcel.Location = new Point (946, 29); btnXuatExcel.Margin = new Padding (3, 4, 3, 4); btnXuatExcel.Name = "btnXuatExcel"; btnXuatExcel.Size = new Size (167, 46); btnXuatExcel.TabIndex = 28; btnXuatExcel.Text = "Xuất file Excel"; btnXuatExcel.UseVisualStyleBackColor = false; btnXuatExcel.Click += btnXuatExcel_Click; // // dtpNgayLap //

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 288

dtpNgayLap.Font = new Font ( "Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0); dtpNgayLap.Location = new Point (450, 29); dtpNgayLap.Margin = new Padding (3, 4, 3, 4); dtpNgayLap.Name = "dtpNgayLap"; dtpNgayLap.Size = new Size (361, 32); dtpNgayLap.TabIndex = 29; // // FormDanhSachHoaDon // AutoScaleDimensions = new SizeF (8F, 20F); AutoScaleMode = AutoScaleMode.Font; ClientSize = new Size (1212, 756); Controls. Add(dtpNgayLap); Controls. Add(btnXuatExcel); Controls. Add(pictureBox1); Controls. Add(txtTimKiem); Controls. Add(dtgDanhSachHoaDon); Margin = new Padding (3, 4, 3, 4); Name = "FormDanhSachHoaDon"; StartPosition = FormStartPosition.CenterScreen; Text = "Danh sách hóa đơn"; Load += FormDanhSachHoaDon_Load; ((System.ComponentModel. ISupportInitialize)dtgDanhSachHoaDon). EndInit (); ((System.ComponentModel. ISupportInitialize)pictureBox1). EndInit (); ResumeLayout ( false); PerformLayout ();

}

#endregion

private System.Windows.Forms. DataGridView dtgDanhSachHoaDon; private System.Windows.Forms. TextBox txtTimKiem; private System.Windows.Forms. PictureBox pictureBox1; private System.Windows.Forms. Button btnXuatExcel; private System.Windows.Forms. DateTimePicker dtpNgayLap; } }

### Bước 7: SV sử dụng mã nguồn tạm thời sau để xử lý chức năng trong file

### FormDanhSachHoaDon.cs

using System; using System.Collections.Generic; using System.ComponentModel; using System.Data; using System.Drawing; using System.Globalization; using System.Text; using System.Windows.Forms; using ClosedXML.Excel; using HotelManagement.Models; using Microsoft.EntityFrameworkCore;

namespace HotelManagement.HoaDon { public partial class FormDanhSachHoaDon : Form { private readonly CultureInfo viVN = new CultureInfo("vi - VN");

public FormDanhSachHoaDon() { InitializeComponent(); }

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 289

private void FormDanhSachHoaDon_Load(object sender, EventArgs e) { dtpNgayLap.Format = DateTimePickerFormat.Short; dtpNgayLap.ShowCheckBox = true; dtpNgayLap.Checked = false;

dtpNgayLap.ValueChanged += dtpNgayLap_ValueChanged; dtgDanhSachHoaDon.CellClick += dtgDanhSachHoaDon_CellClick;

LoadDanhSachHoaDon(); }

private void KhoiTaoBangDuLieu() { dtgDanhSachHoaDon.AllowUserToAddRows = false; dtgDanhSachHoaDon.AllowUserToDeleteRows = false; dtgDanhSachHoaDon.AllowUserToResizeRows = false; dtgDanhSachHoaDon.ReadOnly = true; dtgDanhSachHoaDon.MultiSelect = false; dtgDanhSachHoaDon.RowHeadersVisible = false; dtgDanhSachHoaDon.SelectionMode = DataGridViewSelectionMode.FullRowSelect; dtgDanhSachHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; dtgDanhSachHoaDon.RowTemplate.Height = 40;

dtgDanhSachHoaDon.Columns.Add("MaHD", "Mã hóa đơn"); dtgDanhSachHoaDon.Columns.Add("NgHD", "Ngày lập"); dtgDanhSachHoaDon.Columns.Add("TenNV", "Nhân viên"); dtgDanhSachHoaDon.Columns.Add("MaCTDP", "Mã chi tiết phiếu"); dtgDanhSachHoaDon.Columns.Add("TriGia", "Trị giá"); dtgDanhSachHoaDon.Columns.Add("TrangThai", "Trạng thái");

dtgDanhSachHoaDon.Columns["MaHD"].FillWeight = 14; dtgDanhSachHoaDon.Columns["NgHD"].FillWeight = 14; dtgDanhSachHoaDon.Columns["TenNV"].FillWeight = 20; dtgDanhSachHoaDon.Columns["MaCTDP"].FillWeight = 16; dtgDanhSachHoaDon.Columns["TriGia"].FillWeight = 16; dtgDanhSachHoaDon.Columns["TrangThai"].FillWeight = 16;

dtgDanhSachHoaDon.Columns["NgHD"].DefaultCellStyle.Format = "dd/MM/yyyy"; dtgDanhSachHoaDon.Columns["TriGia"].DefaultCellStyle.Format = "N0"; dtgDanhSachHoaDon.Columns["TriGia"].DefaultCellStyle.FormatProvider = viVN; dtgDanhSachHoaDon.Columns["TriGia"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

DataGridViewImageColumn colXemChiTiet = new DataGridViewImageColumn(); colXemChiTiet.Name = "XemChiTiet"; colXemChiTiet.HeaderText = "Chi tiết"; colXemChiTiet.ToolTipText = "Xem thông tin chi tiết hóa đơn"; colXemChiTiet.ImageLayout = DataGridViewImageCellLayout.Zoom; colXemChiTiet.AutoSizeMode = DataGridViewAutoSizeColumnMode.None; colXemChiTiet.Width = 70; dtgDanhSachHoaDon.Columns.Add(colXemChiTiet); }

public void LoadDanhSachHoaDon() { try { if (dtgDanhSachHoaDon.Columns.Count == 0) { KhoiTaoBangDuLieu(); }

string tuKhoa = txtTimKiem.Text.Trim();

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 290

using var db = new HotelManagementContext();

var query = db.HoaDons .AsNoTracking() .Where(h => h.DaXoa != true);

if (tuKhoa.Length > 0) { query = query.Where(h => h.MaHd.Contains(tuKhoa) ||

h.MaCtdpNavigation.MaPtNavigation.MaKhNavigation.CccdPassport.Contains(tuKhoa) ||

h.MaCtdpNavigation.MaPtNavigation.MaKhNavigation.TenKh.Contains(tuKhoa)); }

if (dtpNgayLap.Checked) { DateTime ngayBatDau = dtpNgayLap.Value.Date; DateTime ngayKetThuc = ngayBatDau.AddDays(1); query = query.Where(h => h.NgHd >= ngayBatDau && h.NgHd < ngayKetThuc); }

var danhSach = query .OrderByDescending(h => h.NgHd) .ThenBy(h => h.MaHd) .Select(h => new { h.MaHd, h.NgHd, TenNV = h.MaNvNavigation.TenNv, h.MaCtdp, TriGia = (h.MaCtdpNavigation.ThanhTien ?? 0) + h.MaCtdpNavigation.Ctdvs .Where(c => c.DaXoa != true) .Sum(c => c.MaDvNavigation.DonGia * c.Sl), h.TrangThai }) .ToList();

Image iconChiTiet = Properties.Resources.details;

dtgDanhSachHoaDon.Rows.Clear(); foreach (var hd in danhSach) { dtgDanhSachHoaDon.Rows.Add( hd.MaHd, hd.NgHd, hd.TenNV ?? "", hd.MaCtdp, hd.TriGia, hd.TrangThai, iconChiTiet ); }

dtgDanhSachHoaDon.ClearSelection(); } catch (Exception ex) { MessageBox.Show("Lỗi khi load danh sách hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); } }

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 291

private void btnXuatExcel_Click(object sender, EventArgs e) { if (dtgDanhSachHoaDon.Rows.Count == 0) { MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

using SaveFileDialog saveDialog = new SaveFileDialog(); saveDialog.Title = "Xuất danh sách hóa đơn"; saveDialog.Filter = "Excel Workbook (*.xlsx)|*.xlsx"; saveDialog.FileName = "DanhSachHoaDon_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".xlsx";

if (saveDialog.ShowDialog() != DialogResult.OK) { return; }

try { string[] tenCot = { "MaHD", "NgHD", "TenNV", "MaCTDP", "TriGia", "TrangThai" };

using (XLWorkbook workbook = new XLWorkbook()) { IXLWorksheet worksheet = workbook.Worksheets.Add("Danh sách hóa đơn");

for (int j = 0; j < tenCot.Length; j++) { worksheet.Cell(1, j + 1).Value = dtgDanhSachHoaDon.Columns[tenCot[j]].HeaderText; } worksheet.Range(1, 1, 1, tenCot.Length).Style.Font.Bold = true;

for (int i = 0; i < dtgDanhSachHoaDon.Rows.Count; i++) { for (int j = 0; j < tenCot.Length; j++) { IXLCell o = worksheet.Cell(i + 2, j + 1); object giaTri = dtgDanhSachHoaDon.Rows[i].Cells[tenCot[j]].Value;

switch (giaTri) { case DateTime ngay: o.Value = ngay; o.Style.NumberFormat.Format = "dd/MM/yyyy"; break; case decimal soTien: o.Value = soTien; o.Style.NumberFormat.Format = "#,##0"; break; default: o.Value = giaTri?.ToString() ?? ""; break; } } }

worksheet.Columns().AdjustToContents(); workbook.SaveAs(saveDialog.FileName); }

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 292

DialogResult moFile = MessageBox.Show( "Xuất dữ liệu thành công! \ nBạn có muốn mở file vừa xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

if (moFile == DialogResult.Yes) { System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(saveDialog.FileName) { UseShellExecute = true }); } } catch (IOException) { MessageBox.Show("Không ghi được file. Có thể file đang được mở trong Excel, hãy đóng lại rồi thử lần nữa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); } catch (Exception ex) { MessageBox.Show("Lỗi khi xuất file Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); } }

private void TimKiemHoaDon() { LoadDanhSachHoaDon(); }

private void txtTimKiem_TextChanged(object sender, EventArgs e) { TimKiemHoaDon(); }

private void dtpNgayLap_ValueChanged(object sender, EventArgs e) { TimKiemHoaDon(); }

private void dtgDanhSachHoaDon_CellClick(object sender, DataGridViewCellEventArgs e) { if (e.RowIndex < 0 || e.ColumnIndex < 0) { return; }

if (dtgDanhSachHoaDon.Columns[e.ColumnIndex].Name != "XemChiTiet") { return; }

string maHD = dtgDanhSachHoaDon.Rows[e.RowIndex].Cells["MaHD"].Value?.ToString(); if (string.IsNullOrEmpty(maHD)) { return; }

using (FormHoaDon frm = new FormHoaDon(maHD)) {

Lập trình trực quan

Ths. Nguyễn Thiện Dương Trang 293

frm.ShowDialog(); }

LoadDanhSachHoaDon(); } } } Bước 8: Chỉnh sửa lại hàm private void button9_Click(object sender,

EventArgs e)trong file FormMain.cs theo nội dung như sau: private void button10_Click ( object sender, EventArgs e) { Form formCon = new HoaDon. FormDanhSachHoaDon (); formCon.TopLevel = false; formCon.FormBorderStyle = FormBorderStyle.None; formCon.Dock = DockStyle.Fill; XoaNoiDungPanelMain (); // hàm có trong bản FormMain mình gửi trước; nếu chưa có, dùng panelMain.Controls.Clear(); panelMain.Controls. Add( formCon); formCon. Show(); }

4. Xây dựng giao diện và chức năng quản lý thông tin tài khoản và quyền đăng nhập

vào hệ thống

Bước 1: Click chuột phải vào thư mục project → Add → New Folder→ Đặt tên folder

là “TaiKhoan”

Bước 2: Click chuột phải vào folder TaiKhoan → Add → Forms( Windows Forms) →

tạo một form thể hiện danh sách loại phòng khách sạn là FormDanhSachTaiKhoan.cs

Bước 3: Thiết kế giao diện FormDanhSachTaiKhoan.cs theo mẫu như sau:

Mã nguồn tham khảo trong file FormDanhSachTaiKhoan.Designer.cs tạm thời như

sau: namespace HotelManagement.TaiKhoan { partial class FormDanhSachTaiKhoan { /// <summary> /// Required designer variable. /// </summary> private System.ComponentModel. IContainer components = null;

/// <summary> /// Clean up any resources being used. /// </summary>

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 294

/// <param name=" disposing "> true if managed resources should be disposed; otherwise, false. </param> protected override void Dispose ( bool disposing) { if ( disposing && (components != null)) { components. Dispose (); } base. Dispose ( disposing); }

#region Windows Form Designer generated code

/// <summary> /// Required method for Designer support - do not modify /// the contents of this method with the code editor. /// </summary> private void InitializeComponent () { this.btnThemMoi = new System.Windows.Forms. Button (); this.dtgDanhSachTaiKhoan = new System.Windows.Forms. DataGridView (); this.btnXuatExcel = new System.Windows.Forms. Button (); this.txtTimKiem = new System.Windows.Forms. TextBox (); this.pictureBox1 = new System.Windows.Forms. PictureBox ();

((System.ComponentModel. ISupportInitialize)( this.dtgDanhSachTaiKhoan)). BeginInit (); ((System.ComponentModel. ISupportInitialize)( this.pictureBox1)). BeginInit (); this. SuspendLayout (); // // btnThemMoi // this.btnThemMoi.BackColor = System.Drawing.Color.LightPink; this.btnThemMoi.Font = new System.Drawing.Font( "Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (( byte)(0))); this.btnThemMoi.Location = new System.Drawing.Point(779, 11); this.btnThemMoi.Name = "btnThemMoi"; this.btnThemMoi.Size = new System.Drawing.Size(167, 37); this.btnThemMoi.TabIndex = 30; this.btnThemMoi.Text = "Thêm mới"; this.btnThemMoi.UseVisualStyleBackColor = false; // this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click); // // dtgDanhSachTaiKhoan // this.dtgDanhSachTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize; this.dtgDanhSachTaiKhoan.Location = new System.Drawing.Point(12, 61); this.dtgDanhSachTaiKhoan.Name = "dtgDanhSachTaiKhoan"; this.dtgDanhSachTaiKhoan.RowHeadersWidth = 51; this.dtgDanhSachTaiKhoan.RowTemplate.Height = 24; this.dtgDanhSachTaiKhoan.Size = new System.Drawing.Size(955, 593); this.dtgDanhSachTaiKhoan.TabIndex = 29; // this.dtgDanhSachTaiKhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDanhSachTaiKhoan_CellClick); // // btnXuatExcel // this.btnXuatExcel.BackColor = System.Drawing.Color.DarkTurquoise; this.btnXuatExcel.Font = new System.Drawing.Font( "Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (( byte)(0))); this.btnXuatExcel.Location = new System.Drawing.Point(549, 11); this.btnXuatExcel.Name = "btnXuatExcel"; this.btnXuatExcel.Size = new System.Drawing.Size(167, 37); this.btnXuatExcel.TabIndex = 28; this.btnXuatExcel.Text = "Xuất file Excel"; this.btnXuatExcel.UseVisualStyleBackColor = false;

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 295

//this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click); // // txtTimKiem // this.txtTimKiem.Font = new System.Drawing.Font( "Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (( byte)(0))); this.txtTimKiem.Location = new System.Drawing.Point(73, 16); this.txtTimKiem.Name = "txtTimKiem"; this.txtTimKiem.Size = new System.Drawing.Size(187, 32); this.txtTimKiem.TabIndex = 26; //this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged); // // pictureBox1 // this.pictureBox1.Image = global::HotelManagement.Properties.Resources.search; this.pictureBox1.Location = new System.Drawing. Point (28, 11); this.pictureBox1.Name = "pictureBox1"; this.pictureBox1.Size = new System.Drawing. Size (39, 37); this.pictureBox1.TabIndex = 27; this.pictureBox1.TabStop = false; // // FormDanhSachTaiKhoan // this.AutoScaleDimensions = new System.Drawing. SizeF (8F, 16F); this.AutoScaleMode = System.Windows.Forms. AutoScaleMode.Font; this.ClientSize = new System.Drawing. Size (979, 666); this.Controls. Add( this.btnThemMoi); this.Controls. Add( this.dtgDanhSachTaiKhoan); this.Controls. Add( this.btnXuatExcel); this.Controls. Add( this.pictureBox1); this.Controls. Add( this.txtTimKiem); this.Name = "FormDanhSachTaiKhoan"; this.Text = "FormDanhSachTaiKhoan"; //this.Load += new System.EventHandler(this.FormDanhSachTaiKhoan_Load);

((System.ComponentModel. ISupportInitialize)( this.dtgDanhSachTaiKhoan)). EndInit (); ((System.ComponentModel. ISupportInitialize)( this.pictureBox1)). EndInit (); this. ResumeLayout ( false); this. PerformLayout ();

}

#endregion

private System.Windows.Forms. Button btnThemMoi; private System.Windows.Forms. DataGridView dtgDanhSachTaiKhoan; private System.Windows.Forms. Button btnXuatExcel; private System.Windows.Forms. PictureBox pictureBox1; private System.Windows.Forms. TextBox txtTimKiem; } }

### Bước 4: SV sử dụng mã nguồn tạm thời sau để xử lý chức năng trong file

### FormDanhSachTaiKhoan.cs

using System; using System.Collections.Generic; using System.ComponentModel; using System.Data; using System.Drawing; using System.Text; using System.Windows.Forms;

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 296

using ClosedXML.Excel; using HotelManagement.DangNhap; using HotelManagement.Models; using Microsoft.EntityFrameworkCore;

namespace HotelManagement.TaiKhoan { public partial class FormDanhSachTaiKhoan : Form { public FormDanhSachTaiKhoan() { InitializeComponent();

Load += FormDanhSachTaiKhoan_Load; txtTimKiem.TextChanged += txtTimKiem_TextChanged; btnXuatExcel.Click += btnXuatExcel_Click; btnThemMoi.Click += btnThemMoi_Click; dtgDanhSachTaiKhoan.CellClick += dtgDanhSachTaiKhoan_CellClick; }

private void FormDanhSachTaiKhoan_Load(object sender, EventArgs e) { LoadDanhSachTaiKhoan(); }

private void KhoiTaoBangDuLieu() { dtgDanhSachTaiKhoan.AllowUserToAddRows = false; dtgDanhSachTaiKhoan.AllowUserToDeleteRows = false; dtgDanhSachTaiKhoan.AllowUserToResizeRows = false; dtgDanhSachTaiKhoan.ReadOnly = true; dtgDanhSachTaiKhoan.MultiSelect = false; dtgDanhSachTaiKhoan.RowHeadersVisible = false; dtgDanhSachTaiKhoan.SelectionMode = DataGridViewSelectionMode.FullRowSelect; dtgDanhSachTaiKhoan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; dtgDanhSachTaiKhoan.RowTemplate.Height = 40;

DataGridViewImageColumn iconCol = new DataGridViewImageColumn(); iconCol.Name = "Icon"; iconCol.HeaderText = ""; iconCol.ImageLayout = DataGridViewImageCellLayout.Zoom; iconCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.None; iconCol.Width = 40; dtgDanhSachTaiKhoan.Columns.Add(iconCol);

dtgDanhSachTaiKhoan.Columns.Add("TenTK", "Tên tài khoản"); dtgDanhSachTaiKhoan.Columns.Add("TenNV", "Họ và tên NV"); dtgDanhSachTaiKhoan.Columns.Add("CapDoQuyen", "Cấp độ quyền");

dtgDanhSachTaiKhoan.Columns["TenTK"].FillWeight = 35; dtgDanhSachTaiKhoan.Columns["TenNV"].FillWeight = 40; dtgDanhSachTaiKhoan.Columns["CapDoQuyen"].FillWeight = 25;

DataGridViewImageColumn suaCol = new DataGridViewImageColumn(); suaCol.Name = "Sua"; suaCol.HeaderText = "Sửa"; suaCol.ImageLayout = DataGridViewImageCellLayout.Zoom; suaCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.None; suaCol.Width = 50; dtgDanhSachTaiKhoan.Columns.Add(suaCol);

DataGridViewImageColumn xoaCol = new DataGridViewImageColumn(); xoaCol.Name = "Xoa"; xoaCol.HeaderText = "Xóa";

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 297

xoaCol.ImageLayout = DataGridViewImageCellLayout.Zoom; xoaCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.None; xoaCol.Width = 50; dtgDanhSachTaiKhoan.Columns.Add(xoaCol); }

private string TenQuyen(int capDo) { switch (capDo) { case 1: return "Cấp 1 - Nhân viên"; case 2: return "Cấp 2 - Quản lý"; case 3: return "Cấp 3 - Admin"; default: return "Cấp " + capDo; } }

private void LoadDanhSachTaiKhoan(string tuKhoa = "") { try { if (dtgDanhSachTaiKhoan.Columns.Count == 0) { KhoiTaoBangDuLieu(); }

using var db = new HotelManagementContext();

var query = db.TaiKhoans .AsNoTracking() .Where(t => t.DaXoa != true);

if (!string.IsNullOrWhiteSpace(tuKhoa)) { query = query.Where(t => t.TenTk.Contains(tuKhoa) || t.MaNv.Contains(tuKhoa) || t.MaNvNavigation.TenNv.Contains(tuKhoa)); }

var danhSach = query .OrderByDescending(t => t.CapDoQuyen) .ThenBy(t => t.TenTk) .Select(t => new { t.TenTk, TenNV = t.MaNvNavigation.TenNv, t.CapDoQuyen }) .ToList();

Image iconTaiKhoan = Properties.Resources.TaiKhoan; Image iconSua = Properties.Resources.edit; Image iconXoa = Properties.Resources.delete;

dtgDanhSachTaiKhoan.Rows.Clear(); foreach (var tk in danhSach) { dtgDanhSachTaiKhoan.Rows.Add( iconTaiKhoan, tk.TenTk, tk.TenNV ?? "",

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 298

TenQuyen(tk.CapDoQuyen), iconSua, iconXoa ); }

dtgDanhSachTaiKhoan.ClearSelection(); } catch (Exception ex) { MessageBox.Show("Lỗi khi load danh sách tài khoản: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); } }

private void txtTimKiem_TextChanged(object sender, EventArgs e) { LoadDanhSachTaiKhoan(txtTimKiem.Text.Trim()); }

private void dtgDanhSachTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e) { if (e.RowIndex < 0 || e.ColumnIndex < 0) { return; }

string tenCot = dtgDanhSachTaiKhoan.Columns[e.ColumnIndex].Name; if (tenCot != "Sua" && tenCot != "Xoa") { return; }

string tenTK = dtgDanhSachTaiKhoan.Rows[e.RowIndex].Cells["TenTK"].Value?.ToString(); if (string.IsNullOrEmpty(tenTK)) { return; }

if (tenCot == "Sua") { using (FormSuaTaiKhoan frmSua = new FormSuaTaiKhoan(tenTK)) { if (frmSua.ShowDialog() == DialogResult.OK) { LoadDanhSachTaiKhoan(txtTimKiem.Text.Trim()); } } return; }

if (MessageBox.Show($"Bạn có chắc chắn muốn xóa tài khoản '{tenTK}'?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) { XoaTaiKhoan(tenTK); } }

private void XoaTaiKhoan(string tenTK) { try { using var db = new HotelManagementContext();

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 299

var taiKhoan = db.TaiKhoans.FirstOrDefault(t => t.TenTk == tenTK && t.DaXoa != true);

if (taiKhoan == null) { MessageBox.Show("Không tìm thấy tài khoản cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); } else if (!string.IsNullOrEmpty(FormDangNhap.MaNV_DangNhap) && taiKhoan.MaNv == FormDangNhap.MaNV_DangNhap) { MessageBox.Show("Không thể xóa tài khoản đang đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); } else { taiKhoan.DaXoa = true; int kq = db.SaveChanges();

if (kq > 0) { MessageBox.Show("Xóa tài khoản thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); } else { MessageBox.Show("Xóa tài khoản thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); } } } catch (Exception ex) { MessageBox.Show("Lỗi khi xóa tài khoản: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }

LoadDanhSachTaiKhoan(txtTimKiem.Text.Trim()); }

private void btnXuatExcel_Click(object sender, EventArgs e) { if (dtgDanhSachTaiKhoan.Rows.Count == 0) { MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

using SaveFileDialog saveDialog = new SaveFileDialog(); saveDialog.Title = "Xuất danh sách tài khoản"; saveDialog.Filter = "Excel Workbook (*.xlsx)|*.xlsx"; saveDialog.FileName = "DanhSachTaiKhoan_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".xlsx";

if (saveDialog.ShowDialog() != DialogResult.OK) { return; }

try { string[] tenCot = { "TenTK", "TenNV", "CapDoQuyen" };

using (XLWorkbook workbook = new XLWorkbook()) {

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 300

IXLWorksheet worksheet = workbook.Worksheets.Add("Danh sách tài khoản");

for (int j = 0; j < tenCot.Length; j++) { worksheet.Cell(1, j + 1).Value = dtgDanhSachTaiKhoan.Columns[tenCot[j]].HeaderText; } worksheet.Range(1, 1, 1, tenCot.Length).Style.Font.Bold = true;

for (int i = 0; i < dtgDanhSachTaiKhoan.Rows.Count; i++) { for (int j = 0; j < tenCot.Length; j++) { worksheet.Cell(i + 2, j + 1).Value = dtgDanhSachTaiKhoan.Rows[i].Cells[tenCot[j]].Value?.ToString() ?? ""; } }

worksheet.Columns().AdjustToContents(); workbook.SaveAs(saveDialog.FileName); }

DialogResult moFile = MessageBox.Show( "Xuất dữ liệu thành công! \ nBạn có muốn mở file vừa xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

if (moFile == DialogResult.Yes) { System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(saveDialog.FileName) { UseShellExecute = true }); } } catch (IOException) { MessageBox.Show("Không ghi được file. Có thể file đang được mở trong Excel, hãy đóng lại rồi thử lần nữa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); } catch (Exception ex) { MessageBox.Show("Lỗi khi xuất file Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); } }

private void btnThemMoi_Click(object sender, EventArgs e) { using (FormThemTaiKhoan f = new FormThemTaiKhoan()) { if (f.ShowDialog() == DialogResult.OK) { LoadDanhSachTaiKhoan(txtTimKiem.Text.Trim()); } } } } }

### Bước 5: Chỉnh sửa lại hàm private void button5_Click(object sender,

### EventArgs e)trong file FormMain.cs theo nội dung như sau:

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 301

private void button5_Click ( object sender, EventArgs e) { Form formCon = new TaiKhoan. FormDanhSachTaiKhoan (); formCon.TopLevel = false; formCon.FormBorderStyle = FormBorderStyle.None; formCon.Dock = DockStyle.Fill; XoaNoiDungPanelMain (); panelMain.Controls. Add( formCon); formCon. Show(); }

### Bước 6: Click chuột phải vào folder TaiKhoan → Add → Forms( Windows Forms) →

### tạo một form để xây dựng giao diện và chức năng thêm mới thông tin 1 dịch vụ là

### FormThemTaiKhoan.cs

### Bước 7: Thiết kế giao diện FormThemTaiKhoan.cs theo mẫu như sau:

### Mã nguồn tham khảo trong file FormThemTaiKhoan.Designer.cs tạm thời như sau:

namespace HotelManagement.TaiKhoan { partial class FormThemTaiKhoan { /// <summary> /// Required designer variable. /// </summary> private System.ComponentModel. IContainer components = null;

/// <summary> /// Clean up any resources being used. /// </summary> /// <param name=" disposing "> true if managed resources should be disposed; otherwise, false. </param> protected override void Dispose ( bool disposing) { if ( disposing && (components != null)) { components. Dispose (); } base. Dispose ( disposing); }

#region Windows Form Designer generated code

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 302

/// <summary> /// Required method for Designer support - do not modify /// the contents of this method with the code editor. /// </summary> private void InitializeComponent () { label6 = new Label (); btnThoat = new Button (); btnThemMoi = new Button (); cbCapDoQuyen = new ComboBox (); txtTenTK = new TextBox (); cbMaNV = new ComboBox (); label7 = new Label (); txtMatKhau = new TextBox (); label2 = new Label (); label1 = new Label (); label5 = new Label (); panel1 = new Panel (); panel1. SuspendLayout (); SuspendLayout (); // // label6 // label6.AutoSize = true; label6.Font = new Font ( "Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 0); label6.ForeColor = Color. FromArgb (192, 0, 0); label6.Location = new Point (139, 11); label6.Name = "label6"; label6.Size = new Size (316, 29); label6.TabIndex = 25; label6.Text = "Thêm thông tin tài khoản"; // // btnThoat // btnThoat.BackColor = SystemColors.GradientActiveCaption; btnThoat.Font = new Font ( "Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); btnThoat.Location = new Point (292, 390); btnThoat.Margin = new Padding (3, 4, 3, 4); btnThoat.Name = "btnThoat"; btnThoat.Size = new Size (137, 59); btnThoat.TabIndex = 24; btnThoat.Text = "Thoát"; btnThoat.UseVisualStyleBackColor = false; btnThoat.Click += btnThoat_Click; // // btnThemMoi // btnThemMoi.BackColor = Color.Moccasin; btnThemMoi.Font = new Font ( "Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); btnThemMoi.Location = new Point (97, 390); btnThemMoi.Margin = new Padding (3, 4, 3, 4); btnThemMoi.Name = "btnThemMoi"; btnThemMoi.Size = new Size (137, 59); btnThemMoi.TabIndex = 23; btnThemMoi.Text = "Thêm mới"; btnThemMoi.UseVisualStyleBackColor = false; btnThemMoi.Click += btnThemMoi_Click; // // cbCapDoQuyen // cbCapDoQuyen.Font = new Font ( "Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0); cbCapDoQuyen.FormattingEnabled = true;

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 303

cbCapDoQuyen.Items. AddRange ( new object [] { "3", "2", "1", "0"}); cbCapDoQuyen.Location = new Point (172, 230); cbCapDoQuyen.Margin = new Padding (3, 4, 3, 4); cbCapDoQuyen.Name = "cbCapDoQuyen"; cbCapDoQuyen.Size = new Size (290, 30); cbCapDoQuyen.TabIndex = 46; // // txtTenTK // txtTenTK.Font = new Font ( "Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); txtTenTK.Location = new Point (172, 94); txtTenTK.Margin = new Padding (3, 4, 3, 4); txtTenTK.Name = "txtTenTK"; txtTenTK.Size = new Size (290, 30); txtTenTK.TabIndex = 44; // // cbMaNV // cbMaNV.Font = new Font ( "Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0); cbMaNV.FormattingEnabled = true; cbMaNV.Items. AddRange ( new object [] { "Người quản trị hệ thống", "Quản lý khách sạn", "Nhân viên"}); cbMaNV.Location = new Point (172, 34); cbMaNV.Margin = new Padding(3, 4, 3, 4); cbMaNV.Name = "cbMaNV"; cbMaNV.Size = new Size (290, 30); cbMaNV.TabIndex = 43; // // label7 // label7.AutoSize = true; label7.Font = new Font ( "Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0); label7.Location = new Point (48, 164); label7.Name = "label7"; label7.Size = new Size (101, 26); label7.TabIndex = 42; label7.Text = "Mật khẩu"; // // txtMatKhau // txtMatKhau.Font = new Font ( "Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); txtMatKhau.Location = new Point (172, 164); txtMatKhau.Margin = new Padding(3, 4, 3, 4); txtMatKhau.Name = "txtMatKhau"; txtMatKhau.PasswordChar = '*'; txtMatKhau.Size = new Size (290, 30); txtMatKhau.TabIndex = 41; // // label2 // label2.AutoSize = true; label2.Font = new Font ( "Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0); label2.Location = new Point (10, 230); label2.Name = "label2"; label2.Size = new Size (147, 26); label2.TabIndex = 40; label2.Text = "Cấp độ quyền"; label2.TextAlign = ContentAlignment.TopCenter; // // label1 //

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 304

label1.AutoSize = true; label1.Font = new Font ( "Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0); label1.Location = new Point (10, 94); label1.Name = "label1"; label1.Size = new Size (142, 26); label1.TabIndex = 39; label1.Text = "Tên tài khoản"; // // label5 // label5.AutoSize = true; label5.Font = new Font ( "Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0); label5.Location = new Point (7, 34); label5.Name = "label5"; label5.Size = new Size (142, 26); label5.TabIndex = 37; label5.Text = "Mã nhân viên"; // // panel1 // panel1.Controls. Add(cbCapDoQuyen); panel1.Controls. Add(label5); panel1.Controls. Add(txtMatKhau); panel1.Controls. Add(txtTenTK); panel1.Controls. Add(cbMaNV); panel1.Controls. Add(label1); panel1.Controls. Add(label7); panel1.Controls. Add(label2); panel1.Location = new Point (5, 55); panel1.Margin = new Padding(3, 4, 3, 4); panel1.Name = "panel1"; panel1.Size = new Size (541, 304); panel1.TabIndex = 47; // // FormThemTaiKhoan // AutoScaleDimensions = new SizeF (8F, 20F); AutoScaleMode = AutoScaleMode.Font; ClientSize = new Size (562, 485); Controls. Add(label6); Controls. Add(btnThoat); Controls. Add(btnThemMoi); Controls. Add(panel1); Margin = new Padding(3, 4, 3, 4); Name = "FormThemTaiKhoan"; Text = "FormThemTaiKhoan"; Load += FormThemTaiKhoan_Load; panel1. ResumeLayout ( false); panel1. PerformLayout (); ResumeLayout ( false); PerformLayout ();

}

#endregion

private System.Windows.Forms. Label label6; private System.Windows.Forms. Button btnThoat; private System.Windows.Forms. Button btnThemMoi; private System.Windows.Forms. ComboBox cbCapDoQuyen; private System.Windows.Forms. TextBox txtTenTK; private System.Windows.Forms. ComboBox cbMaNV; private System.Windows.Forms. Label label7; private System.Windows.Forms. TextBox txtMatKhau;

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 305

private System.Windows.Forms. Label label2; private System.Windows.Forms. Label label1; private System.Windows.Forms. Label label5; private System.Windows.Forms. Panel panel1; } }

### Bước 8: SV sử dụng mã nguồn tạm thời sau để xử lý chức năng trong file

### FormThemTaiKhoan.cs

using System; using System.Collections.Generic; using System.ComponentModel; using System.Data; using System.Drawing; using System.Text; using System.Windows.Forms; using HotelManagement.Models; using Microsoft.EntityFrameworkCore;

namespace HotelManagement.TaiKhoan { public partial class FormThemTaiKhoan: Form { public FormThemTaiKhoan () { InitializeComponent (); }

private void FormThemTaiKhoan_Load ( object sender, EventArgs e) { txtTenTK.MaxLength = 50; txtMatKhau.MaxLength = 100; cbMaNV.DropDownStyle = ComboBoxStyle.DropDownList; cbCapDoQuyen.DropDownStyle = ComboBoxStyle.DropDownList;

LoadDanhSachNhanVien ();

int viTriMacDinh = cbCapDoQuyen. FindStringExact ( "1"); cbCapDoQuyen.SelectedIndex = viTriMacDinh >= 0 ? viTriMacDinh: 0; }

private void LoadDanhSachNhanVien () { try { using var db = new HotelManagementContext ();

var danhSach = db.NhanViens . AsNoTracking () . Where( n => n.DaXoa != true) . OrderBy ( n => n.MaNv) . Select ( n => new { n.MaNv, HienThi = n.MaNv + " - " + n.TenNv }) . ToList ();

if ( danhSach.Count == 0) { MessageBox. Show( "Chưa có nhân viên nào để tạo tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); DialogResult = DialogResult.Cancel; Close ();

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 306

return; }

cbMaNV.Items. Clear (); cbMaNV.DataSource = danhSach; cbMaNV.DisplayMember = "HienThi"; cbMaNV.ValueMember = "MaNv"; cbMaNV.SelectedIndex = 0; } catch ( Exception ex) { MessageBox. Show( "Lỗi khi load danh sách nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); DialogResult = DialogResult.Cancel; Close (); } }

private void btnThemMoi_Click ( object sender, EventArgs e) { string tenTK = txtTenTK.Text. Trim (); string matKhau = txtMatKhau.Text; string maNV = cbMaNV.SelectedValue?. ToString () ?? "";

if ( tenTK == "" || matKhau == "" || maNV == "" || cbCapDoQuyen.SelectedItem == null) { MessageBox. Show( "Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

if (! int. TryParse (cbCapDoQuyen.SelectedItem. ToString (), out int quyen)) { MessageBox. Show( "Cấp độ quyền không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

try { using var db = new HotelManagementContext ();

var taiKhoanCu = db.TaiKhoans. FirstOrDefault ( t => t.TenTk == tenTK);

if ( taiKhoanCu == null) { db.TaiKhoans. Add( new Models. TaiKhoan { TenTk = tenTK, Password = matKhau, CapDoQuyen = quyen, MaNv = maNV, DaXoa = false }); } else if ( taiKhoanCu.DaXoa == true) { taiKhoanCu.Password = matKhau; taiKhoanCu.CapDoQuyen = quyen; taiKhoanCu.MaNv = maNV; taiKhoanCu.DaXoa = false; } else {

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 307

MessageBox. Show( "Tên tài khoản đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); txtTenTK. Focus (); return; }

int kq = db. SaveChanges ();

if ( kq > 0) { MessageBox. Show( "Thêm tài khoản thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information); DialogResult = DialogResult.OK; Close (); } else { MessageBox. Show( "Thêm tài khoản thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); } } catch ( Exception ex) { MessageBox. Show( "Lỗi khi thêm tài khoản: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); } }

private void btnThoat_Click ( object sender, EventArgs e) { DialogResult = DialogResult.Cancel; Close (); } } }

### Bước 9: Click chuột phải vào folder TaiKhoan → Add → Forms( Windows Forms) →

### tạo một form để xây dựng giao diện và chức năng thêm mới thông tin 1 dịch vụ là

### FormSuaTaiKhoan.cs

### Bước 10: Thiết kế giao diện FormSuaTaiKhoan.cs theo mẫu như sau:

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 308

### Mã nguồn tham khảo trong file FormSuaTaiKhoan.Designer.cs tạm thời như sau:

namespace HotelManagement.TaiKhoan { partial class FormSuaTaiKhoan { /// <summary> /// Required designer variable. /// </summary> private System.ComponentModel. IContainer components = null;

/// <summary> /// Clean up any resources being used. /// </summary> /// <param name=" disposing "> true if managed resources should be disposed; otherwise, false. </param> protected override void Dispose ( bool disposing) { if ( disposing && (components != null)) { components. Dispose (); } base. Dispose ( disposing); }

#region Windows Form Designer generated code

/// <summary> /// Required method for Designer support - do not modify /// the contents of this method with the code editor. /// </summary> private void InitializeComponent () { label6 = new Label (); btnThoat = new Button (); btnCapNhat = new Button (); panel1 = new Panel (); txtMaNV = new TextBox(); cbCapDoQuyen = new ComboBox (); label5 = new Label (); txtMatKhau = new TextBox (); txtTenTK = new TextBox (); label1 = new Label (); label7 = new Label (); label2 = new Label (); panel1. SuspendLayout (); SuspendLayout (); // // label6 // label6.AutoSize = true; label6.Font = new Font ( "Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 0); label6.ForeColor = Color. FromArgb (192, 0, 0); label6.Location = new Point (141, 25); label6.Name = "label6"; label6.Size = new Size (357, 29); label6.TabIndex = 50; label6.Text = "Cập nhật thông tin tài khoản"; // // btnThoat // btnThoat.BackColor = SystemColors.GradientActiveCaption; btnThoat.Font = new Font ( "Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); btnThoat.Location = new Point (303, 419);

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 309

btnThoat.Margin = new Padding (3, 4, 3, 4); btnThoat.Name = "btnThoat"; btnThoat.Size = new Size (137, 59); btnThoat.TabIndex = 49; btnThoat.Text = "Thoát"; btnThoat.UseVisualStyleBackColor = false; btnThoat.Click += btnThoat_Click; // // btnCapNhat // btnCapNhat.BackColor = Color.Moccasin; btnCapNhat.Font = new Font ( "Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); btnCapNhat.Location = new Point (108, 419); btnCapNhat.Margin = new Padding (3, 4, 3, 4); btnCapNhat.Name = "btnCapNhat"; btnCapNhat.Size = new Size (137, 59); btnCapNhat.TabIndex = 48; btnCapNhat.Text = "Cập nhật"; btnCapNhat.UseVisualStyleBackColor = false; btnCapNhat.Click += btnCapNhat_Click; // // panel1 // panel1.Controls. Add(txtMaNV); panel1.Controls. Add(cbCapDoQuyen); panel1.Controls. Add(label5); panel1.Controls. Add(txtMatKhau); panel1.Controls. Add(txtTenTK); panel1.Controls. Add(label1); panel1.Controls. Add(label7); panel1.Controls. Add(label2); panel1.Location = new Point (16, 84); panel1.Margin = new Padding(3, 4, 3, 4); panel1.Name = "panel1"; panel1.Size = new Size (541, 304); panel1.TabIndex = 51; // // txtMaNV // txtMaNV.Font = new Font( "Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); txtMaNV.Location = new Point(172, 34); txtMaNV.Margin = new Padding(3, 4, 3, 4); txtMaNV.Name = "txtMaNV"; txtMaNV.ReadOnly = true; txtMaNV.Size = new Size(290, 30); txtMaNV.TabIndex = 47; // // cbCapDoQuyen // cbCapDoQuyen.Font = new Font ( "Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0); cbCapDoQuyen.FormattingEnabled = true; cbCapDoQuyen.Items. AddRange ( new object [] { "3", "2", "1", "0"}); cbCapDoQuyen.Location = new Point (172, 230); cbCapDoQuyen.Margin = new Padding(3, 4, 3, 4); cbCapDoQuyen.Name = "cbCapDoQuyen"; cbCapDoQuyen.Size = new Size (290, 30); cbCapDoQuyen.TabIndex = 46; // // label5 // label5.AutoSize = true; label5.Font = new Font ( "Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 310

label5.Location = new Point (7, 34); label5.Name = "label5"; label5.Size = new Size (142, 26); label5.TabIndex = 37; label5.Text = "Mã nhân viên"; // // txtMatKhau // txtMatKhau.Font = new Font ( "Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); txtMatKhau.Location = new Point (172, 164); txtMatKhau.Margin = new Padding(3, 4, 3, 4); txtMatKhau.Name = "txtMatKhau"; txtMatKhau.PasswordChar = '*'; txtMatKhau.Size = new Size (290, 30); txtMatKhau.TabIndex = 41; // // txtTenTK // txtTenTK.Font = new Font ( "Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0); txtTenTK.Location = new Point (172, 94); txtTenTK.Margin = new Padding(3, 4, 3, 4); txtTenTK.Name = "txtTenTK"; txtTenTK.Size = new Size (290, 30); txtTenTK.TabIndex = 44; // // label1 // label1.AutoSize = true; label1.Font = new Font ( "Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0); label1.Location = new Point (10, 94); label1.Name = "label1"; label1.Size = new Size (142, 26); label1.TabIndex = 39; label1.Text = "Tên tài khoản"; // // label7 // label7.AutoSize = true; label7.Font = new Font ( "Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0); label7.Location = new Point (48, 164); label7.Name = "label7"; label7.Size = new Size (101, 26); label7.TabIndex = 42; label7.Text = "Mật khẩu"; // // label2 // label2.AutoSize = true; label2.Font = new Font ( "Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0); label2.Location = new Point (10, 230); label2.Name = "label2"; label2.Size = new Size (147, 26); label2.TabIndex = 40; label2.Text = "Cấp độ quyền"; label2.TextAlign = ContentAlignment.TopCenter; // // FormSuaTaiKhoan // AutoScaleDimensions = new SizeF (8F, 20F); AutoScaleMode = AutoScaleMode.Font; ClientSize = new Size (577, 520);

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 311

Controls. Add(label6); Controls. Add(btnThoat); Controls. Add(btnCapNhat); Controls. Add(panel1); Margin = new Padding (3, 4, 3, 4); Name = "FormSuaTaiKhoan"; Text = "FormSuaTaiKhoan"; Load += FormSuaTaiKhoan_Load; panel1. ResumeLayout ( false); panel1. PerformLayout (); ResumeLayout ( false); PerformLayout ();

}

#endregion

private System.Windows.Forms. Label label6; private System.Windows.Forms. Button btnThoat; private System.Windows.Forms. Button btnCapNhat; private System.Windows.Forms. Panel panel1; private System.Windows.Forms. ComboBox cbCapDoQuyen; private System.Windows.Forms. Label label5; private System.Windows.Forms. TextBox txtMatKhau; private System.Windows.Forms. TextBox txtTenTK; private System.Windows.Forms. Label label1; private System.Windows.Forms. Label label7; private System.Windows.Forms. Label label2; private System.Windows.Forms. TextBox txtMaNV; } }

### Bước 11: SV sử dụng mã nguồn tạm thời sau để xử lý chức năng trong file

### FormSuaTaiKhoan.cs

using System; using System.Collections.Generic; using System.ComponentModel; using System.Data; using System.Drawing; using System.Text; using System.Windows.Forms; using HotelManagement.Models; using Microsoft.EntityFrameworkCore;

namespace HotelManagement.TaiKhoan { public partial class FormSuaTaiKhoan: Form { private string tenTK = string.Empty;

public FormSuaTaiKhoan () { InitializeComponent(); }

public FormSuaTaiKhoan ( string tenTK) : this () { this.tenTK = tenTK; }

private void FormSuaTaiKhoan_Load ( object sender, EventArgs e) { txtTenTK.MaxLength = 50; txtMatKhau.MaxLength = 100;

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 312

txtMaNV.ReadOnly = true; cbCapDoQuyen.DropDownStyle = ComboBoxStyle.DropDownList;

if ( string.IsNullOrEmpty(tenTK)) { MessageBox.Show( "Không xác định được tài khoản cần cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); DialogResult = DialogResult.Cancel; Close(); return; }

LoadThongTinTaiKhoan(); }

private void LoadThongTinTaiKhoan () { try { using var db = new HotelManagementContext();

var taiKhoan = db.TaiKhoans .AsNoTracking() .Where( t => t.TenTk == tenTK && t.DaXoa != true) .Select( t => new { t.TenTk, t.Password, t.CapDoQuyen, t.MaNv }) .FirstOrDefault();

if (taiKhoan == null) { MessageBox.Show( "Không tìm thấy tài khoản cần cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); DialogResult = DialogResult.Cancel; Close(); return; }

tenTK = taiKhoan.TenTk; txtTenTK.Text = taiKhoan.TenTk; txtMatKhau.Text = taiKhoan.Password; txtMaNV.Text = taiKhoan.MaNv;

string capDo = taiKhoan.CapDoQuyen.ToString(); int viTri = cbCapDoQuyen.FindStringExact(capDo); if (viTri < 0) { viTri = cbCapDoQuyen.Items.Add(capDo); } cbCapDoQuyen.SelectedIndex = viTri; } catch (Exception ex) { MessageBox.Show( "Lỗi khi load tài khoản: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); DialogResult = DialogResult.Cancel; Close(); } }

private void btnCapNhat_Click ( object sender, EventArgs e) {

### Lập trình trực quan

### Ths. Nguyễn Thiện Dương Trang 313

string tenTKMoi = txtTenTK.Text.Trim(); string matKhau = txtMatKhau.Text;

if (tenTKMoi == "" || matKhau == "" || cbCapDoQuyen.SelectedItem == null) { MessageBox.Show( "Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

if (! int.TryParse(cbCapDoQuyen.SelectedItem.ToString(), out int quyen)) { MessageBox.Show( "Cấp độ quyền không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

try { using var db = new HotelManagementContext ();

if ( db.TaiKhoans. Any ( t => t.TenTk == tenTKMoi && t.TenTk != tenTK)) { MessageBox. Show( "Tên tài khoản đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); txtTenTK. Focus (); return; }

int kq = db.TaiKhoans . Where( t => t.TenTk == tenTK && t.DaXoa != true) . ExecuteUpdate ( s => s . SetProperty ( t => t.TenTk, tenTKMoi) . SetProperty ( t => t.Password, matKhau) . SetProperty ( t => t.CapDoQuyen, quyen));

if ( kq > 0) { MessageBox. Show( "Cập nhật tài khoản thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information); DialogResult = DialogResult.OK; Close (); } else { MessageBox. Show( "Cập nhật thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); } } catch ( Exception ex) { MessageBox. Show( "Lỗi khi cập nhật tài khoản: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); } }

private void btnThoat_Click ( object sender, EventArgs e) { DialogResult = DialogResult.Cancel; Close (); } } }

Lập trình trực quan

Ths. Nguyễn Thiện Dương Trang 314

5. Xây dựng giao diện và chức năng lập báo cáo thống kê tình hình kinh doanh của

khách sạn theo một khoảng thời gian cho trước

SV sử dụng công nghệ FastReport hoặc các công nghệ liên quan khác để xây dựng

dashboard báo cáo tương tác động theo giao diện mẫu sau:

VI. Quy định nộp bài thực hành

1. Sinh viên cần trình bày bài làm theo file template được GV cung cấp và nộp lại trên hệ

thống LMS theo đúng deadline và các quy định liên quan.

2. Không chấp nhận những bài làm có dấu hiệu sao chép giống nhau và sẽ cho 0 điểm bài

LAB của những bài làm này.

- ---HẾT----