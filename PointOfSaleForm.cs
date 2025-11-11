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
        }

        public void InitializePointOfSale()
        {
            labelVendorName.Text = PointOfSale.Vendor.ToString();
        }
    }
}
