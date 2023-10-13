using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProjectRetaurantManagement
{
    public partial class FormThongKe : Form
    {
        QuanLyNhaHangEntities db = new QuanLyNhaHangEntities();
        public FormThongKe()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime startDate = dateTimePickerStart.Value.Date;
            DateTime endDate = dateTimePickerEnd.Value.Date;
            CultureInfo culture = new CultureInfo("vi-VN");

            if (startDate > endDate)
            {
                MessageBox.Show("Loi!!");
                return;
            }
            chartThongKe.Series.Clear();
            chartThongKe.Series.Add("Doanh thu");


            var query = from h in db.HoaDon
                        where h.NgayLap >= startDate && h.NgayLap <= endDate
                        group h by h.NgayLap into nhomHoaDon
                        orderby nhomHoaDon.Key
                        select new
                        {
                            Ngay = nhomHoaDon.Key,
                            Tien = nhomHoaDon.Sum(hd => hd.TongTien)
                        };

            List<DateTime?> listNgay = query.Select(g => g.Ngay).ToList();
            List<double?> doanhThu = query.Select(g => g.Tien).ToList();
            //var query = from h in HoaDon
            //            select 
            //var result = db.Database.SqlQuery<>("DTTheoNgay", parameters);
            
            listView1.Items.Clear();
            for (int i = 0; i < listNgay.Count; i++)
            {

                ListViewItem lstItem = new ListViewItem(listNgay[i].Value.ToString("dd/MM/yyyy", culture));
                lstItem.SubItems.Add(doanhThu[i].Value.ToString("C1"));

                listView1.Items.Add(lstItem);
                if (doanhThu[i] > 0)
                {
                    chartThongKe.Series["Doanh thu"].Points.AddXY(listNgay[i], doanhThu[i]);
                }

            }



            chartThongKe.ChartAreas[0].AxisX.Interval = 1;
            chartThongKe.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Number;
            chartThongKe.ChartAreas[0].AxisX.LabelStyle.Format = "dd/MM";
            chartThongKe.ChartAreas[0].AxisX.LabelStyle.Angle = -75;
            // Đặt màu nền và viền cho ChartArea
            chartThongKe.ChartAreas[0].BackColor = Color.White;
            chartThongKe.ChartAreas[0].BorderDashStyle = ChartDashStyle.Solid;
            chartThongKe.ChartAreas[0].BorderColor = Color.Gray;

            // Định dạng trục x
            chartThongKe.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Arial", 8);
            chartThongKe.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;
            // Các thuộc tính khác của trục x

            // Định dạng trục y
            chartThongKe.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Arial", 8);
            chartThongKe.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;
            // Các thuộc tính khác của trục y
            // Đặt kiểu hiển thị cho Series
            chartThongKe.Series[0].ChartType = SeriesChartType.Column;
            chartThongKe.Series["Doanh thu"]["PixelPointWidth"] = "20";
            // Đặt màu sắc và độ dày cho Series

            //System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(126)))));
            chartThongKe.Series[0].Color = System.Drawing.Color.FromArgb(22, 115, 126);
            chartThongKe.Series[0].BorderWidth = 2;

            // Hiển thị giá trị trên biểu đồ
            chartThongKe.Series[0].IsValueShownAsLabel = true;
            chartThongKe.Series[0].LabelForeColor = Color.Black;
            chartThongKe.Series[0].LabelFormat = "#,##0";

            // Đặt vị trí và màu sắc cho Legend
            chartThongKe.Legends[0].Docking = Docking.Bottom;
            chartThongKe.Legends[0].BackColor = Color.White;

            // Đặt kiểu phông chữ và màu sắc cho văn bản trong Legend
            chartThongKe.Legends[0].Font = new Font("Arial", 8);
            chartThongKe.Legends[0].ForeColor = Color.Black;

            chartThongKe.ChartAreas[0].AxisY.Enabled = AxisEnabled.True;
            chartThongKe.Series["Doanh thu"].IsValueShownAsLabel = true;

            tinhToanDoanhThu(doanhThu);
        }
        void tinhToanDoanhThu(List<double?> doanhThu)
        {
            CultureInfo culture = new CultureInfo("vi-VN");
            labelTongDoanhThu.Text = doanhThu.Sum().Value.ToString("C1", culture);
            labelDTCaoNhat.Text = doanhThu.Max().Value.ToString("C1", culture);
            labelDTThapNhat.Text = doanhThu.Min().Value.ToString("C1", culture);
        }
    }
}
