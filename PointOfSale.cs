using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSalesApp
{
    public enum Vendors
    {
        John,
        Polo,
        Lea,
        Anna,
        Paul
    }

    public class PointOfSale
    {
        private List<Sale> TodaysSales = new List<Sale>();

        public string Name { get; private set; }
        public Vendors Vendor;
        public List<Product> Products = new List<Product>();
        public List<Client> Clients = new List<Client>();
        public Sale CurrentSale { get; private set; }
        protected double Money { get; private set; }
        protected Client CurrentClient { get; private set; }

        public PointOfSale(string name, double money)
        {
            Name = name;
            Money = money;
        }
        public PointOfSale(string name, double money, List<Product> products)
        {
            Name = name;
            Money = money;
            Products = products;
        }

        public void SetVendor(Vendors vendor)
        {
            Vendor = vendor;
        }
        public void SetClient(Client client)
        {
            CurrentClient = client;
        }
        public void OnEnterProduct(Product product)
        {
            if (Vendor == null) return;
            if (CurrentSale == null)
            {
                CurrentSale = new Sale(TodaysSales.Count, Vendor, product);
            }
            else
            {
                CurrentSale.AddProduct(product);
            }
        }
        public void RemoveProduct(Product product)
        {
            if (CurrentSale != null)
            {
                CurrentSale.RemoveProduct(product);
            }
        }

        public bool Encaisser()
        {
            if (CurrentSale != null && CurrentClient.Acheter(CurrentSale.Total))
            {
                Money += CurrentSale.Total;
                TodaysSales.Add(CurrentSale);
                CurrentSale = null;
                return true;
            }
            else {
                return false;
            }
        }
        public void CancelSale() 
        {
            if(CurrentSale != null) {
                CurrentSale = null;
            }
        }
    }
}
