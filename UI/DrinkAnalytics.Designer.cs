
namespace CoffeeManagement
{
    partial class DrinkAnalytics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrinkAnalytics));
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblExit = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.drinkChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dtpFromDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpToDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cbTop = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pnFooter = new System.Windows.Forms.Panel();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drinkChart)).BeginInit();
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
            this.pnlTitle.Size = new System.Drawing.Size(788, 50);
            this.pnlTitle.TabIndex = 0;
            // 
            // lblExit
            // 
            this.lblExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblExit.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.ForeColor = System.Drawing.Color.White;
            this.lblExit.Location = new System.Drawing.Point(738, 0);
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
            this.lblTitle.Location = new System.Drawing.Point(297, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(194, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Thống kê thức uống";
            // 
            // dragControl
            // 
            this.dragControl.TargetControl = this.pnlTitle;
            // 
            // drinkChart
            // 
            chartArea1.Name = "ChartArea1";
            this.drinkChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.drinkChart.Legends.Add(legend1);
            this.drinkChart.Location = new System.Drawing.Point(0, 109);
            this.drinkChart.Name = "drinkChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.drinkChart.Series.Add(series1);
            this.drinkChart.Size = new System.Drawing.Size(788, 398);
            this.drinkChart.TabIndex = 1;
            this.drinkChart.Text = "drinkChart";
            this.drinkChart.Click += new System.EventHandler(this.drinkChart_Click);
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CheckedState.Parent = this.dtpFromDate;
            this.dtpFromDate.CustomFormat = "dddd, dd/MM/yyyy";
            this.dtpFromDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(203)))), ((int)(((byte)(110)))));
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.HoverState.Parent = this.dtpFromDate;
            this.dtpFromDate.Location = new System.Drawing.Point(12, 66);
            this.dtpFromDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFromDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.ShadowDecoration.Parent = this.dtpFromDate;
            this.dtpFromDate.Size = new System.Drawing.Size(200, 25);
            this.dtpFromDate.TabIndex = 2;
            this.dtpFromDate.Value = new System.DateTime(2021, 7, 30, 0, 0, 0, 0);
            // 
            // dtpToDate
            // 
            this.dtpToDate.CheckedState.Parent = this.dtpToDate;
            this.dtpToDate.CustomFormat = "dddd, dd/MM/yyyy";
            this.dtpToDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(203)))), ((int)(((byte)(110)))));
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate.HoverState.Parent = this.dtpToDate;
            this.dtpToDate.Location = new System.Drawing.Point(218, 66);
            this.dtpToDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpToDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.ShadowDecoration.Parent = this.dtpToDate;
            this.dtpToDate.Size = new System.Drawing.Size(200, 25);
            this.dtpToDate.TabIndex = 3;
            this.dtpToDate.Value = new System.DateTime(2021, 7, 30, 0, 0, 0, 0);
            // 
            // cbTop
            // 
            this.cbTop.FormattingEnabled = true;
            this.cbTop.Location = new System.Drawing.Point(424, 66);
            this.cbTop.Name = "cbTop";
            this.cbTop.Size = new System.Drawing.Size(95, 25);
            this.cbTop.TabIndex = 4;
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
            this.btnSubmit.Location = new System.Drawing.Point(525, 66);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.ShadowDecoration.Parent = this.btnSubmit;
            this.btnSubmit.Size = new System.Drawing.Size(100, 25);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Thống kê";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // pnFooter
            // 
            this.pnFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.pnFooter.Location = new System.Drawing.Point(0, 504);
            this.pnFooter.Name = "pnFooter";
            this.pnFooter.Size = new System.Drawing.Size(788, 25);
            this.pnFooter.TabIndex = 6;
            // 
            // DrinkAnalytics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(788, 529);
            this.Controls.Add(this.pnFooter);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cbTop);
            this.Controls.Add(this.dtpToDate);
            this.Controls.Add(this.dtpFromDate);
            this.Controls.Add(this.drinkChart);
            this.Controls.Add(this.pnlTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DrinkAnalytics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account";
            this.Load += new System.EventHandler(this.SalesStatistical);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drinkChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2DragControl dragControl;
        private System.Windows.Forms.DataVisualization.Charting.Chart drinkChart;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpFromDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpToDate;
        private System.Windows.Forms.ComboBox cbTop;
        private Guna.UI2.WinForms.Guna2GradientButton btnSubmit;
        private System.Windows.Forms.Panel pnFooter;
    }
}