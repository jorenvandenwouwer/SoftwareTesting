using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection.Metadata;

namespace UnitTesting.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void SumTest()
        {
            var calculator = new Calculator();
            var a = 3;
            var b = 2;
            var expected = 5;
            var result = calculator.Sum(a, b);
            Assert.AreEqual(expected, result);
        }
    }
}