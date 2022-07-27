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
    public partial class frmStaff : Form
    {
        public frmStaff()
        {
            InitializeComponent();
        }

        private void loadDataGridView()
        {
            BUL_Staff bulStaff = new BUL_Staff();
            dgvStaff.DataSource = bulStaff.getDataStaff("GetDataStaff");
        }

        private void frmStaff_Load(object sender, EventArgs e)
        {
            loadDataGridView();
        }

        private void dgvStaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Chọn và hiển thị nội dung vào textbox
            int i = e.RowIndex;
            txtIDStaff.Text = (string)dgvStaff.Rows[i].Cells[0].Value.ToString();
            txtNameStaff.Text = dgvStaff.Rows[i].Cells[1].Value.ToString();
            string sex = dgvStaff.Rows[i].Cells[2].Value.ToString();

            if (sex == "nam")
            {
                cbxSexStaff.SelectedIndex = 0;
            }
            else if (sex == "nu")
            {
                cbxSexStaff.SelectedIndex = 1;
            }

            dtpBirthStaff.Text = dgvStaff.Rows[i].Cells[3].Value.ToString();
            txtAddressStaff.Text = dgvStaff.Rows[i].Cells[4].Value.ToString();
            txtPhoneStaff.Text = dgvStaff.Rows[i].Cells[5].Value.ToString();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtIDStaff.Text = null;
            txtNameStaff.Text = null;
            cbxSexStaff.SelectedItem = null;
            dtpBirthStaff.Value = DateTime.Now;
            txtAddressStaff.Text = null;
            txtPhoneStaff.Text = null;
            loadDataGridView();
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            string name = txtNameStaff.Text;
            string sex = cbxSexStaff.SelectedItem.ToString();
            DateTime dateOfBirth = dtpBirthStaff.Value.Date;
            string address = txtAddressStaff.Text;
            string phone = txtPhoneStaff.Text;

            Staff staff = new Staff(name, sex, dateOfBirth, address, phone);
            BUL_Staff staffBUL = new BUL_Staff();
            if (staffBUL.addData(staff) > 0)
            {
                MessageBox.Show("Đã thêm thành công!");
                dgvStaff.DataSource = staffBUL.getDataStaff("GetDataStaff");
            }
        }

        private void btnEditStaff_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtIDStaff.Text);
            string name = txtNameStaff.Text;
            string sex = cbxSexStaff.SelectedItem.ToString();
            DateTime dateOfBirth = dtpBirthStaff.Value.Date;
            string address = txtAddressStaff.Text;
            string phone = txtPhoneStaff.Text;

            Staff staff = new Staff(id, name, sex, dateOfBirth, address, phone);
            BUL_Staff staffBUL = new BUL_Staff();
            if (staffBUL.editData(staff) > 0)
            {
                MessageBox.Show("Đã cập nhật thành công!");
                dgvStaff.DataSource = staffBUL.getDataStaff("GetDataStaff");
            }

        }

        private void btnbtnDeleteStaff_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Cảnh báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                int id = int.Parse(txtIDStaff.Text);
                string name = txtNameStaff.Text;
                string sex = cbxSexStaff.SelectedItem.ToString();
                DateTime dateOfBirth = dtpBirthStaff.Value.Date;
                string address = txtAddressStaff.Text;
                string phone = txtPhoneStaff.Text;

                Staff staff = new Staff(id, name, sex, dateOfBirth, address, phone);
                BUL_Staff staffBUL = new BUL_Staff();
                if (staffBUL.deleteData(staff) > 0)
                {
                    MessageBox.Show("Đã xóa thành công!");
                    dgvStaff.DataSource = staffBUL.getDataStaff("GetDataStaff");
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = txtSearchPhoneStaff.Text;
            BUL_Staff staffBUL = new BUL_Staff();
            dgvStaff.DataSource = staffBUL.searchData("SearchPhoneStaff", search);
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
