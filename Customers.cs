using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProject.Model
{
    public class Customers
    {
        // Allow access to customers list. 
        public List<Customer> customers { get; set; }

        // Allow creation of customer lists. 
        public Customers()
        {
            customers = new List<Customer>();
        }

        // Create system to authenticate user logins. 
        public Customer Authenticate(string username, string password)
        {
            // Only allow customers who have the proper username and password to log in. 
            var c = customers.Where(o => (o.Username == username) && (o.Password == password));

            // Allow users to stay logged in if they have logged in in the past. 
            if (c.Count() > 0)
            {
                return c.First();
            }
            else
            {
                return null;
            }
        }
    }
}