namespace CoffeeManagement.UI
{
    partial class Spending
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Spending));
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblExit = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dtpFromDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnStatistical = new Guna.UI2.WinForms.Guna2GradientButton();
            this.dtpToDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dgvSpending = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotalSpeding = new System.Windows.Forms.TextBox();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpending)).BeginInit();
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
            this.pnlTitle.Size = new System.Drawing.Size(704, 50);
            this.pnlTitle.TabIndex = 1;
            // 
            // lblExit
            // 
            this.lblExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblExit.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.ForeColor = System.Drawing.Color.White;
            this.lblExit.Location = new System.Drawing.Point(654, 0);
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
            this.lblTitle.Location = new System.Drawing.Point(308, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(79, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Chi tiêu";
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CheckedState.Parent = this.dtpFromDate;
            this.dtpFromDate.CustomFormat = "dddd, dd/MM/yyyy";
            this.dtpFromDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(203)))), ((int)(((byte)(110)))));
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.HoverState.Parent = this.dtpFromDate;
            this.dtpFromDate.Location = new System.Drawing.Point(29, 56);
            this.dtpFromDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFromDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.ShadowDecoration.Parent = this.dtpFromDate;
            this.dtpFromDate.Size = new System.Drawing.Size(200, 25);
            this.dtpFromDate.TabIndex = 2;
            this.dtpFromDate.Value = new System.DateTime(2021, 7, 30, 0, 0, 0, 0);
            // 
            // btnStatistical
            // 
            this.btnStatistical.BorderRadius = 3;
            this.btnStatistical.CheckedState.Parent = this.btnStatistical;
            this.btnStatistical.CustomImages.Parent = this.btnStatistical;
            this.btnStatistical.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnStatistical.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.btnStatistical.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatistical.ForeColor = System.Drawing.Color.White;
            this.btnStatistical.HoverState.Parent = this.btnStatistical;
            this.btnStatistical.Location = new System.Drawing.Point(303, 56);
            this.btnStatistical.Name = "btnStatistical";
            this.btnStatistical.ShadowDecoration.Parent = this.btnStatistical;
            this.btnStatistical.Size = new System.Drawing.Size(100, 25);
            this.btnStatistical.TabIndex = 3;
            this.btnStatistical.Text = "Thống kê";
            this.btnStatistical.Click += new System.EventHandler(this.btnStatistical_Click);
            // 
            // dtpToDate
            // 
            this.dtpToDate.CheckedState.Parent = this.dtpToDate;
            this.dtpToDate.CustomFormat = "dddd, dd/MM/yyyy";
            this.dtpToDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(203)))), ((int)(((byte)(110)))));
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate.HoverState.Parent = this.dtpToDate;
            this.dtpToDate.Location = new System.Drawing.Point(452, 56);
            this.dtpToDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpToDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.ShadowDecoration.Parent = this.dtpToDate;
            this.dtpToDate.Size = new System.Drawing.Size(200, 25);
            this.dtpToDate.TabIndex = 4;
            this.dtpToDate.Value = new System.DateTime(2021, 7, 30, 0, 0, 0, 0);
            // 
            // dgvSpending
            // 
            this.dgvSpending.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(231)))), ((int)(((byte)(203)))));
            this.dgvSpending.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSpending.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSpending.BackgroundColor = System.Drawing.Color.White;
            this.dgvSpending.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvSpending.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSpending.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSpending.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSpending.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(239)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(201)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSpending.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSpending.EnableHeadersVisualStyles = false;
            this.dgvSpending.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(231)))), ((int)(((byte)(201)))));
            this.dgvSpending.Location = new System.Drawing.Point(12, 87);
            this.dgvSpending.Name = "dgvSpending";
            this.dgvSpending.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSpending.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSpending.RowHeadersVisible = false;
            this.dgvSpending.RowHeadersWidth = 51;
            this.dgvSpending.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSpending.Size = new System.Drawing.Size(676, 262);
            this.dgvSpending.TabIndex = 5;
            this.dgvSpending.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Green;
            this.dgvSpending.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(231)))), ((int)(((byte)(203)))));
            this.dgvSpending.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvSpending.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvSpending.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvSpending.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvSpending.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvSpending.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(231)))), ((int)(((byte)(201)))));
            this.dgvSpending.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.dgvSpending.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvSpending.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSpending.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvSpending.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvSpending.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvSpending.ThemeStyle.ReadOnly = true;
            this.dgvSpending.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(239)))), ((int)(((byte)(220)))));
            this.dgvSpending.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSpending.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSpending.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvSpending.ThemeStyle.RowsStyle.Height = 22;
            this.dgvSpending.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(201)))), ((int)(((byte)(138)))));
            this.dgvSpending.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label1.Location = new System.Drawing.Point(427, 365);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tổng chi tiêu";
            // 
            // txtTotalSpeding
            // 
            this.txtTotalSpeding.Location = new System.Drawing.Point(525, 362);
            this.txtTotalSpeding.Name = "txtTotalSpeding";
            this.txtTotalSpeding.ReadOnly = true;
            this.txtTotalSpeding.Size = new System.Drawing.Size(158, 20);
            this.txtTotalSpeding.TabIndex = 8;
            // 
            // Spending
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(704, 402);
            this.Controls.Add(this.txtTotalSpeding);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSpending);
            this.Controls.Add(this.dtpToDate);
            this.Controls.Add(this.btnStatistical);
            this.Controls.Add(this.dtpFromDate);
            this.Controls.Add(this.pnlTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Spending";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spending";
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpending)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpFromDate;
        private Guna.UI2.WinForms.Guna2GradientButton btnStatistical;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpToDate;
        private Guna.UI2.WinForms.Guna2DataGridView dgvSpending;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotalSpeding;
    }
}