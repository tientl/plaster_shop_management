using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLi_CuaHangThachCao.View
{
    public partial class formThongKe : Form
    {
        ConnectionDB condb = new ConnectionDB();
        public formThongKe()
        {
            InitializeComponent();
            
        }

        public void showData()
        {
            string sql = "SELECT COUNT(h.MaHDBan) AS 'Số Lượng Hóa Đơn',SUM(TongTien) AS 'Tổng Tiền' FROM HDBan h,ChiTietHD ct WHERE h.MaHDBan = ct.MaHDBan AND h.NgayBan>=CONVERT(date,'"+date1.Text+ "',103) AND h.NgayBan <=CONVERT(date,'" + date2.Text + "',103)";
            DataTable dt = condb.getDataTable(sql);
            dgvThongKe.DataSource = dt;
            dgvThongKe.Show();
            // Autosize table
            for (int i = 0; i < dgvThongKe.Columns.Count - 1; i++)
            {
                dgvThongKe.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            dgvThongKe.Columns[dgvThongKe.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showData();
        }
    }
}
