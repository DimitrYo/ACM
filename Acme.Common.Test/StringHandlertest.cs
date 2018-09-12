using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Acme.Common;
using System.Linq;

namespace Acme.Common.Test {
    [TestClass]
    public class StringHandlerTest {
        [TestMethod]
        public void TestMethod1() {
            // Arrange
            string source = "SonicScrewdriver";
            var expected = "Sonic Screwdriver";

            // Act
            var actual = source.InsertSpaces();
                            
            // Assert
            Assert.AreEqual(expected, actual);
        }

        public void TestMethod2() {
            // Arrange
            var source = "Sonic Screwdriver";
            var expected = "Sonic Screwdriver";

            // Act
            var actual = source.InsertSpaces();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        public void TestMethod3() {
            // Arrange
            var source = "ABC";
            var expected = "A B C";

            // Act
            var actual = source.InsertSpaces();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
