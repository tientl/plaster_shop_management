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
            
        }
        private void SetEditing()
        {
            //ResetTextBox();
            //tbmakh.Enabled = true;
            //btxoa.Enabled = false;
            //btsua.Enabled = false;
            //btthem.Enabled = false;
            //btnLuu.Enabled = true;
            //btthoat.Text = "Hủy";
        }
        private void ResetTextBox()//Reset trắng nội dung các TextBox, gán dữ liệu ban đầu cho RadioButton, DateTimPickup
        {
            //tbmakh.Clear();
            //tbtenkh.Clear();
            //tbdiachi.Clear();
            //tbdienthoai.Clear();

        }
        public formHoaDon()
        {

            InitializeComponent();
            LoadCBoxHangHoa();
            LoadCBoxMaKhach();
        }

        private void LoadCBoxHangHoa()
        {
            condb.connect();
            string sql = "SELECT * FROM HANG ";
            DataTable dt = condb.getDataTable(sql);
            cbxTenHang.DataSource = dt;
            cbxTenHang.ValueMember = "MaHang";
            cbxTenHang.DisplayMember = "TenHang";
            cbxTenHang.Show();           
        }

        private void LoadCBoxMaKhach()
        {
            condb.connect();
            string sql = "SELECT * FROM Khach ";
            DataTable dt = condb.getDataTable(sql);
            cbTenKhach.DataSource = dt;
            cbMaKhach.DataSource = dt;
            cbTenKhach.ValueMember = "MaKhach";
            cbTenKhach.DisplayMember = "TenKhach";          
            cbMaKhach.DisplayMember = "MaKhach";
            cbTenKhach.Show();
            cbMaKhach.Show();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void formHoaDon_Load(object sender, EventArgs e)
        {
           // LoadCBoxHangHoa();
            
        }

        

        private void btthem_Click(object sender, EventArgs e)
        {
            try
            {
                SetEditing();
                TrangThai = FState.IsEditing;
                groupBox1.Enabled = true;
                AutoUp();
                dgvHoaDon.Enabled = false;
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }

        }
        private void AutoUp()
        {
            Random ra = new Random();
            int ra1 = ra.Next(1, 50);
            int count = dgvHoaDon.Rows.Count;
            if (count > 9)
            {
                tbMaHD.Text = "HD" + count++ + "-" + ra1;
            }
            else
            {
                tbMaHD.Text = "HD0" + count++ + "-" + ra1;
            }

        }
        private void Reload_Click(object sender, EventArgs e)
        {
            formKhach fK = new formKhach();
            fK.Show();
            
        }

        private void Reload_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            formKhach f2 = new formKhach();
            f2.Show();
            this.Hide();
        }
    }
}
