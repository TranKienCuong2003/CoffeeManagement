using CoffeeManagement.BLL;
using CoffeeManagement.DAL;
using CoffeeManagement.DTO;
using System;
using System.Data;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace CoffeeManagement
{
    public partial class Account : Form
    {
        #region Properties
        private AccountDTO LoginAccount { get; set; }
        private bool isAdd = false;
        #endregion
        #region System
        public Account(AccountDTO loginAccount)
        {
            InitializeComponent();
            LoginAccount = loginAccount;
        }

        private void Account_Load(object sender, EventArgs e)
        {
            LoadDataSource();
        }
        #endregion
        #region Common function
        private void LoadDataSource()
        {
            dgvAccount.DataSource = AccountService.Instance.GetAllAccounts();

            dgvAccount.Columns["Password"].Visible = false;

            dgvAccount.Columns["Username"].HeaderText = "Tên đăng nhập";
            dgvAccount.Columns["DisplayName"].HeaderText = "Tên đầy đủ";
            dgvAccount.Columns["Access"].HeaderText = "Quyền truy cập";
            dgvAccount.Columns["DateOfBirth"].HeaderText = "Ngày sinh";
            dgvAccount.Columns["DateOfBirth"].DefaultCellStyle.Format = "dd/MM/yyyy";

            dtpDateOfBirth.Format = DateTimePickerFormat.Custom;
            dtpDateOfBirth.CustomFormat = "dd/MM/yyyy";
        }

        private void ClearInput()
        {
            txtUsername.Clear();
            txtDisplayName.Clear();
            dtpDateOfBirth.Value = DateTime.Now;
            cboAccess.SelectedIndex = 1;
            txtUsername.Enabled = true;
            txtUsername.Focus();
        }

        private string EncodeStringToMD5(string password)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(password);
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);
            //Array.Reverse(hasData);
            string hasPass = "";
            foreach (byte item in hasData)
                hasPass += item;
            return hasPass;
        }
        #endregion
        #region Event handler properties
        private event EventHandler insertAccount;
        public event EventHandler InsertAccount
        {
            add { insertAccount += value; }
            remove { insertAccount -= value; }
        }

        private event EventHandler updateAccount;
        public event EventHandler UpdateAccount
        {
            add { updateAccount += value; }
            remove { updateAccount -= value; }
        }

        private event EventHandler deleteAccount;
        public event EventHandler DeleteAccount
        {
            add { deleteAccount += value; }
            remove { deleteAccount -= value; }
        }
        #endregion
        #region Processing
        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvAccount.DataSource = AccountDAL.Instance.SearchAccount(txtSearch.Text);
            if (dgvAccount.RowCount == 0)
                MessageBox.Show("Không tìm thấy kết quả phù hợp với từ khoá '" + txtSearch.Text + "' này", "Tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClearInput();
            btnSave.Enabled = true;
            btnEdit.Enabled = true;
            isAdd = true;
            btnAdd.Enabled = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtUsername.Enabled = false;
            btnSave.Enabled = true;
            btnAdd.Enabled = true;
            isAdd = false;
            btnEdit.Enabled = false;
        }

        private void HandleCreateOrEdit()
        {
            if (isAdd)
            {
                HandleAdd();
                btnSave.Enabled = false;
                btnAdd.Enabled = true;
                ClearInput();
            } else
            {
                HandleEdit();
                btnSave.Enabled = false;
                btnEdit.Enabled = true;
                ClearInput();
            }
        }

        private void HandleAdd()
        {
            if (AccountService.Instance.InsertAccount(txtUsername.Text, txtDisplayName.Text, cboAccess.Text, dtpDateOfBirth.Value))
            {
                MessageBox.Show("Thêm thành công", "Tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Question);
                LoadDataSource();
                if (insertAccount != null)
                    insertAccount(this, new EventArgs());
            }
            else MessageBox.Show("Thêm thất bại", "Tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void HandleEdit()
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần cập nhật", "Tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }

            if (AccountService.Instance.EditAccount(txtUsername.Text, txtDisplayName.Text, cboAccess.Text, dtpDateOfBirth.Value))
            {
                MessageBox.Show("Cập nhật thành công", "Tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Question);
                LoadDataSource();
                if (updateAccount != null)
                    updateAccount(this, new EventArgs());
            }
            else MessageBox.Show("Cập nhật thất bại", "Tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(LoginAccount.Username == txtUsername.Text)
            {
                MessageBox.Show("Bạn không thể xoá tài khoản đang đăng nhập", "Tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (AccountDAL.Instance.DeleteAccount(txtUsername.Text))
            {
                MessageBox.Show("Xoá thành công", "Tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Question);
                LoadDataSource();
                if (deleteAccount != null)
                    deleteAccount(this, new EventArgs());
            }
            else MessageBox.Show("Vui lòng chọn tài khoản cần xoá", "Tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            HandleCreateOrEdit();
        }

        private void btnResetPass_Click(object sender, EventArgs e)
        {
            var boxOption = MessageBox.Show("Bạn có chắc chắn muốn thiết lập lại mật khẩu cho tài khoản '" + txtUsername.Text + "' không?", "Tài khoản", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (boxOption == DialogResult.OK)
            {
                if (AccountService.Instance.ResetPassword(txtUsername.Text))
                    MessageBox.Show("Thiết lập lại mật khẩu thành công", "Tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Question);
                else MessageBox.Show("Thiết lập lại mật khẩu thất bại", "Tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void dgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAccount.SelectedRows.Count == 1)
            {

                var selectedAccount = dgvAccount.CurrentRow.DataBoundItem as AccountDTO;
                txtUsername.Text = selectedAccount.Username;
                txtDisplayName.Text = selectedAccount.DisplayName;
                dtpDateOfBirth.Value = selectedAccount.DateOfBirth != null ? (DateTime) selectedAccount.DateOfBirth : DateTime.Now;
                cboAccess.Text = selectedAccount.Access;
            }
        }

        private void dgvAccount_DataSourceChanged(object sender, EventArgs e)
        {
            lblStatus.Text = dgvAccount.RowCount + " tài khoản";
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void dgvAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
