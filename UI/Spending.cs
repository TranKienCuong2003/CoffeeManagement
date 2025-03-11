using CoffeeManagement.BLL;
using CoffeeManagement.DAL;
using CoffeeManagement.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeManagement.UI
{
    public partial class Spending : Form
    {
        public Spending()
        {
            InitializeComponent();
            Init();
            LoadDataSource();
        }

        private void Init()
        {
            // DateTimePickers
            DateTime today = DateTime.Now;
            dtpFromDate.Value = new DateTime(today.Year, today.Month, 1);
            dtpToDate.Value = dtpFromDate.Value.AddMonths(1).AddDays(-1);
        }

        private void LoadDataSource()
        {
            var metarialItems = MaterialItemService.Instance.GetMaterialItemInRange(dtpFromDate.Value, dtpToDate.Value);
            ShowTotalSpending(metarialItems);

            dgvSpending.DataSource = metarialItems;
            dgvSpending.Columns["ID"].HeaderText = "ID";
            dgvSpending.Columns["Material"].HeaderText = "Nguyên liệu";
            dgvSpending.Columns["Description"].HeaderText = "Mô tả";
            dgvSpending.Columns["Quantity"].HeaderText = "Số lượng";
            dgvSpending.Columns["Unit"].HeaderText = "Đơn vị";
            dgvSpending.Columns["Price"].HeaderText = "Giá";
            dgvSpending.Columns["FormattedExpireDate"].HeaderText = "Ngày hết hạn";
            dgvSpending.Columns["ExpireDate"].Visible = false;
            dgvSpending.Columns["IsExpired"].Visible = false;
        }

        private void btnStatistical_Click(object sender, EventArgs e)
        {
            var metarialItems = MaterialItemService.Instance.GetMaterialItemInRange(dtpFromDate.Value, dtpToDate.Value);
            dgvSpending.DataSource = metarialItems;
            ShowTotalSpending(metarialItems);
        }

        private void ShowTotalSpending(List<MaterialItemDTO> materialItems)
        {
            int totalSum = 0;
            foreach (var item in materialItems)
            {
                totalSum += item.Price;
            }
            txtTotalSpeding.Text = totalSum.ToString("N0") + " VND";
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
