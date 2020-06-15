using Microsoft.VisualStudio.TestTools.UnitTesting;
using PML.PrimeNumber;
using System;
using System.Collections.Generic;
using System.Text;

namespace PML.PrimeNumber.Tests
{
    [TestClass()]
    public class PrimeNumberServiceTests
    {
        [TestMethod()]
        public void PrimeNumberServiceTest()
        {
            {
                // Arrange
                var pns = new PrimeNumberService(100);
                // Act
                var rc = pns == null;
                // Assert
                Assert.IsFalse(rc);
            }
        }

        [TestMethod()]
        public void FindPrimeNumbersTest()
        {
            // Arrange
            var pns = new PrimeNumberService(100);
            // Act
            var fndPrimes = pns.FindPrimeNumbers( 2);
            // Assert
            Assert.IsTrue(fndPrimes.Count == 100);
        }
    }
}