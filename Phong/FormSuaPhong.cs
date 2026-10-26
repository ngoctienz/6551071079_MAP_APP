using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HotelManagement.Phong
{
    public partial class FormSuaPhong : Form
    {
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string? MaPhong { get; set; }

        public FormSuaPhong()
        {
            InitializeComponent();
        }

        public FormSuaPhong(string? maPhong) : this()
        {
            MaPhong = maPhong;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
        }
    }
}
