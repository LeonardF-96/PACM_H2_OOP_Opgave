using Microsoft.VisualStudio.TestTools.UnitTesting;
using PACM.BL;

namespace PACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //Arrange
            Customer customer = new Customer
            {
                FirstName = "Bilbo",
                LastName = "Baggins"
            };
            string expected = "Baggins, Bilbo";
            //Act
            string actual = customer.FullName;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            Customer customer = new Customer
            {
                LastName = "Baggins"
            };
            string expected = "Baggins";
            string actual = customer.FullName;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            Customer customer = new Customer
            {
                FirstName = "Bilbo"
            };
            string expected = "Bilbo";
            string actual = customer.FullName;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ValidateValid()
        {
            var customer = new Customer
            {
                LastName = "Baggins",
                Email_Address = "fbaggins@hobbiton.me"
            };
            var expected = true;
            var actual = customer.Validate();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ValidateMissingLastName()
        {
            var customer = new Customer
            {
                Email_Address = "fbaggins@hobbiton.me"
            };
            var expected = false;
            var actual = customer.Validate();
            Assert.AreEqual(expected, actual);
        }
    }
}
