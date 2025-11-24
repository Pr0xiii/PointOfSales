using PointOfSalesApp.Data;
using PointOfSalesApp.Models;
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
            using(var db = new PosContext())
            {
                var products = db.Products.ToList();

                if (products.Count == 0) return;
                productsLayoutPanel.Controls.Clear();
                // Initialize products
                foreach (Product product in products)
                {
                    Button btn = new Button();
                    btn.Size = new Size(100, 50);
                    btn.Text = product.Name;
                    btn.Click += (sender, e) => AddProductToSale(product);
                    productsLayoutPanel.Controls.Add(btn);
                }
            }
        }
        private void AddProductToSale(Product product)
        {
            _pos.OnEnterProduct(product);
            textBoxSale.Text += $"{product.Name} ---- {product.SalePrice}" + System.Environment.NewLine;
        }

        private void b_CreateProduct_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm(_pos);
            DialogResult dialog = productForm.ShowDialog();

            if (dialog == DialogResult.OK)
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
            if (_pos.Encaisser())
            {
                MessageBox.Show("Sale confirmed. Thanks for your purchase.");
            }
            else
            {
                MessageBox.Show("No sales found. Or the customer has an insufficient balance.");
            }
        }

        private void textBoxSale_TextChanged(object sender, EventArgs e)
        {
            labelTotalPrice.Text = $"Total : {_pos.CurrentSale.GetTotalPrice()}";
        }
    }
}
