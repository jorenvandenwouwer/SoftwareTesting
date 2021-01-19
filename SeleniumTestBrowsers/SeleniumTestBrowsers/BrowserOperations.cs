using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumTestBrowsers
{
    public class BrowserOperations
    {
        private IWebDriver _webDriver;

        public BrowserOperations(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }
        public void InitBrowser()
        {
            _webDriver.Manage().Window.Maximize();
        }
        public string Title
        {
            get { return _webDriver.Title; }
        }
        public IWebDriver WebDriver
        {
            get { return _webDriver; }
        }
        public void Goto(string url)
        {
            _webDriver.Url = url;
        }
        public void Close()
        {
            _webDriver.Quit();
        }
    }
}
