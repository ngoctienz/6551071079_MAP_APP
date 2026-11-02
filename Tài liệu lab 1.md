# TRƯỜNG ĐẠI HỌC GIAO THÔNG VẬN TẢI
## PHÂN HIỆU TẠI TP. HỒ CHÍ MINH
### Bộ môn: Công nghệ thông tin

---

# BÀI THỰC HÀNH: LẬP TRÌNH TRỰC QUAN
**Giảng viên:** ThS. Nguyễn Thiện Dương  
**Tài liệu:** Lab 1

---

## I. Tổng quát bài thực hành

### 1. Yêu cầu lý thuyết
Sinh viên đã được trang bị các kiến thức sau:
* Ngôn ngữ lập trình C#
* Nguyên lý lập trình hướng đối tượng với ngôn ngữ C#
* Xây dựng ứng dụng WinForms với các điều khiển phổ biến (giao diện, chức năng)
* Xử lý sự kiện nhập liệu với bàn phím và chuột
* Thư viện đồ họa GDI+
* Xây dựng giao diện MDI
* Kết nối và thao tác với CSDL bằng công nghệ Entity Framework Core
* Tạo báo cáo FastReport.Net

### 2. Yêu cầu chuẩn bị
* Phần mềm Visual Studio, đã cài package .NET Framework / .NET Core / .NET 8
* Phần mềm SQL Server
* Trong phần mềm Visual Studio, cài sẵn các NuGet package sau:
  * `Microsoft.EntityFrameworkCore.Design`
  * `Microsoft.EntityFrameworkCore.SqlServer`
  * `Microsoft.EntityFrameworkCore.Tools`
  * `ClosedXML`
  * `iTextSharp`
  * `FastReport.Net.Demo`

### 3. Nội dung chính bài thực hành
Xây dựng một chương trình hoạt động trên nền tảng Windows cho việc **“Quản lý hoạt động khách sạn”** gồm các chức năng chính sau:

#### Nhóm chức năng quản lý nghiệp vụ khách sạn
* Quản lý thông tin phòng.
* Hiển thị tình trạng các phòng (trống, đang có khách, đang dọn...) trên sơ đồ khách sạn để dễ theo dõi trực quan.
* Quản lý thông tin các loại phòng: Standard, Deluxe, Suite... với giá, tiện nghi tương ứng.
* Đặt phòng, hủy đặt, cập nhật tình trạng, kiểm tra lịch đặt phòng.
* Tạo và quản lý hóa đơn thanh toán cho khách, bao gồm tiền phòng và dịch vụ.
* In hóa đơn ra giấy hoặc file PDF để cung cấp cho khách.

#### Nhóm chức năng quản lý dịch vụ & tiện nghi
* Quản lý thông tin các dịch vụ đi kèm: ăn uống, giặt ủi, spa, đưa đón sân bay...
* Quản lý thông tin tiện nghi trong phòng (TV, điều hòa, wifi, minibar...) và đảm bảo cung ứng.

#### Nhóm chức năng quản lý người dùng và nhân sự
* Quản lý thông tin nhân viên: họ tên, chức vụ, lịch làm việc...
* Quản lý thông tin khách hàng: họ tên, CCCD, số điện thoại, lịch sử lưu trú.
* Quản lý các loại tài khoản người dùng hệ thống: admin, lễ tân, kế toán...
* Phân quyền sử dụng hệ thống dựa trên vai trò (chỉ admin được phép xóa, lễ tân chỉ được đặt phòng...).

#### Chức năng hỗ trợ & báo cáo
* Thống kê doanh thu theo ngày, tháng, loại phòng, nhân viên...
* Xuất danh sách phòng, khách, hóa đơn, doanh thu... ra file Excel để lưu trữ hoặc in báo cáo.
* Cho phép người dùng đặt lại mật khẩu nếu quên, hoặc đổi mật khẩu khi cần.

---

## II. Hướng dẫn nộp bài tập thực hành
Để nộp bài thực hành sau mỗi buổi học, các nhóm thực hiện như sau:
* Tạo 1 Repo trên GitHub để lưu trữ mã nguồn của ứng dụng thực hiện được trong cả buổi LAB 1 và LAB 2 (2 lab đều dùng chung repo này):
  * **Cú pháp tên Repo:** `<MSSV1>_<MSSV2>_MAP_APP`
* Tạo 1 Repo khác trên GitHub để lưu trữ mã nguồn của ứng dụng web thực hiện được trong buổi LAB 3:
  * **Cú pháp tên Repo:** `<MSSV1>_<MSSV2>_MAP_WEB`
* Tạo 1 link Google Drive/OneDrive lưu trữ video record lại chạy demo chức năng của app/web thực hiện được sau từng buổi. Mỗi link drive tương ứng cho mỗi buổi. Đặt tên tương ứng như sau: `Video LAB1`, `Video LAB2`, `Video LAB3`.
* Tổng hợp lại link repo GitHub + link GGDrive/OneDrive của video cho từng buổi và paste vào file template được gửi kèm trên LMS.

---

## III. Chi tiết bài thực hành cho buổi 1

### 1. Tạo cơ sở dữ liệu HotelManagement lưu trữ trong SQL Server
SV truy cập vào LMS để download file `Database.sql` để tạo CSDL tương ứng tên là `HotelManagement` trong SQL Server.

#### Mô tả bảng và các thuộc tính trong cơ sở dữ liệu

##### Bảng: NhanVien
| Tên thuộc tính | Ý nghĩa | Kiểu dữ liệu | Ghi chú |
| :--- | :--- | :--- | :--- |
| `MaNV` | Mã nhân viên | NVARCHAR(5) | Khóa chính, định danh nhân viên |
| `TenNV` | Tên nhân viên | NVARCHAR(50) | Không được để trống |
| `ChucVu` | Chức vụ | NVARCHAR(50) | Không được để trống |
| `Luong` | Lương | MONEY | Không được để trống |
| `SDT` | Số điện thoại | NVARCHAR(10) | Không trùng nhau |
| `CCCD` | Số CCCD | NVARCHAR(12) | Không trùng nhau |
| `NgaySinh` | Ngày sinh | DATE | Không được để trống |
| `GioiTinh` | Giới tính | NVARCHAR(3) | Không được để trống |
| `DiaChi` | Địa chỉ | NVARCHAR(100) | Không được để trống |
| `Email` | Email | NVARCHAR(100) | Không trùng nhau |
| `DaXoa` | Đã xóa | BIT | Trạng thái đã xóa |

##### Bảng: TaiKhoan
| Tên thuộc tính | Ý nghĩa | Kiểu dữ liệu | Ghi chú |
| :--- | :--- | :--- | :--- |
| `TenTK` | Tên tài khoản | NVARCHAR(50) | Khóa chính |
| `Password` | Mật khẩu | NVARCHAR(1000) | Không được để trống |
| `CapDoQuyen` | Cấp độ quyền | INT | Không được để trống |
| `MaNV` | Mã nhân viên | NVARCHAR(5) | Khóa ngoại đến NhanVien |
| `DaXoa` | Đã xóa | BIT | Mặc định là 0 |

##### Bảng: KhachHang
| Tên thuộc tính | Ý nghĩa | Kiểu dữ liệu | Ghi chú |
| :--- | :--- | :--- | :--- |
| `MaKH` | Mã khách hàng | NVARCHAR(5) | Khóa chính |
| `TenKH` | Tên khách hàng | NVARCHAR(50) | Không được để trống |
| `SDT` | Số điện thoại | NVARCHAR(10) | Tùy chọn |
| `CCCD` / `CccdPassport` | CCCD/Passport | NVARCHAR(12) | Không trùng nhau |
| `QuocTich` | Quốc tịch | NVARCHAR(30) | Không được để trống |
| `GioiTinh` | Giới tính | NVARCHAR(3) | Không được để trống |
| `DaXoa` | Đã xóa | BIT | Trạng thái đã xóa |

##### Bảng: Phong
| Tên thuộc tính | Ý nghĩa | Kiểu dữ liệu | Ghi chú |
| :--- | :--- | :--- | :--- |
| `MaPH` | Mã phòng | NVARCHAR(5) | Khóa chính |
| `TTPH` | Trạng thái phòng | NVARCHAR(20) | Không được để trống |
| `TTDD` | Tình trạng dọn dẹp | NVARCHAR(20) | Không được để trống |
| `GhiChu` | Ghi chú | NVARCHAR(100) | Tùy chọn |
| `MaLPH` | Mã loại phòng | NVARCHAR(5) | Khóa ngoại |
| `DaXoa` | Đã xóa | BIT | Trạng thái đã xóa |

##### Bảng: PhieuThue
| Tên cột | Ý nghĩa | Kiểu dữ liệu | Ghi chú |
| :--- | :--- | :--- | :--- |
| `MaPT` | Mã phiếu thuê | NVARCHAR(5) | Khóa chính |
| `NgPT` | Ngày lập phiếu thuê | SMALLDATETIME | Không null |
| `MaKH` | Mã khách hàng | NVARCHAR(5) | Khóa ngoại đến KhachHang |
| `MaNV` | Mã nhân viên | NVARCHAR(5) | Khóa ngoại đến NhanVien |
| `DaXoa` | Trạng thái xóa mềm | BIT | Mặc định 0 |

