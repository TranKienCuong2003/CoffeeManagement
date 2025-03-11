namespace CoffeeManagement.management
{
    partial class ChooseBank
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblUsername = new System.Windows.Forms.Label();
            this.cboBank = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtAccountNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAccountName = new Guna.UI2.WinForms.Guna2TextBox();
            this.pBBank = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBankName = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnPayment = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.txtTotalPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.txtDiscount = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFinalPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBBank)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.pnlTitle.Controls.Add(this.lblExit);
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(702, 58);
            this.pnlTitle.TabIndex = 0;
            // 
            // lblExit
            // 
            this.lblExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblExit.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.ForeColor = System.Drawing.Color.White;
            this.lblExit.Location = new System.Drawing.Point(644, 0);
            this.lblExit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(58, 58);
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
            this.lblTitle.Location = new System.Drawing.Point(231, 18);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(249, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Chọn tài khoản thanh toán";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(12, 88);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(76, 17);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Ngân hàng:";
            // 
            // cboBank
            // 
            this.cboBank.BackColor = System.Drawing.Color.Transparent;
            this.cboBank.BorderRadius = 3;
            this.cboBank.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBank.FocusedColor = System.Drawing.Color.Empty;
            this.cboBank.FocusedState.Parent = this.cboBank;
            this.cboBank.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboBank.ForeColor = System.Drawing.Color.Black;
            this.cboBank.FormattingEnabled = true;
            this.cboBank.HoverState.Parent = this.cboBank;
            this.cboBank.ItemHeight = 19;
            this.cboBank.ItemsAppearance.Parent = this.cboBank;
            this.cboBank.Location = new System.Drawing.Point(122, 88);
            this.cboBank.Name = "cboBank";
            this.cboBank.ShadowDecoration.Parent = this.cboBank;
            this.cboBank.Size = new System.Drawing.Size(151, 25);
            this.cboBank.TabIndex = 3;
            this.cboBank.SelectedIndexChanged += new System.EventHandler(this.cboDrink_SelectedIndexChanged);
            // 
            // txtAccountNo
            // 
            this.txtAccountNo.BorderRadius = 3;
            this.txtAccountNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAccountNo.DefaultText = "";
            this.txtAccountNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAccountNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAccountNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAccountNo.DisabledState.Parent = this.txtAccountNo;
            this.txtAccountNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAccountNo.Enabled = false;
            this.txtAccountNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAccountNo.FocusedState.Parent = this.txtAccountNo;
            this.txtAccountNo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountNo.ForeColor = System.Drawing.Color.Black;
            this.txtAccountNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAccountNo.HoverState.Parent = this.txtAccountNo;
            this.txtAccountNo.Location = new System.Drawing.Point(530, 77);
            this.txtAccountNo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAccountNo.Name = "txtAccountNo";
            this.txtAccountNo.PasswordChar = '\0';
            this.txtAccountNo.PlaceholderText = "";
            this.txtAccountNo.ReadOnly = true;
            this.txtAccountNo.SelectedText = "";
            this.txtAccountNo.ShadowDecoration.Parent = this.txtAccountNo;
            this.txtAccountNo.Size = new System.Drawing.Size(135, 36);
            this.txtAccountNo.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(456, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Số thẻ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(425, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên Chủ thẻ";
            // 
            // txtAccountName
            // 
            this.txtAccountName.BorderRadius = 3;
            this.txtAccountName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAccountName.DefaultText = "";
            this.txtAccountName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAccountName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAccountName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAccountName.DisabledState.Parent = this.txtAccountName;
            this.txtAccountName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAccountName.Enabled = false;
            this.txtAccountName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAccountName.FocusedState.Parent = this.txtAccountName;
            this.txtAccountName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountName.ForeColor = System.Drawing.Color.Black;
            this.txtAccountName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAccountName.HoverState.Parent = this.txtAccountName;
            this.txtAccountName.Location = new System.Drawing.Point(530, 152);
            this.txtAccountName.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.PasswordChar = '\0';
            this.txtAccountName.PlaceholderText = "";
            this.txtAccountName.ReadOnly = true;
            this.txtAccountName.SelectedText = "";
            this.txtAccountName.ShadowDecoration.Parent = this.txtAccountName;
            this.txtAccountName.Size = new System.Drawing.Size(135, 35);
            this.txtAccountName.TabIndex = 7;
            this.txtAccountName.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // pBBank
            // 
            this.pBBank.Location = new System.Drawing.Point(18, 210);
            this.pBBank.Name = "pBBank";
            this.pBBank.Size = new System.Drawing.Size(400, 150);
            this.pBBank.TabIndex = 8;
            this.pBBank.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tên ngân hàng";
            // 
            // txtBankName
            // 
            this.txtBankName.BorderRadius = 3;
            this.txtBankName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBankName.DefaultText = "";
            this.txtBankName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBankName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBankName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBankName.DisabledState.Parent = this.txtBankName;
            this.txtBankName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBankName.Enabled = false;
            this.txtBankName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBankName.FocusedState.Parent = this.txtBankName;
            this.txtBankName.ForeColor = System.Drawing.Color.Black;
            this.txtBankName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBankName.HoverState.Parent = this.txtBankName;
            this.txtBankName.Location = new System.Drawing.Point(122, 152);
            this.txtBankName.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.txtBankName.Name = "txtBankName";
            this.txtBankName.PasswordChar = '\0';
            this.txtBankName.PlaceholderText = "";
            this.txtBankName.ReadOnly = true;
            this.txtBankName.SelectedText = "";
            this.txtBankName.ShadowDecoration.Parent = this.txtBankName;
            this.txtBankName.Size = new System.Drawing.Size(281, 35);
            this.txtBankName.TabIndex = 10;
            // 
            // btnPayment
            // 
            this.btnPayment.BorderRadius = 5;
            this.btnPayment.CheckedState.Parent = this.btnPayment;
            this.btnPayment.CustomImages.Parent = this.btnPayment;
            this.btnPayment.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnPayment.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.btnPayment.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.ForeColor = System.Drawing.Color.White;
            this.btnPayment.HoverState.Parent = this.btnPayment;
            this.btnPayment.Location = new System.Drawing.Point(570, 342);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.PressedColor = System.Drawing.Color.BlanchedAlmond;
            this.btnPayment.ShadowDecoration.Parent = this.btnPayment;
            this.btnPayment.Size = new System.Drawing.Size(95, 55);
            this.btnPayment.TabIndex = 11;
            this.btnPayment.Text = "In hoá đơn";
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(435, 230);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(57, 15);
            this.lblTotalPrice.TabIndex = 12;
            this.lblTotalPrice.Text = "Tổng tiền";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalPrice.DefaultText = "";
            this.txtTotalPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotalPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotalPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalPrice.DisabledState.Parent = this.txtTotalPrice;
            this.txtTotalPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalPrice.FocusedState.Parent = this.txtTotalPrice;
            this.txtTotalPrice.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPrice.ForeColor = System.Drawing.Color.Black;
            this.txtTotalPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalPrice.HoverState.Parent = this.txtTotalPrice;
            this.txtTotalPrice.Location = new System.Drawing.Point(535, 230);
            this.txtTotalPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.PasswordChar = '\0';
            this.txtTotalPrice.PlaceholderText = "";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.SelectedText = "";
            this.txtTotalPrice.ShadowDecoration.Parent = this.txtTotalPrice;
            this.txtTotalPrice.Size = new System.Drawing.Size(130, 25);
            this.txtTotalPrice.TabIndex = 13;
            this.txtTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(438, 263);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(54, 15);
            this.lblDiscount.TabIndex = 14;
            this.lblDiscount.Text = "Giảm giá";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiscount.DefaultText = "";
            this.txtDiscount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDiscount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDiscount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiscount.DisabledState.Parent = this.txtDiscount;
            this.txtDiscount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiscount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiscount.FocusedState.Parent = this.txtDiscount;
            this.txtDiscount.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.ForeColor = System.Drawing.Color.Black;
            this.txtDiscount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiscount.HoverState.Parent = this.txtDiscount;
            this.txtDiscount.Location = new System.Drawing.Point(535, 263);
            this.txtDiscount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.PasswordChar = '\0';
            this.txtDiscount.PlaceholderText = "";
            this.txtDiscount.ReadOnly = true;
            this.txtDiscount.SelectedText = "";
            this.txtDiscount.ShadowDecoration.Parent = this.txtDiscount;
            this.txtDiscount.Size = new System.Drawing.Size(130, 25);
            this.txtDiscount.TabIndex = 15;
            this.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(438, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Thành tiền";
            // 
            // txtFinalPrice
            // 
            this.txtFinalPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFinalPrice.DefaultText = "";
            this.txtFinalPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFinalPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFinalPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFinalPrice.DisabledState.Parent = this.txtFinalPrice;
            this.txtFinalPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFinalPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFinalPrice.FocusedState.Parent = this.txtFinalPrice;
            this.txtFinalPrice.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFinalPrice.ForeColor = System.Drawing.Color.Black;
            this.txtFinalPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFinalPrice.HoverState.Parent = this.txtFinalPrice;
            this.txtFinalPrice.Location = new System.Drawing.Point(535, 298);
            this.txtFinalPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFinalPrice.Name = "txtFinalPrice";
            this.txtFinalPrice.PasswordChar = '\0';
            this.txtFinalPrice.PlaceholderText = "";
            this.txtFinalPrice.ReadOnly = true;
            this.txtFinalPrice.SelectedText = "";
            this.txtFinalPrice.ShadowDecoration.Parent = this.txtFinalPrice;
            this.txtFinalPrice.Size = new System.Drawing.Size(130, 25);
            this.txtFinalPrice.TabIndex = 17;
            this.txtFinalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ChooseBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(702, 409);
            this.Controls.Add(this.txtFinalPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.txtBankName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pBBank);
            this.Controls.Add(this.txtAccountName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAccountNo);
            this.Controls.Add(this.cboBank);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.pnlTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ChooseBank";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn tài khoản";
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBBank)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Label lblTitle;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblUsername;
        private Guna.UI2.WinForms.Guna2ComboBox cboBank;
        private Guna.UI2.WinForms.Guna2TextBox txtAccountNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtAccountName;
        private System.Windows.Forms.PictureBox pBBank;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtBankName;
        private Guna.UI2.WinForms.Guna2GradientButton btnPayment;
        private System.Windows.Forms.Label lblTotalPrice;
        private Guna.UI2.WinForms.Guna2TextBox txtTotalPrice;
        private System.Windows.Forms.Label lblDiscount;
        private Guna.UI2.WinForms.Guna2TextBox txtDiscount;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtFinalPrice;
    }
}