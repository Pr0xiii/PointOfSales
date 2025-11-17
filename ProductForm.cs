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
    public partial class ProductForm : Form
    {
        private readonly PointOfSale _pos;
        private readonly Product _product;
        public ProductForm(PointOfSale pos)
        {
            _pos = pos;
            InitializeComponent();
            _product = new Product();
        }

        private void comboBoxMarge_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxMarge.SelectedItem.ToString() == "Variable")
            {
                salePriceField.ReadOnly = false;
                _product.FixedMarge = false;
                _product.SalePrice = double.Parse(salePriceField.Text);
            }
            else
            {
                salePriceField.ReadOnly = true;
                _product.FixedMarge = true;
                _product.Marge = 20;
            }
            salePriceField.Text = _product.SalePrice.ToString();
        }

        private void costPriceField_TextChanged(object sender, EventArgs e)
        {
            bool cost = double.TryParse(costPriceField.Text, out double result);

            if (cost)
            {
                _product.CostPrice = result;
                salePriceField.Text = _product.SalePrice.ToString();
            }
            else
            {
                MessageBox.Show("Please enter a valid number");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxTVA.SelectedIndex)
            {
                case 0:
                    _product.TVA = 0;
                    break;

                case 1:
                    _product.TVA = 6;
                    break;

                case 2:
                    _product.TVA = 21;
                    break;
            }
            salePriceField.Text = _product.SalePrice.ToString();
        }

        private void b_Save_Click(object sender, EventArgs e)
        {
            //Save en backend
            _product.Name = productNameField.Text;
        }

        private void salePriceField_ReadOnlyChanged(object sender, EventArgs e)
        {
            salePriceField.Text = _product.SalePrice.ToString();
        }

        private void b_Create_Click(object sender, EventArgs e)
        {
            _pos.Products.Add(_product);
            this.DialogResult = DialogResult.OK;
        }
    }
}
