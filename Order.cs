using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Order
    {
        public int ID { get; set; }
        public Jewelry Jewel { get; set; }
        public string status { get; set; }
        public List<Jewelry> Items { get; set; }

        public Order()
        {
            Items = new List<Jewelry>();
        }

      






    }
}
