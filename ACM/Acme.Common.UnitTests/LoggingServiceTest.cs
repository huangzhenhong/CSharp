using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using ACM.BL;

namespace Acme.Common.UnitTests
{
    [TestFixture]
    public class LoggingServiceTest
    {
        [Test]
        public void WriteToFileTest() {
            List<ILoggable> changedItems = new List<ILoggable>();
            ILoggable customer = new Customer(1)
            {
                EmailAddress = "Frodo@gmail.com",
                FirstName = "Frodo",
                LastName = "Baggins"
            };
            changedItems.Add(customer);

            ILoggable product = new Product(1) {
                ProductName = "iPhone XS Max"
            };
            changedItems.Add(product);

            LoggingService.WriteToFile(changedItems);

            // Assert.That()
        }
    }
}
