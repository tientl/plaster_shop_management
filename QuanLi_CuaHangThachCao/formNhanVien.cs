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
    public partial class formNhanVien : Form
    {
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
            tbdiachi.Clear();
            tbdienthoai.Clear();
            tbmakh.Clear();
            tbtenkh.Clear();
                        

        }
        public formNhanVien()
        {
            InitializeComponent();
        }

        private void formNhanVien_Load(object sender, EventArgs e)
        {


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dgvkhachhang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
