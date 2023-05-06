using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProject.Model
{
    public class Customer
    {
        // Create data field with ID variables. 
        private static int autoIncreament;
        // Allow access to certain customers variables/data. 
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Create a customer with an ID.
        public Customer()
        {
            // Create unique ID every time. 
            autoIncreament++;
            Id = autoIncreament;
        }
    }
}