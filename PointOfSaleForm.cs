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
        public PointOfSale PointOfSale { get; set; }

        public PointOfSaleForm()
        {
            InitializeComponent();
            InitializePointOfSale();
        }

        public void InitializePointOfSale()
        {
            labelVendorName.Text = PointOfSale.Vendor.ToString();

            // Initialize products
            foreach(Product product in PointOfSale.Products) 
            {
                Button btn = new Button();
                btn.Size = new Size(100, 50);
                btn.Text = product.Name;
                btn.Click += (sender, e) => PointOfSale.OnEnterProduct(product);
                productsLayoutPanel.Controls.Add(btn);
            }
        }

        private void b_CreateProduct_Click(object sender, EventArgs e) 
        {
            // Open Product form
            // If dialogResult == OK => Add Product
        }

        private void b_CreateClient_Click(object sender, EventArgs e) 
        {
            // Open Client form
            // If dialogResult == OK => Create Client
        }

        private void b_Cancel_Click(object sender, EventArgs e) 
        {
            PointOfSale.CancelSale();
            MessageBox.Show("Your current sale is canceled");
        }

        private void b_Encaisser_Click(object sender, EventArgs e) 
        {
            if(PointOfSale.Encaisser()) {
                MessageBox.Show("Sale confirmed. Thanks for your purchase.");
            }
            else {
                MessageBox.Show("No sales found. Or the customer has an insufficient balance.")
            }
        }
    }
}
