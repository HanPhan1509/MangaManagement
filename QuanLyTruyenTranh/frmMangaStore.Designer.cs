
namespace MangaManagementProject
{
    partial class frmMangaStore
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMangaStore));
            this.dgvMangaStore = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearchMG = new System.Windows.Forms.Button();
            this.txtSearchMG = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDMG = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNameMG = new System.Windows.Forms.TextBox();
            this.txtAuthorMG = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGenreMG = new System.Windows.Forms.TextBox();
            this.txtPriceMG = new System.Windows.Forms.TextBox();
            this.txtPublishingCompanyMG = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mnQuantityMG = new System.Windows.Forms.NumericUpDown();
            this.cbxMangaCover = new System.Windows.Forms.ComboBox();
            this.cbxMangaVersion = new System.Windows.Forms.ComboBox();
            this.btnAddMG = new System.Windows.Forms.Button();
            this.btnEditMG = new System.Windows.Forms.Button();
            this.btnDeleteMG = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMangaStore)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mnQuantityMG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMangaStore
            // 
            this.dgvMangaStore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMangaStore.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvMangaStore.Location = new System.Drawing.Point(0, 0);
            this.dgvMangaStore.Name = "dgvMangaStore";
            this.dgvMangaStore.RowTemplate.Height = 25;
            this.dgvMangaStore.Size = new System.Drawing.Size(416, 411);
            this.dgvMangaStore.TabIndex = 0;
            this.dgvMangaStore.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMangaStore_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.btnSearchMG);
            this.panel1.Controls.Add(this.txtSearchMG);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(416, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(568, 79);
            this.panel1.TabIndex = 1;
            // 
            // btnSearchMG
            // 
            this.btnSearchMG.BackColor = System.Drawing.Color.Teal;
            this.btnSearchMG.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearchMG.ForeColor = System.Drawing.Color.Transparent;
            this.btnSearchMG.Location = new System.Drawing.Point(438, 19);
            this.btnSearchMG.Name = "btnSearchMG";
            this.btnSearchMG.Size = new System.Drawing.Size(118, 39);
            this.btnSearchMG.TabIndex = 5;
            this.btnSearchMG.Text = "SEARCH";
            this.btnSearchMG.UseVisualStyleBackColor = false;
            this.btnSearchMG.Click += new System.EventHandler(this.btnSearchMG_Click);
            // 
            // txtSearchMG
            // 
            this.txtSearchMG.Font = new System.Drawing.Font("Book Antiqua", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txtSearchMG.Location = new System.Drawing.Point(99, 25);
            this.txtSearchMG.Multiline = true;
            this.txtSearchMG.Name = "txtSearchMG";
            this.txtSearchMG.PlaceholderText = "Enter manga name...";
            this.txtSearchMG.Size = new System.Drawing.Size(320, 30);
            this.txtSearchMG.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(422, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID:";
            // 
            // txtIDMG
            // 
            this.txtIDMG.Enabled = false;
            this.txtIDMG.Font = new System.Drawing.Font("Book Antiqua", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txtIDMG.Location = new System.Drawing.Point(515, 85);
            this.txtIDMG.Multiline = true;
            this.txtIDMG.Name = "txtIDMG";
            this.txtIDMG.Size = new System.Drawing.Size(320, 30);
            this.txtIDMG.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(422, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(422, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Author:";
            // 
            // txtNameMG
            // 
            this.txtNameMG.Font = new System.Drawing.Font("Book Antiqua", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txtNameMG.Location = new System.Drawing.Point(515, 121);
            this.txtNameMG.Multiline = true;
            this.txtNameMG.Name = "txtNameMG";
            this.txtNameMG.Size = new System.Drawing.Size(320, 30);
            this.txtNameMG.TabIndex = 2;
            // 
            // txtAuthorMG
            // 
            this.txtAuthorMG.Font = new System.Drawing.Font("Book Antiqua", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txtAuthorMG.Location = new System.Drawing.Point(515, 156);
            this.txtAuthorMG.Multiline = true;
            this.txtAuthorMG.Name = "txtAuthorMG";
            this.txtAuthorMG.Size = new System.Drawing.Size(320, 30);
            this.txtAuthorMG.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(422, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "Genre:";
            // 
            // txtGenreMG
            // 
            this.txtGenreMG.Font = new System.Drawing.Font("Book Antiqua", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txtGenreMG.Location = new System.Drawing.Point(515, 190);
            this.txtGenreMG.Multiline = true;
            this.txtGenreMG.Name = "txtGenreMG";
            this.txtGenreMG.Size = new System.Drawing.Size(320, 30);
            this.txtGenreMG.TabIndex = 4;
            // 
            // txtPriceMG
            // 
            this.txtPriceMG.Font = new System.Drawing.Font("Book Antiqua", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txtPriceMG.Location = new System.Drawing.Point(515, 297);
            this.txtPriceMG.Multiline = true;
            this.txtPriceMG.Name = "txtPriceMG";
            this.txtPriceMG.Size = new System.Drawing.Size(320, 30);
            this.txtPriceMG.TabIndex = 6;
            // 
            // txtPublishingCompanyMG
            // 
            this.txtPublishingCompanyMG.Font = new System.Drawing.Font("Book Antiqua", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txtPublishingCompanyMG.Location = new System.Drawing.Point(590, 262);
            this.txtPublishingCompanyMG.Multiline = true;
            this.txtPublishingCompanyMG.Name = "txtPublishingCompanyMG";
            this.txtPublishingCompanyMG.Size = new System.Drawing.Size(246, 30);
            this.txtPublishingCompanyMG.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(422, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 21);
            this.label6.TabIndex = 18;
            this.label6.Text = "Price:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Teal;
            this.label7.Location = new System.Drawing.Point(422, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 21);
            this.label7.TabIndex = 17;
            this.label7.Text = "Publishing company:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Teal;
            this.label8.Location = new System.Drawing.Point(422, 234);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 21);
            this.label8.TabIndex = 15;
            this.label8.Text = "Cover type:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Teal;
            this.label9.Location = new System.Drawing.Point(642, 233);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 21);
            this.label9.TabIndex = 23;
            this.label9.Text = "Version:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(422, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 21);
            this.label5.TabIndex = 21;
            this.label5.Text = "Quantity:";
            // 
            // mnQuantityMG
            // 
            this.mnQuantityMG.Location = new System.Drawing.Point(515, 338);
            this.mnQuantityMG.Name = "mnQuantityMG";
            this.mnQuantityMG.Size = new System.Drawing.Size(110, 23);
            this.mnQuantityMG.TabIndex = 7;
            // 
            // cbxMangaCover
            // 
            this.cbxMangaCover.FormattingEnabled = true;
            this.cbxMangaCover.ItemHeight = 15;
            this.cbxMangaCover.Items.AddRange(new object[] {
            "Soft cover (Normal)",
            "Hard cover",
            "Loose cover"});
            this.cbxMangaCover.Location = new System.Drawing.Point(515, 233);
            this.cbxMangaCover.Name = "cbxMangaCover";
            this.cbxMangaCover.Size = new System.Drawing.Size(121, 23);
            this.cbxMangaCover.TabIndex = 26;
            // 
            // cbxMangaVersion
            // 
            this.cbxMangaVersion.FormattingEnabled = true;
            this.cbxMangaVersion.ItemHeight = 15;
            this.cbxMangaVersion.Items.AddRange(new object[] {
            "Normal version",
            "Collectible version",
            "Special version",
            "Limited edition version"});
            this.cbxMangaVersion.Location = new System.Drawing.Point(715, 233);
            this.cbxMangaVersion.Name = "cbxMangaVersion";
            this.cbxMangaVersion.Size = new System.Drawing.Size(121, 23);
            this.cbxMangaVersion.TabIndex = 27;
            // 
            // btnAddMG
            // 
            this.btnAddMG.BackColor = System.Drawing.Color.Teal;
            this.btnAddMG.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddMG.ForeColor = System.Drawing.Color.Transparent;
            this.btnAddMG.Location = new System.Drawing.Point(854, 147);
            this.btnAddMG.Name = "btnAddMG";
            this.btnAddMG.Size = new System.Drawing.Size(118, 39);
            this.btnAddMG.TabIndex = 6;
            this.btnAddMG.Text = "ADD";
            this.btnAddMG.UseVisualStyleBackColor = false;
            this.btnAddMG.Click += new System.EventHandler(this.btnAddMG_Click);
            // 
            // btnEditMG
            // 
            this.btnEditMG.BackColor = System.Drawing.Color.Teal;
            this.btnEditMG.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditMG.ForeColor = System.Drawing.Color.Transparent;
            this.btnEditMG.Location = new System.Drawing.Point(854, 199);
            this.btnEditMG.Name = "btnEditMG";
            this.btnEditMG.Size = new System.Drawing.Size(118, 39);
            this.btnEditMG.TabIndex = 28;
            this.btnEditMG.Text = "EDIT";
            this.btnEditMG.UseVisualStyleBackColor = false;
            this.btnEditMG.Click += new System.EventHandler(this.btnEditMG_Click);
            // 
            // btnDeleteMG
            // 
            this.btnDeleteMG.BackColor = System.Drawing.Color.Teal;
            this.btnDeleteMG.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteMG.ForeColor = System.Drawing.Color.Transparent;
            this.btnDeleteMG.Location = new System.Drawing.Point(854, 252);
            this.btnDeleteMG.Name = "btnDeleteMG";
            this.btnDeleteMG.Size = new System.Drawing.Size(118, 39);
            this.btnDeleteMG.TabIndex = 29;
            this.btnDeleteMG.Text = "DELETE";
            this.btnDeleteMG.UseVisualStyleBackColor = false;
            this.btnDeleteMG.Click += new System.EventHandler(this.btnDeleteMG_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Teal;
            this.btnRefresh.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRefresh.ForeColor = System.Drawing.Color.Transparent;
            this.btnRefresh.Location = new System.Drawing.Point(854, 93);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(118, 39);
            this.btnRefresh.TabIndex = 30;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnExit.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExit.ForeColor = System.Drawing.Color.Transparent;
            this.btnExit.Location = new System.Drawing.Point(854, 360);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(118, 39);
            this.btnExit.TabIndex = 31;
            this.btnExit.Text = "&EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmMangaStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyTruyenTranh.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(984, 411);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDeleteMG);
            this.Controls.Add(this.btnEditMG);
            this.Controls.Add(this.btnAddMG);
            this.Controls.Add(this.cbxMangaVersion);
            this.Controls.Add(this.cbxMangaCover);
            this.Controls.Add(this.mnQuantityMG);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPriceMG);
            this.Controls.Add(this.txtPublishingCompanyMG);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtGenreMG);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAuthorMG);
            this.Controls.Add(this.txtNameMG);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIDMG);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvMangaStore);
            this.Name = "frmMangaStore";
            this.Text = "Manga Store";
            this.Load += new System.EventHandler(this.frmMangaStore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMangaStore)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mnQuantityMG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMangaStore;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSearchMG;
        private System.Windows.Forms.Button btnSearchMG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDMG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNameMG;
        private System.Windows.Forms.TextBox txtAuthorMG;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGenreMG;
        private System.Windows.Forms.TextBox txtPriceMG;
        private System.Windows.Forms.TextBox txtPublishingCompanyMG;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown mnQuantityMG;
        private System.Windows.Forms.ComboBox cbxMangaCover;
        private System.Windows.Forms.ComboBox cbxMangaVersion;
        private System.Windows.Forms.Button btnAddMG;
        private System.Windows.Forms.Button btnEditMG;
        private System.Windows.Forms.Button btnDeleteMG;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}