using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Tweed.PageObjects;

namespace Tweed
{
    [TestFixture]
    public class GlobalNavTest
    {
        private IWebDriver driver;
        public string homeURL;

        [Test(Description = "Check Global Nav contains the company logo")]
        public void GlobalNavContainsCorrectElements()
        {
            driver.Navigate().GoToUrl(homeURL);
            GlobalNavComponent globalNavComponent = new GlobalNavComponent(driver);

            Assert.AreEqual(1, 2);
        }


        [TearDown]
        public void TearDownTest()
        {
            driver.Close();
        }


        [SetUp]
        public void SetupTest()
        {
            homeURL = "https://uk.virginmoney.com";
            driver = new ChromeDriver();

        }
        
    }
}
