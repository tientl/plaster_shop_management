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
            tbMaHD.Enabled = false;
            dgvHoaDon.Enabled = true;
            btLuu.Enabled = false;
            btthem.Enabled = true;
            btsua.Enabled = true;
            btXoa.Enabled = true;
            btLuu.Enabled = false;
            btthoat.Text = "Thoát";
        }
        private void SetEditing()
        {
            ResetTextBox();
            btthem.Enabled = false;
            btXoa.Enabled = false;
            btsua.Enabled = false;           
            btLuu.Enabled = true;
            btthoat.Text = "Hủy";
        }
        private void ResetTextBox()//Reset trắng nội dung các TextBox, gán dữ liệu ban đầu cho RadioButton, DateTimPickup
        {
            cbTenKhach.Text = "";
            cbMaKhach.Text = "";
            tbMaNV.Clear();           

        }
        public formHoaDon()
        {

            InitializeComponent();
            LoadCBoxHangHoa();
            LoadCBoxMaKhach();
            showData();
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
            //cbMaKhach.ValueMember = "MaKhach";
            cbMaKhach.DisplayMember = "MaKhach";
            cbMaKhach.ValueMember = "MaKhach";
            cbTenKhach.ValueMember = "TenKhach";
            cbTenKhach.DisplayMember = "TenKhach";
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
                //groupBox1.Enabled = true;
                AutoUp();
                dgvHoaDon.Enabled = false;
                cbTenKhach.Focus();
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

        

        private void button1_Click(object sender, EventArgs e)
        {
            formKhach f2 = new formKhach();
            f2.Show();
            this.Hide();
        }

        public void showData()
        {
            string sql = "SELECT * FROM HDBan";
            DataTable dt = condb.getDataTable(sql);
            dgvHoaDon.DataSource = dt;
            dgvHoaDon.Show();
            // Autosize table
            for (int i = 0; i < dgvHoaDon.Columns.Count - 1; i++)
            {
                dgvHoaDon.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            dgvHoaDon.Columns[dgvHoaDon.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            if (tbMaHD.Text != "" && cbMaKhach.Text != "" && cbTenKhach.Text != "" && tbMaNV.Text != "")
            {

                string sql = "INSERT INTO HDBan VALUES(N'" + tbMaHD.Text + "','" + cbMaKhach.Text + "',N'" + cbTenKhach.Text + "',N'" + tbMaNV.Text + "',CONVERT(DATE,'" + date.Value + "',103))";
                condb.ExecuteNonQuery(sql);
                MessageBox.Show("Thêm Thành Công!!");
                showData();
                ResetTextBox();
                SetViewing();
            }
            else
            {
                MessageBox.Show("Hãy nhập thông tin !!");
            }
        }

        private void dgvHoaDon_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                groupBox1.Enabled = true; // Groupbox thông tin KH mở
                int VT = 0;
                if (VT != null && VT >= 0)
                {
                    VT = dgvHoaDon.CurrentCell.RowIndex;
                    tbMaHD.Text = dgvHoaDon.Rows[VT].Cells[0].Value.ToString();
                    cbMaKhach.Text = dgvHoaDon.Rows[VT].Cells[1].Value.ToString();
                    cbTenKhach.Text = dgvHoaDon.Rows[VT].Cells[2].Value.ToString();
                    tbMaNV.Text = dgvHoaDon.Rows[VT].Cells[3].Value.ToString();
                    date.Text = dgvHoaDon.Rows[VT].Cells[4].Value.ToString();
                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbMaNV.Text != "" && cbTenKhach.Text != "" && cbMaKhach.Text != "" && tbMaNV.Text != "")
                {
                    DialogResult result = MessageBox.Show("Bạn có muốn sửa không ?", "Thông báo", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        condb.connect();
                        string sql = "Update HDBan Set MaHDBan =N'" + tbMaHD.Text + "', MaKhach =N'" + cbMaKhach.Text + "',TenKhach =N'" + cbTenKhach.Text + "',MaNhanVien = N'" + tbMaNV.Text + "',NgayBan = CONVERT(DATE,'" + date.Value + "',103) Where MaHDBan ='" + tbMaHD.Text + "'";
                        condb.ExecuteNonQuery(sql);
                        MessageBox.Show("Sửa Thành Công");
                        showData();
                    }

                }
                else
                {
                    MessageBox.Show("Hãy nhập thông tin cần SỬA !!");
                }
        }
            catch
            {
                MessageBox.Show("Lỗi Dữ Liệu !!!");
            }
}
    }
}
