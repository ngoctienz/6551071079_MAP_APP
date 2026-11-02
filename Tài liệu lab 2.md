# TRƯỜNG ĐẠI HỌC GIAO THÔNG VẬN TẢI

# BÀI THỰC HÀNH
## PHÂN HIỆU TẠI TP. HỒ CHÍ MINH
### Bộ môn: Công nghệ thông tin Môn học: Lập trình trực quan

## I. Tổng quát bài thực hành

### 1. Yêu cầu lý thuyết

Sinh viên đã được trang bị các kiến thức sau:
  * Ngôn ngữ lập trình C#
  * Nguyên lý lập trình hướng đối tượng với ngôn ngữ C#
  * Xây dựng ứng dụng winform với các điều khiển phổ biến (giao diện, chức năng)
  * Xử lý sự kiện nhập liệu với bàn phím và chuột
  * Thu viện đồ họa GDI+
  * Xây dựng giao diện MDI
  * Kết nối và thao tác với CSDL bằng công nghệ Entity Framework Core
  * Tạo báo cáo FastRepor.Net

### 2. Yêu cầu chuẩn bị

Phần mềm Visual Studio, đã cài package .Net Framework
Phần mềm SQL Server
Trong phần mềm Visual Studio, cài sẵn các Nuget package sau:
  * Microsoft.EntityFrameworkCore.Design
  * Microsoft.EntityFrameworkCore.SqlServer
  * Microsoft.EntityFrameworkCore.Tools
  * ClosedXML
  * iTextSharp
  * FastReport.Net.Demo

### 3. Nội dung chính bài thực hành

Xây dựng một chương trình hoạt động trên nền tảng window cho việc “Quản lý hoạt
động khách sạn” gồm các chức năng chính sau:
Nhóm chức năng quản lý nghiệp vụ khách sạn
  * Quản lý thông tin phòng
  * Hiển thị tình trạng các phòng (trống, đang có khách, đang dọn...) trên sơ đồ khách
sạn để dễ theo dõi trực quan.
  * Quản lý thông tin các loại phòng: Standard, Deluxe, Suite... với giá, tiện nghi
tương ứng.
  * Đặt phòng, hủy đặt, cập nhật tình trạng, kiểm tra lịch đặt phòng.
  * Tạo và quản lý hóa đơn thanh toán cho khách, bao gồm tiền phòng và dịch vụ.
  * In hóa đơn ra giấy hoặc file PDF để cung cấp cho khách.
Nhóm chức năng quản lý dịch vụ & tiện nghi
  * Quản lý thông tin các dịch vụ đi kèm: ăn uống, giặt ủi, spa, đưa đón sân bay...
  * Quản lý thông tin tiện nghi trong phòng (TV, điều hòa, wifi, minibar...) và đảm
bảo cung ứng.
Nhóm chức năng quản lý người dùng và nhân sự
  * Quản lý thông tin nhân viên: họ tên, chức vụ, lịch làm việc...
  * Quản lý thông tin khách hàng: họ tên, CCCD, số điện thoại, lịch sử lưu trú.
  * Quản lý các loại tài khoản người dùng hệ thống: admin, lễ tân, kế toán...
  * Phân quyền sử dụng hệ thống dựa trên vai trò (chỉ admin được phép xóa, lễ tân
chỉ được đặt phòng...).
Chức năng hỗ trợ & báo cáo
  * Thống kê doanh thu theo ngày, tháng, loại phòng, nhân viên...
  * Xuất danh sách phòng, khách, hóa đơn, doanh thu... ra file Excel để lưu trữ hoặc
in báo cáo
  * Cho phép người dùng đặt lại mật khẩu nếu quên, hoặc đổi mật khẩu khi cần.

## II. Hướng dẫn nộp bài tập thực hành

Để nộp bài thực hành sau mỗi buổi học, các nhóm thực hiện như sau:
* Tạo 1 Repo trên github để lưu trữ mã nguồn của ứng dụng mobile thực hiện được
trong cả buổi LAB 1 và LAB2 (2 lab đều dùng chung repo này)
  * Cú pháp tên Repo: <MSSV1>_<MSSV2>_MAP_APP
* Tạo 1 Repo khác trên github để lưu trữ mã nguồn của ứng dụng web thực hiện
được trong buổi LAB 3
  * Cú pháp tên Repo: <MSSV1>_<MSSV2>_MAP_WEB
* Tạo 1 link GGdrive/Onedrive lưu trữ video record lại chạy demo chức năng của
app/web thực hiện được sau từng buổi. Mỗi link drive tương ứng cho mỗi buổi.
Đặt tên tương ứng như sau: Video LAB1, Video LAB2, VIdeo LAB3
* Tổng hợp lại link repo github + link GGDrive/OneDrive của video cho từng buổi
và paste vào file template được gửi kèm trên LMS

## III. Chi tiết bài thực hành cho buổi 2

### 1. Xây dựng giao diện và chức năng quản lý thông tin dịch vụ khách sạn

#### Bước 1: Click chuột phải vào thư mục project → Add → New Folder→ Đặt tên folder

là “DichVu”

#### Bước 2: Click chuột phải vào folder DichVu → Add → Forms( Windows Forms) →

tạo một form thể hiện danh sách loại phòng khách sạn là FormDanhSachDichVu.cs

#### Bước 3: Thiết kế giao diện FormDanhSachDichVu.cs theo mẫu như sau:

**Mã nguồn tham khảo trong file FormDanhSachDichVu.Designer.cs tạm thời như sau:**

```csharp
namespace HotelManagement.DichVu
{
partial class FormDanhSachDichVu
{
/// <summary>
/// Required designer variable.
/// </summary>
private System.ComponentModel. IContainer components = null ;
/// <summary>
/// Clean up any resources being used.
/// </summary>
/// <param name="disposing ">true if managed resources should be disposed;
otherwise, false. </param>
protected override void Dispose (bool disposing )
{
if (disposing && (components != null ))
{
components. Dispose ();
}
base . Dispose (disposing );
}
#region Windows Form Designer generated code
/// <summary>
/// Required method for Designer support - do not modify
/// the contents of this method with the code editor.
/// </summary>
private void InitializeComponent ()
{
btnThemMoi = new Button ();
dtgDanhSachDichVu = new DataGridView ();
btnXuatExcel = new Button ();
txtTimKiem = new TextBox ();
pictureBox1 = new PictureBox ();
((System.ComponentModel. ISupportInitialize )dtgDanhSachDichVu). BeginInit ();
((System.ComponentModel. ISupportInitialize )pictureBox1). BeginInit ();
SuspendLayout ();
//
// btnThemMoi
//
btnThemMoi.BackColor = Color .LightPink;
btnThemMoi.Font = new Font ("Microsoft Sans Serif" , 12F, FontStyle .Bold,
GraphicsUnit .Point, 0);
btnThemMoi.Location = new Point (673, 28);
btnThemMoi.Margin = new Padding (3, 4, 3, 4);
btnThemMoi.Name = "btnThemMoi" ;
btnThemMoi.Size = new Size (167, 46);
btnThemMoi.TabIndex = 15;
btnThemMoi.Text = "Thêm mới" ;
btnThemMoi.UseVisualStyleBackColor = false ;
btnThemMoi.Click += btnThemMoi_Click ;
//
// dtgDanhSachDichVu
//
dtgDanhSachDichVu.ColumnHeadersHeightSizeMode =
DataGridViewColumnHeadersHeightSizeMode .AutoSize;
dtgDanhSachDichVu.Location = new Point (12, 90);
dtgDanhSachDichVu.Margin = new Padding (3, 4, 3, 4);
dtgDanhSachDichVu.Name = "dtgDanhSachDichVu" ;
dtgDanhSachDichVu.RowHeadersWidth = 51;
dtgDanhSachDichVu.RowTemplate.Height = 24;
dtgDanhSachDichVu.Size = new Size (945, 679);
dtgDanhSachDichVu.TabIndex = 14;
dtgDanhSachDichVu.CellClick += dtgDanhSachDichVu_CellClick ;
//
// btnXuatExcel
//
btnXuatExcel.BackColor = Color .DarkTurquoise;
btnXuatExcel.Font = new Font ("Microsoft Sans Serif" , 12F, FontStyle .Bold,
GraphicsUnit .Point, 0);
btnXuatExcel.Location = new Point (475, 28);
btnXuatExcel.Margin = new Padding (3, 4, 3, 4);
btnXuatExcel.Name = "btnXuatExcel" ;
btnXuatExcel.Size = new Size (167, 46);
btnXuatExcel.TabIndex = 13;
btnXuatExcel.Text = "Xuất file Excel" ;
btnXuatExcel.UseVisualStyleBackColor = false ;
btnXuatExcel.Click += btnXuatExcel_Click ;
//
// txtTimKiem
//
txtTimKiem.Font = new Font ("Microsoft Sans Serif" , 13F, FontStyle .Regular,
GraphicsUnit .Point, 0);
txtTimKiem.Location = new Point (73, 34);
txtTimKiem.Margin = new Padding (3, 4, 3, 4);
txtTimKiem.Name = "txtTimKiem" ;
txtTimKiem.Size = new Size (187, 32);
txtTimKiem.TabIndex = 11;
txtTimKiem.TextChanged += txtTimKiem_TextChanged ;
//
// pictureBox1
//
pictureBox1.Image = Properties. Resources .search;
pictureBox1.Location = new Point (28, 28);
pictureBox1.Margin = new Padding (3, 4, 3, 4);
pictureBox1.Name = "pictureBox1" ;
pictureBox1.Size = new Size (39, 46);
pictureBox1.TabIndex = 12;
pictureBox1.TabStop = false ;
//
// FormDanhSachDichVu
//
AutoScaleDimensions = new SizeF (8F, 20F);
AutoScaleMode = AutoScaleMode .Font;
ClientSize = new Size (961, 784);
Controls. Add(btnThemMoi);
Controls. Add(dtgDanhSachDichVu);
Controls. Add(btnXuatExcel);
Controls. Add(pictureBox1);
Controls. Add(txtTimKiem);
Margin = new Padding (3, 4, 3, 4);
Name = "FormDanhSachDichVu" ;
StartPosition = FormStartPosition .CenterScreen;
Text = "Quản lý thông tin dịch vụ" ;
((System.ComponentModel. ISupportInitialize )dtgDanhSachDichVu). EndInit ();
((System.ComponentModel. ISupportInitialize )pictureBox1). EndInit ();
ResumeLayout (false );
PerformLayout ();
}
#endregion
private System.Windows.Forms. Button btnThemMoi;
private System.Windows.Forms. DataGridView dtgDanhSachDichVu;
private System.Windows.Forms. Button btnXuatExcel;
private System.Windows.Forms. PictureBox pictureBox1;
private System.Windows.Forms. TextBox txtTimKiem;
}
}
```

#### Bước 4: SV sử dụng mã nguồn tạm thời sau để xử lý chức năng trong file

