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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnKhach_Click(object sender, EventArgs e)
        {

            formKhach frKhach = new formKhach();
            this.Hide();
            frKhach.Show();
            frKhach.FormClosing += Main_FormClosing;
        }
       

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            formNhanVien frNhanVien = new formNhanVien();
            this.Hide();
            frNhanVien.Show();
        }

        private void btnGhiNo_Click(object sender, EventArgs e)
        {
            formGhiNo frGhiNo = new formGhiNo();
            this.Hide();
            frGhiNo.Show();
        }

        private void btnKho_Click(object sender, EventArgs e)
        {
            formNhapKho frKho = new formNhapKho();
            this.Hide();
            frKho.Show();

        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            formHoaDon frHoaDon = new formHoaDon();
            this.Hide();
            frHoaDon.Show();
        }

        private void btnChiTietHD_Click(object sender, EventArgs e)
        {
            formHangHoa frHangHoa = new formHangHoa();
            frHangHoa.Show();
            this.Hide();
        }

        private void btnChatLieu_Click(object sender, EventArgs e)
        {

        }
    }
}
