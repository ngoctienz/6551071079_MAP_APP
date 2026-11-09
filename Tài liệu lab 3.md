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