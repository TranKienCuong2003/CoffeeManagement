using CoffeeManagement.BLL;
using CoffeeManagement.DAL;
using CoffeeManagement.DTO;
using System;
using System.Data;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CoffeeManagement
{
    public partial class DrinkAnalytics : Form
    {
        #region Properties
        #endregion
        #region System
        public DrinkAnalytics( )
        {
            InitializeComponent();
        }

        private void SalesStatistical(object sender, EventArgs e)
        {
            InitComponents();
            LoadDataSource();
        }
        #endregion
        #region Common function
        private void InitComponents()
        {
            // DateTimePickers
            DateTime today = DateTime.Now;
            dtpFromDate.Value = new DateTime(today.Year, today.Month, 1);
            dtpToDate.Value = dtpFromDate.Value.AddMonths(1).AddDays(-1);

            // Drink chart
            drinkChart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            drinkChart.ChartAreas[0].AxisX.MinorGrid.Enabled = false;
            drinkChart.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            drinkChart.ChartAreas[0].AxisY.MinorGrid.Enabled = false;

            drinkChart.ChartAreas[0].AxisX.IsLabelAutoFit = true;
            drinkChart.ChartAreas[0].AxisX.Interval = 1;


            drinkChart.ChartAreas[0].AxisX.Title = "Thức uống";
            drinkChart.ChartAreas[0].AxisY.Title = "Số lượng đã bán";
            drinkChart.Legends.Clear();

            // Top combobox
            var topModes = new[]
            {
                new { Label = "Top 10", Value = 12 },
                new { Label = "Top 5", Value = 5 },
                new { Label = "Top 3", Value = 3 }
            };
            cbTop.DataSource = topModes;
            cbTop.DisplayMember = "Label";
            cbTop.ValueMember = "Value";
        }

        private void LoadDataSource()
        {
            Series series = new Series();
            series.ChartType = SeriesChartType.Column;
            drinkChart.Series.Add(series);

            var topValue = (int)cbTop.SelectedValue;
            if(topValue >= 10)
            {
                drinkChart.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
            } else
            {
                drinkChart.ChartAreas[0].AxisX.LabelStyle.Angle = 0;
            }
            
            var drinkAnalyticsItems = DrinkService.Instance.GetDrinkAnalytis(dtpFromDate.Value, dtpToDate.Value, topValue);

            foreach (var item in drinkAnalyticsItems)
            {
                var point = new DataPoint();
                point.AxisLabel = item.Name;
                point.YValues = new double[] { item.Quantity };
                point.Label = item.Quantity.ToString();
                point.Color = Color.FromArgb(255, 214, 90);

                series.Points.Add(point);
                
            }
        }
        #endregion
        #region Event handler properties
        #endregion
        #region Processing        
        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            drinkChart.Series.Clear();
            LoadDataSource();
        }

        private void drinkChart_Click(object sender, EventArgs e)
        {

        }
    }
}
