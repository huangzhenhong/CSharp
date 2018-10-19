using System;
using System.Collections.Generic;
using System.Text;
using ACM.BL.Data;
using NUnit.Framework;

namespace ACM.BL.UnitTests.Data
{
    [TestFixture]
    [Category("CustomerRepositoryTests")]
    public class CustomerRepositoryTests
    {
        [Test]
        public void RetrieveExisting() {
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1) {
                EmailAddress = "Frodo@gmail.com",
                FirstName = "Frodo",
                LastName = "Baggins"
            };

            var actual = customerRepository.Retrieve(1);

            Assert.That(expected.CustomerId, Is.EqualTo(actual.CustomerId));
            Assert.That(expected.EmailAddress, Is.EqualTo(actual.EmailAddress));
            Assert.That(expected.FirstName, Is.EqualTo(actual.FirstName));
            Assert.That(expected.LastName, Is.EqualTo(actual.LastName));
        }

        [Test]
        public void RetrieveExistingWithAddress() {
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "Frodo@gmail.com",
                FirstName = "Frodo",
                LastName = "Baggins",
                AddressList = new List<Address>() {
                    new Address() {
                        StreetLine1 = "Bag End",
                        StreetLine2 = "Bagshot row",
                        City = "Hobbiton",
                        State = "Shire",
                        Country = "Middle Earth",
                        PostalCode = "144"
                    },
                    new Address() {
                        StreetLine1 = "Green Dragon",
                        StreetLine2 = "",
                        City = "Bywater",
                        State = "Shire",
                        Country = "Middle Earth",
                        PostalCode = "144"
                    }
                }
            };

            var actual = customerRepository.Retrieve(1);

            Assert.That(expected.CustomerId, Is.EqualTo(actual.CustomerId));
            Assert.That(expected.EmailAddress, Is.EqualTo(actual.EmailAddress));
            Assert.That(expected.FirstName, Is.EqualTo(actual.FirstName));
            Assert.That(expected.LastName, Is.EqualTo(actual.LastName));

            for (int i = 0; i < 1; i++) {
                Assert.AreEqual(expected.AddressList[i].AddressType, actual.AddressList[i].AddressType);
            }
        }
    }
}
