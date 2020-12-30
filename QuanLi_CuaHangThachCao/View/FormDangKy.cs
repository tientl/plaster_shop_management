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
    public partial class FormDangKy : Form
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
            dgvDangKy.Enabled = true;
            btLuu.Enabled = false;
            btthem.Enabled = true;
            btsua.Enabled = true;
            btxoa.Enabled = true;
            btLuu.Enabled = false;

            btthoat.Text = "Thoát";
        }
        private void SetEditing()
        {
            ResetTextBox();
            btthem.Enabled = false;
            btxoa.Enabled = false;
            btsua.Enabled = false;
            btLuu.Enabled = true;
            btthoat.Text = "Hủy";
        }
        private void ResetTextBox()//Reset trắng nội dung các TextBox, gán dữ liệu ban đầu cho RadioButton, DateTimPickup
        {
            txtUserName.Text = "";
            txtPassword.Text = "";
        }
        public void showData()
        {
            string sql = "SELECT * FROM TaiKhoan";
            DataTable dt = condb.getDataTable(sql);
            dgvDangKy.DataSource = dt;
            dgvDangKy.Show();
            // Autosize table
            for (int i = 0; i < dgvDangKy.Columns.Count - 1; i++)
            {
                dgvDangKy.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            dgvDangKy.Columns[dgvDangKy.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void LoadCBoxMaHD()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Name");
            dt.Rows.Add("ADMIN", "ADMIN");
            dt.Rows.Add("USER", "USER");
            cboRole.DataSource = dt;
            cboRole.ValueMember = "ID";
            cboRole.DisplayMember = "Name";
        }
        public FormDangKy()
        {
            InitializeComponent();
            TrangThai = FState.IsViewing;
            showData();
            LoadCBoxMaHD();
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            TrangThai = FState.IsEditing;

        }

        private void btsua_Click(object sender, EventArgs e)
        {
            try
            {
                int VT = 0;
                VT = dgvDangKy.CurrentCell.RowIndex;
                if (txtUserName.Text != "" && txtPassword.Text != "")
                {
                    DialogResult result = MessageBox.Show("Bạn có muốn sửa không ?", "Thông báo", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        condb.connect();
                        string sql = "update TaiKhoan set UserName ='"+txtUserName.Text + "',Password ='"+txtPassword.Text+"' where TaiKhoan.ID_TK = '"+ dgvDangKy.Rows[VT].Cells[0].Value.ToString() + "' ";
                        condb.ExecuteNonQuery(sql);
                        MessageBox.Show("Sửa Thành Công");
                        showData();
                    }
                }               
            }
            catch
            {
                MessageBox.Show("Lỗi Dữ Liệu !!!");
            }
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUserName.Text != "" && txtPassword.Text != "")
                {

                    condb.connect();
                    string sql = "INSERT INTO TaiKhoan VALUES ('"+txtUserName.Text+"','"+txtPassword.Text+"','"+cboRole.SelectedValue+"')";
                    condb.ExecuteNonQuery(sql);
                    MessageBox.Show("Thêm Thành Công!!");

                    showData();
                    ResetTextBox();
                    TrangThai = FState.IsViewing;
                    SetViewing();
                }
                else
                {
                    MessageBox.Show("Hãy nhập thông tin !!");
                }
            }
            catch
            {
                MessageBox.Show("Hóa Đơn Nợ đã tồn tại!!!");
            }
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            try
            {
                int VT = 0;
                VT = dgvDangKy.CurrentCell.RowIndex;
                DialogResult result = MessageBox.Show("Bạn có muốn xóa " + txtUserName.Text + " Không ?", "Thông Báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    condb.connect();
                    string sql = "DELETE FROM TaiKhoan  Where ID_TK= '" + dgvDangKy.Rows[VT].Cells[0].Value.ToString() + "' ";
                    condb.ExecuteNonQuery(sql);
                    MessageBox.Show("Xóa Thành Công!!");
                    showData();
                }  
            else
                {
                    MessageBox.Show("Còn Nợ không được xóa");
                }


            }
            catch
            {
                MessageBox.Show("Lỗi dữ liệu");
            }
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            if (TrangThai == FState.IsViewing)
            {
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    this.Hide();
                    Main main = new Main();
                    main.Show();
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn HỦY  ?", "Thông báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    TrangThai = FState.IsViewing;

                }
            }
        }

        private void dgvDangKy_SelectionChanged(object sender, EventArgs e)
        {
            int VT = 0;
            VT = dgvDangKy.CurrentCell.RowIndex;
            txtUserName.Text = dgvDangKy.Rows[VT].Cells[1].Value.ToString();
            txtPassword.Text = dgvDangKy.Rows[VT].Cells[2].Value.ToString();
            
        }

        
    }
}
