using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PACM.BL
{
    public class CustomerRepository
    {
        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }
        private AddressRepository addressRepository { get; set; }
        public Customer Retrieve(int CustomerID)
        {
            Customer customer = new Customer(CustomerID);
            if (CustomerID == 1)
            {
                customer.Email_Address = "fbaggins@hobbiton.me";
                customer.FirstName = "Frodo";
                customer.LastName = "Baggins";
                customer.AddressList = addressRepository.RetrieveByCustomerID(CustomerID).ToList();
            }
            return customer;
        }
        public bool Save(Customer customer)
        {
            return true;
        }
    }
}
