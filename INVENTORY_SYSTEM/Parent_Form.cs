using INVENTORY_SYSTEM.Login;
using System;
using System.Windows.Forms;
using INVENTORY_SYSTEM.Views.Product.ProductList;
using INVENTORY_SYSTEM.Views.Customer.CustomerList;
using INVENTORY_SYSTEM.Repository;

namespace INVENTORY_SYSTEM
{
    public partial class Parent_Form : Form
    {
        IProductRepository _productRepository;
        public Parent_Form(IProductRepository productRepository)
        {
            InitializeComponent();
            _productRepository = productRepository; 
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login_Page page = new Login_Page();
            page.MdiParent = Parent_Form.ActiveForm;
            page.Show();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!FormHandler.IsFormOpen(typeof(ProductForm)))
            {
                ProductForm productForm = new ProductForm(_productRepository);
                productForm.MdiParent = Parent_Form.ActiveForm;
                productForm.Show();
            }            
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();
            customerForm.MdiParent = Parent_Form.ActiveForm;
            customerForm.Show();
        }
    }
}
