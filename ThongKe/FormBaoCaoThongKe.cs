using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ClosedXML.Excel;
using FastReport;
using FastReport.Data;
using HotelManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelManagement.ThongKe
{
    public partial class FormBaoCaoThongKe : Form
    {
        private readonly CultureInfo viVN = new CultureInfo("vi-VN");

        // Dữ liệu phục vụ vẽ biểu đồ GDI+
        private class DuLieuBieuDo
        {
            public string Nhan { get; set; } = string.Empty;
            public decimal GiaTri { get; set; }
        }

        private List<DuLieuBieuDo> _chart1Data = new List<DuLieuBieuDo>();
        private List<DuLieuBieuDo> _chart2Data = new List<DuLieuBieuDo>();

        // Dữ liệu dịch vụ
        private class DongDichVuThongKe
        {
            public string TenDV { get; set; } = string.Empty;
            public int SoLuong { get; set; }
            public decimal DoanhThu { get; set; }
        }

        private List<DongDichVuThongKe> _danhSachDichVu = new List<DongDichVuThongKe>();

        public FormBaoCaoThongKe()
        {
            InitializeComponent();
        }

        private void FormBaoCaoThongKe_Load(object sender, EventArgs e)
        {
            // Tải icon cho các card và ranking
            picCard1.Image = Properties.Resources.DoanhThuThue;
            picCard2.Image = Properties.Resources.DichVuChart;
            picCard3.Image = Properties.Resources.DatPhongChart;
            picTop1.Image = Properties.Resources.top1;
            picTop2.Image = Properties.Resources.top2;
            picTop3.Image = Properties.Resources.top3;

            KhoiTaoLuoiDichVu();

            // Khởi tạo ngày mặc định: lấy từ ngày đầu năm tới ngày hiện tại để bao quát dữ liệu
            try
            {
                using var db = new HotelManagementContext();
                var ngayNhoNhat = db.Ctdps.Where(c => c.DaXoa != true).Select(c => (DateTime?)c.CheckIn).Min();
                if (ngayNhoNhat.HasValue)
                {
                    dtpTuNgay.Value = ngayNhoNhat.Value.Date;
                }
                else
                {
                    dtpTuNgay.Value = new DateTime(DateTime.Now.Year, 1, 1);
                }
            }
            catch
            {
                dtpTuNgay.Value = new DateTime(DateTime.Now.Year, 1, 1);
            }
            dtpDenNgay.Value = DateTime.Today;

            TaiDuLieuThongKe();
        }

        private void KhoiTaoLuoiDichVu()
        {
            dtgDichVu.AutoGenerateColumns = false;
            dtgDichVu.ReadOnly = true;
            dtgDichVu.AllowUserToAddRows = false;
            dtgDichVu.AllowUserToDeleteRows = false;
            dtgDichVu.AllowUserToResizeRows = false;
            dtgDichVu.MultiSelect = false;
            dtgDichVu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgDichVu.RowHeadersVisible = false;
            dtgDichVu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgDichVu.BackgroundColor = Color.White;
            dtgDichVu.BorderStyle = BorderStyle.None;

            dtgDichVu.Columns.Clear();

            dtgDichVu.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TenDV",
                DataPropertyName = "TenDV",
                HeaderText = "Tên dịch vụ",
                FillWeight = 50
            });

            var cotSL = new DataGridViewTextBoxColumn
            {
                Name = "SoLuong",
                DataPropertyName = "SoLuong",
                HeaderText = "Số lượng",
                FillWeight = 25
            };
            cotSL.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgDichVu.Columns.Add(cotSL);

            var cotDT = new DataGridViewTextBoxColumn
            {
                Name = "DoanhThu",
                DataPropertyName = "DoanhThu",
                HeaderText = "Thành tiền",
                FillWeight = 35
            };
            cotDT.DefaultCellStyle.Format = "N0";
            cotDT.DefaultCellStyle.FormatProvider = viVN;
            cotDT.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dtgDichVu.Columns.Add(cotDT);
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            if (dtpTuNgay.Value.Date > dtpDenNgay.Value.Date)
            {
                MessageBox.Show("Từ ngày không thể lớn hơn đến ngày!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            TaiDuLieuThongKe();
        }

        private void TaiDuLieuThongKe()
        {
            DateTime tuNgay = dtpTuNgay.Value.Date;
            DateTime denNgay = dtpDenNgay.Value.Date.AddDays(1);

            try
            {
                using var db = new HotelManagementContext();

                // Lấy danh sách CTDP trong khoảng thời gian
                var dsCtdp = db.Ctdps
                    .AsNoTracking()
                    .Where(c => c.DaXoa != true && c.CheckIn >= tuNgay && c.CheckIn < denNgay)
                    .Select(c => new
                    {
                        c.MaCtdp,
                        c.MaPh,
                        TenLph = c.MaPhNavigation.MaLphNavigation.TenLph,
                        c.ThanhTien
                    })
                    .ToList();

                decimal tongTienPhong = dsCtdp.Sum(c => c.ThanhTien ?? 0);
                int soPhongDat = dsCtdp.Count;

                // Lấy danh sách dịch vụ thuộc các phòng đã lọc
                var listMaCtdp = dsCtdp.Select(c => c.MaCtdp).ToList();
                var dsCtdv = db.Ctdvs
                    .AsNoTracking()
                    .Where(v => v.DaXoa != true && listMaCtdp.Contains(v.MaCtdp))
                    .Select(v => new
                    {
                        v.MaDv,
                        TenDv = v.MaDvNavigation.TenDv,
                        v.Sl,
                        ThanhTien = v.ThanhTien ?? (v.Sl * v.MaDvNavigation.DonGia)
                    })
                    .ToList();

                decimal tongTienDichVu = dsCtdv.Sum(v => v.ThanhTien);

                // Cập nhật 3 KPI Cards
                lblDoanhThuThuePhong.Text = tongTienPhong.ToString("N0", viVN) + " VND";
                lblDoanhThuDichVu.Text = tongTienDichVu.ToString("N0", viVN) + " VND";
                lblSoPhongDat.Text = soPhongDat.ToString("N0", viVN) + " phòng";

                // 1. Loại phòng doanh thu cao nhất & Dữ liệu Chart 1 (Doanh thu thuê phòng theo loại phòng)
                var dtLoaiPhong = dsCtdp
                    .GroupBy(c => c.TenLph ?? "Khác")
                    .Select(g => new DuLieuBieuDo
                    {
                        Nhan = g.Key,
                        GiaTri = g.Sum(c => c.ThanhTien ?? 0)
                    })
                    .OrderByDescending(x => x.GiaTri)
                    .ToList();

                _chart1Data = dtLoaiPhong;

                if (dtLoaiPhong.Count > 0 && dtLoaiPhong[0].GiaTri > 0)
                {
                    lblTop1.Text = $"{dtLoaiPhong[0].Nhan} ({dtLoaiPhong[0].GiaTri.ToString("N0", viVN)} VND)";
                }
                else
                {
                    lblTop1.Text = "Chưa có dữ liệu";
                }

                // 2. Loại phòng được đặt nhiều nhất & Dữ liệu Chart 2 (Số phòng đặt theo loại phòng)
                var slLoaiPhong = dsCtdp
                    .GroupBy(c => c.TenLph ?? "Khác")
                    .Select(g => new DuLieuBieuDo
                    {
                        Nhan = g.Key,
                        GiaTri = g.Count()
                    })
                    .OrderByDescending(x => x.GiaTri)
                    .ToList();

                _chart2Data = slLoaiPhong;

                if (slLoaiPhong.Count > 0 && slLoaiPhong[0].GiaTri > 0)
                {
                    lblTop2.Text = $"{slLoaiPhong[0].Nhan} ({slLoaiPhong[0].GiaTri} lượt)";
                }
                else
                {
                    lblTop2.Text = "Chưa có dữ liệu";
                }

                // 3. Dịch vụ doanh thu cao nhất & Bảng danh sách dịch vụ
                _danhSachDichVu = dsCtdv
                    .GroupBy(v => v.TenDv ?? "Dịch vụ khác")
                    .Select(g => new DongDichVuThongKe
                    {
                        TenDV = g.Key,
                        SoLuong = g.Sum(x => x.Sl),
                        DoanhThu = g.Sum(x => x.ThanhTien)
                    })
                    .OrderByDescending(x => x.DoanhThu)
                    .ToList();

                if (_danhSachDichVu.Count > 0 && _danhSachDichVu[0].DoanhThu > 0)
                {
                    lblTop3.Text = $"{_danhSachDichVu[0].TenDV} ({_danhSachDichVu[0].DoanhThu.ToString("N0", viVN)} VND)";
                }
                else
                {
                    lblTop3.Text = "Chưa có dữ liệu";
                }

                dtgDichVu.DataSource = null;
                dtgDichVu.DataSource = _danhSachDichVu;
                dtgDichVu.ClearSelection();

                // Yêu cầu vẽ lại biểu đồ
                picChart1.Invalidate();
                picChart2.Invalidate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu thống kê: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ================= BIỂU ĐỒ 1: DOANH THU THUÊ PHÒNG (GDI+) =================
        private void picChart1_Paint(object sender, PaintEventArgs e)
        {
            VeBieuDoCot(
                e.Graphics,
                picChart1.ClientRectangle,
                _chart1Data,
                "Doanh thu",
                Color.FromArgb(41, 128, 185),
                Color.FromArgb(109, 179, 242),
                true
            );
        }

        // ================= BIỂU ĐỒ 2: SỐ PHÒNG ĐẶT (GDI+) =================
        private void picChart2_Paint(object sender, PaintEventArgs e)
        {
            VeBieuDoCot(
                e.Graphics,
                picChart2.ClientRectangle,
                _chart2Data,
                "Lượt đặt",
                Color.FromArgb(231, 76, 60),
                Color.FromArgb(245, 183, 177),
                false
            );
        }

        private void VeBieuDoCot(Graphics g, Rectangle bounds, List<DuLieuBieuDo> data, string tenDonVi, Color colorTop, Color colorBottom, bool laTienTe)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;

            // Xóa nền
            using var brushBg = new SolidBrush(Color.White);
            g.FillRectangle(brushBg, bounds);

            if (data == null || data.Count == 0 || data.All(x => x.GiaTri <= 0))
            {
                using var fontEmpty = new Font("Segoe UI", 11F, FontStyle.Italic);
                using var brushEmpty = new SolidBrush(Color.Gray);
                var sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
                g.DrawString("Không có dữ liệu trong khoảng thời gian đã chọn", fontEmpty, brushEmpty, bounds, sf);
                return;
            }

            int marginL = 70;
            int marginR = 25;
            int marginT = 25;
            int marginB = 45;

            int plotW = bounds.Width - marginL - marginR;
            int plotH = bounds.Height - marginT - marginB;

            if (plotW <= 0 || plotH <= 0) return;

            decimal maxVal = data.Max(x => x.GiaTri);
            if (maxVal <= 0) maxVal = 1;

            // Tự làm tròn maxVal lên nấc đẹp
            decimal maxRound = LamTronGiaTriMax(maxVal);

            // Vẽ các đường lưới ngang và nhãn trục Y
            int soNac = 4;
            using var penGrid = new Pen(Color.FromArgb(235, 238, 242), 1) { DashStyle = DashStyle.Dash };
            using var penAxis = new Pen(Color.FromArgb(189, 195, 199), 1);
            using var fontAxis = new Font("Segoe UI", 8.5F, FontStyle.Regular);
            using var brushText = new SolidBrush(Color.FromArgb(100, 110, 120));

            for (int i = 0; i <= soNac; i++)
            {
                float y = marginT + plotH - (float)i * plotH / soNac;
                g.DrawLine(penGrid, marginL, y, marginL + plotW, y);

                decimal valAtNac = maxRound * i / soNac;
                string labelY = laTienTe ? DinhDangTienNgan(valAtNac) : valAtNac.ToString("N0");
                var sfY = new StringFormat { Alignment = StringAlignment.Far, LineAlignment = StringAlignment.Center };
                g.DrawString(labelY, fontAxis, brushText, new RectangleF(0, y - 10, marginL - 8, 20), sfY);
            }

            // Trục tọa độ
            g.DrawLine(penAxis, marginL, marginT, marginL, marginT + plotH);
            g.DrawLine(penAxis, marginL, marginT + plotH, marginL + plotW, marginT + plotH);

            // Vẽ các cột (bars)
            int n = data.Count;
            float slotW = (float)plotW / n;
            float barW = Math.Min(65f, slotW * 0.55f);

            using var fontLabel = new Font("Segoe UI Semibold", 9F);
            using var fontValue = new Font("Segoe UI", 8.5F, FontStyle.Bold);

            for (int i = 0; i < n; i++)
            {
                var item = data[i];
                float centerX = marginL + i * slotW + slotW / 2;
                float barX = centerX - barW / 2;

                float barH = maxRound > 0 ? (float)(item.GiaTri / maxRound) * plotH : 0;
                float barY = marginT + plotH - barH;

                if (barH > 0)
                {
                    var rectBar = new RectangleF(barX, barY, barW, barH);
                    using var brushBar = new LinearGradientBrush(rectBar, colorTop, colorBottom, LinearGradientMode.Vertical);
                    g.FillRectangle(brushBar, rectBar);

                    // Viền cột
                    using var penBarBorder = new Pen(colorTop, 1);
                    g.DrawRectangle(penBarBorder, rectBar.X, rectBar.Y, rectBar.Width, rectBar.Height);

                    // Giá trị trên đầu cột
                    string valText = laTienTe ? item.GiaTri.ToString("N0", viVN) : item.GiaTri.ToString();
                    var sfVal = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Far };
                    g.DrawString(valText, fontValue, brushText, new RectangleF(barX - 25, barY - 20, barW + 50, 18), sfVal);
                }

                // Tên loại phòng dưới trục X
                var sfCat = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Near };
                g.DrawString(item.Nhan, fontLabel, brushText, new RectangleF(centerX - slotW / 2, marginT + plotH + 6, slotW, 35), sfCat);
            }
        }

        private static decimal LamTronGiaTriMax(decimal val)
        {
            if (val <= 5) return 5;
            if (val <= 10) return 10;
            if (val <= 50) return 50;
            if (val <= 100) return 100;

            double v = (double)val;
            double exponent = Math.Floor(Math.Log10(v));
            double power = Math.Pow(10, exponent);
            double fraction = v / power;

            double factor = fraction <= 2 ? 2 : fraction <= 5 ? 5 : 10;
            return (decimal)(factor * power);
        }

        private static string DinhDangTienNgan(decimal val)
        {
            if (val >= 1_000_000)
                return (val / 1_000_000m).ToString("0.#") + "M";
            if (val >= 1_000)
                return (val / 1_000m).ToString("0.#") + "K";
            return val.ToString("N0");
        }

        // ================= XUẤT EXCEL (CLOSEDXML) =================
        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            using var saveDialog = new SaveFileDialog
            {
                Title = "Xuất báo cáo thống kê doanh thu",
                Filter = "Excel Workbook (*.xlsx)|*.xlsx",
                FileName = $"BaoCaoThongKe_{dtpTuNgay.Value:yyyyMMdd}_{dtpDenNgay.Value:yyyyMMdd}.xlsx"
            };

            if (saveDialog.ShowDialog() != DialogResult.OK) return;

            try
            {
                using var workbook = new XLWorkbook();
                var ws = workbook.Worksheets.Add("BaoCaoDoanhThu");

                // Tiêu đề báo cáo
                ws.Cell(1, 1).Value = "BÁO CÁO THỐNG KÊ DOANH THU & HOẠT ĐỘNG KHÁCH SẠN";
                ws.Range(1, 1, 1, 6).Merge().Style
                    .Font.SetBold().Font.SetFontSize(16)
                    .Font.SetFontColor(XLColor.White)
                    .Fill.SetBackgroundColor(XLColor.FromHtml("#2980B9"))
                    .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);

                ws.Cell(2, 1).Value = $"Khoảng thời gian: Từ ngày {dtpTuNgay.Value:dd/MM/yyyy} đến ngày {dtpDenNgay.Value:dd/MM/yyyy}";
                ws.Range(2, 1, 2, 6).Merge().Style
                    .Font.SetItalic().Font.SetFontSize(11)
                    .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);

                // BẢNG 1: CHỈ SỐ KPI TỔNG QUAN
                ws.Cell(4, 1).Value = "1. CHỈ SỐ TỔNG QUAN";
                ws.Range(4, 1, 4, 3).Merge().Style.Font.SetBold().Font.SetFontSize(12).Font.SetFontColor(XLColor.DarkBlue);

                ws.Cell(5, 1).Value = "Chỉ số";
                ws.Cell(5, 2).Value = "Giá trị";
                ws.Range(5, 1, 5, 2).Style.Font.SetBold().Fill.SetBackgroundColor(XLColor.LightGray);

                ws.Cell(6, 1).Value = "Doanh thu thuê phòng";
                ws.Cell(6, 2).Value = lblDoanhThuThuePhong.Text;

                ws.Cell(7, 1).Value = "Doanh thu dịch vụ";
                ws.Cell(7, 2).Value = lblDoanhThuDichVu.Text;

                ws.Cell(8, 1).Value = "Tổng số phòng đã đặt/thuê";
                ws.Cell(8, 2).Value = lblSoPhongDat.Text;

                ws.Range(5, 1, 8, 2).Style.Border.SetOutsideBorder(XLBorderStyleValues.Thin).Border.SetInsideBorder(XLBorderStyleValues.Thin);

                // BẢNG 2: XẾP HẠNG TOP
                ws.Cell(10, 1).Value = "2. XẾP HẠNG NỔI BẬT";
                ws.Range(10, 1, 10, 3).Merge().Style.Font.SetBold().Font.SetFontSize(12).Font.SetFontColor(XLColor.DarkBlue);

                ws.Cell(11, 1).Value = "Hạng mục";
                ws.Cell(11, 2).Value = "Nội dung nổi bật";
                ws.Range(11, 1, 11, 2).Style.Font.SetBold().Fill.SetBackgroundColor(XLColor.LightGray);

                ws.Cell(12, 1).Value = "Loại phòng doanh thu cao nhất";
                ws.Cell(12, 2).Value = lblTop1.Text;

                ws.Cell(13, 1).Value = "Phòng được đặt nhiều nhất";
                ws.Cell(13, 2).Value = lblTop2.Text;

                ws.Cell(14, 1).Value = "Dịch vụ doanh thu cao nhất";
                ws.Cell(14, 2).Value = lblTop3.Text;

                ws.Range(11, 1, 14, 2).Style.Border.SetOutsideBorder(XLBorderStyleValues.Thin).Border.SetInsideBorder(XLBorderStyleValues.Thin);

                // BẢNG 3: DOANH THU & LƯỢT ĐẶT THEO LOẠI PHÒNG
                ws.Cell(16, 1).Value = "3. CHI TIẾT THEO LOẠI PHÒNG";
                ws.Range(16, 1, 16, 3).Merge().Style.Font.SetBold().Font.SetFontSize(12).Font.SetFontColor(XLColor.DarkBlue);

                ws.Cell(17, 1).Value = "Tên loại phòng";
                ws.Cell(17, 2).Value = "Số lượt đặt";
                ws.Cell(17, 3).Value = "Doanh thu (VND)";
                ws.Range(17, 1, 17, 3).Style.Font.SetBold().Fill.SetBackgroundColor(XLColor.LightGray);

                int r = 18;
                foreach (var item in _chart1Data)
                {
                    var slItem = _chart2Data.FirstOrDefault(x => x.Nhan == item.Nhan);
                    ws.Cell(r, 1).Value = item.Nhan;
                    ws.Cell(r, 2).Value = slItem != null ? slItem.GiaTri : 0;
                    ws.Cell(r, 2).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                    ws.Cell(r, 3).Value = item.GiaTri;
                    ws.Cell(r, 3).Style.NumberFormat.Format = "#,##0";
                    r++;
                }
                ws.Range(17, 1, r - 1, 3).Style.Border.SetOutsideBorder(XLBorderStyleValues.Thin).Border.SetInsideBorder(XLBorderStyleValues.Thin);

                // BẢNG 4: DANH SÁCH DỊCH VỤ ĐÃ DÙNG
                r++;
                ws.Cell(r, 1).Value = "4. CHI TIẾT DỊCH VỤ SỬ DỤNG";
                ws.Range(r, 1, r, 3).Merge().Style.Font.SetBold().Font.SetFontSize(12).Font.SetFontColor(XLColor.DarkBlue);

                r++;
                int rStartDV = r;
                ws.Cell(r, 1).Value = "Tên dịch vụ";
                ws.Cell(r, 2).Value = "Số lượng đã dùng";
                ws.Cell(r, 3).Value = "Doanh thu (VND)";
                ws.Range(r, 1, r, 3).Style.Font.SetBold().Fill.SetBackgroundColor(XLColor.LightGray);

                r++;
                foreach (var dv in _danhSachDichVu)
                {
                    ws.Cell(r, 1).Value = dv.TenDV;
                    ws.Cell(r, 2).Value = dv.SoLuong;
                    ws.Cell(r, 2).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                    ws.Cell(r, 3).Value = dv.DoanhThu;
                    ws.Cell(r, 3).Style.NumberFormat.Format = "#,##0";
                    r++;
                }
                ws.Range(rStartDV, 1, r - 1, 3).Style.Border.SetOutsideBorder(XLBorderStyleValues.Thin).Border.SetInsideBorder(XLBorderStyleValues.Thin);

                ws.Columns().AdjustToContents();
                workbook.SaveAs(saveDialog.FileName);

                var hoi = MessageBox.Show("Xuất file Excel thành công! Bạn có muốn mở file vừa xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (hoi == DialogResult.Yes)
                {
                    Process.Start(new ProcessStartInfo(saveDialog.FileName) { UseShellExecute = true });
                }
            }
            catch (IOException)
            {
                MessageBox.Show("Không thể ghi file. File có thể đang được mở trong Excel, vui lòng đóng lại và thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xuất file Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ================= IN BÁO CÁO (FASTREPORT.NET.DEMO) =================
        private void btnInBaoCao_Click(object sender, EventArgs e)
        {
            try
            {
                using var report = new Report();

                // Tạo DataSet cung cấp dữ liệu cho FastReport
                var ds = new DataSet("HotelData");

                // Bảng thông tin chung
                var dtThongTin = new DataTable("ThongTinChung");
                dtThongTin.Columns.Add("TuNgay", typeof(string));
                dtThongTin.Columns.Add("DenNgay", typeof(string));
                dtThongTin.Columns.Add("DoanhThuPhong", typeof(string));
                dtThongTin.Columns.Add("DoanhThuDichVu", typeof(string));
                dtThongTin.Columns.Add("SoPhongDat", typeof(string));
                dtThongTin.Columns.Add("Top1LoaiPhong", typeof(string));
                dtThongTin.Columns.Add("Top2PhongDat", typeof(string));
                dtThongTin.Columns.Add("Top3DichVu", typeof(string));

                dtThongTin.Rows.Add(
                    dtpTuNgay.Value.ToString("dd/MM/yyyy"),
                    dtpDenNgay.Value.ToString("dd/MM/yyyy"),
                    lblDoanhThuThuePhong.Text,
                    lblDoanhThuDichVu.Text,
                    lblSoPhongDat.Text,
                    lblTop1.Text,
                    lblTop2.Text,
                    lblTop3.Text
                );
                ds.Tables.Add(dtThongTin);

                // Bảng loại phòng
                var dtLoaiPhong = new DataTable("LoaiPhong");
                dtLoaiPhong.Columns.Add("TenLoaiPhong", typeof(string));
                dtLoaiPhong.Columns.Add("SoLuot", typeof(int));
                dtLoaiPhong.Columns.Add("DoanhThu", typeof(decimal));

                foreach (var lp in _chart1Data)
                {
                    var sl = _chart2Data.FirstOrDefault(x => x.Nhan == lp.Nhan);
                    dtLoaiPhong.Rows.Add(lp.Nhan, sl != null ? (int)sl.GiaTri : 0, lp.GiaTri);
                }
                ds.Tables.Add(dtLoaiPhong);

                // Bảng dịch vụ
                var dtDichVu = new DataTable("DichVu");
                dtDichVu.Columns.Add("TenDV", typeof(string));
                dtDichVu.Columns.Add("SoLuong", typeof(int));
                dtDichVu.Columns.Add("DoanhThu", typeof(decimal));

                foreach (var dv in _danhSachDichVu)
                {
                    dtDichVu.Rows.Add(dv.TenDV, dv.SoLuong, dv.DoanhThu);
                }
                ds.Tables.Add(dtDichVu);

                // Đăng ký dữ liệu vào FastReport
                report.RegisterData(ds, "HotelData");
                report.GetDataSource("ThongTinChung").Enabled = true;
                report.GetDataSource("LoaiPhong").Enabled = true;
                report.GetDataSource("DichVu").Enabled = true;

                // Xây dựng trang báo cáo động
                var page = new ReportPage();
                report.Pages.Add(page);

                // Report Title Band
                var titleBand = new ReportTitleBand { Height = 220 };
                page.ReportTitle = titleBand;

                var txtTieuDe = new TextObject
                {
                    Bounds = new RectangleF(0, 10, 718, 40),
                    Text = "BÁO CÁO THỐNG KÊ TÌNH HÌNH KINH DOANH",
                    Font = new Font("Segoe UI", 16F, FontStyle.Bold),
                    HorzAlign = HorzAlign.Center,
                    TextColor = Color.DarkBlue
                };
                titleBand.Objects.Add(txtTieuDe);

                var txtNgay = new TextObject
                {
                    Bounds = new RectangleF(0, 50, 718, 25),
                    Text = $"Khoảng thời gian: Từ ngày {dtpTuNgay.Value:dd/MM/yyyy} đến ngày {dtpDenNgay.Value:dd/MM/yyyy}",
                    Font = new Font("Segoe UI", 11F, FontStyle.Italic),
                    HorzAlign = HorzAlign.Center
                };
                titleBand.Objects.Add(txtNgay);

                // Thông tin tổng hợp KPI
                var txtKpi = new TextObject
                {
                    Bounds = new RectangleF(20, 85, 680, 65),
                    Text = $"• Doanh thu thuê phòng: {lblDoanhThuThuePhong.Text}\n" +
                           $"• Doanh thu dịch vụ: {lblDoanhThuDichVu.Text}\n" +
                           $"• Tổng số phòng đã đặt: {lblSoPhongDat.Text}",
                    Font = new Font("Segoe UI", 10.5F),
                    Border = new Border { Lines = BorderLines.All, Color = Color.LightGray }
                };
                titleBand.Objects.Add(txtKpi);

                // Xếp hạng nổi bật
                var txtRank = new TextObject
                {
                    Bounds = new RectangleF(20, 155, 680, 60),
                    Text = $"• Loại phòng doanh thu cao nhất: {lblTop1.Text}\n" +
                           $"• Phòng được đặt nhiều nhất: {lblTop2.Text}\n" +
                           $"• Dịch vụ doanh thu cao nhất: {lblTop3.Text}",
                    Font = new Font("Segoe UI", 10F, FontStyle.Italic),
                    TextColor = Color.FromArgb(44, 62, 80)
                };
                titleBand.Objects.Add(txtRank);

                // Header cho bảng dịch vụ
                var pageHeader = new PageHeaderBand { Height = 30 };
                page.PageHeader = pageHeader;

                var th1 = new TextObject { Bounds = new RectangleF(20, 5, 340, 25), Text = "Tên dịch vụ sử dụng", Font = new Font("Segoe UI", 10F, FontStyle.Bold), FillColor = Color.LightGray };
                var th2 = new TextObject { Bounds = new RectangleF(360, 5, 140, 25), Text = "Số lượng", Font = new Font("Segoe UI", 10F, FontStyle.Bold), HorzAlign = HorzAlign.Center, FillColor = Color.LightGray };
                var th3 = new TextObject { Bounds = new RectangleF(500, 5, 200, 25), Text = "Doanh thu (VND)", Font = new Font("Segoe UI", 10F, FontStyle.Bold), HorzAlign = HorzAlign.Right, FillColor = Color.LightGray };
                pageHeader.Objects.Add(th1);
                pageHeader.Objects.Add(th2);
                pageHeader.Objects.Add(th3);

                // DataBand cho Dịch vụ
                var dataBand = new DataBand
                {
                    Height = 25,
                    DataSource = report.GetDataSource("DichVu")
                };
                page.Bands.Add(dataBand);

                var td1 = new TextObject { Bounds = new RectangleF(20, 0, 340, 25), Text = "[DichVu.TenDV]", Font = new Font("Segoe UI", 9.5F) };
                var td2 = new TextObject { Bounds = new RectangleF(360, 0, 140, 25), Text = "[DichVu.SoLuong]", Font = new Font("Segoe UI", 9.5F), HorzAlign = HorzAlign.Center };
                var td3 = new TextObject { Bounds = new RectangleF(500, 0, 200, 25), Text = "[DichVu.DoanhThu]", Format = new FastReport.Format.CurrencyFormat { UseLocale = true, DecimalDigits = 0 }, Font = new Font("Segoe UI", 9.5F), HorzAlign = HorzAlign.Right };
                dataBand.Objects.Add(td1);
                dataBand.Objects.Add(td2);
                dataBand.Objects.Add(td3);

                // Hiển thị giao diện xem trước và in báo cáo FastReport
                report.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi mở FastReport: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
