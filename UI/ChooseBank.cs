using CoffeeManagement.DAL;
using CoffeeManagement.qrCode;
using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CoffeeManagement.model;
using CoffeeManagement.utils;
using CoffeeManagement.DTO;
using CoffeeManagement.pdf;
using CoffeeManagement.UI;
namespace CoffeeManagement.management
{
    public partial class ChooseBank : Form
    {
        private BillPayload Payload;

        public ChooseBank(BillPayload payload)
        {
            InitializeComponent();
            this.Payload = payload;
            LoadData();
        }

        private void LoadData()
        {
            cboBank.DataSource = Bank.LoadExistingBanks();
            cboBank.DisplayMember = "Code";
            cboBank.ValueMember = "Name";

            txtBankName.DataBindings.Clear();
            txtBankName.DataBindings.Add("Text", cboBank.DataSource, "Name");

            txtAccountNo.DataBindings.Clear();
            txtAccountNo.DataBindings.Add("Text", cboBank.DataSource, "AccountNo");

            txtAccountName.DataBindings.Clear();
            txtAccountName.DataBindings.Add("Text", cboBank.DataSource, "AccountName");

            txtTotalPrice.Text = PriceUtils.ToPriceString(Payload.TotalPrice);
            txtDiscount.Text = PriceUtils.ToPercentString(Payload.Discount);
            txtFinalPrice.Text = PriceUtils.ToPriceString(Payload.FinalPrice);
        }

        private void cboDrink_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedBank = cboBank.SelectedItem as Bank;
           
            string projectDir = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
            string fullPath = Path.Combine(projectDir, selectedBank.LogoPath);
            pBBank.Image = Image.FromFile(fullPath);
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            var SelectedBank = cboBank.SelectedItem as Bank;
            string billNo = GenerateBillNo();
            InvoiceGenerator.Instance.GenerateInvoice(Payload, SelectedBank, billNo);
            this.Hide();
            var confirmBill = new ConfirmBill(billNo, Payload);
            confirmBill.ShowDialog();
        }

        private string GenerateBillNo()
        {
            DateTime now = DateTime.Now;

            long ticks = now.Ticks;

            return now.ToString("yyyyMMddHHmmss") + ticks % 10000000;
        }
    }
}