##### Bảng: CTDP (Chi tiết đặt phòng)
| Tên cột | Ý nghĩa | Kiểu dữ liệu | Ghi chú |
| :--- | :--- | :--- | :--- |
| `MaCTDP` | Mã chi tiết đặt phòng | NVARCHAR(7) | Khóa chính |
| `SoNguoi` | Số người | INT | |
| `MaPT` | Mã phiếu thuê | NVARCHAR(5) | Khóa ngoại đến PhieuThue |
| `MaPH` | Mã phòng | NVARCHAR(5) | Khóa ngoại đến Phong |
| `CheckIn` | Ngày nhận phòng | SMALLDATETIME | Không null |
| `CheckOut` | Ngày trả phòng | SMALLDATETIME | Không null |
| `TrangThai` | Trạng thái đặt phòng | NVARCHAR(20) | |
| `DonGia` | Đơn giá | MONEY | |
| `ThanhTien` | Thành tiền | MONEY | Mặc định 0 |
| `DaXoa` | Trạng thái xóa mềm | BIT | Mặc định 0 |
| `TheoGio` | Thuê theo giờ | BIT | Mặc định 0 |

##### Bảng: HoaDon
| Tên cột | Ý nghĩa | Kiểu dữ liệu | Ghi chú |
| :--- | :--- | :--- | :--- |
| `MaHD` | Mã hóa đơn | NVARCHAR(5) | Khóa chính |
| `NgHD` | Ngày lập hóa đơn | SMALLDATETIME | |
| `TriGia` | Trị giá | MONEY | Mặc định 0 |
| `MaNV` | Mã nhân viên | NVARCHAR(5) | Khóa ngoại đến NhanVien |
| `TrangThai` | Trạng thái thanh toán | NVARCHAR(20) | Không null |
| `MaCTDP` | Mã chi tiết đặt phòng | NVARCHAR(7) | Khóa ngoại đến CTDP |
| `DaXoa` | Trạng thái xóa mềm | BIT | Mặc định 0 |

##### Bảng: LoaiPhong
| Tên cột | Ý nghĩa | Kiểu dữ liệu | Ghi chú |
| :--- | :--- | :--- | :--- |
| `MaLPH` | Mã loại phòng | NVARCHAR(5) | Khóa chính |
| `TenLPH` | Tên loại phòng | NVARCHAR(20) | Không null |
| `SoGiuong` | Số giường | INT | Không null |
| `SoNguoiToiDa` | Số người tối đa | INT | Không null |
| `GiaNgay` | Giá theo ngày | MONEY | Không null |
| `GiaGio` | Giá theo giờ | MONEY | Không null |

##### Bảng: TienNghi
| Tên cột | Ý nghĩa | Kiểu dữ liệu | Ghi chú |
| :--- | :--- | :--- | :--- |
| `MaTN` | Mã tiện nghi | NVARCHAR(5) | Khóa chính |
| `TenTN` | Tên tiện nghi | NVARCHAR(50) | Không null |
| `DaXoa` | Trạng thái xóa mềm | BIT | |

##### Bảng: CTTN (Chi tiết tiện nghi)
| Tên cột | Ý nghĩa | Kiểu dữ liệu | Ghi chú |
| :--- | :--- | :--- | :--- |
| `MaLPH` | Mã loại phòng | NVARCHAR(5) | Khóa chính, FK đến LoaiPhong |
| `MaTN` | Mã tiện nghi | NVARCHAR(5) | Khóa chính, FK đến TienNghi |
| `SL` | Số lượng | INT | Mặc định -1 |
| `DaXoa` | Trạng thái xóa mềm | BIT | Mặc định 0 |

##### Bảng: DichVu
| Tên cột | Ý nghĩa | Kiểu dữ liệu | Ghi chú |
| :--- | :--- | :--- | :--- |
| `MaDV` | Mã dịch vụ | NVARCHAR(5) | Khóa chính |
| `TenDV` | Tên dịch vụ | NVARCHAR(20) | Không null |
| `DonGia` | Đơn giá | MONEY | Không null |
| `SLConLai` | Số lượng còn lại | INT | Mặc định -1 |
| `LoaiDV` | Loại dịch vụ | NVARCHAR(20) | Không null |
| `DaXoa` | Trạng thái xóa mềm | BIT | |

##### Bảng: CTDV (Chi tiết dịch vụ)
| Tên cột | Ý nghĩa | Kiểu dữ liệu | Ghi chú |
| :--- | :--- | :--- | :--- |
| `MaCTDP` | Mã chi tiết đặt phòng | NVARCHAR(7) | Khóa chính, FK đến CTDP |
| `MaDV` | Mã dịch vụ | NVARCHAR(5) | Khóa chính, FK đến DichVu |
| `DonGia` | Đơn giá | MONEY | Khóa chính |
| `SL` | Số lượng sử dụng | INT | Không null |
| `DaXoa` | Trạng thái xóa mềm | BIT | Mặc định 0 |
| `ThanhTien` | Thành tiền | MONEY | Mặc định 0 |

---

### 2. Cấu hình kết nối đến cơ sở dữ liệu HotelManagement từ chương trình WinForms
* **Bước 1:** Click chuột phải vào tên Project trong cửa sổ Solution Explorer → **EF Core Power Tools** → **Reverse Engineer**.
* **Bước 2:** Cửa sổ *Choose your data connection* hiện ra → click vào **Add** → chọn **Add Database Connection**.
* **Bước 3:** Cửa sổ *Connection Properties* hiện ra:
  * Chọn thông tin **Server Name** (ví dụ: `.` hoặc `localhost` hoặc `(localdb)\MSSQLLocalDB`).
  * Tích chọn **Trust Server Certificate**.
  * Chọn Database vừa tạo: `HotelManagement`.
  * Click **OK** → Quay lại cửa sổ *Choose your data connection* → Click **Next**.
* **Bước 4:** Trong cửa sổ *Choose your database object*, tích chọn hết tất cả các table của database vừa tạo → Click **Next** → Click **Next** → **Finish**.
* **Bước 5:** Trong thư mục của Project sẽ tự động tạo thư mục `Models` và các file `.cs` chứa định nghĩa các class entity và DbContext.
* **Bước 6:** Click chuột phải vào thư mục `Models` → chọn **Add** → **Class** → tạo file đặt tên là `HotelManagementContext.custom.cs` có nội dung như sau:

```csharp
using Microsoft.EntityFrameworkCore;

namespace HotelManagement.Models;

// File riêng (partial) để khi scaffold lại DB, EF Core Power Tools ghi đè HotelManagementContext.cs
// thì cấu hình kết nối này không bị mất.
public partial class HotelManagementContext
{
    // Đổi Server cho đúng máy của bạn: "." | "localhost" | ".\\SQLEXPRESS" | "(localdb)\\MSSQLLocalDB"
    private const string ConnectionString = 
        "Server=(localdb)\\MSSQLLocalDB;Database=HotelManagement;Trusted_Connection=True;TrustServerCertificate=True;";

    // Constructor không tham số để dùng: new HotelManagementContext()
    public HotelManagementContext()
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
            optionsBuilder.UseSqlServer(ConnectionString);
    }
}
```

---

### 3. Cấu hình tạo tự động thư mục Resource chứa các file tài nguyên của ứng dụng
* **Bước 1:** Click chuột phải vào thư mục Project → **Properties** → tìm đến tab **Resource**.
* **Bước 2:** Click vào **Create or open assembly resources** → tab `Resources.resx` hiện ra → Click vào icon “+” ở góc trái trên cùng → cửa sổ *Add new resource to Resources* hiện ra → thêm vào các icon/symbol/images được cung cấp.
* **Bước 3:** Sau khi thêm xong, thư mục `Resources` sẽ được tự động tạo ra trong Project chứa các file tài nguyên.

---

### 4. Xây dựng giao diện và chức năng đăng nhập vào ứng dụng

* **Bước 1:** Click chuột phải vào thư mục Project → **Add** → **New Folder** → Đặt tên `DangNhap`.
* **Bước 2:** Click chuột phải vào thư mục `DangNhap` → **Add** → **Form (Windows Forms)** → đặt tên là `FormDangNhap.cs`.
* **Bước 3:** Xây dựng giao diện form đăng nhập. Tham khảo mã `FormDangNhap.Designer.cs`:

