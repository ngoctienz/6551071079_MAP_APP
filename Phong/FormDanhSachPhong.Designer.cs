namespace HotelManagement.Phong
{
    partial class FormDanhSachPhong
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
            picTimKiem = new PictureBox();
            txtTimKiem = new TextBox();
            btnXuatExcel = new Button();
            btnThemMoiPhong = new Button();
            dtgDanhSachPhong = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)picTimKiem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgDanhSachPhong).BeginInit();
            SuspendLayout();
            // 
            // picTimKiem
            // 
            picTimKiem.Image = Properties.Resources.search;
            picTimKiem.Location = new Point(60, 12);
            picTimKiem.Margin = new Padding(3, 4, 3, 4);
            picTimKiem.Name = "picTimKiem";
            picTimKiem.Size = new Size(39, 37);
            picTimKiem.SizeMode = PictureBoxSizeMode.Zoom;
            picTimKiem.TabIndex = 1;
            picTimKiem.TabStop = false;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTimKiem.Location = new Point(105, 17);
            txtTimKiem.Margin = new Padding(3, 4, 3, 4);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Tìm theo mã phòng...";
            txtTimKiem.Size = new Size(250, 32);
            txtTimKiem.TabIndex = 2;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // btnXuatExcel
            // 
            btnXuatExcel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnXuatExcel.BackColor = Color.DarkTurquoise;
            btnXuatExcel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXuatExcel.Location = new Point(945, 12);
            btnXuatExcel.Margin = new Padding(3, 4, 3, 4);
            btnXuatExcel.Name = "btnXuatExcel";
            btnXuatExcel.Size = new Size(140, 37);
            btnXuatExcel.TabIndex = 3;
            btnXuatExcel.Text = "Xuất Excel";
            btnXuatExcel.UseVisualStyleBackColor = false;
            btnXuatExcel.Click += btnXuatExcel_Click;
            // 
            // btnThemMoiPhong
            // 
            btnThemMoiPhong.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThemMoiPhong.BackColor = Color.LightPink;
            btnThemMoiPhong.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThemMoiPhong.Location = new Point(1100, 12);
            btnThemMoiPhong.Margin = new Padding(3, 4, 3, 4);
            btnThemMoiPhong.Name = "btnThemMoiPhong";
            btnThemMoiPhong.Size = new Size(140, 37);
            btnThemMoiPhong.TabIndex = 4;
            btnThemMoiPhong.Text = "Thêm mới";
            btnThemMoiPhong.UseVisualStyleBackColor = false;
            btnThemMoiPhong.Click += btnThemMoiPhong_Click;
            // 
            // dtgDanhSachPhong
            // 
            dtgDanhSachPhong.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgDanhSachPhong.BackgroundColor = Color.Honeydew;
            dtgDanhSachPhong.BorderStyle = BorderStyle.None;
            dtgDanhSachPhong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDanhSachPhong.Location = new Point(0, 66);
            dtgDanhSachPhong.Margin = new Padding(3, 4, 3, 4);
            dtgDanhSachPhong.Name = "dtgDanhSachPhong";
            dtgDanhSachPhong.RowHeadersWidth = 51;
            dtgDanhSachPhong.RowTemplate.Height = 40;
            dtgDanhSachPhong.Size = new Size(1276, 769);
            dtgDanhSachPhong.TabIndex = 5;
            dtgDanhSachPhong.CellClick += dtgDanhSachPhong_CellClick;
            // 
            // FormDanhSachPhong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(1276, 851);
            Controls.Add(btnThemMoiPhong);
            Controls.Add(btnXuatExcel);
            Controls.Add(picTimKiem);
            Controls.Add(txtTimKiem);
            Controls.Add(dtgDanhSachPhong);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormDanhSachPhong";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Danh sách phòng";
            Load += FormDanhSachPhong_Load;
            ((System.ComponentModel.ISupportInitialize)picTimKiem).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgDanhSachPhong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox picTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnXuatExcel;
        private System.Windows.Forms.Button btnThemMoiPhong;
        private System.Windows.Forms.DataGridView dtgDanhSachPhong;
    }
}
