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
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void RetrieveTest()
        {
            var productRepository = new ProductRepository();
            var expected = new Product(2)
            {
                CurrentPrice = 15.96M,
                ProductDescription = "4 delightful mini sunflowers in bright yellow.",
                ProductName = "Sunflowers"
            };
            var actual = productRepository.Retrieve(2);
            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
            Assert.AreEqual(expected.ProductDescription, actual.ProductDescription);
            Assert.AreEqual(expected.ProductName, actual.ProductName);
        }
        [TestMethod]
        public void SaveTestValid()
        {
            var productRepository = new ProductRepository();
            var updatedProduct = new Product(2)
            {
                CurrentPrice = 18M,
                ProductDescription = "4 delightful mini sunflowers in bright yellow.",
                ProductName = "Sunflowers",
                HasChanges = true
            };
            var actual = productRepository.Save(updatedProduct);
            Assert.AreEqual(true, actual);
        }
        [TestMethod]
        public void SaveTestMissingPrice()
        {
            var productRepository = new ProductRepository();
            var updatedProduct = new Product(2)
            {
                CurrentPrice = null,
                ProductDescription = "4 delightful mini sunflowers in bright yellow.",
                ProductName = "Sunflowers",
                HasChanges = true
            };
            var actual = productRepository.Save(updatedProduct);
            Assert.AreEqual(false, actual);
        }
    }
}
