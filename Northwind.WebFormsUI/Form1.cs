using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Northwind.Business.Abstract;
using Northwind.Business.Concrete;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.Entities.Concrete;

namespace Northwind.WebFormsUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _productService = new ProductManager(new EfProductDal());
            _categoryService = new CategoryManager(new EfCategoryDal());
        }

        private IProductService _productService;
        private ICategoryService _categoryService;

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadCategories();
            ManageFilterButton();
        }

        #region UIInteractions

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgwProducts.DataSource = _productService.GetProductsByCategory(Convert.ToInt32(cbxCategory.SelectedValue));
                btnClearFilters.Enabled = true;
            }
            catch (Exception exception)
            {
                MessageBox.Show("Kategorileri Yüklerken Hata Oluştu Details \n{}",exception.Message);
            }
        }

        private void txtProductName_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtProductName.Text))
            {
                dgwProducts.DataSource = _productService.GetProductsByName(txtProductName.Text);
            }
            else
            {
                LoadProducts();
            }
        }

        private void btnClearFilters_Click(object sender, EventArgs e)
        {
            LoadProducts();
            ManageFilterButton();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _productService.Add(new Product
            {
                ProductName = txtPName.Text,
                QuantityPerUnit = txtQuantity.Text,
                UnitPrice = Convert.ToDecimal(txtPrice.Text),
                UnitsInStock = Convert.ToInt16(txtStock.Text),
                CategoryId = Convert.ToInt32(cbxCatId.SelectedValue)
            });
            MessageBox.Show("Product Saved");
            LoadProducts();
            ClearProductFields();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _productService.Update(new Product
            {
                ProductId = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                ProductName = txtPName.Text,
                QuantityPerUnit = txtQuantity.Text,
                UnitPrice = Convert.ToDecimal(txtPrice.Text),
                UnitsInStock = Convert.ToInt16(txtStock.Text),
                CategoryId = Convert.ToInt32(cbxCatId.SelectedValue)
            });
            MessageBox.Show("Product Updated");
            LoadProducts();
            ClearProductFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _productService.Delete(new Product
            {
                ProductId = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value)
            });
            MessageBox.Show("Product Deleted");
            LoadProducts();
            ClearProductFields();
        }

        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPName.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();
            cbxCatId.SelectedValue = dgwProducts.CurrentRow.Cells[2].Value;
            txtPrice.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();
            txtQuantity.Text = dgwProducts.CurrentRow.Cells[4].Value.ToString();
            txtStock.Text = dgwProducts.CurrentRow.Cells[5].Value.ToString();
        }

        #endregion

        #region UIMethods

        private void ManageFilterButton()
        {
            btnClearFilters.Enabled = false;
            cbxCategory.Text = "";
        }

        private void ClearProductFields()
        {
            txtPrice.Clear();
            txtQuantity.Clear();
            txtStock.Clear();
            txtPName.Clear();
            cbxCatId.Text = "";
        }

        private void LoadProducts()
        {
            dgwProducts.DataSource = _productService.GetAll().ToList();
        }

        private void LoadCategories()
        {
            cbxCategory.DataSource = _categoryService.GetAll();
            cbxCategory.DisplayMember = "CategoryName";
            cbxCategory.ValueMember = "CategoryId";

            cbxCatId.DataSource = _categoryService.GetAll();
            cbxCatId.DisplayMember = "CategoryName";
            cbxCatId.ValueMember = "CategoryId";

            cbxCategory.Text = "";
        }

        #endregion
    }
}
