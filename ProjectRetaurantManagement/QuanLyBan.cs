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
    public partial class FormQuanLyBan : Form
    {
        QuanLyNhaHangEntities db = new QuanLyNhaHangEntities();
        public FormQuanLyBan()
        {
            InitializeComponent();
            LoadTable();
            LoadCategories();
        }
        #region methods
        void LoadTable()
        {
            List<Ban> ban = db.Ban.ToList();
            cbChangeTable.DataSource = ban;
            cbChangeTable.DisplayMember = "TenBan";
            foreach (Ban item in ban)
            {
                Button btn = new Button()
                {
                    Width = 100,
                    Height = 100,
                    BackColor = System.Drawing.Color.FromArgb(22, 115, 126),
                    ForeColor = System.Drawing.Color.White,
                    Font = new Font("Tahoma", 10, FontStyle.Bold)
                };
                btn.Text = item.TenBan + Environment.NewLine + item.TrangThai;

                btn.Click += btnClick;
                btn.Tag = item;
                if (item.TrangThai == "Trống")
                {
                    btn.BackColor = Color.FromArgb(22, 115, 126);
                }
                else
                {
                    btn.BackColor = Color.FromArgb(190, 52, 85);
                }
                flpTable.Controls.Add(btn);
            }
        }

        void ShowBill(string id)
        {
            int tongTien = 0;
            lstBill.Items.Clear();
            if (id != null)
            {
                List<ChiTietHD> cthd = db.ChiTietHD.Where(row => row.MaHD == id).ToList();
                HoaDon tongHD = db.HoaDon.Where(row => row.MaHD == id).FirstOrDefault();
                tongHD.TongTien = 0;
                //tim id ban trong chi tiêt hoa don sau do list ra ( foreach )
                foreach (ChiTietHD item in cthd)
                {
                    ListViewItem lsvItem = new ListViewItem(item.MonAn.TenMonAn.ToString());
                    lsvItem.SubItems.Add(item.SoLuong.ToString());
                    lsvItem.SubItems.Add(item.MonAn.DonGia.ToString());
                    lsvItem.SubItems.Add((item.MonAn.DonGia * item.SoLuong).ToString());
                    tongTien += (int)item.MonAn.DonGia * (int)item.SoLuong;
                    lstBill.Items.Add(lsvItem);
                }
                tongHD.TongTien = tongTien;
                db.SaveChanges();
            }
            txbTongTien.Text = tongTien.ToString("c");
            //CultureInfo cul = new CultureInfo("en-US");
            //txbTongTien.Text = tongTien.ToString("c", cul);
        }
        void LoadFoods(string id)
        {
            List<MonAn> monAn = db.MonAn.Where(row => row.MaLoaiMonAn == id).ToList();
            cbMon.DataSource = monAn;
            cbMon.DisplayMember = "TenMonAn";
        }
        void LoadCategories()
        {
            List<LoaiMonAn> LoaiMonAn = db.LoaiMonAn.ToList();

            cbLoaiMon.DataSource = LoaiMonAn;
            cbLoaiMon.DisplayMember = "TenLoaiMonAn";
        }
        int kiemTraChuSo(int n)
        {
            int count = 1;
            while (n >= 10)
            {
                n /= 10;
                count += 1;
            }
            return count;
        }
        string TangMaChiTietHD()
        {
            //Nếu ban đầu mình không có mã nào hết thì mình sẽ cho biến numBillID là biến global để lưu thứ tự mã CTHD
            //Mỗi lần thêm một chi tiết hóa đơn sẽ gọi hàm này để cắt chuỗi và ghép vào mã CTHD + 1
            List<ChiTietHD> cthd = db.ChiTietHD.ToList();
            if(cthd.Count == 0)
            {
                return "CTHD001";
            }    
            string maCTHD = cthd.LastOrDefault().MaCTHD.ToString();
            if (maCTHD == null)
                maCTHD = "CTHD000";
            int numBillID = int.Parse(maCTHD.Substring(4, 3));//020, lấy 3 ký tự
            numBillID += 1;//21
            maCTHD = maCTHD.Substring(0, 4);//CTHD
            int chuoiDayDu = 3 - kiemTraChuSo(numBillID);//2 => thêm 2 số 00
            if (chuoiDayDu == 0)
                maCTHD += numBillID.ToString();
            else if (chuoiDayDu == 1)
                maCTHD += ("0" + numBillID.ToString());
            else
                maCTHD += ("00" + numBillID.ToString());
            return maCTHD;//Trả ra Chi tiet hoa don (max + 1) VD: CTHD005 -> CTHD006
        }
        string TangMaHD()
        {
            //Nếu ban đầu mình không có mã nào hết thì mình sẽ cho biến numBillID là biến global để lưu thứ tự mã CTHD
            //Mỗi lần thêm một chi tiết hóa đơn sẽ gọi hàm này để cắt chuỗi và ghép vào mã CTHD + 1
            List<HoaDon> hd = db.HoaDon.ToList();
            if(hd.Count == 0)
            {
                return "HD001";
            }
            string maHD = hd.LastOrDefault().MaHD;
            if (maHD == null)
                maHD = "HD000";
            int numBillID = int.Parse(maHD.Substring(2, 3));//020, lấy 3 ký tự
            numBillID += 1;//21

            maHD = maHD.Substring(0, 2);//CTHD
            int chuoiDayDu = 3 - kiemTraChuSo(numBillID);//2 => thêm 2 số 00
            if (chuoiDayDu == 0)
                maHD += numBillID.ToString();
            else if (chuoiDayDu == 1)
                maHD += ("0" + numBillID.ToString());
            else
                maHD += ("00" + numBillID.ToString());
            return maHD;//Trả ra Chi tiet hoa don (max + 1) VD: HD005 -> HD006
        }
        #endregion
        void btnClick(object sender, EventArgs e)
        {
            string tableID = ((sender as Button).Tag as Ban).MaBan;
            lstBill.Tag = (sender as Button).Tag;
            HoaDon billID = db.HoaDon.Where(row => row.MaBan == tableID && row.TrangThaiThanhToan == "Chưa thanh toán").FirstOrDefault();
            if (billID == null)
                ShowBill(null);
            else
                ShowBill(billID.MaHD);
        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            if (cbMon.SelectedItem == null)
                return;
            MonAn maMon = (cbMon.SelectedItem as MonAn);
            Ban ban = new Ban();
            if (lstBill.Tag != null)
                ban = lstBill.Tag as Ban;

            ban.TrangThai = "Đã đặt";
            db.SaveChanges();
            flpTable.Controls.Clear();
            LoadTable();
            HoaDon hd = db.HoaDon.Where(row => row.MaBan == ban.MaBan && row.TrangThaiThanhToan == "Chưa thanh toán").FirstOrDefault();
            int soLuong = (int)nudSoLuong.Value;
            //MessageBox.Show(TangMaHD() + " " + TangMaChiTietHD() + " " + maMon.MaMonAn + " " + soLuong + " " + ban.MaBan + " " + DateTime.Now.ToString());
            if (hd != null)
            {
                List<ChiTietHD> listMon = db.ChiTietHD.Where(row => row.MaHD == hd.MaHD).ToList();
                ChiTietHD idMatch = listMon.Where(row => row.MaMonAn == maMon.MaMonAn).FirstOrDefault();
                if (idMatch == null)
                {
                    ChiTietHD newCTHD = new ChiTietHD() { MaCTHD = TangMaChiTietHD(), MaMonAn = maMon.MaMonAn, SoLuong = soLuong, MaHD = hd.MaHD, TrangThaiMon = "Chưa chuẩn bị" };
                    db.ChiTietHD.Add(newCTHD);
                }
                else
                {
                    //ChiTietHD newCTHD = new ChiTietHD() { MaCTHD = idMatch.MaCTHD, MaMonAn = maMon.MaMonAn, SoLuong = soLuong + idMatch.SoLuong, MaHD = hd, TrangThaiMon = "Chưa chuẩn bị" };
                    idMatch.MaCTHD = idMatch.MaCTHD;
                    idMatch.MaHD = hd.MaHD;
                    idMatch.MaMonAn = idMatch.MaMonAn;
                    idMatch.SoLuong += soLuong;
                    idMatch.TrangThaiMon = "Chưa chuẩn bị";
                }
                db.SaveChanges();
                ShowBill(hd.MaHD);
            }
            else
            {
                HoaDon newHD = new HoaDon() { MaHD = TangMaHD(), MaBan = ban.MaBan, NgayLap = DateTime.Now, TrangThaiThanhToan = "Chưa thanh toán" };//Thêm mã nv và mã kh sau khi cài đặt role
                db.HoaDon.Add(newHD);
                db.SaveChanges();
                ChiTietHD newCTHD = new ChiTietHD() { MaCTHD = TangMaChiTietHD(), MaMonAn = maMon.MaMonAn, SoLuong = soLuong, MaHD = newHD.MaHD, TrangThaiMon = "Chưa chuẩn bị" };
                db.ChiTietHD.Add(newCTHD);
                db.SaveChanges();
                ShowBill(newHD.MaHD);
            }
        }

        private void btnChangeTable_Click(object sender, EventArgs e)
        {
            Ban ban = new Ban();

            Ban newBan = new Ban();
            if (lstBill.Tag != null)
                ban = lstBill.Tag as Ban;
            ban.TrangThai = "Trống";
            HoaDon hd = db.HoaDon.Where(row => row.MaBan == ban.MaBan && row.TrangThaiThanhToan == "Chưa thanh toán").FirstOrDefault();
            if (hd != null)
            {
                newBan = (cbChangeTable.SelectedItem as Ban);
                newBan.TrangThai = "Đã đặt";
                hd.MaBan = newBan.MaBan;
                db.SaveChanges();
                flpTable.Controls.Clear();
                LoadTable();
                ShowBill(hd.MaHD);
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            Ban ban = new Ban();
            if (lstBill.Tag != null)
                ban = lstBill.Tag as Ban;
            ban.TrangThai = "Trống";
            HoaDon hd = db.HoaDon.Where(row => row.MaBan == ban.MaBan && row.TrangThaiThanhToan == "Chưa thanh toán").FirstOrDefault();
            if (hd == null)
            {
                return;
            }
            hd.TrangThaiThanhToan = "Đã thanh toán";
            db.SaveChanges();
            ShowBill(null);
            flpTable.Controls.Clear();
            LoadTable();
        }

        private void cbLoaiMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLoaiMon.SelectedItem == null)
                return;

            LoaiMonAn lma = cbLoaiMon.SelectedItem as LoaiMonAn;
            LoadFoods(lma.MaLoaiMonAn);
        }

        
    }
}
