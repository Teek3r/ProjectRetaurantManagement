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
    public partial class FormBan : Form
    {
        QuanLyNhaHangEntities db = new QuanLyNhaHangEntities(); 
        public FormBan()
        {
            InitializeComponent();
            loadData();
            AddBinding();
        }
        void loadData()
        {
            var query = from b in db.Ban
                        select new
                        {
                            MãBàn = b.MaBan,
                            TênBàn = b.TenBan,
                            TrạngThái = b.TrangThai
                        };
            dataGridViewBan.DataSource = query.ToList();
        }
        void AddBinding()
        {
            textBoxMaBan.DataBindings.Add(new Binding("Text", dataGridViewBan.DataSource, "MãBàn"));
            textBoxTenBan.DataBindings.Add(new Binding("Text", dataGridViewBan.DataSource, "TênBàn"));
        }

        private void buttonThemBan_Click(object sender, EventArgs e)
        {
            Ban b = new Ban() { MaBan = textBoxMaBan.Text, TenBan = textBoxTenBan.Text, TrangThai = "Trong", HoaDon = null };
            db.Ban.Add(b);
            db.SaveChanges();
            loadData();
        }

        private void buttonXoaBan_Click(object sender, EventArgs e)
        {
            string maBan = textBoxMaBan.Text;
            Ban b = db.Ban.Where(p => p.MaBan == maBan).SingleOrDefault();
            db.Ban.Remove(b);
            db.SaveChanges();
            loadData();
        }

        private void buttonSuaBan_Click(object sender, EventArgs e)
        {
            string maBan = dataGridViewBan.SelectedCells[0].OwningRow.Cells["MãBàn"].Value.ToString();
            Ban b = db.Ban.Find(maBan);
            b.MaBan = textBoxMaBan.Text;
            b.TenBan = textBoxTenBan.Text;
            db.SaveChanges();
            loadData();
        }
    }
}