```csharp
namespace HotelManagement.DangNhap
{
    partial class FormDangNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            panel2 = new Panel();
            label1 = new Label();
            txtMatKhau = new TextBox();
            txtTenDangNhap = new TextBox();
            pictureBox2 = new PictureBox();
            btnDangNhap = new Button();
            linkLabel1 = new LinkLabel();
            label2 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtMatKhau);
            panel2.Controls.Add(txtTenDangNhap);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(btnDangNhap);
            panel2.Controls.Add(linkLabel1);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(448, 16);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(395, 531);
            panel2.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(19, 182);
            label1.Name = "label1";
            label1.Size = new Size(141, 24);
            label1.TabIndex = 9;
            label1.Text = "Tên đăng nhập";
            // 
            // txtMatKhau
            // 
            txtMatKhau.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMatKhau.Location = new Point(177, 255);
            txtMatKhau.Margin = new Padding(3, 4, 3, 4);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new Size(192, 34);
            txtMatKhau.TabIndex = 8;
            txtMatKhau.KeyDown += txtMatKhau_KeyDown;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTenDangNhap.Location = new Point(177, 170);
            txtTenDangNhap.Margin = new Padding(3, 4, 3, 4);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(192, 34);
            txtTenDangNhap.TabIndex = 14;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.DangNhap;
            pictureBox2.Location = new Point(97, 44);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(203, 75);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.FromArgb(192, 192, 255);
            btnDangNhap.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDangNhap.Location = new Point(117, 380);
            btnDangNhap.Margin = new Padding(3, 4, 3, 4);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(134, 66);
            btnDangNhap.TabIndex = 5;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Italic, GraphicsUnit.Point, 0);
            linkLabel1.Location = new Point(222, 328);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(161, 26);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Quên mật khẩu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(192, 0, 0);
            label2.Location = new Point(62, 265);
            label2.Name = "label2";
            label2.Size = new Size(86, 24);
            label2.TabIndex = 2;
            label2.Text = "Mật khẩu";
            // 
            // panel1
            // 
            panel1.Location = new Point(-22, 16);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(414, 531);
            panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pictureIcon;
            pictureBox1.Location = new Point(-16, 20);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(458, 524);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // FormDangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(855, 562);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormDangNhap";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.Label label1;
    }
}
```

* **Bước 4:** Xử lý chức năng đăng nhập trong file `FormDangNhap.cs`:

```csharp
using HotelManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelManagement.DangNhap
{
    public partial class FormDangNhap : Form
    {
        // Thông tin phiên đăng nhập – các form khác đọc trực tiếp, ví dụ: FormDangNhap.MaNV_DangNhap
        public static string MaNV_DangNhap = string.Empty;
        public static string TenNV_DangNhap = string.Empty;
        public static int CapDoQuyen_DangNhap; // 1: Nhân viên, 2: Quản lý, 3: Admin (theo dữ liệu mẫu)

        public FormDangNhap()
        {
            InitializeComponent();
            ActiveControl = txtTenDangNhap; // Focus() trong constructor không có tác dụng vì form chưa hiện
        }

        private async void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtTenDangNhap.Text.Trim();
            string matKhau = txtMatKhau.Text;

            if (tenDangNhap.Length == 0 || matKhau.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            btnDangNhap.Enabled = false; // tránh bấm nhiều lần khi đang chờ CSDL

            try
            {
                bool hopLe = await KiemTraDangNhapAsync(tenDangNhap, matKhau);
                if (hopLe)
                {
                    DialogResult = DialogResult.OK; // Program.cs sẽ mở form chính, không Show ở đây
                }
                else
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu.", "Đăng nhập thất bại",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMatKhau.Clear();
                    txtMatKhau.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối CSDL: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnDangNhap.Enabled = true;
            }
        }

        private async Task<bool> KiemTraDangNhapAsync(string tenDangNhap, string matKhau)
        {
            await using var db = new HotelManagementContext();

            // 1 câu truy vấn duy nhất: lấy tài khoản + tên nhân viên (JOIN qua navigation property)
            // DaXoa là bool? nên dùng "!= true" để chấp nhận cả giá trị NULL lẫn false
            var tk = await db.TaiKhoans
                .AsNoTracking()
                .Where(t => t.TenTk == tenDangNhap && t.DaXoa != true)
                .Select(t => new
                {
                    t.Password,
                    t.MaNv,
                    t.CapDoQuyen,
                    TenNv = t.MaNvNavigation.TenNv,
                    NhanVienDaXoa = t.MaNvNavigation.DaXoa
                })
                .FirstOrDefaultAsync();

            if (tk == null || tk.NhanVienDaXoa == true)
                return false;

            // So sánh mật khẩu phía C# (phân biệt hoa/thường) vì collation mặc định của SQL Server không phân biệt
            if (!string.Equals(tk.Password, matKhau, StringComparison.Ordinal))
                return false;

            MaNV_DangNhap = tk.MaNv;
            TenNV_DangNhap = tk.TenNv;
            CapDoQuyen_DangNhap = tk.CapDoQuyen;
            Tag = tk.TenNv; // giữ cách cũ: truyền tên nhân viên qua Tag
            return true;
        }

        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // bỏ tiếng "ding" khi nhấn Enter
                btnDangNhap.PerformClick();
            }
        }
    }
}
```

* **Bước 5:** Mở file `Program.cs`, sửa lại nội dung:

```csharp
using HotelManagement.DangNhap;

namespace HotelManagement
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Hiện form đăng nhập trước; đăng nhập thành công (DialogResult.OK) mới mở form chính
            using (var formDangNhap = new FormDangNhap())
            {
                if (formDangNhap.ShowDialog() != DialogResult.OK)
                    return;
            }

            Application.Run(new FormMain());
        }
    }
}
```

---

### 5. Xây dựng giao diện trang chủ của ứng dụng
* **Bước 1:** Đổi tên file `Form1.cs` thành `FormMain.cs`.
* **Bước 2:** Xây dựng giao diện form trang chủ chính `FormMain.Designer.cs`:

```csharp
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
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            panel1.Name = "panel1";
            panel1.Size = new Size(1834, 92);
            panel1.TabIndex = 0;
            // 
            // labelTenKhachSan
            // 
            labelTenKhachSan.AutoSize = true;
            labelTenKhachSan.BackColor = Color.Transparent;
            labelTenKhachSan.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            panel2.Location = new Point(1, 94);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(304, 198);
            panel2.TabIndex = 1;
            // 
            // lblTenNguoiDung
            // 
            lblTenNguoiDung.AutoSize = true;
            lblTenNguoiDung.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            linkLabel1.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            button13.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            btnTrangChu.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTrangChu.ForeColor = SystemColors.ButtonHighlight;
            btnTrangChu.Image = Properties.Resources.MenuTrangChu;
            btnTrangChu.ImageAlign = ContentAlignment.MiddleLeft;
            btnTrangChu.Location = new Point(0, 0);
            btnTrangChu.Margin = new Padding(3, 4, 3, 4);
            btnTrangChu.Name = "btnTrangChu";
            btnTrangChu.Size = new Size(304, 69);
            btnTrangChu.TabIndex = 3;
            btnTrangChu.Text = "Trang chủ";
            btnTrangChu.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.DarkCyan;
            button5.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            button4.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Image = Properties.Resources.MenuLoaiPhong;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(-2, 194);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(307, 51);
            button4.TabIndex = 7;
            button4.Text = "Loại phòng";
            button4.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.DarkCyan;
            button7.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            button6.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            // 
            // btnQuanLyPhong
            // 
            btnQuanLyPhong.BackColor = Color.DarkCyan;
            btnQuanLyPhong.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            button12.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            // 
            button11.BackColor = Color.DarkCyan;
            button11.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            btnSoDoPhong.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            button9.BackColor = Color.DarkCyan;
            button9.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            button10.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnQuanLyPhong;
        private System.Windows.Forms.Button btnSoDoPhong;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button13;
    }
}
```

* **Bước 3:** Xử lý chức năng cơ bản trong `FormMain.cs`:

