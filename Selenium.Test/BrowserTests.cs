using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Reflection;

namespace Selenium.Test
{
    [TestFixture]
    public class BrowserTests
    {
        private static IWebDriver _chrome;
        private static IWebDriver _edge;
        private static IWebDriver _firefox;

        [SetUp]
        public void SetUp()
        {
            var directory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            //var pathDrivers = directory + "/../../../drivers";
            //var pathDrivers = @"C:\Users\VssAdministrator\.nuget\packages\selenium.webdriver.chromedriver\97.0.4692.7100\build\**\driver\win32\";
            var pathDrivers = directory;
            _chrome = new ChromeDriver(pathDrivers);
            //_edge = new EdgeDriver(pathDrivers);
            //_firefox = new FirefoxDriver(pathDrivers);
        }

        [Test]
        public void GoToIndex()
        {
            Console.WriteLine("User name is :" + TestContext.Parameters["webAppUserName"]);
            _chrome.Navigate().GoToUrl("https://google.com/");
            //_edge.Navigate().GoToUrl("https://www.microsoft.com/");
            //_firefox.Navigate().GoToUrl("http://www.mozilla.org/");
        }

        [TearDown]
        public void Cleanup()
        {
            _edge?.Dispose();
            _chrome?.Dispose();
            _firefox?.Dispose();
        }
    }
}
