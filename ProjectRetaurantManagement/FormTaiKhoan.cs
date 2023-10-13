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
    public partial class FormTaiKhoan : Form
    {
        QuanLyNhaHangEntities db = new QuanLyNhaHangEntities();
        public FormTaiKhoan()
        {
            InitializeComponent();
            loadData();
            AddBinding();
        }
        void loadData()
        {
            var query = from n in db.NhanVien
                        select new
                        {
                            MãNhânViên = n.MaNV,
                            TênNhânViên = n.TenNV,
                            ChứcVụ = n.ChucVu,
                            Lương = n.Luong
                        };
            dataGridViewTaiKhoan.DataSource = query.ToList();
        }

        void AddBinding()
        {
            textBoxMaNhanVien.DataBindings.Add(new Binding("Text", dataGridViewTaiKhoan.DataSource, "MãNhânViên"));
            textBoxTenNhanVien.DataBindings.Add(new Binding("Text", dataGridViewTaiKhoan.DataSource, "TênNhânViên"));
            textBoxChucVu.DataBindings.Add(new Binding("Text", dataGridViewTaiKhoan.DataSource, "ChứcVụ"));
            textBoxLuong.DataBindings.Add(new Binding("Text", dataGridViewTaiKhoan.DataSource, "Lương"));
        }
        private void buttonThemNhanVien_Click(object sender, EventArgs e)
        {
            NhanVien n = new NhanVien()
            {
                MaNV = textBoxMaNhanVien.Text,
                TenNV = textBoxTenNhanVien.Text,
                ChucVu = textBoxChucVu.Text,
                Luong = int.Parse(textBoxLuong.Text)
            };
            db.NhanVien.Add(n);
            db.SaveChanges();
            loadData();
        }

        private void buttonXoaNhanVien_Click(object sender, EventArgs e)
        {
            string maNhanVien = textBoxMaNhanVien.Text;
            NhanVien n = db.NhanVien.Where(p => p.MaNV == maNhanVien).SingleOrDefault();
            db.NhanVien.Remove(n);
            db.SaveChanges();
            loadData();
        }

        private void buttonSuaNhanVien_Click(object sender, EventArgs e)
        {
            string maNhanVien = dataGridViewTaiKhoan.SelectedCells[0].OwningRow.Cells["MãNhânViên"].Value.ToString();
            NhanVien n = db.NhanVien.Find(maNhanVien);
            n.MaNV = textBoxMaNhanVien.Text;
            n.TenNV = textBoxTenNhanVien.Text;
            n.ChucVu = textBoxChucVu.Text;
            n.Luong = int.Parse(textBoxLuong.Text);
            db.SaveChanges();
            loadData();
        }

        private void FormTaiKhoan_Load(object sender, EventArgs e)
        {

        }
    }
}