```csharp
using HotelManagement.DangNhap;

namespace HotelManagement
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            HienThiThongTinNguoiDung();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn đăng xuất?", "Đăng xuất",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            this.Hide();
            using (var formLogin = new FormDangNhap())
            {
                if (formLogin.ShowDialog() == DialogResult.OK)
                {
                    HienThiThongTinNguoiDung();
                    HienThiTrangChu();
                    this.Show();
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void button13_Click(object sender, EventArgs e) => HienThiDangPhatTrien("Thống kê");
        private void btnTrangChu_Click(object sender, EventArgs e) => HienThiTrangChu();
        private void button5_Click(object sender, EventArgs e) => HienThiDangPhatTrien("Danh sách tài khoản");
        private void button4_Click(object sender, EventArgs e) => HienThiDangPhatTrien("Loại phòng");
        private void button7_Click(object sender, EventArgs e) => HienThiDangPhatTrien("Danh sách nhân viên");
        private void button6_Click(object sender, EventArgs e) => HienThiDangPhatTrien("Danh sách khách hàng");
        private void btnQuanLyPhong_Click(object sender, EventArgs e) => HienThiDangPhatTrien("Phòng");
        private void button12_Click(object sender, EventArgs e) => HienThiDangPhatTrien("Danh sách tiện nghi");
        private void button11_Click(object sender, EventArgs e) => HienThiDangPhatTrien("Danh sách dịch vụ");
        private void btnSoDoPhong_Click(object sender, EventArgs e) => HienThiDangPhatTrien("Sơ đồ phòng");
        private void button9_Click(object sender, EventArgs e) => HienThiDangPhatTrien("Danh sách đặt phòng");
        private void button10_Click(object sender, EventArgs e) => HienThiDangPhatTrien("Danh sách hóa đơn");

        private void FormMain_Load(object sender, EventArgs e)
        {
            HienThiTrangChu();
        }

        private void HienThiThongTinNguoiDung()
        {
            lblTenNguoiDung.Text = FormDangNhap.TenNV_DangNhap;
            lblTenNguoiDung.Left = (panel2.Width - lblTenNguoiDung.PreferredWidth) / 2;
        }

        private void XoaNoiDungPanelMain()
        {
            foreach (Control c in panelMain.Controls.Cast<Control>().ToList())
            {
                panelMain.Controls.Remove(c);
                c.Dispose();
            }
        }

        private void LoadUserControl(UserControl uc)
        {
            XoaNoiDungPanelMain();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
            uc.BringToFront();
        }

        private void LoadFormCon(Form formCon)
        {
            XoaNoiDungPanelMain();
            formCon.TopLevel = false;
            formCon.FormBorderStyle = FormBorderStyle.None;
            formCon.Dock = DockStyle.Fill;
            panelMain.Controls.Add(formCon);
            formCon.Show();
        }

        private void HienThiTrangChu()
        {
            if (panelMain.Controls.Count == 1 && panelMain.Controls[0] is FormTrangChu)
                return;
            LoadUserControl(new FormTrangChu());
        }

        private void HienThiDangPhatTrien(string tenChucNang)
        {
            XoaNoiDungPanelMain();
            panelMain.Controls.Add(new Label
            {
                Dock = DockStyle.Fill,
                Text = tenChucNang + Environment.NewLine + "(chức năng đang được xây dựng)",
                Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Italic),
                ForeColor = Color.DarkCyan,
                TextAlign = ContentAlignment.MiddleCenter
            });
        }
    }
}
```

* **Bước 5:** Tạo màn hình chào ở trang chủ: Click chuột phải vào Project → **Add** → **User Control (Windows Forms)** → đặt tên `FormTrangChu.cs`.
* **Bước 6:** `FormTrangChu.Designer.cs`:

```csharp
namespace HotelManagement
{
    partial class FormTrangChu
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTrangChu));
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(843, 889);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // FormTrangChu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormTrangChu";
            Size = new Size(843, 889);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
```

---

### 6. Xây dựng giao diện và chức năng thể hiện sơ đồ thông tin phòng khách sạn

* **Bước 1:** Click chuột phải vào thư mục Project → **Add** → **New Folder** → Đặt tên `SoDoPhong`.
* **Bước 2:** Click chuột phải vào folder `SoDoPhong` → **Add** → **Form (Windows Forms)** → tạo `FormSoDoPhong.cs`.
* **Bước 3:** Giao diện `FormSoDoPhong.Designer.cs` (gồm 3 nhóm RadioButton: Trạng thái phòng, Loại phòng, Tình trạng dọn dẹp; ô tìm kiếm mã phòng; DateTimePicker chọn ngày; DataGridView hiển thị danh sách phòng; nút Đặt phòng).
* **Bước 4:** Xử lý chức năng trong file `FormSoDoPhong.cs`:

```csharp
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HotelManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelManagement.SoDoPhong
{
    public partial class FormSoDoPhong : Form
    {
        private bool _dangKhoiTao;

        public FormSoDoPhong()
        {
            InitializeComponent();
        }

        private void FormSoDoPhong_Load(object sender, EventArgs e)
        {
            _dangKhoiTao = true;
            rdbTatCaTrangThaiPhong.Checked = true;
            rdbTatCaLoaiPhong.Checked = true;
            rdbTatCaPhong.Checked = true;

            dtNgayChon.ShowCheckBox = true;
            dtNgayChon.Checked = false;

            toolTip1.SetToolTip(txtSearchMaPhong, "Ví dụ: 101, P20...");

            dataGridViewPhong.ReadOnly = true;
            dataGridViewPhong.AllowUserToAddRows = false;
            dataGridViewPhong.AllowUserToDeleteRows = false;
            dataGridViewPhong.MultiSelect = false;
            dataGridViewPhong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPhong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            _dangKhoiTao = false;
            TaiLaiDanhSach();
        }

        private void LocTheoRadio(object sender)
        {
            if (_dangKhoiTao) return;
            if (sender is RadioButton rdb && !rdb.Checked) return;
            TaiLaiDanhSach();
        }

        private void rdbTatCaPhong_CheckedChanged(object sender, EventArgs e) => LocTheoRadio(sender);
        private void rdbPhongChuaDon_CheckedChanged(object sender, EventArgs e) => LocTheoRadio(sender);
        private void rdbPhongDaDonDep_CheckedChanged(object sender, EventArgs e) => LocTheoRadio(sender);
        private void rdbTatCaLoaiPhong_CheckedChanged(object sender, EventArgs e) => LocTheoRadio(sender);
        private void rdbPhongVipDoi_CheckedChanged(object sender, EventArgs e) => LocTheoRadio(sender);
        private void rdbPhongVipDon_CheckedChanged(object sender, EventArgs e) => LocTheoRadio(sender);
        private void rdbPhongThuongDoi_CheckedChanged(object sender, EventArgs e) => LocTheoRadio(sender);
        private void rdbPhongThuongDon_CheckedChanged(object sender, EventArgs e) => LocTheoRadio(sender);
        private void rdbTatCaTrangThaiPhong_CheckedChanged(object sender, EventArgs e) => LocTheoRadio(sender);
        private void rdbPhongDangSuaChua_CheckedChanged(object sender, EventArgs e) => LocTheoRadio(sender);
        private void rdbPhongDangThue_CheckedChanged(object sender, EventArgs e) => LocTheoRadio(sender);
        private void rdbPhongDaDat_CheckedChanged(object sender, EventArgs e) => LocTheoRadio(sender);
        private void rdbPhongTrong_CheckedChanged(object sender, EventArgs e) => LocTheoRadio(sender);

        private void txtSearchMaPhong_TextChanged(object sender, EventArgs e)
        {
            if (_dangKhoiTao) return;
            TaiLaiDanhSach();
        }

        private void dtNgayChon_ValueChanged(object sender, EventArgs e)
        {
            if (_dangKhoiTao) return;
            TaiLaiDanhSach();
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            string? maPhong = MaPhongDangChon();
            MessageBox.Show(
                "Chức năng đặt phòng đang được xây dựng."
                + (maPhong != null ? Environment.NewLine + "Phòng đang chọn: " + maPhong : ""),
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private string? TrangThaiPhongDangChon()
        {
            if (rdbPhongTrong.Checked) return "Bình thường";
            if (rdbPhongDaDat.Checked) return "Đã đặt";
            if (rdbPhongDangThue.Checked) return "Đang thuê";
            if (rdbPhongDangSuaChua.Checked) return "Đang sửa chữa";
            return null;
        }

        private string? MaLoaiPhongDangChon()
        {
            if (rdbPhongThuongDon.Checked) return "NOR01";
            if (rdbPhongThuongDoi.Checked) return "NOR02";
            if (rdbPhongVipDon.Checked) return "VIP01";
            if (rdbPhongVipDoi.Checked) return "VIP02";
            return null;
        }

        private string? TinhTrangDonDepDangChon()
        {
            if (rdbPhongDaDonDep.Checked) return "Đã dọn dẹp";
            if (rdbPhongChuaDon.Checked) return "Chưa dọn dẹp";
            return null;
        }

        private string? MaPhongDangChon()
        {
            return dataGridViewPhong.CurrentRow?.Cells["MaPH"].Value?.ToString();
        }

        private void TaiLaiDanhSach()
        {
            try
            {
                string? ttph = TrangThaiPhongDangChon();
                string? maLph = MaLoaiPhongDangChon();
                string? ttdd = TinhTrangDonDepDangChon();
                string maPhong = txtSearchMaPhong.Text.Trim();

                using var db = new HotelManagementContext();
                var query = db.Phongs.AsNoTracking().Where(p => p.DaXoa != true);

                if (ttph != null) query = query.Where(p => p.Ttph == ttph);
                if (maLph != null) query = query.Where(p => p.MaLph == maLph);
                if (ttdd != null) query = query.Where(p => p.Ttdd == ttdd);
                if (maPhong.Length > 0) query = query.Where(p => p.MaPh.Contains(maPhong));

                if (dtNgayChon.Checked)
                {
                    DateTime ngayChon = dtNgayChon.Value.Date;
                    query = query.Where(p => p.Ttph == "Bình thường"
                        && !p.Ctdps.Any(c => c.DaXoa != true
                            && ngayChon >= c.CheckIn.Date
                            && ngayChon < c.CheckOut.Date));
                }

                var dsPhong = query
                    .OrderBy(p => p.MaPh)
                    .Select(p => new
                    {
                        p.MaPh,
                        TenLph = p.MaLphNavigation.TenLph,
                        p.Ttph,
                        p.Ttdd,
                        p.GhiChu
                    })
                    .ToList();

                dataGridViewPhong.DataSource = dsPhong
                    .Select(p => new
                    {
                        MaPH = p.MaPh,
                        Tang = p.MaPh.Length > 1 ? p.MaPh.Substring(1, 1) : "",
                        TenLPH = p.TenLph,
                        TTPH = p.Ttph,
                        TTDD = p.Ttdd,
                        GhiChu = p.GhiChu
                    })
                    .ToList();

                DatTieuDeCot("MaPH", "Mã phòng");
                DatTieuDeCot("Tang", "Tầng");
                DatTieuDeCot("TenLPH", "Loại phòng");
                DatTieuDeCot("TTPH", "Trạng thái phòng");
                DatTieuDeCot("TTDD", "Tình trạng dọn dẹp");
                DatTieuDeCot("GhiChu", "Ghi chú");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách phòng: " + ex.Message);
            }
        }

        private void DatTieuDeCot(string tenCot, string tieuDe)
        {
            if (dataGridViewPhong.Columns.Contains(tenCot))
                dataGridViewPhong.Columns[tenCot].HeaderText = tieuDe;
        }
    }
}
```

