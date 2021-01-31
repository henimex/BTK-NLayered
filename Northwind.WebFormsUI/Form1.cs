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

        private void LoadCategories()
        {
            cbxCategory.DataSource = _categoryService.GetAll();
            cbxCategory.DisplayMember = "CategoryName";
            cbxCategory.ValueMember = "CategoryId";
            cbxCategory.Text = "";
        }

        private void LoadProducts()
        {
            dgwProducts.DataSource = _productService.GetAll().ToList();
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgwProducts.DataSource = _productService.GetProductsByCategory(Convert.ToInt32(cbxCategory.SelectedValue));
                btnClearFilters.Enabled = true;
            }
            catch (Exception exception)
            {

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

        private void ManageFilterButton()
        {
            btnClearFilters.Enabled = false;
            cbxCategory.Text = "";
        }
    }
}
