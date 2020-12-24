using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLi_CuaHangThachCao
{
    public partial class formHoaDon : Form
    {
        ConnectionDB condb = new ConnectionDB();
        public formHoaDon()
        {

            InitializeComponent();
            LoadCBox();
        }

        private void LoadCBox()
        {
            condb.connect();
            string sql = "SELECT * FROM HANG ";
            DataTable dt = condb.getDataTable(sql);
            cbxTenHang.DataSource = dt;
            cbxTenHang.ValueMember = "MaHang";
            cbxTenHang.DisplayMember = "TenHang";
            cbxTenHang.Show();           
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void formHoaDon_Load(object sender, EventArgs e)
        {
            LoadCBox();
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cbxTenHang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btthem_Click(object sender, EventArgs e)
        {
             dgvListSP.Rows.Add(cbxTenHang.Text, txtSoLuong.Text);
             
        }

        private void Reload_Click(object sender, EventArgs e)
        {
            formKhach fK = new formKhach();
            fK.Show();
            
        }
    }
}
