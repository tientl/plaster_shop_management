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
            btnThemSp.Enabled = true;
            btnSuaSP.Enabled = true;
            btnXoaSp.Enabled = true;
            txtDonGiaBan.Enabled = true;
            txtSoLuong.Enabled = true;
            cbxTenHang.Enabled = true;
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
            TrangThai = FState.IsViewing;
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
            DongiaBan();


        }

        private void LoadCBoxMaKhach()
        {
            condb.connect();
            string sql = "SELECT * FROM Khach ";
            DataTable dt = condb.getDataTable(sql);
            cbTenKhach.DataSource = dt;
            cbMaKhach.DataSource = dt;
            cbMaKhach.DisplayMember = "MaKhach";
            cbTenKhach.DisplayMember = "TenKhach";
            cbTenKhach.Show();
            cbMaKhach.Show();
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
                dgvListSP.Refresh();
                
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
        public void showDataCTHD()
        {
            string sql = "SELECT ct.MaHDBan,ct.TenHang,ct.SoLuong,h.DonGiaBan,ct.TongTien FROM ChiTietHD ct,Hang h WHERE ct.MaHang = h.MaHang AND ct.MaHDBan = '"+tbMaHD.Text+"'";
           // string sql = "SELECT * FROM HDBan h,ChiTietHD ct WHERE ct.MaHDBan = h.MaHDBan";
            DataTable dt = condb.getDataTable(sql);
            dgvListSP.DataSource = dt;
            dgvListSP.Show();
            // Autosize table
            for (int i = 0; i < dgvListSP.Columns.Count - 1; i++)
            {
                dgvListSP.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            dgvListSP.Columns[dgvListSP.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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

                string sql = "INSERT INTO HDBan VALUES(N'" + tbMaHD.Text + "','" + cbMaKhach.Text + "',N'" + cbTenKhach.Text + "',N'" + tbMaNV.Text + "',CONVERT(DATE,'" + date.Value + "',103),N'"+cbxTrangThai.Text+"')";
                condb.ExecuteNonQuery(sql);
                MessageBox.Show("Thêm Thành Công!!");
                showData();
                ResetTextBox();
                SetViewing();

                int R = dgvHoaDon.Rows.Count-1;
                tbMaHD.Text = dgvHoaDon.Rows[R].ToString();
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
                GrChiTietHD.Enabled = true; // Groupbox thông tin KH mở
                int VT=0;
                if (VT != null && VT >= 0)
                {
                    VT = dgvHoaDon.CurrentCell.RowIndex;
                    tbMaHD.Text = dgvHoaDon.Rows[VT].Cells[0].Value.ToString();
                    cbMaKhach.Text = dgvHoaDon.Rows[VT].Cells[1].Value.ToString();
                    cbTenKhach.Text = dgvHoaDon.Rows[VT].Cells[2].Value.ToString();
                    tbMaNV.Text = dgvHoaDon.Rows[VT].Cells[3].Value.ToString();
                    date.Text = dgvHoaDon.Rows[VT].Cells[4].Value.ToString();
                    showDataCTHD();
                    TongTien();
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

        private void btThemKhach_Click(object sender, EventArgs e)
        {
            formKhach fK = new formKhach();
            fK.Show();           
            this.Hide();
        }

        private void btnThemSp_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtSoLuong.Text != "")
                {
                    float DHB, Tong;
                    int SL;
                    DHB = float.Parse(txtDonGiaBan.Text);
                    SL = int.Parse(txtSoLuong.Text);
                    Tong = DHB * SL;
                    string sql = "INSERT INTO ChiTietHD VALUES(N'" + tbMaHD.Text + "','" + cbxTenHang.SelectedValue.ToString() + "',N'" + cbxTenHang.Text + "',N'" + txtSoLuong.Text + "',N'" + Tong + "')";
                    condb.ExecuteNonQuery(sql);
                    showDataCTHD();
                    //ResetTextBox();
                    //SetViewing();
                }
                else
                {
                    MessageBox.Show("Hãy nhập Số Lượng !!");
                }
            }
            catch
            {
                MessageBox.Show("Mặt Hàng đã tồn tại!!!");
            }

        }
             

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            condb.connect();
            string sql = "";
            if (rbMaHD.Checked)
            {
                sql = "SELECT * FROM HDBan Where MaHDBan Like N'%" + tbtimkiem.Text + "%'";
                condb.ExcuteQuery(sql);
            }
            if (rbTenKhach.Checked)
            {
                sql = "SELECT * FROM HDBan Where TenKhach Like N'%" + tbtimkiem.Text + "%'";
                condb.ExcuteQuery(sql);
            }
            DataTable dt = condb.getDataTable(sql);
            dgvHoaDon.DataSource = dt;
            dgvHoaDon.Show();
            
        }

        

        private void btXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa " + tbMaHD.Text + "Không ?", "Thông Báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    condb.connect();
                    string sql = "DELETE FROM ChiTietHD  Where MaHDBan='" + tbMaHD.Text + "' " +
                        "DELETE FROM HDBan Where MaHDBan = '" + tbMaHD.Text + "'"  ;


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

        private void cbxTenHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            DongiaBan();
        }
        private void DongiaBan()
        {
            SqlConnection Conn = new SqlConnection(condb.Path());
            Conn.Open();
            string MaHang = cbxTenHang.SelectedValue.ToString();
            string sqlquery = "SELECT DonGiaBan From Hang WHERE MaHang = '" + MaHang + "'";

            SqlCommand command = new SqlCommand(sqlquery, Conn);

            SqlDataReader sdr = command.ExecuteReader();

            while (sdr.Read())
            {
                txtDonGiaBan.Text = sdr["DonGiaBan"].ToString();
            }
        }

        private void dgvListSP_SelectionChanged(object sender, EventArgs e)
        {
            dgvListSP_CellContentClick();
        }

        private void dgvListSP_CellContentClick()
        {
            int VT = 0;
            VT = dgvListSP.CurrentCell.RowIndex;
            if(VT != -1)
            {
                cbxTenHang.Text = dgvListSP.Rows[VT].Cells[1].Value.ToString();
                txtSoLuong.Text = dgvListSP.Rows[VT].Cells[2].Value.ToString();
                txtDonGiaBan.Text = dgvListSP.Rows[VT].Cells[3].Value.ToString();
            }
                      
            //showDataCTHD();
        }

        private void btnSuaSP_Click(object sender, EventArgs e)
        {
            try
            {
                condb.connect();
                string sql = "Update ChiTietHD  Set SoLuong =N'" + txtSoLuong.Text + "'Where MaHang ='" + cbxTenHang.SelectedValue.ToString() + "'";
                condb.ExecuteNonQuery(sql);
                MessageBox.Show("Sửa Thành Công");
                showDataCTHD();
            }
            catch
            {

            }
        }

        private void btnXoaSp_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa " + cbxTenHang.Text + "Không ?", "Thông Báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    condb.connect();
                    string sql = "DELETE FROM ChiTietHD  Where MaHang='" + cbxTenHang.SelectedValue.ToString() + "' " ;                      
                    condb.ExecuteNonQuery(sql);
                    MessageBox.Show("Xóa Thành Công!!");
                    showDataCTHD();
                }

            }
            catch
            {
                MessageBox.Show("Lỗi dữ liệu");
            }
        }

        

        private void TongTien()
        {
            SqlConnection Conn = new SqlConnection(condb.Path());
            Conn.Open();
            string MaHang = cbxTenHang.SelectedValue.ToString();
            string sql = " SELECT SUM(TongTien) AS Total FROM ChiTietHD ct Where MaHDBan = '" + tbMaHD.Text + "' ";

            SqlCommand command = new SqlCommand(sql, Conn);

            SqlDataReader sdr = command.ExecuteReader();

            while (sdr.Read())
            {
                lbTongTien.Text = sdr["Total"].ToString();
            }
        }

        

        private void dgvListSP_DataSourceChanged(object sender, EventArgs e)
        {
            TongTien();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxTrangThai.Checked = true)
            {
                cbxTrangThai.Enabled = true;
                btLuu.Enabled = true;
            }    
        }

        private void btformGhiNo_Click(object sender, EventArgs e)
        {
            formGhiNo fGN = new formGhiNo();
            this.Hide();
            fGN.Show();
            
        }

        private void cbxTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkBoxTrangThai.Checked == true)
            {
                string sql = "Update HDBan Set TrangThai = N'" + cbxTrangThai.Text + "'Where MaHDBan ='" + tbMaHD.Text + "'";
                condb.ExecuteNonQuery(sql);
                MessageBox.Show("Thêm Thành Công!!");
                showData();
                ResetTextBox();
                SetViewing();
            }
        }

        
    }
}
