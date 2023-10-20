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
    public partial class FormThucAn : Form
    {
        QuanLyNhaHangEntities db = new QuanLyNhaHangEntities();
        public FormThucAn()
        {
            InitializeComponent();
            loadData();
            AddBinding();
        }
        void loadData()
        {
            var query = from m in db.MonAn
                        select new
                        {
                            MaMonAn = m.MaMonAn,
                            TenMonAn = m.TenMonAn,
                            DonGia = m.DonGia,
                            MaLoaiMonAn = m.MaLoaiMonAn
                        };
            dataGridViewMonAn.DataSource = db.MonAn.ToList();
        }
        void AddBinding()
        {
            textBoxMaMonAn.DataBindings.Add(new Binding("Text", dataGridViewMonAn.DataSource, "MaMonAn"));
            textBoxTenMonAn.DataBindings.Add(new Binding("Text", dataGridViewMonAn.DataSource, "TenMonAn"));
            textBoxDonGia.DataBindings.Add(new Binding("Text", dataGridViewMonAn.DataSource, "DonGia"));
            textBoxMaLoaiMonAn.DataBindings.Add(new Binding("Text", dataGridViewMonAn.DataSource, "MaLoaiMonAn"));
        }

        private void buttonThemMonAn_Click(object sender, EventArgs e)
        {
            ////MonAn m = new MonAn()
            ////{
            ////    MaMonAn = textBoxMaMonAn.Text,
            ////    TenMonAn = textBoxTenMonAn.Text,
            ////    DonGia = int.Parse(textBoxDonGia.Text),
            ////    MaLoaiMonAn = textBoxMaLoaiMonAn.Text,
            ////};
            ////db.MonAn.Add(m);
            //db.SaveChanges();
            db.ThemMonAn(textBoxMaMonAn.Text, textBoxTenMonAn.Text, int.Parse(textBoxDonGia.Text), textBoxMaLoaiMonAn.Text);
            loadData();
       //     AddBinding();
        }

        private void buttonXoaMonAn_Click(object sender, EventArgs e)
        {
            string maMonAn = textBoxMaMonAn.Text;
            MonAn m = db.MonAn.Where(p => p.MaMonAn == maMonAn).SingleOrDefault();
            db.MonAn.Remove(m);
            db.SaveChanges();
            loadData();
            //AddBinding();
        }

        private void buttonSuaMonAn_Click(object sender, EventArgs e)
        {
            string maMonAn = dataGridViewMonAn.SelectedCells[0].OwningRow.Cells["MaMonAn"].Value.ToString();
            MonAn m = db.MonAn.Find(maMonAn);
            m.MaMonAn = textBoxMaMonAn.Text;
            m.TenMonAn = textBoxTenMonAn.Text;
            m.DonGia = int.Parse(textBoxDonGia.Text);
            m.MaLoaiMonAn = textBoxMaLoaiMonAn.Text;
            db.SaveChanges();
            loadData();
            AddBinding();
        }
    }
}
