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

        private int productTVA = 0;
        private bool margeFixed = true;

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
                margeFixed = false;
            }
            else
            {
                salePriceField.ReadOnly = true;
                margeFixed = true;
            }
            salePriceField.Text = CalculateSalePrice().ToString();
            OnChangeField(true);
        }

        private void costPriceField_TextChanged(object sender, EventArgs e)
        {
            bool cost = double.TryParse(costPriceField.Text, out double result);

            if (cost)
            {
                salePriceField.Text = CalculateSalePrice().ToString();
                OnChangeField(true);
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
                    productTVA = 0;
                    break;

                case 1:
                    productTVA = 6;
                    break;

                case 2:
                    productTVA = 21;
                    break;
            }

            salePriceField.Text = CalculateSalePrice().ToString();
            OnChangeField(true);
        }

        private void b_Save_Click(object sender, EventArgs e)
        {
            //Save en backend
            _product.Name = productNameField.Text == "" ? "New product" : productNameField.Text;
            _product.CostPrice = costPriceField.Text == "" ? 0 : double.Parse(costPriceField.Text);
            _product.SalePrice = salePriceField.Text == "" ? 0 : double.Parse(salePriceField.Text);
            _product.TVA = productTVA;
            _product.FixedMarge = margeFixed;
            OnChangeField(false);
        }

        private void salePriceField_ReadOnlyChanged(object sender, EventArgs e)
        {
            salePriceField.Text = _product.SalePrice.ToString();
        }

        private void b_Create_Click(object sender, EventArgs e)
        {
            if(b_Save.Visible == true)
            {
                b_Save_Click(sender, e);
            }
            
            _pos.Products.Add(_product);
            this.DialogResult = DialogResult.OK;
        }

        private void productNameField_TextChanged(object sender, EventArgs e)
        {
            OnChangeField(true);
        }

        private double CalculateSalePrice()
        {
            double cost = double.Parse(costPriceField.Text);
            if (margeFixed)
            {
                return cost + (cost * productTVA / 100) + (cost * 20 / 100);
            }
            else
            {
                return cost;
            }
        }

        private void b_Cancel_Click(object sender, EventArgs e)
        {
            productNameField.Text = _product.Name;
            costPriceField.Text = _product.CostPrice.ToString();
            salePriceField.Text = _product.CostPrice.ToString();
            margeFixed = _product.FixedMarge;
            comboBoxTVA.ResetText();
            comboBoxMarge.ResetText();
        }

        private void OnChangeField(bool state)
        {
            b_Save.Visible = state;
            b_Cancel.Visible = state;
        }
    }
}
