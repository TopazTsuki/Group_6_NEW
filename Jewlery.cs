using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Jewlery
    {
        private string type;
        private double price;
        private double cost;


        public string Description { get; set; }

        public List<Material> Materials { get; set; }
        public List<int> Quantities { get; set; }

        public Jewlery()
        {
            Materials = new List<Material>();
            Quantities = new List<int>();
        }

   }
}

