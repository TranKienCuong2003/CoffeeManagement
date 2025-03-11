using CoffeeManagement.BLL;
using CoffeeManagement.DAL;
using CoffeeManagement.DTO;
using System;
using System.Data;
using System.Windows.Forms;

namespace CoffeeManagement
{
    public partial class AccountProfile : Form
    {
        #region Properties
        public AccountDTO LoginAccount { get; set; }
        #endregion
        #region System
        public AccountProfile(AccountDTO loginAccount)
        {
            InitializeComponent();
            LoginAccount = loginAccount;
            txtUsername.Text = LoginAccount.Username;
            txtDisplayName.Text = LoginAccount.DisplayName;
        }
        #endregion
        #region Event handler properties
        private event EventHandler<AccountEvent> updateAccount;
        public event EventHandler<AccountEvent> UpdateAccount
        {
            add { updateAccount += value; }
            remove { updateAccount -= value; }
        }
        #endregion
        #region Process
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!txtNewPassword.Text.Equals(txtEnterPassword.Text))
                MessageBox.Show("Mật khẩu mới không khớp", "Thông tin tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (AccountDAL.Instance.UpdateAccount(txtUsername.Text, txtDisplayName.Text, txtPassword.Text, txtNewPassword.Text))
                {
                    MessageBox.Show("Cập nhật thành công", "Thông tin tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (updateAccount != null)
                        updateAccount(null, new AccountEvent(AccountService.Instance.GetAccountByUsername(txtUsername.Text)));
                }
                else MessageBox.Show("Cập nhật thất bại", "Thông tin tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }

    public class AccountEvent : EventArgs
    {
        public AccountEvent(AccountDTO loginAcc)
        {
            LoginAcc = loginAcc;
        }

        public AccountDTO LoginAcc { get; set; }
    }
}
