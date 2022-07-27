
namespace MangaManagementProject
{
    partial class frmCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomer));
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearchPhoneCustomer = new System.Windows.Forms.Button();
            this.txtPhoneSearchCustomer = new System.Windows.Forms.TextBox();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.btnEditCustomer = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.txtCustomerAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPhoneCustomer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpBirthCustomer = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxSexCustomer = new System.Windows.Forms.ComboBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvCustomer.Location = new System.Drawing.Point(0, 264);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.RowTemplate.Height = 25;
            this.dgvCustomer.Size = new System.Drawing.Size(836, 229);
            this.dgvCustomer.TabIndex = 1;
            this.dgvCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomer_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.btnSearchPhoneCustomer);
            this.panel1.Controls.Add(this.txtPhoneSearchCustomer);
            this.panel1.Location = new System.Drawing.Point(460, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 115);
            this.panel1.TabIndex = 2;
            // 
            // btnSearchPhoneCustomer
            // 
            this.btnSearchPhoneCustomer.BackColor = System.Drawing.Color.Teal;
            this.btnSearchPhoneCustomer.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearchPhoneCustomer.ForeColor = System.Drawing.Color.Transparent;
            this.btnSearchPhoneCustomer.Location = new System.Drawing.Point(246, 56);
            this.btnSearchPhoneCustomer.Name = "btnSearchPhoneCustomer";
            this.btnSearchPhoneCustomer.Size = new System.Drawing.Size(118, 39);
            this.btnSearchPhoneCustomer.TabIndex = 5;
            this.btnSearchPhoneCustomer.Text = "SEARCH";
            this.btnSearchPhoneCustomer.UseVisualStyleBackColor = false;
            this.btnSearchPhoneCustomer.Click += new System.EventHandler(this.btnSearchPhoneCustomer_Click);
            // 
            // txtPhoneSearchCustomer
            // 
            this.txtPhoneSearchCustomer.Font = new System.Drawing.Font("Book Antiqua", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txtPhoneSearchCustomer.Location = new System.Drawing.Point(49, 20);
            this.txtPhoneSearchCustomer.Multiline = true;
            this.txtPhoneSearchCustomer.Name = "txtPhoneSearchCustomer";
            this.txtPhoneSearchCustomer.PlaceholderText = "Enter customer phone...";
            this.txtPhoneSearchCustomer.Size = new System.Drawing.Size(274, 30);
            this.txtPhoneSearchCustomer.TabIndex = 0;
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.BackColor = System.Drawing.Color.Teal;
            this.btnDeleteCustomer.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteCustomer.ForeColor = System.Drawing.Color.Transparent;
            this.btnDeleteCustomer.Location = new System.Drawing.Point(706, 129);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(118, 39);
            this.btnDeleteCustomer.TabIndex = 50;
            this.btnDeleteCustomer.Text = "DELETE";
            this.btnDeleteCustomer.UseVisualStyleBackColor = false;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // btnEditCustomer
            // 
            this.btnEditCustomer.BackColor = System.Drawing.Color.Teal;
            this.btnEditCustomer.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditCustomer.ForeColor = System.Drawing.Color.Transparent;
            this.btnEditCustomer.Location = new System.Drawing.Point(582, 129);
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.Size = new System.Drawing.Size(118, 39);
            this.btnEditCustomer.TabIndex = 49;
            this.btnEditCustomer.Text = "EDIT";
            this.btnEditCustomer.UseVisualStyleBackColor = false;
            this.btnEditCustomer.Click += new System.EventHandler(this.btnEditCustomer_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.BackColor = System.Drawing.Color.Teal;
            this.btnAddCustomer.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddCustomer.ForeColor = System.Drawing.Color.Transparent;
            this.btnAddCustomer.Location = new System.Drawing.Point(458, 129);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(118, 39);
            this.btnAddCustomer.TabIndex = 31;
            this.btnAddCustomer.Text = "ADD";
            this.btnAddCustomer.UseVisualStyleBackColor = false;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // txtCustomerAddress
            // 
            this.txtCustomerAddress.Font = new System.Drawing.Font("Book Antiqua", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txtCustomerAddress.Location = new System.Drawing.Point(106, 174);
            this.txtCustomerAddress.Multiline = true;
            this.txtCustomerAddress.Name = "txtCustomerAddress";
            this.txtCustomerAddress.Size = new System.Drawing.Size(320, 30);
            this.txtCustomerAddress.TabIndex = 43;
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
            this.label6.TabIndex = 41;
            this.label6.Text = "Address:";
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
            this.label4.TabIndex = 37;
            this.label4.Text = "Date of birth:";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("Book Antiqua", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txtCustomerName.Location = new System.Drawing.Point(106, 48);
            this.txtCustomerName.Multiline = true;
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(320, 30);
            this.txtCustomerName.TabIndex = 35;
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
            this.label2.TabIndex = 33;
            this.label2.Text = "Name:";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Enabled = false;
            this.txtCustomerID.Font = new System.Drawing.Font("Book Antiqua", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txtCustomerID.Location = new System.Drawing.Point(106, 12);
            this.txtCustomerID.Multiline = true;
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(320, 30);
            this.txtCustomerID.TabIndex = 32;
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
            this.label1.TabIndex = 30;
            this.label1.Text = "ID:";
            // 
            // txtPhoneCustomer
            // 
            this.txtPhoneCustomer.Font = new System.Drawing.Font("Book Antiqua", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txtPhoneCustomer.Location = new System.Drawing.Point(106, 210);
            this.txtPhoneCustomer.Multiline = true;
            this.txtPhoneCustomer.Name = "txtPhoneCustomer";
            this.txtPhoneCustomer.Size = new System.Drawing.Size(320, 30);
            this.txtPhoneCustomer.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(9, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 21);
            this.label3.TabIndex = 53;
            this.label3.Text = "Phone:";
            // 
            // dtpBirthCustomer
            // 
            this.dtpBirthCustomer.Location = new System.Drawing.Point(126, 145);
            this.dtpBirthCustomer.Name = "dtpBirthCustomer";
            this.dtpBirthCustomer.Size = new System.Drawing.Size(200, 23);
            this.dtpBirthCustomer.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(13, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 21);
            this.label5.TabIndex = 56;
            this.label5.Text = "Sex:";
            // 
            // cbxSexCustomer
            // 
            this.cbxSexCustomer.FormattingEnabled = true;
            this.cbxSexCustomer.Items.AddRange(new object[] {
            "nam",
            "nu"});
            this.cbxSexCustomer.Location = new System.Drawing.Point(106, 95);
            this.cbxSexCustomer.Name = "cbxSexCustomer";
            this.cbxSexCustomer.Size = new System.Drawing.Size(220, 23);
            this.cbxSexCustomer.TabIndex = 57;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnExit.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExit.ForeColor = System.Drawing.Color.Transparent;
            this.btnExit.Location = new System.Drawing.Point(647, 182);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(118, 39);
            this.btnExit.TabIndex = 77;
            this.btnExit.Text = "&EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Teal;
            this.btnRefresh.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRefresh.ForeColor = System.Drawing.Color.Transparent;
            this.btnRefresh.Location = new System.Drawing.Point(523, 182);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(118, 39);
            this.btnRefresh.TabIndex = 76;
            this.btnRefresh.Text = "&REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyTruyenTranh.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(836, 493);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.cbxSexCustomer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpBirthCustomer);
            this.Controls.Add(this.txtPhoneCustomer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDeleteCustomer);
            this.Controls.Add(this.btnEditCustomer);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.txtCustomerAddress);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvCustomer);
            this.Name = "frmCustomer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.frmCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearchPhoneCustomer;
        private System.Windows.Forms.TextBox txtPhoneSearchCustomer;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.Button btnEditCustomer;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.TextBox txtCustomerAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPhoneCustomer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpBirthCustomer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxSexCustomer;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRefresh;
    }
}