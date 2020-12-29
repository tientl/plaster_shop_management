using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLi_CuaHangThachCao
{
    public partial class formGhiNo : Form
    {
        ConnectionDB condb = new ConnectionDB();
        FState trangThai;
        private FState TrangThai //get, set trạng thái (chế độ) của Form2: đang "xem" hay đang "chỉnh sửa dữ liệu"
        {
            get { return this.trangThai; }
            set
            {
                switch (value)
                {
                    case FState.IsViewing: SetViewing(); break;
                    case FState.IsEditing: SetEditing(); break;

                }
                trangThai = value;
            }
        }

        private void SetViewing()
        {
            //tbMaHD.Enabled = false;
            //dgvHoaDon.Enabled = true;
            //btLuu.Enabled = false;
            //btthem.Enabled = true;
            //btsua.Enabled = true;
            //btXoa.Enabled = true;
            //btLuu.Enabled = false;

            btthoat.Text = "Thoát";
        }
        private void SetEditing()
        {
            ResetTextBox();
            //btthem.Enabled = false;
            //btXoa.Enabled = false;
            //btsua.Enabled = false;
            //btLuu.Enabled = true;
            //btnThemSp.Enabled = true;
            //btnSuaSP.Enabled = true;
            //btnXoaSp.Enabled = true;
            //txtDonGiaBan.Enabled = true;
            //txtSoLuong.Enabled = true;
            //cbxTenHang.Enabled = true;
            //btthoat.Text = "Hủy";
        }
        private void ResetTextBox()//Reset trắng nội dung các TextBox, gán dữ liệu ban đầu cho RadioButton, DateTimPickup
        {
            //cbTenKhach.Text = "";
            //cbMaKhach.Text = "";
            //tbMaNV.Clear();

        }
        public formGhiNo()
        {
            InitializeComponent();
            showData();
            LoadCBoxMaHD();
        }

        public void showData()
        {
            string sql = "SELECT * FROM GhiNo";
            DataTable dt = condb.getDataTable(sql);
            dgvGhiNo.DataSource = dt;
            dgvGhiNo.Show();
            // Autosize table
            for (int i = 0; i < dgvGhiNo.Columns.Count - 1; i++)
            {
                dgvGhiNo.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            dgvGhiNo.Columns[dgvGhiNo.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void LoadCBoxMaHD()
        {
            condb.connect();
            string sql = "SELECT * FROM HDBan ";
            DataTable dt = condb.getDataTable(sql);
            cbxMaHD.DataSource = dt;
            cbxTenKhach.DataSource = dt;          
            cbxMaHD.DisplayMember = "MaHDBan";           
            cbxTenKhach.DisplayMember = "TenKhach";
            cbxMaHD.Show();
            cbxTenKhach.Show();
        }

        
    }
}
