namespace HotelManagement.ThongKe
{
    partial class FormBaoCaoThongKe
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
            pnlHeader = new Panel();
            btnInBaoCao = new Button();
            btnXuatExcel = new Button();
            btnThongKe = new Button();
            dtpDenNgay = new DateTimePicker();
            label2 = new Label();
            dtpTuNgay = new DateTimePicker();
            label1 = new Label();
            pnlCard1 = new Panel();
            lblDoanhThuThuePhong = new Label();
            label3 = new Label();
            picCard1 = new PictureBox();
            pnlCard2 = new Panel();
            lblDoanhThuDichVu = new Label();
            label5 = new Label();
            picCard2 = new PictureBox();
            pnlCard3 = new Panel();
            lblSoPhongDat = new Label();
            label7 = new Label();
            picCard3 = new PictureBox();
            pnlRankings = new Panel();
            lblTop3 = new Label();
            label11 = new Label();
            picTop3 = new PictureBox();
            lblTop2 = new Label();
            label9 = new Label();
            picTop2 = new PictureBox();
            lblTop1 = new Label();
            label6 = new Label();
            picTop1 = new PictureBox();
            label4 = new Label();
            pnlServices = new Panel();
            dtgDichVu = new DataGridView();
            label8 = new Label();
            pnlChart1 = new Panel();
            picChart1 = new PictureBox();
            label10 = new Label();
            pnlChart2 = new Panel();
            picChart2 = new PictureBox();
            label12 = new Label();
            pnlHeader.SuspendLayout();
            pnlCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCard1).BeginInit();
            pnlCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCard2).BeginInit();
            pnlCard3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCard3).BeginInit();
            pnlRankings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picTop3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picTop2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picTop1).BeginInit();
            pnlServices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgDichVu).BeginInit();
            pnlChart1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picChart1).BeginInit();
            pnlChart2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picChart2).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlHeader.BackColor = Color.White;
            pnlHeader.BorderStyle = BorderStyle.FixedSingle;
            pnlHeader.Controls.Add(btnInBaoCao);
            pnlHeader.Controls.Add(btnXuatExcel);
            pnlHeader.Controls.Add(btnThongKe);
            pnlHeader.Controls.Add(dtpDenNgay);
            pnlHeader.Controls.Add(label2);
            pnlHeader.Controls.Add(dtpTuNgay);
            pnlHeader.Controls.Add(label1);
            pnlHeader.Location = new Point(14, 12);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1174, 52);
            pnlHeader.TabIndex = 0;
            // 
            // btnInBaoCao
            // 
            btnInBaoCao.BackColor = Color.FromArgb(230, 126, 34);
            btnInBaoCao.Cursor = Cursors.Hand;
            btnInBaoCao.FlatAppearance.BorderSize = 0;
            btnInBaoCao.FlatStyle = FlatStyle.Flat;
            btnInBaoCao.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnInBaoCao.ForeColor = Color.White;
            btnInBaoCao.Location = new Point(946, 8);
            btnInBaoCao.Name = "btnInBaoCao";
            btnInBaoCao.Size = new Size(210, 34);
            btnInBaoCao.TabIndex = 6;
            btnInBaoCao.Text = "In báo cáo FastReport";
            btnInBaoCao.UseVisualStyleBackColor = false;
            btnInBaoCao.Click += btnInBaoCao_Click;
            // 
            // btnXuatExcel
            // 
            btnXuatExcel.BackColor = Color.FromArgb(46, 139, 87);
            btnXuatExcel.Cursor = Cursors.Hand;
            btnXuatExcel.FlatAppearance.BorderSize = 0;
            btnXuatExcel.FlatStyle = FlatStyle.Flat;
            btnXuatExcel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnXuatExcel.ForeColor = Color.White;
            btnXuatExcel.Location = new Point(788, 8);
            btnXuatExcel.Name = "btnXuatExcel";
            btnXuatExcel.Size = new Size(148, 34);
            btnXuatExcel.TabIndex = 5;
            btnXuatExcel.Text = "Xuất Excel";
            btnXuatExcel.UseVisualStyleBackColor = false;
            btnXuatExcel.Click += btnXuatExcel_Click;
            // 
            // btnThongKe
            // 
            btnThongKe.BackColor = Color.FromArgb(41, 128, 185);
            btnThongKe.Cursor = Cursors.Hand;
            btnThongKe.FlatAppearance.BorderSize = 0;
            btnThongKe.FlatStyle = FlatStyle.Flat;
            btnThongKe.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnThongKe.ForeColor = Color.White;
            btnThongKe.Location = new Point(640, 8);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(138, 34);
            btnThongKe.TabIndex = 4;
            btnThongKe.Text = "Thống kê";
            btnThongKe.UseVisualStyleBackColor = false;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.CalendarFont = new Font("Segoe UI", 10F);
            dtpDenNgay.Font = new Font("Segoe UI", 10.5F);
            dtpDenNgay.Format = DateTimePickerFormat.Short;
            dtpDenNgay.Location = new Point(446, 11);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new Size(165, 31);
            dtpDenNgay.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(344, 14);
            label2.Name = "label2";
            label2.Size = new Size(96, 25);
            label2.TabIndex = 2;
            label2.Text = "Đến ngày:";
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.CalendarFont = new Font("Segoe UI", 10F);
            dtpTuNgay.Font = new Font("Segoe UI", 10.5F);
            dtpTuNgay.Format = DateTimePickerFormat.Short;
            dtpTuNgay.Location = new Point(102, 11);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new Size(165, 31);
            dtpTuNgay.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(14, 14);
            label1.Name = "label1";
            label1.Size = new Size(82, 25);
            label1.TabIndex = 0;
            label1.Text = "Từ ngày:";
            // 
            // pnlCard1
            // 
            pnlCard1.BackColor = Color.White;
            pnlCard1.BorderStyle = BorderStyle.FixedSingle;
            pnlCard1.Controls.Add(lblDoanhThuThuePhong);
            pnlCard1.Controls.Add(label3);
            pnlCard1.Controls.Add(picCard1);
            pnlCard1.Location = new Point(14, 73);
            pnlCard1.Name = "pnlCard1";
            pnlCard1.Size = new Size(375, 86);
            pnlCard1.TabIndex = 1;
            // 
            // lblDoanhThuThuePhong
            // 
            lblDoanhThuThuePhong.AutoSize = true;
            lblDoanhThuThuePhong.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblDoanhThuThuePhong.ForeColor = Color.FromArgb(192, 0, 0);
            lblDoanhThuThuePhong.Location = new Point(88, 40);
            lblDoanhThuThuePhong.Name = "lblDoanhThuThuePhong";
            lblDoanhThuThuePhong.Size = new Size(91, 35);
            lblDoanhThuThuePhong.TabIndex = 2;
            lblDoanhThuThuePhong.Text = "0 VND";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(88, 12);
            label3.Name = "label3";
            label3.Size = new Size(204, 25);
            label3.TabIndex = 1;
            label3.Text = "Doanh thu thuê phòng";
            // 
            // picCard1
            // 
            picCard1.Location = new Point(14, 12);
            picCard1.Name = "picCard1";
            picCard1.Size = new Size(62, 62);
            picCard1.SizeMode = PictureBoxSizeMode.Zoom;
            picCard1.TabIndex = 0;
            picCard1.TabStop = false;
            // 
            // pnlCard2
            // 
            pnlCard2.BackColor = Color.White;
            pnlCard2.BorderStyle = BorderStyle.FixedSingle;
            pnlCard2.Controls.Add(lblDoanhThuDichVu);
            pnlCard2.Controls.Add(label5);
            pnlCard2.Controls.Add(picCard2);
            pnlCard2.Location = new Point(413, 73);
            pnlCard2.Name = "pnlCard2";
            pnlCard2.Size = new Size(375, 86);
            pnlCard2.TabIndex = 2;
            // 
            // lblDoanhThuDichVu
            // 
            lblDoanhThuDichVu.AutoSize = true;
            lblDoanhThuDichVu.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblDoanhThuDichVu.ForeColor = Color.FromArgb(0, 102, 204);
            lblDoanhThuDichVu.Location = new Point(88, 40);
            lblDoanhThuDichVu.Name = "lblDoanhThuDichVu";
            lblDoanhThuDichVu.Size = new Size(91, 35);
            lblDoanhThuDichVu.TabIndex = 2;
            lblDoanhThuDichVu.Text = "0 VND";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            label5.ForeColor = Color.Gray;
            label5.Location = new Point(88, 12);
            label5.Name = "label5";
            label5.Size = new Size(164, 25);
            label5.TabIndex = 1;
            label5.Text = "Doanh thu dịch vụ";
            // 
            // picCard2
            // 
            picCard2.Location = new Point(14, 12);
            picCard2.Name = "picCard2";
            picCard2.Size = new Size(62, 62);
            picCard2.SizeMode = PictureBoxSizeMode.Zoom;
            picCard2.TabIndex = 0;
            picCard2.TabStop = false;
            // 
            // pnlCard3
            // 
            pnlCard3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlCard3.BackColor = Color.White;
            pnlCard3.BorderStyle = BorderStyle.FixedSingle;
            pnlCard3.Controls.Add(lblSoPhongDat);
            pnlCard3.Controls.Add(label7);
            pnlCard3.Controls.Add(picCard3);
            pnlCard3.Location = new Point(812, 73);
            pnlCard3.Name = "pnlCard3";
            pnlCard3.Size = new Size(376, 86);
            pnlCard3.TabIndex = 3;
            // 
            // lblSoPhongDat
            // 
            lblSoPhongDat.AutoSize = true;
            lblSoPhongDat.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblSoPhongDat.ForeColor = Color.FromArgb(39, 174, 96);
            lblSoPhongDat.Location = new Point(88, 40);
            lblSoPhongDat.Name = "lblSoPhongDat";
            lblSoPhongDat.Size = new Size(106, 35);
            lblSoPhongDat.TabIndex = 2;
            lblSoPhongDat.Text = "0 phòng";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            label7.ForeColor = Color.Gray;
            label7.Location = new Point(88, 12);
            label7.Name = "label7";
            label7.Size = new Size(126, 25);
            label7.TabIndex = 1;
            label7.Text = "Số phòng đặt";
            // 
            // picCard3
            // 
            picCard3.Location = new Point(14, 12);
            picCard3.Name = "picCard3";
            picCard3.Size = new Size(62, 62);
            picCard3.SizeMode = PictureBoxSizeMode.Zoom;
            picCard3.TabIndex = 0;
            picCard3.TabStop = false;
            // 
            // pnlRankings
            // 
            pnlRankings.BackColor = Color.White;
            pnlRankings.BorderStyle = BorderStyle.FixedSingle;
            pnlRankings.Controls.Add(lblTop3);
            pnlRankings.Controls.Add(label11);
            pnlRankings.Controls.Add(picTop3);
            pnlRankings.Controls.Add(lblTop2);
            pnlRankings.Controls.Add(label9);
            pnlRankings.Controls.Add(picTop2);
            pnlRankings.Controls.Add(lblTop1);
            pnlRankings.Controls.Add(label6);
            pnlRankings.Controls.Add(picTop1);
            pnlRankings.Controls.Add(label4);
            pnlRankings.Location = new Point(14, 171);
            pnlRankings.Name = "pnlRankings";
            pnlRankings.Size = new Size(410, 290);
            pnlRankings.TabIndex = 4;
            // 
            // lblTop3
            // 
            lblTop3.AutoSize = true;
            lblTop3.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblTop3.ForeColor = Color.FromArgb(142, 68, 173);
            lblTop3.Location = new Point(62, 240);
            lblTop3.Name = "lblTop3";
            lblTop3.Size = new Size(100, 25);
            lblTop3.TabIndex = 9;
            lblTop3.Text = "Chưa có dữ liệu";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.5F);
            label11.ForeColor = Color.FromArgb(64, 64, 64);
            label11.Location = new Point(62, 215);
            label11.Name = "label11";
            label11.Size = new Size(204, 21);
            label11.TabIndex = 8;
            label11.Text = "Dịch vụ doanh thu cao nhất:";
            // 
            // picTop3
            // 
            picTop3.Location = new Point(14, 216);
            picTop3.Name = "picTop3";
            picTop3.Size = new Size(40, 40);
            picTop3.SizeMode = PictureBoxSizeMode.Zoom;
            picTop3.TabIndex = 7;
            picTop3.TabStop = false;
            // 
            // lblTop2
            // 
            lblTop2.AutoSize = true;
            lblTop2.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblTop2.ForeColor = Color.FromArgb(41, 128, 185);
            lblTop2.Location = new Point(62, 155);
            lblTop2.Name = "lblTop2";
            lblTop2.Size = new Size(100, 25);
            lblTop2.TabIndex = 6;
            lblTop2.Text = "Chưa có dữ liệu";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.5F);
            label9.ForeColor = Color.FromArgb(64, 64, 64);
            label9.Location = new Point(62, 130);
            label9.Name = "label9";
            label9.Size = new Size(183, 21);
            label9.TabIndex = 5;
            label9.Text = "Phòng được đặt nhiều nhất:";
            // 
            // picTop2
            // 
            picTop2.Location = new Point(14, 131);
            picTop2.Name = "picTop2";
            picTop2.Size = new Size(40, 40);
            picTop2.SizeMode = PictureBoxSizeMode.Zoom;
            picTop2.TabIndex = 4;
            picTop2.TabStop = false;
            // 
            // lblTop1
            // 
            lblTop1.AutoSize = true;
            lblTop1.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblTop1.ForeColor = Color.FromArgb(192, 0, 0);
            lblTop1.Location = new Point(62, 70);
            lblTop1.Name = "lblTop1";
            lblTop1.Size = new Size(100, 25);
            lblTop1.TabIndex = 3;
            lblTop1.Text = "Chưa có dữ liệu";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.5F);
            label6.ForeColor = Color.FromArgb(64, 64, 64);
            label6.Location = new Point(62, 45);
            label6.Name = "label6";
            label6.Size = new Size(225, 21);
            label6.TabIndex = 2;
            label6.Text = "Loại phòng doanh thu cao nhất:";
            // 
            // picTop1
            // 
            picTop1.Location = new Point(14, 46);
            picTop1.Name = "picTop1";
            picTop1.Size = new Size(40, 40);
            picTop1.SizeMode = PictureBoxSizeMode.Zoom;
            picTop1.TabIndex = 1;
            picTop1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.5F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(30, 30, 30);
            label4.Location = new Point(14, 10);
            label4.Name = "label4";
            label4.Size = new Size(227, 28);
            label4.TabIndex = 0;
            label4.Text = "XẾP HẠNG & NỔI BẬT";
            // 
            // pnlServices
            // 
            pnlServices.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pnlServices.BackColor = Color.White;
            pnlServices.BorderStyle = BorderStyle.FixedSingle;
            pnlServices.Controls.Add(dtgDichVu);
            pnlServices.Controls.Add(label8);
            pnlServices.Location = new Point(14, 473);
            pnlServices.Name = "pnlServices";
            pnlServices.Size = new Size(410, 318);
            pnlServices.TabIndex = 5;
            // 
            // dtgDichVu
            // 
            dtgDichVu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgDichVu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDichVu.Location = new Point(14, 45);
            dtgDichVu.Name = "dtgDichVu";
            dtgDichVu.RowHeadersWidth = 51;
            dtgDichVu.RowTemplate.Height = 28;
            dtgDichVu.Size = new Size(380, 258);
            dtgDichVu.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.5F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(30, 30, 30);
            label8.Location = new Point(14, 12);
            label8.Name = "label8";
            label8.Size = new Size(254, 28);
            label8.TabIndex = 0;
            label8.Text = "Các dịch vụ được sử dụng";
            // 
            // pnlChart1
            // 
            pnlChart1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlChart1.BackColor = Color.White;
            pnlChart1.BorderStyle = BorderStyle.FixedSingle;
            pnlChart1.Controls.Add(picChart1);
            pnlChart1.Controls.Add(label10);
            pnlChart1.Location = new Point(438, 171);
            pnlChart1.Name = "pnlChart1";
            pnlChart1.Size = new Size(750, 290);
            pnlChart1.TabIndex = 6;
            // 
            // picChart1
            // 
            picChart1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            picChart1.BackColor = Color.White;
            picChart1.Location = new Point(14, 40);
            picChart1.Name = "picChart1";
            picChart1.Size = new Size(720, 236);
            picChart1.TabIndex = 1;
            picChart1.TabStop = false;
            picChart1.Paint += picChart1_Paint;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11.5F, FontStyle.Bold);
            label10.ForeColor = Color.FromArgb(30, 30, 30);
            label10.Location = new Point(14, 10);
            label10.Name = "label10";
            label10.Size = new Size(223, 28);
            label10.TabIndex = 0;
            label10.Text = "Doanh thu thuê phòng";
            // 
            // pnlChart2
            // 
            pnlChart2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlChart2.BackColor = Color.White;
            pnlChart2.BorderStyle = BorderStyle.FixedSingle;
            pnlChart2.Controls.Add(picChart2);
            pnlChart2.Controls.Add(label12);
            pnlChart2.Location = new Point(438, 473);
            pnlChart2.Name = "pnlChart2";
            pnlChart2.Size = new Size(750, 318);
            pnlChart2.TabIndex = 7;
            // 
            // picChart2
            // 
            picChart2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            picChart2.BackColor = Color.White;
            picChart2.Location = new Point(14, 40);
            picChart2.Name = "picChart2";
            picChart2.Size = new Size(720, 263);
            picChart2.TabIndex = 1;
            picChart2.TabStop = false;
            picChart2.Paint += picChart2_Paint;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 11.5F, FontStyle.Bold);
            label12.ForeColor = Color.FromArgb(30, 30, 30);
            label12.Location = new Point(14, 10);
            label12.Name = "label12";
            label12.Size = new Size(138, 28);
            label12.TabIndex = 0;
            label12.Text = "Số phòng đặt";
            // 
            // FormBaoCaoThongKe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 250);
            ClientSize = new Size(1202, 803);
            Controls.Add(pnlChart2);
            Controls.Add(pnlChart1);
            Controls.Add(pnlServices);
            Controls.Add(pnlRankings);
            Controls.Add(pnlCard3);
            Controls.Add(pnlCard2);
            Controls.Add(pnlCard1);
            Controls.Add(pnlHeader);
            Name = "FormBaoCaoThongKe";
            Text = "Báo cáo thống kê tình hình kinh doanh";
            Load += FormBaoCaoThongKe_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlCard1.ResumeLayout(false);
            pnlCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picCard1).EndInit();
            pnlCard2.ResumeLayout(false);
            pnlCard2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picCard2).EndInit();
            pnlCard3.ResumeLayout(false);
            pnlCard3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picCard3).EndInit();
            pnlRankings.ResumeLayout(false);
            pnlRankings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picTop3).EndInit();
            ((System.ComponentModel.ISupportInitialize)picTop2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picTop1).EndInit();
            pnlServices.ResumeLayout(false);
            pnlServices.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgDichVu).EndInit();
            pnlChart1.ResumeLayout(false);
            pnlChart1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picChart1).EndInit();
            pnlChart2.ResumeLayout(false);
            pnlChart2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picChart2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label label1;
        private DateTimePicker dtpTuNgay;
        private Label label2;
        private DateTimePicker dtpDenNgay;
        private Button btnThongKe;
        private Button btnXuatExcel;
        private Button btnInBaoCao;
        private Panel pnlCard1;
        private PictureBox picCard1;
        private Label label3;
        private Label lblDoanhThuThuePhong;
        private Panel pnlCard2;
        private PictureBox picCard2;
        private Label label5;
        private Label lblDoanhThuDichVu;
        private Panel pnlCard3;
        private PictureBox picCard3;
        private Label label7;
        private Label lblSoPhongDat;
        private Panel pnlRankings;
        private Label label4;
        private PictureBox picTop1;
        private Label label6;
        private Label lblTop1;
        private PictureBox picTop2;
        private Label label9;
        private Label lblTop2;
        private PictureBox picTop3;
        private Label label11;
        private Label lblTop3;
        private Panel pnlServices;
        private Label label8;
        private DataGridView dtgDichVu;
        private Panel pnlChart1;
        private Label label10;
        private PictureBox picChart1;
        private Panel pnlChart2;
        private Label label12;
        private PictureBox picChart2;
    }
}
