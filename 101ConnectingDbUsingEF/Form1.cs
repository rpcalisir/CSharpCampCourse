using _101ConnectingDbUsingEF.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _101ConnectingDbUsingEF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListCategories();
            ListProducts();
        }

        private void ListProducts()
        {
            using (NorthwindContext context = new NorthwindContext())
            {

                dgwProducts.DataSource = context.Products.ToList();
            }
        }
        private void ListProductsByCategoryId(int selectedCategoryId)
        {
            using (NorthwindContext context = new NorthwindContext())
            {

                dgwProducts.DataSource = context.Products.Where(p => p.CategoryId == selectedCategoryId).ToList();
            }
        }

        private void ListProductsByName(string selectedName)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                dgwProducts.DataSource = context.Products.Where(p => p.ProductName.Contains(selectedName)).ToList();
            }
        }
        private void ListCategories()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                cmbSearchCategory.DataSource = context.Categories.ToList();
                cmbSearchCategory.ValueMember = "CategoryID";
                cmbSearchCategory.DisplayMember = "CategoryName";
            }
        }

        private void cmbSearchCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                int expectedCategoryId = Convert.ToInt32(cmbSearchCategory.SelectedValue);
                ListProductsByCategoryId(expectedCategoryId);
            }
            catch
            {

            }
        }

        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchName.Text))
            {
                ListProducts();
            }
            else
            {
                ListProductsByName(txtSearchName.Text);
            }
        }
    }
}
