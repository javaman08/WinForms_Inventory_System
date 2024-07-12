using INVENTORY_SYSTEM.Model;
using INVENTORY_SYSTEM.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace INVENTORY_SYSTEM.Views.Product.ProductList
{
    public partial class ProductForm : Form
    {
        IProductRepository _productRepository;

        private List<ToolStripMenuItem> menuItems = new List<ToolStripMenuItem>();

        bool addData = false;
        public ProductForm(IProductRepository productRepository)
        {
            InitializeComponent();

            _productRepository = productRepository;

            MenuStateHelper.SetInitialMenuStates(menuAdd, menuUpdate, menuSave, menuCancel);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetProducts();
        }

        private void menuAdd_Click(object sender, EventArgs e)
        {
            addData = true;
            MenuStateHelper.DisableAddAndUpdate(menuAdd, menuUpdate, menuSave, menuCancel);
        }

        private void menuUpdate_Click(object sender, EventArgs e)
        {
            addData = false;
            MenuStateHelper.DisableAddAndUpdate(menuAdd, menuUpdate, menuSave, menuCancel);
        }

        private void menuSave_Click(object sender, EventArgs e)
        {
            if (addData)
            {
                var product = new Model.Product();
                product.ProductCode = txtProductCode.Text.Trim();
                product.BarCode = txtBarcode.Text.Trim();
                product.ProductName = txtProductName.Text.Trim();
                product.ProductDescription = txtProductDec.Text.Trim();
                product.ProductCategory = txtProductCategory.Text.Trim();
                product.PackedWeight = string.IsNullOrEmpty(txtPackedWeight.Text.Trim()) ? 0 : Convert.ToDecimal(txtPackedWeight.Text.Trim());
                product.PackedWidth = string.IsNullOrEmpty(txtPackedWidth.Text.Trim()) ? 0 : Convert.ToDecimal(txtPackedWidth.Text.Trim());
                product.PackedDepth = string.IsNullOrEmpty(txtPackedDepth.Text.Trim()) ? 0 : Convert.ToDecimal(txtPackedDepth.Text.Trim());
                product.Refrigerated = cbRefrigirated.Checked;

                _productRepository.AddProduct(product);

                GetProducts();
                MessageBox.Show("Add new Product data sucessfully done.");
            }
            else
            {
                MessageBox.Show("Update Product data sucessfully done.");
            }

            MenuStateHelper.SetInitialMenuStates(menuAdd, menuUpdate, menuSave, menuCancel);
        }

        private void menuCancel_Click(object sender, EventArgs e)
        {
            MenuStateHelper.SetInitialMenuStates(menuAdd, menuUpdate, menuSave, menuCancel);
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GetProducts()
        {
            dgvProducts.DataSource = _productRepository.GetProducts();
        }
    }
}
