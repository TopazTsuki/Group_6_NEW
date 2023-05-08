using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Order
    {
        // Set data field with Order variables such as ID, Status, and Jewlery. 
        private string ID;
        private string Jewlery;
        private string status;

        public List<Jewlery> Items { get; set; }

        // Allow users to create orders that contain jewlery. 
        public Order()
        {
            Items = new List<Jewlery>();
        }

        // 
        public string Order(string ID, string JewlType, string description)
        {
            Order Order = new Order();
        }






    }
}
