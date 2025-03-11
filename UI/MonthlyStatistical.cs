using CoffeeManagement.BLL;
using CoffeeManagement.DAL;
using CoffeeManagement.DTO;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CoffeeManagement
{
    public partial class MonthlyStatistical : Form
    {
        #region Properties
        private readonly Color REVENUE_CORLOR = Color.FromArgb(255, 214, 90);
        private readonly Color SPENDING_CORLOR = Color.FromArgb(246, 199, 148);
        #endregion
        #region System
        public MonthlyStatistical()
        {
            InitializeComponent();
        }

        private void MonthlyStatistical_Load(object sender, EventArgs e)
        {
            InitChart();
            InitComboBoxes();
            LoadDataSource();
        }
        #endregion
        #region Common function
        private void InitChart()
        {
            chartRevenue.ChartAreas[0].AxisX.Title = "Tháng";
            chartRevenue.ChartAreas[0].AxisY.Title = "Số tiền (VND)";
            chartRevenue.ChartAreas[0].AxisY.LabelStyle.Format = "N0";
            chartRevenue.Legends.Clear();

            chartRevenue.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chartRevenue.ChartAreas[0].AxisX.MinorGrid.Enabled = false;
            chartRevenue.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chartRevenue.ChartAreas[0].AxisY.MinorGrid.Enabled = false;

            chartRevenue.ChartAreas[0].AxisX.IsLabelAutoFit = true;
            chartRevenue.ChartAreas[0].AxisX.Interval = 1;
            chartRevenue.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
            chartRevenue.Legends.Clear();
            chartRevenue.Series.Clear();
        }

        private void LoadDataSource()
        {
            int year = Convert.ToInt32(cboYear.SelectedValue);
            int fromMonth = Convert.ToInt32(cboFromMonth.SelectedValue);
            int toMonth = Convert.ToInt32(cboToMonth.SelectedValue);

            chartRevenue.Legends.Add(new Legend());

            Series revenueSeries = new Series
            {
                ChartType = SeriesChartType.Column,
                XValueType = ChartValueType.DateTime,
                LegendText = "Thu",
                Color = REVENUE_CORLOR
            };

            Series spendingSeries = new Series
            {
                ChartType = SeriesChartType.Column,
                XValueType = ChartValueType.DateTime,
                LegendText = "Chi",
                Color = SPENDING_CORLOR
            };

            chartRevenue.Series.Add(revenueSeries);
            chartRevenue.Series.Add(spendingSeries);

            for (int month = fromMonth; month <= toMonth; month++)
            {
                DateTime startDate = new DateTime(year, month, 1);
                DateTime endDate = startDate.AddMonths(1).AddDays(-1);

                var revenueData = BillDAL.Instance.GetRevenueInRange(startDate, endDate);
                var monthRevenue = Convert.ToInt32(revenueData.Rows[0]["TotalRevenue"]);

                var spedingData = BillDAL.Instance.GetSpendingInRange(startDate, endDate);
                var monthSpeding = Convert.ToInt32(spedingData.Rows[0]["TotalSpending"]);

                var revenuePoint = new DataPoint();
                revenuePoint.AxisLabel = startDate.ToString("MM/yyyy");
                revenuePoint.YValues = new double[] { monthRevenue };
                revenuePoint.Label = monthRevenue > 0 ? monthRevenue.ToString("N0") : "";
                revenuePoint.Color = REVENUE_CORLOR;

                var spendingPoint = new DataPoint();
                spendingPoint.AxisLabel = startDate.ToString("MM/yyyy");
                spendingPoint.YValues = new double[] { monthSpeding };
                spendingPoint.Label = monthSpeding > 0 ? monthSpeding.ToString("N0") : "";
                spendingPoint.Color = SPENDING_CORLOR;
                
                revenueSeries.Points.Add(revenuePoint);
                spendingSeries.Points.Add(spendingPoint);
            }
        }
        #endregion
        #region Processing
        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        private void InitComboBoxes()
        {
            var currentYear = DateTime.Now.Year;
            var yearItems = Enumerable.Range(currentYear - 4, 5)
                .Select(year => new { Label = $"Năm {year.ToString()}", Value = year })
                .Reverse()
                .ToList();

            cboYear.DataSource = yearItems;
            cboYear.DisplayMember = "Label";
            cboYear.ValueMember = "Value";

            var fromMonthItems = Enumerable.Range(1, 12)
                .Select(month => new { Label = $"Tháng {month.ToString()}", Value = month })
                .ToList();

            cboFromMonth.DataSource = fromMonthItems;
            cboFromMonth.DisplayMember = "Label";
            cboFromMonth.ValueMember = "Value";
            cboFromMonth.SelectedIndex = 0;

            var toMonthItems = Enumerable.Range(1, 12)
                .Select(month => new { Label = $"Tháng {month.ToString()}", Value = month })
                .ToList();

            cboToMonth.DataSource = toMonthItems;
            cboToMonth.DisplayMember = "Label";
            cboToMonth.ValueMember = "Value";
            cboToMonth.SelectedIndex = 11;
        }

        private void chartRevenue_Click(object sender, EventArgs e)
        {

        }

        private void pnlTitle_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            chartRevenue.Legends.Clear();
            chartRevenue.Series.Clear();
            LoadDataSource();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
