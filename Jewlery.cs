using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Jewelry
    {

        public string JewelType { get; set; }
        public double JCost { get; set; }
        public string Description { get; set; }

        public List<string> type { get; set; }
        public List<double> Jprice { get; set; }

        public Jewelry()
        {
            List<string> type = new List<string>();
            type.Add("bracelet");
            type.Add("necklace");
            type.Add("ring");
<<<<<<< HEAD


            price = new List<double>();
=======


            price = new List<double>();
        }

    }
}
>>>>>>> e8499328bfcd033a71e5263860f32c80e2b78a5d

