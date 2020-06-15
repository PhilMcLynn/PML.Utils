using Microsoft.VisualStudio.TestTools.UnitTesting;
using PML.PrimeNumber;
using System;
using System.Collections.Generic;
using System.Text;

namespace PML.PrimeNumber.Tests
{
    [TestClass()]
    public class PrimeNumberCandidateTests
    {
        [TestMethod()]
        public void PrimeNumberCandidateTest()
        {
            // Arrange
            var pn = new PrimeNumberCandidate(143);
            // Act
            var rc = pn == null;
            // Assert
            Assert.IsFalse(rc);
        }

        [TestMethod()]
        public void GetIsPrimeNumberTestNotPrimeNumber()
        {
            // Arrange
            var pn = new PrimeNumberCandidate(143);
            // Act
            var rc = pn.GetIsPrimeNumber();
            // Assert
            Assert.IsFalse(rc);
        }
        [TestMethod()]
        public void GetIsPrimeNumberTest_PrimeNumber()
        {
            // Arrange
            var pn = new PrimeNumberCandidate(149);
            // Act
            var rc = pn.GetIsPrimeNumber();
            // Assert
            Assert.IsTrue(rc);
        }

        [TestMethod()]
        public void DisposeTest()
        {
            // Arrange
            var isOk = true;
            var pn = new PrimeNumberCandidate(149);
            // Act
            try
            {
                // Act
                pn.Dispose();
            }
            catch
            {
                isOk = false;
            }
            // Assert
            Assert.IsTrue(isOk);
        }
    }
}