using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DTO;
using BUL;

namespace MangaManagementProject
{
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
        }

        private void loadDataGridView()
        {
            BUL_Customer bulCus = new BUL_Customer();
            dgvCustomer.DataSource = bulCus.getDataCustomer("GetDataCustomer");
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            loadDataGridView();
        }

        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Chọn và hiển thị nội dung vào textbox
            int i = e.RowIndex;
            txtCustomerID.Text = (string)dgvCustomer.Rows[i].Cells[0].Value.ToString();
            txtCustomerName.Text = dgvCustomer.Rows[i].Cells[1].Value.ToString();
            string sex = dgvCustomer.Rows[i].Cells[2].Value.ToString();

            if (sex == "nam")
            {
                cbxSexCustomer.SelectedIndex = 0;
            }
            else if (sex == "nu")
            {
                cbxSexCustomer.SelectedIndex = 1;
            }

            dtpBirthCustomer.Text = dgvCustomer.Rows[i].Cells[3].Value.ToString();
            txtCustomerAddress.Text = dgvCustomer.Rows[i].Cells[4].Value.ToString();
            txtPhoneCustomer.Text = dgvCustomer.Rows[i].Cells[5].Value.ToString();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtCustomerID.Text = null;
            txtCustomerName.Text = null;
            cbxSexCustomer.SelectedItem = null;
            dtpBirthCustomer.Value = DateTime.Now;
            txtCustomerAddress.Text = null;
            txtPhoneCustomer.Text = null;
            loadDataGridView();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            string name = txtCustomerName.Text;
            string sex = cbxSexCustomer.SelectedItem.ToString();
            DateTime dateOfBirth = dtpBirthCustomer.Value.Date;
            string address = txtCustomerAddress.Text;
            string phone = txtPhoneCustomer.Text;

            Customer cus = new Customer(name, sex, dateOfBirth, address, phone);
            BUL_Customer bulCus = new BUL_Customer();
            if (bulCus.addData(cus) > 0)
            {
                MessageBox.Show("Đã thêm thành công!");
                dgvCustomer.DataSource = bulCus.getDataCustomer("GetDataCustomer");
            }
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCustomerID.Text);
            string name = txtCustomerName.Text;
            string sex = cbxSexCustomer.SelectedItem.ToString();
            DateTime dateOfBirth = dtpBirthCustomer.Value.Date;
            string address = txtCustomerAddress.Text;
            string phone = txtPhoneCustomer.Text;

            Customer cus = new Customer(id, name, sex, dateOfBirth, address, phone);
            BUL_Customer bulCus = new BUL_Customer();
            if (bulCus.editData(cus) > 0)
            {
                MessageBox.Show("Đã cập nhật thành công!");
                dgvCustomer.DataSource = bulCus.getDataCustomer("GetDataCustomer");
            }
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa thông tn của khách hàng này?", "Cảnh báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                int id = int.Parse(txtCustomerID.Text);
                string name = txtCustomerName.Text;
                string sex = cbxSexCustomer.SelectedItem.ToString();
                DateTime dateOfBirth = dtpBirthCustomer.Value.Date;
                string address = txtCustomerAddress.Text;
                string phone = txtPhoneCustomer.Text;

                Customer cus = new Customer(id, name, sex, dateOfBirth, address, phone);
                BUL_Customer bulCus = new BUL_Customer();
                if (bulCus.deleteData(cus) > 0)
                {
                    MessageBox.Show("Đã cập nhật thành công!");
                    dgvCustomer.DataSource = bulCus.getDataCustomer("GetDataCustomer");
                }
            }
        }

        private void btnSearchPhoneCustomer_Click(object sender, EventArgs e)
        {
            string search = txtPhoneSearchCustomer.Text;
            BUL_Customer bulCus = new BUL_Customer();
            dgvCustomer.DataSource = bulCus.searchData("SearchPhoneCustomer", search);
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
