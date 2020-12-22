using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//hello
namespace QuanLi_CuaHangThachCao
{
    public partial class formNhanVien : Form
    {
        ConnectionDB condb = new ConnectionDB();
        FState trangThai;
        private FState TrangThai
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
            dgvNhanVien.Enabled = true;
            btluu.Enabled = false;
            btthem.Enabled = true;
            btsua.Enabled = true;
            btxoa.Enabled = true;
            btthoat.Text = "Thoát";
        }
        private void SetEditing()
        {
            ResetTextBox();
            btxoa.Enabled = false;
            btsua.Enabled = false;
            btthem.Enabled = false;
            btluu.Enabled = true;
            btthoat.Text = "Hủy";
        }
        private void ResetTextBox()//Reset trắng nội dung các TextBox, gán dữ liệu ban đầu cho RadioButton, DateTimPickup
        {
            tbdiachinv.Clear();
            tbdienthoai.Clear();
            tbmanv.Clear();
            tbtennv.Clear();
                        

        }
        public formNhanVien()
        {
            InitializeComponent();
            TrangThai = FState.IsViewing;
            showData();
        }

        private void formNhanVien_Load(object sender, EventArgs e)
        {

            
        }
        private void showData()
        {
            string sql = "SELECT * FROM NhanVien";
            DataTable dt = condb.getDataTable(sql);
            dgvNhanVien.DataSource = dt;
            dgvNhanVien.Show();
            //Autosize table
            for (int i = 0; i < dgvNhanVien.Columns.Count - 1; i++)
            {
                dgvNhanVien.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            dgvNhanVien.Columns[dgvNhanVien.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btthem_Click(object sender, EventArgs e)
        {

            SetEditing();
            TrangThai = FState.IsEditing;
            groupBox1.Enabled = true;
            AutoUp();
            dgvNhanVien.Enabled = false;
            tbtennv.Focus();
            
        }

        private void AutoUp()
        {
            Random ra = new Random();
            int ra1 = ra.Next(1, 50);
            int count = dgvNhanVien.Rows.Count;
            if (count > 9)
            {
                tbmanv.Text = "NV" + count++ + "-" + ra1;
            }
            else
            {
                tbmanv.Text = "NV0" + count++ + "-" + ra1;
            }
        }

        private void btluu_Click(object sender, EventArgs e)
        {
            if (tbmanv.Text != "" && tbtennv.Text != "" && tbdiachinv.Text != "" && tbdienthoai.Text != "")
            {

                string sql = "INSERT INTO NhanVien VALUES(N'" + tbmanv.Text + "',N'" + tbtennv.Text + "',N'"+rbNam.Checked + "',N'"  + tbdiachinv.Text + "',N'" + tbdienthoai.Text + "',CONVERT(DATE,'"+ dateTimePicker1.Value+"',103))";
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

        private void btsua_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbmanv.Text != "" && tbtennv.Text != "" && tbdiachinv.Text != "" && tbdienthoai.Text != "")
                {
                    DialogResult result = MessageBox.Show("Bạn có muốn sửa không ?", "Thông báo", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        condb.connect();
                        string sql = "Update Khach Set NhanVien =N'" + tbmanv.Text + "', TenKhach =N'" + tbtennv.Text + "',GioiTinh = N'" + rbmakh.Checked + "',DiaChi = N'" + tbdiachinv.Text + "',DienThoai = N'" + tbdienthoai.Text +"', NgaySinh = N'" + tbdiachinv.Text + "'Where NhanVien ='" + tbmanv.Text + "'";
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

        

        private void dgvNhanVien_SelectionChanged_1(object sender, EventArgs e)
        {
            try
            {
                groupBox1.Enabled = true; // Groupbox thông tin KH mở
                int VT = 0;
                if (VT != null && VT >= 0)
                {
                    VT = dgvNhanVien.CurrentCell.RowIndex;
                    tbmanv.Text = dgvNhanVien.Rows[VT].Cells[0].Value.ToString();
                    tbtennv.Text = dgvNhanVien.Rows[VT].Cells[1].Value.ToString();
                    if (Boolean.Parse(dgvNhanVien.Rows[VT].Cells[2].Value.ToString()) == true)                    
                    {
                        rbNam.Checked = true;
                    }
                    else
                    {
                        rbNu.Checked = true;
                    }

                    tbdiachinv.Text = dgvNhanVien.Rows[VT].Cells[3].Value.ToString();
                    tbdienthoai.Text = dgvNhanVien.Rows[VT].Cells[4].Value.ToString();
                    dateTimePicker1.Text = dgvNhanVien.Rows[VT].Cells[5].Value.ToString();
                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            if (TrangThai == FState.IsViewing)
            {
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                    this.Close();
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn HỦY  ?", "Thông báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    TrangThai = FState.IsViewing;
                    groupBox1.Enabled = false;
                }
            }
        }

        
    }
}
