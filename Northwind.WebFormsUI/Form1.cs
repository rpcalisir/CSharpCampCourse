using Northwind.Business.Facade;
using Northwind.Business.Interface;
using System;
using System.Windows.Forms;

namespace Northwind.WebFormsUI
{
    public partial class Form1 : Form
    {
        private readonly IProductManager _productManager;
        private readonly ICategoryManager _categoryManager;
        public Form1()
        {
            InitializeComponent();
            _productManager = new ProductManager();
            _categoryManager = new CategoryManager();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListAllProducts();
            ListAllCategories();
        }

        private void ListAllProducts()
        {
            dgwProducts.DataSource = _productManager.GetAllProducts();
        }

        private void ListAllCategories()
        {
            cmbSearchCategory.DataSource = _categoryManager.GetAllCategories();
            cmbSearchCategory.DisplayMember = "CategoryName";
            cmbSearchCategory.ValueMember = "CategoryID";
        }
        private void cmbSearchCategory_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ListByCategoryId();
        }

        private void ListByCategoryId()
        {
            try
            {
                dgwProducts.DataSource = _productManager.GetProductsByCategory(Convert.ToInt32(cmbSearchCategory.SelectedValue));
            }
            catch
            {
            }
        }

        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {
            dgwProducts.DataSource = _productManager.GetProductsByName(txtSearchName.Text);
        }
    }
}
