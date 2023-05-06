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
        // Allow acess to the order variables. 
        public string type { get; set; }
        public double cost { get; set; }
        public string color { get; set; }
        public string size { get; set; }
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