* **Bước 5:** Sửa nút `btnSoDoPhong_Click` trong file `FormMain.cs`:

```csharp
private void btnSoDoPhong_Click(object sender, EventArgs e)
{
    Form formCon = new SoDoPhong.FormSoDoPhong();
    formCon.TopLevel = false;
    formCon.FormBorderStyle = FormBorderStyle.None;
    formCon.Dock = DockStyle.Fill;
    XoaNoiDungPanelMain();
    panelMain.Controls.Add(formCon);
    formCon.Show();
}
```

---

### 7. Xây dựng giao diện và chức năng quản lý thông tin phòng khách sạn

* **Bước 1:** Click chuột phải vào thư mục Project → **Add** → **New Folder** → Đặt tên `Phong`.
* **Bước 2:** Click chuột phải vào folder `Phong` → **Add** → **Form (Windows Forms)** → tạo `FormDanhSachPhong.cs`.
* **Bước 3:** Thiết kế giao diện `FormDanhSachPhong.Designer.cs` (gồm DataGridView hiển thị danh sách phòng, các nút Sửa, Xóa dưới dạng hình ảnh, nút Xuất file Excel, Thêm mới phòng, ô tìm kiếm).
* **Bước 4 & 11:** Xử lý chức năng trong `FormDanhSachPhong.cs` (tìm kiếm, xuất Excel bằng ClosedXML, Sửa, Xóa):

```csharp
using ClosedXML.Excel;
using HotelManagement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HotelManagement.Phong
{
    public partial class FormDanhSachPhong : Form
    {
        private readonly Image _iconPhong = Properties.Resources.Phong;
        private readonly Image _iconSua = Properties.Resources.edit;
        private readonly Image _iconXoa = Properties.Resources.delete;

        public FormDanhSachPhong()
        {
            InitializeComponent();
        }

        private void FormDanhSachPhong_Load(object sender, EventArgs e)
        {
            CauHinhLuoi();
            LoadDanhSachPhong();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            LocTheoTuKhoa();
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            var cacDong = dtgDanhSachPhong.Rows.Cast<DataGridViewRow>()
                .Where(r => r.Visible && !r.IsNewRow)
                .ToList();

            if (cacDong.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var hopLuu = new SaveFileDialog())
            {
                hopLuu.Title = "Xuất danh sách phòng";
                hopLuu.Filter = "Excel Workbook (*.xlsx)|*.xlsx";
                hopLuu.FileName = $"DanhSachPhong_{DateTime.Now:yyyyMMdd_HHmm}.xlsx";

                if (hopLuu.ShowDialog() != DialogResult.OK)
                    return;

                try
                {
                    using (var wb = new XLWorkbook())
                    {
                        var ws = wb.Worksheets.Add("Danh sách phòng");
                        string[] tenCot = { "MaPH", "TTPH", "TTDD", "TenLPH" };
                        string[] tieuDe = { "Mã phòng", "Tình trạng phòng", "Dọn dẹp", "Loại phòng" };

                        for (int c = 0; c < tenCot.Length; c++)
                            ws.Cell(1, c + 1).Value = tieuDe[c];
                        ws.Row(1).Style.Font.Bold = true;

                        for (int i = 0; i < cacDong.Count; i++)
                        {
                            for (int c = 0; c < tenCot.Length; c++)
                                ws.Cell(i + 2, c + 1).Value = cacDong[i].Cells[tenCot[c]].Value?.ToString() ?? "";
                        }

                        ws.Columns().AdjustToContents();
                        wb.SaveAs(hopLuu.FileName);
                    }

                    var traLoi = MessageBox.Show("Xuất dữ liệu thành công!\nBạn có muốn mở file ngay không?", "Thông báo",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (traLoi == DialogResult.Yes)
                    {
                        System.Diagnostics.Process.Start(
                            new System.Diagnostics.ProcessStartInfo(hopLuu.FileName) { UseShellExecute = true });
                    }
                }
                catch (IOException)
                {
                    MessageBox.Show("Không ghi được file. Có thể file đang được mở trong Excel, hãy đóng lại rồi thử lần nữa.",
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xuất Excel: " + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnThemMoiPhong_Click(object sender, EventArgs e)
        {
            using (var form = new FormThemPhong())
            {
                form.ShowDialog();
            }
            LoadDanhSachPhong();
        }

        private void dtgDanhSachPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            string? maPhong = dtgDanhSachPhong.Rows[e.RowIndex].Cells["MaPH"].Value?.ToString();
            if (string.IsNullOrEmpty(maPhong))
                return;

            string tenCot = dtgDanhSachPhong.Columns[e.ColumnIndex].Name;

            if (tenCot == "colSua")
            {
                using (var formSua = new FormSuaPhong(maPhong))
                {
                    formSua.ShowDialog();
                }
                LoadDanhSachPhong();
            }
            else if (tenCot == "colXoa")
            {
                DialogResult result = MessageBox.Show($"Bạn có chắc muốn xóa phòng {maPhong} không?", "Xác nhận",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    XoaPhong(maPhong);
                    LoadDanhSachPhong();
                }
            }
        }

        private void CauHinhLuoi()
        {
            if (dtgDanhSachPhong.Columns.Count > 0)
                return;

            dtgDanhSachPhong.ReadOnly = true;
            dtgDanhSachPhong.AllowUserToAddRows = false;
            dtgDanhSachPhong.AllowUserToDeleteRows = false;
            dtgDanhSachPhong.AllowUserToResizeRows = false;
            dtgDanhSachPhong.MultiSelect = false;
            dtgDanhSachPhong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgDanhSachPhong.RowHeadersVisible = false;
            dtgDanhSachPhong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgDanhSachPhong.RowTemplate.Height = 40;

            dtgDanhSachPhong.Columns.Add(TaoCotAnh("colIcon", "", _iconPhong));
            dtgDanhSachPhong.Columns.Add("MaPH", "Mã phòng");
            dtgDanhSachPhong.Columns.Add("TTPH", "Tình trạng phòng");
            dtgDanhSachPhong.Columns.Add("TTDD", "Dọn dẹp");
            dtgDanhSachPhong.Columns.Add("TenLPH", "Loại phòng");
            dtgDanhSachPhong.Columns.Add(TaoCotAnh("colSua", "Sửa", _iconSua));
            dtgDanhSachPhong.Columns.Add(TaoCotAnh("colXoa", "Xóa", _iconXoa));
        }

        private DataGridViewImageColumn TaoCotAnh(string ten, string tieuDe, Image anh)
        {
            return new DataGridViewImageColumn
            {
                Name = ten,
                HeaderText = tieuDe,
                Image = anh,
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                Width = 50,
                Resizable = DataGridViewTriState.False,
                SortMode = DataGridViewColumnSortMode.NotSortable
            };
        }

        private void LoadDanhSachPhong()
        {
            try
            {
                using var db = new HotelManagementContext();
                var dsPhong = db.Phongs
                    .AsNoTracking()
                    .Where(p => p.DaXoa != true)
                    .OrderBy(p => p.MaPh)
                    .Select(p => new
                    {
                        p.MaPh,
                        p.Ttph,
                        p.Ttdd,
                        TenLph = p.MaLphNavigation.TenLph
                    })
                    .ToList();

                dtgDanhSachPhong.Rows.Clear();
                foreach (var p in dsPhong)
                {
                    dtgDanhSachPhong.Rows.Add(
                        _iconPhong,
                        p.MaPh,
                        p.Ttph,
                        p.Ttdd,
                        p.TenLph,
                        _iconSua,
                        _iconXoa
                    );
                }
                LocTheoTuKhoa();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách phòng: " + ex.Message);
            }
        }

        private void LocTheoTuKhoa()
        {
            string keyword = txtTimKiem.Text.Trim();
            dtgDanhSachPhong.CurrentCell = null;
            foreach (DataGridViewRow row in dtgDanhSachPhong.Rows)
            {
                string maPhong = row.Cells["MaPH"].Value?.ToString() ?? "";
                row.Visible = keyword.Length == 0 || maPhong.Contains(keyword, StringComparison.OrdinalIgnoreCase);
            }
        }

        private void XoaPhong(string maPhong)
        {
            try
            {
                using var db = new HotelManagementContext();
                var phong = db.Phongs.FirstOrDefault(p => p.MaPh == maPhong && p.DaXoa != true);
                if (phong == null)
                {
                    MessageBox.Show("Không tìm thấy phòng để xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (phong.Ttph == "Đang thuê" || phong.Ttph == "Đã đặt")
                {
                    MessageBox.Show($"Phòng {maPhong} đang ở trạng thái \"{phong.Ttph}\" nên không thể xóa.",
                        "Không thể xóa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                phong.DaXoa = true;
                db.SaveChanges();
                MessageBox.Show("Đã xóa phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
```

