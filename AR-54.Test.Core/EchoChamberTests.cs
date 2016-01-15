using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AR_54.Common.Test;

namespace AR_54.Test.Core
{
    [TestClass]
    public class ShoutTests
    {
        [TestMethod]
        public void Test_ShoutLoudly_WithLowerCase()
        {
            // Arrange
            string input = "fourwordsalluppercase";

            // Act
            string output = EchoChamber.ShoutLoudly(input);

            // Assert
            Assert.AreEqual(input.ToUpper(), output);
        }

        [TestMethod]
        public void Test_ShoutLoudly_WithUpperCase()
        {
            // Arrange
            string input = "ONE WORD ALL LOWERCASE";

            // Act
            string output = EchoChamber.ShoutLoudly(input);

            // Assert
            Assert.AreEqual(input.ToUpper(), output);
        }
    }
}