FormDanhSachDichVu.cs
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
namespace HotelManagement.DichVu
{
public partial class FormDanhSachDichVu : Form
{
private readonly Image _iconDichVu = Properties.Resources.DichVu;
private readonly Image _iconSua = Properties.Resources.edit;
private readonly Image _iconXoa = Properties.Resources.delete;
public FormDanhSachDichVu()
{
InitializeComponent();
Load += FormDanhSachDichVu_Load;
}
private void FormDanhSachDichVu_Load(object? sender, EventArgs e)
{
CauHinhLuoi();
LoadDanhSachDichVu();
}
private void txtTimKiem_TextChanged(object sender, EventArgs e)
{
LocTheoTuKhoa();
}
private void btnXuatExcel_Click(object sender, EventArgs e)
{
var cacDong = dtgDanhSachDichVu.Rows.Cast<DataGridViewRow>()
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
hopLuu.Title = "Xuất danh sách dịch vụ";
hopLuu.Filter = "Excel Workbook (*.xlsx)|*.xlsx";
hopLuu.FileName = $"DanhSachDichVu_{DateTime.Now:yyyyMMdd_HHmm}.xlsx";
if (hopLuu.ShowDialog() != DialogResult.OK)
return;
try
{
using (var wb = new XLWorkbook())
{
var ws = wb.Worksheets.Add("Danh sách dịch vụ");
string[] tenCot = { "MaDV", "TenDV", "DonGia", "SLConLai",
"LoaiDV" };
for (int c = 0; c < tenCot.Length; c++)
ws.Cell(1, c + 1).Value =
dtgDanhSachDichVu.Columns[tenCot[c]].HeaderText;
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
var traLoi = MessageBox.Show("Xuất dữ liệu thành công! \nBạn có muốn
mở file ngay không?", "Thông báo",
MessageBoxButtons.YesNo, MessageBoxIcon.Information);
if (traLoi == DialogResult.Yes)
{
System.Diagnostics.Process.Start(
new System.Diagnostics.ProcessStartInfo(hopLuu.FileName) {
UseShellExecute = true });
}
}
catch (IOException)
{
MessageBox.Show("Không ghi được file. Có thể file đang được mở
trong Excel, hãy đóng lại rồi thử lần nữa.",
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
using (var formThem = new FormThemDichVu())
{
formThem.ShowDialog();
}
LoadDanhSachDichVu();
}
private void dtgDanhSachDichVu_CellClick(object sender,
DataGridViewCellEventArgs e)
{
if (e.RowIndex < 0 || e.ColumnIndex < 0)
return;
string? maDV =
dtgDanhSachDichVu.Rows[e.RowIndex].Cells["MaDV"].Value?.ToString();
string? tenDV =
dtgDanhSachDichVu.Rows[e.RowIndex].Cells["TenDV"].Value?.ToString();
if (string.IsNullOrEmpty(maDV))
return;
string tenCot = dtgDanhSachDichVu.Columns[e.ColumnIndex].Name;
if (tenCot == "colSua")
{
using (var formSua = new FormSuaDichVu())
{
formSua.MaDichVu = maDV;
formSua.ShowDialog();
}
LoadDanhSachDichVu();
}
else if (tenCot == "colXoa")
{
DialogResult result = MessageBox.Show($"Bạn có chắc muốn xóa dịch vụ
{tenDV} ({maDV}) không?", "Xác nhận",
MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
if (result == DialogResult.Yes)
{
XoaDichVu(maDV);
LoadDanhSachDichVu();
}
}
}
private void CauHinhLuoi()
{
if (dtgDanhSachDichVu.Columns.Count > 0)
return;
dtgDanhSachDichVu.ReadOnly = true;
dtgDanhSachDichVu.AllowUserToAddRows = false;
dtgDanhSachDichVu.AllowUserToDeleteRows = false;
dtgDanhSachDichVu.AllowUserToResizeRows = false;
dtgDanhSachDichVu.MultiSelect = false;
dtgDanhSachDichVu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
dtgDanhSachDichVu.RowHeadersVisible = false;
dtgDanhSachDichVu.AutoSizeColumnsMode =
DataGridViewAutoSizeColumnsMode.Fill;
dtgDanhSachDichVu.RowTemplate.Height = 40;
dtgDanhSachDichVu.Columns.Add(TaoCotAnh("colIcon", "", _iconDichVu, 50));
dtgDanhSachDichVu.Columns.Add("MaDV", "Mã DV");
dtgDanhSachDichVu.Columns.Add("TenDV", "Tên dịch vụ");
dtgDanhSachDichVu.Columns.Add("DonGia", "Đơn giá");
dtgDanhSachDichVu.Columns.Add("SLConLai", "Số lượng còn lại");
dtgDanhSachDichVu.Columns.Add("LoaiDV", "Loại dịch vụ");
dtgDanhSachDichVu.Columns["DonGia"]!.DefaultCellStyle.Format = "#,##0'
VNĐ'";
dtgDanhSachDichVu.Columns["DonGia"]!.DefaultCellStyle.Alignment =
DataGridViewContentAlignment.MiddleRight;
dtgDanhSachDichVu.Columns["SLConLai"]!.DefaultCellStyle.Alignment =
DataGridViewContentAlignment.MiddleCenter;
dtgDanhSachDichVu.Columns.Add(TaoCotAnh("colSua", "Sửa", _iconSua, 50));
dtgDanhSachDichVu.Columns.Add(TaoCotAnh("colXoa", "Xóa", _iconXoa, 50));
}
private DataGridViewImageColumn TaoCotAnh(string ten, string tieuDe, Image anh,
int doRong)
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
private void LoadDanhSachDichVu()
{
try
{
using var db = new HotelManagementContext();
var dsDichVu = db.DichVus
.AsNoTracking()
.Where(d => d.DaXoa != true)
.OrderBy(d => d.MaDv)
.Select(d => new
{
d.MaDv,
d.TenDv,
d.DonGia,
d.SlconLai,
d.LoaiDv
})
.ToList();
dtgDanhSachDichVu.Rows.Clear();
foreach (var d in dsDichVu)
{
string soLuong = d.SlconLai == null || d.SlconLai < 0
? "Không giới hạn"
: d.SlconLai.Value.ToString();
dtgDanhSachDichVu.Rows.Add(
_iconDichVu,
d.MaDv,
d.TenDv,
d.DonGia,
soLuong,
d.LoaiDv,
_iconSua,
_iconXoa
);
}
LocTheoTuKhoa();
}
catch (Exception ex)
{
MessageBox.Show("Lỗi tải danh sách dịch vụ: " + ex.Message, "Lỗi",
MessageBoxButtons.OK, MessageBoxIcon.Error);
}
}
private void LocTheoTuKhoa()
{
string keyword = txtTimKiem.Text.Trim();
dtgDanhSachDichVu.CurrentCell = null;
foreach (DataGridViewRow row in dtgDanhSachDichVu.Rows)
{
string ma = row.Cells["MaDV"].Value?.ToString() ?? "";
string ten = row.Cells["TenDV"].Value?.ToString() ?? "";
row.Visible = keyword.Length == 0
|| ma.Contains(keyword,
StringComparison.OrdinalIgnoreCase)
|| ten.Contains(keyword,
StringComparison.OrdinalIgnoreCase);
}
}
private void XoaDichVu(string maDV)
{
try
{
using var db = new HotelManagementContext();
var dichVu = db.DichVus.FirstOrDefault(d => d.MaDv == maDV && d.DaXoa
!= true);
if (dichVu == null)
{
MessageBox.Show("Không tìm thấy dịch vụ để xóa.", "Lỗi",
MessageBoxButtons.OK, MessageBoxIcon.Error);
return;
}
dichVu.DaXoa = true;
db.SaveChanges();
MessageBox.Show("Đã xóa dịch vụ thành công!", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Information);
}
catch (Exception ex)
{
MessageBox.Show("Lỗi khi xóa dịch vụ: " + ex.Message, "Lỗi",
MessageBoxButtons.OK, MessageBoxIcon.Error);
}
}
}
}
```

#### Bước 5: Chỉnh sửa lại hàm private void button11_Click(object sender,

EventArgs e)trong file FormMain.cs theo nội dung như sau:
```csharp
private void button11_Click (object sender , EventArgs e)
{
Form formCon = new DichVu. FormDanhSachDichVu ();
formCon .TopLevel = false ;
formCon .FormBorderStyle = FormBorderStyle .None;
formCon .Dock = DockStyle .Fill;
XoaNoiDungPanelMain (); // hàm có trong bản FormMain mình gửi trước; nếu chưa có,
dùng panelMain.Controls.Clear();
panelMain.Controls. Add(formCon );
formCon . Show();
}
```

#### Bước 5: Click chuột phải vào folder DichVu → Add → Forms( Windows Forms) →

tạo một form để xây dựng giao diện và chức năng thêm mới thông tin 1 dịch vụ là
FormThemDichVu.cs

#### Bước 6: Thiết kế giao diện FormThemDichVu.cs theo mẫu như sau:

**Mã nguồn tham khảo trong file FormThemDichVu.Designer.cs tạm thời như sau:**

```csharp
namespace HotelManagement.DichVu
{
partial class FormThemDichVu
{
/// <summary>
/// Required designer variable.
/// </summary>
private System.ComponentModel. IContainer components = null ;
/// <summary>
/// Clean up any resources being used.
/// </summary>
/// <param name="disposing ">true if managed resources should be disposed;
otherwise, false. </param>
protected override void Dispose (bool disposing )
{
if (disposing && (components != null ))
{
components. Dispose ();
}
base . Dispose (disposing );
}
#region Windows Form Designer generated code
/// <summary>
/// Required method for Designer support - do not modify
/// the contents of this method with the code editor.
/// </summary>
private void InitializeComponent ()
{
btnThoat = new Button ();
btnThemMoi = new Button();
panel1 = new Panel();
cbLoaiDV = new ComboBox();
label7 = new Label();
txtSoLuongConLai = new TextBox();
label3 = new Label();
txtDonGia = new TextBox();
label2 = new Label();
txtTenDV = new TextBox();
label1 = new Label();
txtMaDV = new TextBox();
label5 = new Label();
label6 = new Label();
panel1.SuspendLayout();
SuspendLayout();
//
// btnThoat
//
btnThoat.BackColor = SystemColors.GradientActiveCaption;
btnThoat.Font = new Font( "Microsoft Sans Serif" , 12F, FontStyle.Regular,
GraphicsUnit.Point, 0);
btnThoat.Location = new Point(342, 488);
btnThoat.Margin = new Padding(3, 4, 3, 4);
btnThoat.Name = "btnThoat" ;
btnThoat.Size = new Size(137, 59);
btnThoat.TabIndex = 16;
btnThoat.Text = "Thoát" ;
btnThoat.UseVisualStyleBackColor = false ;
btnThoat.Click += btnThoat_Click;
//
// btnThemMoi
//
btnThemMoi.BackColor = Color.Moccasin;
btnThemMoi.Font = new Font( "Microsoft Sans Serif" , 12F, FontStyle.Regular,
GraphicsUnit.Point, 0);
btnThemMoi.Location = new Point(142, 488);
btnThemMoi.Margin = new Padding(3, 4, 3, 4);
btnThemMoi.Name = "btnThemMoi" ;
btnThemMoi.Size = new Size(137, 59);
btnThemMoi.TabIndex = 15;
btnThemMoi.Text = "Thêm mới" ;
btnThemMoi.UseVisualStyleBackColor = false ;
btnThemMoi.Click += btnThemMoi_Click;
//
// panel1
//
panel1.Controls.Add(cbLoaiDV);
panel1.Controls.Add(label7);
panel1.Controls.Add(txtSoLuongConLai);
panel1.Controls.Add(label3);
panel1.Controls.Add(txtDonGia);
panel1.Controls.Add(label2);
panel1.Controls.Add(txtTenDV);
panel1.Controls.Add(label1);
panel1.Controls.Add(txtMaDV);
panel1.Controls.Add(label5);
panel1.Location = new Point(66, 114);
panel1.Margin = new Padding(3, 4, 3, 4);
panel1.Name = "panel1" ;
panel1.Size = new Size(507, 340);
panel1.TabIndex = 14;
//
// cbLoaiDV
//
cbLoaiDV.Font = new Font( "Microsoft Sans Serif" , 11F, FontStyle.Regular,
GraphicsUnit.Point, 0);
cbLoaiDV.FormattingEnabled = true ;
cbLoaiDV.Items.AddRange( new object [] { "Dịch vụ giặt ủi quần áo" , "Dịch vụ
xe đưa đón " , "Dịch vụ cho thuê xe máy tự lái" , "Dịch vụ đặt vé máy bay, tour du lịch" ,
"Dịch vụ trông trẻ" , "Bơi 4 mùa " , "Dịch vụ karaoke" , "Dịch vụ phục vụ phòng 24/24" ,
"Dịch vụ thu đổi ngoại tệ" , "Nhà hàng" , "Dịch vụ hội họp, văn phòng" , "Dịch vụ Spa" });
cbLoaiDV.Location = new Point(202, 152);
cbLoaiDV.Margin = new Padding(3, 4, 3, 4);
cbLoaiDV.Name = "cbLoaiDV" ;
cbLoaiDV.Size = new Size(290, 30);
cbLoaiDV.TabIndex = 25;
//
// label7
//
label7.AutoSize = true ;
label7.Font = new Font( "Microsoft Sans Serif" , 13F, FontStyle.Regular,
GraphicsUnit.Point, 0);
label7.Location = new Point(48, 151);
label7.Name = "label7" ;
label7.Size = new Size(128, 26);
label7.TabIndex = 24;
label7.Text = "Loại dịch vụ" ;
//
// txtSoLuongConLai
//
txtSoLuongConLai.Font = new Font( "Microsoft Sans Serif" , 12F,
FontStyle.Regular, GraphicsUnit.Point, 0);
txtSoLuongConLai.Location = new Point(202, 276);
txtSoLuongConLai.Margin = new Padding(3, 4, 3, 4);
txtSoLuongConLai.Name = "txtSoLuongConLai" ;
txtSoLuongConLai.Size = new Size(290, 30);
txtSoLuongConLai.TabIndex = 23;
txtSoLuongConLai.KeyPress += txtSoLuongConLai_KeyPress;
//
// label3
//
label3.AutoSize = true ;
label3.Font = new Font( "Microsoft Sans Serif" , 13F, FontStyle.Regular,
GraphicsUnit.Point, 0);
label3.Location = new Point(15, 279);
label3.Name = "label3" ;
label3.Size = new Size(167, 26);
label3.TabIndex = 22;
label3.Text = "Số lượng còn lại" ;
//
// txtDonGia
//
txtDonGia.Font = new Font( "Microsoft Sans Serif" , 12F, FontStyle.Regular,
GraphicsUnit.Point, 0);
txtDonGia.Location = new Point(202, 214);
txtDonGia.Margin = new Padding(3, 4, 3, 4);
txtDonGia.Name = "txtDonGia" ;
txtDonGia.Size = new Size(290, 30);
txtDonGia.TabIndex = 21;
txtDonGia.KeyPress += txtDonGia_KeyPress;
//
// label2
//
label2.AutoSize = true ;
label2.Font = new Font( "Microsoft Sans Serif" , 13F, FontStyle.Regular,
GraphicsUnit.Point, 0);
label2.Location = new Point(89, 214);
label2.Name = "label2" ;
label2.Size = new Size(87, 26);
label2.TabIndex = 20;
label2.Text = "Đơn giá" ;
//
// txtTenDV
//
txtTenDV.Font = new Font( "Microsoft Sans Serif" , 12F, FontStyle.Regular,
GraphicsUnit.Point, 0);
txtTenDV.Location = new Point(202, 82);
txtTenDV.Margin = new Padding(3, 4, 3, 4);
txtTenDV.Name = "txtTenDV" ;
txtTenDV.Size = new Size(290, 30);
txtTenDV.TabIndex = 19;
//
// label1
//
label1.AutoSize = true ;
label1.Font = new Font( "Microsoft Sans Serif" , 13F, FontStyle.Regular,
GraphicsUnit.Point, 0);
label1.Location = new Point(59, 79);
label1.Name = "label1" ;
label1.Size = new Size(123, 26);
label1.TabIndex = 18;
label1.Text = "Tên dịch vụ" ;
//
// txtMaDV
//
txtMaDV.Font = new Font( "Microsoft Sans Serif" , 12F, FontStyle.Regular,
GraphicsUnit.Point, 0);
txtMaDV.Location = new Point(202, 22);
txtMaDV.Margin = new Padding(3, 4, 3, 4);
txtMaDV.Name = "txtMaDV" ;
txtMaDV.Size = new Size(290, 30);
txtMaDV.TabIndex = 17;
//
// label5
//
label5.AutoSize = true ;
label5.Font = new Font( "Microsoft Sans Serif" , 13F, FontStyle.Regular,
GraphicsUnit.Point, 0);
label5.Location = new Point(59, 19);
label5.Name = "label5" ;
label5.Size = new Size(117, 26);
label5.TabIndex = 16;
label5.Text = "Mã dịch vụ" ;
//
// label6
//
label6.AutoSize = true ;
label6.Font = new Font( "Microsoft Sans Serif" , 15F, FontStyle.Bold,
GraphicsUnit.Point, 0);
label6.ForeColor = Color.FromArgb(192, 0, 0);
label6.Location = new Point(175, 45);
label6.Name = "label6" ;
label6.Size = new Size(292, 29);
label6.TabIndex = 17;
label6.Text = "Thêm thông tin dịch vụ" ;
//
// FormThemDichVu
//
AutoScaleDimensions = new SizeF(8F, 20F);
AutoScaleMode = AutoScaleMode.Font;
ClientSize = new Size(602, 561);
Controls.Add(label6);
Controls.Add(btnThoat);
Controls.Add(btnThemMoi);
Controls.Add(panel1);
Margin = new Padding(3, 4, 3, 4);
Name = "FormThemDichVu" ;
Text = "FormThemDichVu" ;
panel1.ResumeLayout( false );
panel1. PerformLayout ();
ResumeLayout (false );
PerformLayout ();
}
#endregion
private System.Windows.Forms. Button btnThoat;
private System.Windows.Forms. Button btnThemMoi;
private System.Windows.Forms. Panel panel1;
private System.Windows.Forms. TextBox txtMaDV;
private System.Windows.Forms. Label label5;
private System.Windows.Forms. Label label6;
private System.Windows.Forms. TextBox txtSoLuongConLai;
private System.Windows.Forms. Label label3;
private System.Windows.Forms. TextBox txtDonGia;
private System.Windows.Forms. Label label2;
private System.Windows.Forms. TextBox txtTenDV;
private System.Windows.Forms. Label label1;
private System.Windows.Forms. ComboBox cbLoaiDV;
private System.Windows.Forms. Label label7;
}
}
```

#### Bước 7: SV sử dụng mã nguồn tạm thời sau để xử lý chức năng trong file

FormThemDichVu.cs
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
namespace HotelManagement.DichVu
{
public partial class FormThemDichVu : Form
{
private static readonly string [] LoaiMacDinh = { "Thức uống" , "Đồ ăn" , "Dịch
vụ" };
public FormThemDichVu ()
{
InitializeComponent();
Text = "Thêm mới dịch vụ" ;
StartPosition = FormStartPosition.CenterParent;
FormBorderStyle = FormBorderStyle.FixedDialog;
MaximizeBox = false ;
MinimizeBox = false ;
AcceptButton = btnThemMoi;
CancelButton = btnThoat;
txtMaDV.MaxLength = 5;
txtTenDV.MaxLength = 20;
txtDonGia.MaxLength = 12;
txtSoLuongConLai.MaxLength = 6;
txtSoLuongConLai.PlaceholderText = "Để trống = không giới hạn" ;
cbLoaiDV.DropDownStyle = ComboBoxStyle.DropDownList;
Load += FormThemDichVu_Load;
}
private void FormThemDichVu_Load (object ? sender , EventArgs e)
{
var dsLoai = new List< string >(LoaiMacDinh);
try
{
using var db = new HotelManagementContext();
var loaiTrongCsdl = db.DichVus
.AsNoTracking()
.Select( d => d.LoaiDv)
.Distinct()
.ToList();
foreach (var loai in loaiTrongCsdl)
{
string ten = (loai ?? "" ).Trim();
if (ten.Length > 0 && !dsLoai.Contains(ten,
StringComparer.OrdinalIgnoreCase))
dsLoai.Add(ten);
}
}
catch (Exception ex)
{
MessageBox.Show( "Lỗi tải loại dịch vụ: " + ex.Message, "Lỗi" ,
MessageBoxButtons.OK, MessageBoxIcon.Error);
}
cbLoaiDV.Items.Clear();
cbLoaiDV.Items.AddRange(dsLoai.ToArray());
cbLoaiDV.SelectedIndex = -1;
}
private void txtDonGia_KeyPress (object sender , KeyPressEventArgs e)
{
if (! char . IsControl (e.KeyChar) && ! char . IsDigit (e.KeyChar))
{
e.Handled = true ;
}
}
private void txtSoLuongConLai_KeyPress (object sender , KeyPressEventArgs e)
{
if (! char . IsControl (e.KeyChar) && ! char . IsDigit (e.KeyChar))
{
e.Handled = true ;
}
}
private void btnThemMoi_Click (object sender , EventArgs e)
{
string maDV = txtMaDV.Text. Trim (). ToUpper ();
string tenDV = txtTenDV.Text. Trim ();
string donGiaText = txtDonGia.Text. Trim ();
string soLuongText = txtSoLuongConLai.Text. Trim ();
string loaiDV = cbLoaiDV.SelectedItem?. ToString ()?. Trim () ?? "" ;
if (maDV.Length == 0)
{
MessageBox . Show("Vui lòng nhập mã dịch vụ." , "Thiếu thông tin" ,
MessageBoxButtons .OK, MessageBoxIcon .Warning);
txtMaDV. Focus ();
return ;
}
if (tenDV .Length == 0)
{
MessageBox . Show("Vui lòng nhập tên dịch vụ." , "Thiếu thông tin" ,
MessageBoxButtons .OK, MessageBoxIcon .Warning);
txtTenDV. Focus ();
return ;
}
if (loaiDV .Length == 0)
{
MessageBox . Show("Vui lòng chọn loại dịch vụ." , "Thiếu thông tin" ,
MessageBoxButtons .OK, MessageBoxIcon .Warning);
cbLoaiDV. Focus ();
return ;
}
if (loaiDV .Length > 20)
{
MessageBox . Show("Tên loại dịch vụ tối đa 20 ký tự." , "Thông báo" ,
MessageBoxButtons .OK, MessageBoxIcon .Warning);
cbLoaiDV. Focus ();
return ;
}
if (! decimal . TryParse (donGiaText , out decimal donGia ) || donGia <= 0)
{
MessageBox . Show("Đơn giá không hợp lệ!" , "Thông báo" ,
MessageBoxButtons .OK, MessageBoxIcon .Warning);
txtDonGia. Focus ();
return ;
}
int soLuongConLai = -1;
if (soLuongText .Length > 0 && (! int . TryParse (soLuongText , out
soLuongConLai ) || soLuongConLai < 0))
{
MessageBox . Show("Số lượng còn lại không hợp lệ!" , "Thông báo" ,
MessageBoxButtons .OK, MessageBoxIcon .Warning);
txtSoLuongConLai. Focus ();
return ;
}
try
{
using var db = new HotelManagementContext ();
var daCo = db.DichVus. FirstOrDefault (d => d.MaDv == maDV);
if (daCo != null )
{
if (daCo.DaXoa != true )
{
MessageBox . Show("Mã dịch vụ đã tồn tại. Vui lòng nhập mã
khác." , "Thông báo" ,
MessageBoxButtons .OK, MessageBoxIcon .Warning);
txtMaDV. Focus ();
return ;
}
var traLoi = MessageBox . Show(
$"Mã {maDV} từng thuộc dịch vụ \"{daCo.TenDv} \" đã bị xóa. \nBạn
có muốn khôi phục mã này với thông tin vừa nhập không?" ,
"Xác nhận" , MessageBoxButtons .YesNo, MessageBoxIcon .Question);
if (traLoi != DialogResult .Yes)
{
txtMaDV. Focus ();
return ;
}
daCo.TenDv = tenDV ;
daCo.DonGia = donGia ;
daCo.SlconLai = soLuongConLai ;
daCo.LoaiDv = loaiDV ;
daCo.DaXoa = false ;
}
else
{
db.DichVus. Add(new Models. DichVu
{
MaDv = maDV,
TenDv = tenDV ,
DonGia = donGia ,
SlconLai = soLuongConLai ,
LoaiDv = loaiDV ,
DaXoa = false
});
}
int rows = db. SaveChanges ();
if (rows > 0)
{
MessageBox . Show("Thêm dịch vụ thành công!" , "Thành công" ,
MessageBoxButtons .OK, MessageBoxIcon .Information);
DialogResult = DialogResult .OK;
this . Close ();
}
else
{
MessageBox . Show("Thêm thất bại!" , "Lỗi" , MessageBoxButtons .OK,
MessageBoxIcon .Error);
}
}
catch (DbUpdateException ex)
{
MessageBox . Show("Lỗi: " + ( ex.InnerException?.Message ?? ex.Message),
"Lỗi khi thêm" ,
MessageBoxButtons .OK, MessageBoxIcon .Error);
}
catch (Exception ex)
{
MessageBox . Show("Lỗi: " + ex.Message, "Lỗi khi thêm" ,
MessageBoxButtons .OK, MessageBoxIcon .Error);
}
}
private void btnThoat_Click (object sender , EventArgs e)
{
DialogResult = DialogResult .Cancel;
this . Close ();
}
}
}
```

#### Bước 8: Click chuột phải vào folder DichVu → Add → Forms( Windows Forms) →

tạo một form để xây dựng giao diện và chức năng cập nhật thông tin 1 dịch vụ đang có
là FormSuaDichVu.cs

#### Bước 10: Thiết kế giao diện FormSuaDichVu.cs theo mẫu như sau:

**Mã nguồn tham khảo trong file FormSuaDichVu.Designer.cs tạm thời như sau:**

```csharp
namespace HotelManagement.DichVu
{
partial class FormSuaDichVu
{
/// <summary>
/// Required designer variable.
/// </summary>
private System.ComponentModel. IContainer components = null ;
/// <summary>
/// Clean up any resources being used.
/// </summary>
/// <param name="disposing ">true if managed resources should be disposed;
otherwise, false. </param>
protected override void Dispose (bool disposing )
{
if (disposing && (components != null ))
{
components. Dispose ();
}
base . Dispose (disposing );
}
#region Windows Form Designer generated code
/// <summary>
/// Required method for Designer support - do not modify
/// the contents of this method with the code editor.
/// </summary>
private void InitializeComponent ()
{
label6 = new Label ();
btnThoat = new Button();
btnCapNhat = new Button();
panel1 = new Panel();
cbLoaiDV = new ComboBox();
label7 = new Label();
txtSoLuongConLai = new TextBox();
label3 = new Label();
txtDonGia = new TextBox();
label2 = new Label();
txtTenDV = new TextBox();
label1 = new Label();
panel1.SuspendLayout();
SuspendLayout();
//
// label6
//
label6.AutoSize = true ;
label6.Font = new Font( "Microsoft Sans Serif" , 15F, FontStyle.Bold,
GraphicsUnit.Point, 0);
label6.ForeColor = Color.FromArgb(192, 0, 0);
label6.Location = new Point(124, 29);
label6.Name = "label6" ;
label6.Size = new Size(333, 29);
label6.TabIndex = 21;
label6.Text = "Cập nhật thông tin dịch vụ" ;
//
// btnThoat
//
btnThoat.BackColor = SystemColors.GradientActiveCaption;
btnThoat.Font = new Font( "Microsoft Sans Serif" , 12F, FontStyle.Regular,
GraphicsUnit.Point, 0);
btnThoat.Location = new Point(323, 429);
btnThoat.Margin = new Padding(3, 4, 3, 4);
btnThoat.Name = "btnThoat" ;
btnThoat.Size = new Size(137, 59);
btnThoat.TabIndex = 20;
btnThoat.Text = "Thoát" ;
btnThoat.UseVisualStyleBackColor = false ;
btnThoat.Click += btnThoat_Click;
//
// btnCapNhat
//
btnCapNhat.BackColor = Color.Moccasin;
btnCapNhat.Font = new Font( "Microsoft Sans Serif" , 12F, FontStyle.Regular,
GraphicsUnit.Point, 0);
btnCapNhat.Location = new Point(123, 429);
btnCapNhat.Margin = new Padding(3, 4, 3, 4);
btnCapNhat.Name = "btnCapNhat" ;
btnCapNhat.Size = new Size(137, 59);
btnCapNhat.TabIndex = 19;
btnCapNhat.Text = "Cập nhật" ;
btnCapNhat.UseVisualStyleBackColor = false ;
btnCapNhat.Click += btnCapNhat_Click;
//
// panel1
//
panel1.Controls.Add(cbLoaiDV);
panel1.Controls.Add(label7);
panel1.Controls.Add(txtSoLuongConLai);
panel1.Controls.Add(label3);
panel1.Controls.Add(txtDonGia);
panel1.Controls.Add(label2);
panel1.Controls.Add(txtTenDV);
panel1.Controls.Add(label1);
panel1.Location = new Point(35, 94);
panel1.Margin = new Padding(3, 4, 3, 4);
panel1.Name = "panel1" ;
panel1.Size = new Size(507, 288);
panel1.TabIndex = 18;
//
// cbLoaiDV
//
cbLoaiDV.Font = new Font( "Microsoft Sans Serif" , 11F, FontStyle.Regular,
GraphicsUnit.Point, 0);
cbLoaiDV.FormattingEnabled = true ;
cbLoaiDV.Items.AddRange( new object [] { "Dịch vụ giặt ủi quần áo" , "Dịch vụ
xe đưa đón " , "Dịch vụ cho thuê xe máy tự lái" , "Dịch vụ đặt vé máy bay, tour du lịch" ,
"Dịch vụ trông trẻ" , "Bơi 4 mùa " , "Dịch vụ karaoke" , "Dịch vụ phục vụ phòng 24/24" ,
"Dịch vụ thu đổi ngoại tệ" , "Nhà hàng" , "Dịch vụ hội họp, văn phòng" , "Dịch vụ Spa" });
cbLoaiDV.Location = new Point(202, 95);
cbLoaiDV.Margin = new Padding(3, 4, 3, 4);
cbLoaiDV.Name = "cbLoaiDV" ;
cbLoaiDV.Size = new Size(284, 30);
cbLoaiDV.TabIndex = 25;
//
// label7
//
label7.AutoSize = true ;
label7.Font = new Font( "Microsoft Sans Serif" , 13F, FontStyle.Regular,
GraphicsUnit.Point, 0);
label7.Location = new Point(48, 94);
label7.Name = "label7" ;
label7.Size = new Size(128, 26);
label7.TabIndex = 24;
label7.Text = "Loại dịch vụ" ;
//
// txtSoLuongConLai
//
txtSoLuongConLai.Font = new Font( "Microsoft Sans Serif" , 12F,
FontStyle.Regular, GraphicsUnit.Point, 0);
txtSoLuongConLai.Location = new Point(202, 219);
txtSoLuongConLai.Margin = new Padding(3, 4, 3, 4);
txtSoLuongConLai.Name = "txtSoLuongConLai" ;
txtSoLuongConLai.Size = new Size(284, 30);
txtSoLuongConLai.TabIndex = 23;
txtSoLuongConLai.KeyPress += txtSoLuongConLai_KeyPress;
//
// label3
//
label3.AutoSize = true ;
label3.Font = new Font( "Microsoft Sans Serif" , 13F, FontStyle.Regular,
GraphicsUnit.Point, 0);
label3.Location = new Point(15, 221);
label3.Name = "label3" ;
label3.Size = new Size(167, 26);
label3.TabIndex = 22;
label3.Text = "Số lượng còn lại" ;
//
// txtDonGia
//
txtDonGia.Font = new Font( "Microsoft Sans Serif" , 12F, FontStyle.Regular,
GraphicsUnit.Point, 0);
txtDonGia.Location = new Point(202, 156);
txtDonGia.Margin = new Padding(3, 4, 3, 4);
txtDonGia.Name = "txtDonGia" ;
txtDonGia.Size = new Size(284, 30);
txtDonGia.TabIndex = 21;
txtDonGia.KeyPress += txtDonGia_KeyPress;
//
// label2
//
label2.AutoSize = true ;
label2.Font = new Font( "Microsoft Sans Serif" , 13F, FontStyle.Regular,
GraphicsUnit.Point, 0);
label2.Location = new Point(89, 156);
label2.Name = "label2" ;
label2.Size = new Size(87, 26);
label2.TabIndex = 20;
label2.Text = "Đơn giá" ;
//
// txtTenDV
//
txtTenDV.Font = new Font( "Microsoft Sans Serif" , 12F, FontStyle.Regular,
GraphicsUnit.Point, 0);
txtTenDV.Location = new Point(202, 25);
txtTenDV.Margin = new Padding(3, 4, 3, 4);
txtTenDV.Name = "txtTenDV" ;
txtTenDV.Size = new Size(284, 30);
txtTenDV.TabIndex = 19;
//
// label1
//
label1.AutoSize = true ;
label1.Font = new Font( "Microsoft Sans Serif" , 13F, FontStyle.Regular,
GraphicsUnit.Point, 0);
label1.Location = new Point(59, 21);
label1.Name = "label1" ;
label1.Size = new Size(123, 26);
label1.TabIndex = 18;
label1.Text = "Tên dịch vụ" ;
//
// FormSuaDichVu
//
AutoScaleDimensions = new SizeF(8F, 20F);
AutoScaleMode = AutoScaleMode.Font;
ClientSize = new Size(540, 522);
Controls.Add(label6);
Controls.Add(btnThoat);
Controls.Add(btnCapNhat);
Controls.Add(panel1);
Margin = new Padding(3, 4, 3, 4);
Name = "FormSuaDichVu" ;
Text = "FormSuaDichVu" ;
panel1. ResumeLayout (false );
panel1. PerformLayout ();
ResumeLayout (false );
PerformLayout ();
}
#endregion
private System.Windows.Forms. Label label6;
private System.Windows.Forms. Button btnThoat;
private System.Windows.Forms. Button btnCapNhat;
private System.Windows.Forms. Panel panel1;
private System.Windows.Forms. ComboBox cbLoaiDV;
private System.Windows.Forms. Label label7;
private System.Windows.Forms. TextBox txtSoLuongConLai;
private System.Windows.Forms. Label label3;
private System.Windows.Forms. TextBox txtDonGia;
private System.Windows.Forms. Label label2;
private System.Windows.Forms. TextBox txtTenDV;
private System.Windows.Forms. Label label1;
}
}
```

#### Bước 10: SV sử dụng mã nguồn tạm thời sau để xử lý chức năng trong file

FormSuaDichVu.cs
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
namespace HotelManagement.DichVu
{
public partial class FormSuaDichVu : Form
{
private static readonly string [] LoaiMacDinh = { "Thức uống" , "Đồ ăn" , "Dịch
vụ" };
[Browsable (false )]
[DesignerSerializationVisibility (DesignerSerializationVisibility .Hidden)]
public string ? MaDichVu { get ; set ; }
public FormSuaDichVu ()
{
InitializeComponent ();
Text = "Cập nhật thông tin dịch vụ" ;
StartPosition = FormStartPosition .CenterParent;
FormBorderStyle = FormBorderStyle .FixedDialog;
MaximizeBox = false ;
MinimizeBox = false ;
AcceptButton = btnCapNhat;
CancelButton = btnThoat;
txtTenDV.MaxLength = 20;
txtDonGia.MaxLength = 12;
txtSoLuongConLai.MaxLength = 6;
txtSoLuongConLai.PlaceholderText = "Để trống = không giới hạn" ;
cbLoaiDV.DropDownStyle = ComboBoxStyle .DropDownList;
Load += FormSuaDichVu_Load ;
}
private void FormSuaDichVu_Load (object ? sender , EventArgs e)
{
string ? ma = MaDichVu;
if (string .IsNullOrEmpty (ma))
{
MessageBox . Show("Chưa xác định được dịch vụ cần cập nhật." , "Lỗi" ,
MessageBoxButtons .OK, MessageBoxIcon .Error);
btnCapNhat.Enabled = false ;
return ;
}
Text = "Cập nhật dịch vụ " + ma;
try
{
using var db = new HotelManagementContext ();
var dsLoai = new List <string >(LoaiMacDinh);
var loaiTrongCsdl = db.DichVus
. AsNoTracking ()
. Select (d => d.LoaiDv)
. Distinct ()
. ToList ();
foreach (var loai in loaiTrongCsdl )
{
string ten = ( loai ?? "" ). Trim ();
if (ten .Length > 0 && ! dsLoai . Contains (ten ,
StringComparer .OrdinalIgnoreCase))
dsLoai . Add(ten );
}
cbLoaiDV.Items. Clear ();
cbLoaiDV.Items. AddRange (dsLoai . ToArray ());
var thongTin = db.DichVus
. AsNoTracking ()
. Where(d => d.MaDv == ma && d.DaXoa != true )
. Select (d => new { d.TenDv, d.DonGia, d.SlconLai, d.LoaiDv })
. FirstOrDefault ();
if (thongTin == null )
{
MessageBox . Show("Không tìm thấy dịch vụ " + ma + "." , "Lỗi" ,
MessageBoxButtons .OK, MessageBoxIcon .Error);
btnCapNhat.Enabled = false ;
return ;
}
txtTenDV.Text = thongTin .TenDv;
txtDonGia.Text = thongTin .DonGia. ToString ("0" );
txtSoLuongConLai.Text = thongTin .SlconLai == null || thongTin .SlconLai
< 0
? ""
: thongTin .SlconLai.Value. ToString ();
cbLoaiDV.SelectedIndex = cbLoaiDV. FindStringExact (( thongTin .LoaiDv ??
"" ). Trim ());
}
catch (Exception ex)
{
MessageBox . Show("Lỗi tải thông tin dịch vụ: " + ex.Message, "Lỗi" ,
MessageBoxButtons .OK, MessageBoxIcon .Error);
btnCapNhat.Enabled = false ;
}
}
private void btnCapNhat_Click (object sender , EventArgs e)
{
string ? ma = MaDichVu;
if (string .IsNullOrEmpty (ma))
{
MessageBox . Show("Chưa xác định được dịch vụ cần cập nhật." , "Lỗi" ,
MessageBoxButtons .OK, MessageBoxIcon .Error);
return ;
}
string tenDV = txtTenDV.Text. Trim ();
string donGiaText = txtDonGia.Text. Trim ();
string soLuongText = txtSoLuongConLai.Text. Trim ();
string loaiDV = cbLoaiDV.SelectedItem?. ToString ()?. Trim () ?? "" ;
if (tenDV .Length == 0)
{
MessageBox . Show("Vui lòng nhập tên dịch vụ." , "Thiếu thông tin" ,
MessageBoxButtons .OK, MessageBoxIcon .Warning);
txtTenDV. Focus ();
return ;
}
if (loaiDV .Length == 0)
{
MessageBox . Show("Vui lòng chọn loại dịch vụ." , "Thiếu thông tin" ,
MessageBoxButtons .OK, MessageBoxIcon .Warning);
cbLoaiDV. Focus ();
return ;
}
if (! decimal . TryParse (donGiaText , out decimal donGia ) || donGia <= 0)
{
MessageBox . Show("Đơn giá không hợp lệ!" , "Thông báo" ,
MessageBoxButtons .OK, MessageBoxIcon .Warning);
txtDonGia. Focus ();
return ;
}
int soLuongConLai = -1;
if (soLuongText .Length > 0 && (! int . TryParse (soLuongText , out
soLuongConLai ) || soLuongConLai < 0))
{
MessageBox . Show("Số lượng còn lại không hợp lệ!" , "Thông báo" ,
MessageBoxButtons .OK, MessageBoxIcon .Warning);
txtSoLuongConLai. Focus ();
return ;
}
try
{
using var db = new HotelManagementContext ();
var dichVu = db.DichVus. FirstOrDefault (d => d.MaDv == ma && d.DaXoa !=
true );
if (dichVu == null )
{
MessageBox . Show("Không tìm thấy dịch vụ cần cập nhật." , "Lỗi" ,
MessageBoxButtons .OK, MessageBoxIcon .Error);
return ;
}
dichVu .TenDv = tenDV ;
dichVu .DonGia = donGia ;
dichVu .SlconLai = soLuongConLai ;
dichVu .LoaiDv = loaiDV ;
int rows = db. SaveChanges ();
if (rows > 0)
{
MessageBox . Show("Cập nhật thành công!" , "Thông báo" ,
MessageBoxButtons .OK, MessageBoxIcon .Information);
DialogResult = DialogResult .OK;
this . Close ();
}
else
{
MessageBox . Show("Thông tin không thay đổi nên không có gì để cập
nhật." , "Thông báo" ,
MessageBoxButtons .OK, MessageBoxIcon .Information);
}
}
catch (DbUpdateException ex)
{
MessageBox . Show("Lỗi khi cập nhật: " + ( ex.InnerException?.Message ??
ex.Message), "Lỗi" ,
MessageBoxButtons .OK, MessageBoxIcon .Error);
}
catch (Exception ex)
{
MessageBox . Show("Lỗi khi cập nhật: " + ex.Message, "Lỗi" ,
MessageBoxButtons .OK, MessageBoxIcon .Error);
}
}
private void txtSoLuongConLai_KeyPress (object sender , KeyPressEventArgs e)
{
if (! char . IsControl (e.KeyChar) && ! char . IsDigit (e.KeyChar))
{
e.Handled = true ;
}
}
private void txtDonGia_KeyPress (object sender , KeyPressEventArgs e)
{
if (! char . IsControl (e.KeyChar) && ! char . IsDigit (e.KeyChar))
{
e.Handled = true ;
}
}
private void btnThoat_Click (object sender , EventArgs e)
{
DialogResult = DialogResult .Cancel;
this . Close ();
}
}
}
```

### 2. Xây dựng giao diện và chức năng quản lý thông tin dịch vụ khách sạn

#### Bước 1: Click chuột phải vào thư mục project → Add → New Folder→ Đặt tên folder

là “TienNghi”

#### Bước 2: Click chuột phải vào folder TienNghi → Add → Forms( Windows Forms) →

tạo một form thể hiện danh sách các tiện ích có trong khách sạn là
FormDanhSachTienNghi.cs

#### Bước 3: Thiết kế giao diện FormDanhSachTienNghi.cs theo mẫu như sau:

Mã nguồn tham khảo trong file FormDanhSachTienNghi.Designer.cs tạm thời như
sau:
```csharp
namespace HotelManagement.TienNghi
{
partial class FormDanhSachTienNghi
{
/// <summary>
/// Required designer variable.
/// </summary>
private System.ComponentModel. IContainer components = null ;
/// <summary>
/// Clean up any resources being used.
/// </summary>
/// <param name="disposing ">true if managed resources should be disposed;
otherwise, false. </param>
protected override void Dispose (bool disposing )
{
if (disposing && (components != null ))
{
components. Dispose ();
}
base . Dispose (disposing );
}
#region Windows Form Designer generated code
/// <summary>
/// Required method for Designer support - do not modify
/// the contents of this method with the code editor.
/// </summary>
private void InitializeComponent ()
{
this .btnThemMoi = new System.Windows.Forms. Button ();
this .dtgDanhSachTienNghi = new System.Windows.Forms. DataGridView ();
this .btnXuatExcel = new System.Windows.Forms. Button ();
this .txtTimKiem = new System.Windows.Forms. TextBox ();
this .pictureBox1 = new System.Windows.Forms. PictureBox ();
((System.ComponentModel. ISupportInitialize )( this .dtgDanhSachTienNghi)). BeginInit ();
((System.ComponentModel. ISupportInitialize )( this .pictureBox1)). BeginInit ();
this . SuspendLayout ();
//
// btnThemMoi
//
this .btnThemMoi.BackColor = System.Drawing. Color .LightPink;
this .btnThemMoi.Font = new System.Drawing. Font ("Microsoft Sans Serif" , 12F,
System.Drawing. FontStyle .Bold, System.Drawing. GraphicsUnit .Point, (( byte )(0)));
this .btnThemMoi.Location = new System.Drawing. Point (841, 8);
this .btnThemMoi.Name = "btnThemMoi" ;
this .btnThemMoi.Size = new System.Drawing. Size (167, 37);
this .btnThemMoi.TabIndex = 15;
this .btnThemMoi.Text = "Thêm mới" ;
this .btnThemMoi.UseVisualStyleBackColor = false ;
// this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
//
// dtgDanhSachTienNghi
//
this .dtgDanhSachTienNghi.ColumnHeadersHeightSizeMode =
System.Windows.Forms. DataGridViewColumnHeadersHeightSizeMode .AutoSize;
this .dtgDanhSachTienNghi.Location = new System.Drawing. Point (3, 62);
this .dtgDanhSachTienNghi.Name = "dtgDanhSachTienNghi" ;
this .dtgDanhSachTienNghi.RowHeadersWidth = 51;
this .dtgDanhSachTienNghi.RowTemplate.Height = 24;
this .dtgDanhSachTienNghi.Size = new System.Drawing. Size (1035, 615);
this .dtgDanhSachTienNghi.TabIndex = 14;
// this.dtgDanhSachTienNghi.CellClick += new
System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDanhSachTienNghi_CellClick);
//
// btnXuatExcel
//
this .btnXuatExcel.BackColor = System.Drawing. Color .DarkTurquoise;
this .btnXuatExcel.Font = new System.Drawing. Font ("Microsoft Sans Serif" ,
12F, System.Drawing. FontStyle .Bold, System.Drawing. GraphicsUnit .Point, (( byte )(0)));
this .btnXuatExcel.Location = new System.Drawing. Point (640, 8);
this .btnXuatExcel.Name = "btnXuatExcel" ;
this .btnXuatExcel.Size = new System.Drawing. Size (167, 37);
this .btnXuatExcel.TabIndex = 13;
this .btnXuatExcel.Text = "Xuất file Excel" ;
this .btnXuatExcel.UseVisualStyleBackColor = false ;
// this.btnXuatExcel.Click += new
System.EventHandler(this.btnXuatExcel_Click);
//
// txtTimKiem
//
this .txtTimKiem.Font = new System.Drawing. Font ("Microsoft Sans Serif" , 13F,
System.Drawing. FontStyle .Regular, System.Drawing. GraphicsUnit .Point, (( byte )(0)));
this .txtTimKiem.Location = new System.Drawing. Point (199, 13);
this .txtTimKiem.Name = "txtTimKiem" ;
this .txtTimKiem.Size = new System.Drawing. Size (187, 32);
this .txtTimKiem.TabIndex = 11;
// this.txtTimKiem.TextChanged += new
System.EventHandler(this.txtTimKiem_TextChanged);
//
// pictureBox1
//
this .pictureBox1.Image =
global ::HotelManagement.Properties. Resources .search;
this .pictureBox1.Location = new System.Drawing. Point (154, 8);
this .pictureBox1.Name = "pictureBox1" ;
this .pictureBox1.Size = new System.Drawing. Size (39, 37);
this .pictureBox1.TabIndex = 12;
this .pictureBox1.TabStop = false ;
//
// FormDanhSachTienNghi
//
this .AutoScaleDimensions = new System.Drawing. SizeF (8F, 16F);
this .AutoScaleMode = System.Windows.Forms. AutoScaleMode .Font;
this .ClientSize = new System.Drawing. Size (1043, 685);
this .Controls. Add(this .btnThemMoi);
this .Controls. Add(this .dtgDanhSachTienNghi);
this .Controls. Add(this .btnXuatExcel);
this .Controls. Add(this .pictureBox1);
this .Controls. Add(this .txtTimKiem);
this .Name = "FormDanhSachTienNghi" ;
this .StartPosition = System.Windows.Forms. FormStartPosition .CenterScreen;
this .Text = "Quản lý thông tin tiện nghi" ;
// this.Load += new System.EventHandler(this.FormDanhSachTienNghi_Load);
((System.ComponentModel. ISupportInitialize )( this .dtgDanhSachTienNghi)). EndInit ();
((System.ComponentModel. ISupportInitialize )( this .pictureBox1)). EndInit ();
this . ResumeLayout (false );
this . PerformLayout ();
}
#endregion
private System.Windows.Forms. Button btnThemMoi;
private System.Windows.Forms. DataGridView dtgDanhSachTienNghi;
private System.Windows.Forms. Button btnXuatExcel;
private System.Windows.Forms. PictureBox pictureBox1;
private System.Windows.Forms. TextBox txtTimKiem;
}
}
```

#### Bước 4: SV sử dụng mã nguồn tạm thời sau để xử lý chức năng trong file

FormDanhSachTienNghi.cs
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
namespace HotelManagement.TienNghi
{
public partial class FormDanhSachTienNghi : Form
{
public FormDanhSachTienNghi ()
{
InitializeComponent ();
}
private void FormDanhSachTienNghi_Load (object sender , EventArgs e)
{
LoadDanhSachTienNghi ();
}
private void KhoiTaoBangDuLieu ()
{
dtgDanhSachTienNghi.AllowUserToAddRows = false ;
dtgDanhSachTienNghi.AllowUserToDeleteRows = false ;
dtgDanhSachTienNghi.AllowUserToResizeRows = false ;
dtgDanhSachTienNghi.ReadOnly = true ;
dtgDanhSachTienNghi.MultiSelect = false ;
dtgDanhSachTienNghi.RowHeadersVisible = false ;
dtgDanhSachTienNghi.SelectionMode =
DataGridViewSelectionMode .FullRowSelect;
dtgDanhSachTienNghi.AutoSizeColumnsMode =
DataGridViewAutoSizeColumnsMode .Fill;
dtgDanhSachTienNghi.RowTemplate.Height = 40;
DataGridViewImageColumn iconCol = new DataGridViewImageColumn ();
iconCol .Name = "Icon" ;
iconCol .HeaderText = "" ;
iconCol .ImageLayout = DataGridViewImageCellLayout .Zoom;
iconCol .AutoSizeMode = DataGridViewAutoSizeColumnMode .None;
iconCol .Width = 50;
dtgDanhSachTienNghi.Columns. Add(iconCol );
dtgDanhSachTienNghi.Columns. Add("MaTN", "Mã tiện nghi" );
dtgDanhSachTienNghi.Columns. Add("TenTN" , "Tên tiện nghi" );
dtgDanhSachTienNghi.Columns[ "MaTN"].FillWeight = 30;
dtgDanhSachTienNghi.Columns[ "TenTN" ].FillWeight = 70;
DataGridViewImageColumn suaCol = new DataGridViewImageColumn ();
suaCol .Name = "Sua" ;
suaCol .HeaderText = "Sửa" ;
suaCol .ImageLayout = DataGridViewImageCellLayout .Zoom;
suaCol .AutoSizeMode = DataGridViewAutoSizeColumnMode .None;
suaCol .Width = 50;
dtgDanhSachTienNghi.Columns. Add(suaCol );
DataGridViewImageColumn xoaCol = new DataGridViewImageColumn ();
xoaCol .Name = "Xoa" ;
xoaCol .HeaderText = "Xóa" ;
xoaCol .ImageLayout = DataGridViewImageCellLayout .Zoom;
xoaCol .AutoSizeMode = DataGridViewAutoSizeColumnMode .None;
xoaCol .Width = 50;
dtgDanhSachTienNghi.Columns. Add(xoaCol );
}
private void LoadDanhSachTienNghi (string tuKhoa = "" )
{
try
{
if (dtgDanhSachTienNghi.Columns.Count == 0)
{
KhoiTaoBangDuLieu ();
}
using var db = new HotelManagementContext ();
var query = db.TienNghis
. AsNoTracking ()
. Where(t => t.DaXoa != true );
if (! string . IsNullOrWhiteSpace (tuKhoa ))
{
query = query . Where(t => t.TenTn. Contains (tuKhoa ));
}
var danhSach = query
. OrderBy (t => t.MaTn)
. Select (t => new { t.MaTn, t.TenTn })
. ToList ();
Image iconTienNghi = Properties. Resources .TienNghi;
Image iconSua = Properties. Resources .edit;
Image iconXoa = Properties. Resources .delete;
dtgDanhSachTienNghi.Rows. Clear ();
foreach (var tn in danhSach )
{
dtgDanhSachTienNghi.Rows. Add(
iconTienNghi ,
tn.MaTn,
tn.TenTn,
iconSua ,
iconXoa
);
}
dtgDanhSachTienNghi. ClearSelection ();
}
catch (Exception ex)
{
MessageBox . Show("Lỗi khi load tiện nghi: " + ex.Message, "Lỗi" ,
MessageBoxButtons .OK, MessageBoxIcon .Error);
}
}
private void txtTimKiem_TextChanged (object sender , EventArgs e)
{
LoadDanhSachTienNghi (txtTimKiem.Text. Trim ());
}
private void btnXuatExcel_Click (object sender , EventArgs e)
{
if (dtgDanhSachTienNghi.Rows.Count == 0)
{
MessageBox . Show("Không có dữ liệu để xuất!" , "Thông báo" ,
MessageBoxButtons .OK, MessageBoxIcon .Warning);
return ;
}
using SaveFileDialog saveDialog = new SaveFileDialog ();
saveDialog .Title = "Xuất danh sách tiện nghi" ;
saveDialog .Filter = "Excel Workbook (*.xlsx)|*.xlsx" ;
saveDialog .FileName = "DanhSachTienNghi_" +
DateTime .Now. ToString ("yyyyMMdd_HHmmss" ) + ".xlsx" ;
if (saveDialog . ShowDialog () != DialogResult .OK)
{
return ;
}
try
{
using (XLWorkbook workbook = new XLWorkbook ())
{
IXLWorksheet worksheet = workbook .Worksheets. Add("Danh sách tiện
nghi" );
worksheet . Cell (1, 1).Value = "Mã tiện nghi" ;
worksheet . Cell (1, 2).Value = "Tên tiện nghi" ;
worksheet . Range (1, 1, 1, 2).Style.Font.Bold = true ;
for (int i = 0; i < dtgDanhSachTienNghi.Rows.Count; i ++)
{
worksheet . Cell (i + 2, 1).Value =
dtgDanhSachTienNghi.Rows[ i ].Cells[ "MaTN"].Value?. ToString () ?? "" ;
worksheet . Cell (i + 2, 2).Value =
dtgDanhSachTienNghi.Rows[ i ].Cells[ "TenTN" ].Value?. ToString () ?? "" ;
}
worksheet . Columns (). AdjustToContents ();
workbook . SaveAs (saveDialog .FileName);
}
DialogResult moFile = MessageBox . Show(
"Xuất dữ liệu thành công! \nBạn có muốn mở file vừa xuất không?" ,
"Thông báo" ,
MessageBoxButtons .YesNo,
MessageBoxIcon .Information);
if (moFile == DialogResult .Yes)
{
System.Diagnostics. Process . Start (new
System.Diagnostics. ProcessStartInfo (saveDialog .FileName)
{
UseShellExecute = true
});
}
}
catch (Exception ex)
{
MessageBox . Show("Lỗi khi xuất file Excel: " + ex.Message, "Lỗi" ,
MessageBoxButtons .OK, MessageBoxIcon .Error);
}
}
private void btnThemMoi_Click (object sender , EventArgs e)
{
using (FormThemTienNghi f = new FormThemTienNghi ())
{
if (f. ShowDialog () == DialogResult .OK)
{
LoadDanhSachTienNghi (txtTimKiem.Text. Trim ());
}
}
}
private void dtgDanhSachTienNghi_CellClick (object sender ,
DataGridViewCellEventArgs e)
{
if (e.RowIndex < 0 || e.ColumnIndex < 0)
{
return ;
}
string tenCot = dtgDanhSachTienNghi.Columns[ e.ColumnIndex].Name;
if (tenCot != "Sua" && tenCot != "Xoa" )
{
return ;
}
string maTN =
dtgDanhSachTienNghi.Rows[ e.RowIndex].Cells[ "MaTN"].Value?. ToString ();
if (string .IsNullOrEmpty (maTN))
{
return ;
}
if (tenCot == "Sua" )
{
using (FormSuaTienNghi f = new FormSuaTienNghi(maTN))
{
if (f.ShowDialog() == DialogResult.OK)
{
LoadDanhSachTienNghi(txtTimKiem.Text.Trim());
}
}
return ;
}
if (MessageBox . Show("Bạn có chắc chắn muốn xóa tiện nghi này?" , "Xác nhận" ,
MessageBoxButtons .YesNo, MessageBoxIcon .Question) != DialogResult .Yes)
{
return ;
}
try
{
using var db = new HotelManagementContext ();
var tienNghi = db.TienNghis. FirstOrDefault (t => t.MaTn == maTN);
if (tienNghi == null )
{
MessageBox . Show("Không tìm thấy tiện nghi cần xóa!" , "Thông báo" ,
MessageBoxButtons .OK, MessageBoxIcon .Warning);
}
else
{
tienNghi .DaXoa = true ;
int kq = db. SaveChanges ();
if (kq > 0)
{
MessageBox . Show("Xóa thành công!" , "Thông báo" ,
MessageBoxButtons .OK, MessageBoxIcon .Information);
}
else
{
MessageBox . Show("Xóa thất bại!" , "Thông báo" ,
MessageBoxButtons .OK, MessageBoxIcon .Warning);
}
}
}
catch (Exception ex)
{
MessageBox . Show("Lỗi khi xóa tiện nghi: " + ex.Message, "Lỗi" ,
MessageBoxButtons .OK, MessageBoxIcon .Error);
}
LoadDanhSachTienNghi (txtTimKiem.Text. Trim ());
}
}
}
```

#### Bước 5: Chỉnh sửa lại hàm private void button12_Click(object sender,

EventArgs e)trong file FormMain.cs theo nội dung như sau:
```csharp
private void button12_Click (object sender , EventArgs e)
{
Form formCon = new TienNghi. FormDanhSachTienNghi ();
formCon .TopLevel = false ;
formCon .FormBorderStyle = FormBorderStyle .None;
formCon .Dock = DockStyle .Fill;
XoaNoiDungPanelMain ();
panelMain.Controls. Add(formCon );
formCon . Show();
}
```

#### Bước 5: Click chuột phải vào folder TienNghi → Add → Forms( Windows Forms) →

tạo một form để xây dựng giao diện và chức năng thêm mới thông tin 1 tiện nghi trong
khách sạn là FormThemTienNghi.cs

#### Bước 6: Thiết kế giao diện FormThemTienNghi.cs theo mẫu như sau:

**Mã nguồn tham khảo trong file FormThemTienNghi.Designer.cs tạm thời như sau:**

```csharp
namespace HotelManagement.TienNghi
{
partial class FormThemTienNghi
{
/// <summary>
/// Required designer variable.
/// </summary>
private System.ComponentModel. IContainer components = null ;
/// <summary>
/// Clean up any resources being used.
/// </summary>
/// <param name="disposing ">true if managed resources should be disposed;
otherwise, false. </param>
protected override void Dispose (bool disposing )
{
if (disposing && (components != null ))
{
components. Dispose ();
}
base . Dispose (disposing );
}
#region Windows Form Designer generated code
/// <summary>
/// Required method for Designer support - do not modify
/// the contents of this method with the code editor.
/// </summary>
private void InitializeComponent ()
{
LabelThemTienNghi = new Label ();
label1 = new Label ();
txtTenTN = new TextBox ();
btnThoat = new Button ();
btnThemMoi = new Button ();
txtMaTN = new TextBox ();
label2 = new Label ();
SuspendLayout ();
//
// LabelThemTienNghi
//
LabelThemTienNghi.AutoSize = true ;
LabelThemTienNghi.Font = new Font ("Segoe UI" , 20.25F, FontStyle .Bold,
GraphicsUnit .Point, 0);
LabelThemTienNghi.ForeColor = Color . FromArgb (192, 0, 0);
LabelThemTienNghi.Location = new Point (122, 22);
LabelThemTienNghi.Margin = new Padding (4, 0, 4, 0);
LabelThemTienNghi.Name = "LabelThemTienNghi" ;
LabelThemTienNghi.Size = new Size (261, 46);
LabelThemTienNghi.TabIndex = 1;
LabelThemTienNghi.Text = "Thêm tiện nghi" ;
//
// label1
//
label1.AutoSize = true ;
label1.Font = new Font ("Microsoft Sans Serif" , 13F, FontStyle .Regular,
GraphicsUnit .Point, 0);
label1.Location = new Point (56, 198);
label1.Name = "label1" ;
label1.Size = new Size (136, 26);
label1.TabIndex = 2;
label1.Text = "Tên tiện nghi" ;
//
// txtTenTN
//
txtTenTN.Font = new Font ("Microsoft Sans Serif" , 14F, FontStyle .Regular,
GraphicsUnit .Point, 0);
txtTenTN.Location = new Point (210, 191);
txtTenTN.Margin = new Padding (3, 4, 3, 4);
txtTenTN.Name = "txtTenTN" ;
txtTenTN.Size = new Size (298, 34);
txtTenTN.TabIndex = 3;
//
// btnThoat
//
btnThoat.BackColor = SystemColors .GradientActiveCaption;
btnThoat.Font = new Font ("Microsoft Sans Serif" , 12F, FontStyle .Regular,
GraphicsUnit .Point, 0);
btnThoat.Location = new Point (330, 261);
btnThoat.Margin = new Padding (3, 4, 3, 4);
btnThoat.Name = "btnThoat" ;
btnThoat.Size = new Size (137, 59);
btnThoat.TabIndex = 15;
btnThoat.Text = "Thoát" ;
btnThoat.UseVisualStyleBackColor = false ;
btnThoat.Click += btnThoat_Click ;
//
// btnThemMoi
//
btnThemMoi.BackColor = Color .Moccasin;
btnThemMoi.Font = new Font ("Microsoft Sans Serif" , 12F, FontStyle .Regular,
GraphicsUnit .Point, 0);
btnThemMoi.Location = new Point (130, 261);
btnThemMoi.Margin = new Padding (3, 4, 3, 4);
btnThemMoi.Name = "btnThemMoi" ;
btnThemMoi.Size = new Size (137, 59);
btnThemMoi.TabIndex = 14;
btnThemMoi.Text = "Thêm mới" ;
btnThemMoi.UseVisualStyleBackColor = false ;
btnThemMoi.Click += btnThemMoi_Click ;
//
// txtMaTN
//
txtMaTN.Font = new Font ("Microsoft Sans Serif" , 14F, FontStyle .Regular,
GraphicsUnit .Point, 0);
txtMaTN.Location = new Point (210, 100);
txtMaTN.Margin = new Padding (3, 4, 3, 4);
txtMaTN.Name = "txtMaTN" ;
txtMaTN.Size = new Size (298, 34);
txtMaTN.TabIndex = 17;
//
// label2
//
label2.AutoSize = true ;
label2.Font = new Font ("Microsoft Sans Serif" , 13F, FontStyle .Regular,
GraphicsUnit .Point, 0);
label2.Location = new Point (56, 110);
label2.Name = "label2" ;
label2.Size = new Size (130, 26);
label2.TabIndex = 16;
label2.Text = "Mả tiện nghi" ;
//
// FormThemTienNghi
//
AutoScaleDimensions = new SizeF (8F, 20F);
AutoScaleMode = AutoScaleMode .Font;
ClientSize = new Size (520, 380);
Controls. Add(txtMaTN);
Controls. Add(label2);
Controls. Add(btnThoat);
Controls. Add(btnThemMoi);
Controls. Add(txtTenTN);
Controls. Add(label1);
Controls. Add(LabelThemTienNghi);
Margin = new Padding (3, 4, 3, 4);
Name = "FormThemTienNghi" ;
ResumeLayout (false );
PerformLayout ();
}
#endregion
private System.Windows.Forms. Label LabelThemTienNghi;
private System.Windows.Forms. Label label1;
private System.Windows.Forms. TextBox txtTenTN;
private System.Windows.Forms. Button btnThoat;
private System.Windows.Forms. Button btnThemMoi;
private System.Windows.Forms. TextBox txtMaTN;
private System.Windows.Forms. Label label2;
}
}
}
```

#### Bước 10: SV sử dụng mã nguồn tạm thời sau để xử lý chức năng trong file

FormThemTienNghi.cs
```csharp
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HotelManagement.Models;
namespace HotelManagement.TienNghi
{
public partial class FormThemTienNghi : Form
{
public FormThemTienNghi ()
{
InitializeComponent ();
}
private void btnThemMoi_Click (object sender , EventArgs e)
{
string maTN = txtMaTN.Text. Trim (). ToUpper ();
string tenTN = txtTenTN.Text. Trim ();
if (string .IsNullOrEmpty (maTN))
{
MessageBox . Show("Vui lòng nhập mã tiện nghi!" , "Thông báo" ,
MessageBoxButtons .OK, MessageBoxIcon .Warning);
txtMaTN. Focus ();
return ;
}
if (maTN.Length > 5)
{
MessageBox . Show("Mã tiện nghi tối đa 5 ký tự!" , "Thông báo" ,
MessageBoxButtons .OK, MessageBoxIcon .Warning);
txtMaTN. Focus ();
return ;
}
if (string .IsNullOrEmpty (tenTN ))
{
MessageBox . Show("Vui lòng nhập tên tiện nghi!" , "Thông báo" ,
MessageBoxButtons .OK, MessageBoxIcon .Warning);
txtTenTN. Focus ();
return ;
}
if (tenTN .Length > 50)
{
MessageBox . Show("Tên tiện nghi tối đa 50 ký tự!" , "Thông báo" ,
MessageBoxButtons .OK, MessageBoxIcon .Warning);
txtTenTN. Focus ();
return ;
}
try
{
using var db = new HotelManagementContext ();
if (db.TienNghis. Any(t => t.MaTn == maTN))
{
MessageBox . Show("Mã tiện nghi đã tồn tại!" , "Thông báo" ,
MessageBoxButtons .OK, MessageBoxIcon .Warning);
txtMaTN. Focus ();
return ;
}
if (db.TienNghis. Any(t => t.DaXoa != true && t.TenTn == tenTN ))
{
MessageBox . Show("Tên tiện nghi đã tồn tại!" , "Thông báo" ,
MessageBoxButtons .OK, MessageBoxIcon .Warning);
txtTenTN. Focus ();
return ;
}
var tienNghi = new Models. TienNghi
{
MaTn = maTN,
TenTn = tenTN ,
DaXoa = false
};
db.TienNghis. Add(tienNghi );
int kq = db. SaveChanges ();
if (kq > 0)
{
MessageBox . Show("Thêm tiện nghi thành công!" , "Thông báo" ,
MessageBoxButtons .OK, MessageBoxIcon .Information);
DialogResult = DialogResult .OK;
Close ();
}
else
{
MessageBox . Show("Thêm tiện nghi thất bại!" , "Thông báo" ,
MessageBoxButtons .OK, MessageBoxIcon .Warning);
}
}
catch (Exception ex)
{
MessageBox . Show("Lỗi khi thêm tiện nghi: " + ex.Message, "Lỗi" ,
MessageBoxButtons .OK, MessageBoxIcon .Error);
}
}
private void btnThoat_Click (object sender , EventArgs e)
{
DialogResult = DialogResult .Cancel;
Close ();
}
}
}
```

#### Bước 11: Click chuột phải vào folder TienNghi → Add → Forms( Windows Forms)

→ tạo một form để xây dựng giao diện và chức năng cập nhật thông tin 1 tiện nghi
đang có là FormSuaTienNghi.cs

#### Bước 12: Thiết kế giao diện FormSuaTienNghi.cs theo mẫu như sau:

**Mã nguồn tham khảo trong file FormSuaDichVu.Designer.cs tạm thời như sau:**

```csharp
namespace HotelManagement.TienNghi
{
partial class FormSuaTienNghi
{
/// <summary>
/// Required designer variable.
/// </summary>
private System.ComponentModel. IContainer components = null ;
/// <summary>
/// Clean up any resources being used.
/// </summary>
/// <param name="disposing ">true if managed resources should be disposed;
otherwise, false. </param>
protected override void Dispose (bool disposing )
{
if (disposing && (components != null ))
{
components. Dispose ();
}
base . Dispose (disposing );
}
#region Windows Form Designer generated code
/// <summary>
/// Required method for Designer support - do not modify
/// the contents of this method with the code editor.
/// </summary>
private void InitializeComponent ()
{
btnThoat = new Button ();
btnCapNhat = new Button ();
txtTenTN = new TextBox ();
label1 = new Label ();
LabelThemTienNghi = new Label ();
SuspendLayout ();
//
// btnThoat
//
btnThoat.BackColor = SystemColors.GradientActiveCaption;
btnThoat.Font = new Font( "Microsoft Sans Serif" , 12F, FontStyle.Regular,
GraphicsUnit.Point, 0);
btnThoat.Location = new Point(333, 234);
btnThoat.Margin = new Padding(3, 4, 3, 4);
btnThoat.Name = "btnThoat" ;
btnThoat.Size = new Size(137, 59);
btnThoat.TabIndex = 22;
btnThoat.Text = "Thoát" ;
btnThoat.UseVisualStyleBackColor = false ;
btnThoat.Click += btnThoat_Click;
//
// btnCapNhat
//
btnCapNhat.BackColor = Color.Moccasin;
btnCapNhat.Font = new Font( "Microsoft Sans Serif" , 12F, FontStyle.Regular,
GraphicsUnit.Point, 0);
btnCapNhat.Location = new Point(133, 234);
btnCapNhat.Margin = new Padding(3, 4, 3, 4);
btnCapNhat.Name = "btnCapNhat" ;
btnCapNhat.Size = new Size(137, 59);
btnCapNhat.TabIndex = 21;
btnCapNhat.Text = "Cập nhật" ;
btnCapNhat.UseVisualStyleBackColor = false ;
btnCapNhat.Click += btnCapNhat_Click;
//
// txtTenTN
//
txtTenTN.Font = new Font( "Microsoft Sans Serif" , 14F, FontStyle.Regular,
GraphicsUnit.Point, 0);
txtTenTN.Location = new Point(213, 164);
txtTenTN.Margin = new Padding(3, 4, 3, 4);
txtTenTN.Name = "txtTenTN" ;
txtTenTN.Size = new Size(298, 34);
txtTenTN.TabIndex = 20;
//
// label1
//
label1.AutoSize = true ;
label1.Font = new Font( "Microsoft Sans Serif" , 13F, FontStyle.Regular,
GraphicsUnit.Point, 0);
label1.Location = new Point(59, 170);
label1.Name = "label1" ;
label1.Size = new Size(136, 26);
label1.TabIndex = 19;
label1.Text = "Tên tiện nghi" ;
//
// LabelThemTienNghi
//
LabelThemTienNghi.AutoSize = true ;
LabelThemTienNghi.Font = new Font( "Segoe UI" , 20.25F, FontStyle.Bold,
GraphicsUnit.Point, 0);
LabelThemTienNghi.ForeColor = Color . FromArgb (192, 0, 0);
LabelThemTienNghi.Location = new Point (136, 51);
LabelThemTienNghi.Margin = new Padding (4, 0, 4, 0);
LabelThemTienNghi.Name = "LabelThemTienNghi" ;
LabelThemTienNghi.Size = new Size (313, 46);
LabelThemTienNghi.TabIndex = 18;
LabelThemTienNghi.Text = "Cập nhật tiện nghi" ;
//
// FormSuaTienNghi
//
AutoScaleDimensions = new SizeF (8F, 20F);
AutoScaleMode = AutoScaleMode .Font;
ClientSize = new Size (549, 400);
Controls. Add(btnThoat);
Controls. Add(btnCapNhat);
Controls. Add(txtTenTN);
Controls. Add(label1);
Controls. Add(LabelThemTienNghi);
Margin = new Padding (3, 4, 3, 4);
Name = "FormSuaTienNghi" ;
Text = "FormSuaTienNghi" ;
Load += FormSuaTienNghi_Load ;
ResumeLayout (false );
PerformLayout ();
}
#endregion
private System.Windows.Forms. Button btnThoat;
private System.Windows.Forms. Button btnCapNhat;
private System.Windows.Forms. TextBox txtTenTN;
private System.Windows.Forms. Label label1;
private System.Windows.Forms. Label LabelThemTienNghi;
}
}
```

#### Bước 13: SV sử dụng mã nguồn tạm thời sau để xử lý chức năng trong file

FormSuaTienNghi.cs
```csharp
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HotelManagement.Models;
namespace HotelManagement.TienNghi
{
public partial class FormSuaTienNghi : Form
{
private string maTN = string .Empty;
public FormSuaTienNghi ()
{
InitializeComponent ();
}
public FormSuaTienNghi (string maTN) : this ()
{
this .maTN = maTN;
}
private void FormSuaTienNghi_Load (object sender , EventArgs e)
{
if (string .IsNullOrEmpty (maTN))
{
MessageBox . Show("Không xác định được tiện nghi cần cập nhật!" , "Thông
báo" , MessageBoxButtons .OK, MessageBoxIcon .Warning);
DialogResult = DialogResult .Cancel;
Close ();
return ;
}
try
{
using var db = new HotelManagementContext ();
var tienNghi = db.TienNghis
. Where(t => t.MaTn == maTN && t.DaXoa != true )
. Select (t => new { t.TenTn })
. FirstOrDefault ();
if (tienNghi == null )
{
MessageBox . Show("Không tìm thấy tiện nghi cần cập nhật!" , "Thông
báo" , MessageBoxButtons .OK, MessageBoxIcon .Warning);
DialogResult = DialogResult .Cancel;
Close ();
return ;
}
txtTenTN.Text = tienNghi .TenTn;
txtTenTN. Focus ();
txtTenTN. SelectAll ();
}
catch (Exception ex)
{
MessageBox . Show("Lỗi khi load tiện nghi: " + ex.Message, "Lỗi" ,
MessageBoxButtons .OK, MessageBoxIcon .Error);
DialogResult = DialogResult .Cancel;
Close ();
}
}
private void btnCapNhat_Click (object sender , EventArgs e)
{
string tenTN = txtTenTN.Text. Trim ();
if (string .IsNullOrEmpty (tenTN ))
{
MessageBox . Show("Vui lòng nhập tên tiện nghi!" , "Thông báo" ,
MessageBoxButtons .OK, MessageBoxIcon .Warning);
txtTenTN. Focus ();
return ;
}
if (tenTN .Length > 50)
{
MessageBox . Show("Tên tiện nghi tối đa 50 ký tự!" , "Thông báo" ,
MessageBoxButtons .OK, MessageBoxIcon .Warning);
txtTenTN. Focus ();
return ;
}
try
{
using var db = new HotelManagementContext ();
var tienNghi = db.TienNghis. FirstOrDefault (t => t.MaTn == maTN &&
t.DaXoa != true );
if (tienNghi == null )
{
MessageBox . Show("Không tìm thấy tiện nghi cần cập nhật!" , "Thông
báo" , MessageBoxButtons .OK, MessageBoxIcon .Warning);
DialogResult = DialogResult .Cancel;
Close ();
return ;
}
if (db.TienNghis. Any(t => t.MaTn != maTN && t.DaXoa != true && t.TenTn
== tenTN ))
{
MessageBox . Show("Tên tiện nghi đã tồn tại!" , "Thông báo" ,
MessageBoxButtons .OK, MessageBoxIcon .Warning);
txtTenTN. Focus ();
return ;
}
tienNghi .TenTn = tenTN ;
int kq = db. SaveChanges ();
if (kq > 0)
{
MessageBox . Show("Cập nhật tiện nghi thành công!" , "Thông báo" ,
MessageBoxButtons .OK, MessageBoxIcon .Information);
DialogResult = DialogResult .OK;
Close ();
}
else
{
MessageBox . Show("Không có thay đổi nào để cập nhật!" , "Thông báo" ,
MessageBoxButtons .OK, MessageBoxIcon .Information);
}
}
catch (Exception ex)
{
MessageBox . Show("Lỗi khi cập nhật tiện nghi: " + ex.Message, "Lỗi" ,
MessageBoxButtons .OK, MessageBoxIcon .Error);
}
}
private void btnThoat_Click (object sender , EventArgs e)
{
DialogResult = DialogResult .Cancel;
Close ();
}
}
}
```

### 3. Xây dựng giao diện và chức năng quản lý thông tin khách hàng tại khách sạn

#### Bước 1: Click chuột phải vào thư mục project → Add → New Folder→ Đặt tên folder

là “KhachHang”

#### Bước 2: Click chuột phải vào folder KhachHang → Add → Forms( Windows Forms)

→ tạo một form thể hiện danh sách các khách hàng đã và đang thuê phòng trong khách
sạn là FormDanhSachKhachHang.cs

#### Bước 3: Thiết kế giao diện FormDanhSachKhachHang.cs theo mẫu như sau:

Mã nguồn tham khảo trong file FormDanhSachKhachHang.Designer.cs tạm thời như
sau:
```csharp
namespace HotelManagement.KhachHang
{
partial class FormDanhSachKhachHang
{
/// <summary>
/// Required designer variable.
/// </summary>
private System.ComponentModel. IContainer components = null ;
/// <summary>
/// Clean up any resources being used.
/// </summary>
/// <param name="disposing ">true if managed resources should be disposed;
otherwise, false. </param>
protected override void Dispose (bool disposing )
{
if (disposing && (components != null ))
{
components. Dispose ();
}
base . Dispose (disposing );
}
#region Windows Form Designer generated code
/// <summary>
/// Required method for Designer support - do not modify
/// the contents of this method with the code editor.
/// </summary>
private void InitializeComponent ()
{
this .btnThemMoi = new System.Windows.Forms. Button ();
this .dtgDanhSachKhachHang = new System.Windows.Forms. DataGridView ();
this .btnXuatExcel = new System.Windows.Forms. Button ();
this .txtTimKiem = new System.Windows.Forms. TextBox ();
this .pictureBox1 = new System.Windows.Forms. PictureBox ();
((System.ComponentModel. ISupportInitialize )( this .dtgDanhSachKhachHang)). BeginInit ();
((System.ComponentModel. ISupportInitialize )( this .pictureBox1)). BeginInit ();
this . SuspendLayout ();
//
// btnThemMoi
//
this .btnThemMoi.BackColor = System.Drawing. Color .LightPink;
this .btnThemMoi.Font = new System.Drawing. Font ("Microsoft Sans Serif" , 12F,
System.Drawing. FontStyle .Bold, System.Drawing. GraphicsUnit .Point, (( byte )(0)));
this .btnThemMoi.Location = new System.Drawing. Point (687, 22);
this .btnThemMoi.Name = "btnThemMoi" ;
this .btnThemMoi.Size = new System.Drawing. Size (167, 37);
this .btnThemMoi.TabIndex = 20;
this .btnThemMoi.Text = "Thêm mới" ;
this .btnThemMoi.UseVisualStyleBackColor = false ;
//this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
//
// dtgDanhSachKhachHang
//
this .dtgDanhSachKhachHang.ColumnHeadersHeightSizeMode =
System.Windows.Forms. DataGridViewColumnHeadersHeightSizeMode .AutoSize;
this .dtgDanhSachKhachHang.Location = new System.Drawing. Point (26, 72);
this .dtgDanhSachKhachHang.Name = "dtgDanhSachKhachHang" ;
this .dtgDanhSachKhachHang.RowHeadersWidth = 51;
this .dtgDanhSachKhachHang.RowTemplate.Height = 24;
this .dtgDanhSachKhachHang.Size = new System.Drawing. Size (945, 543);
this .dtgDanhSachKhachHang.TabIndex = 19;
//this.dtgDanhSachKhachHang.CellClick += new
System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDanhSachKhachHang_CellClick);
//
// btnXuatExcel
//
this .btnXuatExcel.BackColor = System.Drawing. Color .DarkTurquoise;
this .btnXuatExcel.Font = new System.Drawing. Font ("Microsoft Sans Serif" ,
12F, System.Drawing. FontStyle .Bold, System.Drawing. GraphicsUnit .Point, (( byte )(0)));
this .btnXuatExcel.Location = new System.Drawing. Point (489, 22);
this .btnXuatExcel.Name = "btnXuatExcel" ;
this .btnXuatExcel.Size = new System.Drawing. Size (167, 37);
this .btnXuatExcel.TabIndex = 18;
this .btnXuatExcel.Text = "Xuất file Excel" ;
this .btnXuatExcel.UseVisualStyleBackColor = false ;
// this.btnXuatExcel.Click += new
System.EventHandler(this.btnXuatExcel_Click);
//
// txtTimKiem
//
this .txtTimKiem.Font = new System.Drawing. Font ("Microsoft Sans Serif" , 13F,
System.Drawing. FontStyle .Regular, System.Drawing. GraphicsUnit .Point, (( byte )(0)));
this .txtTimKiem.Location = new System.Drawing. Point (87, 27);
this .txtTimKiem.Name = "txtTimKiem" ;
this .txtTimKiem.Size = new System.Drawing. Size (187, 32);
this .txtTimKiem.TabIndex = 16;
//this.txtTimKiem.TextChanged += new
System.EventHandler(this.txtTimKiem_TextChanged);
//
// pictureBox1
//
this .pictureBox1.Image =
global ::HotelManagement.Properties. Resources .search;
this .pictureBox1.Location = new System.Drawing. Point (42, 22);
this .pictureBox1.Name = "pictureBox1" ;
this .pictureBox1.Size = new System.Drawing. Size (39, 37);
this .pictureBox1.TabIndex = 17;
this .pictureBox1.TabStop = false ;
//
// FormDanhSachKhachHang
//
this .AutoScaleDimensions = new System.Drawing. SizeF (8F, 16F);
this .AutoScaleMode = System.Windows.Forms. AutoScaleMode .Font;
this .ClientSize = new System.Drawing. Size (983, 620);
this .Controls. Add(this .btnThemMoi);
this .Controls. Add(this .dtgDanhSachKhachHang);
this .Controls. Add(this .btnXuatExcel);
this .Controls. Add(this .pictureBox1);
this .Controls. Add(this .txtTimKiem);
this .Name = "FormDanhSachKhachHang" ;
this .StartPosition = System.Windows.Forms. FormStartPosition .CenterScreen;
this .Text = "FormDanhSachKhachHang" ;
// this.Load += new System.EventHandler(this.FormDanhSachKhachHang_Load);
((System.ComponentModel. ISupportInitialize )( this .dtgDanhSachKhachHang)). EndInit ();
((System.ComponentModel. ISupportInitialize )( this .pictureBox1)). EndInit ();
this . ResumeLayout (false );
this . PerformLayout ();
}
#endregion
private System.Windows.Forms. Button btnThemMoi;
private System.Windows.Forms. DataGridView dtgDanhSachKhachHang;
private System.Windows.Forms. Button btnXuatExcel;
private System.Windows.Forms. PictureBox pictureBox1;
private System.Windows.Forms. TextBox txtTimKiem;
}
}
```

#### Bước 4: SV sử dụng mã nguồn tạm thời sau để xử lý chức năng trong file

FormDanhSachKhachHang.cs
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
namespace HotelManagement.KhachHang
{
public partial class FormDanhSachKhachHang : Form
{
public FormDanhSachKhachHang()
{
InitializeComponent();
}
private void FormDanhSachKhachHang_Load(object sender, EventArgs e)
{
LoadDanhSachKhachHang();
}
private void KhoiTaoBangDuLieu()
{
dtgDanhSachKhachHang.AllowUserToAddRows = false;
dtgDanhSachKhachHang.AllowUserToDeleteRows = false;
dtgDanhSachKhachHang.AllowUserToResizeRows = false;
dtgDanhSachKhachHang.ReadOnly = true;
dtgDanhSachKhachHang.MultiSelect = false;
dtgDanhSachKhachHang.RowHeadersVisible = false;
dtgDanhSachKhachHang.SelectionMode =
DataGridViewSelectionMode.FullRowSelect;
dtgDanhSachKhachHang.AutoSizeColumnsMode =
DataGridViewAutoSizeColumnsMode.Fill;
dtgDanhSachKhachHang.RowTemplate.Height = 40;
DataGridViewImageColumn iconCol = new DataGridViewImageColumn();
iconCol.Name = "Icon";
iconCol.HeaderText = "";
iconCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
iconCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
iconCol.Width = 40;
dtgDanhSachKhachHang.Columns.Add(iconCol);
dtgDanhSachKhachHang.Columns.Add("MaKH", "Mã KH");
dtgDanhSachKhachHang.Columns.Add("TenKH", "Tên khách hàng");
dtgDanhSachKhachHang.Columns.Add("SDT", "SĐT");
dtgDanhSachKhachHang.Columns.Add("CCCD", "CCCD/Passport");
dtgDanhSachKhachHang.Columns.Add("QuocTich", "Quốc tịch");
dtgDanhSachKhachHang.Columns.Add("GioiTinh", "Giới tính");
dtgDanhSachKhachHang.Columns["MaKH"].FillWeight = 10;
dtgDanhSachKhachHang.Columns["TenKH"].FillWeight = 25;
dtgDanhSachKhachHang.Columns["SDT"].FillWeight = 15;
dtgDanhSachKhachHang.Columns["CCCD"].FillWeight = 20;
dtgDanhSachKhachHang.Columns["QuocTich"].FillWeight = 15;
dtgDanhSachKhachHang.Columns["GioiTinh"].FillWeight = 10;
DataGridViewImageColumn suaCol = new DataGridViewImageColumn();
suaCol.Name = "Sua";
suaCol.HeaderText = "Sửa";
suaCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
suaCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
suaCol.Width = 50;
dtgDanhSachKhachHang.Columns.Add(suaCol);
DataGridViewImageColumn xoaCol = new DataGridViewImageColumn();
xoaCol.Name = "Xoa";
xoaCol.HeaderText = "Xóa";
xoaCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
xoaCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
xoaCol.Width = 50;
dtgDanhSachKhachHang.Columns.Add(xoaCol);
}
private void LoadDanhSachKhachHang(string tuKhoa = "")
{
try
{
if (dtgDanhSachKhachHang.Columns.Count == 0)
{
KhoiTaoBangDuLieu();
}
using var db = new HotelManagementContext();
var query = db.KhachHangs
.AsNoTracking()
.Where(k => k.DaXoa != true);
if (!string.IsNullOrWhiteSpace(tuKhoa))
{
query = query.Where(k =>
k.MaKh.Contains(tuKhoa) ||
k.TenKh.Contains(tuKhoa) ||
k.Sdt.Contains(tuKhoa) ||
k.CccdPassport.Contains(tuKhoa));
}
var danhSach = query
.OrderBy(k => k.MaKh)
.Select(k => new
{
k.MaKh,
k.TenKh,
k.Sdt,
k.CccdPassport,
k.QuocTich,
k.GioiTinh
})
.ToList();
Image iconKhachHang = Properties.Resources.KhachHang;
Image iconSua = Properties.Resources.edit;
Image iconXoa = Properties.Resources.delete;
dtgDanhSachKhachHang.Rows.Clear();
foreach (var kh in danhSach)
{
dtgDanhSachKhachHang.Rows.Add(
iconKhachHang,
kh.MaKh,
kh.TenKh,
kh.Sdt,
kh.CccdPassport,
kh.QuocTich,
kh.GioiTinh,
iconSua,
iconXoa
);
}
dtgDanhSachKhachHang.ClearSelection();
}
catch (Exception ex)
{
MessageBox.Show("Lỗi khi load khách hàng: " + ex.Message, "Lỗi",
MessageBoxButtons.OK, MessageBoxIcon.Error);
}
}
private void txtTimKiem_TextChanged(object sender, EventArgs e)
{
LoadDanhSachKhachHang(txtTimKiem.Text.Trim());
}
private void btnXuatExcel_Click(object sender, EventArgs e)
{
if (dtgDanhSachKhachHang.Rows.Count == 0)
{
MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
return;
}
using SaveFileDialog saveDialog = new SaveFileDialog();
saveDialog.Title = "Xuất danh sách khách hàng";
saveDialog.Filter = "Excel Workbook (*.xlsx)|*.xlsx";
saveDialog.FileName = "DanhSachKhachHang_" +
DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".xlsx";
if (saveDialog.ShowDialog() != DialogResult.OK)
{
return;
}
try
{
string[] tenCot = { "MaKH", "TenKH", "SDT", "CCCD", "QuocTich",
"GioiTinh" };
using (XLWorkbook workbook = new XLWorkbook())
{
IXLWorksheet worksheet = workbook.Worksheets.Add("Danh sách khách
hàng");
for (int j = 0; j < tenCot.Length; j++)
{
worksheet.Cell(1, j + 1).Value =
dtgDanhSachKhachHang.Columns[tenCot[j]].HeaderText;
}
worksheet.Range(1, 1, 1, tenCot.Length).Style.Font.Bold = true;
for (int i = 0; i < dtgDanhSachKhachHang.Rows.Count; i++)
{
for (int j = 0; j < tenCot.Length; j++)
{
worksheet.Cell(i + 2, j + 1).Value =
dtgDanhSachKhachHang.Rows[i].Cells[tenCot[j]].Value?.ToString() ?? "";
}
}
worksheet.Columns().AdjustToContents();
workbook.SaveAs(saveDialog.FileName);
}
DialogResult moFile = MessageBox.Show(
"Xuất dữ liệu thành công! \nBạn có muốn mở file vừa xuất không?",
"Thông báo",
MessageBoxButtons.YesNo,
MessageBoxIcon.Information);
if (moFile == DialogResult.Yes)
{
System.Diagnostics.Process.Start(new
System.Diagnostics.ProcessStartInfo(saveDialog.FileName)
{
UseShellExecute = true
});
}
}
catch (Exception ex)
{
MessageBox.Show("Lỗi khi xuất file Excel: " + ex.Message, "Lỗi",
MessageBoxButtons.OK, MessageBoxIcon.Error);
}
}
private void btnThemMoi_Click(object sender, EventArgs e)
{
using (FormThemKhachHang f = new FormThemKhachHang())
{
if (f.ShowDialog() == DialogResult.OK)
{
LoadDanhSachKhachHang(txtTimKiem.Text.Trim());
}
}
}
private void dtgDanhSachKhachHang_CellClick(object sender,
DataGridViewCellEventArgs e)
{
if (e.RowIndex < 0 || e.ColumnIndex < 0)
{
return;
}
string tenCot = dtgDanhSachKhachHang.Columns[e.ColumnIndex].Name;
if (tenCot != "Sua" && tenCot != "Xoa")
{
return;
}
string maKH =
dtgDanhSachKhachHang.Rows[e.RowIndex].Cells["MaKH"].Value?.ToString();
if (string.IsNullOrEmpty(maKH))
{
return;
}
if (tenCot == "Sua")
{
using (FormSuaKhachHang f = new FormSuaKhachHang(maKH))
{
if (f.ShowDialog() == DialogResult.OK)
{
LoadDanhSachKhachHang(txtTimKiem.Text.Trim());
}
}
return;
}
if (MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này?", "Xác
nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
{
return;
}
try
{
using var db = new HotelManagementContext();
var khachHang = db.KhachHangs.FirstOrDefault(k => k.MaKh == maKH);
if (khachHang == null)
{
MessageBox.Show("Không tìm thấy khách hàng cần xóa!", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
}
else
{
khachHang.DaXoa = true;
int kq = db.SaveChanges();
if (kq > 0)
{
MessageBox.Show("Xóa thành công!", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Information);
}
else
{
MessageBox.Show("Xóa thất bại!", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
}
}
}
catch (Exception ex)
{
MessageBox.Show("Lỗi khi xóa khách hàng: " + ex.Message, "Lỗi",
MessageBoxButtons.OK, MessageBoxIcon.Error);
}
LoadDanhSachKhachHang(txtTimKiem.Text.Trim());
}
}
}
```

#### Bước 5: Chỉnh sửa lại hàm private void button6_Click(object sender,

EventArgs e)trong file FormMain.cs theo nội dung như sau:
```csharp
private void button6_Click (object sender , EventArgs e)
{
Form formCon = new KhachHang. FormDanhSachKhachHang ();
formCon .TopLevel = false ;
formCon .FormBorderStyle = FormBorderStyle .None;
formCon .Dock = DockStyle .Fill;
XoaNoiDungPanelMain ();
panelMain.Controls. Add(formCon );
formCon . Show();
}
```

#### Bước 6: Click chuột phải vào folder KhachHang → Add → Forms( Windows Forms)

→ tạo một form để xây dựng giao diện và chức năng thêm mới thông tin 1 khách hàng
trong khách sạn là FormThemKhachHang.cs

#### Bước 7: Thiết kế giao diện FormThemKhachHang.cs theo mẫu như sau:

**Mã nguồn tham khảo trong file FormThemKhachHang.Designer.cs tạm thời như sau:**

```csharp
namespace HotelManagement.KhachHang
{
partial class FormThemKhachHang
{
/// <summary>
/// Required designer variable.
/// </summary>
private System.ComponentModel.IContainer components = null;
/// <summary>
/// Clean up any resources being used.
/// </summary>
/// <param name="disposing">true if managed resources should be disposed;
otherwise, false.</param>
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
label6 = new Label();
btnThoat = new Button();
btnThemMoi = new Button();
panel1 = new Panel();
txtMaKH = new TextBox();
label4 = new Label();
cbGioiTinh = new ComboBox();
label7 = new Label();
txtSoDienThoai = new TextBox();
label3 = new Label();
txtQuocTich = new TextBox();
label2 = new Label();
txtCCCD = new TextBox();
label1 = new Label();
txtHoVaTen = new TextBox();
label5 = new Label();
panel1.SuspendLayout();
SuspendLayout();
//
// label6
//
label6.AutoSize = true;
label6.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold,
GraphicsUnit.Point, 0);
label6.ForeColor = Color.FromArgb(192, 0, 0);
label6.Location = new Point(152, 36);
label6.Name = "label6";
label6.Size = new Size(345, 29);
label6.TabIndex = 21;
label6.Text = "Thêm thông tin khách hàng";
//
// btnThoat
//
btnThoat.BackColor = SystemColors.GradientActiveCaption;
btnThoat.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular,
GraphicsUnit.Point, 0);
btnThoat.Location = new Point(317, 536);
btnThoat.Margin = new Padding(3, 4, 3, 4);
btnThoat.Name = "btnThoat";
btnThoat.Size = new Size(137, 59);
btnThoat.TabIndex = 20;
btnThoat.Text = "Thoát";
btnThoat.UseVisualStyleBackColor = false;
//
// btnThemMoi
//
btnThemMoi.BackColor = Color.Moccasin;
btnThemMoi.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular,
GraphicsUnit.Point, 0);
btnThemMoi.Location = new Point(117, 536);
btnThemMoi.Margin = new Padding(3, 4, 3, 4);
btnThemMoi.Name = "btnThemMoi";
btnThemMoi.Size = new Size(137, 59);
btnThemMoi.TabIndex = 19;
btnThemMoi.Text = "Thêm mới";
btnThemMoi.UseVisualStyleBackColor = false;
btnThemMoi.Click += btnThemMoi_Click;
//
// panel1
//
panel1.Controls.Add(txtMaKH);
panel1.Controls.Add(label4);
panel1.Controls.Add(cbGioiTinh);
panel1.Controls.Add(label7);
panel1.Controls.Add(txtSoDienThoai);
panel1.Controls.Add(label3);
panel1.Controls.Add(txtQuocTich);
panel1.Controls.Add(label2);
panel1.Controls.Add(txtCCCD);
panel1.Controls.Add(label1);
panel1.Controls.Add(txtHoVaTen);
panel1.Controls.Add(label5);
panel1.Location = new Point(12, 102);
panel1.Margin = new Padding(3, 4, 3, 4);
panel1.Name = "panel1";
panel1.Size = new Size(548, 426);
panel1.TabIndex = 18;
//
// txtMaKH
//
txtMaKH.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular,
GraphicsUnit.Point, 0);
txtMaKH.Location = new Point(243, 30);
txtMaKH.Margin = new Padding(3, 4, 3, 4);
txtMaKH.Name = "txtMaKH";
txtMaKH.ReadOnly = true;
txtMaKH.Size = new Size(290, 30);
txtMaKH.TabIndex = 27;
//
// label4
//
label4.AutoSize = true;
label4.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular,
GraphicsUnit.Point, 0);
label4.Location = new Point(104, 32);
label4.Name = "label4";
label4.Size = new Size(79, 26);
label4.TabIndex = 26;
label4.Text = "Mã KH";
//
// cbGioiTinh
//
cbGioiTinh.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular,
GraphicsUnit.Point, 0);
cbGioiTinh.FormattingEnabled = true;
cbGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
cbGioiTinh.Location = new Point(243, 348);
cbGioiTinh.Margin = new Padding(3, 4, 3, 4);
cbGioiTinh.Name = "cbGioiTinh";
cbGioiTinh.Size = new Size(290, 30);
cbGioiTinh.TabIndex = 25;
//
// label7
//
label7.AutoSize = true;
label7.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular,
GraphicsUnit.Point, 0);
label7.Location = new Point(83, 226);
label7.Name = "label7";
label7.Size = new Size(139, 26);
label7.TabIndex = 24;
label7.Text = "Số điện thoại";
//
// txtSoDienThoai
//
txtSoDienThoai.Font = new Font("Microsoft Sans Serif", 12F,
FontStyle.Regular, GraphicsUnit.Point, 0);
txtSoDienThoai.Location = new Point(243, 221);
txtSoDienThoai.Margin = new Padding(3, 4, 3, 4);
txtSoDienThoai.Name = "txtSoDienThoai";
txtSoDienThoai.Size = new Size(290, 30);
txtSoDienThoai.TabIndex = 23;
//
// label3
//
label3.AutoSize = true;
label3.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular,
GraphicsUnit.Point, 0);
label3.Location = new Point(130, 352);
label3.Name = "label3";
label3.Size = new Size(92, 26);
label3.TabIndex = 22;
label3.Text = "Giới tính";
//
// txtQuocTich
//
txtQuocTich.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular,
GraphicsUnit.Point, 0);
txtQuocTich.Location = new Point(243, 288);
txtQuocTich.Margin = new Padding(3, 4, 3, 4);
txtQuocTich.Name = "txtQuocTich";
txtQuocTich.Size = new Size(290, 30);
txtQuocTich.TabIndex = 21;
//
// label2
//
label2.AutoSize = true;
label2.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular,
GraphicsUnit.Point, 0);
label2.Location = new Point(124, 288);
label2.Name = "label2";
label2.Size = new Size(104, 26);
label2.TabIndex = 20;
label2.Text = "Quốc tịch";
//
// txtCCCD
//
txtCCCD.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular,
GraphicsUnit.Point, 0);
txtCCCD.Location = new Point(243, 156);
txtCCCD.Margin = new Padding(3, 4, 3, 4);
txtCCCD.Name = "txtCCCD";
txtCCCD.Size = new Size(290, 30);
txtCCCD.TabIndex = 19;
//
// label1
//
label1.AutoSize = true;
label1.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular,
GraphicsUnit.Point, 0);
label1.Location = new Point(14, 159);
label1.Name = "label1";
label1.Size = new Size(201, 26);
label1.TabIndex = 18;
label1.Text = "Số CCCD/Passport";
//
// txtHoVaTen
//
txtHoVaTen.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular,
GraphicsUnit.Point, 0);
txtHoVaTen.Location = new Point(243, 96);
txtHoVaTen.Margin = new Padding(3, 4, 3, 4);
txtHoVaTen.Name = "txtHoVaTen";
txtHoVaTen.Size = new Size(290, 30);
txtHoVaTen.TabIndex = 17;
//
// label5
//
label5.AutoSize = true;
label5.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular,
GraphicsUnit.Point, 0);
label5.Location = new Point(104, 99);
label5.Name = "label5";
label5.Size = new Size(105, 26);
label5.TabIndex = 16;
label5.Text = "Họ và tên";
//
// FormThemKhachHang
//
AutoScaleDimensions = new SizeF(8F, 20F);
AutoScaleMode = AutoScaleMode.Font;
ClientSize = new Size(608, 645);
Controls.Add(label6);
Controls.Add(btnThoat);
Controls.Add(btnThemMoi);
Controls.Add(panel1);
Margin = new Padding(3, 4, 3, 4);
Name = "FormThemKhachHang";
Text = "FormThemKhachHang";
Load += FormThemKhachHang_Load;
panel1.ResumeLayout(false);
panel1.PerformLayout();
ResumeLayout(false);
PerformLayout();
}
#endregion
private System.Windows.Forms.Label label6;
private System.Windows.Forms.Button btnThoat;
private System.Windows.Forms.Button btnThemMoi;
private System.Windows.Forms.Panel panel1;
private System.Windows.Forms.ComboBox cbGioiTinh;
private System.Windows.Forms.Label label7;
private System.Windows.Forms.TextBox txtSoDienThoai;
private System.Windows.Forms.Label label3;
private System.Windows.Forms.TextBox txtQuocTich;
private System.Windows.Forms.Label label2;
private System.Windows.Forms.TextBox txtCCCD;
private System.Windows.Forms.Label label1;
private System.Windows.Forms.TextBox txtHoVaTen;
private System.Windows.Forms.Label label5;
private System.Windows.Forms.TextBox txtMaKH;
private System.Windows.Forms.Label label4;
}
}
```

#### Bước 8: SV sử dụng mã nguồn tạm thời sau để xử lý chức năng trong file

FormThemKhachHang.cs
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
namespace HotelManagement.KhachHang
{
public partial class FormThemKhachHang : Form
{
public FormThemKhachHang ()
{
InitializeComponent();
btnThoat.DialogResult = DialogResult.Cancel;
}
private string GenerateMaKH ()
{
using var db = new HotelManagementContext();
var danhSachMa = db.KhachHangs
.AsNoTracking()
.Select( k => k.MaKh)
.ToList();
int max = 0;
foreach (string ma in danhSachMa)
{
if (ma != null && ma.Length > 2 && int . TryParse (ma. Substring (2), out
int so) && so > max)
{
max = so;
}
}
return "KH" + ( max + 1). ToString ("D3" );
}
private void FormThemKhachHang_Load (object sender , EventArgs e)
{
txtHoVaTen.MaxLength = 50;
txtCCCD.MaxLength = 12;
txtSoDienThoai.MaxLength = 10;
txtQuocTich.MaxLength = 30;
cbGioiTinh.DropDownStyle = ComboBoxStyle .DropDownList;
txtSoDienThoai.KeyPress += OnlyAllowDigits ;
try
{
txtMaKH.Text = GenerateMaKH ();
}
catch (Exception ex)
{
MessageBox . Show("Lỗi khi tạo mã khách hàng: " + ex.Message, "Lỗi" ,
MessageBoxButtons .OK, MessageBoxIcon .Error);
}
cbGioiTinh.SelectedIndex = 0;
}
private void OnlyAllowDigits (object sender , KeyPressEventArgs e)
{
if (! char . IsControl (e.KeyChar) && ! char . IsDigit (e.KeyChar))
{
e.Handled = true ;
}
}
private void btnThemMoi_Click (object sender , EventArgs e)
{
string maKH = txtMaKH.Text. Trim ();
string tenKH = txtHoVaTen.Text. Trim ();
string sdt = txtSoDienThoai.Text. Trim ();
string cccd = txtCCCD.Text. Trim ();
string quocTich = txtQuocTich.Text. Trim ();
string gioiTinh = cbGioiTinh.Text. Trim ();
if (string .IsNullOrEmpty (maKH))
{
MessageBox . Show("Chưa có mã khách hàng, vui lòng mở lại form!" , "Thông
báo" , MessageBoxButtons .OK, MessageBoxIcon .Warning);
return ;
}
if (string .IsNullOrEmpty (tenKH ))
{
MessageBox . Show("Vui lòng nhập họ và tên!" , "Thông báo" ,
MessageBoxButtons .OK, MessageBoxIcon .Warning);
txtHoVaTen. Focus ();
return ;
}
if (string .IsNullOrEmpty (cccd ))
{
MessageBox . Show("Vui lòng nhập số CCCD/Passport!" , "Thông báo" ,
MessageBoxButtons .OK, MessageBoxIcon .Warning);
txtCCCD. Focus ();
return ;
}
if (string .IsNullOrEmpty (quocTich ))
{
MessageBox . Show("Vui lòng nhập quốc tịch!" , "Thông báo" ,
MessageBoxButtons .OK, MessageBoxIcon .Warning);
txtQuocTich. Focus ();
return ;
}
if (string .IsNullOrEmpty (gioiTinh ))
{
MessageBox . Show("Vui lòng chọn giới tính!" , "Thông báo" ,
MessageBoxButtons .OK, MessageBoxIcon .Warning);
cbGioiTinh. Focus ();
return ;
}
try
{
using var db = new HotelManagementContext ();
if (db.KhachHangs. Any(k => k.CccdPassport == cccd ))
{
MessageBox . Show("Số CCCD/Passport đã tồn tại!" , "Thông báo" ,
MessageBoxButtons .OK, MessageBoxIcon .Warning);
txtCCCD. Focus ();
return ;
}
if (db.KhachHangs. Any(k => k.MaKh == maKH))
{
maKH = GenerateMaKH ();
txtMaKH.Text = maKH;
}
var khachHang = new Models. KhachHang
{
MaKh = maKH,
TenKh = tenKH ,
Sdt = string . IsNullOrEmpty (sdt ) ? null : sdt ,
CccdPassport = cccd ,
QuocTich = quocTich ,
GioiTinh = gioiTinh ,
DaXoa = false
};
db.KhachHangs. Add(khachHang );
int kq = db. SaveChanges ();
if (kq > 0)
{
MessageBox . Show("Thêm khách hàng thành công!" , "Thông báo" ,
MessageBoxButtons .OK, MessageBoxIcon .Information);
DialogResult = DialogResult .OK;
Close ();
}
else
{
MessageBox . Show("Thêm khách hàng thất bại!" , "Thông báo" ,
MessageBoxButtons .OK, MessageBoxIcon .Warning);
}
}
catch (Exception ex)
{
MessageBox . Show("Lỗi khi thêm khách hàng: " + ex.Message, "Lỗi" ,
MessageBoxButtons .OK, MessageBoxIcon .Error);
}
}
}
}
```

