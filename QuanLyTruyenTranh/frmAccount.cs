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
    public partial class frmAccount : Form
    {
        public frmAccount()
        {
            InitializeComponent();
        }

        private void frmAccount_Load(object sender, EventArgs e)
        {
            BUL_Account bulAcc = new BUL_Account();
            dgvAccount.DataSource = bulAcc.getDataAccount("GetDataAccount");
        }

        //Chọn và hiển thị nội dung vào textbox
        private void dgvAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtIDAcc.Text = (string)dgvAccount.Rows[i].Cells[0].Value.ToString();
            txtUsernameAcc.Text = dgvAccount.Rows[i].Cells[1].Value.ToString();
            txtPasswordAcc.Text = dgvAccount.Rows[i].Cells[2].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản này?", "Cảnh báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                int id = int.Parse(txtIDAcc.Text);
                string sUsername = txtUsernameAcc.Text;
                string sPassword = txtPasswordAcc.Text;

                Account acc = new Account(id, sUsername, sPassword);
                BUL_Account bulAcc = new BUL_Account();
                if (bulAcc.deleteData(acc) > 0)
                {
                    MessageBox.Show("Đã xóa tài khoản thành công!");
                    dgvAccount.DataSource = bulAcc.getDataAccount("GetDataAccount");
                }
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            int iID = int.Parse(txtIDAcc.Text);
            string sUsername = txtUsernameAcc.Text;
            string sPassword = txtPasswordAcc.Text;

            Account acc = new Account(iID, sUsername, sPassword);
            BUL_Account bulAcc = new BUL_Account();
            if (bulAcc.editData(acc) > 0)
            {
                MessageBox.Show("Đã cập nhật!");
                dgvAccount.DataSource = bulAcc.getDataAccount("GetDataAccount");
            }
        }

        private void btnUsernameSearch_Click(object sender, EventArgs e)
        {
            string search = txtUsernameSearch.Text;
            BUL_Account bulAcc = new BUL_Account();
            dgvAccount.DataSource = bulAcc.searchData("SearchAcc", search);
        }
        
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                frmHome fHome = new frmHome();
                fHome.Show();
                this.Close();
            }
        }
    }
}
