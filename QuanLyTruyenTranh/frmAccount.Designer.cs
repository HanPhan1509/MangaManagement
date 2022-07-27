
namespace QuanLyTruyenTranh
{
    partial class frmAccount
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
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            this.txtUsernameAcc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPasswordAcc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtUsernameSearch = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUsernameSearch = new System.Windows.Forms.Button();
            this.txtIDAcc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAccount
            // 
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccount.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvAccount.Location = new System.Drawing.Point(0, 0);
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.RowTemplate.Height = 25;
            this.dgvAccount.Size = new System.Drawing.Size(320, 341);
            this.dgvAccount.TabIndex = 0;
            this.dgvAccount.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccount_CellContentClick);
            // 
            // txtUsernameAcc
            // 
            this.txtUsernameAcc.Enabled = false;
            this.txtUsernameAcc.Font = new System.Drawing.Font("Book Antiqua", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txtUsernameAcc.Location = new System.Drawing.Point(349, 174);
            this.txtUsernameAcc.Multiline = true;
            this.txtUsernameAcc.Name = "txtUsernameAcc";
            this.txtUsernameAcc.Size = new System.Drawing.Size(320, 30);
            this.txtUsernameAcc.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(349, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 21);
            this.label1.TabIndex = 33;
            this.label1.Text = "Username:";
            // 
            // txtPasswordAcc
            // 
            this.txtPasswordAcc.Font = new System.Drawing.Font("Book Antiqua", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txtPasswordAcc.Location = new System.Drawing.Point(349, 238);
            this.txtPasswordAcc.Multiline = true;
            this.txtPasswordAcc.Name = "txtPasswordAcc";
            this.txtPasswordAcc.Size = new System.Drawing.Size(320, 30);
            this.txtPasswordAcc.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(349, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 21);
            this.label2.TabIndex = 35;
            this.label2.Text = "Password:";
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.Teal;
            this.btnChangePassword.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnChangePassword.ForeColor = System.Drawing.Color.Transparent;
            this.btnChangePassword.Location = new System.Drawing.Point(349, 274);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(197, 39);
            this.btnChangePassword.TabIndex = 38;
            this.btnChangePassword.Text = "CHANGE PASSWORD";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Teal;
            this.btnDelete.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.Color.Transparent;
            this.btnDelete.Location = new System.Drawing.Point(552, 274);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(118, 39);
            this.btnDelete.TabIndex = 39;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtUsernameSearch
            // 
            this.txtUsernameSearch.Font = new System.Drawing.Font("Book Antiqua", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txtUsernameSearch.Location = new System.Drawing.Point(10, 16);
            this.txtUsernameSearch.Multiline = true;
            this.txtUsernameSearch.Name = "txtUsernameSearch";
            this.txtUsernameSearch.PlaceholderText = "Enter username...";
            this.txtUsernameSearch.Size = new System.Drawing.Size(320, 30);
            this.txtUsernameSearch.TabIndex = 42;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::QuanLyTruyenTranh.Properties.Resources.background;
            this.panel1.Controls.Add(this.btnUsernameSearch);
            this.panel1.Controls.Add(this.txtUsernameSearch);
            this.panel1.Location = new System.Drawing.Point(339, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(477, 61);
            this.panel1.TabIndex = 43;
            // 
            // btnUsernameSearch
            // 
            this.btnUsernameSearch.BackColor = System.Drawing.Color.Teal;
            this.btnUsernameSearch.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUsernameSearch.ForeColor = System.Drawing.Color.Transparent;
            this.btnUsernameSearch.Location = new System.Drawing.Point(345, 10);
            this.btnUsernameSearch.Name = "btnUsernameSearch";
            this.btnUsernameSearch.Size = new System.Drawing.Size(118, 39);
            this.btnUsernameSearch.TabIndex = 44;
            this.btnUsernameSearch.Text = "SEARCH";
            this.btnUsernameSearch.UseVisualStyleBackColor = false;
            this.btnUsernameSearch.Click += new System.EventHandler(this.btnUsernameSearch_Click);
            // 
            // txtIDAcc
            // 
            this.txtIDAcc.Enabled = false;
            this.txtIDAcc.Font = new System.Drawing.Font("Book Antiqua", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txtIDAcc.Location = new System.Drawing.Point(349, 108);
            this.txtIDAcc.Multiline = true;
            this.txtIDAcc.Name = "txtIDAcc";
            this.txtIDAcc.Size = new System.Drawing.Size(164, 30);
            this.txtIDAcc.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(349, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 21);
            this.label3.TabIndex = 45;
            this.label3.Text = "ID:";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnExit.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExit.ForeColor = System.Drawing.Color.Transparent;
            this.btnExit.Location = new System.Drawing.Point(676, 274);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(118, 39);
            this.btnExit.TabIndex = 47;
            this.btnExit.Text = "&EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyTruyenTranh.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(825, 341);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtIDAcc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.txtPasswordAcc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUsernameAcc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvAccount);
            this.Controls.Add(this.panel1);
            this.Name = "frmAccount";
            this.Text = "Account Management";
            this.Load += new System.EventHandler(this.frmAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAccount;
        private System.Windows.Forms.TextBox txtUsernameAcc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPasswordAcc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtUsernameSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUsernameSearch;
        private System.Windows.Forms.TextBox txtIDAcc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExit;
    }
}