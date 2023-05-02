using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Customer
    {
        public List<Customer> customer { get; set; }

        public Customer()
        {
            customer = new List<Customer>();
        }

  /*     public Customer Authenticate(string username, string password)
        {
            Customer c = customer;
       }
   */ }
}