#### Bước 11: Click chuột phải vào folder KhachHang → Add → Forms( Windows Forms)

→ tạo một form để xây dựng giao diện và chức năng cập nhật thông tin 1 khách hàng
đang có là FormSuaKhachHang.cs

#### Bước 12: Thiết kế giao diện FormSuaKhachHang.cs theo mẫu như sau:

**Mã nguồn tham khảo trong file FormSuaKhachHang.Designer.cs tạm thời như sau:**

```csharp
namespace HotelManagement.KhachHang
{
partial class FormSuaKhachHang
{
/// <summary>
/// Required designer variable.
/// </summary>
private System.ComponentModel.IContainer components = null;
/// <summary>
/// Clean up any resources being used.
/// </summary>
/// <param name="disposing">true if managed resources should be disposed;
otherwise, false.</param>
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
label6 = new Label();
btnThoat = new Button();
btnCapNhat = new Button();
panel1 = new Panel();
txtMaKH = new TextBox();
label4 = new Label();
cbGioiTinh = new ComboBox();
label7 = new Label();
txtSoDienThoai = new TextBox();
label3 = new Label();
txtQuocTich = new TextBox();
label2 = new Label();
txtCCCD = new TextBox();
label1 = new Label();
txtHoVaTen = new TextBox();
label5 = new Label();
panel1.SuspendLayout();
SuspendLayout();
//
// label6
//
label6.AutoSize = true;
label6.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold,
GraphicsUnit.Point, 0);
label6.ForeColor = Color.FromArgb(192, 0, 0);
label6.Location = new Point(144, 31);
label6.Name = "label6";
label6.Size = new Size(386, 29);
label6.TabIndex = 25;
label6.Text = "Cập nhật thông tin khách hàng";
//
// btnThoat
//
btnThoat.BackColor = SystemColors.GradientActiveCaption;
btnThoat.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular,
GraphicsUnit.Point, 0);
btnThoat.Location = new Point(345, 531);
btnThoat.Margin = new Padding(3, 4, 3, 4);
btnThoat.Name = "btnThoat";
btnThoat.Size = new Size(137, 59);
btnThoat.TabIndex = 24;
btnThoat.Text = "Thoát";
btnThoat.UseVisualStyleBackColor = false;
btnThoat.Click += btnThoat_Click;
//
// btnCapNhat
//
btnCapNhat.BackColor = Color.Moccasin;
btnCapNhat.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular,
GraphicsUnit.Point, 0);
btnCapNhat.Location = new Point(145, 531);
btnCapNhat.Margin = new Padding(3, 4, 3, 4);
btnCapNhat.Name = "btnCapNhat";
btnCapNhat.Size = new Size(137, 59);
btnCapNhat.TabIndex = 23;
btnCapNhat.Text = "Cập nhật";
btnCapNhat.UseVisualStyleBackColor = false;
btnCapNhat.Click += btnCapNhat_Click;
//
// panel1
//
panel1.Controls.Add(txtMaKH);
panel1.Controls.Add(label4);
panel1.Controls.Add(cbGioiTinh);
panel1.Controls.Add(label7);
panel1.Controls.Add(txtSoDienThoai);
panel1.Controls.Add(label3);
panel1.Controls.Add(txtQuocTich);
panel1.Controls.Add(label2);
panel1.Controls.Add(txtCCCD);
panel1.Controls.Add(label1);
panel1.Controls.Add(txtHoVaTen);
panel1.Controls.Add(label5);
panel1.Location = new Point(40, 98);
panel1.Margin = new Padding(3, 4, 3, 4);
panel1.Name = "panel1";
panel1.Size = new Size(548, 426);
panel1.TabIndex = 22;
//
// txtMaKH
//
txtMaKH.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular,
GraphicsUnit.Point, 0);
txtMaKH.Location = new Point(243, 30);
txtMaKH.Margin = new Padding(3, 4, 3, 4);
txtMaKH.Name = "txtMaKH";
txtMaKH.ReadOnly = true;
txtMaKH.Size = new Size(290, 30);
txtMaKH.TabIndex = 27;
//
// label4
//
label4.AutoSize = true;
label4.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular,
GraphicsUnit.Point, 0);
label4.Location = new Point(104, 32);
label4.Name = "label4";
label4.Size = new Size(79, 26);
label4.TabIndex = 26;
label4.Text = "Mã KH";
//
// cbGioiTinh
//
cbGioiTinh.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular,
GraphicsUnit.Point, 0);
cbGioiTinh.FormattingEnabled = true;
cbGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
cbGioiTinh.Location = new Point(243, 348);
cbGioiTinh.Margin = new Padding(3, 4, 3, 4);
cbGioiTinh.Name = "cbGioiTinh";
cbGioiTinh.Size = new Size(290, 30);
cbGioiTinh.TabIndex = 25;
//
// label7
//
label7.AutoSize = true;
label7.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular,
GraphicsUnit.Point, 0);
label7.Location = new Point(83, 226);
label7.Name = "label7";
label7.Size = new Size(139, 26);
label7.TabIndex = 24;
label7.Text = "Số điện thoại";
//
// txtSoDienThoai
//
txtSoDienThoai.Font = new Font("Microsoft Sans Serif", 12F,
FontStyle.Regular, GraphicsUnit.Point, 0);
txtSoDienThoai.Location = new Point(243, 221);
txtSoDienThoai.Margin = new Padding(3, 4, 3, 4);
txtSoDienThoai.Name = "txtSoDienThoai";
txtSoDienThoai.Size = new Size(290, 30);
txtSoDienThoai.TabIndex = 23;
//
// label3
//
label3.AutoSize = true;
label3.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular,
GraphicsUnit.Point, 0);
label3.Location = new Point(130, 352);
label3.Name = "label3";
label3.Size = new Size(92, 26);
label3.TabIndex = 22;
label3.Text = "Giới tính";
//
// txtQuocTich
//
txtQuocTich.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular,
GraphicsUnit.Point, 0);
txtQuocTich.Location = new Point(243, 288);
txtQuocTich.Margin = new Padding(3, 4, 3, 4);
txtQuocTich.Name = "txtQuocTich";
txtQuocTich.Size = new Size(290, 30);
txtQuocTich.TabIndex = 21;
//
// label2
//
label2.AutoSize = true;
label2.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular,
GraphicsUnit.Point, 0);
label2.Location = new Point(124, 288);
label2.Name = "label2";
label2.Size = new Size(104, 26);
label2.TabIndex = 20;
label2.Text = "Quốc tịch";
//
// txtCCCD
//
txtCCCD.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular,
GraphicsUnit.Point, 0);
txtCCCD.Location = new Point(243, 156);
txtCCCD.Margin = new Padding(3, 4, 3, 4);
txtCCCD.Name = "txtCCCD";
txtCCCD.Size = new Size(290, 30);
txtCCCD.TabIndex = 19;
//
// label1
//
label1.AutoSize = true;
label1.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular,
GraphicsUnit.Point, 0);
label1.Location = new Point(14, 159);
label1.Name = "label1";
label1.Size = new Size(201, 26);
label1.TabIndex = 18;
label1.Text = "Số CCCD/Passport";
//
// txtHoVaTen
//
txtHoVaTen.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular,
GraphicsUnit.Point, 0);
txtHoVaTen.Location = new Point(243, 96);
txtHoVaTen.Margin = new Padding(3, 4, 3, 4);
txtHoVaTen.Name = "txtHoVaTen";
txtHoVaTen.Size = new Size(290, 30);
txtHoVaTen.TabIndex = 17;
//
// label5
//
label5.AutoSize = true;
label5.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular,
GraphicsUnit.Point, 0);
label5.Location = new Point(104, 99);
label5.Name = "label5";
label5.Size = new Size(105, 26);
label5.TabIndex = 16;
label5.Text = "Họ và tên";
//
// FormSuaKhachHang
//
AutoScaleDimensions = new SizeF(8F, 20F);
AutoScaleMode = AutoScaleMode.Font;
ClientSize = new Size(628, 620);
Controls.Add(label6);
Controls.Add(btnThoat);
Controls.Add(btnCapNhat);
Controls.Add(panel1);
Margin = new Padding(3, 4, 3, 4);
Name = "FormSuaKhachHang";
Text = "FormSuaKhachHang";
Load += FormSuaKhachHang_Load;
panel1.ResumeLayout(false);
panel1.PerformLayout();
ResumeLayout(false);
PerformLayout();
}
#endregion
private System.Windows.Forms.Label label6;
private System.Windows.Forms.Button btnThoat;
private System.Windows.Forms.Button btnCapNhat;
private System.Windows.Forms.Panel panel1;
private System.Windows.Forms.TextBox txtMaKH;
private System.Windows.Forms.Label label4;
private System.Windows.Forms.ComboBox cbGioiTinh;
private System.Windows.Forms.Label label7;
private System.Windows.Forms.TextBox txtSoDienThoai;
private System.Windows.Forms.Label label3;
private System.Windows.Forms.TextBox txtQuocTich;
private System.Windows.Forms.Label label2;
private System.Windows.Forms.TextBox txtCCCD;
private System.Windows.Forms.Label label1;
private System.Windows.Forms.TextBox txtHoVaTen;
private System.Windows.Forms.Label label5;
}
}
```

