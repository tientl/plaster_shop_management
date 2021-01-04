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
    
    public partial class formNhapKho : Form
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
            tbmakh.Enabled = false;
            dgvKho.Enabled = true;
            btLuu.Enabled = false;
            btthem.Enabled = true;
            btsua.Enabled = true;
            btxoa.Enabled = true;
            btthoat.Text = "Thoát";
        }
        private void SetEditing()
        {
            ResetTextBox();
            tbmakh.Enabled = true;
            btxoa.Enabled = false;
            btsua.Enabled = false;
            btthem.Enabled = false;
            btLuu.Enabled = true;
            btthoat.Text = "Hủy";
        }
        public formNhapKho()
        {
            InitializeComponent();
            TrangThai = FState.IsViewing;
            showData();
        }

        public void showData()
        {
            string sql = "SELECT * FROM NhapKho";
            DataTable dt = condb.getDataTable(sql);
            dgvKho.DataSource = dt;
            dgvKho.Show();
            // Autosize table
            for (int i = 0; i < dgvKho.Columns.Count - 1; i++)
            {
                dgvKho.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            dgvKho.Columns[dgvKho.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void ResetTextBox()//Reset trắng nội dung các TextBox, gán dữ liệu ban đầu cho RadioButton, DateTimPickup
        {
            tbmakh.Clear();
            tbtenkh.Clear();
            tbTenChatLieu.Clear();
            tbSoluong.Clear();
            tbTongTien.Clear();
            tbDiaChiNhap.Clear();
            tbDonGiaNhap.Clear();

        }
        private void btthem_Click(object sender, EventArgs e)
        {
            try
            {
                SetEditing();
                TrangThai = FState.IsEditing;
                groupBox1.Enabled = true;
                AutoUp();
                dgvKho.Enabled = false;
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {

            if (tbmakh.Text != "" && tbtenkh.Text != "" && tbTenChatLieu.Text != "" && tbSoluong.Text != "")
            {

                string sql = "INSERT INTO NhapKho VALUES(N'" + tbmakh.Text + "',N'" + tbtenkh.Text + "',N'" + tbTenChatLieu.Text + "',N'" + tbSoluong.Text + "',N'" + tbDonGiaNhap.Text + "',N'" + tbDiaChiNhap.Text + "',N'" + tbTongTien.Text + "',Convert(date,'"+dataNgayNhap.Value+"',103))";
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
        private void btsua_Click(object sender, EventArgs e)
        {

            try
            {
                if (tbmakh.Text != "" && tbtenkh.Text != "" && tbTenChatLieu.Text != "" && tbSoluong.Text != "")
                {
                    DialogResult result = MessageBox.Show("Bạn có muốn sửa không ?", "Thông báo", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        condb.connect();
                        string sql = "Update NhapKho Set MaHang =N'" + tbmakh.Text + "', TenHang =N'" + tbtenkh.Text + "',TenChatLieu=N'" + tbTenChatLieu.Text + "',SoLuong=N'" + tbSoluong.Text + "',DonGiaNhap=N'" + tbDonGiaNhap.Text + "',DiaChiNhap=N'" + tbDiaChiNhap.Text + "',TongTien=N'" + tbTongTien.Text + "',NgayNhap=Convert(date,'" + dataNgayNhap.Value + "',103) Where MaHang = '"+tbmakh+"'";
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
                DialogResult result = MessageBox.Show("Bạn có muốn xóa " + tbtenkh.Text + "Không ?", "Thông Báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    condb.connect();
                    string sql = "DELETE FROM NhapKho Where MaHang='" + tbmakh.Text + "'";
                    condb.ExecuteNonQuery(sql);
                    MessageBox.Show("Xóa Thành Công!!");
                    showData();
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
                    this.Close();
                Main main = new Main();
                main.Show();

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
            string sql = "";
            if (rbmakh.Checked)
            {
                sql = "SELECT * FROM Khach Where MaKhach Like N'%" + tbtimkiem.Text + "%'";
                condb.ExcuteQuery(sql);
            }
            if (rbtenHang.Checked)
            {
                sql = "SELECT * FROM Khach Where TenKhach Like N'%" + tbtimkiem.Text + "%'";
                condb.ExcuteQuery(sql);
            }
            DataTable dt = condb.getDataTable(sql);
            dgvKho.DataSource = dt;
            dgvKho.Show();
            // Autosize table
            for (int i = 0; i < dgvKho.Columns.Count - 1; i++)
            {
                dgvKho.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            dgvKho.Columns[dgvKho.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }




        private void dgvkhachhang_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                groupBox1.Enabled = true; // Groupbox thông tin KH mở
                int VT = 0;
                if (VT != null && VT >= 0)
                {
                    VT = dgvKho.CurrentCell.RowIndex;
                    tbmakh.Text = dgvKho.Rows[VT].Cells[0].Value.ToString();
                    tbtenkh.Text = dgvKho.Rows[VT].Cells[1].Value.ToString();
                    tbTenChatLieu.Text = dgvKho.Rows[VT].Cells[2].Value.ToString();
                    tbSoluong.Text = dgvKho.Rows[VT].Cells[3].Value.ToString();
                    tbDonGiaNhap.Text = dgvKho.Rows[VT].Cells[4].Value.ToString();
                    tbDiaChiNhap.Text = dgvKho.Rows[VT].Cells[5].Value.ToString();
                    tbTongTien.Text = dgvKho.Rows[VT].Cells[6].Value.ToString();
                    dataNgayNhap.Text = dgvKho.Rows[VT].Cells[7].Value.ToString();
                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void AutoUp()
        {
            Random ra = new Random();
            int ra1 = ra.Next(1, 50);
            int count = dgvKho.Rows.Count;
            if (count > 9)
            {
                tbmakh.Text = "H" + count++ + "-" + ra1;
            }
            else
            {
                tbmakh.Text = "H0" + count++ + "-" + ra1;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            formHoaDon fHD = new formHoaDon();
            Main m = new Main();
            m.Hide();
            fHD.Show();
            this.Close();

        }

        
    }
}
