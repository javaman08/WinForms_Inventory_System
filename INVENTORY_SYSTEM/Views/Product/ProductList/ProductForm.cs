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
using WinFormsMenuExample;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace INVENTORY_SYSTEM.Views.Product.ProductList
{
    public partial class ProductForm : Form
    {
        IProductRepository productRepository;

        private List<ToolStripMenuItem> menuItems = new List<ToolStripMenuItem>();
        public ProductForm()
        {
            InitializeComponent();

            MenuStateHelper.SetInitialMenuStates(menuAdd, menuUpdate, menuSave, menuCancel);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            productRepository = new ProductRepository();
            dgvProducts.DataSource = productRepository.GetProducts();
        }

        private void menuAdd_Click(object sender, EventArgs e)
        {
            MenuStateHelper.DisableAddAndUpdate(menuAdd, menuUpdate, menuSave, menuCancel);
        }

        private void menuUpdate_Click(object sender, EventArgs e)
        {
            MenuStateHelper.DisableAddAndUpdate(menuAdd, menuUpdate, menuSave, menuCancel);
        }

        private void menuSave_Click(object sender, EventArgs e)
        {
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
    }
}
