using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTestBrowsers.Tests
{
    [TestFixture(Description = "Test Case 01: Chrome")]
    public class Tests
    {
        BrowserOperations brow;

        [SetUp]
        public void Setup()
        {
            brow = new BrowserOperations(new ChromeDriver(@"c:\webdrivers"));
            brow.InitBrowser();
        }

        [Test(Description = "Test search")]
        public void TestSearch()
        {
            brow.Goto("https://www.duckduckGo.com");

            System.Threading.Thread.Sleep(4000);

            IWebElement element = brow.WebDriver.FindElement(By.XPath("//*[@id='search_form_input_homepage']"));

            element.SendKeys("LambdaTest");

            element.Submit();

            System.Threading.Thread.Sleep(4000);

            Assert.Pass();
        }

        [TearDown]
        public void CloseBrowser()
        {
            brow.Close();
        }
    }
}