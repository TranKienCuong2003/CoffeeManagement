using CoffeeManagement.DAL;
using CoffeeManagement.model;
using CoffeeManagement.utils;
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
    public partial class ConfirmBill : Form
    {
        private BillPayload Payload;

        public ConfirmBill(string billNo, BillPayload payload)
        {
            InitializeComponent();
            this.Payload = payload;

            txtBillNo.Text = billNo;
            txtFinalPrice.Text = PriceUtils.ToPriceString(payload.FinalPrice);

            var paymentOption = new List<string> { "Tiền mặt", "Chuyển khoản" };
            cboPaymentOption.DataSource = paymentOption;
                
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cboDrink_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtGivenPrice_TextChanged(object sender, EventArgs e)
        {
            int finalPrice = (int) PriceUtils.ToPriceNumber(txtFinalPrice.Text);
            var givenPriceStr = txtGivenPrice.Text;

            bool isValidPrice = int.TryParse(givenPriceStr, out int givenPrice);
            if (!isValidPrice)
            {
                txtChangePrice.Text = "";
                return;
            }

            if (givenPrice < finalPrice)
            {
                txtChangePrice.Text = "";
                return;
            }

            int change = givenPrice - finalPrice;
            txtChangePrice.Text = PriceUtils.ToPriceString(change);
        }

        private void txtGivenPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var boxOption = MessageBox.Show("Xác nhận thanh toán", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (boxOption == DialogResult.OK)
            {
                int customerMoney = (int) PriceUtils.ToPriceNumber(txtGivenPrice.Text);
                int change = (int)PriceUtils.ToPriceNumber(txtChangePrice.Text);
                string paymentOption = cboPaymentOption.SelectedItem.ToString();
                BillDAL.Instance.Payment(Payload.BillId, (int)Payload.Discount, (int)Payload.FinalPrice, customerMoney, change, paymentOption);
                Program.mainFrm.ShowBillInfoOfTable(Payload.TableId);
                Program.mainFrm.LoadTable();
                this.Hide();
            }
        }
    }
}
