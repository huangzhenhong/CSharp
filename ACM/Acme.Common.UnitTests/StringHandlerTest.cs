using System;
using NUnit.Framework;

namespace Acme.Common.UnitTests
{
    [TestFixture]
    public class StringHandlerTest
    {
        [Test]
        public void InsertSpacesTest() {
            var source = "SonicScrewdriver";
            var expected = "Sonic Screwdriver";

            // var actual = StringHandler.InsertSpaces(source);
            var actual = source.InsertSpaces();

            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void InsertSpacesTestWithExistingSpace() {
            var source = "Sonic Screwdriver";
            var expected = "Sonic Screwdriver";

            // var actual = StringHandler.InsertSpaces(source);
            var actual = source.InsertSpaces();

            Assert.That(expected, Is.EqualTo(actual));
        }
    }
}
