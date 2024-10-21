using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FNZ.Models
{
    public class Customers
    {
        private List<Customer> _customers;

        public Customers()
        {
            _customers = new List<Customer>();
        }

        public void AddCustomer(Customer customer)
        {
            if (customer.DateOfBirth > DateTime.Now) 
            {
                throw new Exception("Birthday_error");
            
            }
            _customers.Add(customer);
        }

        public double AverageAge(Gender? gender)
        {
            if (gender != null)
            {
                return _customers.Where(c => c.Gender == gender).Average(c => c.Age());
            }

            return _customers.Average(c => c.Age());
        }
    }
}
