using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSalesApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Barcode { get; set; }
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
            Barcode = 0;
            FixedMarge = true;
        }
    }
}
