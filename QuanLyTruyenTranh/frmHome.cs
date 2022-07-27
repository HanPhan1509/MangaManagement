using QuanLyTruyenTranh;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MangaManagementProject
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void btnMangaStore_Click(object sender, EventArgs e)
        {
            frmMangaStore fMangastore = new frmMangaStore();
            fMangastore.Show();
            this.Hide();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            frmStaff fStaff = new frmStaff();
            fStaff.Show();
            this.Hide();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            frmCustomer fCus = new frmCustomer();
            fCus.Show();
            this.Hide();
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            frmSell fSell = new frmSell();
            fSell.Show();
            this.Hide();
        }

        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn đăng xuất khỏi tài khoản này?", "thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                frmLogin fLogin = new frmLogin();
                fLogin.Show();
                this.Close();
            }
        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAccount fAccount = new frmAccount();
            fAccount.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
