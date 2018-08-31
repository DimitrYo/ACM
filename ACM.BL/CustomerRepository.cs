using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class CustomerRepository
    {
        public Customer Retrieve(int customerid)
        {
            Customer customer = new Customer(customerid);

            if (customerid == 1)
            {
                customer.EmailAddress = "fbaggins@hobbiton.me";
                customer.FirstName = "Frodo";
                customer.LastName = "Baggins";
            }
            return customer;
        }

        public List<Customer> Retrieve()
        {

            return new List<Customer>();
        }

        /// <summary>
        /// Save the current customer
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            return true;
        }

    }
}
