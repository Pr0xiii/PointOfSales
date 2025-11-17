using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSalesApp
{
    public class Sale
    {
        public int Id;
        public Vendors Vendor;
        public List<Product> BoughtProducts = new List<Product>();
        public double Total { get; private set; }

        public Sale(int id, Vendors vendor, Product product)
        {
            Id = id;
            Vendor = vendor;
            BoughtProducts.Add(product);
            Total = product.SalePrice;
            Console.WriteLine($"Starting a new sale with {product.Name}. Total : {Total}.");
        }

        public void AddProduct(Product product)
        {
            BoughtProducts.Add(product);
            Total += product.SalePrice;
            Console.WriteLine($"Adding {product.Name} to the cart. Total : {Total}.");
        }
        public void RemoveProduct(Product product)
        {
            BoughtProducts.Remove(product);
            Total -= product.SalePrice;
            Console.WriteLine($"Removing {product.Name} from the cart. Total : {Total}.");
        }
        public double GetTotalPrice()
        {
            if (BoughtProducts.Count == 0) return 0.00;

            return BoughtProducts.Sum(e => e.SalePrice);
        }
    }

}
