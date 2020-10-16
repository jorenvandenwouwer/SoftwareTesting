using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTesting.Tests
{
    [TestClass()]
    public class NumberGameTests
    {
        [TestMethod()]
        public void RateGuess_Returns_2_When_Guess_Is_Correct()
        {
            var numbergame = new NumberGame();
            var result = numbergame.RateGuess(5);
            Assert.AreEqual(2, result);
        }
    }
}