* **Bước 5:** Cập nhật hàm `btnQuanLyPhong_Click` trong file `FormMain.cs`:

```csharp
private void btnQuanLyPhong_Click(object sender, EventArgs e)
{
    Form formCon = new Phong.FormDanhSachPhong();
    formCon.TopLevel = false;
    formCon.FormBorderStyle = FormBorderStyle.None;
    formCon.Dock = DockStyle.Fill;
    XoaNoiDungPanelMain();
    panelMain.Controls.Add(formCon);
    formCon.Show();
}
```

* **Bước 6 & 7:** Tạo form `FormThemPhong.cs` và thiết kế `FormThemPhong.Designer.cs`.
* **Bước 8:** Code chức năng cho `FormThemPhong.cs`:

```csharp
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HotelManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelManagement.Phong
{
    public partial class FormThemPhong : Form
    {
        public FormThemPhong()
        {
            InitializeComponent();
            Text = "Thêm mới phòng";
            StartPosition = FormStartPosition.CenterParent;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            AcceptButton = btnThemMoi;
            CancelButton = btnThoat;
        }

        private void FormThemPhong_Load(object sender, EventArgs e)
        {
            txtMaPhong.MaxLength = 5;
            txtGhiChu.MaxLength = 100;
            cbTrangThaiPhong.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTinhTrangDonDep.DropDownStyle = ComboBoxStyle.DropDownList;
            cbLoaiPhong.DropDownStyle = ComboBoxStyle.DropDownList;

            try
            {
                using var db = new HotelManagementContext();
                var dsLoaiPhong = db.LoaiPhongs
                    .AsNoTracking()
                    .OrderBy(l => l.MaLph)
                    .Select(l => new { l.MaLph, l.TenLph })
                    .ToList();

                cbLoaiPhong.Items.Clear();
                cbLoaiPhong.DisplayMember = "TenLph";
                cbLoaiPhong.ValueMember = "MaLph";
                cbLoaiPhong.DataSource = dsLoaiPhong;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách loại phòng: " + ex.Message);
            }

            if (cbTrangThaiPhong.Items.Count > 0) cbTrangThaiPhong.SelectedIndex = 0;
            if (cbTinhTrangDonDep.Items.Count > 0) cbTinhTrangDonDep.SelectedIndex = 0;
            txtMaPhong.Focus();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            string maPH = txtMaPhong.Text.Trim().ToUpper();
            string trangThai = cbTrangThaiPhong.Text;
            string donDep = cbTinhTrangDonDep.Text;
            string? maLPH = cbLoaiPhong.SelectedValue?.ToString();
            string ghiChu = txtGhiChu.Text.Trim();

            if (maPH.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập mã phòng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaPhong.Focus();
                return;
            }

            if (string.IsNullOrEmpty(maLPH))
            {
                MessageBox.Show("Vui lòng chọn loại phòng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbLoaiPhong.Focus();
                return;
            }

            if (trangThai.Length == 0 || donDep.Length == 0)
            {
                MessageBox.Show("Vui lòng chọn trạng thái phòng và tình trạng dọn dẹp.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using var db = new HotelManagementContext();
                var tonTai = db.Phongs.FirstOrDefault(p => p.MaPh == maPH);
                if (tonTai != null)
                {
                    if (tonTai.DaXoa != true)
                    {
                        MessageBox.Show("Mã phòng đã tồn tại. Vui lòng nhập mã khác.", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMaPhong.Focus();
                        return;
                    }

                    var traLoi = MessageBox.Show(
                        $"Mã phòng {maPH} từng bị xóa trước đây.\nBạn có muốn khôi phục phòng này với thông tin vừa nhập không?",
                        "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (traLoi != DialogResult.Yes)
                        return;

                    tonTai.Ttph = trangThai;
                    tonTai.Ttdd = donDep;
                    tonTai.GhiChu = ghiChu.Length == 0 ? null : ghiChu;
                    tonTai.MaLph = maLPH;
                    tonTai.DaXoa = false;
                }
                else
                {
                    db.Phongs.Add(new Models.Phong
                    {
                        MaPh = maPH,
                        Ttph = trangThai,
                        Ttdd = donDep,
                        GhiChu = ghiChu.Length == 0 ? null : ghiChu,
                        MaLph = maLPH,
                        DaXoa = false
                    });
                }

                int result = db.SaveChanges();
                if (result > 0)
                {
                    MessageBox.Show("Thêm phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Không thể thêm phòng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show("Lỗi khi thêm phòng: " + (ex.InnerException?.Message ?? ex.Message),
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
```

* **Bước 9 & 10:** Tạo form `FormSuaPhong.cs` và thiết kế `FormSuaPhong.Designer.cs`.
* **Bước 11:** Code chức năng cho `FormSuaPhong.cs`:

```csharp
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HotelManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelManagement.Phong
{
    public partial class FormSuaPhong : Form
    {
        private string? maPhong;

        public FormSuaPhong()
        {
            InitializeComponent();
            Text = "Cập nhật thông tin phòng";
            StartPosition = FormStartPosition.CenterParent;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            AcceptButton = btnCapNhat;
            CancelButton = btnThoat;
            txtGhiChu.MaxLength = 100;
            cbTrangThaiPhong.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTinhTrangDonDep.DropDownStyle = ComboBoxStyle.DropDownList;
            cbLoaiPhong.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public FormSuaPhong(string maPhong) : this()
        {
            this.maPhong = maPhong;
            Text = $"Cập nhật phòng {maPhong}";
            label5.Text = $"Cập nhật thông tin phòng {maPhong}";
            LoadLoaiPhong();
            LoadThongTinPhong();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(maPhong))
            {
                MessageBox.Show("Chưa xác định được phòng cần cập nhật.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string trangThai = cbTrangThaiPhong.Text;
            string donDep = cbTinhTrangDonDep.Text;
            string? maLPH = cbLoaiPhong.SelectedValue?.ToString();
            string ghiChu = txtGhiChu.Text.Trim();

            if (string.IsNullOrEmpty(maLPH))
            {
                MessageBox.Show("Vui lòng chọn loại phòng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbLoaiPhong.Focus();
                return;
            }

            if (trangThai.Length == 0 || donDep.Length == 0)
            {
                MessageBox.Show("Vui lòng chọn trạng thái phòng và tình trạng dọn dẹp.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using var db = new HotelManagementContext();
                var phong = db.Phongs.FirstOrDefault(p => p.MaPh == maPhong && p.DaXoa != true);
                if (phong == null)
                {
                    MessageBox.Show("Không tìm thấy phòng cần cập nhật (có thể đã bị xóa).", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                phong.Ttph = trangThai;
                phong.Ttdd = donDep;
                phong.MaLph = maLPH;
                phong.GhiChu = ghiChu.Length == 0 ? null : ghiChu;

                int rows = db.SaveChanges();
                if (rows > 0)
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thông tin không thay đổi nên không có gì để cập nhật.", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show("Lỗi khi cập nhật phòng: " + (ex.InnerException?.Message ?? ex.Message),
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void LoadLoaiPhong()
        {
            try
            {
                using var db = new HotelManagementContext();
                var dsLoaiPhong = db.LoaiPhongs
                    .AsNoTracking()
                    .OrderBy(l => l.MaLph)
                    .Select(l => new { l.MaLph, l.TenLph })
                    .ToList();

                cbLoaiPhong.Items.Clear();
                cbLoaiPhong.DisplayMember = "TenLph";
                cbLoaiPhong.ValueMember = "MaLph";
                cbLoaiPhong.DataSource = dsLoaiPhong;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách loại phòng: " + ex.Message);
            }
        }

        private void LoadThongTinPhong()
        {
            try
            {
                using var db = new HotelManagementContext();
                var thongTin = db.Phongs
                    .AsNoTracking()
                    .Where(p => p.MaPh == maPhong && p.DaXoa != true)
                    .Select(p => new { p.Ttph, p.Ttdd, p.MaLph, p.GhiChu })
                    .FirstOrDefault();

                if (thongTin == null)
                {
                    MessageBox.Show("Không tìm thấy phòng " + maPhong + ".", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnCapNhat.Enabled = false;
                    return;
                }

                cbTrangThaiPhong.SelectedIndex = cbTrangThaiPhong.FindStringExact(thongTin.Ttph);
                cbTinhTrangDonDep.SelectedIndex = cbTinhTrangDonDep.FindStringExact(thongTin.Ttdd);
                cbLoaiPhong.SelectedValue = thongTin.MaLph;
                txtGhiChu.Text = thongTin.GhiChu ?? "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải thông tin phòng: " + ex.Message);
                btnCapNhat.Enabled = false;
            }
        }
    }
}
```

