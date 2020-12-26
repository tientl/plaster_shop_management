using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLi_CuaHangThachCao.View
{
    public partial class FormLogin : Form
    {
        private string username;
        private string password;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            username = txtUsername.Text.Trim();
            password = txtPassword.Text.Trim();

            if (username.Length == 0 || password.Length == 0)
               MessageBox.Show("Tài khoản và mật khẩu không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                // sql injection - ' or '1' = '1
                string query = "SELECT * FROM TAIKHOAN WHERE UserName = '" + username + "' AND Password = '" + password + "';";
                DataTable dtUser = new ConnectionDB().getDataTable(query);
                if (dtUser.Rows.Count != 1) 
                    MessageBox.Show("Sai tai khoan hoac mat khau");
                else
                {
                    new Main().Show();
                    this.Hide();
                }
            }    
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có muốn thoát chương trình?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
