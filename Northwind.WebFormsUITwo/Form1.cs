using Northwind.BusinessTwo.Concrete.EntityFramework;
using Northwind.BusinessTwo.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.WebFormsUITwo
{
    public partial class Form1 : Form
    {
        private readonly IManager _productManager;
        public Form1()
        {
            InitializeComponent();
            _productManager = new ProductManager();
        }

        private void cmbSearchCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListAll();
        }
        private void ListAll()
        {
            dgwProducts.DataSource = _productManager.ListAll();
        }
    }
}
