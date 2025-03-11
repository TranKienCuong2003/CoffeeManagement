using CoffeeManagement.BLL;
using System;
using System.Data;
using System.Windows.Forms;

namespace CoffeeManagement
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (AccountService.Instance.isLoginSucess(txtUsername.Text, txtPassword.Text))
            {
                var account =  AccountService.Instance.GetAccountByUsername(txtUsername.Text);
                Program.context.LoginAccount = account;
                this.Hide();

                txtUsername.Clear();
                txtPassword.Clear();
                txtUsername.Focus();

                Program.mainFrm.PostLogin();

                if (!Program.context.LoginAccount.ForceResetPassword)
                    Program.mainFrm.ShowDialog();
                this.Show();
            }
            else
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không hợp lệ", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void ckbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !ckbShowPass.Checked;
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắn chắn muốn thoát không?", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
                this.Close();
        }
    }
}
