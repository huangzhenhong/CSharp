using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACM.BL.Data
{
    public class CustomerRepository
    {
        private AddressRepository addressRepository { get; set; }

        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }

        public Customer Retrieve(int custId)
        {
            Customer customer = new Customer(custId);
            customer.AddressList = addressRepository.RetrieveByCustomerId(custId).ToList();

            if (custId == 1) {
                customer.EmailAddress = "Frodo@gmail.com";
                customer.FirstName = "Frodo";
                customer.LastName = "Baggins";
            }
            return customer;
        }

        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }

        public bool Save(Customer customer)
        {
            var success = true;

            if (customer.HasChanges && customer.IsValid)
            {
                if (customer.IsNew)
                {

                }
                else
                {

                }
            }
            return success;
        }
    }
}