#### Bước 8: SV sử dụng mã nguồn tạm thời sau để xử lý chức năng trong file

FormSuaKhachHang.cs
```csharp
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HotelManagement.Models;
namespace HotelManagement.KhachHang
{
public partial class FormSuaKhachHang : Form
{
private string maKH = string .Empty;
public FormSuaKhachHang ()
{
InitializeComponent ();
}
public FormSuaKhachHang (string maKH) : this ()
{
this .maKH = maKH;
}
private void FormSuaKhachHang_Load (object sender , EventArgs e)
{
txtHoVaTen.MaxLength = 50;
txtCCCD.MaxLength = 12;
txtSoDienThoai.MaxLength = 10;
txtQuocTich.MaxLength = 30;
cbGioiTinh.DropDownStyle = ComboBoxStyle .DropDownList;
txtSoDienThoai.KeyPress += OnlyAllowDigits ;
if (string .IsNullOrEmpty (maKH))
{
MessageBox . Show("Không xác định được khách hàng cần cập nhật!" , "Thông
báo" , MessageBoxButtons .OK, MessageBoxIcon .Warning);
DialogResult = DialogResult .Cancel;
Close ();
return ;
}
try
{
using var db = new HotelManagementContext ();
var khachHang = db.KhachHangs
. Where(k => k.MaKh == maKH && k.DaXoa != true )
. Select (k => new
{
k.MaKh,
k.TenKh,
k.Sdt,
k.CccdPassport,
k.QuocTich,
k.GioiTinh
})
. FirstOrDefault ();
if (khachHang == null )
{
MessageBox . Show("Không tìm thấy khách hàng cần cập nhật!" , "Thông
báo" , MessageBoxButtons .OK, MessageBoxIcon .Warning);
DialogResult = DialogResult .Cancel;
Close ();
return ;
}
txtMaKH.Text = khachHang .MaKh;
txtHoVaTen.Text = khachHang .TenKh;
txtSoDienThoai.Text = khachHang .Sdt ?? "" ;
txtCCCD.Text = khachHang .CccdPassport;
txtQuocTich.Text = khachHang .QuocTich;
int viTri = cbGioiTinh. FindStringExact (khachHang .GioiTinh);
cbGioiTinh.SelectedIndex = viTri >= 0 ? viTri : 0;
}
catch (Exception ex)
{
MessageBox . Show("Lỗi khi load khách hàng: " + ex.Message, "Lỗi" ,
MessageBoxButtons .OK, MessageBoxIcon .Error);
DialogResult = DialogResult .Cancel;
Close ();
}
}
private void btnCapNhat_Click (object sender , EventArgs e)
{
string tenKH = txtHoVaTen.Text. Trim ();
string sdt = txtSoDienThoai.Text. Trim ();
string cccd = txtCCCD.Text. Trim ();
string quocTich = txtQuocTich.Text. Trim ();
string gioiTinh = cbGioiTinh.Text. Trim ();
if (string .IsNullOrEmpty (tenKH ))
{
MessageBox . Show("Vui lòng nhập họ và tên!" , "Thông báo" ,
MessageBoxButtons .OK, MessageBoxIcon .Warning);
txtHoVaTen. Focus ();
return ;
}
if (string .IsNullOrEmpty (cccd ))
{
MessageBox . Show("Vui lòng nhập số CCCD/Passport!" , "Thông báo" ,
MessageBoxButtons .OK, MessageBoxIcon .Warning);
txtCCCD. Focus ();
return ;
}
if (string .IsNullOrEmpty (quocTich ))
{
MessageBox . Show("Vui lòng nhập quốc tịch!" , "Thông báo" ,
MessageBoxButtons .OK, MessageBoxIcon .Warning);
txtQuocTich. Focus ();
return ;
}
if (string .IsNullOrEmpty (gioiTinh ))
{
MessageBox . Show("Vui lòng chọn giới tính!" , "Thông báo" ,
MessageBoxButtons .OK, MessageBoxIcon .Warning);
cbGioiTinh. Focus ();
return ;
}
try
{
using var db = new HotelManagementContext ();
var khachHang = db.KhachHangs. FirstOrDefault (k => k.MaKh == maKH &&
k.DaXoa != true );
if (khachHang == null )
{
MessageBox . Show("Không tìm thấy khách hàng cần cập nhật!" , "Thông
báo" , MessageBoxButtons .OK, MessageBoxIcon .Warning);
DialogResult = DialogResult .Cancel;
Close ();
return ;
}
if (db.KhachHangs. Any(k => k.MaKh != maKH && k.CccdPassport == cccd ))
{
MessageBox . Show("Số CCCD/Passport đã tồn tại!" , "Thông báo" ,
MessageBoxButtons .OK, MessageBoxIcon .Warning);
txtCCCD. Focus ();
return ;
}
khachHang .TenKh = tenKH ;
khachHang .Sdt = string . IsNullOrEmpty (sdt ) ? null : sdt ;
khachHang .CccdPassport = cccd ;
khachHang .QuocTich = quocTich ;
khachHang .GioiTinh = gioiTinh ;
int kq = db. SaveChanges ();
if (kq > 0)
{
MessageBox . Show("Cập nhật thành công!" , "Thông báo" ,
MessageBoxButtons .OK, MessageBoxIcon .Information);
DialogResult = DialogResult .OK;
Close ();
}
else
{
MessageBox . Show("Không có thay đổi nào để cập nhật!" , "Thông báo" ,
MessageBoxButtons .OK, MessageBoxIcon .Information);
}
}
catch (Exception ex)
{
MessageBox . Show("Lỗi khi cập nhật khách hàng: " + ex.Message, "Lỗi" ,
MessageBoxButtons .OK, MessageBoxIcon .Error);
}
}
private void btnThoat_Click (object sender , EventArgs e)
{
DialogResult = DialogResult .Cancel;
Close ();
}
private void OnlyAllowDigits (object sender , KeyPressEventArgs e)
{
if (! char . IsControl (e.KeyChar) && ! char . IsDigit (e.KeyChar))
{
e.Handled = true ;
}
}
}
}
```

### 4. Xây dựng giao diện và chức năng quản lý thông tin nhân viên tại khách sạn

#### Bước 1: Click chuột phải vào thư mục project → Add → New Folder→ Đặt tên folder

là “NhanVien”

#### Bước 2: Click chuột phải vào folder NhanVien → Add → Forms( Windows Forms) →

tạo một form thể hiện danh sách các nhân viên đang có trong khách sạn là
FormDanhSachNhanVien.cs

#### Bước 3: Thiết kế giao diện FormDanhSachNhanVien.cs theo mẫu như sau:

