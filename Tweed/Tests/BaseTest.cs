using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Tweed.Tests
{
    public class BaseTest
    {
        protected IWebDriver driver;
        public string homeURL;

        [SetUp]
        //[OneTimeSetUp]
        public void SetupTest()
        {
            homeURL = "https://uk.virginmoney.com";
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(homeURL);
        }

        [TearDown]
        //[OneTimeTearDown]
        public void TearDownTest()
        {
            driver.Close();
        }
    }
}
