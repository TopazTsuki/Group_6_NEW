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
        private string Date;
        private string Jewlery;
        private string status;

        public List<Jewlery> Items { get; set; }

        public Order()
        {
            Items = new List<Jewlery>();
        }

    }
}
