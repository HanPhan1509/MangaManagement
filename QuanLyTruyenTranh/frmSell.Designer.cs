
namespace QuanLyTruyenTranh
{
    partial class frmSell
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
            this.dgvSell = new System.Windows.Forms.DataGridView();
            this.txtMangaName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDCustomer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPhoneSearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNameCustomer = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSearchCustomer = new System.Windows.Forms.Button();
            this.cbxMembers = new System.Windows.Forms.CheckBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSearchIDManga = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddSell = new System.Windows.Forms.Button();
            this.btnEditSell = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtIDManga = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mnQuantitySell = new System.Windows.Forms.NumericUpDown();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtIDSell = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTotalPrice = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSell)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mnQuantitySell)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSell
            // 
            this.dgvSell.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSell.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvSell.Location = new System.Drawing.Point(0, 238);
            this.dgvSell.Name = "dgvSell";
            this.dgvSell.RowTemplate.Height = 25;
            this.dgvSell.Size = new System.Drawing.Size(964, 274);
            this.dgvSell.TabIndex = 1;
            this.dgvSell.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSell_CellContentClick);
            this.dgvSell.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvSell_RowsAdded);
            // 
            // txtMangaName
            // 
            this.txtMangaName.Font = new System.Drawing.Font("Book Antiqua", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txtMangaName.Location = new System.Drawing.Point(132, 58);
            this.txtMangaName.Multiline = true;
            this.txtMangaName.Name = "txtMangaName";
            this.txtMangaName.Size = new System.Drawing.Size(255, 30);
            this.txtMangaName.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(6, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Manga\'s name:";
            // 
            // txtIDCustomer
            // 
            this.txtIDCustomer.Enabled = false;
            this.txtIDCustomer.Font = new System.Drawing.Font("Book Antiqua", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txtIDCustomer.Location = new System.Drawing.Point(159, 97);
            this.txtIDCustomer.Multiline = true;
            this.txtIDCustomer.Name = "txtIDCustomer";
            this.txtIDCustomer.Size = new System.Drawing.Size(234, 30);
            this.txtIDCustomer.TabIndex = 56;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(6, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 21);
            this.label3.TabIndex = 55;
            this.label3.Text = "Customer\'s ID:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtPhoneSearch);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtNameCustomer);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnSearchCustomer);
            this.groupBox1.Controls.Add(this.cbxMembers);
            this.groupBox1.Controls.Add(this.txtIDCustomer);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.Teal;
            this.groupBox1.Location = new System.Drawing.Point(12, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 181);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer";
            // 
            // txtPhoneSearch
            // 
            this.txtPhoneSearch.Enabled = false;
            this.txtPhoneSearch.Font = new System.Drawing.Font("Book Antiqua", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txtPhoneSearch.Location = new System.Drawing.Point(159, 57);
            this.txtPhoneSearch.Multiline = true;
            this.txtPhoneSearch.Name = "txtPhoneSearch";
            this.txtPhoneSearch.Size = new System.Drawing.Size(234, 30);
            this.txtPhoneSearch.TabIndex = 68;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Teal;
            this.label7.Location = new System.Drawing.Point(6, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 21);
            this.label7.TabIndex = 67;
            this.label7.Text = "Customer\'s Phone:";
            // 
            // txtNameCustomer
            // 
            this.txtNameCustomer.Enabled = false;
            this.txtNameCustomer.Font = new System.Drawing.Font("Book Antiqua", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txtNameCustomer.Location = new System.Drawing.Point(159, 133);
            this.txtNameCustomer.Multiline = true;
            this.txtNameCustomer.Name = "txtNameCustomer";
            this.txtNameCustomer.Size = new System.Drawing.Size(234, 30);
            this.txtNameCustomer.TabIndex = 65;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Teal;
            this.label9.Location = new System.Drawing.Point(6, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 21);
            this.label9.TabIndex = 64;
            this.label9.Text = "Customer\'s name:";
            // 
            // btnSearchCustomer
            // 
            this.btnSearchCustomer.BackColor = System.Drawing.Color.Teal;
            this.btnSearchCustomer.Enabled = false;
            this.btnSearchCustomer.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearchCustomer.ForeColor = System.Drawing.Color.Transparent;
            this.btnSearchCustomer.Location = new System.Drawing.Point(275, 15);
            this.btnSearchCustomer.Name = "btnSearchCustomer";
            this.btnSearchCustomer.Size = new System.Drawing.Size(118, 39);
            this.btnSearchCustomer.TabIndex = 63;
            this.btnSearchCustomer.Text = "SEARCH";
            this.btnSearchCustomer.UseVisualStyleBackColor = false;
            this.btnSearchCustomer.Click += new System.EventHandler(this.btnSearchCustomer_Click);
            // 
            // cbxMembers
            // 
            this.cbxMembers.AutoSize = true;
            this.cbxMembers.Location = new System.Drawing.Point(15, 26);
            this.cbxMembers.Name = "cbxMembers";
            this.cbxMembers.Size = new System.Drawing.Size(183, 25);
            this.cbxMembers.TabIndex = 62;
            this.cbxMembers.Text = "Members of the store";
            this.cbxMembers.UseVisualStyleBackColor = true;
            this.cbxMembers.CheckedChanged += new System.EventHandler(this.cbxMembers_CheckedChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Teal;
            this.btnRefresh.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRefresh.ForeColor = System.Drawing.Color.Transparent;
            this.btnRefresh.Location = new System.Drawing.Point(834, 8);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(118, 39);
            this.btnRefresh.TabIndex = 62;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSearchIDManga
            // 
            this.btnSearchIDManga.BackColor = System.Drawing.Color.Teal;
            this.btnSearchIDManga.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearchIDManga.ForeColor = System.Drawing.Color.Transparent;
            this.btnSearchIDManga.Location = new System.Drawing.Point(269, 15);
            this.btnSearchIDManga.Name = "btnSearchIDManga";
            this.btnSearchIDManga.Size = new System.Drawing.Size(118, 39);
            this.btnSearchIDManga.TabIndex = 64;
            this.btnSearchIDManga.Text = "SEARCH";
            this.btnSearchIDManga.UseVisualStyleBackColor = false;
            this.btnSearchIDManga.Click += new System.EventHandler(this.btnSearchIDManga_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Teal;
            this.btnExit.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExit.ForeColor = System.Drawing.Color.Transparent;
            this.btnExit.Location = new System.Drawing.Point(834, 189);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(118, 39);
            this.btnExit.TabIndex = 68;
            this.btnExit.Text = "&EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddSell
            // 
            this.btnAddSell.BackColor = System.Drawing.Color.Teal;
            this.btnAddSell.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddSell.ForeColor = System.Drawing.Color.Transparent;
            this.btnAddSell.Location = new System.Drawing.Point(834, 54);
            this.btnAddSell.Name = "btnAddSell";
            this.btnAddSell.Size = new System.Drawing.Size(118, 39);
            this.btnAddSell.TabIndex = 69;
            this.btnAddSell.Text = "ADD";
            this.btnAddSell.UseVisualStyleBackColor = false;
            this.btnAddSell.Click += new System.EventHandler(this.btnAddSell_Click);
            // 
            // btnEditSell
            // 
            this.btnEditSell.BackColor = System.Drawing.Color.Teal;
            this.btnEditSell.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditSell.ForeColor = System.Drawing.Color.Transparent;
            this.btnEditSell.Location = new System.Drawing.Point(834, 99);
            this.btnEditSell.Name = "btnEditSell";
            this.btnEditSell.Size = new System.Drawing.Size(118, 39);
            this.btnEditSell.TabIndex = 70;
            this.btnEditSell.Text = "EDIT";
            this.btnEditSell.UseVisualStyleBackColor = false;
            this.btnEditSell.Click += new System.EventHandler(this.btnEditSell_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Teal;
            this.btnDelete.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.Color.Transparent;
            this.btnDelete.Location = new System.Drawing.Point(834, 144);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(118, 39);
            this.btnDelete.TabIndex = 71;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.Teal;
            this.label10.Location = new System.Drawing.Point(6, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 21);
            this.label10.TabIndex = 72;
            this.label10.Text = "Manga\'s ID:";
            // 
            // txtIDManga
            // 
            this.txtIDManga.Enabled = false;
            this.txtIDManga.Font = new System.Drawing.Font("Book Antiqua", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txtIDManga.Location = new System.Drawing.Point(132, 21);
            this.txtIDManga.Multiline = true;
            this.txtIDManga.Name = "txtIDManga";
            this.txtIDManga.Size = new System.Drawing.Size(131, 30);
            this.txtIDManga.TabIndex = 73;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.mnQuantitySell);
            this.groupBox2.Controls.Add(this.txtIDManga);
            this.groupBox2.Controls.Add(this.txtPrice);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.btnSearchIDManga);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtMangaName);
            this.groupBox2.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.Color.Teal;
            this.groupBox2.Location = new System.Drawing.Point(435, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(393, 181);
            this.groupBox2.TabIndex = 66;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Manga Store";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(6, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 21);
            this.label4.TabIndex = 86;
            this.label4.Text = "Price:";
            // 
            // mnQuantitySell
            // 
            this.mnQuantitySell.Location = new System.Drawing.Point(132, 96);
            this.mnQuantitySell.Name = "mnQuantitySell";
            this.mnQuantitySell.Size = new System.Drawing.Size(110, 27);
            this.mnQuantitySell.TabIndex = 85;
            this.mnQuantitySell.ValueChanged += new System.EventHandler(this.mnQuantitySell_ValueChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.Enabled = false;
            this.txtPrice.Font = new System.Drawing.Font("Book Antiqua", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txtPrice.Location = new System.Drawing.Point(132, 129);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(255, 30);
            this.txtPrice.TabIndex = 87;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(6, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 21);
            this.label5.TabIndex = 84;
            this.label5.Text = "Quantity:";
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.Teal;
            this.btnPay.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPay.ForeColor = System.Drawing.Color.Transparent;
            this.btnPay.Location = new System.Drawing.Point(704, 187);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(118, 43);
            this.btnPay.TabIndex = 81;
            this.btnPay.Text = "PAY";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Enabled = false;
            this.txtTotalPrice.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtTotalPrice.Location = new System.Drawing.Point(435, 196);
            this.txtTotalPrice.Multiline = true;
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(197, 30);
            this.txtTotalPrice.TabIndex = 87;
            this.txtTotalPrice.Text = "0";
            this.txtTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTotalPrice.TextChanged += new System.EventHandler(this.txtTotalPrice_TextChanged);
            // 
            // ID
            // 
            this.ID.HeaderText = "Column1";
            this.ID.Name = "ID";
            // 
            // txtIDSell
            // 
            this.txtIDSell.Enabled = false;
            this.txtIDSell.Font = new System.Drawing.Font("Book Antiqua", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txtIDSell.Location = new System.Drawing.Point(60, 195);
            this.txtIDSell.Multiline = true;
            this.txtIDSell.Name = "txtIDSell";
            this.txtIDSell.Size = new System.Drawing.Size(160, 30);
            this.txtIDSell.TabIndex = 89;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(21, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 21);
            this.label6.TabIndex = 88;
            this.label6.Text = "ID:";
            // 
            // btnTotalPrice
            // 
            this.btnTotalPrice.BackColor = System.Drawing.Color.Teal;
            this.btnTotalPrice.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTotalPrice.ForeColor = System.Drawing.Color.Transparent;
            this.btnTotalPrice.Location = new System.Drawing.Point(264, 195);
            this.btnTotalPrice.Name = "btnTotalPrice";
            this.btnTotalPrice.Size = new System.Drawing.Size(165, 31);
            this.btnTotalPrice.TabIndex = 90;
            this.btnTotalPrice.Text = "TOTAL PRICE";
            this.btnTotalPrice.UseVisualStyleBackColor = false;
            this.btnTotalPrice.Click += new System.EventHandler(this.btnTotalPrice_Click);
            // 
            // frmSell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyTruyenTranh.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(964, 512);
            this.Controls.Add(this.btnTotalPrice);
            this.Controls.Add(this.txtIDSell);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEditSell);
            this.Controls.Add(this.btnAddSell);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvSell);
            this.Name = "frmSell";
            this.Text = "frmSell";
            this.Load += new System.EventHandler(this.frmSell_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSell)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mnQuantitySell)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSell;
        private System.Windows.Forms.TextBox txtMangaName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDCustomer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbxMembers;
        private System.Windows.Forms.Button btnSearchCustomer;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSearchIDManga;
        private System.Windows.Forms.TextBox txtNameCustomer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddSell;
        private System.Windows.Forms.Button btnEditSell;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtIDManga;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.NumericUpDown mnQuantitySell;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtIDSell;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPhoneSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnTotalPrice;
    }
}