using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSalesApp
{
    public class Product
    {
        private int _tva;
        private int _marge;

        public string Name { get; set; }
        public int? Barcode { get; private set; }
        public double SalePrice { get; set; }
        public double CostPrice { get; set; }
        public int TVA
        {
            get { return _tva; }
            set
            {
                _tva = value;
                CalculateSalePrice();
            }
        }
        public int Marge
        {
            get { return _marge; }
            set
            {
                _marge = value;
                CalculateSalePrice();
            }
        }

        public bool FixedMarge { get; set; }

        public Product()
        {
            Name = "Default product";
            CostPrice = 0;
            TVA = 0;
            Marge = 0;
            FixedMarge = false;
        }
        public Product(string name, double cost)
        {
            Name = name;
            CostPrice = cost;
            TVA = 21;
            Marge = 0;
            FixedMarge = false;
        }

        public void CalculateSalePrice()
        {
            if (FixedMarge)
            {
                SalePrice = CostPrice + (CostPrice * TVA / 100) + (CostPrice * Marge / 100);
            }
        }
        public void EnterBarcade(int barcode)
        {
            Barcode = barcode;
        }
    }
}
