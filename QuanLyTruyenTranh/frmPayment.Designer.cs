
namespace QuanLyTruyenTranh
{
    partial class frmPayment
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
            this.txtExcess = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtReceive = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotalPricePay = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnInvoice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtExcess
            // 
            this.txtExcess.Enabled = false;
            this.txtExcess.Font = new System.Drawing.Font("Book Antiqua", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txtExcess.Location = new System.Drawing.Point(162, 138);
            this.txtExcess.Multiline = true;
            this.txtExcess.Name = "txtExcess";
            this.txtExcess.Size = new System.Drawing.Size(320, 30);
            this.txtExcess.TabIndex = 77;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Teal;
            this.label7.Location = new System.Drawing.Point(10, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 21);
            this.label7.TabIndex = 76;
            this.label7.Text = "Excess cash:";
            // 
            // txtReceive
            // 
            this.txtReceive.Font = new System.Drawing.Font("Book Antiqua", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txtReceive.Location = new System.Drawing.Point(162, 102);
            this.txtReceive.Multiline = true;
            this.txtReceive.Name = "txtReceive";
            this.txtReceive.Size = new System.Drawing.Size(320, 30);
            this.txtReceive.TabIndex = 75;
            this.txtReceive.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtReceive_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(10, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 21);
            this.label4.TabIndex = 74;
            this.label4.Text = "Money received:";
            // 
            // txtTotalPricePay
            // 
            this.txtTotalPricePay.Enabled = false;
            this.txtTotalPricePay.Font = new System.Drawing.Font("Book Antiqua", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txtTotalPricePay.Location = new System.Drawing.Point(162, 66);
            this.txtTotalPricePay.Multiline = true;
            this.txtTotalPricePay.Name = "txtTotalPricePay";
            this.txtTotalPricePay.Size = new System.Drawing.Size(320, 30);
            this.txtTotalPricePay.TabIndex = 71;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(10, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 21);
            this.label6.TabIndex = 70;
            this.label6.Text = "Total price:";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Teal;
            this.btnClear.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClear.ForeColor = System.Drawing.Color.Transparent;
            this.btnClear.Location = new System.Drawing.Point(488, 42);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(118, 54);
            this.btnClear.TabIndex = 81;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Teal;
            this.btnClose.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.Color.Transparent;
            this.btnClose.Location = new System.Drawing.Point(488, 157);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(118, 55);
            this.btnClose.TabIndex = 82;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnInvoice
            // 
            this.btnInvoice.BackColor = System.Drawing.Color.Teal;
            this.btnInvoice.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInvoice.ForeColor = System.Drawing.Color.Transparent;
            this.btnInvoice.Location = new System.Drawing.Point(488, 99);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.Size = new System.Drawing.Size(118, 54);
            this.btnInvoice.TabIndex = 84;
            this.btnInvoice.Text = "INVOICE";
            this.btnInvoice.UseVisualStyleBackColor = false;
            this.btnInvoice.Click += new System.EventHandler(this.btnInvoice_Click);
            // 
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyTruyenTranh.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(607, 267);
            this.Controls.Add(this.btnInvoice);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtExcess);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtReceive);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTotalPricePay);
            this.Controls.Add(this.label6);
            this.Name = "frmPayment";
            this.Text = "frmPayment";
            this.Load += new System.EventHandler(this.frmPayment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtExcess;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtReceive;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotalPricePay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnInvoice;
    }
}