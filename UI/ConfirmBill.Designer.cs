namespace CoffeeManagement.UI
{
    partial class ConfirmBill
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
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblExit = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtBillNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFinalPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboPaymentOption = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGivenPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtChangePrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnConfirm = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pnlTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.pnlTitle.Controls.Add(this.lblExit);
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(396, 50);
            this.pnlTitle.TabIndex = 1;
            // 
            // lblExit
            // 
            this.lblExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblExit.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.ForeColor = System.Drawing.Color.White;
            this.lblExit.Location = new System.Drawing.Point(346, 0);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(50, 50);
            this.lblExit.TabIndex = 0;
            this.lblExit.Text = "X";
            this.lblExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(122, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(172, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Xác nhận hoá đơn";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(21, 76);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(65, 13);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Mã hoá đơn";
            // 
            // txtBillNo
            // 
            this.txtBillNo.BorderRadius = 3;
            this.txtBillNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBillNo.DefaultText = "";
            this.txtBillNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBillNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBillNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBillNo.DisabledState.Parent = this.txtBillNo;
            this.txtBillNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBillNo.Enabled = false;
            this.txtBillNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBillNo.FocusedState.Parent = this.txtBillNo;
            this.txtBillNo.ForeColor = System.Drawing.Color.Black;
            this.txtBillNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBillNo.HoverState.Parent = this.txtBillNo;
            this.txtBillNo.Location = new System.Drawing.Point(154, 67);
            this.txtBillNo.Name = "txtBillNo";
            this.txtBillNo.PasswordChar = '\0';
            this.txtBillNo.PlaceholderText = "";
            this.txtBillNo.ReadOnly = true;
            this.txtBillNo.SelectedText = "";
            this.txtBillNo.ShadowDecoration.Parent = this.txtBillNo;
            this.txtBillNo.Size = new System.Drawing.Size(204, 32);
            this.txtBillNo.TabIndex = 3;
            this.txtBillNo.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Thành tiền";
            // 
            // txtFinalPrice
            // 
            this.txtFinalPrice.BorderRadius = 3;
            this.txtFinalPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFinalPrice.DefaultText = "";
            this.txtFinalPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFinalPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFinalPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFinalPrice.DisabledState.Parent = this.txtFinalPrice;
            this.txtFinalPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFinalPrice.Enabled = false;
            this.txtFinalPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFinalPrice.FocusedState.Parent = this.txtFinalPrice;
            this.txtFinalPrice.ForeColor = System.Drawing.Color.Black;
            this.txtFinalPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFinalPrice.HoverState.Parent = this.txtFinalPrice;
            this.txtFinalPrice.Location = new System.Drawing.Point(154, 128);
            this.txtFinalPrice.Name = "txtFinalPrice";
            this.txtFinalPrice.PasswordChar = '\0';
            this.txtFinalPrice.PlaceholderText = "";
            this.txtFinalPrice.ReadOnly = true;
            this.txtFinalPrice.SelectedText = "";
            this.txtFinalPrice.ShadowDecoration.Parent = this.txtFinalPrice;
            this.txtFinalPrice.Size = new System.Drawing.Size(204, 32);
            this.txtFinalPrice.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hình thức thanh toán";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cboPaymentOption
            // 
            this.cboPaymentOption.BackColor = System.Drawing.Color.Transparent;
            this.cboPaymentOption.BorderRadius = 3;
            this.cboPaymentOption.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboPaymentOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPaymentOption.FocusedColor = System.Drawing.Color.Empty;
            this.cboPaymentOption.FocusedState.Parent = this.cboPaymentOption;
            this.cboPaymentOption.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboPaymentOption.ForeColor = System.Drawing.Color.Black;
            this.cboPaymentOption.FormattingEnabled = true;
            this.cboPaymentOption.HoverState.Parent = this.cboPaymentOption;
            this.cboPaymentOption.ItemHeight = 19;
            this.cboPaymentOption.ItemsAppearance.Parent = this.cboPaymentOption;
            this.cboPaymentOption.Location = new System.Drawing.Point(154, 187);
            this.cboPaymentOption.Name = "cboPaymentOption";
            this.cboPaymentOption.ShadowDecoration.Parent = this.cboPaymentOption;
            this.cboPaymentOption.Size = new System.Drawing.Size(204, 25);
            this.cboPaymentOption.TabIndex = 7;
            this.cboPaymentOption.SelectedIndexChanged += new System.EventHandler(this.cboDrink_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tiền khách đưa";
            // 
            // txtGivenPrice
            // 
            this.txtGivenPrice.BorderRadius = 3;
            this.txtGivenPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGivenPrice.DefaultText = "";
            this.txtGivenPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGivenPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGivenPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGivenPrice.DisabledState.Parent = this.txtGivenPrice;
            this.txtGivenPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGivenPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGivenPrice.FocusedState.Parent = this.txtGivenPrice;
            this.txtGivenPrice.ForeColor = System.Drawing.Color.Black;
            this.txtGivenPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGivenPrice.HoverState.Parent = this.txtGivenPrice;
            this.txtGivenPrice.Location = new System.Drawing.Point(154, 234);
            this.txtGivenPrice.Name = "txtGivenPrice";
            this.txtGivenPrice.PasswordChar = '\0';
            this.txtGivenPrice.PlaceholderText = "";
            this.txtGivenPrice.SelectedText = "";
            this.txtGivenPrice.ShadowDecoration.Parent = this.txtGivenPrice;
            this.txtGivenPrice.Size = new System.Drawing.Size(204, 32);
            this.txtGivenPrice.TabIndex = 9;
            this.txtGivenPrice.TextChanged += new System.EventHandler(this.txtGivenPrice_TextChanged);
            this.txtGivenPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGivenPrice_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tiền thừa";
            // 
            // txtChangePrice
            // 
            this.txtChangePrice.BorderRadius = 3;
            this.txtChangePrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtChangePrice.DefaultText = "";
            this.txtChangePrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtChangePrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtChangePrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtChangePrice.DisabledState.Parent = this.txtChangePrice;
            this.txtChangePrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtChangePrice.Enabled = false;
            this.txtChangePrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtChangePrice.FocusedState.Parent = this.txtChangePrice;
            this.txtChangePrice.ForeColor = System.Drawing.Color.Black;
            this.txtChangePrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtChangePrice.HoverState.Parent = this.txtChangePrice;
            this.txtChangePrice.Location = new System.Drawing.Point(154, 287);
            this.txtChangePrice.Name = "txtChangePrice";
            this.txtChangePrice.PasswordChar = '\0';
            this.txtChangePrice.PlaceholderText = "";
            this.txtChangePrice.ReadOnly = true;
            this.txtChangePrice.SelectedText = "";
            this.txtChangePrice.ShadowDecoration.Parent = this.txtChangePrice;
            this.txtChangePrice.Size = new System.Drawing.Size(204, 32);
            this.txtChangePrice.TabIndex = 11;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BorderRadius = 3;
            this.btnConfirm.CheckedState.Parent = this.btnConfirm;
            this.btnConfirm.CustomImages.Parent = this.btnConfirm;
            this.btnConfirm.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnConfirm.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.HoverState.Parent = this.btnConfirm;
            this.btnConfirm.Location = new System.Drawing.Point(258, 336);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.ShadowDecoration.Parent = this.btnConfirm;
            this.btnConfirm.Size = new System.Drawing.Size(100, 30);
            this.btnConfirm.TabIndex = 12;
            this.btnConfirm.Text = "Xác nhận";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // ConfirmBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(396, 384);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtChangePrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtGivenPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboPaymentOption);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFinalPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBillNo);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.pnlTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConfirmBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ConfirmBill";
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUsername;
        private Guna.UI2.WinForms.Guna2TextBox txtBillNo;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtFinalPrice;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox cboPaymentOption;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtGivenPrice;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtChangePrice;
        private Guna.UI2.WinForms.Guna2GradientButton btnConfirm;
    }
}