---

### 8. Xây dựng giao diện và chức năng quản lý thông tin loại phòng khách sạn

* **Bước 1:** Click chuột phải vào thư mục Project → **Add** → **New Folder** → Đặt tên `LoaiPhong`.
* **Bước 2:** Click chuột phải vào folder `LoaiPhong` → **Add** → **Form (Windows Forms)** → tạo `FormDanhSachLoaiPhong.cs`.
* **Bước 3:** Thiết kế giao diện `FormDanhSachLoaiPhong.Designer.cs`.
* **Bước 4:** Xử lý chức năng trong `FormDanhSachLoaiPhong.cs`:

```csharp
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClosedXML.Excel;
using HotelManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelManagement.LoaiPhong
{
    public partial class FormDanhSachLoaiPhong : Form
    {
        private readonly Image _iconGiuong = Properties.Resources.Giuong;
        private readonly Image _iconTienNghi = Properties.Resources.details;
        private readonly Image _iconSua = Properties.Resources.edit;

        public FormDanhSachLoaiPhong()
        {
            InitializeComponent();
            Load += FormDanhSachLoaiPhong_Load;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            LocTheoTuKhoa();
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            var cacDong = dtgDanhSachLoaiPhong.Rows.Cast<DataGridViewRow>()
                .Where(r => r.Visible && !r.IsNewRow)
                .ToList();

            if (cacDong.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var hopLuu = new SaveFileDialog())
            {
                hopLuu.Title = "Xuất danh sách loại phòng";
                hopLuu.Filter = "Excel Workbook (*.xlsx)|*.xlsx";
                hopLuu.FileName = $"DanhSachLoaiPhong_{DateTime.Now:yyyyMMdd_HHmm}.xlsx";

                if (hopLuu.ShowDialog() != DialogResult.OK)
                    return;

                try
                {
                    using (var wb = new XLWorkbook())
                    {
                        var ws = wb.Worksheets.Add("Danh sách loại phòng");
                        string[] tenCot = { "MaLPH", "TenLPH", "SoGiuong", "SoNguoiToiDa", "GiaNgay", "GiaGio" };

                        for (int c = 0; c < tenCot.Length; c++)
                            ws.Cell(1, c + 1).Value = dtgDanhSachLoaiPhong.Columns[tenCot[c]].HeaderText;
                        ws.Row(1).Style.Font.Bold = true;

                        for (int i = 0; i < cacDong.Count; i++)
                        {
                            for (int c = 0; c < tenCot.Length; c++)
                            {
                                var o = ws.Cell(i + 2, c + 1);
                                object? giaTri = cacDong[i].Cells[tenCot[c]].Value;
                                switch (giaTri)
                                {
                                    case decimal d:
                                        o.Value = d;
                                        o.Style.NumberFormat.Format = "#,##0";
                                        break;
                                    case int n:
                                        o.Value = n;
                                        break;
                                    default:
                                        o.Value = giaTri?.ToString() ?? "";
                                        break;
                                }
                            }
                        }

                        ws.Columns().AdjustToContents();
                        wb.SaveAs(hopLuu.FileName);
                    }

                    var traLoi = MessageBox.Show("Xuất dữ liệu thành công!\nBạn có muốn mở file ngay không?", "Thông báo",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (traLoi == DialogResult.Yes)
                    {
                        System.Diagnostics.Process.Start(
                            new System.Diagnostics.ProcessStartInfo(hopLuu.FileName) { UseShellExecute = true });
                    }
                }
                catch (IOException)
                {
                    MessageBox.Show("Không ghi được file. Có thể file đang được mở trong Excel, hãy đóng lại rồi thử lần nữa.",
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xuất Excel: " + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            using (var formThemLoaiPhong = new FormThemLoaiPhong())
            {
                formThemLoaiPhong.ShowDialog();
            }
            LoadLoaiPhong();
        }

        private void dtgDanhSachLoaiPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            var dong = dtgDanhSachLoaiPhong.Rows[e.RowIndex];
            string? maLPH = dong.Cells["MaLPH"].Value?.ToString();
            string? tenLPH = dong.Cells["TenLPH"].Value?.ToString();

            if (string.IsNullOrEmpty(maLPH))
                return;

            string tenCot = dtgDanhSachLoaiPhong.Columns[e.ColumnIndex].Name;

            if (tenCot == "colSua")
            {
                using (var formSua = new FormSuaLoaiPhong())
                {
                    formSua.Tag = maLPH;
                    formSua.ShowDialog();
                }
                LoadLoaiPhong();
            }
            else if (tenCot == "colTienNghi")
            {
                MessageBox.Show(
                    $"Chức năng chi tiết tiện nghi của loại phòng {tenLPH} ({maLPH}) đang được xây dựng.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FormDanhSachLoaiPhong_Load(object sender, EventArgs e)
        {
            CauHinhLuoi();
            LoadLoaiPhong();
        }

        private void CauHinhLuoi()
        {
            if (dtgDanhSachLoaiPhong.Columns.Count > 0)
                return;

            dtgDanhSachLoaiPhong.ReadOnly = true;
            dtgDanhSachLoaiPhong.AllowUserToAddRows = false;
            dtgDanhSachLoaiPhong.AllowUserToDeleteRows = false;
            dtgDanhSachLoaiPhong.AllowUserToResizeRows = false;
            dtgDanhSachLoaiPhong.MultiSelect = false;
            dtgDanhSachLoaiPhong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgDanhSachLoaiPhong.RowHeadersVisible = false;
            dtgDanhSachLoaiPhong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgDanhSachLoaiPhong.RowTemplate.Height = 40;

            dtgDanhSachLoaiPhong.Columns.Add(TaoCotAnh("colIcon", "", _iconGiuong, 50));
            dtgDanhSachLoaiPhong.Columns.Add("MaLPH", "Mã loại");
            dtgDanhSachLoaiPhong.Columns.Add("TenLPH", "Tên loại");
            dtgDanhSachLoaiPhong.Columns.Add("SoGiuong", "Số giường");
            dtgDanhSachLoaiPhong.Columns.Add("SoNguoiToiDa", "Số người tối đa");
            dtgDanhSachLoaiPhong.Columns.Add("GiaNgay", "Giá ngày");
            dtgDanhSachLoaiPhong.Columns.Add("GiaGio", "Giá giờ");

            dtgDanhSachLoaiPhong.Columns["GiaNgay"]!.DefaultCellStyle.Format = "N0";
            dtgDanhSachLoaiPhong.Columns["GiaGio"]!.DefaultCellStyle.Format = "N0";
            dtgDanhSachLoaiPhong.Columns["GiaNgay"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dtgDanhSachLoaiPhong.Columns["GiaGio"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dtgDanhSachLoaiPhong.Columns.Add(TaoCotAnh("colTienNghi", "Tiện nghi", _iconTienNghi, 60));
            dtgDanhSachLoaiPhong.Columns.Add(TaoCotAnh("colSua", "Cập nhật", _iconSua, 70));
        }

        private DataGridViewImageColumn TaoCotAnh(string ten, string tieuDe, Image anh, int doRong)
        {
            return new DataGridViewImageColumn
            {
                Name = ten,
                HeaderText = tieuDe,
                Image = anh,
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                Width = doRong,
                Resizable = DataGridViewTriState.False,
                SortMode = DataGridViewColumnSortMode.NotSortable
            };
        }

        private void LoadLoaiPhong()
        {
            try
            {
                using var db = new HotelManagementContext();
                var dsLoaiPhong = db.LoaiPhongs
                    .AsNoTracking()
                    .OrderBy(l => l.MaLph)
                    .Select(l => new
                    {
                        l.MaLph,
                        l.TenLph,
                        l.SoGiuong,
                        l.SoNguoiToiDa,
                        l.GiaNgay,
                        l.GiaGio
                    })
                    .ToList();

                dtgDanhSachLoaiPhong.Rows.Clear();
                foreach (var l in dsLoaiPhong)
                {
                    dtgDanhSachLoaiPhong.Rows.Add(
                        _iconGiuong,
                        l.MaLph,
                        l.TenLph,
                        l.SoGiuong,
                        l.SoNguoiToiDa,
                        l.GiaNgay,
                        l.GiaGio,
                        _iconTienNghi,
                        _iconSua
                    );
                }
                LocTheoTuKhoa();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải loại phòng: " + ex.Message);
            }
        }

        private void LocTheoTuKhoa()
        {
            string keyword = txtTimKiem.Text.Trim();
            dtgDanhSachLoaiPhong.CurrentCell = null;
            foreach (DataGridViewRow row in dtgDanhSachLoaiPhong.Rows)
            {
                string ma = row.Cells["MaLPH"].Value?.ToString() ?? "";
                string ten = row.Cells["TenLPH"].Value?.ToString() ?? "";
                row.Visible = keyword.Length == 0
                    || ma.Contains(keyword, StringComparison.OrdinalIgnoreCase)
                    || ten.Contains(keyword, StringComparison.OrdinalIgnoreCase);
            }
        }
    }
}
```

