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
    public enum FState { IsViewing, IsEditing };
    public partial class formKhach : Form
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
            dgvkhachhang.Enabled = true;
            btnLuu.Enabled = false;
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
            btnLuu.Enabled = true;
            btthoat.Text = "Hủy";
        }
        public formKhach()
        {           
            InitializeComponent();
            TrangThai = FState.IsViewing;
            showData();
        }
        
        public void showData()
        {                        
            string sql = "SELECT * FROM Khach";           
            DataTable dt = condb.getDataTable(sql);
            dgvkhachhang.DataSource = dt;
            dgvkhachhang.Show();
            // Autosize table
            for (int i = 0; i < dgvkhachhang.Columns.Count - 1; i++)
            {
                dgvkhachhang.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            dgvkhachhang.Columns[dgvkhachhang.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
               
        private void ResetTextBox()//Reset trắng nội dung các TextBox, gán dữ liệu ban đầu cho RadioButton, DateTimPickup
        {
            tbmakh.Clear();
            tbtenkh.Clear();
            tbdiachi.Clear();
            tbdienthoai.Clear();
             
        }
        private void btthem_Click(object sender, EventArgs e)
        {
            try
            {
                TrangThai = FState.IsEditing;
                groupBox1.Enabled = true;
                SetEditing();
                dgvkhachhang.Enabled = false;
            }
            catch(Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            
            if (tbmakh.Text!="" && tbtenkh.Text != "" && tbdiachi.Text != "" && tbdienthoai.Text != "" )
            {
                
                string sql = "INSERT INTO Khach VALUES(N'" + tbmakh.Text + "',N'" + tbtenkh.Text + "',N'" + tbdiachi.Text + "',N'" + tbdienthoai.Text + "')";
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
                if (tbmakh.Text != "" && tbtenkh.Text != "" && tbdiachi.Text != "" && tbdienthoai.Text != "")
                {
                    DialogResult result = MessageBox.Show("Bạn có muốn sửa không ?", "Thông báo", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        condb.connect();
                        string sql = "Update Khach Set MaKhach =N'" + tbmakh.Text + "', TenKhach =N'" + tbtenkh.Text + "',DiaChi = N'" + tbdiachi.Text + "',DienThoai = N'" + tbdienthoai.Text + "'Where MaKhach ='" + tbmakh.Text + "'";
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

        private void btxoa_Click(object sender, EventArgs e)
        {
            try
            {
                condb.connect();
                string sql = "DELETE FROM Khach Where MaKhach='"+tbmakh.Text+"'";
                condb.ExecuteNonQuery(sql);
                MessageBox.Show("Xóa Thành Công!!");
                showData();
            }
            catch
            {
                MessageBox.Show("Lỗi dữ liệu");
            }
        }
        private void btthoat_Click(object sender, EventArgs e)
        {
            
            if(TrangThai == FState.IsViewing)
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
            condb.connect();
            string sql="";
            if (rbmakh.Checked)
            {              
                 sql = "SELECT * FROM Khach Where MaKhach Like N'%" + tbtimkiem.Text + "%'";
                condb.ExcuteQuery(sql);
            }
            if(rbtenkh.Checked)
            {
                sql = "SELECT * FROM Khach Where TenKhach Like N'%" + tbtimkiem.Text + "%'";
                condb.ExcuteQuery(sql);                
            }
            DataTable dt = condb.getDataTable(sql);
            dgvkhachhang.DataSource = dt;
            dgvkhachhang.Show();
            // Autosize table
            for (int i = 0; i < dgvkhachhang.Columns.Count - 1; i++)
            {
                dgvkhachhang.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            dgvkhachhang.Columns[dgvkhachhang.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void rbmakh_CheckedChanged(object sender, EventArgs e)
        {

        }
        

        private void dgvkhachhang_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                groupBox1.Enabled = true; // Groupbox thông tin KH mở
                int VT = 0;
                if (VT != null && VT >= 0)
                {
                    VT = dgvkhachhang.CurrentCell.RowIndex;
                    tbmakh.Text = dgvkhachhang.Rows[VT].Cells[0].Value.ToString();
                    tbtenkh.Text = dgvkhachhang.Rows[VT].Cells[1].Value.ToString();
                    tbdiachi.Text = dgvkhachhang.Rows[VT].Cells[2].Value.ToString();
                    tbdienthoai.Text = dgvkhachhang.Rows[VT].Cells[3].Value.ToString();
                }
            }
            catch( Exception a)
            {
                MessageBox.Show(a.Message);
            }
            

        }

        
    }
}
