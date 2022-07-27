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
    public partial class frmSell : Form
    {
        public frmSell()
        {
            InitializeComponent();
        }

        private void loadDataGridView()
        {
            BUL_Sell bulSell = new BUL_Sell();
            dgvSell.DataSource = bulSell.getDataSell("GetDataSell");
        }

        private void frmSell_Load(object sender, EventArgs e)
        {
            loadDataGridView();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadDataGridView();
            txtMangaName.Text = null;
            txtIDManga.Text = null;
            mnQuantitySell.Value = 0;
            cbxMembers.Checked = false;
            txtPrice.Text = null;
        }

        private void cbxMembers_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxMembers.Checked == true)
            {
                //txtNameCustomer.Enabled = true;
                //txtIDCustomer.Enabled = true;
                btnSearchCustomer.Enabled = true;
                txtPhoneSearch.Enabled = true;
            }
            else
            {
                //txtNameCustomer.Enabled = false;
                //txtIDCustomer.Enabled = false;
                btnSearchCustomer.Enabled = false;
                txtPhoneSearch.Enabled = false;
            }

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

        private void dgvSell_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Chọn và hiển thị nội dung vào textbox
            /*ID, IDCustomer, IDManga, CustomerName, MangaName, Price, Quantity*/
            int i = e.RowIndex;
            txtIDSell.Text = (string)dgvSell.Rows[i].Cells[0].Value.ToString();
            txtIDCustomer.Text = (string)dgvSell.Rows[i].Cells[1].Value.ToString();
            txtNameCustomer.Text = dgvSell.Rows[i].Cells[2].Value.ToString();
            txtIDManga.Text = (string)dgvSell.Rows[i].Cells[3].Value.ToString();
            txtMangaName.Text = dgvSell.Rows[i].Cells[4].Value.ToString();
            txtPrice.Text = (string)dgvSell.Rows[i].Cells[5].Value.ToString();
            mnQuantitySell.Text = (string)dgvSell.Rows[i].Cells[6].Value.ToString();
        }

        private void btnAddSell_Click(object sender, EventArgs e)
        {
            /*ID, IDCustomer, IDManga, CustomerName, MangaName, Price, Quantity*/
            int idCus = int.Parse(txtIDCustomer.Text);
            int idManga = int.Parse(txtIDManga.Text);
            string cusName = txtNameCustomer.Text;
            string mgName = txtMangaName.Text;
            int price = int.Parse(txtPrice.Text);
            int quantity = int.Parse(mnQuantitySell.Text);

            Sell sell = new Sell(idCus, idManga, cusName, mgName, price, quantity);
            BUL_Sell bulSell = new BUL_Sell();
            if (bulSell.addData(sell) > 0)
            {
                MessageBox.Show("Đã thêm thành công!");
                dgvSell.DataSource = bulSell.getDataSell("GetDataSell");
            }
        }

        private void btnEditSell_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtIDSell.Text);
            int idCus = int.Parse(txtIDCustomer.Text);
            int idManga = int.Parse(txtIDManga.Text);
            string cusName = txtNameCustomer.Text;
            string mgName = txtMangaName.Text;
            int price = int.Parse(txtPrice.Text);
            int quantity = int.Parse(mnQuantitySell.Text);

            Sell sell = new Sell(id, idCus, idManga, cusName, mgName, price, quantity);
            BUL_Sell bulSell = new BUL_Sell();
            if (bulSell.editData(sell) > 0)
            {
                MessageBox.Show("Đã cập nhật thành công!");
                dgvSell.DataSource = bulSell.getDataSell("GetDataSell");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa truyện tranh này?", "Cảnh báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                int id = int.Parse(txtIDSell.Text);
                int idCus = int.Parse(txtIDCustomer.Text);
                int idManga = int.Parse(txtIDManga.Text);
                string cusName = txtNameCustomer.Text;
                string mgName = txtMangaName.Text;
                int price = int.Parse(txtPrice.Text);
                int quantity = int.Parse(mnQuantitySell.Text);

                Sell sell = new Sell(id, idCus, idManga, cusName, mgName, price, quantity);
                BUL_Sell bulSell = new BUL_Sell();
                if (bulSell.deleteData(sell) > 0)
                {
                    MessageBox.Show("Đã xóa thành công!");
                    dgvSell.DataSource = bulSell.getDataSell("GetDataSell");
                }
            }
        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            string phone = txtPhoneSearch.Text;
            if (phone != null)
            {
                BUL_Sell bulSell = new BUL_Sell();
                DataTable dt = bulSell.searchInfoCustomer("GetIDNameCustomer", phone);
                DataRow dr = dt.Rows[0];
                string id = dr["ID"].ToString();
                string name = dr["Name"].ToString();
                txtIDCustomer.Text = id;
                txtNameCustomer.Text = name;
            }

        }

        private void btnSearchIDManga_Click(object sender, EventArgs e)
        {
            string nameMg = txtMangaName.Text;
            if (nameMg != null)
            {
                BUL_Sell bulSell = new BUL_Sell();
                DataTable dt = bulSell.searchNameManga("GetNameManga", nameMg);
                DataRow dr = dt.Rows[0];
                string id = dr["ID"].ToString();
                //nameMg = dr["Name"].ToString();
                string price = dr["Price"].ToString();
                txtIDManga.Text = id;
                //txtNameCustomer.Text = nameMg;
                txtPrice.Text = price;
            }
        }

        private void mnQuantitySell_ValueChanged(object sender, EventArgs e)
        {
            if (txtMangaName.Text == null)
            {
                MessageBox.Show("Vui lòng nhập tên Manga bạn muốn bán!");
            }
            else
            {
                if (mnQuantitySell.Value != 0)
                {
                    int quantity = int.Parse(mnQuantitySell.Value.ToString());
                    int num = int.Parse(txtPrice.Text);
                    int kq = num * quantity;
                    txtPrice.Text = kq.ToString();
                } else
                {
                    MessageBox.Show("Vui lòng nhập số lượng bạn cần mua!");
                }
            }
        }

        private void txtTotalPrice_TextChanged(object sender, EventArgs e)
        {
            //if (dgvSell.Rows.Count != 0)
            //{
            //    for (int i = 0; i <= dgvSell.Rows.Count; i++)
            //    {
            //        int pri = 0;
            //        pri += int.Parse(dgvSell.Rows[i].Cells[5].Value.ToString());
            //        txtTotalPrice.Text = pri.ToString();
            //    }
            //}
        }

        private void dgvSell_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //int pri = 0;
            //for (int i = 0; i <= dgvSell.Rows.Count; i++)
            //{
            //    pri += int.Parse(dgvSell.Rows[i].Cells[5].Value.ToString());
            //    txtTotalPrice.Text = pri.ToString();
            //}
        }

        private void btnTotalPrice_Click(object sender, EventArgs e)
        {
            if (dgvSell.Rows.Count != 0)
            {
                try
                {
                    BUL_Sell bulSell = new BUL_Sell();
                    DataTable dt = bulSell.getTotalPrice();
                    DataRow dr = dt.Rows[0];
                    string total = dr[0].ToString();
                    txtTotalPrice.Text = total;
                    //int pri = 0;
                    //for (int i = 0; i < dgvSell.Rows.Count; i++)
                    //{
                    //    pri = int.Parse(dgvSell.Rows[i].Cells[5].Value.ToString());
                    //}
                    ////txtTotalPrice.Text = pri.ToString();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
            {
                MessageBox.Show("Chưa có đơn hàng!");
            }
        }

        //public int GetValue()
        //{            
        //    int price = int.Parse(txtTotalPrice.Text);
        //    return price;
        //}

        private void btnPay_Click(object sender, EventArgs e)
        {
            frmPayment fPay = new frmPayment();
            fPay.Show();
            this.Hide();
        }
    }
}