* **Bước 5:** Sửa `button4_Click` trong file `FormMain.cs`:

```csharp
private void button4_Click(object sender, EventArgs e)
{
    Form formCon = new LoaiPhong.FormDanhSachLoaiPhong();
    formCon.TopLevel = false;
    formCon.FormBorderStyle = FormBorderStyle.None;
    formCon.Dock = DockStyle.Fill;
    XoaNoiDungPanelMain();
    panelMain.Controls.Add(formCon);
    formCon.Show();
}
```

* **Bước 6 & 7:** Tạo form `FormThemLoaiPhong.cs` và thiết kế `FormThemLoaiPhong.Designer.cs`.
* **Bước 8:** Code chức năng cho `FormThemLoaiPhong.cs`:

```csharp
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HotelManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelManagement.LoaiPhong
{
    public partial class FormThemLoaiPhong : Form
    {
        public FormThemLoaiPhong()
        {
            InitializeComponent();
            Text = "Thêm mới loại phòng";
            StartPosition = FormStartPosition.CenterParent;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            AcceptButton = btnThemMoi;
            CancelButton = btnThoat;
            txtMaLoaiPhong.MaxLength = 5;
            txtTenLP.MaxLength = 20;
            txtSoGiuong.MaxLength = 2;
            txtSoNguoiToiDa.MaxLength = 2;
            txtSoGiuong.KeyPress += ChiChoNhapSo;
            txtSoNguoiToiDa.KeyPress += ChiChoNhapSo;
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            string maLPH = txtMaLoaiPhong.Text.Trim().ToUpper();
            string tenLPH = txtTenLP.Text.Trim();

            if (maLPH.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập mã loại phòng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaLoaiPhong.Focus();
                return;
            }

            if (tenLPH.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập tên loại phòng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenLP.Focus();
                return;
            }

            if (!int.TryParse(txtSoGiuong.Text.Trim(), out int soGiuong) || soGiuong <= 0)
            {
                MessageBox.Show("Số giường không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoGiuong.Focus();
                return;
            }

            if (!int.TryParse(txtSoNguoiToiDa.Text.Trim(), out int soNguoiToiDa) || soNguoiToiDa <= 0)
            {
                MessageBox.Show("Số người tối đa không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoNguoiToiDa.Focus();
                return;
            }

            if (!decimal.TryParse(txtGiaNgay.Text.Trim(), out decimal giaNgay) || giaNgay <= 0)
            {
                MessageBox.Show("Giá ngày không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGiaNgay.Focus();
                return;
            }

            if (!decimal.TryParse(txtGiaGio.Text.Trim(), out decimal giaGio) || giaGio <= 0)
            {
                MessageBox.Show("Giá giờ không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGiaGio.Focus();
                return;
            }

            try
            {
                using var db = new HotelManagementContext();
                if (db.LoaiPhongs.Any(l => l.MaLph == maLPH))
                {
                    MessageBox.Show("Mã loại phòng đã tồn tại. Vui lòng nhập mã khác.", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaLoaiPhong.Focus();
                    return;
                }

                db.LoaiPhongs.Add(new Models.LoaiPhong
                {
                    MaLph = maLPH,
                    TenLph = tenLPH,
                    SoGiuong = soGiuong,
                    SoNguoiToiDa = soNguoiToiDa,
                    GiaNgay = giaNgay,
                    GiaGio = giaGio
                });

                int rows = db.SaveChanges();
                if (rows > 0)
                {
                    MessageBox.Show("Thêm loại phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Không thể thêm loại phòng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show("Lỗi: " + (ex.InnerException?.Message ?? ex.Message), "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void ChiChoNhapSo(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}
```

* **Bước 9 & 10:** Tạo form `FormSuaLoaiPhong.cs` và thiết kế `FormSuaLoaiPhong.Designer.cs`.
* **Bước 11:** Code chức năng cho `FormSuaLoaiPhong.cs`:

```csharp
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HotelManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelManagement.LoaiPhong
{
    public partial class FormSuaLoaiPhong : Form
    {
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string? MaLoaiPhong { get; set; }

        public FormSuaLoaiPhong()
        {
            InitializeComponent();
            Text = "Cập nhật thông tin loại phòng";
            StartPosition = FormStartPosition.CenterParent;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            AcceptButton = btnCapNhat;
            CancelButton = btnThoat;
            txtTenLP.MaxLength = 20;
            txtSoGiuong.MaxLength = 2;
            txtSoNguoiToiDa.MaxLength = 2;
            txtSoGiuong.KeyPress += ChiChoNhapSo;
            txtSoNguoiToiDa.KeyPress += ChiChoNhapSo;
            Load += FormSuaLoaiPhong_Load;
        }

        private void FormSuaLoaiPhong_Load(object sender, EventArgs e)
        {
            string? ma = MaLoaiPhong;
            if (string.IsNullOrEmpty(ma))
            {
                MessageBox.Show("Chưa xác định được loại phòng cần cập nhật.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnCapNhat.Enabled = false;
                return;
            }

            Text = "Cập nhật loại phòng " + ma;

            try
            {
                using var db = new HotelManagementContext();
                var thongTin = db.LoaiPhongs
                    .AsNoTracking()
                    .Where(l => l.MaLph == ma)
                    .Select(l => new { l.TenLph, l.SoGiuong, l.SoNguoiToiDa, l.GiaNgay, l.GiaGio })
                    .FirstOrDefault();

                if (thongTin == null)
                {
                    MessageBox.Show("Không tìm thấy loại phòng " + ma + ".", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnCapNhat.Enabled = false;
                    return;
                }

                txtTenLP.Text = thongTin.TenLph;
                txtSoGiuong.Text = thongTin.SoGiuong.ToString();
                txtSoNguoiToiDa.Text = thongTin.SoNguoiToiDa.ToString();
                txtGiaNgay.Text = thongTin.GiaNgay.ToString("0.##");
                txtGiaGio.Text = thongTin.GiaGio.ToString("0.##");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải thông tin loại phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnCapNhat.Enabled = false;
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string? ma = MaLoaiPhong;
            if (string.IsNullOrEmpty(ma))
            {
                MessageBox.Show("Chưa xác định được loại phòng cần cập nhật.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string tenLPH = txtTenLP.Text.Trim();

            if (tenLPH.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập tên loại phòng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenLP.Focus();
                return;
            }

            if (!int.TryParse(txtSoGiuong.Text.Trim(), out int soGiuong) || soGiuong <= 0)
            {
                MessageBox.Show("Số giường không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoGiuong.Focus();
                return;
            }

            if (!int.TryParse(txtSoNguoiToiDa.Text.Trim(), out int soNguoiToiDa) || soNguoiToiDa <= 0)
            {
                MessageBox.Show("Số người tối đa không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoNguoiToiDa.Focus();
                return;
            }

            if (!decimal.TryParse(txtGiaNgay.Text.Trim(), out decimal giaNgay) || giaNgay <= 0)
            {
                MessageBox.Show("Giá ngày không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGiaNgay.Focus();
                return;
            }

            if (!decimal.TryParse(txtGiaGio.Text.Trim(), out decimal giaGio) || giaGio <= 0)
            {
                MessageBox.Show("Giá giờ không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGiaGio.Focus();
                return;
            }

            try
            {
                using var db = new HotelManagementContext();
                var loaiPhong = db.LoaiPhongs.FirstOrDefault(l => l.MaLph == ma);
                if (loaiPhong == null)
                {
                    MessageBox.Show("Không tìm thấy loại phòng cần cập nhật.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                loaiPhong.TenLph = tenLPH;
                loaiPhong.SoGiuong = soGiuong;
                loaiPhong.SoNguoiToiDa = soNguoiToiDa;
                loaiPhong.GiaNgay = giaNgay;
                loaiPhong.GiaGio = giaGio;

                int rows = db.SaveChanges();
                if (rows > 0)
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thông tin không thay đổi nên không có gì để cập nhật.", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show("Lỗi khi cập nhật: " + (ex.InnerException?.Message ?? ex.Message), "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void ChiChoNhapSo(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}
```

---

## IV. Quy định nộp bài thực hành
1. Sinh viên cần trình bày bài làm theo file template được GV cung cấp và nộp lại trên hệ thống LMS theo đúng deadline và các quy định liên quan.
2. Không chấp nhận những bài làm có dấu hiệu sao chép giống nhau và sẽ cho 0 điểm bài LAB của những bài làm này.

---
**---- HẾT LAB 1 ----**
