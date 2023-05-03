using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Material
    {
        public Material(string type, double cost, string color, string size, int qty)
        {
            this.type = type;
            this.cost = cost;
            this.color = color;
            this.size = size;
            this.qty = qty;
        }
        public string MatType { get; set; }
        public double MatCost { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public int qty { get; set; }

        public string checkQty
        {
            get
            {

                if (qty <= 0)
                {
                    return ("No available materials of type:" + type);
                }
                return null;  

            }

        }
    }



}