Mã nguồn tham khảo trong file FormDanhSachNhanVien.Designer.cs tạm thời như
sau:
```csharp
namespace HotelManagement.NhanVien
{
partial class FormDanhSachNhanVien
{
/// <summary>
/// Required designer variable.
/// </summary>
private System.ComponentModel. IContainer components = null ;
/// <summary>
/// Clean up any resources being used.
/// </summary>
/// <param name="disposing ">true if managed resources should be disposed;
otherwise, false. </param>
protected override void Dispose (bool disposing )
{
if (disposing && (components != null ))
{
components. Dispose ();
}
base . Dispose (disposing );
}
#region Windows Form Designer generated code
/// <summary>
/// Required method for Designer support - do not modify
/// the contents of this method with the code editor.
/// </summary>
private void InitializeComponent ()
{
btnThemMoi = new Button ();
dtgDanhSachNhanVien = new DataGridView ();
btnXuatExcel = new Button ();
txtTimKiem = new TextBox ();
pictureBox1 = new PictureBox ();
((System.ComponentModel. ISupportInitialize )dtgDanhSachNhanVien). BeginInit ();
((System.ComponentModel. ISupportInitialize )pictureBox1). BeginInit ();
SuspendLayout ();
//
// btnThemMoi
//
btnThemMoi.BackColor = Color .LightPink;
btnThemMoi.Font = new Font ("Microsoft Sans Serif" , 12F, FontStyle .Bold,
GraphicsUnit .Point, 0);
btnThemMoi.Location = new Point (692, 31);
btnThemMoi.Margin = new Padding (3, 4, 3, 4);
btnThemMoi.Name = "btnThemMoi" ;
btnThemMoi.Size = new Size (167, 46);
btnThemMoi.TabIndex = 25;
btnThemMoi.Text = "Thêm mới" ;
btnThemMoi.UseVisualStyleBackColor = false ;
//
// dtgDanhSachNhanVien
//
dtgDanhSachNhanVien.ColumnHeadersHeightSizeMode =
DataGridViewColumnHeadersHeightSizeMode .AutoSize;
dtgDanhSachNhanVien.Location = new Point (31, 94);
dtgDanhSachNhanVien.Margin = new Padding (3, 4, 3, 4);
dtgDanhSachNhanVien.Name = "dtgDanhSachNhanVien" ;
dtgDanhSachNhanVien.RowHeadersWidth = 51;
dtgDanhSachNhanVien.RowTemplate.Height = 24;
dtgDanhSachNhanVien.Size = new Size (945, 679);
dtgDanhSachNhanVien.TabIndex = 24;
dtgDanhSachNhanVien.CellClick += dtgDanhSachNhanVien_CellClick ;
//
// btnXuatExcel
//
btnXuatExcel.BackColor = Color .DarkTurquoise;
btnXuatExcel.Font = new Font ("Microsoft Sans Serif" , 12F, FontStyle .Bold,
GraphicsUnit .Point, 0);
btnXuatExcel.Location = new Point (494, 31);
btnXuatExcel.Margin = new Padding (3, 4, 3, 4);
btnXuatExcel.Name = "btnXuatExcel" ;
btnXuatExcel.Size = new Size (167, 46);
btnXuatExcel.TabIndex = 23;
btnXuatExcel.Text = "Xuất file Excel" ;
btnXuatExcel.UseVisualStyleBackColor = false ;
btnXuatExcel.Click += btnXuatExcel_Click ;
//
// txtTimKiem
//
txtTimKiem.Font = new Font ("Microsoft Sans Serif" , 13F, FontStyle .Regular,
GraphicsUnit .Point, 0);
txtTimKiem.Location = new Point (92, 38);
txtTimKiem.Margin = new Padding (3, 4, 3, 4);
txtTimKiem.Name = "txtTimKiem" ;
txtTimKiem.Size = new Size (187, 32);
txtTimKiem.TabIndex = 21;
txtTimKiem.TextChanged += txtTimKiem_TextChanged ;
//
// pictureBox1
//
pictureBox1.Image = Properties. Resources .search;
pictureBox1.Location = new Point (47, 31);
pictureBox1.Margin = new Padding (3, 4, 3, 4);
pictureBox1.Name = "pictureBox1" ;
pictureBox1.Size = new Size (39, 46);
pictureBox1.TabIndex = 22;
pictureBox1.TabStop = false ;
//
// FormDanhSachNhanVien
//
AutoScaleDimensions = new SizeF (8F, 20F);
AutoScaleMode = AutoScaleMode .Font;
ClientSize = new Size (989, 806);
Controls. Add(btnThemMoi);
Controls. Add(dtgDanhSachNhanVien);
Controls. Add(btnXuatExcel);
Controls. Add(pictureBox1);
Controls. Add(txtTimKiem);
Margin = new Padding (3, 4, 3, 4);
Name = "FormDanhSachNhanVien" ;
StartPosition = FormStartPosition .CenterScreen;
Text = "FormDanhSachNhanVien" ;
Load += FormDanhSachNhanVien_Load ;
((System.ComponentModel. ISupportInitialize )dtgDanhSachNhanVien). EndInit ();
((System.ComponentModel. ISupportInitialize )pictureBox1). EndInit ();
ResumeLayout (false );
PerformLayout ();
}
#endregion
private System.Windows.Forms. Button btnThemMoi;
private System.Windows.Forms. DataGridView dtgDanhSachNhanVien;
private System.Windows.Forms. Button btnXuatExcel;
private System.Windows.Forms. PictureBox pictureBox1;
private System.Windows.Forms. TextBox txtTimKiem;
}
}
```

#### Bước 4: SV sử dụng mã nguồn tạm thời sau để xử lý chức năng trong file

