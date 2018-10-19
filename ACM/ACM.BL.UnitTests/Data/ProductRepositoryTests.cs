using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using ACM.BL.Data;

namespace ACM.BL.UnitTests.Data
{
    [TestFixture]
    [Category("ProductRepositoryTests")]
    public class ProductRepositoryTests
    {
        [Test]
        public void RetrieveExisting() {
            var productRepository = new ProductRepository();
            var expected = new Product(1) {
                ProductName = "iPhone XS Max"
            };
            var actual = productRepository.Retrieve(1);
            Assert.AreEqual(expected.ProductId, actual.ProductId);
            Assert.AreEqual(expected.ProductName, actual.ProductName);
        }

    }
}
