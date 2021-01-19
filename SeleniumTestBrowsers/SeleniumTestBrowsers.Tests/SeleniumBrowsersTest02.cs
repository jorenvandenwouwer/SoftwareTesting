using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace SeleniumTestBrowsers.Tests
{
    [TestFixture(Description = "Test Case 02: FireFox")]
    public class TestsFox
    {
        BrowserOperations brow;

        [SetUp]
        public void Setup()
        {
            brow = new BrowserOperations(new FirefoxDriver(@"c:\webdrivers"));
            brow.InitBrowser();
        }

        [Test(Description = "Test search")]
        public void TestSearch()
        {
            brow.Goto("https://www.ap.be");


            IWebElement element = brow.WebDriver.FindElement(By.Name("aggregated_field"));

            element.SendKeys("Bedrijfsmanagement - Accountancy-Fiscaliteit");

            element.Submit();

            IWebElement el = brow.WebDriver.FindElement(By.XPath("//*[contains(text(),'Accountancy-Fiscaliteit')]"));
            el.Click();


            string title = brow.WebDriver.Title;
            Assert.AreEqual(title, "Opleiding Bedrijfsmanagement - Accountancy-Fiscaliteit | AP Hogeschool");

        }

        [TearDown]
        public void CloseBrowser()
        {
            brow.Close();
        }
    }
}