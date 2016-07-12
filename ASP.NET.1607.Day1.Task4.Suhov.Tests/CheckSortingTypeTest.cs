using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ASP.NET._1607.Day1.Task4.Suhov.Tests
{
    [TestClass]
    public class CheckSortingTypeTest
    {
        [TestMethod]
        public void TestCheckSortingTypeArrays()
        {
            // Arrange
            var arrays = new List<int>() { 123456, 654321, 1122334455, 99887766, 111111, 123654321  };
            string[] result = new string[] { "Increasing", "Desreasing", "IncreaseLax", "DesreaseLax", "Mono", "NoSort" };
            // Act
            // Assert
            int i = 0;
            arrays.ForEach(delegate (int numb) {
                Assert.AreEqual(CheckSortingType.CheckType(numb), result[i]);
                i++;
            });

        }
    }
}
