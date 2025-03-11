using CoffeeManagement.BLL;
using CoffeeManagement.DAL;
using CoffeeManagement.DTO;
using PdfSharp.Pdf.Content.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CoffeeManagement.UI
{
    public partial class MaterialItem : Form
    {
        private bool add = false;

        public MaterialItem()
        {
            InitializeComponent();
        }

        private void MaterialItem_Load(object sender, EventArgs e)
        {
            Init();
            LoadDataSource();
        }

        private void Init()
        {
            // Combo box material
            cboMaterial.DataSource = MaterialService.Instance.GetAllMaterials();
            cboMaterial.DisplayMember = "Name";
            cboMaterial.ValueMember = "Name";

            // Combo box unit
            var units = new List<string> { "g", "kg", "ml", "l" };
            cbUnit.DataSource = units;

            // Datetime picker expire
            dtpExpireDate.Value = DateTime.Now;

            nudPrice.Value = 0;
            nudQuantity.Value = 0;

            txtID.Enabled = false;
            btnSave.Enabled = false;
        }

        private void LoadDataSource()
        {
            
            dgvMaterialItem.DataSource = MaterialItemService.Instance.GetAllMaterialItems();
            dgvMaterialItem.Columns["ID"].HeaderText = "ID";
            dgvMaterialItem.Columns["Material"].HeaderText = "Nguyên liệu";
            dgvMaterialItem.Columns["Description"].HeaderText = "Mô tả";
            dgvMaterialItem.Columns["Quantity"].HeaderText = "Số lượng";
            dgvMaterialItem.Columns["Unit"].HeaderText = "Đơn vị";
            dgvMaterialItem.Columns["Price"].HeaderText = "Giá";
            dgvMaterialItem.Columns["FormattedExpireDate"].HeaderText = "Ngày hết hạn";
            dgvMaterialItem.Columns["ExpireDate"].Visible = false;
            dgvMaterialItem.Columns["IsExpired"].Visible = false;

            filterExpiredMaterialItems();
        }

        private void filterExpiredMaterialItems()
        {
            foreach (DataGridViewRow row in dgvMaterialItem.Rows)
            {
                if (!row.IsNewRow)
                {
                    bool isExpired = Convert.ToBoolean(row.Cells["IsExpired"].Value);
                    if (isExpired)
                    {
                        row.DefaultCellStyle.BackColor = Color.LightCoral;
                    }
                }
            }
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbMaterial_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvMaterialItem.DataSource = MaterialItemService.Instance.SearchMaterialItem(txtSearch.Text);
            filterExpiredMaterialItems();
            if (dgvMaterialItem.RowCount == 0)
                MessageBox.Show("Không tìm thấy kết quả phù hợp với từ khoá '" + txtSearch.Text + "' này", "Tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtSearch.Clear();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            resetInputs();
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnSearch.Enabled = false;
            btnSave.Enabled = true;
            add = true;
        }

        private void resetInputs()
        {
            txtID.Clear();
            cboMaterial.SelectedIndex = 0;
            txtDescription.Clear();
            txtDescription.Focus();
            nudQuantity.Value = 0;
            cbUnit.SelectedIndex = 0;
            nudPrice.Value = 0;
            dtpExpireDate.Value = DateTime.Now;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var material = cboMaterial.SelectedValue.ToString();
            var description = txtDescription.Text;
            var quantity = (int)nudQuantity.Value;
            var unit = cbUnit.SelectedItem.ToString();
            var price = (int)nudPrice.Value;
            var expireDate = dtpExpireDate.Value;
            if (add)
            {
                if (MaterialItemDAL.Instance.InsertMaterialItem(material, description, quantity, unit, price, expireDate))
                {
                    LoadDataSource();
                    MessageBox.Show("Thêm thành công", "Nguyên liệu", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else MessageBox.Show("Thêm thất bại", "Nguyên liệu", MessageBoxButtons.OK, MessageBoxIcon.Question);
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
                btnSearch.Enabled = true;
                btnSave.Enabled = false;
                resetInputs();
                add = false;
            }
            else
            {
                if (MaterialItemDAL.Instance.UpdateMaterialItem(Convert.ToInt32(txtID.Text), material, description, quantity, unit, price, expireDate))
                {
                    LoadDataSource();
                    MessageBox.Show("Cập nhật thành công", "Nguyên liệu", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else MessageBox.Show("Cập nhật thất bại", "Nguyên liệu", MessageBoxButtons.OK, MessageBoxIcon.Question);
                btnAdd.Enabled = true;
                btnDelete.Enabled = true;
                btnSearch.Enabled = true;
                btnSave.Enabled = false;
                resetInputs();
            }
        }

        private void cboMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvMaterialItem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMaterialItem.SelectedRows.Count == 1)
            {
                var row = dgvMaterialItem.SelectedRows[0];
                txtID.Text = row.Cells["ID"].Value.ToString();
                cboMaterial.Text = row.Cells["Material"].Value.ToString();
                txtDescription.Text = row.Cells["Description"].Value.ToString();
                nudQuantity.Value = Convert.ToInt32(row.Cells["Quantity"].Value);
                cbUnit.Text = row.Cells["Unit"].Value.ToString();
                nudPrice.Value = Convert.ToInt32(row.Cells["Price"].Value);
                dtpExpireDate.Value = Convert.ToDateTime(row.Cells["ExpireDate"].Value);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtDescription.Focus();
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnSearch.Enabled = false;
            btnSave.Enabled = true;
            add = false;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadDataSource();
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

                if (MaterialItemDAL.Instance.DeleteMaterialItem(id))
                {
                    LoadDataSource();
                    MessageBox.Show("Xoá thành công", "Nguyên liệu", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else MessageBox.Show("Xoá thất bại", "Danh mục", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }

            resetInputs();
        }
    }
}
