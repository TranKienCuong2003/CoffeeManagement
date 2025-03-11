
namespace CoffeeManagement
{
    partial class MonthlyStatistical
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonthlyStatistical));
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblExit = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.chartRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new Guna.UI2.WinForms.Guna2GradientButton();
            this.cboToMonth = new System.Windows.Forms.ComboBox();
            this.cboFromMonth = new System.Windows.Forms.ComboBox();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.pnlTitle.Controls.Add(this.lblExit);
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(972, 50);
            this.pnlTitle.TabIndex = 0;
            this.pnlTitle.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTitle_Paint);
            // 
            // lblExit
            // 
            this.lblExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblExit.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.ForeColor = System.Drawing.Color.White;
            this.lblExit.Location = new System.Drawing.Point(922, 0);
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
            this.lblTitle.Location = new System.Drawing.Point(404, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(161, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Thống kê thu chi";
            // 
            // dragControl
            // 
            this.dragControl.TargetControl = this.pnlTitle;
            // 
            // chartRevenue
            // 
            chartArea1.Name = "ChartArea1";
            this.chartRevenue.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartRevenue.Legends.Add(legend1);
            this.chartRevenue.Location = new System.Drawing.Point(0, 90);
            this.chartRevenue.Name = "chartRevenue";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartRevenue.Series.Add(series1);
            this.chartRevenue.Size = new System.Drawing.Size(972, 436);
            this.chartRevenue.TabIndex = 1;
            this.chartRevenue.Text = "chart Revenue";
            this.chartRevenue.Click += new System.EventHandler(this.chartRevenue_Click);
            // 
            // cboYear
            // 
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Location = new System.Drawing.Point(708, 62);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(95, 25);
            this.cboYear.TabIndex = 2;
            this.cboYear.SelectedIndexChanged += new System.EventHandler(this.cboYear_SelectedIndexChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BorderRadius = 3;
            this.btnSubmit.CheckedState.Parent = this.btnSubmit;
            this.btnSubmit.CustomImages.Parent = this.btnSubmit;
            this.btnSubmit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnSubmit.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.HoverState.Parent = this.btnSubmit;
            this.btnSubmit.Location = new System.Drawing.Point(832, 62);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.ShadowDecoration.Parent = this.btnSubmit;
            this.btnSubmit.Size = new System.Drawing.Size(100, 25);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Thống kê";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // cboToMonth
            // 
            this.cboToMonth.FormattingEnabled = true;
            this.cboToMonth.Location = new System.Drawing.Point(601, 62);
            this.cboToMonth.Name = "cboToMonth";
            this.cboToMonth.Size = new System.Drawing.Size(88, 25);
            this.cboToMonth.TabIndex = 7;
            this.cboToMonth.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cboFromMonth
            // 
            this.cboFromMonth.FormattingEnabled = true;
            this.cboFromMonth.Location = new System.Drawing.Point(501, 62);
            this.cboFromMonth.Name = "cboFromMonth";
            this.cboFromMonth.Size = new System.Drawing.Size(94, 25);
            this.cboFromMonth.TabIndex = 8;
            // 
            // MonthlyStatistical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(972, 526);
            this.Controls.Add(this.cboFromMonth);
            this.Controls.Add(this.cboToMonth);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cboYear);
            this.Controls.Add(this.chartRevenue);
            this.Controls.Add(this.pnlTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MonthlyStatistical";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account";
            this.Load += new System.EventHandler(this.MonthlyStatistical_Load);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2DragControl dragControl;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRevenue;
        private System.Windows.Forms.ComboBox cboYear;
        private Guna.UI2.WinForms.Guna2GradientButton btnSubmit;
        private System.Windows.Forms.ComboBox cboToMonth;
        private System.Windows.Forms.ComboBox cboFromMonth;
    }
}