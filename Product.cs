using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSalesApp
{
    public class Product
    {
        public string Name { get; set; }
        public int? Barcode { get; private set; }
        public double SalePrice { get; set; }
        public double CostPrice { get; set; }
        public int TVA { get; set; }
        public int Marge { get; set; }

        public bool FixedMarge { get; set; }

        public Product()
        {
            Name = "Default product";
            CostPrice = 0;
            TVA = 0;
            Marge = 20;
            FixedMarge = true;
        }
        public Product(string name, double cost)
        {
            Name = name;
            CostPrice = cost;
            TVA = 21;
            Marge = 20;
            FixedMarge = true;
        }

        public void EnterBarcode(int barcode)
        {
            Barcode = barcode;
        }
    }
}
