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
    public partial class frmPayment : Form
    {
        public frmPayment()
        {
            InitializeComponent();
        }

        private void txtReceive_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                long money = long.Parse(txtReceive.Text);
                long price = long.Parse(txtTotalPricePay.Text);
                txtExcess.Text = (money - price) + "";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            frmHome fHome = new frmHome();
            fHome.Show();
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtReceive.Text = null;
            txtExcess.Text = null;
        }

        private void frmPayment_Load(object sender, EventArgs e)
        {
            BUL_Sell bulSell = new BUL_Sell();
            DataTable dt = bulSell.getTotalPrice();
            DataRow dr = dt.Rows[0];
            string total = dr[0].ToString();
            txtTotalPricePay.Text = total;
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanh toán thành công!\n Đang xuất hóa đơn...", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            BUL_Sell bulSell = new BUL_Sell();
            DataTable dt = bulSell.deleteSell();
            frmSell fSell = new frmSell();
            fSell.Show();
            this.Close();
        }
    }
}
