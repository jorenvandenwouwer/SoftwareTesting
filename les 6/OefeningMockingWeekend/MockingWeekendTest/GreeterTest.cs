using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Moq;
using OefeningMockingWeekend;
using System.Runtime.InteropServices;

using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace MockingWeekendTest
{
    [TestClass]
    public class GreeterTest
    {
        [TestMethod]
        public void GetMessage_Returns_It_Is_Week_Day()
        {
            var dateGetter = new Mock<IDateGetter>();
            var date = new DateTime(2020, 10, 26);
            dateGetter.Setup(x => x.GetDate()).Returns(date);
            var greeter = new Greeter(dateGetter.Object);
            var result = greeter.GetMessage();
            Assert.AreEqual("Work hard, weekend is on his way....", result);
        }
        [TestMethod]
        public void GetMessage_Returns_It_Is_Weekend()
        {
            var dateGetter = new Mock<IDateGetter>();
            var date = new DateTime(2020, 10, 25);
            dateGetter.Setup(x => x.GetDate()).Returns(date);
            var greeter = new Greeter(dateGetter.Object);
            var result = greeter.GetMessage();
            Assert.AreEqual("Party time.....it's weekend", result);
        }
    }
}
