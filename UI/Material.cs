using CoffeeManagement.BLL;
using CoffeeManagement.DAL;
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
    public partial class Material : Form
    {
        private bool add = false;

        public Material()
        {
            InitializeComponent();

            txtID.Enabled = false;

            LoadDataSource();
        }

        private void LoadDataSource()
        {
            btnSave.Enabled = false;
            dgvMaterial.DataSource = MaterialService.Instance.GetAllMaterials();
            dgvMaterial.Columns[0].HeaderText = "ID";
            dgvMaterial.Columns[1].HeaderText = "Tên nguyên liệu";
            dgvMaterial.Columns[2].HeaderText = "Ngày tạo";
            
            btnSave.Enabled = false;
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(txtID.Text, out id))
            {
                MessageBox.Show("Vui lòng chọn nguyên liệu để xóa", "Nguyên liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DialogResult result = MessageBox.Show("Khi bạn nhấn OK thì nguyên liệu này sẽ bị xoá", "Nguyên liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {

                if (MaterialDAL.Instance.DeleteMaterial(id))
                {
                    LoadDataSource();
                    MessageBox.Show("Xoá thành công", "Nguyên liệu", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else MessageBox.Show("Xoá thất bại", "Danh mục", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            txtID.Clear();
            txtName.Clear();
            txtName.Focus();
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
            add = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Vui lòng nhập tên nguyên liệu", "Nguyên liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }

            if (add)
            {
                if (MaterialDAL.Instance.InsertMaterial(name))
                {
                    LoadDataSource();
                    MessageBox.Show("Thêm thành công", "Nguyên liệu", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else MessageBox.Show("Thêm thất bại", "Nguyên liệu", MessageBoxButtons.OK, MessageBoxIcon.Question);
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
                btnSearch.Enabled = true;
                btnSave.Enabled = false;
                txtName.Clear();
                txtName.Focus();
                add = false;
            }
            else
            {
                if (MaterialDAL.Instance.UpdateMaterial(Convert.ToInt32(txtID.Text), name))
                {
                    LoadDataSource();
                    MessageBox.Show("Cập nhật thành công", "Nguyên liệu", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else MessageBox.Show("Cập nhật thất bại", "Nguyên liệu", MessageBoxButtons.OK, MessageBoxIcon.Question);
                btnAdd.Enabled = true;
                btnDelete.Enabled = true;
                btnSearch.Enabled = true;
                btnSave.Enabled = false;
                txtName.Clear();
                txtName.Focus();
            }
        }

        private void pnlTitle_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvMaterial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMaterial.SelectedRows.Count == 1)
            {
                DataGridViewRow row = dgvMaterial.SelectedRows[0];
                txtID.Text = row.Cells["ID"].Value.ToString();
                txtName.Text = row.Cells["Name"].Value.ToString();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvMaterial.DataSource = MaterialService.Instance.SearchMaterial(txtSearch.Text);
            if (dgvMaterial.RowCount == 0)
                MessageBox.Show("Không tìm thấy kết quả phù hợp với từ khoá '" + txtSearch.Text + "' này", "Tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadDataSource();
        }
    }
}
