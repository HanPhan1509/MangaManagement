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
    public partial class frmMangaStore : Form
    {
        public frmMangaStore()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtNameMG.Focus();
            txtSearchMG.Text = null;
            txtIDMG.Text = null;
            txtNameMG.Text = null;
            txtAuthorMG.Text = null;
            txtGenreMG.Text = null;
            cbxMangaCover.SelectedItem = null;
            cbxMangaVersion.SelectedItem = null;
            txtPublishingCompanyMG.Text = null;
            txtPriceMG.Text = null;
            mnQuantityMG.Value = 0;
            loadDataGridView();
            errorProvider.SetError(txtNameMG, null);
            errorProvider.SetError(txtAuthorMG, null);
            errorProvider.SetError(txtGenreMG, null);
            errorProvider.SetError(cbxMangaCover, null);
            errorProvider.SetError(cbxMangaVersion, null);
            errorProvider.SetError(txtPublishingCompanyMG, null);
            errorProvider.SetError(txtPublishingCompanyMG, null);
            errorProvider.SetError(txtPublishingCompanyMG, null);
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

        private void loadDataGridView()
        {
            BUL_MangaStore bulManga = new BUL_MangaStore();
            dgvMangaStore.DataSource = bulManga.getDataMangaStore("GetDataMangaStore");
        }    

        private void frmMangaStore_Load(object sender, EventArgs e)
        {
            loadDataGridView();
        }

        private void btnAddMG_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNameMG.Text))
            {
                txtNameMG.Focus();
                errorProvider.SetError(txtNameMG, "Nhập vào tên manga!");
            }
            else if (string.IsNullOrEmpty(txtAuthorMG.Text))
            {
                txtAuthorMG.Focus();
                errorProvider.SetError(txtAuthorMG, "Nhập vào tên tác giả!");
            }
            else if (string.IsNullOrEmpty(txtGenreMG.Text))
            {
                txtGenreMG.Focus();
                errorProvider.SetError(txtGenreMG, "Nhập vào thể loại manga!");
            }
            else if (cbxMangaCover.SelectedItem == null)
            {
                cbxMangaCover.Focus();
                errorProvider.SetError(cbxMangaCover, "Nhập vào loại bìa manga!");
            }
            else if (cbxMangaVersion.SelectedItem == null)
            {
                cbxMangaVersion.Focus();
                errorProvider.SetError(cbxMangaVersion, "Nhập vào phiên bản manga!");
            }
            else if (string.IsNullOrEmpty(txtPublishingCompanyMG.Text))
            {
                txtPublishingCompanyMG.Focus();
                errorProvider.SetError(txtPublishingCompanyMG, "Nhập vào tên nhà xuất bản!");
            }
            else if (string.IsNullOrEmpty(txtPriceMG.Text))
            {
                txtPriceMG.Focus();
                errorProvider.SetError(txtPriceMG, "Nhập vào giá tiền!");
            }
            else
            {
                string name = txtNameMG.Text;
                string author = txtAuthorMG.Text;
                string genre = txtGenreMG.Text;
                string covertype = cbxMangaCover.SelectedItem.ToString();
                string version = cbxMangaVersion.SelectedItem.ToString();
                string publishing = txtPublishingCompanyMG.Text;
                int price = int.Parse(txtPriceMG.Text);
                int quantity = int.Parse(mnQuantityMG.Value.ToString());
                MangaStore mangaStore = new MangaStore(name, author, genre, covertype, version, publishing, price, quantity);
                BUL_MangaStore mgBUL = new BUL_MangaStore();
                if (mgBUL.addData(mangaStore) > 0)
                {
                    MessageBox.Show("Đã thêm thành công!");
                    dgvMangaStore.DataSource = mgBUL.getDataMangaStore("GetDataMangaStore");
                    txtNameMG.Focus();
                    txtIDMG.Text = null;
                    txtNameMG.Text = null;
                    txtAuthorMG.Text = null;
                    txtGenreMG.Text = null;
                    cbxMangaCover.SelectedItem = null;
                    cbxMangaVersion.SelectedItem = null;
                    txtPublishingCompanyMG.Text = null;
                    txtPriceMG.Text = null;
                    mnQuantityMG.Value = 0;
                }
            }
        }

        private void dgvMangaStore_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Chọn và hiển thị nội dung vào textbox
            /*ID, Name, author, genre, covertype, version, publishing company, price, quantity*/
            int i = e.RowIndex;
            txtIDMG.Text = (string)dgvMangaStore.Rows[i].Cells[0].Value.ToString();
            txtNameMG.Text = dgvMangaStore.Rows[i].Cells[1].Value.ToString();
            txtAuthorMG.Text = dgvMangaStore.Rows[i].Cells[2].Value.ToString();
            txtGenreMG.Text = dgvMangaStore.Rows[i].Cells[3].Value.ToString();

            //cbxMangaCover.Text = dgvMangaStore.Rows[i].Cells[5].Value.ToString();
            string cover = dgvMangaStore.Rows[i].Cells[4].Value.ToString();

            if (cover == "Soft cover(Normal)")
            {
                cbxMangaCover.SelectedIndex = 0;
            }
            else if (cover == "Hard cover")
            {
                cbxMangaCover.SelectedIndex = 1;
            }
            else if (cover == "Loose cover")
            {
                cbxMangaCover.SelectedIndex = 2;
            }

            string version = dgvMangaStore.Rows[i].Cells[5].Value.ToString();

            if (version == "Normal version")
            {
                cbxMangaVersion.SelectedIndex = 0;
            }
            else if (version == "Collectible version")
            {
                cbxMangaVersion.SelectedIndex = 1;
            }
            else if (version == "Special version")
            {
                cbxMangaVersion.SelectedIndex = 2;
            }
            else if (version == "Limited edition version")
            {
                cbxMangaVersion.SelectedIndex = 3;
            }

            txtPublishingCompanyMG.Text = dgvMangaStore.Rows[i].Cells[6].Value.ToString();
            txtPriceMG.Text = (string)dgvMangaStore.Rows[i].Cells[7].Value.ToString();
            mnQuantityMG.Text = (string)dgvMangaStore.Rows[i].Cells[8].Value.ToString();
        }

        private void btnDeleteMG_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa truyện tranh này?", "Cảnh báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                int id = int.Parse(txtIDMG.Text);
                string name = txtNameMG.Text;
                string author = txtAuthorMG.Text;
                string genre = txtGenreMG.Text;
                string covertype = cbxMangaCover.SelectedItem.ToString();
                string version = cbxMangaVersion.SelectedItem.ToString();
                string publishing = txtPublishingCompanyMG.Text;
                int price = int.Parse(txtPriceMG.Text);
                int quantity = int.Parse(mnQuantityMG.Value.ToString());

                MangaStore mangaStore = new MangaStore(id, name, author, genre, covertype, version, publishing, price, quantity);
                BUL_MangaStore mgBUL = new BUL_MangaStore();
                if (mgBUL.deleteData(mangaStore) > 0)
                {
                    MessageBox.Show("Đã xóa thành công!");
                    dgvMangaStore.DataSource = mgBUL.getDataMangaStore("GetDataMangaStore");
                    txtNameMG.Focus();
                    txtIDMG.Text = null;
                    txtNameMG.Text = null;
                    txtAuthorMG.Text = null;
                    txtGenreMG.Text = null;
                    cbxMangaCover.SelectedItem = null;
                    cbxMangaVersion.SelectedItem = null;
                    txtPublishingCompanyMG.Text = null;
                    txtPriceMG.Text = null;
                    mnQuantityMG.Value = 0;
                }
            }
        }

        private void btnEditMG_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtIDMG.Text);
            string name = txtNameMG.Text;
            string author = txtAuthorMG.Text;
            string genre = txtGenreMG.Text;
            string covertype = cbxMangaCover.SelectedItem.ToString();
            string version = cbxMangaVersion.SelectedItem.ToString();
            string publishing = txtPublishingCompanyMG.Text;
            int price = int.Parse(txtPriceMG.Text);
            int quantity = int.Parse(mnQuantityMG.Value.ToString());

            MangaStore mangaStore = new MangaStore(id, name, author, genre, covertype, version, publishing, price, quantity);
            BUL_MangaStore mgBUL = new BUL_MangaStore();
            if (mgBUL.editData(mangaStore) > 0)
            {
                MessageBox.Show("Đã cập nhật!");
                dgvMangaStore.DataSource = mgBUL.getDataMangaStore("GetDataMangaStore");
            }
        }

        private void btnSearchMG_Click(object sender, EventArgs e)
        {
            string search = txtSearchMG.Text;

            if (string.IsNullOrEmpty(txtSearchMG.Text))
            {
                txtSearchMG.Focus();
                errorProvider.SetError(txtSearchMG, "Nhập vào tên manga mà bạn muốn tìm!");
            } else
            {
                BUL_MangaStore mgBUL = new BUL_MangaStore();
                if (mgBUL.searchData("SearchMangaStore", search) == null)
                {
                    MessageBox.Show("Manga bạn tìm không tồn tại");
                } else
                {
                    dgvMangaStore.DataSource = mgBUL.searchData("SearchMangaStore", search);
                }
            }
        }
    }
}
