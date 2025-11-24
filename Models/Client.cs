using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSalesApp.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsCompany { get; set; }
        public string TVA { get; set; }
        public double Money { get; set; }

        public Client()
        {
            Name = "Default Client";
            TVA = "BE012345678";
            Money = 0;
            IsCompany = true;
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
