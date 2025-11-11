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

        public string Name { get; private set; }
        public int? Barcode { get; private set; }
        public double SalePrice { get; private set; }
        public double CostPrice { get; private set; }
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

        public Product(string name, double cost)
        {
            Name = name;
            CostPrice = cost;
            TVA = 21;
            Marge = 0;
        }

        public void CalculateSalePrice()
        {
            SalePrice = CostPrice + (CostPrice * TVA / 100) + (CostPrice * Marge / 100);
            Console.WriteLine($"New price : {SalePrice} with {TVA}% of TVA and {Marge}% of marge");
        }
        public void EnterBarcade(int barcode)
        {
            Barcode = barcode;
        }
    }
}
