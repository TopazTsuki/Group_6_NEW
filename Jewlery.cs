using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    
    public class Jewlery
    {
        // Set data field for Jewlery variables. 
        private string type;
        private double price;
        private double cost;

        // Allow access to lists and description 
        public string Description { get; set; }

        public List<Material> Materials { get; set; }
        public List<int> Quantities { get; set; }

        // Construct method to create a piece of jewlery with materials and quantity
        public Jewlery()
        {
            // Create new materials list 
            Materials = new List<Material>();
            // Create new quantity list 
            Quantities = new List<int>();
        }

   }
}

