using CoffeeManagement.BLL;
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
    public partial class Reset : Form
    {
        public Reset()
        {
            InitializeComponent();
        }

        private void ckbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !ckbShowPass.Checked;
            txtConfirmPassword.UseSystemPasswordChar = !ckbShowPass.Checked;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Xác nhận mật khẩu không khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var user = Program.context.LoginAccount;
            var isSuccess = AccountService.Instance.ResetPassword(user.Username, txtPassword.Text.Trim(), false);

            if (isSuccess) {
                MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Đổi mật khẩu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
