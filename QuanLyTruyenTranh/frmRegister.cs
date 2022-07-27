using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DTO;
using BUL;
using MangaManagementProject;

namespace QuanLyTruyenTranh
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string userName = txtUsername.Text;
            string passWord = txtPassword.Text;

            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                Account acc = new Account(userName, passWord);
                BUL_Account bulAcc = new BUL_Account();
                if (bulAcc.addData(acc) > 0)
                {
                    MessageBox.Show("Đăng ký tài khoản thành công!");
                    txtUsername.Text = null;
                    txtPassword.Text = null;
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            
            this.Close();
            frmLogin fLogin = new frmLogin();
            fLogin.Show();
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                e.Cancel = true;
                txtUsername.Focus();
                errorProvider.SetError(txtUsername, "Vui lòng nhập password!");
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
