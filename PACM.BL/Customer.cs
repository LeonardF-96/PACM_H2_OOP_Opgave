using System;
using System.Collections.Generic;
using PACME.Common;

namespace PACM.BL
{
    public class Customer : EntityBase, ILoggable
    {
        public Customer(): this(0)
        {

        }
        public Customer(int customerId)
        {
            CustomerID = customerId;
            AddressList = new List<Address>();
        }
        public List<Address> AddressList { get; set; }
        public string FirstName { get; set; }
        private string _lastname;
        public string LastName
        {
            get
            {
                return _lastname;
            }
            set
            {
                _lastname = value;
            }
        }
        public override string ToString() => FullName;
        public string Log() => $"{CustomerID}: {FullName} Email: {Email_Address} status: {EntityState.ToString()}";
        public string FullName
        {
            get 
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }
        public string Email_Address { get; set; }
        public int CustomerID { get; private set; }
        public int CustomerType { get; set; }
        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(Email_Address)) isValid = false;

            return isValid;
        }
    }
}
