using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSalesApp
{
    public partial class PointOfSaleForm : Form
    {
        private readonly PointOfSale _pos;

        public PointOfSaleForm(PointOfSale pos)
        {
            _pos = pos;
            InitializeComponent();
            InitializePointOfSale();
        }

        public void InitializePointOfSale()
        {
            labelVendorName.Text = _pos.Vendor.ToString();
            InitializeProducts();
        }
        private void InitializeProducts()
        {
            if (_pos.Products.Count == 0) return;
            // Initialize products
            foreach(Product product in _pos.Products) 
            {
                Button btn = new Button();
                btn.Size = new Size(100, 50);
                btn.Text = product.Name;
                btn.Click += (sender, e) => _pos.OnEnterProduct(product);
                productsLayoutPanel.Controls.Add(btn);
            }
        }

        private void b_CreateProduct_Click(object sender, EventArgs e) 
        {
            // Open Product form
            // If dialogResult == OK => Add Product
            ProductForm productForm = new ProductForm(_pos);
            DialogResult dialog = productForm.ShowDialog();

            if(dialog == DialogResult.OK)
            {
                InitializeProducts();
            }
        }

        private void b_CreateClient_Click(object sender, EventArgs e) 
        {
            // Open Client form
            // If dialogResult == OK => Create Client
        }

        private void b_Cancel_Click(object sender, EventArgs e) 
        {
            _pos.CancelSale();
            MessageBox.Show("Your current sale is canceled");
        }

        private void b_Encaisser_Click(object sender, EventArgs e) 
        {
            if(_pos.Encaisser()) {
                MessageBox.Show("Sale confirmed. Thanks for your purchase.");
            }
            else {
                MessageBox.Show("No sales found. Or the customer has an insufficient balance.");
            }
        }
    }
}
