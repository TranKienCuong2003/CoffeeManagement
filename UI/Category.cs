using CoffeeManagement.DAL;
using System;
using System.Windows.Forms;

namespace CoffeeManagement
{
    public partial class Category : Form
    {
        private bool add = false;
        #region System
        public Category()
        {
            InitializeComponent();
        }

        private void Category_Load(object sender, EventArgs e)
        {
            LoadDataSource();
        }
        #endregion
        #region Common function
        private void LoadDataSource()
        {
            btnSave.Enabled = false;
            dgvCategory.DataSource = CategoryDAL.Instance.GetTable();
            dgvCategory.Columns[0].HeaderText = "ID";
            dgvCategory.Columns[1].HeaderText = "Tên danh mục";

            txtID.Enabled = false;
        }
        #endregion
        #region Event handler properties
        private event EventHandler insertCategory;
        public event EventHandler InsertCategory
        {
            add { insertCategory += value; }
            remove { insertCategory -= value; }
        }

        private event EventHandler updateCategory;
        public event EventHandler UpdateCategory
        {
            add { updateCategory += value; }
            remove { updateCategory -= value; }
        }

        private event EventHandler deleteCategory;
        public event EventHandler DeleteCategory
        {
            add { deleteCategory += value; }
            remove { deleteCategory -= value; }
        }
        #endregion
        #region Processing
        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvCategory.DataSource = CategoryDAL.Instance.SearchCategory(txtSearch.Text);
            if (dgvCategory.RowCount == 0)  
                MessageBox.Show("Không tìm thấy kết quả phù hợp với từ khoá '" + txtSearch.Text + "' này", "Tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtName.Clear();
            txtName.Focus();
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnSearch.Enabled = false;
            btnSave.Enabled = true;
            add = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtName.Focus();
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnSearch.Enabled = false;
            btnSave.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(txtID.Text, out id))
            {
                MessageBox.Show("Vui lòng chọn mục để xóa", "Danh mục", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DialogResult result = MessageBox.Show("Khi bạn nhấn OK thì tất cả thức uống thuộc danh mục này sẽ bị sẽ xoá theo", "Danh mục", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if(result == DialogResult.OK)
            {
                
                if (CategoryDAL.Instance.DeleteCategory(id))
                {
                    LoadDataSource();
                    MessageBox.Show("Xoá thành công", "Danh mục", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    if (deleteCategory != null)
                        deleteCategory(this, new EventArgs());
                }
                else MessageBox.Show("Xoá thất bại", "Danh mục", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadDataSource();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCategory.SelectedRows.Count == 1)
            {
                DataGridViewRow row = dgvCategory.SelectedRows[0];
                txtID.Text = row.Cells["IdCategory"].Value.ToString();
                txtName.Text = row.Cells["NameCategory"].Value.ToString();
            }
        }

        private void dgvCategory_DataSourceChanged(object sender, EventArgs e)
        {
            lblStatus.Text = dgvCategory.RowCount + " danh mục";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (add)
            {
                if (CategoryDAL.Instance.InsertCategory(txtName.Text))
                {
                    LoadDataSource();
                    MessageBox.Show("Thêm thành công", "Danh mục", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    if (insertCategory != null)
                        insertCategory(this, new EventArgs());
                }
                else MessageBox.Show("Thêm thất bại", "Danh mục", MessageBoxButtons.OK, MessageBoxIcon.Question);
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
                btnSearch.Enabled = true;
                btnSave.Enabled = false;
                add = false;
            }
            else
            {
                if (CategoryDAL.Instance.UpdateCategory(Convert.ToInt32(txtID.Text), txtName.Text))
                {
                    LoadDataSource();
                    MessageBox.Show("Cập nhật thành công", "Danh mục", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    if (updateCategory != null)
                        updateCategory(this, new EventArgs());
                }
                else MessageBox.Show("Cập nhật thất bại", "Danh mục", MessageBoxButtons.OK, MessageBoxIcon.Question);
                btnAdd.Enabled = true;
                btnDelete.Enabled = true;
                btnSearch.Enabled = true;
                btnSave.Enabled = false;    
            }
        }
        #endregion

        private void dgvCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            return;
        }
    }
}
