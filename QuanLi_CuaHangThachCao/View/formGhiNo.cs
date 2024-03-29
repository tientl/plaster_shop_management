﻿using System;
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
            dgvGhiNo.Enabled = true;
            btLuu.Enabled = false;
            btthem.Enabled = true;
            btsua.Enabled = true;
            btxoa.Enabled = true;
            btLuu.Enabled = false;
            btThemTT.Enabled = true;
            btSuaTT.Enabled = true;
            btXoaTT.Enabled = true;
            
            btthoat.Text = "Thoát";
        }
        private void SetEditing()
        {
            ResetTextBox();
            btthem.Enabled = false;
            btxoa.Enabled = false;
            btsua.Enabled = false;
            btLuu.Enabled = true;
            btThemTT.Enabled = false;
            btSuaTT.Enabled = false;
            btXoaTT.Enabled = false;
            btthoat.Text = "Hủy";
        }
        private void ResetTextBox()//Reset trắng nội dung các TextBox, gán dữ liệu ban đầu cho RadioButton, DateTimPickup
        {
            cbxMaHD.Text = "";
            cbxTenKhach.Text = "";
            tbMaNV.Text = "";
            tbMaNV.Clear();
            tbTienDaTra.Clear();
            

        }
        public formGhiNo()
        {
            InitializeComponent();
            TrangThai = FState.IsViewing;
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
        public void showDataCTGhiNo()
        {
            string sql = "SELECT ct.MaHDBan,ct.TienTra,ct.NgayTra,ct.TienConLai FROM ChiTietGhiNo ct,GhiNo n WHERE ct.MaHDBan = n.MaHDBan AND ct.MaHDBan = '" + cbxMaHD.Text+"'";
            DataTable dt = condb.getDataTable(sql);
            dgvCTGhiNo.DataSource = dt;
            dgvCTGhiNo.Show();
            // Autosize table
            for (int i = 0; i < dgvCTGhiNo.Columns.Count - 1; i++)
            {
                dgvCTGhiNo.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            dgvCTGhiNo.Columns[dgvCTGhiNo.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void LoadCBoxMaHD()
        {
            condb.connect();
            string sql = "SELECT * FROM HDBan WHERE TrangThai = N'Nợ'";
            DataTable dt = condb.getDataTable(sql);
            cbxMaHD.DataSource = dt;
            cbxTenKhach.DataSource = dt;          
            cbxMaHD.DisplayMember = "MaHDBan";           
            cbxTenKhach.DisplayMember = "TenKhach";
            cbxMaHD.Show();
            cbxTenKhach.Show();
            
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            TrangThai = FState.IsEditing;
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbTienTra.Text != "" && tbMaNV.Text != "")
                {

                    condb.connect();
                    
                    float TienCL = float.Parse(tbTongTien.Text) - float.Parse(tbTienTra.Text);
                    lbTongTien.Text = TienCL.ToString();
                    string sql = "INSERT INTO GhiNo VALUES(N'" + cbxMaHD.Text + "',N'" + cbxTenKhach.Text + "',N'" + tbMaNV.Text + "',N'" + TienCL + "')" +
                        "INSERT INTO ChiTietGhiNo VALUES(N'" + cbxMaHD.Text + "',N'" + tbTienTra.Text + "',CONVERT(date,'" + dateNgayTra.Text + "',103),N'" + TienCL + "')";
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

        private void dgvGhiNo_SelectionChanged(object sender, EventArgs e)
        {
            int VT = 0;
            if (VT != null && VT >= 0)
            {
                VT = dgvGhiNo.CurrentCell.RowIndex;
                cbxMaHD.Text = dgvGhiNo.Rows[VT].Cells[0].Value.ToString();
                cbxTenKhach.Text = dgvGhiNo.Rows[VT].Cells[1].Value.ToString();
                tbMaNV.Text = dgvGhiNo.Rows[VT].Cells[2].Value.ToString();
                lbTongTien.Text = dgvGhiNo.Rows[VT].Cells[3].Value.ToString();
                showDataCTGhiNo();
            }


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btsua_Click(object sender, EventArgs e)
        {
            try
            {

                if (tbMaNV.Text != "" && tbTienDaTra.Text != "")
                {
                    DialogResult result = MessageBox.Show("Bạn có muốn sửa không ?", "Thông báo", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        int TienCL = Int32.Parse(lbTongTien.Text) - Int32.Parse(tbTienDaTra.Text);
                        condb.connect();
                        string sql = "Update GhiNo Set TienDaTra =N'" + tbTienDaTra.Text + "', NgayTra =CONVERT(DATE,'" + dateNgayTra.Value + "',103),TienConLai = N'" + TienCL + "' Where MaHDBan ='" + cbxMaHD.Text + "'";
                        condb.ExecuteNonQuery(sql);
                        MessageBox.Show("Sửa Thành Công");
                        showData();
                    }

                }
                else
                {
                    MessageBox.Show("Hãy nhập thông tin cần SỬA !!");
                }
                if (Int32.Parse(lbTongTien.Text) < 1)
                {
                    DialogResult result = MessageBox.Show("Bạn có muốn Sửa " + cbxMaHD.Text + " Không ?", "Thông Báo", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        string sql = "Update HDBan Set TrangThai = N'Thanh Toán Xong' Where MaHDBan ='" + cbxMaHD.Text + "'";
                        condb.ExecuteNonQuery(sql);
                    }
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
                if (Int32.Parse(lbTongTien.Text) < 1)
                {
                    DialogResult result = MessageBox.Show("Bạn có muốn xóa " + cbxMaHD.Text + " Không ?", "Thông Báo", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        condb.connect();
                        string sql = "DELETE FROM GhiNo  Where MaHDBan='" + cbxMaHD.Text + "' ";
                        condb.ExecuteNonQuery(sql);
                        MessageBox.Show("Xóa Thành Công!!");
                        showData();
                    }
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

        private void tbtimkiem_TextChanged(object sender, EventArgs e)
        {
            condb.connect();
            string sql = "";
            if (rbMaHD.Checked)
            {
                sql = "SELECT * FROM GhiNo Where MaHDBan Like N'%" + tbtimkiem.Text + "%'";
                condb.ExcuteQuery(sql);
            }
            if (rbTenKhach.Checked)
            {
                sql = "SELECT * FROM HDBan Where TenKhach Like N'%" + tbtimkiem.Text + "%'";
                condb.ExcuteQuery(sql);
            }
            DataTable dt = condb.getDataTable(sql);
            dgvGhiNo.DataSource = dt;
            dgvGhiNo.Show();
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

        private void button1_Click(object sender, EventArgs e)
        {
            if(lbTongTien.Text == "0")
            {
                string sql = "Update HDBan Set TrangThai = N'Thanh Toán Xong'Where MaHDBan ='" + cbxMaHD.Text + "'";
                condb.ExecuteNonQuery(sql);
                MessageBox.Show("Thêm Thành Công!!");
                showData();
                ResetTextBox();
                SetViewing();
            }
        }
        private void TongTien()
        {
            SqlConnection Conn = new SqlConnection(condb.Path());
            Conn.Open();
            
            string sql = " SELECT SUM(TongTien) AS Total FROM ChiTietHD Where MaHDBan = '" + cbxMaHD.Text + "' ";

            SqlCommand command = new SqlCommand(sql, Conn);

            SqlDataReader sdr = command.ExecuteReader();
            
            while (sdr.Read())
            {
                
                tbTongTien.Text = sdr["Total"].ToString();
            }
        }
        

        private void cbxMaHD_SelectedIndexChanged(object sender, EventArgs e)
        {
            TongTien();
        }

        

        private void btThemTT_Click(object sender, EventArgs e)
        {
            
            if (tbTienTra.Text != "" )
            {
                condb.connect();                 
                int TienCL = Int32.Parse(lbTongTien.Text) - Int32.Parse(tbTienTra.Text);
                if(TienCL < 1)
                {
                    lbTongTien.Text = "0";
                    string sql = "INSERT INTO ChiTietGhiNo VALUES(N'" + cbxMaHD.Text + "',N'" + tbTienTra.Text + "',CONVERT(DATE,'" + dateNgayTra.Value + "',103),N'" + lbTongTien.Text + "')" +
                            "Update GhiNo Set TienConLai = '" + lbTongTien.Text + "' Where MaHDBan ='" + cbxMaHD.Text + "'";
                    condb.ExecuteNonQuery(sql);
                }
                else
                {
                    lbTongTien.Text = TienCL.ToString();
                    string sql = "INSERT INTO ChiTietGhiNo VALUES(N'" + cbxMaHD.Text + "',N'" + tbTienTra.Text + "',CONVERT(DATE,'" + dateNgayTra.Value + "',103),N'" + TienCL + "')" +
                            "Update GhiNo Set TienConLai = '" + TienCL + "' Where MaHDBan ='" + cbxMaHD.Text + "'";
                    condb.ExecuteNonQuery(sql);
                }    
                
                
                MessageBox.Show("Thêm Thành Công!!");
                showDataCTGhiNo();
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

        
    }
}
