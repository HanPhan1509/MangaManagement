using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUL;
using QuanLyTruyenTranh;

namespace MangaManagementProject
{
    public partial class frmLogin : Form
    {
        protected Boolean success = false;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (checkLogin() == true)
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.success = true;
                    frmHome fHome = new frmHome();
                    fHome.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại");
                    txtUsername.Text = null;
                    txtPassword.Text = null;
                }
            }

            
            

        }

        public Boolean checkLogin()
        {
            string userName = txtUsername.Text;
            string passWord = txtPassword.Text;
            
            BUL_Account bulAcc = new BUL_Account();
            Account acc = new Account(userName, passWord);
            DataTable daAccount = bulAcc.Login("LoginAccount", acc);

            if (daAccount.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmRegister fReg = new frmRegister();
            fReg.Show();
            this.Hide();
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                e.Cancel = true;
                txtUsername.Focus();
                errorProvider.SetError(txtUsername, "Vui lòng nhập username!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtUsername, null);
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                e.Cancel = true;
                txtPassword.Focus();
                errorProvider.SetError(txtPassword, "Vui lòng nhập password!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtPassword, null);
            }
        }
    }
}
