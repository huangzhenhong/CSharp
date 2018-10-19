using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Moq;
using ACM.BL;

namespace ACM.BL.UnitTests
{
    [TestFixture]
    [Category("CustomerTests")]
    public class CustomerTests
    {
        [SetUp]
        public void SetUp() {

        }

        [Test]
        public void FullNameTestValid() {
            Customer customer = new Customer
            {
                FirstName = "Bilbo",
                LastName = "Baggins"
            };
            
            string expected = "Baggins, Bilbo";

            var result = customer.FullName;

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void FullNameFirstNameEmpty()
        {
            Customer customer = new Customer
            {
                FirstName = "",
                LastName = "Baggins"
            };

            string expected = "Baggins";

            var result = customer.FullName;

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void FullNameLastNameEmpty()
        {
            Customer customer = new Customer
            {
                FirstName = "Bilbo",
                LastName = ""
            };

            string expected = "Bilbo";

            var result = customer.FullName;

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void StaticTest() {
            var customer1 = new Customer
            {
                FirstName = "Bilbo",
                LastName = ""
            };
            Customer.InstanceCount += 1;

            var customer2 = new Customer
            {
                FirstName = "Frodo",
                LastName = ""
            };
            Customer.InstanceCount += 1;

            Assert.That(Customer.InstanceCount, Is.EqualTo(2));
        }

        [Test]
        public void ValidateValid() {
            var cust = new Customer
            {
                LastName = "Baggins",
                EmailAddress = "baggins@gmail.com"
            };
            
            Assert.IsTrue(cust.Validate());
        }

        [Test]
        public void ValidateLastNameEmpty()
        {
            var cust = new Customer
            {
                EmailAddress = "baggins@gmail.com"
            };

            Assert.IsFalse(cust.Validate());
        }

        [Test]
        public void ValidateEmailEmpty()
        {
            var cust = new Customer
            {
                LastName = "Baggins"
            };

            Assert.IsFalse(cust.Validate());
        }

    }
}
