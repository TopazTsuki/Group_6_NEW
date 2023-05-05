using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Order
    {
        private string ID;
        private string Jewlery;
        private string status;

        public List<Jewelry> Items { get; set; }

        public Order()
        {
            Items = new List<Jewlery>();
        }

        // Order Method Draft 1 
        public string Order(string ID, string JewlType, string description)
        {
            Order Order = new Order();
        }






    }
}