FormDanhSachNhanVien.cs
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
namespace HotelManagement.NhanVien
{
public partial class FormDanhSachNhanVien : Form
{
public FormDanhSachNhanVien()
{
InitializeComponent();
}
private void FormDanhSachNhanVien_Load(object sender, EventArgs e)
{
btnThemMoi.Click += btnThemMoi_Click;
LoadDanhSachNhanVien();
}
private void KhoiTaoBangDuLieu()
{
dtgDanhSachNhanVien.AllowUserToAddRows = false;
dtgDanhSachNhanVien.AllowUserToDeleteRows = false;
dtgDanhSachNhanVien.AllowUserToResizeRows = false;
dtgDanhSachNhanVien.ReadOnly = true;
dtgDanhSachNhanVien.MultiSelect = false;
dtgDanhSachNhanVien.RowHeadersVisible = false;
dtgDanhSachNhanVien.SelectionMode =
DataGridViewSelectionMode.FullRowSelect;
dtgDanhSachNhanVien.AutoSizeColumnsMode =
DataGridViewAutoSizeColumnsMode.Fill;
dtgDanhSachNhanVien.RowTemplate.Height = 40;
DataGridViewImageColumn iconCol = new DataGridViewImageColumn();
iconCol.Name = "Icon";
iconCol.HeaderText = "";
iconCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
iconCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
iconCol.Width = 40;
dtgDanhSachNhanVien.Columns.Add(iconCol);
dtgDanhSachNhanVien.Columns.Add("MaNV", "Mã NV");
dtgDanhSachNhanVien.Columns.Add("TenNV", "Tên nhân viên");
dtgDanhSachNhanVien.Columns.Add("ChucVu", "Chức vụ");
dtgDanhSachNhanVien.Columns.Add("Luong", "Lương");
dtgDanhSachNhanVien.Columns.Add("SDT", "Số điện thoại");
dtgDanhSachNhanVien.Columns.Add("Email", "Email");
dtgDanhSachNhanVien.Columns.Add("DiaChi", "Địa chỉ");
dtgDanhSachNhanVien.Columns["MaNV"].FillWeight = 8;
dtgDanhSachNhanVien.Columns["TenNV"].FillWeight = 17;
dtgDanhSachNhanVien.Columns["ChucVu"].FillWeight = 12;
dtgDanhSachNhanVien.Columns["Luong"].FillWeight = 13;
dtgDanhSachNhanVien.Columns["SDT"].FillWeight = 12;
dtgDanhSachNhanVien.Columns["Email"].FillWeight = 19;
dtgDanhSachNhanVien.Columns["DiaChi"].FillWeight = 25;
dtgDanhSachNhanVien.Columns["Luong"].DefaultCellStyle.Alignment =
DataGridViewContentAlignment.MiddleRight;
DataGridViewImageColumn suaCol = new DataGridViewImageColumn();
suaCol.Name = "Sua";
suaCol.HeaderText = "Sửa";
suaCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
suaCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
suaCol.Width = 50;
dtgDanhSachNhanVien.Columns.Add(suaCol);
DataGridViewImageColumn xoaCol = new DataGridViewImageColumn();
xoaCol.Name = "Xoa";
xoaCol.HeaderText = "Xóa";
xoaCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
xoaCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
xoaCol.Width = 50;
dtgDanhSachNhanVien.Columns.Add(xoaCol);
}
private void LoadDanhSachNhanVien(string tuKhoa = "")
{
try
{
if (dtgDanhSachNhanVien.Columns.Count == 0)
{
KhoiTaoBangDuLieu();
}
using var db = new HotelManagementContext();
var query = db.NhanViens
.AsNoTracking()
.Where(n => n.DaXoa != true);
if (!string.IsNullOrWhiteSpace(tuKhoa))
{
query = query.Where(n =>
n.MaNv.Contains(tuKhoa) ||
n.TenNv.Contains(tuKhoa) ||
n.Sdt.Contains(tuKhoa) ||
n.Cccd.Contains(tuKhoa));
}
var danhSach = query
.OrderBy(n => n.MaNv)
.Select(n => new
{
n.MaNv,
n.TenNv,
n.ChucVu,
n.Luong,
n.Sdt,
n.Email,
n.DiaChi
})
.ToList();
Image iconNhanVien = Properties.Resources.NhanVien;
Image iconSua = Properties.Resources.edit;
Image iconXoa = Properties.Resources.delete;
System.Globalization.CultureInfo viVN = new
System.Globalization.CultureInfo("vi -VN");
dtgDanhSachNhanVien.Rows.Clear();
foreach (var nv in danhSach)
{
dtgDanhSachNhanVien.Rows.Add(
iconNhanVien,
nv.MaNv,
nv.TenNv,
nv.ChucVu,
nv.Luong.ToString("C0", viVN),
nv.Sdt,
nv.Email ?? "",
nv.DiaChi,
iconSua,
iconXoa
);
}
dtgDanhSachNhanVien.ClearSelection();
}
catch (Exception ex)
{
MessageBox.Show("Lỗi khi load nhân viên: " + ex.Message, "Lỗi",
MessageBoxButtons.OK, MessageBoxIcon.Error);
}
}
private void txtTimKiem_TextChanged(object sender, EventArgs e)
{
LoadDanhSachNhanVien(txtTimKiem.Text.Trim());
}
private void dtgDanhSachNhanVien_CellClick(object sender,
DataGridViewCellEventArgs e)
{
if (e.RowIndex < 0 || e.ColumnIndex < 0)
{
return;
}
string tenCot = dtgDanhSachNhanVien.Columns[e.ColumnIndex].Name;
if (tenCot != "Sua" && tenCot != "Xoa")
{
return;
}
string maNV =
dtgDanhSachNhanVien.Rows[e.RowIndex].Cells["MaNV"].Value?.ToString();
if (string.IsNullOrEmpty(maNV))
{
return;
}
if (tenCot == "Sua")
{
using (FormSuaNhanVien f = new FormSuaNhanVien(maNV))
{
if (f.ShowDialog() == DialogResult.OK)
{
LoadDanhSachNhanVien(txtTimKiem.Text.Trim());
}
}
return;
}
if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận",
MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
{
XoaNhanVien(maNV);
}
}
private void XoaNhanVien(string maNV)
{
try
{
using var db = new HotelManagementContext();
var nhanVien = db.NhanViens
.Include(n => n.TaiKhoans)
.FirstOrDefault(n => n.MaNv == maNV);
if (nhanVien == null)
{
MessageBox.Show("Không tìm thấy nhân viên cần xóa!", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
}
else
{
nhanVien.DaXoa = true;
foreach (var taiKhoan in nhanVien.TaiKhoans)
{
taiKhoan.DaXoa = true;
}
int kq = db.SaveChanges();
if (kq > 0)
{
MessageBox.Show("Xóa nhân viên thành công.", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Information);
}
else
{
MessageBox.Show("Xóa nhân viên thất bại!", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
}
}
}
catch (Exception ex)
{
MessageBox.Show("Lỗi khi xóa nhân viên: " + ex.Message, "Lỗi",
MessageBoxButtons.OK, MessageBoxIcon.Error);
}
LoadDanhSachNhanVien(txtTimKiem.Text.Trim());
}
private void btnXuatExcel_Click(object sender, EventArgs e)
{
if (dtgDanhSachNhanVien.Rows.Count == 0)
{
MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
return;
}
using SaveFileDialog saveDialog = new SaveFileDialog();
saveDialog.Title = "Xuất danh sách nhân viên";
saveDialog.Filter = "Excel Workbook (*.xlsx)|*.xlsx";
saveDialog.FileName = "DanhSachNhanVien_" +
DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".xlsx";
if (saveDialog.ShowDialog() != DialogResult.OK)
{
return;
}
try
{
string[] tenCot = { "MaNV", "TenNV", "ChucVu", "Luong", "SDT", "Email",
"DiaChi" };
using (XLWorkbook workbook = new XLWorkbook())
{
IXLWorksheet worksheet = workbook.Worksheets.Add("Danh sách nhân
viên");
for (int j = 0; j < tenCot.Length; j++)
{
worksheet.Cell(1, j + 1).Value =
dtgDanhSachNhanVien.Columns[tenCot[j]].HeaderText;
}
worksheet.Range(1, 1, 1, tenCot.Length).Style.Font.Bold = true;
for (int i = 0; i < dtgDanhSachNhanVien.Rows.Count; i++)
{
for (int j = 0; j < tenCot.Length; j++)
{
worksheet.Cell(i + 2, j + 1).Value =
dtgDanhSachNhanVien.Rows[i].Cells[tenCot[j]].Value?.ToString() ?? "";
}
}
worksheet.Columns().AdjustToContents();
workbook.SaveAs(saveDialog.FileName);
}
DialogResult moFile = MessageBox.Show(
"Xuất dữ liệu thành công! \nBạn có muốn mở file vừa xuất không?",
"Thông báo",
MessageBoxButtons.YesNo,
MessageBoxIcon.Information);
if (moFile == DialogResult.Yes)
{
System.Diagnostics.Process.Start(new
System.Diagnostics.ProcessStartInfo(saveDialog.FileName)
{
UseShellExecute = true
});
}
}
catch (Exception ex)
{
MessageBox.Show("Lỗi khi xuất file Excel: " + ex.Message, "Lỗi",
MessageBoxButtons.OK, MessageBoxIcon.Error);
}
}
private void btnThemMoi_Click(object sender, EventArgs e)
{
using (FormThemNhanVien f = new FormThemNhanVien())
{
if (f.ShowDialog() == DialogResult.OK)
{
LoadDanhSachNhanVien(txtTimKiem.Text.Trim());
}
}
}
}
}
```

#### Bước 5: Chỉnh sửa lại hàm private void button7_Click(object sender,

EventArgs e)trong file FormMain.cs theo nội dung như sau:
```csharp
private void button7_Click (object sender , EventArgs e)
{
Form formCon = new NhanVien. FormDanhSachNhanVien ();
formCon .TopLevel = false ;
formCon .FormBorderStyle = FormBorderStyle .None;
formCon .Dock = DockStyle .Fill;
XoaNoiDungPanelMain ();
panelMain.Controls. Add(formCon );
formCon . Show();
}
```

#### Bước 6: Click chuột phải vào folder NhanVien → Add → Forms( Windows Forms) →

tạo một form để xây dựng giao diện và chức năng thêm mới thông tin 1 nhân viên trong
khách sạn là FormThemNhanVien.cs

#### Bước 7: Thiết kế giao diện FormThemNhanVien.cs theo mẫu như sau:

**Mã nguồn tham khảo trong file FormThemNhanVien.Designer.cs tạm thời như sau:**

```csharp
namespace HotelManagement.NhanVien
{
partial class FormThemNhanVien
{
/// <summary>
/// Required designer variable.
/// </summary>
private System.ComponentModel.IContainer components = null;
/// <summary>
/// Clean up any resources being used.
/// </summary>
/// <param name="disposing">true if managed resources should be disposed;
otherwise, false.</param>
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
label6 = new Label();
btnThoat = new Button();
btnThemMoi = new Button();
panel1 = new Panel();
txtMaNV = new TextBox();
label11 = new Label();
cbGioiTinh = new ComboBox();
label10 = new Label();
txtEmail = new TextBox();
label9 = new Label();
txtDiaChi = new TextBox();
label8 = new Label();
txtSoCCCD = new TextBox();
label4 = new Label();
dtNgaySinh = new DateTimePicker();
txtLuong = new TextBox();
cbChucVu = new ComboBox();
label7 = new Label();
label3 = new Label();
txtSoDT = new TextBox();
label2 = new Label();
label1 = new Label();
txtHoTenNV = new TextBox();
label5 = new Label();
panel1.SuspendLayout();
SuspendLayout();
//
// label6
//
label6.AutoSize = true;
label6.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold,
GraphicsUnit.Point, 0);
label6.ForeColor = Color.FromArgb(192, 0, 0);
label6.Location = new Point(400, 31);
label6.Name = "label6";
label6.Size = new Size(323, 29);
label6.TabIndex = 21;
label6.Text = "Thêm thông tin nhân viên";
//
// btnThoat
//
btnThoat.BackColor = SystemColors.GradientActiveCaption;
btnThoat.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular,
GraphicsUnit.Point, 0);
btnThoat.Location = new Point(555, 475);
btnThoat.Margin = new Padding(3, 4, 3, 4);
btnThoat.Name = "btnThoat";
btnThoat.Size = new Size(137, 59);
btnThoat.TabIndex = 20;
btnThoat.Text = "Thoát";
btnThoat.UseVisualStyleBackColor = false;
btnThoat.Click += btnThoat_Click;
//
// btnThemMoi
//
btnThemMoi.BackColor = Color.Moccasin;
btnThemMoi.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular,
GraphicsUnit.Point, 0);
btnThemMoi.Location = new Point(355, 475);
btnThemMoi.Margin = new Padding(3, 4, 3, 4);
btnThemMoi.Name = "btnThemMoi";
btnThemMoi.Size = new Size(137, 59);
btnThemMoi.TabIndex = 19;
btnThemMoi.Text = "Thêm mới";
btnThemMoi.UseVisualStyleBackColor = false;
btnThemMoi.Click += btnThemMoi_Click;
//
// panel1
//
panel1.Controls.Add(txtMaNV);
panel1.Controls.Add(label11);
panel1.Controls.Add(cbGioiTinh);
panel1.Controls.Add(label10);
panel1.Controls.Add(txtEmail);
panel1.Controls.Add(label9);
panel1.Controls.Add(txtDiaChi);
panel1.Controls.Add(label8);
panel1.Controls.Add(txtSoCCCD);
panel1.Controls.Add(label4);
panel1.Controls.Add(dtNgaySinh);
panel1.Controls.Add(txtLuong);
panel1.Controls.Add(cbChucVu);
panel1.Controls.Add(label7);
panel1.Controls.Add(label3);
panel1.Controls.Add(txtSoDT);
panel1.Controls.Add(label2);
panel1.Controls.Add(label1);
panel1.Controls.Add(txtHoTenNV);
panel1.Controls.Add(label5);
panel1.Location = new Point(12, 84);
panel1.Margin = new Padding(3, 4, 3, 4);
panel1.Name = "panel1";
panel1.Size = new Size(1020, 355);
panel1.TabIndex = 18;
//
// txtMaNV
//
txtMaNV.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular,
GraphicsUnit.Point, 0);
txtMaNV.Location = new Point(696, 289);
txtMaNV.Margin = new Padding(3, 4, 3, 4);
txtMaNV.Name = "txtMaNV";
txtMaNV.Size = new Size(290, 30);
txtMaNV.TabIndex = 38;
//
// label11
//
label11.AutoSize = true;
label11.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular,
GraphicsUnit.Point, 0);
label11.Location = new Point(601, 291);
label11.Name = "label11";
label11.Size = new Size(79, 26);
label11.TabIndex = 37;
label11.Text = "Mã NV";
//
// cbGioiTinh
//
cbGioiTinh.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular,
GraphicsUnit.Point, 0);
cbGioiTinh.FormattingEnabled = true;
cbGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
cbGioiTinh.Location = new Point(202, 294);
cbGioiTinh.Margin = new Padding(3, 4, 3, 4);
cbGioiTinh.Name = "cbGioiTinh";
cbGioiTinh.Size = new Size(290, 30);
cbGioiTinh.TabIndex = 36;
//
// label10
//
label10.AutoSize = true;
label10.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular,
GraphicsUnit.Point, 0);
label10.Location = new Point(72, 294);
label10.Name = "label10";
label10.Size = new Size(92, 26);
label10.TabIndex = 35;
label10.Text = "Giới tính";
//
// txtEmail
//
txtEmail.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular,
GraphicsUnit.Point, 0);
txtEmail.Location = new Point(696, 211);
txtEmail.Margin = new Padding(3, 4, 3, 4);
txtEmail.Name = "txtEmail";
txtEmail.Size = new Size(290, 30);
txtEmail.TabIndex = 34;
//
// label9
//
label9.AutoSize = true;
label9.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular,
GraphicsUnit.Point, 0);
label9.Location = new Point(612, 214);
label9.Name = "label9";
label9.Size = new Size(68, 26);
label9.TabIndex = 33;
label9.Text = "Email";
//
// txtDiaChi
//
txtDiaChi.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular,
GraphicsUnit.Point, 0);
txtDiaChi.Location = new Point(696, 152);
txtDiaChi.Margin = new Padding(3, 4, 3, 4);
txtDiaChi.Name = "txtDiaChi";
txtDiaChi.Size = new Size(290, 30);
txtDiaChi.TabIndex = 32;
//
// label8
//
label8.AutoSize = true;
label8.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular,
GraphicsUnit.Point, 0);
label8.Location = new Point(601, 152);
label8.Name = "label8";
label8.Size = new Size(79, 26);
label8.TabIndex = 31;
label8.Text = "Địa chỉ";
//
// txtSoCCCD
//
txtSoCCCD.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular,
GraphicsUnit.Point, 0);
txtSoCCCD.Location = new Point(696, 80);
txtSoCCCD.Margin = new Padding(3, 4, 3, 4);
txtSoCCCD.Name = "txtSoCCCD";
txtSoCCCD.Size = new Size(290, 30);
txtSoCCCD.TabIndex = 30;
//
// label4
//
label4.AutoSize = true;
label4.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular,
GraphicsUnit.Point, 0);
label4.Location = new Point(571, 88);
label4.Name = "label4";
label4.Size = new Size(109, 26);
label4.TabIndex = 29;
label4.Text = "Số CCCD";
//
// dtNgaySinh
//
dtNgaySinh.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular,
GraphicsUnit.Point, 0);
dtNgaySinh.Location = new Point(696, 19);
dtNgaySinh.Margin = new Padding(3, 4, 3, 4);
dtNgaySinh.Name = "dtNgaySinh";
dtNgaySinh.Size = new Size(290, 28);
dtNgaySinh.TabIndex = 28;
//
// txtLuong
//
txtLuong.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular,
GraphicsUnit.Point, 0);
txtLuong.Location = new Point(202, 150);
txtLuong.Margin = new Padding(3, 4, 3, 4);
txtLuong.Name = "txtLuong";
txtLuong.Size = new Size(290, 30);
txtLuong.TabIndex = 27;
//
// cbChucVu
//
cbChucVu.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular,
GraphicsUnit.Point, 0);
cbChucVu.FormattingEnabled = true;
cbChucVu.Items.AddRange(new object[] { "Người quản trị hệ thống", "Quản lý
khách sạn", "Nhân viên" });
cbChucVu.Location = new Point(202, 82);
cbChucVu.Margin = new Padding(3, 4, 3, 4);
cbChucVu.Name = "cbChucVu";
cbChucVu.Size = new Size(290, 30);
cbChucVu.TabIndex = 26;
//
// label7
//
label7.AutoSize = true;
label7.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular,
GraphicsUnit.Point, 0);
label7.Location = new Point(89, 152);
label7.Name = "label7";
label7.Size = new Size(72, 26);
label7.TabIndex = 24;
label7.Text = "Lương";
//
// label3
//
label3.AutoSize = true;
label3.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular,
GraphicsUnit.Point, 0);
label3.Location = new Point(571, 21);
label3.Name = "label3";
label3.Size = new Size(109, 26);
label3.TabIndex = 22;
label3.Text = "Ngày sinh";
//
// txtSoDT
//
txtSoDT.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular,
GraphicsUnit.Point, 0);
txtSoDT.Location = new Point(202, 214);
txtSoDT.Margin = new Padding(3, 4, 3, 4);
txtSoDT.Name = "txtSoDT";
txtSoDT.Size = new Size(290, 30);
txtSoDT.TabIndex = 21;
//
// label2
//
label2.AutoSize = true;
label2.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular,
GraphicsUnit.Point, 0);
label2.Location = new Point(25, 216);
label2.Name = "label2";
label2.Size = new Size(139, 26);
label2.TabIndex = 20;
label2.Text = "Số điện thoại";
//
// label1
//
label1.AutoSize = true;
label1.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular,
GraphicsUnit.Point, 0);
label1.Location = new Point(72, 82);
label1.Name = "label1";
label1.Size = new Size(92, 26);
label1.TabIndex = 18;
label1.Text = "Chức vụ";
//
// txtHoTenNV
//
txtHoTenNV.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular,
GraphicsUnit.Point, 0);
txtHoTenNV.Location = new Point(202, 22);
txtHoTenNV.Margin = new Padding(3, 4, 3, 4);
txtHoTenNV.Name = "txtHoTenNV";
txtHoTenNV.Size = new Size(290, 30);
txtHoTenNV.TabIndex = 17;
//
// label5
//
label5.AutoSize = true;
label5.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular,
GraphicsUnit.Point, 0);
label5.Location = new Point(59, 19);
label5.Name = "label5";
label5.Size = new Size(105, 26);
label5.TabIndex = 16;
label5.Text = "Họ và tên";
//
// FormThemNhanVien
//
AutoScaleDimensions = new SizeF(8F, 20F);
AutoScaleMode = AutoScaleMode.Font;
ClientSize = new Size(1076, 558);
Controls.Add(label6);
Controls.Add(btnThoat);
Controls.Add(btnThemMoi);
Controls.Add(panel1);
Margin = new Padding(3, 4, 3, 4);
Name = "FormThemNhanVien";
Text = "FormThemNhanVien";
Load += FormThemNhanVien_Load;
panel1.ResumeLayout(false);
panel1.PerformLayout();
ResumeLayout(false);
PerformLayout();
}
#endregion
private System.Windows.Forms.Label label6;
private System.Windows.Forms.Button btnThoat;
private System.Windows.Forms.Button btnThemMoi;
private System.Windows.Forms.Panel panel1;
private System.Windows.Forms.Label label7;
private System.Windows.Forms.Label label3;
private System.Windows.Forms.TextBox txtSoDT;
private System.Windows.Forms.Label label2;
private System.Windows.Forms.Label label1;
private System.Windows.Forms.TextBox txtHoTenNV;
private System.Windows.Forms.Label label5;
private System.Windows.Forms.TextBox txtEmail;
private System.Windows.Forms.Label label9;
private System.Windows.Forms.TextBox txtDiaChi;
private System.Windows.Forms.Label label8;
private System.Windows.Forms.TextBox txtSoCCCD;
private System.Windows.Forms.Label label4;
private System.Windows.Forms.DateTimePicker dtNgaySinh;
private System.Windows.Forms.TextBox txtLuong;
private System.Windows.Forms.ComboBox cbChucVu;
private System.Windows.Forms.TextBox txtMaNV;
private System.Windows.Forms.Label label11;
private System.Windows.Forms.ComboBox cbGioiTinh;
private System.Windows.Forms.Label label10;
}
}
```

#### Bước 8: SV sử dụng mã nguồn tạm thời sau để xử lý chức năng trong file

FormThemNhanVien.cs
```csharp
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using HotelManagement.Models;
namespace HotelManagement.NhanVien
{
public partial class FormThemNhanVien : Form
{
public FormThemNhanVien ()
{
InitializeComponent();
}
private void FormThemNhanVien_Load (object sender , EventArgs e)
{
txtMaNV.MaxLength = 5;
txtHoTenNV.MaxLength = 50;
txtLuong.MaxLength = 15;
txtSoDT.MaxLength = 10;
txtSoCCCD.MaxLength = 12;
txtDiaChi.MaxLength = 100;
txtEmail.MaxLength = 100;
cbChucVu.DropDownStyle = ComboBoxStyle.DropDownList;
cbGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;
cbGioiTinh.SelectedIndex = 0;
dtNgaySinh.Format = DateTimePickerFormat.Short;
dtNgaySinh.Value = DateTime.Today.AddYears( -18);
txtLuong.KeyPress += ChiNhapSo;
txtSoDT.KeyPress += ChiNhapSo;
txtSoCCCD.KeyPress += ChiNhapSo;
}
private void ChiNhapSo (object sender , KeyPressEventArgs e)
{
if (! char .IsControl(e.KeyChar) && ! char .IsDigit(e.KeyChar))
{
e.Handled = true ;
}
}
private bool IsValidEmail (string email )
{
return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+ \.[^@ \s]+$" );
}
private bool ToanChuSo (string chuoi )
{
foreach (char c in chuoi)
{
if (! char .IsDigit(c))
{
return false ;
}
}
return true ;
}
private void btnThemMoi_Click (object sender , EventArgs e)
{
string maNV = txtMaNV.Text. Trim (). ToUpper ();
string tenNV = txtHoTenNV.Text. Trim ();
string chucVu = cbChucVu.SelectedItem?. ToString () ?? "" ;
string luong = txtLuong.Text. Trim ();
string sdt = txtSoDT.Text. Trim ();
string cccd = txtSoCCCD.Text. Trim ();
DateTime ngaySinh = dtNgaySinh.Value.Date;
string gioiTinh = cbGioiTinh.SelectedItem?. ToString () ?? "" ;
string diaChi = txtDiaChi.Text. Trim ();
string email = txtEmail.Text. Trim ();
if (maNV == "" || tenNV == "" || chucVu == "" || luong == "" || sdt == ""
|| cccd == "" || diaChi == "" || email == "" )
{
MessageBox . Show("Vui lòng điền đầy đủ thông tin bắt buộc." , "Thông
báo" , MessageBoxButtons .OK, MessageBoxIcon .Warning);
return ;
}
if (! decimal . TryParse (luong , NumberStyles .None,
CultureInfo .InvariantCulture, out decimal luongSo ) || luongSo <= 0)
{
MessageBox . Show("Lương phải là số lớn hơn 0." , "Thông báo" ,
MessageBoxButtons .OK, MessageBoxIcon .Warning);
txtLuong. Focus ();
return ;
}
if (! ToanChuSo (sdt ) || sdt .Length < 9)
{
MessageBox . Show("Số điện thoại phải gồm 9 đến 10 chữ số." , "Thông báo" ,
MessageBoxButtons .OK, MessageBoxIcon .Warning);
txtSoDT. Focus ();
return ;
}
if (! ToanChuSo (cccd ) || cccd .Length != 12)
{
MessageBox . Show("Số CCCD phải gồm đúng 12 chữ số." , "Thông báo" ,
MessageBoxButtons .OK, MessageBoxIcon .Warning);
txtSoCCCD. Focus ();
return ;
}
if (! IsValidEmail (email ))
{
MessageBox . Show("Email không đúng định dạng." , "Thông báo" ,
MessageBoxButtons .OK, MessageBoxIcon .Warning);
txtEmail. Focus ();
return ;
}
if (ngaySinh > DateTime .Today. AddYears (-18))
{
MessageBox . Show("Nhân viên phải đủ 18 tuổi." , "Thông báo" ,
MessageBoxButtons .OK, MessageBoxIcon .Warning);
dtNgaySinh. Focus ();
return ;
}
try
{
using var db = new HotelManagementContext ();
if (db.NhanViens. Any(n => n.MaNv == maNV))
{
MessageBox . Show("Mã nhân viên đã tồn tại." , "Thông báo" ,
MessageBoxButtons .OK, MessageBoxIcon .Warning);
txtMaNV. Focus ();
return ;
}
if (db.NhanViens. Any(n => n.Sdt == sdt ))
{
MessageBox . Show("Số điện thoại đã tồn tại." , "Thông báo" ,
MessageBoxButtons .OK, MessageBoxIcon .Warning);
txtSoDT. Focus ();
return ;
}
if (db.NhanViens. Any(n => n.Cccd == cccd ))
{
MessageBox . Show("Số CCCD đã tồn tại." , "Thông báo" ,
MessageBoxButtons .OK, MessageBoxIcon .Warning);
txtSoCCCD. Focus ();
return ;
}
if (db.NhanViens. Any(n => n.Email == email ))
{
MessageBox . Show("Email đã tồn tại." , "Thông báo" ,
MessageBoxButtons .OK, MessageBoxIcon .Warning);
txtEmail. Focus ();
return ;
}
var nhanVien = new Models. NhanVien
{
MaNv = maNV,
TenNv = tenNV ,
ChucVu = chucVu ,
Luong = luongSo ,
Sdt = sdt ,
Cccd = cccd ,
NgaySinh = DateOnly . FromDateTime (ngaySinh ),
GioiTinh = gioiTinh ,
DiaChi = diaChi ,
Email = email ,
DaXoa = false
};
db.NhanViens. Add(nhanVien );
int kq = db. SaveChanges ();
if (kq > 0)
{
MessageBox . Show("Thêm nhân viên thành công." , "Thông báo" ,
MessageBoxButtons .OK, MessageBoxIcon .Information);
DialogResult = DialogResult .OK;
Close ();
}
else
{
MessageBox . Show("Thêm nhân viên thất bại!" , "Thông báo" ,
MessageBoxButtons .OK, MessageBoxIcon .Warning);
}
}
catch (Exception ex)
{
MessageBox . Show("Lỗi khi thêm nhân viên: " + ex.Message, "Lỗi" ,
MessageBoxButtons .OK, MessageBoxIcon .Error);
}
}
private void btnThoat_Click (object sender , EventArgs e)
{
DialogResult = DialogResult .Cancel;
Close ();
}
}
}
```

#### Bước 11: Click chuột phải vào folder NhanVien → Add → Forms( Windows Forms)

→ tạo một form để xây dựng giao diện và chức năng cập nhật thông tin 1 nhân viên
đang có là FormSuaNhanVien.cs

#### Bước 12: Thiết kế giao diện FormSuaNhanVien.cs theo mẫu như sau:

**Mã nguồn tham khảo trong file FormSuaNhanVien.Designer.cs tạm thời như sau:**

```csharp
namespace HotelManagement.NhanVien
{
partial class FormSuaNhanVien
{
/// <summary>
/// Required designer variable.
/// </summary>
private System.ComponentModel.IContainer components = null;
/// <summary>
/// Clean up any resources being used.
/// </summary>
/// <param name="disposing">true if managed resources should be disposed;
otherwise, false.</param>
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
label6 = new Label();
btnThoat = new Button();
btnCapNhat = new Button();
panel1 = new Panel();
txtMaNV = new TextBox();
label11 = new Label();
cbGioiTinh = new ComboBox();
label10 = new Label();
txtEmail = new TextBox();
label9 = new Label();
txtDiaChi = new TextBox();
label8 = new Label();
txtSoCCCD = new TextBox();
label4 = new Label();
dtNgaySinh = new DateTimePicker();
txtLuong = new TextBox();
cbChucVu = new ComboBox();
label7 = new Label();
label3 = new Label();
txtSoDT = new TextBox();
label2 = new Label();
label1 = new Label();
txtHoTenNV = new TextBox();
label5 = new Label();
panel1.SuspendLayout();
SuspendLayout();
//
// label6
//
label6.AutoSize = true;
label6.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold,
GraphicsUnit.Point, 0);
label6.ForeColor = Color.FromArgb(192, 0, 0);
label6.Location = new Point(358, 26);
label6.Name = "label6";
label6.Size = new Size(364, 29);
label6.TabIndex = 25;
label6.Text = "Cập nhật thông tin nhân viên";
//
// btnThoat
//
btnThoat.BackColor = SystemColors.GradientActiveCaption;
btnThoat.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular,
GraphicsUnit.Point, 0);
btnThoat.Location = new Point(563, 476);
btnThoat.Margin = new Padding(3, 4, 3, 4);
btnThoat.Name = "btnThoat";
btnThoat.Size = new Size(137, 59);
btnThoat.TabIndex = 24;
btnThoat.Text = "Thoát";
btnThoat.UseVisualStyleBackColor = false;
btnThoat.Click += btnThoat_Click;
//
// btnCapNhat
//
btnCapNhat.BackColor = Color.Moccasin;
btnCapNhat.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular,
GraphicsUnit.Point, 0);
btnCapNhat.Location = new Point(363, 476);
btnCapNhat.Margin = new Padding(3, 4, 3, 4);
btnCapNhat.Name = "btnCapNhat";
btnCapNhat.Size = new Size(137, 59);
btnCapNhat.TabIndex = 23;
btnCapNhat.Text = "Cập nhật";
btnCapNhat.UseVisualStyleBackColor = false;
btnCapNhat.Click += btnCapNhat_Click;
//
// panel1
//
panel1.Controls.Add(txtMaNV);
panel1.Controls.Add(label11);
panel1.Controls.Add(cbGioiTinh);
panel1.Controls.Add(label10);
panel1.Controls.Add(txtEmail);
panel1.Controls.Add(label9);
panel1.Controls.Add(txtDiaChi);
panel1.Controls.Add(label8);
panel1.Controls.Add(txtSoCCCD);
panel1.Controls.Add(label4);
panel1.Controls.Add(dtNgaySinh);
panel1.Controls.Add(txtLuong);
panel1.Controls.Add(cbChucVu);
panel1.Controls.Add(label7);
panel1.Controls.Add(label3);
panel1.Controls.Add(txtSoDT);
panel1.Controls.Add(label2);
panel1.Controls.Add(label1);
panel1.Controls.Add(txtHoTenNV);
panel1.Controls.Add(label5);
panel1.Location = new Point(20, 85);
panel1.Margin = new Padding(3, 4, 3, 4);
panel1.Name = "panel1";
panel1.Size = new Size(1020, 355);
panel1.TabIndex = 22;
//
// txtMaNV
//
txtMaNV.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular,
GraphicsUnit.Point, 0);
txtMaNV.Location = new Point(696, 289);
txtMaNV.Margin = new Padding(3, 4, 3, 4);
txtMaNV.Name = "txtMaNV";
txtMaNV.ReadOnly = true;
txtMaNV.Size = new Size(290, 30);
txtMaNV.TabIndex = 38;
//
// label11
//
label11.AutoSize = true;
label11.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular,
GraphicsUnit.Point, 0);
label11.Location = new Point(601, 291);
label11.Name = "label11";
label11.Size = new Size(79, 26);
label11.TabIndex = 37;
label11.Text = "Mã NV";
//
// cbGioiTinh
//
cbGioiTinh.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular,
GraphicsUnit.Point, 0);
cbGioiTinh.FormattingEnabled = true;
cbGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
cbGioiTinh.Location = new Point(202, 294);
cbGioiTinh.Margin = new Padding(3, 4, 3, 4);
cbGioiTinh.Name = "cbGioiTinh";
cbGioiTinh.Size = new Size(290, 30);
cbGioiTinh.TabIndex = 36;
//
// label10
//
label10.AutoSize = true;
label10.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular,
GraphicsUnit.Point, 0);
label10.Location = new Point(72, 294);
label10.Name = "label10";
label10.Size = new Size(92, 26);
label10.TabIndex = 35;
label10.Text = "Giới tính";
//
// txtEmail
//
txtEmail.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular,
GraphicsUnit.Point, 0);
txtEmail.Location = new Point(696, 211);
txtEmail.Margin = new Padding(3, 4, 3, 4);
txtEmail.Name = "txtEmail";
txtEmail.Size = new Size(290, 30);
txtEmail.TabIndex = 34;
//
// label9
//
label9.AutoSize = true;
label9.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular,
GraphicsUnit.Point, 0);
label9.Location = new Point(612, 214);
label9.Name = "label9";
label9.Size = new Size(68, 26);
label9.TabIndex = 33;
label9.Text = "Email";
//
// txtDiaChi
//
txtDiaChi.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular,
GraphicsUnit.Point, 0);
txtDiaChi.Location = new Point(696, 152);
txtDiaChi.Margin = new Padding(3, 4, 3, 4);
txtDiaChi.Name = "txtDiaChi";
txtDiaChi.Size = new Size(290, 30);
txtDiaChi.TabIndex = 32;
//
// label8
//
label8.AutoSize = true;
label8.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular,
GraphicsUnit.Point, 0);
label8.Location = new Point(601, 152);
label8.Name = "label8";
label8.Size = new Size(79, 26);
label8.TabIndex = 31;
label8.Text = "Địa chỉ";
//
// txtSoCCCD
//
txtSoCCCD.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular,
GraphicsUnit.Point, 0);
txtSoCCCD.Location = new Point(696, 80);
txtSoCCCD.Margin = new Padding(3, 4, 3, 4);
txtSoCCCD.Name = "txtSoCCCD";
txtSoCCCD.Size = new Size(290, 30);
txtSoCCCD.TabIndex = 30;
//
// label4
//
label4.AutoSize = true;
label4.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular,
GraphicsUnit.Point, 0);
label4.Location = new Point(571, 88);
label4.Name = "label4";
label4.Size = new Size(109, 26);
label4.TabIndex = 29;
label4.Text = "Số CCCD";
//
// dtNgaySinh
//
dtNgaySinh.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular,
GraphicsUnit.Point, 0);
dtNgaySinh.Location = new Point(696, 19);
dtNgaySinh.Margin = new Padding(3, 4, 3, 4);
dtNgaySinh.Name = "dtNgaySinh";
dtNgaySinh.Size = new Size(290, 28);
dtNgaySinh.TabIndex = 28;
//
// txtLuong
//
txtLuong.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular,
GraphicsUnit.Point, 0);
txtLuong.Location = new Point(202, 150);
txtLuong.Margin = new Padding(3, 4, 3, 4);
txtLuong.Name = "txtLuong";
txtLuong.Size = new Size(290, 30);
txtLuong.TabIndex = 27;
//
// cbChucVu
//
cbChucVu.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular,
GraphicsUnit.Point, 0);
cbChucVu.FormattingEnabled = true;
cbChucVu.Items.AddRange(new object[] { "Người quản trị hệ thống", "Quản lý
khách sạn", "Nhân viên" });
cbChucVu.Location = new Point(202, 82);
cbChucVu.Margin = new Padding(3, 4, 3, 4);
cbChucVu.Name = "cbChucVu";
cbChucVu.Size = new Size(290, 30);
cbChucVu.TabIndex = 26;
//
// label7
//
label7.AutoSize = true;
label7.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular,
GraphicsUnit.Point, 0);
label7.Location = new Point(89, 152);
label7.Name = "label7";
label7.Size = new Size(72, 26);
label7.TabIndex = 24;
label7.Text = "Lương";
//
// label3
//
label3.AutoSize = true;
label3.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular,
GraphicsUnit.Point, 0);
label3.Location = new Point(571, 21);
label3.Name = "label3";
label3.Size = new Size(109, 26);
label3.TabIndex = 22;
label3.Text = "Ngày sinh";
//
// txtSoDT
//
txtSoDT.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular,
GraphicsUnit.Point, 0);
txtSoDT.Location = new Point(202, 214);
txtSoDT.Margin = new Padding(3, 4, 3, 4);
txtSoDT.Name = "txtSoDT";
txtSoDT.Size = new Size(290, 30);
txtSoDT.TabIndex = 21;
//
// label2
//
label2.AutoSize = true;
label2.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular,
GraphicsUnit.Point, 0);
label2.Location = new Point(25, 216);
label2.Name = "label2";
label2.Size = new Size(139, 26);
label2.TabIndex = 20;
label2.Text = "Số điện thoại";
//
// label1
//
label1.AutoSize = true;
label1.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular,
GraphicsUnit.Point, 0);
label1.Location = new Point(72, 82);
label1.Name = "label1";
label1.Size = new Size(92, 26);
label1.TabIndex = 18;
label1.Text = "Chức vụ";
//
// txtHoTenNV
//
txtHoTenNV.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular,
GraphicsUnit.Point, 0);
txtHoTenNV.Location = new Point(202, 22);
txtHoTenNV.Margin = new Padding(3, 4, 3, 4);
txtHoTenNV.Name = "txtHoTenNV";
txtHoTenNV.Size = new Size(290, 30);
txtHoTenNV.TabIndex = 17;
//
// label5
//
label5.AutoSize = true;
label5.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular,
GraphicsUnit.Point, 0);
label5.Location = new Point(59, 19);
label5.Name = "label5";
label5.Size = new Size(105, 26);
label5.TabIndex = 16;
label5.Text = "Họ và tên";
//
// FormSuaNhanVien
//
AutoScaleDimensions = new SizeF(8F, 20F);
AutoScaleMode = AutoScaleMode.Font;
ClientSize = new Size(1053, 559);
Controls.Add(label6);
Controls.Add(btnThoat);
Controls.Add(btnCapNhat);
Controls.Add(panel1);
Margin = new Padding(3, 4, 3, 4);
Name = "FormSuaNhanVien";
Text = "FormSuaNhanVien";
Load += FormSuaNhanVien_Load;
panel1.ResumeLayout(false);
panel1.PerformLayout();
ResumeLayout(false);
PerformLayout();
}
#endregion
private System.Windows.Forms.Label label6;
private System.Windows.Forms.Button btnThoat;
private System.Windows.Forms.Button btnCapNhat;
private System.Windows.Forms.Panel panel1;
private System.Windows.Forms.TextBox txtMaNV;
private System.Windows.Forms.Label label11;
private System.Windows.Forms.ComboBox cbGioiTinh;
private System.Windows.Forms.Label label10;
private System.Windows.Forms.TextBox txtEmail;
private System.Windows.Forms.Label label9;
private System.Windows.Forms.TextBox txtDiaChi;
private System.Windows.Forms.Label label8;
private System.Windows.Forms.TextBox txtSoCCCD;
private System.Windows.Forms.Label label4;
private System.Windows.Forms.DateTimePicker dtNgaySinh;
private System.Windows.Forms.TextBox txtLuong;
private System.Windows.Forms.ComboBox cbChucVu;
private System.Windows.Forms.Label label7;
private System.Windows.Forms.Label label3;
private System.Windows.Forms.TextBox txtSoDT;
private System.Windows.Forms.Label label2;
private System.Windows.Forms.Label label1;
private System.Windows.Forms.TextBox txtHoTenNV;
private System.Windows.Forms.Label label5;
}
}
```

#### Bước 13: SV sử dụng mã nguồn tạm thời sau để xử lý chức năng trong file

FormSuaNhanVien.cs
```csharp
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using HotelManagement.Models;
namespace HotelManagement.NhanVien
{
public partial class FormSuaNhanVien : Form
{
private string maNV = string .Empty;
public FormSuaNhanVien ()
{
InitializeComponent();
}
public FormSuaNhanVien (string maNV) : this ()
{
this .maNV = maNV;
}
private void FormSuaNhanVien_Load (object sender , EventArgs e)
{
txtHoTenNV.MaxLength = 50;
txtLuong.MaxLength = 15;
txtSoDT.MaxLength = 10;
txtSoCCCD.MaxLength = 12;
txtDiaChi.MaxLength = 100;
txtEmail.MaxLength = 100;
cbChucVu.DropDownStyle = ComboBoxStyle.DropDownList;
cbGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;
dtNgaySinh.Format = DateTimePickerFormat.Short;
txtLuong.KeyPress += ChiNhapSo;
txtSoDT.KeyPress += ChiNhapSo;
txtSoCCCD.KeyPress += ChiNhapSo;
if (string .IsNullOrEmpty(maNV))
{
MessageBox.Show( "Không xác định được nhân viên cần cập nhật!" , "Thông
báo" , MessageBoxButtons.OK, MessageBoxIcon.Warning);
DialogResult = DialogResult.Cancel;
Close();
return ;
}
LoadThongTinNhanVien();
}
private void LoadThongTinNhanVien ()
{
try
{
using var db = new HotelManagementContext();
var nhanVien = db.NhanViens
.Where( n => n.MaNv == maNV && n.DaXoa != true )
.Select( n => new
{
n.MaNv,
n.TenNv,
n.ChucVu,
n.Luong,
n.Sdt,
n.Cccd,
n.NgaySinh,
n.GioiTinh,
n.DiaChi,
n.Email
})
.FirstOrDefault();
if (nhanVien == null )
{
MessageBox.Show( "Không tìm thấy nhân viên cần cập nhật!" , "Thông
báo" , MessageBoxButtons.OK, MessageBoxIcon.Warning);
DialogResult = DialogResult.Cancel;
Close();
return ;
}
txtMaNV.Text = nhanVien.MaNv;
txtHoTenNV.Text = nhanVien.TenNv;
ChonGiaTri(cbChucVu, nhanVien.ChucVu);
txtLuong.Text = nhanVien.Luong.ToString( "0" ,
CultureInfo.InvariantCulture);
txtSoDT.Text = nhanVien.Sdt;
txtSoCCCD.Text = nhanVien.Cccd;
dtNgaySinh.Value = nhanVien.NgaySinh.ToDateTime(TimeOnly.MinValue);
ChonGiaTri(cbGioiTinh, nhanVien.GioiTinh);
txtDiaChi.Text = nhanVien.DiaChi;
txtEmail.Text = nhanVien.Email ?? "" ;
}
catch (Exception ex)
{
MessageBox.Show( "Lỗi khi load nhân viên: " + ex.Message, "Lỗi" ,
MessageBoxButtons.OK, MessageBoxIcon.Error);
DialogResult = DialogResult.Cancel;
Close();
}
}
private void ChonGiaTri (ComboBox comboBox , string giaTri )
{
if (string .IsNullOrEmpty(giaTri))
{
return ;
}
int viTri = comboBox.FindStringExact(giaTri);
if (viTri < 0)
{
viTri = comboBox.Items.Add(giaTri);
}
comboBox.SelectedIndex = viTri;
}
private void ChiNhapSo (object sender , KeyPressEventArgs e)
{
if (! char .IsControl(e.KeyChar) && ! char .IsDigit(e.KeyChar))
{
e.Handled = true ;
}
}
private bool IsValidEmail (string email )
{
return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+ \.[^@ \s]+$" );
}
private bool ToanChuSo (string chuoi )
{
foreach (char c in chuoi)
{
if (! char .IsDigit(c))
{
return false ;
}
}
return true ;
}
private void btnCapNhat_Click (object sender , EventArgs e)
{
string tenNV = txtHoTenNV.Text. Trim ();
string chucVu = cbChucVu.SelectedItem?. ToString () ?? "" ;
string luong = txtLuong.Text. Trim ();
string sdt = txtSoDT.Text. Trim ();
string cccd = txtSoCCCD.Text. Trim ();
DateTime ngaySinh = dtNgaySinh.Value.Date;
string gioiTinh = cbGioiTinh.SelectedItem?. ToString () ?? "" ;
string diaChi = txtDiaChi.Text. Trim ();
string email = txtEmail.Text. Trim ();
if (tenNV == "" || chucVu == "" || luong == "" || sdt == "" || cccd == ""
|| gioiTinh == "" || diaChi == "" || email == "" )
{
MessageBox . Show("Vui lòng điền đầy đủ thông tin bắt buộc." , "Thông
báo" , MessageBoxButtons .OK, MessageBoxIcon .Warning);
return ;
}
if (! decimal . TryParse (luong , NumberStyles .None,
CultureInfo .InvariantCulture, out decimal luongSo ) || luongSo <= 0)
{
MessageBox . Show("Lương phải là số lớn hơn 0." , "Thông báo" ,
MessageBoxButtons .OK, MessageBoxIcon .Warning);
txtLuong. Focus ();
return ;
}
if (! ToanChuSo (sdt ) || sdt .Length < 9)
{
MessageBox . Show("Số điện thoại phải gồm 9 đến 10 chữ số." , "Thông báo" ,
MessageBoxButtons .OK, MessageBoxIcon .Warning);
txtSoDT. Focus ();
return ;
}
if (! ToanChuSo (cccd ) || cccd .Length != 12)
{
MessageBox . Show("Số CCCD phải gồm đúng 12 chữ số." , "Thông báo" ,
MessageBoxButtons .OK, MessageBoxIcon .Warning);
txtSoCCCD. Focus ();
return ;
}
if (! IsValidEmail (email ))
{
MessageBox . Show("Email không đúng định dạng." , "Thông báo" ,
MessageBoxButtons .OK, MessageBoxIcon .Warning);
txtEmail. Focus ();
return ;
}
if (ngaySinh > DateTime .Today. AddYears (-18))
{
MessageBox . Show("Nhân viên phải đủ 18 tuổi." , "Thông báo" ,
MessageBoxButtons .OK, MessageBoxIcon .Warning);
dtNgaySinh. Focus ();
return ;
}
try
{
using var db = new HotelManagementContext ();
var nhanVien = db.NhanViens. FirstOrDefault (n => n.MaNv == maNV &&
n.DaXoa != true );
if (nhanVien == null )
{
MessageBox . Show("Không tìm thấy nhân viên cần cập nhật!" , "Thông
báo" , MessageBoxButtons .OK, MessageBoxIcon .Warning);
DialogResult = DialogResult .Cancel;
Close ();
return ;
}
if (db.NhanViens. Any(n => n.MaNv != maNV && n.Sdt == sdt ))
{
MessageBox . Show("Số điện thoại đã tồn tại." , "Thông báo" ,
MessageBoxButtons .OK, MessageBoxIcon .Warning);
txtSoDT. Focus ();
return ;
}
if (db.NhanViens. Any(n => n.MaNv != maNV && n.Cccd == cccd ))
{
MessageBox . Show("Số CCCD đã tồn tại." , "Thông báo" ,
MessageBoxButtons .OK, MessageBoxIcon .Warning);
txtSoCCCD. Focus ();
return ;
}
if (db.NhanViens. Any(n => n.MaNv != maNV && n.Email == email ))
{
MessageBox . Show("Email đã tồn tại." , "Thông báo" ,
MessageBoxButtons .OK, MessageBoxIcon .Warning);
txtEmail. Focus ();
return ;
}
nhanVien .TenNv = tenNV ;
nhanVien .ChucVu = chucVu ;
nhanVien .Luong = luongSo ;
nhanVien .Sdt = sdt ;
nhanVien .Cccd = cccd ;
nhanVien .NgaySinh = DateOnly . FromDateTime (ngaySinh );
nhanVien .GioiTinh = gioiTinh ;
nhanVien .DiaChi = diaChi ;
nhanVien .Email = email ;
int kq = db. SaveChanges ();
if (kq > 0)
{
MessageBox . Show("Cập nhật nhân viên thành công." , "Thông báo" ,
MessageBoxButtons .OK, MessageBoxIcon .Information);
DialogResult = DialogResult .OK;
Close ();
}
else
{
MessageBox . Show("Không có thay đổi nào để cập nhật!" , "Thông báo" ,
MessageBoxButtons .OK, MessageBoxIcon .Information);
}
}
catch (Exception ex)
{
MessageBox . Show("Lỗi khi cập nhật nhân viên: " + ex.Message, "Lỗi" ,
MessageBoxButtons .OK, MessageBoxIcon .Error);
}
}
private void btnThoat_Click (object sender , EventArgs e)
{
DialogResult = DialogResult .Cancel;
Close ();
}
}
}
```

### 5. Xây dựng giao diện và chức năng quản lý thông tin tiện nghi cho các loại phòng

trong khách sạn

#### Bước 1: Click chuột phải vào thư mục project → Add → New Folder→ Đặt tên folder

là “ChiTietTienNghi”

#### Bước 2: Click chuột phải vào folder ChiTietTienNghi → Add → Forms( Windows

Forms) → tạo một form thể hiện danh sách các nhân viên đang có trong khách sạn là
FormDanhSachChiTietTienNghi.cs

#### Bước 3: Thiết kế giao diện FormDanhSachChiTietTienNghi.cs theo mẫu như sau:

Mã nguồn tham khảo trong file FormDanhSachChiTietTienNghi.Designer.cs tạm thời
như sau:
```csharp
namespace HotelManagement.ChiTietTienNghi
{
partial class FormDanhSachChiTietTienNghi
{
/// <summary>
/// Required designer variable.
/// </summary>
private System.ComponentModel. IContainer components = null ;
/// <summary>
/// Clean up any resources being used.
/// </summary>
/// <param name="disposing ">true if managed resources should be disposed;
otherwise, false. </param>
protected override void Dispose (bool disposing )
{
if (disposing && (components != null ))
{
components. Dispose ();
}
base . Dispose (disposing );
}
#region Windows Form Designer generated code
/// <summary>
/// Required method for Designer support - do not modify
/// the contents of this method with the code editor.
/// </summary>
private void InitializeComponent ()
{
dtgDanhSachTienNghiTheoLoaiPhong = new DataGridView ();
label1 = new Label ();
lblTenLoaiPhong = new Label ();
btnThoat = new Button ();
btnCapNhat = new Button ();
((System.ComponentModel. ISupportInitialize )dtgDanhSachTienNghiTheoLoaiPhong). BeginInit (
);
SuspendLayout ();
//
// dtgDanhSachTienNghiTheoLoaiPhong
//
dtgDanhSachTienNghiTheoLoaiPhong.ColumnHeadersHeightSizeMode =
DataGridViewColumnHeadersHeightSizeMode .AutoSize;
dtgDanhSachTienNghiTheoLoaiPhong.Location = new Point (12, 141);
dtgDanhSachTienNghiTheoLoaiPhong.Margin = new Padding (3, 4, 3, 4);
dtgDanhSachTienNghiTheoLoaiPhong.Name = "dtgDanhSachTienNghiTheoLoaiPhong" ;
dtgDanhSachTienNghiTheoLoaiPhong.RowHeadersWidth = 51;
dtgDanhSachTienNghiTheoLoaiPhong.RowTemplate.Height = 24;
dtgDanhSachTienNghiTheoLoaiPhong.Size = new Size (776, 415);
dtgDanhSachTienNghiTheoLoaiPhong.TabIndex = 0;
//
// label1
//
label1.AutoSize = true ;
label1.Font = new Font ("Microsoft Sans Serif" , 17F, FontStyle .Bold,
GraphicsUnit .Point, 0);
label1.ForeColor = Color .Red;
label1.Location = new Point (157, 26);
label1.Name = "label1" ;
label1.Size = new Size (496, 33);
label1.TabIndex = 1;
label1.Text = "DANH SÁCH TIỆN NGHI HIỆN CÓ" ;
//
// lblTenLoaiPhong
//
lblTenLoaiPhong.AutoSize = true ;
lblTenLoaiPhong.Font = new Font ("Microsoft Sans Serif" , 15F,
FontStyle .Bold, GraphicsUnit .Point, 0);
lblTenLoaiPhong.ForeColor = Color .Blue;
lblTenLoaiPhong.Location = new Point (306, 90);
lblTenLoaiPhong.Name = "lblTenLoaiPhong" ;
lblTenLoaiPhong.Size = new Size (194, 29);
lblTenLoaiPhong.TabIndex = 2;
lblTenLoaiPhong.Text = "Tên loai phòng" ;
//
// btnThoat
//
btnThoat.BackColor = SystemColors .GradientActiveCaption;
btnThoat.Font = new Font ("Microsoft Sans Serif" , 12F, FontStyle .Regular,
GraphicsUnit .Point, 0);
btnThoat.Location = new Point (435, 587);
btnThoat.Margin = new Padding(3, 4, 3, 4);
btnThoat.Name = "btnThoat" ;
btnThoat.Size = new Size (137, 59);
btnThoat.TabIndex = 17;
btnThoat.Text = "Thoát" ;
btnThoat.UseVisualStyleBackColor = false ;
//
// btnCapNhat
//
btnCapNhat.BackColor = Color .Moccasin;
btnCapNhat.Font = new Font ("Microsoft Sans Serif" , 12F, FontStyle .Regular,
GraphicsUnit .Point, 0);
btnCapNhat.Location = new Point (227, 587);
btnCapNhat.Margin = new Padding (3, 4, 3, 4);
btnCapNhat.Name = "btnCapNhat" ;
btnCapNhat.Size = new Size (137, 59);
btnCapNhat.TabIndex = 16;
btnCapNhat.Text = "Thêm mới" ;
btnCapNhat.UseVisualStyleBackColor = false ;
//
// FormDanhSachChiTietTienNghi
//
AutoScaleDimensions = new SizeF (8F, 20F);
AutoScaleMode = AutoScaleMode .Font;
ClientSize = new Size (800, 656);
Controls. Add(btnThoat);
Controls. Add(btnCapNhat);
Controls. Add(lblTenLoaiPhong);
Controls. Add(label1);
Controls. Add(dtgDanhSachTienNghiTheoLoaiPhong);
Margin = new Padding (3, 4, 3, 4);
Name = "FormDanhSachChiTietTienNghi" ;
StartPosition = FormStartPosition .CenterScreen;
Text = "Quản lý các tiện nghi theo loại phòng" ;
((System.ComponentModel. ISupportInitialize )dtgDanhSachTienNghiTheoLoaiPhong). EndInit ();
ResumeLayout (false );
PerformLayout ();
}
#endregion
private System.Windows.Forms. DataGridView dtgDanhSachTienNghiTheoLoaiPhong;
private System.Windows.Forms. Label label1;
private System.Windows.Forms. Label lblTenLoaiPhong;
private System.Windows.Forms. Button btnThoat;
private System.Windows.Forms. Button btnCapNhat;
}
}
```

#### Bước 5: SV sử dụng mã nguồn tạm thời sau để xử lý chức năng trong file

FormDanhSachChiTietTienNghi.cs
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
namespace HotelManagement.ChiTietTienNghi
{
public partial class FormDanhSachChiTietTienNghi : Form
{
private string maLPH = string .Empty;
private string tenLoaiPhong = string .Empty;
public FormDanhSachChiTietTienNghi ()
{
InitializeComponent();
}
public FormDanhSachChiTietTienNghi (string maLPH, string tenLoaiPhong ) : this ()
{
this .maLPH = maLPH;
this .tenLoaiPhong = tenLoaiPhong;
}
private void FormDanhSachChiTietTienNghi_Load (object sender , EventArgs e)
{
if (string .IsNullOrEmpty(maLPH))
{
MessageBox.Show( "Không xác định được loại phòng!" , "Thông báo" ,
MessageBoxButtons.OK, MessageBoxIcon.Warning);
Close();
return ;
}
lblTenLoaiPhong.Text = $"Loại phòng: {tenLoaiPhong} ";
LoadChiTietTienNghi();
}
private void KhoiTaoBangDuLieu ()
{
dtgDanhSachTienNghiTheoLoaiPhong.AllowUserToAddRows = false ;
dtgDanhSachTienNghiTheoLoaiPhong.AllowUserToDeleteRows = false ;
dtgDanhSachTienNghiTheoLoaiPhong.AllowUserToResizeRows = false ;
dtgDanhSachTienNghiTheoLoaiPhong.ReadOnly = true ;
dtgDanhSachTienNghiTheoLoaiPhong.MultiSelect = false ;
dtgDanhSachTienNghiTheoLoaiPhong.RowHeadersVisible = false ;
dtgDanhSachTienNghiTheoLoaiPhong.SelectionMode =
DataGridViewSelectionMode.FullRowSelect;
dtgDanhSachTienNghiTheoLoaiPhong.AutoSizeColumnsMode =
DataGridViewAutoSizeColumnsMode.Fill;
dtgDanhSachTienNghiTheoLoaiPhong.RowTemplate.Height = 36;
dtgDanhSachTienNghiTheoLoaiPhong.Columns.Add( "MaTN", "Mã tiện nghi" );
dtgDanhSachTienNghiTheoLoaiPhong.Columns[ "MaTN"].Visible = false ;
dtgDanhSachTienNghiTheoLoaiPhong.Columns.Add( "TenTN" , "Tên tiện nghi" );
dtgDanhSachTienNghiTheoLoaiPhong.Columns.Add( "SL" , "Số lượng" );
dtgDanhSachTienNghiTheoLoaiPhong.Columns.Add( "GhiChu" , "Ghi chú" );
dtgDanhSachTienNghiTheoLoaiPhong.Columns[ "TenTN" ].FillWeight = 45;
dtgDanhSachTienNghiTheoLoaiPhong.Columns[ "SL" ].FillWeight = 15;
dtgDanhSachTienNghiTheoLoaiPhong.Columns[ "GhiChu" ].FillWeight = 40;
dtgDanhSachTienNghiTheoLoaiPhong.Columns[ "SL" ].DefaultCellStyle.Alignment =
DataGridViewContentAlignment.MiddleCenter;
DataGridViewImageColumn suaCol = new DataGridViewImageColumn();
suaCol.Name = "Sua" ;
suaCol.HeaderText = "Sửa" ;
suaCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
suaCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
suaCol.Width = 50;
dtgDanhSachTienNghiTheoLoaiPhong.Columns.Add(suaCol);
DataGridViewImageColumn xoaCol = new DataGridViewImageColumn();
xoaCol.Name = "Xoa" ;
xoaCol.HeaderText = "Xóa" ;
xoaCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
xoaCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
xoaCol.Width = 50;
dtgDanhSachTienNghiTheoLoaiPhong.Columns.Add(xoaCol);
}
private void LoadChiTietTienNghi ()
{
try
{
if (dtgDanhSachTienNghiTheoLoaiPhong.Columns.Count == 0)
{
KhoiTaoBangDuLieu ();
}
using var db = new HotelManagementContext ();
var danhSach = db.Cttns
. AsNoTracking ()
. Where(c => c.MaLph == maLPH && c.DaXoa != true &&
c.MaTnNavigation.DaXoa != true )
. OrderBy (c => c.MaTn)
. Select (c => new
{
c.MaTn,
c.MaTnNavigation.TenTn,
c.Sl
})
. ToList ();
Image iconSua = Properties. Resources .edit;
Image iconXoa = Properties. Resources .delete;
dtgDanhSachTienNghiTheoLoaiPhong.Rows. Clear ();
foreach (var tn in danhSach )
{
int soLuong = tn.Sl ?? 0;
bool dungDuoc = soLuong >= 1;
int viTri = dtgDanhSachTienNghiTheoLoaiPhong.Rows. Add(
tn.MaTn,
tn.TenTn,
soLuong ,
dungDuoc ? "Có thể sử dụng tốt" : "Đang không sử dụng được" ,
iconSua ,
iconXoa
);
if (! dungDuoc )
{
dtgDanhSachTienNghiTheoLoaiPhong.Rows[ viTri ].Cells[ "GhiChu" ].Style.ForeColor =
Color .Red;
}
}
dtgDanhSachTienNghiTheoLoaiPhong. ClearSelection ();
}
catch (Exception ex)
{
MessageBox . Show("Lỗi khi load tiện nghi của loại phòng: " + ex.Message,
"Lỗi" , MessageBoxButtons .OK, MessageBoxIcon .Error);
}
}
private void dtgDanhSachTienNghiTheoLoaiPhong_CellClick (object sender ,
DataGridViewCellEventArgs e)
{
if (e.RowIndex < 0 || e.ColumnIndex < 0)
{
return ;
}
string tenCot =
dtgDanhSachTienNghiTheoLoaiPhong.Columns[ e.ColumnIndex].Name;
if (tenCot != "Sua" && tenCot != "Xoa" )
{
return ;
}
DataGridViewRow dong = dtgDanhSachTienNghiTheoLoaiPhong.Rows[ e.RowIndex];
string maTN = dong.Cells[ "MaTN"].Value?. ToString ();
string tenTN = dong.Cells[ "TenTN" ].Value?. ToString () ?? "" ;
if (string .IsNullOrEmpty (maTN))
{
return ;
}
if (tenCot == "Sua" )
{
int . TryParse (dong.Cells[ "SL" ].Value?. ToString (), out int sl );
using (FormSuaChiTietTienNghi f = new FormSuaChiTietTienNghi (maLPH,
maTN, tenTN , sl ))
{
if (f. ShowDialog () == DialogResult .OK)
{
LoadChiTietTienNghi ();
}
}
return ;
}
if (MessageBox . Show($"Bạn có chắc muốn xóa tiện nghi ' {tenTN }'?" , "Xác
nhận" , MessageBoxButtons .YesNo, MessageBoxIcon .Warning) != DialogResult .Yes)
{
return ;
}
try
{
using var db = new HotelManagementContext ();
var chiTiet = db.Cttns. FirstOrDefault (c => c.MaLph == maLPH && c.MaTn
== maTN);
if (chiTiet == null )
{
MessageBox . Show("Không tìm thấy tiện nghi cần xóa!" , "Lỗi" ,
MessageBoxButtons .OK, MessageBoxIcon .Error);
}
else
{
db.Cttns. Remove(chiTiet );
int kq = db. SaveChanges ();
if (kq > 0)
{
MessageBox . Show("Xóa thành công!" , "Thông báo" ,
MessageBoxButtons .OK, MessageBoxIcon .Information);
}
else
{
MessageBox . Show("Xóa thất bại!" , "Lỗi" , MessageBoxButtons .OK,
MessageBoxIcon .Error);
}
}
}
catch (Exception ex)
{
MessageBox . Show("Lỗi khi xóa tiện nghi: " + ex.Message, "Lỗi" ,
MessageBoxButtons .OK, MessageBoxIcon .Error);
}
LoadChiTietTienNghi ();
}
private void btnCapNhat_Click (object sender , EventArgs e)
{
using (FormThemChiTietTienNghi f = new FormThemChiTietTienNghi (maLPH))
{
f. ShowDialog ();
}
LoadChiTietTienNghi ();
}
private void btnThoat_Click (object sender , EventArgs e)
{
Close ();
}
}
}
```

#### Bước 6: Click chuột phải vào folder ChiTietTienNghi → Add → Forms( Windows

Forms) → tạo một form để xây dựng giao diện và chức năng thêm mới thông tin 1 tiện
nghi cho một loại phòng trong khách sạn là FormThemChiTietTienNghi.cs

#### Bước 7: Thiết kế giao diện FormThemChiTietTienNghi.cs theo mẫu như sau:

Mã nguồn tham khảo trong file FormThemChiTietTienNghi.Designer.cs tạm thời như
sau:
```csharp
namespace HotelManagement.ChiTietTienNghi
{
partial class FormThemChiTietTienNghi
{
/// <summary>
/// Required designer variable.
/// </summary>
private System.ComponentModel. IContainer components = null ;
/// <summary>
/// Clean up any resources being used.
/// </summary>
/// <param name="disposing ">true if managed resources should be disposed;
otherwise, false. </param>
protected override void Dispose (bool disposing )
{
if (disposing && (components != null ))
{
components. Dispose ();
}
base . Dispose (disposing );
}
#region Windows Form Designer generated code
/// <summary>
/// Required method for Designer support - do not modify
/// the contents of this method with the code editor.
/// </summary>
private void InitializeComponent ()
{
txtSoLuong = new TextBox ();
label2 = new Label ();
label1 = new Label ();
label5 = new Label ();
btnThoat = new Button ();
btnCapNhat = new Button ();
cbTenTN = new ComboBox();
SuspendLayout ();
//
// txtSoLuong
//
txtSoLuong.Font = new Font ("Microsoft Sans Serif" , 12F, FontStyle .Regular,
GraphicsUnit .Point, 0);
txtSoLuong.Location = new Point (242, 271);
txtSoLuong.Margin = new Padding(3, 4, 3, 4);
txtSoLuong.Name = "txtSoLuong" ;
txtSoLuong.Size = new Size (275, 30);
txtSoLuong.TabIndex = 29;
//
// label2
//
label2.AutoSize = true ;
label2.Font = new Font ("Microsoft Sans Serif" , 13F, FontStyle .Regular,
GraphicsUnit .Point, 0);
label2.Location = new Point (115, 271);
label2.Name = "label2" ;
label2.Size = new Size (98, 26);
label2.TabIndex = 28;
label2.Text = "Số lượng" ;
//
// label1
//
label1.AutoSize = true ;
label1.Font = new Font ("Microsoft Sans Serif" , 13F, FontStyle .Regular,
GraphicsUnit .Point, 0);
label1.Location = new Point (73, 148);
label1.Name = "label1" ;
label1.Size = new Size (136, 26);
label1.TabIndex = 26;
label1.Text = "Tên tiện nghi" ;
//
// label5
//
label5.AutoSize = true ;
label5.Font = new Font ("Microsoft Sans Serif" , 16F, FontStyle .Bold,
GraphicsUnit .Point, 0);
label5.ForeColor = Color . FromArgb (192, 64, 0);
label5.Location = new Point (29, 39);
label5.Name = "label5" ;
label5.Size = new Size (578, 31);
label5.TabIndex = 25;
label5.Text = "Thêm mới thông tin tiện nghi của loại phòng" ;
//
// btnThoat
//
btnThoat.BackColor = SystemColors .GradientActiveCaption;
btnThoat.Font = new Font ("Microsoft Sans Serif" , 12F, FontStyle .Regular,
GraphicsUnit .Point, 0);
btnThoat.Location = new Point (361, 371);
btnThoat.Margin = new Padding (3, 4, 3, 4);
btnThoat.Name = "btnThoat" ;
btnThoat.Size = new Size (137, 59);
btnThoat.TabIndex = 24;
btnThoat.Text = "Thoát" ;
btnThoat.UseVisualStyleBackColor = false ;
btnThoat.Click += btnThoat_Click ;
//
// btnCapNhat
//
btnCapNhat.BackColor = Color .Moccasin;
btnCapNhat.Font = new Font ("Microsoft Sans Serif" , 12F, FontStyle .Regular,
GraphicsUnit .Point, 0);
btnCapNhat.Location = new Point (161, 371);
btnCapNhat.Margin = new Padding (3, 4, 3, 4);
btnCapNhat.Name = "btnCapNhat" ;
btnCapNhat.Size = new Size (137, 59);
btnCapNhat.TabIndex = 23;
btnCapNhat.Text = "Thêm mới" ;
btnCapNhat.UseVisualStyleBackColor = false ;
btnCapNhat.Click += btnCapNhat_Click ;
//
// cbTenTN
//
cbTenTN.Font = new Font ("Microsoft Sans Serif" , 13F, FontStyle .Regular,
GraphicsUnit .Point, 0);
cbTenTN.FormattingEnabled = true ;
cbTenTN.Location = new Point (242, 149);
cbTenTN.Margin = new Padding (3, 4, 3, 4);
cbTenTN.Name = "cbTenTN" ;
cbTenTN.Size = new Size (275, 34);
cbTenTN.TabIndex = 30;
//
// FormThemChiTietTienNghi
//
AutoScaleDimensions = new SizeF (8F, 20F);
AutoScaleMode = AutoScaleMode .Font;
ClientSize = new Size (610, 445);
Controls. Add(cbTenTN);
Controls. Add(txtSoLuong);
Controls. Add(label2);
Controls. Add(label1);
Controls. Add(label5);
Controls. Add(btnThoat);
Controls. Add(btnCapNhat);
Margin = new Padding (3, 4, 3, 4);
Name = "FormThemChiTietTienNghi" ;
StartPosition = FormStartPosition .CenterScreen;
Text = "FormThemChiTietTienNghi" ;
Load += FormThemChiTietTienNghi_Load ;
ResumeLayout (false );
PerformLayout ();
}
#endregion
private System.Windows.Forms. TextBox txtSoLuong;
private System.Windows.Forms. Label label2;
private System.Windows.Forms. Label label1;
private System.Windows.Forms. Label label5;
private System.Windows.Forms. Button btnThoat;
private System.Windows.Forms. Button btnCapNhat;
private System.Windows.Forms. ComboBox cbTenTN;
}
}
```

#### Bước 8: SV sử dụng mã nguồn tạm thời sau để xử lý chức năng trong file

FormThemChiTietTienNghi.cs
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
namespace HotelManagement.ChiTietTienNghi
{
public partial class FormThemChiTietTienNghi : Form
{
private string maLPH = string .Empty;
public FormThemChiTietTienNghi ()
{
InitializeComponent();
}
public FormThemChiTietTienNghi (string maLPH) : this ()
{
this .maLPH = maLPH;
}
private void FormThemChiTietTienNghi_Load (object sender , EventArgs e)
{
cbTenTN.DropDownStyle = ComboBoxStyle.DropDownList;
txtSoLuong.MaxLength = 4;
txtSoLuong.KeyPress += ChiNhapSo;
if (string .IsNullOrEmpty(maLPH))
{
MessageBox.Show( "Không xác định được loại phòng!" , "Thông báo" ,
MessageBoxButtons.OK, MessageBoxIcon.Warning);
DialogResult = DialogResult.Cancel;
Close();
return ;
}
LoadTienNghiChuaThem ();
}
private void ChiNhapSo (object sender , KeyPressEventArgs e)
{
if (! char . IsControl (e.KeyChar) && ! char . IsDigit (e.KeyChar))
{
e.Handled = true ;
}
}
private void LoadTienNghiChuaThem ()
{
try
{
using var db = new HotelManagementContext ();
var daCo = db.Cttns
. AsNoTracking ()
. Where(c => c.MaLph == maLPH && c.DaXoa != true )
. Select (c => c.MaTn);
var danhSach = db.TienNghis
. AsNoTracking ()
. Where(t => t.DaXoa != true && ! daCo. Contains (t.MaTn))
. OrderBy (t => t.TenTn)
. Select (t => new
{
t.MaTn,
t.TenTn
})
. ToList ();
if (danhSach .Count == 0)
{
MessageBox . Show("Loại phòng này đã có đầy đủ các tiện nghi, không
còn tiện nghi nào để thêm!" , "Thông báo" , MessageBoxButtons .OK,
MessageBoxIcon .Information);
DialogResult = DialogResult .Cancel;
Close ();
return ;
}
cbTenTN.DataSource = danhSach ;
cbTenTN.DisplayMember = "TenTn" ;
cbTenTN.ValueMember = "MaTn" ;
cbTenTN.SelectedIndex = 0;
}
catch (Exception ex)
{
MessageBox . Show("Lỗi khi load danh sách tiện nghi: " + ex.Message,
"Lỗi" , MessageBoxButtons .OK, MessageBoxIcon .Error);
DialogResult = DialogResult .Cancel;
Close ();
}
}
private void btnCapNhat_Click (object sender , EventArgs e)
{
if (string .IsNullOrWhiteSpace (txtSoLuong.Text) || cbTenTN.SelectedIndex ==
-1)
{
MessageBox . Show("Vui lòng nhập đầy đủ thông tin!" , "Thông báo" ,
MessageBoxButtons .OK, MessageBoxIcon .Warning);
return ;
}
if (! int . TryParse (txtSoLuong.Text. Trim (), out int soLuong ) || soLuong < 0)
{
MessageBox . Show("Số lượng không hợp lệ!" , "Lỗi" , MessageBoxButtons .OK,
MessageBoxIcon .Error);
txtSoLuong. Focus ();
return ;
}
string maTN = cbTenTN.SelectedValue?. ToString () ?? "" ;
if (maTN == "" )
{
MessageBox . Show("Vui lòng chọn tiện nghi!" , "Thông báo" ,
MessageBoxButtons .OK, MessageBoxIcon .Warning);
return ;
}
try
{
using var db = new HotelManagementContext ();
var chiTiet = db.Cttns. FirstOrDefault (c => c.MaLph == maLPH && c.MaTn
== maTN);
if (chiTiet == null )
{
db.Cttns. Add(new Cttn
{
MaLph = maLPH,
MaTn = maTN,
Sl = soLuong ,
DaXoa = false
});
}
else if (chiTiet .DaXoa == true )
{
chiTiet .Sl = soLuong ;
chiTiet .DaXoa = false ;
}
else
{
MessageBox . Show("Tiện nghi này đã có trong loại phòng!" , "Thông
báo" , MessageBoxButtons .OK, MessageBoxIcon .Warning);
LoadTienNghiChuaThem ();
return ;
}
int kq = db. SaveChanges ();
if (kq > 0)
{
MessageBox . Show("Thêm thành công!" , "Thông báo" ,
MessageBoxButtons .OK, MessageBoxIcon .Information);
DialogResult = DialogResult .OK;
Close ();
}
else
{
MessageBox . Show("Thêm thất bại!" , "Lỗi" , MessageBoxButtons .OK,
MessageBoxIcon .Error);
}
}
catch (Exception ex)
{
MessageBox . Show("Lỗi khi thêm tiện nghi: " + ex.Message, "Lỗi" ,
MessageBoxButtons .OK, MessageBoxIcon .Error);
}
}
private void btnThoat_Click (object sender , EventArgs e)
{
DialogResult = DialogResult .Cancel;
Close ();
}
}
}
```

#### Bước 9: Click chuột phải vào folder ChiTietTienNghi → Add → Forms( Windows

Forms) → tạo một form để xây dựng giao diện và chức năng cập nhật thông tin 1 tiện
nghi cho một loại phòng trong khách sạn là FormSuaChiTietTienNghi.cs

#### Bước 10: Thiết kế giao diện FormSuaChiTietTienNghi.cs theo mẫu như sau:

Mã nguồn tham khảo trong file FormSuaChiTietTienNghi.Designer.cs tạm thời như
sau:
```csharp
namespace HotelManagement.ChiTietTienNghi
{
partial class FormSuaChiTietTienNghi
{
/// <summary>
/// Required designer variable.
/// </summary>
private System.ComponentModel. IContainer components = null ;
/// <summary>
/// Clean up any resources being used.
/// </summary>
/// <param name="disposing ">true if managed resources should be disposed;
otherwise, false. </param>
protected override void Dispose (bool disposing )
{
if (disposing && (components != null ))
{
components. Dispose ();
}
base . Dispose (disposing );
}
#region Windows Form Designer generated code
/// <summary>
/// Required method for Designer support - do not modify
/// the contents of this method with the code editor.
/// </summary>
private void InitializeComponent ()
{
btnThoat = new Button ();
btnCapNhat = new Button ();
label5 = new Label ();
txtSoLuong = new TextBox ();
label2 = new Label ();
txtTenTN = new TextBox ();
label1 = new Label ();
SuspendLayout ();
//
// btnThoat
//
btnThoat.BackColor = SystemColors .GradientActiveCaption;
btnThoat.Font = new Font ("Microsoft Sans Serif" , 12F, FontStyle .Regular,
GraphicsUnit .Point, 0);
btnThoat.Location = new Point (327, 431);
btnThoat.Margin = new Padding (3, 4, 3, 4);
btnThoat.Name = "btnThoat" ;
btnThoat.Size = new Size (137, 59);
btnThoat.TabIndex = 15;
btnThoat.Text = "Thoát" ;
btnThoat.UseVisualStyleBackColor = false ;
btnThoat.Click += btnThoat_Click ;
//
// btnCapNhat
//
btnCapNhat.BackColor = Color .Moccasin;
btnCapNhat.Font = new Font ("Microsoft Sans Serif" , 12F, FontStyle .Regular,
GraphicsUnit .Point, 0);
btnCapNhat.Location = new Point (127, 431);
btnCapNhat.Margin = new Padding (3, 4, 3, 4);
btnCapNhat.Name = "btnCapNhat" ;
btnCapNhat.Size = new Size (137, 59);
btnCapNhat.TabIndex = 14;
btnCapNhat.Text = "Cập nhật" ;
btnCapNhat.UseVisualStyleBackColor = false ;
btnCapNhat.Click += btnCapNhat_Click ;
//
// label5
//
label5.AutoSize = true ;
label5.Font = new Font ("Microsoft Sans Serif" , 16F, FontStyle .Bold,
GraphicsUnit .Point, 0);
label5.ForeColor = Color . FromArgb (192, 64, 0);
label5.Location = new Point (12, 45);
label5.Name = "label5" ;
label5.Size = new Size (569, 31);
label5.TabIndex = 16;
label5.Text = "Cập nhật thông tin tiện nghi của loại phòng" ;
//
// txtSoLuong
//
txtSoLuong.Font = new Font ("Microsoft Sans Serif" , 12F, FontStyle .Regular,
GraphicsUnit .Point, 0);
txtSoLuong.Location = new Point (253, 294);
txtSoLuong.Margin = new Padding (3, 4, 3, 4);
txtSoLuong.Name = "txtSoLuong" ;
txtSoLuong.Size = new Size (275, 30);
txtSoLuong.TabIndex = 22;
//
// label2
//
label2.AutoSize = true ;
label2.Font = new Font ("Microsoft Sans Serif" , 13F, FontStyle .Regular,
GraphicsUnit .Point, 0);
label2.Location = new Point (126, 294);
label2.Name = "label2" ;
label2.Size = new Size (98, 26);
label2.TabIndex = 21;
label2.Text = "Số lượng" ;
//
// txtTenTN
//
txtTenTN.AcceptsReturn = true ;
txtTenTN.Font = new Font ("Microsoft Sans Serif" , 12F, FontStyle .Regular,
GraphicsUnit .Point, 0);
txtTenTN.Location = new Point (253, 170);
txtTenTN.Margin = new Padding(3, 4, 3, 4);
txtTenTN.Name = "txtTenTN" ;
txtTenTN.ReadOnly = true ;
txtTenTN.Size = new Size (275, 30);
txtTenTN.TabIndex = 20;
//
// label1
//
label1.AutoSize = true ;
label1.Font = new Font ("Microsoft Sans Serif" , 13F, FontStyle .Regular,
GraphicsUnit .Point, 0);
label1.Location = new Point (84, 170);
label1.Name = "label1" ;
label1.Size = new Size (136, 26);
label1.TabIndex = 19;
label1.Text = "Tên tiện nghi" ;
//
// FormSuaChiTietTienNghi
//
AutoScaleDimensions = new SizeF (8F, 20F);
AutoScaleMode = AutoScaleMode .Font;
ClientSize = new Size (613, 576);
Controls. Add(txtSoLuong);
Controls. Add(label2);
Controls. Add(txtTenTN);
Controls. Add(label1);
Controls. Add(label5);
Controls. Add(btnThoat);
Controls. Add(btnCapNhat);
Margin = new Padding(3, 4, 3, 4);
Name = "FormSuaChiTietTienNghi" ;
StartPosition = FormStartPosition .CenterScreen;
Text = "FormSuaChiTietTienNghi" ;
Load += FormSuaChiTietTienNghi_Load;
ResumeLayout (false );
PerformLayout ();
}
#endregion
private System.Windows.Forms. Button btnThoat;
private System.Windows.Forms. Button btnCapNhat;
private System.Windows.Forms. Label label5;
private System.Windows.Forms. TextBox txtSoLuong;
private System.Windows.Forms. Label label2;
private System.Windows.Forms. TextBox txtTenTN;
private System.Windows.Forms. Label label1;
}
}
```

#### Bước 11: SV sử dụng mã nguồn tạm thời sau để xử lý chức năng trong file

FormSuaChiTietTienNghi.cs
```csharp
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HotelManagement.Models;
namespace HotelManagement.ChiTietTienNghi
{
public partial class FormSuaChiTietTienNghi : Form
{
private string maLPH = string .Empty;
private string maTN = string .Empty;
private string tenTN = string .Empty;
private int soLuongHienTai;
public FormSuaChiTietTienNghi ()
{
InitializeComponent ();
}
public FormSuaChiTietTienNghi (string maLPH, string maTN, string tenTN , int
soLuong ) : this ()
{
this .maLPH = maLPH;
this .maTN = maTN;
this .tenTN = tenTN ;
soLuongHienTai = soLuong ;
}
private void FormSuaChiTietTienNghi_Load (object sender , EventArgs e)
{
txtTenTN.ReadOnly = true ;
txtSoLuong.MaxLength = 4;
txtSoLuong.KeyPress += ChiNhapSo ;
if (string .IsNullOrEmpty (maLPH) || string . IsNullOrEmpty (maTN))
{
MessageBox . Show("Không xác định được tiện nghi cần cập nhật!" , "Thông
báo" , MessageBoxButtons .OK, MessageBoxIcon .Warning);
DialogResult = DialogResult .Cancel;
Close ();
return ;
}
txtTenTN.Text = tenTN;
txtSoLuong.Text = soLuongHienTai. ToString ();
txtSoLuong. Focus ();
txtSoLuong. SelectAll ();
}
private void ChiNhapSo (object sender , KeyPressEventArgs e)
{
if (! char . IsControl (e.KeyChar) && ! char . IsDigit (e.KeyChar))
{
e.Handled = true ;
}
}
private void btnCapNhat_Click (object sender , EventArgs e)
{
if (string .IsNullOrWhiteSpace (txtSoLuong.Text))
{
MessageBox . Show("Vui lòng nhập số lượng!" , "Thông báo" ,
MessageBoxButtons .OK, MessageBoxIcon .Warning);
txtSoLuong. Focus ();
return ;
}
if (! int . TryParse (txtSoLuong.Text. Trim (), out int soLuongMoi ) || soLuongMoi
< 0)
{
MessageBox . Show("Vui lòng nhập số hợp lệ!" , "Lỗi" ,
MessageBoxButtons .OK, MessageBoxIcon .Error);
txtSoLuong. Focus ();
return ;
}
try
{
using var db = new HotelManagementContext ();
var chiTiet = db.Cttns. FirstOrDefault (c => c.MaLph == maLPH && c.MaTn
== maTN && c.DaXoa != true );
if (chiTiet == null )
{
MessageBox . Show("Không tìm thấy tiện nghi cần cập nhật!" , "Lỗi" ,
MessageBoxButtons .OK, MessageBoxIcon .Error);
DialogResult = DialogResult .Cancel;
Close ();
return ;
}
chiTiet .Sl = soLuongMoi ;
int kq = db. SaveChanges ();
if (kq > 0)
{
MessageBox . Show("Cập nhật thành công!" , "Thông báo" ,
MessageBoxButtons .OK, MessageBoxIcon .Information);
DialogResult = DialogResult .OK;
Close ();
}
else
{
MessageBox . Show("Không có thay đổi nào để cập nhật!" , "Thông báo" ,
MessageBoxButtons .OK, MessageBoxIcon .Information);
}
}
catch (Exception ex)
{
MessageBox . Show("Lỗi khi cập nhật tiện nghi: " + ex.Message, "Lỗi" ,
MessageBoxButtons .OK, MessageBoxIcon .Error);
}
}
private void btnThoat_Click (object sender , EventArgs e)
{
DialogResult = DialogResult .Cancel;
Close ();
}
}
}
```

#### Bước 12: SV sử dụng mã nguồn sau cập nhật lại mã nguồn trong file

FormDanhSachLoaiPhong.cs để bổ sung thêm chức năng xem chi tiết các tiện nghi
đang có trong loại phòng
```csharp
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClosedXML.Excel;
using HotelManagement.ChiTietTienNghi;
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
hopLuu.FileName =
$"DanhSachLoaiPhong_{DateTime.Now:yyyyMMdd_HHmm}.xlsx";
if (hopLuu.ShowDialog() != DialogResult.OK)
return;
try
{
using (var wb = new XLWorkbook())
{
var ws = wb.Worksheets.Add("Danh sách loại phòng");
string[] tenCot = { "MaLPH", "TenLPH", "SoGiuong",
"SoNguoiToiDa", "GiaNgay", "GiaGio" };
for (int c = 0; c < tenCot.Length; c++)
ws.Cell(1, c + 1).Value =
dtgDanhSachLoaiPhong.Columns[tenCot[c]].HeaderText;
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
var traLoi = MessageBox.Show("Xuất dữ liệu thành công! \nBạn có muốn
mở file ngay không?", "Thông báo",
MessageBoxButtons.YesNo, MessageBoxIcon.Information);
if (traLoi == DialogResult.Yes)
{
System.Diagnostics.Process.Start(
new System.Diagnostics.ProcessStartInfo(hopLuu.FileName) {
UseShellExecute = true });
}
}
catch (IOException)
{
MessageBox.Show("Không ghi được file. Có thể file đang được mở
trong Excel, hãy đóng lại rồi thử lần nữa.",
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
private void dtgDanhSachLoaiPhong_CellClick(object sender,
DataGridViewCellEventArgs e)
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
formSua.MaLoaiPhong = maLPH;
formSua.ShowDialog();
}
LoadLoaiPhong();
}
else if (tenCot == "colTienNghi")
{
using (var formTienNghi = new FormDanhSachChiTietTienNghi(maLPH, tenLPH
?? ""))
{
formTienNghi.ShowDialog();
}
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
dtgDanhSachLoaiPhong.SelectionMode =
DataGridViewSelectionMode.FullRowSelect;
dtgDanhSachLoaiPhong.RowHeadersVisible = false;
dtgDanhSachLoaiPhong.AutoSizeColumnsMode =
DataGridViewAutoSizeColumnsMode.Fill;
dtgDanhSachLoaiPhong.RowTemplate.Height = 40;
dtgDanhSachLoaiPhong.Columns.Add(TaoCotAnh("colIcon", "", _iconGiuong,
50));
dtgDanhSachLoaiPhong.Columns.Add("MaLPH", "Mã loại");
dtgDanhSachLoaiPhong.Columns.Add("TenLPH", "Tên loại");
dtgDanhSachLoaiPhong.Columns.Add("SoGiuong", "Số giường");
dtgDanhSachLoaiPhong.Columns.Add("SoNguoiToiDa", "Số người tối đa");
dtgDanhSachLoaiPhong.Columns.Add("GiaNgay", "Giá ngày");
dtgDanhSachLoaiPhong.Columns.Add("GiaGio", "Giá giờ");
dtgDanhSachLoaiPhong.Columns["GiaNgay"]!.DefaultCellStyle.Format = "N0";
dtgDanhSachLoaiPhong.Columns["GiaGio"]!.DefaultCellStyle.Format = "N0";
dtgDanhSachLoaiPhong.Columns["GiaNgay"]!.DefaultCellStyle.Alignment =
DataGridViewContentAlignment.MiddleRight;
dtgDanhSachLoaiPhong.Columns["GiaGio"]!.DefaultCellStyle.Alignment =
DataGridViewContentAlignment.MiddleRight;
dtgDanhSachLoaiPhong.Columns.Add(TaoCotAnh("colTienNghi", "Tiện nghi",
_iconTienNghi, 60));
dtgDanhSachLoaiPhong.Columns.Add(TaoCotAnh("colSua", "Cập nhật", _iconSua,
70));
}
private DataGridViewImageColumn TaoCotAnh(string ten, string tieuDe, Image anh,
int doRong)
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
|| ma.Contains(keyword,
StringComparison.OrdinalIgnoreCase)
|| ten.Contains(keyword,
StringComparison.OrdinalIgnoreCase);
}
}
}
}
```

### 6. Xây dựng giao diện và chức năng quản lý thông tin đặt phòng tại khách sạn

#### Bước 1: Click chuột phải vào folder SoDoPhong → Add → Forms( Windows Forms)

→ tạo một form cho phép tạo thông tin đặt/thuê phòngtrong khách sạn là
FormDatPhong.cs

#### Bước 2: Thiết kế giao diện FormDatPhong.cs theo mẫu như sau:

**Mã nguồn tham khảo trong file FormDatPhong.Designer.cs tạm thời như sau:**

```csharp
namespace HotelManagement.SoDoPhong
{
partial class FormDatPhong
{
/// <summary>
/// Required designer variable.
/// </summary>
private System.ComponentModel.IContainer components = null;
/// <summary>
/// Clean up any resources being used.
/// </summary>
/// <param name="disposing">true if managed resources should be disposed;
otherwise, false.</param>
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
this.label6 = new System.Windows.Forms.Label();
this.panel1 = new System.Windows.Forms.Panel();
this.label4 = new System.Windows.Forms.Label();
this.cbGioiTinh = new System.Windows.Forms.ComboBox();
this.label7 = new System.Windows.Forms.Label();
this.txtSoDienThoai = new System.Windows.Forms.TextBox();
this.label3 = new System.Windows.Forms.Label();
this.txtQuocTich = new System.Windows.Forms.TextBox();
this.label2 = new System.Windows.Forms.Label();
this.txtCCCD = new System.Windows.Forms.TextBox();
this.label1 = new System.Windows.Forms.Label();
this.txtHoVaTen = new System.Windows.Forms.TextBox();
this.label5 = new System.Windows.Forms.Label();
this.panel2 = new System.Windows.Forms.Panel();
this.label14 = new System.Windows.Forms.Label();
this.label13 = new System.Windows.Forms.Label();
this.dtgDanhSachPhongDaChon = new System.Windows.Forms.DataGridView();
this.dtgDanhSachPhongTrong = new System.Windows.Forms.DataGridView();
this.cbDangGioDi = new System.Windows.Forms.ComboBox();
this.cbGioDi = new System.Windows.Forms.ComboBox();
this.cbDangGioDen = new System.Windows.Forms.ComboBox();
this.cbGioDen = new System.Windows.Forms.ComboBox();
this.label12 = new System.Windows.Forms.Label();
this.label11 = new System.Windows.Forms.Label();
this.dtpNgayKT = new System.Windows.Forms.DateTimePicker();
this.dtpNgayBD = new System.Windows.Forms.DateTimePicker();
this.label10 = new System.Windows.Forms.Label();
this.label9 = new System.Windows.Forms.Label();
this.label8 = new System.Windows.Forms.Label();
this.btnDatPhong = new System.Windows.Forms.Button();
this.button2 = new System.Windows.Forms.Button();
this.panel1.SuspendLayout();
this.panel2.SuspendLayout();
((System.ComponentModel.ISupportInitialize)(this.dtgDanhSachPhongDaChon)).BeginInit();
((System.ComponentModel.ISupportInitialize)(this.dtgDanhSachPhongTrong)).BeginInit();
this.SuspendLayout();
//
// label6
//
this.label6.AutoSize = true;
this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F,
System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
this.label6.ForeColor =
System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))),
((int)(((byte)(192)))));
this.label6.Location = new System.Drawing.Point(515, 9);
this.label6.Name = "label6";
this.label6.Size = new System.Drawing.Size(138, 29);
this.label6.TabIndex = 22;
this.label6.Text = "Đặt phòng";
//
// panel1
//
this.panel1.Controls.Add(this.label4);
this.panel1.Controls.Add(this.cbGioiTinh);
this.panel1.Controls.Add(this.label7);
this.panel1.Controls.Add(this.txtSoDienThoai);
this.panel1.Controls.Add(this.label3);
this.panel1.Controls.Add(this.txtQuocTich);
this.panel1.Controls.Add(this.label2);
this.panel1.Controls.Add(this.txtCCCD);
this.panel1.Controls.Add(this.label1);
this.panel1.Controls.Add(this.txtHoVaTen);
this.panel1.Controls.Add(this.label5);
this.panel1.Location = new System.Drawing.Point(12, 49);
this.panel1.Name = "panel1";
this.panel1.Size = new System.Drawing.Size(465, 413);
this.panel1.TabIndex = 23;
//
// label4
//
this.label4.AutoSize = true;
this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F,
System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
this.label4.ForeColor =
System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))),
((int)(((byte)(0)))));
this.label4.Location = new System.Drawing.Point(119, 23);
this.label4.Name = "label4";
this.label4.Size = new System.Drawing.Size(276, 29);
this.label4.TabIndex = 24;
this.label4.Text = "Thông tin khách hàng";
//
// cbGioiTinh
//
this.cbGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
this.cbGioiTinh.FormattingEnabled = true;
this.cbGioiTinh.Items.AddRange(new object[] {
"Nam",
"Nữ"});
this.cbGioiTinh.Location = new System.Drawing.Point(236, 288);
this.cbGioiTinh.Name = "cbGioiTinh";
this.cbGioiTinh.Size = new System.Drawing.Size(199, 30);
this.cbGioiTinh.TabIndex = 25;
//
// label7
//
this.label7.AutoSize = true;
this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F,
System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
this.label7.Location = new System.Drawing.Point(68, 191);
this.label7.Name = "label7";
this.label7.Size = new System.Drawing.Size(139, 26);
this.label7.TabIndex = 24;
this.label7.Text = "Số điện thoại";
//
// txtSoDienThoai
//
this.txtSoDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif",
12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
this.txtSoDienThoai.Location = new System.Drawing.Point(236, 187);
this.txtSoDienThoai.Name = "txtSoDienThoai";
this.txtSoDienThoai.Size = new System.Drawing.Size(199, 30);
this.txtSoDienThoai.TabIndex = 23;
//
// label3
//
this.label3.AutoSize = true;
this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F,
System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
this.label3.Location = new System.Drawing.Point(115, 292);
this.label3.Name = "label3";
this.label3.Size = new System.Drawing.Size(92, 26);
this.label3.TabIndex = 22;
this.label3.Text = "Giới tính";
//
// txtQuocTich
//
this.txtQuocTich.Font = new System.Drawing.Font("Microsoft Sans Serif",
12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
this.txtQuocTich.Location = new System.Drawing.Point(236, 240);
this.txtQuocTich.Name = "txtQuocTich";
this.txtQuocTich.Size = new System.Drawing.Size(199, 30);
this.txtQuocTich.TabIndex = 21;
//
// label2
//
this.label2.AutoSize = true;
this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F,
System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
this.label2.Location = new System.Drawing.Point(109, 240);
this.label2.Name = "label2";
this.label2.Size = new System.Drawing.Size(104, 26);
this.label2.TabIndex = 20;
this.label2.Text = "Quốc tịch";
//
// txtCCCD
//
this.txtCCCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,
System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
this.txtCCCD.Location = new System.Drawing.Point(236, 135);
this.txtCCCD.Name = "txtCCCD";
this.txtCCCD.Size = new System.Drawing.Size(199, 30);
this.txtCCCD.TabIndex = 19;
//
// label1
//
this.label1.AutoSize = true;
this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F,
System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
this.label1.Location = new System.Drawing.Point( -1, 137);
this.label1.Name = "label1";
this.label1.Size = new System.Drawing.Size(201, 26);
this.label1.TabIndex = 18;
this.label1.Text = "Số CCCD/Passport";
//
// txtHoVaTen
//
this.txtHoVaTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,
System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
this.txtHoVaTen.Location = new System.Drawing.Point(236, 87);
this.txtHoVaTen.Name = "txtHoVaTen";
this.txtHoVaTen.Size = new System.Drawing.Size(199, 30);
this.txtHoVaTen.TabIndex = 17;
//
// label5
//
this.label5.AutoSize = true;
this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F,
System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
this.label5.Location = new System.Drawing.Point(89, 89);
this.label5.Name = "label5";
this.label5.Size = new System.Drawing.Size(105, 26);
this.label5.TabIndex = 16;
this.label5.Text = "Họ và tên";
//
// panel2
//
this.panel2.Controls.Add(this.label14);
this.panel2.Controls.Add(this.label13);
this.panel2.Controls.Add(this.dtgDanhSachPhongDaChon);
this.panel2.Controls.Add(this.dtgDanhSachPhongTrong);
this.panel2.Controls.Add(this.cbDangGioDi);
this.panel2.Controls.Add(this.cbGioDi);
this.panel2.Controls.Add(this.cbDangGioDen);
this.panel2.Controls.Add(this.cbGioDen);
this.panel2.Controls.Add(this.label12);
this.panel2.Controls.Add(this.label11);
this.panel2.Controls.Add(this.dtpNgayKT);
this.panel2.Controls.Add(this.dtpNgayBD);
this.panel2.Controls.Add(this.label10);
this.panel2.Controls.Add(this.label9);
this.panel2.Controls.Add(this.label8);
this.panel2.Location = new System.Drawing.Point(483, 49);
this.panel2.Name = "panel2";
this.panel2.Size = new System.Drawing.Size(796, 521);
this.panel2.TabIndex = 26;
//
// label14
//
this.label14.AutoSize = true;
this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F,
System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
this.label14.ForeColor = System.Drawing.Color.Green;
this.label14.Location = new System.Drawing.Point(440, 199);
this.label14.Name = "label14";
this.label14.Size = new System.Drawing.Size(331, 29);
this.label14.TabIndex = 38;
this.label14.Text = "Danh sách phòng đã chọn";
//
// label13
//
this.label13.AutoSize = true;
this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F,
System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
this.label13.ForeColor = System.Drawing.Color.Green;
this.label13.Location = new System.Drawing.Point(43, 199);
this.label13.Name = "label13";
this.label13.Size = new System.Drawing.Size(296, 29);
this.label13.TabIndex = 26;
this.label13.Text = "Danh sách phòng trống";
//
// dtgDanhSachPhongDaChon
//
this.dtgDanhSachPhongDaChon.ColumnHeadersHeightSizeMode =
System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
this.dtgDanhSachPhongDaChon.Location = new System.Drawing.Point(396, 235);
this.dtgDanhSachPhongDaChon.Name = "dtgDanhSachPhongDaChon";
this.dtgDanhSachPhongDaChon.RowHeadersWidth = 51;
this.dtgDanhSachPhongDaChon.RowTemplate.Height = 24;
this.dtgDanhSachPhongDaChon.Size = new System.Drawing.Size(397, 276);
this.dtgDanhSachPhongDaChon.TabIndex = 37;
//this.dtgDanhSachPhongDaChon.CellClick += new
System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDanhSachPhongDaChon_CellClick
);
//
// dtgDanhSachPhongTrong
//
this.dtgDanhSachPhongTrong.ColumnHeadersHeightSizeMode =
System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
this.dtgDanhSachPhongTrong.Location = new System.Drawing.Point(3, 235);
this.dtgDanhSachPhongTrong.Name = "dtgDanhSachPhongTrong";
this.dtgDanhSachPhongTrong.RowHeadersWidth = 51;
this.dtgDanhSachPhongTrong.RowTemplate.Height = 24;
this.dtgDanhSachPhongTrong.Size = new System.Drawing.Size(373, 276);
this.dtgDanhSachPhongTrong.TabIndex = 36;
//this.dtgDanhSachPhongTrong.CellClick += new
System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDanhSachPhongTrong_CellClick)
;
//
// cbDangGioDi
//
this.cbDangGioDi.FormattingEnabled = true;
this.cbDangGioDi.Items.AddRange(new object[] {
"AM",
"PM"});
this.cbDangGioDi.Location = new System.Drawing.Point(634, 138);
this.cbDangGioDi.Name = "cbDangGioDi";
this.cbDangGioDi.Size = new System.Drawing.Size(55, 24);
this.cbDangGioDi.TabIndex = 35;
//
// cbGioDi
//
this.cbGioDi.FormattingEnabled = true;
this.cbGioDi.Items.AddRange(new object[] {
"01:00",
"01:30",
"02:00",
"02:30",
"03:00",
"03:30",
"04:00",
"04:30",
"05:00",
"05:30",
"06:00",
"06:30",
"07:00",
"07:30",
"08:00",
"08:30",
"09:00",
"09:30",
"10:00",
"10:30",
"11:00",
"11:30",
"12:00",
"12:30"});
this.cbGioDi.Location = new System.Drawing.Point(536, 138);
this.cbGioDi.Name = "cbGioDi";
this.cbGioDi.Size = new System.Drawing.Size(101, 24);
this.cbGioDi.TabIndex = 34;
//
// cbDangGioDen
//
this.cbDangGioDen.FormattingEnabled = true;
this.cbDangGioDen.Items.AddRange(new object[] {
"AM",
"PM"});
this.cbDangGioDen.Location = new System.Drawing.Point(634, 69);
this.cbDangGioDen.Name = "cbDangGioDen";
this.cbDangGioDen.Size = new System.Drawing.Size(55, 24);
this.cbDangGioDen.TabIndex = 33;
//
// cbGioDen
//
this.cbGioDen.FormattingEnabled = true;
this.cbGioDen.Items.AddRange(new object[] {
"01:00",
"01:30",
"02:00",
"02:30",
"03:00",
"03:30",
"04:00",
"04:30",
"05:00",
"05:30",
"06:00",
"06:30",
"07:00",
"07:30",
"08:00",
"08:30",
"09:00",
"09:30",
"10:00",
"10:30",
"11:00",
"11:30",
"12:00",
"12:30"});
this.cbGioDen.Location = new System.Drawing.Point(536, 69);
this.cbGioDen.Name = "cbGioDen";
this.cbGioDen.Size = new System.Drawing.Size(101, 24);
this.cbGioDen.TabIndex = 32;
//
// label12
//
this.label12.AutoSize = true;
this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F,
System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
this.label12.Location = new System.Drawing.Point(463, 138);
this.label12.Name = "label12";
this.label12.Size = new System.Drawing.Size(53, 20);
this.label12.TabIndex = 31;
this.label12.Text = "Giờ đi";
//
// label11
//
this.label11.AutoSize = true;
this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F,
System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
this.label11.Location = new System.Drawing.Point(463, 72);
this.label11.Name = "label11";
this.label11.Size = new System.Drawing.Size(67, 20);
this.label11.TabIndex = 30;
this.label11.Text = "Giờ đến";
//
// dtpNgayKT
//
this.dtpNgayKT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F,
System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
this.dtpNgayKT.Location = new System.Drawing.Point(145, 133);
this.dtpNgayKT.Name = "dtpNgayKT";
this.dtpNgayKT.Size = new System.Drawing.Size(267, 26);
this.dtpNgayKT.TabIndex = 29;
//
// dtpNgayBD
//
this.dtpNgayBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F,
System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
this.dtpNgayBD.Location = new System.Drawing.Point(145, 67);
this.dtpNgayBD.Name = "dtpNgayBD";
this.dtpNgayBD.Size = new System.Drawing.Size(267, 26);
this.dtpNgayBD.TabIndex = 28;
//
// label10
//
this.label10.AutoSize = true;
this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F,
System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
this.label10.Location = new System.Drawing.Point(32, 133);
this.label10.Name = "label10";
this.label10.Size = new System.Drawing.Size(111, 20);
this.label10.TabIndex = 27;
this.label10.Text = "Ngày kết thúc";
//
// label9
//
this.label9.AutoSize = true;
this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F,
System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
this.label9.Location = new System.Drawing.Point(32, 72);
this.label9.Name = "label9";
this.label9.Size = new System.Drawing.Size(107, 20);
this.label9.TabIndex = 26;
this.label9.Text = "Ngày bắt đầu";
//
// label8
//
this.label8.AutoSize = true;
this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F,
System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
this.label8.ForeColor =
System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))),
((int)(((byte)(0)))));
this.label8.Location = new System.Drawing.Point(306, 8);
this.label8.Name = "label8";
this.label8.Size = new System.Drawing.Size(210, 29);
this.label8.TabIndex = 24;
this.label8.Text = "Thông tin phòng";
//
// btnDatPhong
//
this.btnDatPhong.BackColor = System.Drawing.SystemColors.ActiveCaption;
this.btnDatPhong.Font = new System.Drawing.Font("Microsoft Sans Serif",
13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
this.btnDatPhong.ForeColor = System.Drawing.Color.ForestGreen;
this.btnDatPhong.Location = new System.Drawing.Point(45, 496);
this.btnDatPhong.Name = "btnDatPhong";
this.btnDatPhong.Size = new System.Drawing.Size(167, 42);
this.btnDatPhong.TabIndex = 27;
this.btnDatPhong.Text = "Đặt trước";
this.btnDatPhong.UseVisualStyleBackColor = false;
// this.btnDatPhong.Click += new
System.EventHandler(this.btnDatPhong_Click);
//
// button2
//
this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F,
System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
this.button2.Location = new System.Drawing.Point(227, 496);
this.button2.Name = "button2";
this.button2.Size = new System.Drawing.Size(129, 42);
this.button2.TabIndex = 28;
this.button2.Text = "Hủy";
this.button2.UseVisualStyleBackColor = true;
//
// FormDatPhong
//
this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
this.ClientSize = new System.Drawing.Size(1291, 575);
this.Controls.Add(this.button2);
this.Controls.Add(this.btnDatPhong);
this.Controls.Add(this.panel2);
this.Controls.Add(this.panel1);
this.Controls.Add(this.label6);
this.Name = "FormDatPhong";
this.Text = "Đặt phòng trước";
// this.Load += new System.EventHandler(this.FormDatPhong_Load);
this.panel1.ResumeLayout(false);
this.panel1.PerformLayout();
this.panel2.ResumeLayout(false);
this.panel2.PerformLayout();
((System.ComponentModel.ISupportInitialize)(this.dtgDanhSachPhongDaChon)).EndInit();
((System.ComponentModel.ISupportInitialize)(this.dtgDanhSachPhongTrong)).EndInit();
this.ResumeLayout(false);
this.PerformLayout();
}
#endregion
private System.Windows.Forms.Label label6;
private System.Windows.Forms.Panel panel1;
private System.Windows.Forms.Label label4;
private System.Windows.Forms.ComboBox cbGioiTinh;
private System.Windows.Forms.Label label7;
private System.Windows.Forms.TextBox txtSoDienThoai;
private System.Windows.Forms.Label label3;
private System.Windows.Forms.TextBox txtQuocTich;
private System.Windows.Forms.Label label2;
private System.Windows.Forms.TextBox txtCCCD;
private System.Windows.Forms.Label label1;
private System.Windows.Forms.TextBox txtHoVaTen;
private System.Windows.Forms.Label label5;
private System.Windows.Forms.Panel panel2;
private System.Windows.Forms.ComboBox cbDangGioDi;
private System.Windows.Forms.ComboBox cbGioDi;
private System.Windows.Forms.ComboBox cbDangGioDen;
private System.Windows.Forms.ComboBox cbGioDen;
private System.Windows.Forms.Label label12;
private System.Windows.Forms.Label label11;
private System.Windows.Forms.DateTimePicker dtpNgayKT;
private System.Windows.Forms.DateTimePicker dtpNgayBD;
private System.Windows.Forms.Label label10;
private System.Windows.Forms.Label label9;
private System.Windows.Forms.Label label8;
private System.Windows.Forms.DataGridView dtgDanhSachPhongDaChon;
private System.Windows.Forms.DataGridView dtgDanhSachPhongTrong;
private System.Windows.Forms.Button btnDatPhong;
private System.Windows.Forms.Button button2;
private System.Windows.Forms.Label label14;
private System.Windows.Forms.Label label13;
}
}
```

#### Bước 3: SV sử dụng mã nguồn tạm thời sau để xử lý chức năng trong file

FormDatPhong.cs
```csharp
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HotelManagement.DangNhap;
using HotelManagement.Models;
using Microsoft.EntityFrameworkCore;
namespace HotelManagement.SoDoPhong
{
public partial class FormDatPhong : Form
{
private readonly Image _iconThem = Properties.Resources.Add;
private readonly Image _iconHuy = Properties.Resources.delete;
private bool _dangKhoiTao;
public FormDatPhong()
{
InitializeComponent();
StartPosition = FormStartPosition.CenterParent;
FormBorderStyle = FormBorderStyle.FixedDialog;
MaximizeBox = false;
MinimizeBox = false;
CancelButton = button2;
txtHoVaTen.MaxLength = 50;
txtCCCD.MaxLength = 12;
txtSoDienThoai.MaxLength = 10;
txtQuocTich.MaxLength = 30;
cbGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;
cbGioDen.DropDownStyle = ComboBoxStyle.DropDownList;
cbGioDi.DropDownStyle = ComboBoxStyle.DropDownList;
cbDangGioDen.DropDownStyle = ComboBoxStyle.DropDownList;
cbDangGioDi.DropDownStyle = ComboBoxStyle.DropDownList;
txtSoDienThoai.KeyPress += txtSoDienThoai_KeyPress;
txtCCCD.TextChanged += txtCCCD_TextChanged;
dtpNgayBD.ValueChanged += dtpNgayBD_ValueChanged;
dtpNgayKT.ValueChanged += ThayDoiThoiGian;
cbGioDen.SelectedIndexChanged += ThayDoiThoiGian;
cbDangGioDen.SelectedIndexChanged += ThayDoiThoiGian;
cbGioDi.SelectedIndexChanged += ThayDoiThoiGian;
cbDangGioDi.SelectedIndexChanged += ThayDoiThoiGian;
button2.Click += button2_Click;
}
private void FormDatPhong_Load(object sender, EventArgs e)
{
_dangKhoiTao = true;
dtpNgayBD.MinDate = DateTime.Today;
CapNhatNgayKetThucToiThieu();
cbGioDen.SelectedIndex = cbGioDen.FindStringExact("02:00");
cbDangGioDen.SelectedIndex = cbDangGioDen.FindStringExact("PM");
cbGioDi.SelectedIndex = cbGioDi.FindStringExact("12:00");
cbDangGioDi.SelectedIndex = cbDangGioDi.FindStringExact("PM");
KhoiTaoGridPhongTrong();
KhoiTaoGridPhongDaChon();
_dangKhoiTao = false;
LoadDanhSachPhongTrong();
}
private void KhoiTaoGridPhongTrong()
{
if (dtgDanhSachPhongTrong.Columns.Count > 0)
return;
dtgDanhSachPhongTrong.ReadOnly = true;
dtgDanhSachPhongTrong.AllowUserToAddRows = false;
dtgDanhSachPhongTrong.AllowUserToDeleteRows = false;
dtgDanhSachPhongTrong.AllowUserToResizeRows = false;
dtgDanhSachPhongTrong.MultiSelect = false;
dtgDanhSachPhongTrong.SelectionMode =
DataGridViewSelectionMode.FullRowSelect;
dtgDanhSachPhongTrong.RowHeadersVisible = false;
dtgDanhSachPhongTrong.AutoSizeColumnsMode =
DataGridViewAutoSizeColumnsMode.Fill;
dtgDanhSachPhongTrong.RowTemplate.Height = 32;
dtgDanhSachPhongTrong.Columns.Add("MaPH", "Mã phòng");
dtgDanhSachPhongTrong.Columns.Add("TenLPH", "Loại phòng");
dtgDanhSachPhongTrong.Columns.Add("SoNguoiToiDa", "Số người tối đa");
dtgDanhSachPhongTrong.Columns["SoNguoiToiDa"]!.Visible = false;
dtgDanhSachPhongTrong.Columns.Add(TaoCotAnh("Them", "Thêm", _iconThem,
50));
}
private void KhoiTaoGridPhongDaChon()
{
if (dtgDanhSachPhongDaChon.Columns.Count > 0)
return;
dtgDanhSachPhongDaChon.ReadOnly = true;
dtgDanhSachPhongDaChon.AllowUserToAddRows = false;
dtgDanhSachPhongDaChon.AllowUserToDeleteRows = false;
dtgDanhSachPhongDaChon.AllowUserToResizeRows = false;
dtgDanhSachPhongDaChon.MultiSelect = false;
dtgDanhSachPhongDaChon.SelectionMode =
DataGridViewSelectionMode.FullRowSelect;
dtgDanhSachPhongDaChon.RowHeadersVisible = false;
dtgDanhSachPhongDaChon.AutoSizeColumnsMode =
DataGridViewAutoSizeColumnsMode.Fill;
dtgDanhSachPhongDaChon.RowTemplate.Height = 32;
dtgDanhSachPhongDaChon.AutoGenerateColumns = false;
dtgDanhSachPhongDaChon.Columns.Add("MaPhong", "Mã phòng");
dtgDanhSachPhongDaChon.Columns.Add("SoNguoiToiDa", "Số người tối đa");
dtgDanhSachPhongDaChon.Columns.Add("NgayBatDau", "Ngày bắt đầu");
dtgDanhSachPhongDaChon.Columns.Add("NgayKetThuc", "Ngày kết thúc");
dtgDanhSachPhongDaChon.Columns["NgayBatDau"]!.DefaultCellStyle.Format =
"dd/MM/yyyy HH:mm";
dtgDanhSachPhongDaChon.Columns["NgayKetThuc"]!.DefaultCellStyle.Format =
"dd/MM/yyyy HH:mm";
dtgDanhSachPhongDaChon.Columns.Add(TaoCotAnh("Huy", "Hủy", _iconHuy, 45));
}
private DataGridViewImageColumn TaoCotAnh(string ten, string tieuDe, Image anh,
int doRong)
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
private void CapNhatNgayKetThucToiThieu()
{
DateTime toiThieu = dtpNgayBD.Value.Date.AddDays(1);
if (dtpNgayKT.Value.Date < toiThieu)
dtpNgayKT.Value = toiThieu;
dtpNgayKT.MinDate = toiThieu;
}
private void dtpNgayBD_ValueChanged(object? sender, EventArgs e)
{
if (_dangKhoiTao) return;
CapNhatNgayKetThucToiThieu();
LoadDanhSachPhongTrong();
}
private void ThayDoiThoiGian(object? sender, EventArgs e)
{
if (_dangKhoiTao) return;
LoadDanhSachPhongTrong();
}
private void LoadDanhSachPhongTrong()
{
if (_dangKhoiTao) return;
try
{
DateTime checkIn = LayThoiGian(dtpNgayBD, cbGioDen, cbDangGioDen) ??
dtpNgayBD.Value.Date;
DateTime checkOut = LayThoiGian(dtpNgayKT, cbGioDi, cbDangGioDi) ??
dtpNgayKT.Value.Date;
using var db = new HotelManagementContext();
var dsPhongTrong = db.Phongs
.AsNoTracking()
.Where(p => p.DaXoa != true
&& p.Ttph == "Bình thường"
&& !p.Ctdps.Any(c => c.DaXoa != true
&& c.CheckIn < checkOut
&& c.CheckOut > checkIn))
.OrderBy(p => p.MaPh)
.Select(p => new
{
p.MaPh,
TenLph = p.MaLphNavigation.TenLph,
SoNguoiToiDa = p.MaLphNavigation.SoNguoiToiDa
})
.ToList();
dtgDanhSachPhongTrong.Rows.Clear();
foreach (var p in dsPhongTrong)
{
dtgDanhSachPhongTrong.Rows.Add(p.MaPh, p.TenLph, p.SoNguoiToiDa,
_iconThem);
}
dtgDanhSachPhongTrong.CurrentCell = null;
}
catch (Exception ex)
{
MessageBox.Show("Lỗi tải danh sách phòng trống: " + ex.Message, "Lỗi",
MessageBoxButtons.OK, MessageBoxIcon.Error);
}
}
private void dtgDanhSachPhongTrong_CellClick(object sender,
DataGridViewCellEventArgs e)
{
if (e.RowIndex < 0 || e.ColumnIndex < 0)
return;
if (dtgDanhSachPhongTrong.Columns[e.ColumnIndex].Name != "Them")
return;
var dong = dtgDanhSachPhongTrong.Rows[e.RowIndex];
string? maPhong = dong.Cells["MaPH"].Value?.ToString();
if (string.IsNullOrEmpty(maPhong))
return;
foreach (DataGridViewRow daChon in dtgDanhSachPhongDaChon.Rows)
{
if (string.Equals(daChon.Cells["MaPhong"].Value?.ToString(), maPhong,
StringComparison.OrdinalIgnoreCase))
{
MessageBox.Show($"Phòng {maPhong} đã có trong danh sách phòng đã
chọn.", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Information);
return;
}
}
DateTime? checkIn = LayThoiGian(dtpNgayBD, cbGioDen, cbDangGioDen);
DateTime? checkOut = LayThoiGian(dtpNgayKT, cbGioDi, cbDangGioDi);
if (checkIn == null || checkOut == null)
{
MessageBox.Show("Vui lòng chọn đầy đủ giờ đến và giờ đi!", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
return;
}
if (checkOut.Value.Date <= checkIn.Value.Date)
{
MessageBox.Show("Ngày trả phòng phải sau ngày nhận phòng!", "Thông
báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
return;
}
int soNguoiToiDa = Convert.ToInt32(dong.Cells["SoNguoiToiDa"].Value);
dtgDanhSachPhongDaChon.Rows.Add(maPhong, soNguoiToiDa, checkIn.Value,
checkOut.Value, _iconHuy);
}
private DateTime? LayThoiGian(DateTimePicker dtp, ComboBox cbGio, ComboBox
cbAMPM)
{
string? gio = cbGio.SelectedItem?.ToString();
string? ampm = cbAMPM.SelectedItem?.ToString();
if (string.IsNullOrEmpty(gio) || string.IsNullOrEmpty(ampm))
return null;
string[] phan = gio.Split(':');
if (phan.Length != 2 || !int.TryParse(phan[0], out int hour) ||
!int.TryParse(phan[1], out int minute))
return null;
if (ampm == "PM" && hour < 12) hour += 12;
if (ampm == "AM" && hour == 12) hour = 0;
return dtp.Value.Date.AddHours(hour).AddMinutes(minute);
}
private void dtgDanhSachPhongDaChon_CellClick(object sender,
DataGridViewCellEventArgs e)
{
if (e.RowIndex < 0 || e.ColumnIndex < 0)
return;
if (dtgDanhSachPhongDaChon.Columns[e.ColumnIndex].Name == "Huy")
{
dtgDanhSachPhongDaChon.Rows.RemoveAt(e.RowIndex);
}
}
private void txtSoDienThoai_KeyPress(object? sender, KeyPressEventArgs e)
{
if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
e.Handled = true;
}
private void txtCCCD_TextChanged(object? sender, EventArgs e)
{
if (txtHoVaTen.Enabled)
return;
txtHoVaTen.Clear();
txtSoDienThoai.Clear();
txtQuocTich.Clear();
cbGioiTinh.SelectedIndex = -1;
DatChoPhepNhapThongTinKhach(true);
}
private void DatChoPhepNhapThongTinKhach(bool choPhep)
{
txtHoVaTen.Enabled = choPhep;
txtSoDienThoai.Enabled = choPhep;
txtQuocTich.Enabled = choPhep;
cbGioiTinh.Enabled = choPhep;
}
private void button2_Click(object? sender, EventArgs e)
{
DialogResult = DialogResult.Cancel;
this.Close();
}
private bool KiemTraVaDienThongTinKH(string cccd)
{
if (cccd.Length == 0)
return false;
try
{
using var db = new HotelManagementContext();
var khachHang = db.KhachHangs
.AsNoTracking()
.Where(k => k.CccdPassport == cccd && k.DaXoa != true)
.Select(k => new { k.TenKh, k.Sdt, k.QuocTich, k.GioiTinh })
.FirstOrDefault();
if (khachHang == null)
return false;
txtHoVaTen.Text = khachHang.TenKh;
txtSoDienThoai.Text = khachHang.Sdt;
txtQuocTich.Text = khachHang.QuocTich;
cbGioiTinh.SelectedIndex =
cbGioiTinh.FindStringExact(khachHang.GioiTinh ?? "");
DatChoPhepNhapThongTinKhach(false);
return true;
}
catch (Exception ex)
{
MessageBox.Show("Lỗi kiểm tra thông tin khách hàng: " + ex.Message,
"Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
return false;
}
}
private static string TaoMaTiepTheo(IEnumerable<string> cacMa, string tienTo,
int soChuSo, int doDaiToiDa)
{
int lonNhat = 0;
foreach (string ma in cacMa)
{
if (ma.Length > tienTo.Length
&& ma.StartsWith(tienTo, StringComparison.OrdinalIgnoreCase)
&& int.TryParse(ma.Substring(tienTo.Length), out int so)
&& so > lonNhat)
{
lonNhat = so;
}
}
string maMoi = tienTo + (lonNhat + 1).ToString("D" + soChuSo);
if (maMoi.Length > doDaiToiDa)
throw new InvalidOperationException($"Đã hết mã có tiền tố {tienTo}
(tối đa {doDaiToiDa} ký tự).");
return maMoi;
}
private bool LuuPhieuThue()
{
string maNV = FormDangNhap.MaNV_DangNhap;
if (string.IsNullOrWhiteSpace(maNV))
{
MessageBox.Show("Chưa xác định được nhân viên đang đăng nhập. Vui lòng
đăng nhập lại.", "Lỗi",
MessageBoxButtons.OK, MessageBoxIcon.Error);
return false;
}
string tenKH = txtHoVaTen.Text.Trim();
string cccd = txtCCCD.Text.Trim();
string sdt = txtSoDienThoai.Text.Trim();
string quocTich = txtQuocTich.Text.Trim();
string gioiTinh = cbGioiTinh.SelectedItem?.ToString() ?? "";
var cacPhongChon = new List<(string MaPH, int SoNguoi, DateTime CheckIn,
DateTime CheckOut)>();
foreach (DataGridViewRow row in dtgDanhSachPhongDaChon.Rows)
{
if (row.IsNewRow) continue;
cacPhongChon.Add((
row.Cells["MaPhong"].Value?.ToString() ?? "",
Convert.ToInt32(row.Cells["SoNguoiToiDa"].Value),
Convert.ToDateTime(row.Cells["NgayBatDau"].Value),
Convert.ToDateTime(row.Cells["NgayKetThuc"].Value)));
}
try
{
using var db = new HotelManagementContext();
using var giaoDich =
db.Database.BeginTransaction(IsolationLevel.Serializable);
var khachHang = db.KhachHangs.FirstOrDefault(k => k.CccdPassport ==
cccd);
string maKH;
if (khachHang == null)
{
maKH = TaoMaTiepTheo(db.KhachHangs.Select(k => k.MaKh).ToList(),
"KH", 3, 5);
db.KhachHangs.Add(new Models.KhachHang
{
MaKh = maKH,
TenKh = tenKH,
Sdt = sdt,
CccdPassport = cccd,
QuocTich = quocTich,
GioiTinh = gioiTinh,
DaXoa = false
});
}
else
{
maKH = khachHang.MaKh;
if (khachHang.DaXoa == true)
{
khachHang.TenKh = tenKH;
khachHang.Sdt = sdt;
khachHang.QuocTich = quocTich;
khachHang.GioiTinh = gioiTinh;
khachHang.DaXoa = false;
}
}
string maPT = TaoMaTiepTheo(db.PhieuThues.Select(p => p.MaPt).ToList(),
"PT", 3, 5);
db.PhieuThues.Add(new Models.PhieuThue
{
MaPt = maPT,
NgPt = DateTime.Now,
MaKh = maKH,
MaNv = maNV,
DaXoa = false
});
db.SaveChanges();
var cacMaCtdp = db.Ctdps.Select(c => c.MaCtdp).ToList();
var cacPhongCapNhat = new List<Models.Phong>();
foreach (var phongChon in cacPhongChon)
{
string maPH = phongChon.MaPH;
DateTime checkIn = phongChon.CheckIn;
DateTime checkOut = phongChon.CheckOut;
var phong = db.Phongs
.Include(p => p.MaLphNavigation)
.FirstOrDefault(p => p.MaPh == maPH && p.DaXoa != true);
if (phong == null)
{
MessageBox.Show($"Không tìm thấy phòng {maPH}.", "Lỗi",
MessageBoxButtons.OK, MessageBoxIcon.Error);
return false;
}
if (phong.Ttph != "Bình thường")
{
MessageBox.Show($"Phòng {maPH} hiện ở trạng thái
\"{phong.Ttph} \" nên không thể đặt.", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
return false;
}
bool biTrung = db.Ctdps.Any(c => c.MaPh == maPH
&& c.DaXoa != true
&& c.CheckIn < checkOut
&& c.CheckOut > checkIn);
if (biTrung)
{
MessageBox.Show($"Phòng {maPH} đã có người đặt trong khoảng
thời gian này.", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
return false;
}
decimal donGia = phong.MaLphNavigation.GiaNgay;
int soNgay = Math.Max(1, (checkOut.Date - checkIn.Date).Days);
string maCTDP = TaoMaTiepTheo(cacMaCtdp, "CTDP", 3, 7);
cacMaCtdp.Add(maCTDP);
db.Ctdps.Add(new Models.Ctdp
{
MaCtdp = maCTDP,
SoNguoi = phongChon.SoNguoi,
MaPt = maPT,
MaPh = maPH,
CheckIn = checkIn,
CheckOut = checkOut,
TrangThai = "Đã đặt",
DonGia = donGia,
ThanhTien = donGia * soNgay,
DaXoa = false,
TheoGio = false
});
db.SaveChanges();
if (!cacPhongCapNhat.Contains(phong))
cacPhongCapNhat.Add(phong);
}
foreach (var phong in cacPhongCapNhat)
{
phong.Ttph = "Đã đặt";
}
db.SaveChanges();
giaoDich.Commit();
return true;
}
catch (DbUpdateException ex)
{
MessageBox.Show("Có lỗi xảy ra khi lưu phiếu thuê: " +
(ex.InnerException?.Message ?? ex.Message), "Lỗi",
MessageBoxButtons.OK, MessageBoxIcon.Error);
return false;
}
catch (Exception ex)
{
MessageBox.Show("Có lỗi xảy ra khi lưu phiếu thuê: " + ex.Message,
"Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
return false;
}
}
private void btnDatPhong_Click(object sender, EventArgs e)
{
bool khachHangTonTai = KiemTraVaDienThongTinKH(txtCCCD.Text.Trim());
if (khachHangTonTai)
{
DialogResult result = MessageBox.Show(
"Khách hàng đã tồn tại trong hệ thống. Thông tin sẽ được tự động
điền và không thể sửa. \nBạn có muốn tiếp tục đặt phòng không?",
"Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
if (result == DialogResult.No) return;
}
if (txtHoVaTen.Text.Trim().Length == 0)
{
MessageBox.Show("Vui lòng nhập họ và tên khách hàng!", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
txtHoVaTen.Focus();
return;
}
if (txtCCCD.Text.Trim().Length == 0)
{
MessageBox.Show("Vui lòng nhập số CCCD/Passport!", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
txtCCCD.Focus();
return;
}
string sdt = txtSoDienThoai.Text.Trim();
if (sdt.Length == 0 || !sdt.All(char.IsDigit))
{
MessageBox.Show("Vui lòng nhập số điện thoại hợp lệ (chỉ gồm chữ số)!",
"Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
txtSoDienThoai.Focus();
return;
}
if (txtQuocTich.Text.Trim().Length == 0)
{
MessageBox.Show("Vui lòng nhập quốc tịch!", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
txtQuocTich.Focus();
return;
}
if (cbGioiTinh.SelectedIndex == -1)
{
MessageBox.Show("Vui lòng chọn giới tính!", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
cbGioiTinh.Focus();
return;
}
if (dtgDanhSachPhongDaChon.Rows.Count == 0)
{
MessageBox.Show("Vui lòng chọn ít nhất 1 phòng để đặt!", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
return;
}
bool thanhCong = LuuPhieuThue();
if (thanhCong)
{
MessageBox.Show("Đặt phòng thành công!", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Information);
DialogResult = DialogResult.OK;
this.Close();
}
}
}
}
```

#### Bước 4: SV sử dụng mã nguồn tạm thời sau để xử lý chức năng nút đặt phòng thuộc

hàm private void btnDatPhong_Click(object sender, EventArgs e)
trong file FormSoDoPhong.cs
```csharp
private void btnDatPhong_Click (object sender , EventArgs e)
{
string ? maPhong = MaPhongDangChon (); // Phòng đang chọn trong lưới (có thể
null)
using (var fDatPhong = new FormDatPhong ())
{
fDatPhong . ShowDialog ();
}
TaiLaiDanhSach ();
}
```

## IV. Quy định nộp bài thực hành

### 1. Sinh viên cần trình bày bài làm theo file template được GV cung cấp và nộp lại trên hệ

thống LMS theo đúng deadline và các quy định liên quan.

### 2. Không chấp nhận những bài làm có dấu hiệu sao chép giống nhau và sẽ cho 0 điểm bài

LAB của những bài làm này.

---
**----HẾT----**
