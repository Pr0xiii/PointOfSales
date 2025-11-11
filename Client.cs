using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSalesApp
{
    public class Client
    {
        public string Name { get; private set; }
        public string TVA { get; private set; }
        public double Money { get; private set; }

        public Client(string name, string tva, double money)
        {
            Name = name;
            TVA = tva;
            Money = money;
        }

        public bool Acheter(double amount)
        {
            double expected = Money - amount;

            if(expected >= 0)
            {
                Money -= amount;
                return true;
            }
            else
            {
                return false;
            }
        } 
    }
}
