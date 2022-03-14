using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PACM.BL;

namespace PACM.BLTest
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                Email_Address = "fbaggins@hobbiton.me",
                FirstName = "Frodo",
                LastName = "Baggins"
            };
            var actual = customerRepository.Retrieve(1);

            Assert.AreEqual(expected.CustomerID, actual.CustomerID);
            Assert.AreEqual(expected.Email_Address, actual.Email_Address);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
        }
        [TestMethod]
        public void RetrieveExistingWithAddress()
        {
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                Email_Address = "fbaggins@hobbiton.me",
                FirstName = "Frodo",
                LastName = "Baggins",
                AddressList = new List<Address>()
                {
                    new Address()
                    {
                        AddressType = 1,
                        StreetLine1 = "Bag End",
                        StreetLine2 = "Bagshot Row",
                        City = "Hobbiton",
                        State = "Shire",
                        Country = "Middle Earth",
                        PostalCode = "144"
                    },
                    new Address()
                    {
                        AddressType = 2,
                        StreetLine1 = "Green Dragon",
                        City = "Bywater",
                        State = "Shire",
                        Country = "Middle Earth",
                        PostalCode = "146"
                    },
                }
            };
            var actual = customerRepository.Retrieve(1);
            Assert.AreEqual(expected.CustomerID, actual.CustomerID);
            Assert.AreEqual(expected.Email_Address, actual.Email_Address);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);

            for (int counter = 0; counter < 1; counter++)
            {
                Assert.AreEqual(expected.AddressList[counter].AddressType, actual.AddressList[counter].AddressType);
                Assert.AreEqual(expected.AddressList[counter].StreetLine1, actual.AddressList[counter].StreetLine1);
                Assert.AreEqual(expected.AddressList[counter].City, actual.AddressList[counter].City);
                Assert.AreEqual(expected.AddressList[counter].State, actual.AddressList[counter].State);
                Assert.AreEqual(expected.AddressList[counter].Country, actual.AddressList[counter].Country);
                Assert.AreEqual(expected.AddressList[counter].PostalCode, actual.AddressList[counter].PostalCode);
            }
        }
    }
}
