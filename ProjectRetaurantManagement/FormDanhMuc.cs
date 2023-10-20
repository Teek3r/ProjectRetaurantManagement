using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjectRetaurantManagement
{
    public partial class FormDanhMuc : Form
    {
        QuanLyNhaHangEntities db = new QuanLyNhaHangEntities(); 
        public FormDanhMuc()
        {
            InitializeComponent();
            loadData();
            addBinding();
        }
        void loadData()
        {
            dataGridViewLoaiMonAn.DataSource = db.LoaiMonAn.ToList();
        }
        void addBinding()
        {
            textBoxTenLoaiMonAn.DataBindings.Add(new Binding("Text", dataGridViewLoaiMonAn.DataSource, "TenLoaiMonAn"));
            textBoxMaLoaiMonAn.DataBindings.Add(new Binding("Text", dataGridViewLoaiMonAn.DataSource, "MaLoaiMonAn"));
        }

        private void buttonThemLoaiMonAn_Click(object sender, EventArgs e)
        {
            //db.LoaiMonAn.Add(new LoaiMonAn() { MaLoaiMonAn = textBoxMaLoaiMonAn.Text, TenLoaiMonAn = textBoxTenLoaiMonAn.Text });
            //db.SaveChanges();

            db.ThemLoaiMonAn(textBoxMaLoaiMonAn.Text, textBoxTenLoaiMonAn.Text);
            loadData();
        }

        private void buttonXoaLoaiMonAn_Click(object sender, EventArgs e)
        {
            string maLoaiMonAn = textBoxMaLoaiMonAn.Text;
            LoaiMonAn l = db.LoaiMonAn.Where(p => p.MaLoaiMonAn == maLoaiMonAn).SingleOrDefault();
            db.LoaiMonAn.Remove(l);
            db.SaveChanges();
            loadData();
        }

        private void buttonSuaLoaiMonAn_Click(object sender, EventArgs e)
        {
            string maLoaiMonAn = dataGridViewLoaiMonAn.SelectedCells[0].OwningRow.Cells["MaLoaiMonAn"].Value.ToString();
            LoaiMonAn l = db.LoaiMonAn.Find(maLoaiMonAn);
            l.MaLoaiMonAn = textBoxMaLoaiMonAn.Text;
            l.TenLoaiMonAn = textBoxTenLoaiMonAn.Text;
            db.SaveChanges();
            loadData();
        }
    }
}
