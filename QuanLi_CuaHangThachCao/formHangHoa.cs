using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace QuanLi_CuaHangThachCao
{
    public partial class formHangHoa : Form
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
            dgvhanghoa.Enabled = true;
            btLuu.Enabled = false;
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
            btLuu.Enabled = true;
            btthoat.Text = "Hủy";
        }
        private void ResetTextBox()//Reset trắng nội dung các TextBox, gán dữ liệu ban đầu cho RadioButton, DateTimPickup
        {
            tbmahang.Clear();
            tbtenhang.Clear();
            tbtenChatlieu.Clear();
            tbsoluong.Clear();
            tbDonGiaBan.Clear();
            tbDonGiaNhap.Clear();
            
        }
        public formHangHoa()
        {
            InitializeComponent();
            showData();
            TrangThai = FState.IsViewing;
        }


        private void formHangHoa_Load(object sender, EventArgs e)
        {
            
        }
        public void showData()
        {
            string sql = "SELECT * FROM Hang";
            DataTable dt = condb.getDataTable(sql);
            dgvhanghoa.DataSource = dt;
            dgvhanghoa.Show();
            //Autosize table
            for (int i = 0; i < dgvhanghoa.Columns.Count - 1; i++)
            {
                dgvhanghoa.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            dgvhanghoa.Columns[dgvhanghoa.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            try
            {
                TrangThai = FState.IsEditing;
                groupBox1.Enabled = true;
                SetEditing();
                dgvhanghoa.Enabled = false;
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }

        }

        private void dgvhanghoa_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                groupBox1.Enabled = true; // Groupbox thông tin KH mở
                int VT = 0;
                if (VT != null && VT >= 0)
                {
                    VT = dgvhanghoa.CurrentCell.RowIndex;
                    tbmahang.Text = dgvhanghoa.Rows[VT].Cells[0].Value.ToString();
                    tbtenhang.Text = dgvhanghoa.Rows[VT].Cells[1].Value.ToString();
                    tbtenChatlieu.Text = dgvhanghoa.Rows[VT].Cells[2].Value.ToString();
                    tbsoluong.Text = dgvhanghoa.Rows[VT].Cells[3].Value.ToString();
                    tbDonGiaNhap.Text = dgvhanghoa.Rows[VT].Cells[4].Value.ToString();
                    tbDonGiaBan.Text = dgvhanghoa.Rows[VT].Cells[5].Value.ToString();
                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            
            if (tbmahang.Text != "" && tbtenhang.Text != "" && tbtenChatlieu.Text != "" && tbsoluong.Text != "" && tbDonGiaNhap.Text != "" && tbDonGiaBan.Text != "")
            {

                string sql = "INSERT INTO Hang VALUES(N'" + tbmahang.Text + "',N'" + tbtenhang.Text + "',N'" + tbtenChatlieu.Text + "',N'" + tbsoluong.Text + "',N'" + tbDonGiaNhap.Text + "',N'" + tbDonGiaBan.Text + "')";
                condb.ExecuteNonQuery(sql);
                MessageBox.Show("Thêm Thành Công!!");
                showData();
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
                if (tbmahang.Text != "" && tbtenhang.Text != "" && tbtenChatlieu.Text != "" && tbsoluong.Text != "" && tbDonGiaNhap.Text != "" && tbDonGiaBan.Text != "")
                {
                    DialogResult result = MessageBox.Show("Bạn có muốn sửa không ?", "Thông báo", MessageBoxButtons.YesNo);
                    if(result == DialogResult.Yes)
                    {
                        
                        string sql = "Update Hang Set MaHang =N'" + tbmahang.Text + "',TenHang =N'" + tbtenhang.Text + "',MaChatLieu=N'" + tbtenChatlieu.Text + "',SoLuong =N'" + tbsoluong.Text + "',DonGiaNhap =N'" + tbDonGiaNhap.Text + "',DonGiaBan =N'" + tbDonGiaBan.Text + "'Where MaHang ='" + tbmahang.Text + "'";
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
                MessageBox.Show("Lỗi Dữ Liệu!!");
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

        private void tbtimkiem_TextChanged(object sender, EventArgs e)
        {
            
            string sql = "";
            if (rbmh.Checked)
            {
                sql = "SELECT * FROM Hang Where MaHang Like N'%" + tbtimkiem.Text + "%'";
                condb.ExcuteQuery(sql);
            }
            if (rbth.Checked)
            {
                sql = "SELECT * FROM Hang Where TenHang Like N'%" + tbtimkiem.Text + "%'";
                condb.ExcuteQuery(sql);
            }
            DataTable dt = condb.getDataTable(sql);
            dgvhanghoa.DataSource = dt;
            dgvhanghoa.Show();
            // Autosize table
            for (int i = 0; i < dgvhanghoa.Columns.Count - 1; i++)
            {
                dgvhanghoa.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            dgvhanghoa.Columns[dgvhanghoa.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
