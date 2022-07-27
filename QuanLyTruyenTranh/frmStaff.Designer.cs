
namespace MangaManagementProject
{
    partial class frmStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStaff));
            this.label3 = new System.Windows.Forms.Label();
            this.txtPhoneStaff = new System.Windows.Forms.TextBox();
            this.btnbtnDeleteStaff = new System.Windows.Forms.Button();
            this.btnEditStaff = new System.Windows.Forms.Button();
            this.btnAddStaff = new System.Windows.Forms.Button();
            this.txtAddressStaff = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDStaff = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSearchPhoneStaff = new System.Windows.Forms.TextBox();
            this.dgvStaff = new System.Windows.Forms.DataGridView();
            this.txtNameStaff = new System.Windows.Forms.TextBox();
            this.dtpBirthStaff = new System.Windows.Forms.DateTimePicker();
            this.cbxSexStaff = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(13, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 21);
            this.label3.TabIndex = 69;
            this.label3.Text = "Phone:";
            // 
            // txtPhoneStaff
            // 
            this.txtPhoneStaff.Font = new System.Drawing.Font("Book Antiqua", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txtPhoneStaff.Location = new System.Drawing.Point(106, 210);
            this.txtPhoneStaff.Multiline = true;
            this.txtPhoneStaff.Name = "txtPhoneStaff";
            this.txtPhoneStaff.Size = new System.Drawing.Size(320, 30);
            this.txtPhoneStaff.TabIndex = 70;
            // 
            // btnbtnDeleteStaff
            // 
            this.btnbtnDeleteStaff.BackColor = System.Drawing.Color.Teal;
            this.btnbtnDeleteStaff.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnbtnDeleteStaff.ForeColor = System.Drawing.Color.Transparent;
            this.btnbtnDeleteStaff.Location = new System.Drawing.Point(708, 138);
            this.btnbtnDeleteStaff.Name = "btnbtnDeleteStaff";
            this.btnbtnDeleteStaff.Size = new System.Drawing.Size(118, 39);
            this.btnbtnDeleteStaff.TabIndex = 67;
            this.btnbtnDeleteStaff.Text = "DELETE";
            this.btnbtnDeleteStaff.UseVisualStyleBackColor = false;
            this.btnbtnDeleteStaff.Click += new System.EventHandler(this.btnbtnDeleteStaff_Click);
            // 
            // btnEditStaff
            // 
            this.btnEditStaff.BackColor = System.Drawing.Color.Teal;
            this.btnEditStaff.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditStaff.ForeColor = System.Drawing.Color.Transparent;
            this.btnEditStaff.Location = new System.Drawing.Point(584, 138);
            this.btnEditStaff.Name = "btnEditStaff";
            this.btnEditStaff.Size = new System.Drawing.Size(118, 39);
            this.btnEditStaff.TabIndex = 66;
            this.btnEditStaff.Text = "EDIT";
            this.btnEditStaff.UseVisualStyleBackColor = false;
            this.btnEditStaff.Click += new System.EventHandler(this.btnEditStaff_Click);
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.BackColor = System.Drawing.Color.Teal;
            this.btnAddStaff.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddStaff.ForeColor = System.Drawing.Color.Transparent;
            this.btnAddStaff.Location = new System.Drawing.Point(460, 138);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(118, 39);
            this.btnAddStaff.TabIndex = 58;
            this.btnAddStaff.Text = "ADD";
            this.btnAddStaff.UseVisualStyleBackColor = false;
            this.btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);
            // 
            // txtAddressStaff
            // 
            this.txtAddressStaff.Font = new System.Drawing.Font("Book Antiqua", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txtAddressStaff.Location = new System.Drawing.Point(106, 174);
            this.txtAddressStaff.Multiline = true;
            this.txtAddressStaff.Name = "txtAddressStaff";
            this.txtAddressStaff.Size = new System.Drawing.Size(320, 30);
            this.txtAddressStaff.TabIndex = 65;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(13, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 21);
            this.label6.TabIndex = 64;
            this.label6.Text = "Address:";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Teal;
            this.btnSearch.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.ForeColor = System.Drawing.Color.Transparent;
            this.btnSearch.Location = new System.Drawing.Point(205, 56);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(118, 39);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "&SEARCH";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(13, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 21);
            this.label4.TabIndex = 62;
            this.label4.Text = "Date of birth:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(13, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 21);
            this.label2.TabIndex = 60;
            this.label2.Text = "Name:";
            // 
            // txtIDStaff
            // 
            this.txtIDStaff.Enabled = false;
            this.txtIDStaff.Font = new System.Drawing.Font("Book Antiqua", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txtIDStaff.Location = new System.Drawing.Point(106, 12);
            this.txtIDStaff.Multiline = true;
            this.txtIDStaff.Name = "txtIDStaff";
            this.txtIDStaff.Size = new System.Drawing.Size(320, 30);
            this.txtIDStaff.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 21);
            this.label1.TabIndex = 57;
            this.label1.Text = "ID:";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtSearchPhoneStaff);
            this.panel1.Location = new System.Drawing.Point(460, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 115);
            this.panel1.TabIndex = 56;
            // 
            // txtSearchPhoneStaff
            // 
            this.txtSearchPhoneStaff.Font = new System.Drawing.Font("Book Antiqua", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txtSearchPhoneStaff.Location = new System.Drawing.Point(49, 20);
            this.txtSearchPhoneStaff.Multiline = true;
            this.txtSearchPhoneStaff.Name = "txtSearchPhoneStaff";
            this.txtSearchPhoneStaff.PlaceholderText = "Enter staff phone...";
            this.txtSearchPhoneStaff.Size = new System.Drawing.Size(274, 30);
            this.txtSearchPhoneStaff.TabIndex = 0;
            // 
            // dgvStaff
            // 
            this.dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaff.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvStaff.Location = new System.Drawing.Point(0, 268);
            this.dgvStaff.Name = "dgvStaff";
            this.dgvStaff.RowTemplate.Height = 25;
            this.dgvStaff.Size = new System.Drawing.Size(836, 229);
            this.dgvStaff.TabIndex = 55;
            this.dgvStaff.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStaff_CellContentClick);
            // 
            // txtNameStaff
            // 
            this.txtNameStaff.Font = new System.Drawing.Font("Book Antiqua", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txtNameStaff.Location = new System.Drawing.Point(106, 48);
            this.txtNameStaff.Multiline = true;
            this.txtNameStaff.Name = "txtNameStaff";
            this.txtNameStaff.Size = new System.Drawing.Size(320, 30);
            this.txtNameStaff.TabIndex = 61;
            // 
            // dtpBirthStaff
            // 
            this.dtpBirthStaff.Location = new System.Drawing.Point(126, 145);
            this.dtpBirthStaff.Name = "dtpBirthStaff";
            this.dtpBirthStaff.Size = new System.Drawing.Size(200, 23);
            this.dtpBirthStaff.TabIndex = 71;
            // 
            // cbxSexStaff
            // 
            this.cbxSexStaff.FormattingEnabled = true;
            this.cbxSexStaff.Items.AddRange(new object[] {
            "nam",
            "nu"});
            this.cbxSexStaff.Location = new System.Drawing.Point(106, 101);
            this.cbxSexStaff.Name = "cbxSexStaff";
            this.cbxSexStaff.Size = new System.Drawing.Size(220, 23);
            this.cbxSexStaff.TabIndex = 73;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(13, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 21);
            this.label5.TabIndex = 72;
            this.label5.Text = "Sex:";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnExit.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExit.ForeColor = System.Drawing.Color.Transparent;
            this.btnExit.Location = new System.Drawing.Point(648, 204);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(118, 39);
            this.btnExit.TabIndex = 75;
            this.btnExit.Text = "&EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Teal;
            this.btnRefresh.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRefresh.ForeColor = System.Drawing.Color.Transparent;
            this.btnRefresh.Location = new System.Drawing.Point(524, 204);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(118, 39);
            this.btnRefresh.TabIndex = 74;
            this.btnRefresh.Text = "&REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyTruyenTranh.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(836, 497);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.cbxSexStaff);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpBirthStaff);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPhoneStaff);
            this.Controls.Add(this.btnbtnDeleteStaff);
            this.Controls.Add(this.btnEditStaff);
            this.Controls.Add(this.btnAddStaff);
            this.Controls.Add(this.txtAddressStaff);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIDStaff);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvStaff);
            this.Controls.Add(this.txtNameStaff);
            this.Name = "frmStaff";
            this.Text = "frmStaff";
            this.Load += new System.EventHandler(this.frmStaff_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPhoneStaff;
        private System.Windows.Forms.Button btnbtnDeleteStaff;
        private System.Windows.Forms.Button btnEditStaff;
        private System.Windows.Forms.Button btnAddStaff;
        private System.Windows.Forms.TextBox txtAddressStaff;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDStaff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSearchPhoneStaff;
        private System.Windows.Forms.DataGridView dgvStaff;
        private System.Windows.Forms.TextBox txtNameStaff;
        private System.Windows.Forms.DateTimePicker dtpBirthStaff;
        private System.Windows.Forms.ComboBox cbxSexStaff;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRefresh;
    }
}