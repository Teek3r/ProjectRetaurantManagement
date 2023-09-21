using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectRetaurantManagement
{
    public partial class formQuanLy : Form
    {
        public formQuanLy()
        {
            InitializeComponent();
        }
        public void LoadForm(object Form)
        {
            if (this.panelXuly.Controls.Count > 0)
                this.panelXuly.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panelXuly.Controls.Add(f);
            this.panelXuly.Tag = f;
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadForm( new FormQuanLyBan());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadForm(new FormThucAn());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadForm(new FormBan());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadForm(new FormDanhMuc());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoadForm(new FormThongKe());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LoadForm(new FormTaiKhoan());
        }
    }

}
