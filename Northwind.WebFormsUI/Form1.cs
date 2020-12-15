using Northwind.Business.Facade;
using System;
using System.Windows.Forms;

namespace Northwind.WebFormsUI
{
    public partial class Form1 : Form
    {
        private readonly ProductManager _productOperations;
        public Form1()
        {
            InitializeComponent();
            _productOperations = new ProductManager();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListAllProducts();
            ListAllCategories();
        }

        private void cmbSearchCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListByCategoryId();
        }

        private void ListAllProducts()
        {
            dgwProducts.DataSource = _productOperations.GetAllProducts();
        }

        private void ListAllCategories()
        {
            cmbSearchCategory.DataSource = _productOperations.GetAllCategories();
            cmbSearchCategory.DisplayMember = "CategoryName";
            cmbSearchCategory.ValueMember = "CategoryID";
        }

        private void ListByCategoryId()
        {
            try
            {
                dgwProducts.DataSource = _productOperations.SearchByCategory(Convert.ToInt32(cmbSearchCategory.SelectedValue));
            }
            catch
            {
            }
        }

    }
}
