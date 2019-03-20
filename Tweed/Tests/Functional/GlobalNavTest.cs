using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Tweed.PageObjects;
using Tweed.PageObjects.Home;

namespace Tweed.Tests
{
    [TestFixture]
    public class GlobalNavTest : BaseTest
    {
        [Test(Description = "Validate the company logo icon URL path")]
        public void CheckVirginLogoUrlPath()
        {
            GlobalNavComponent globalNav = new GlobalNavComponent(driver);
            Assert.AreEqual(globalNav.GetVirginLogoHref(), "/virgin/");
        }

        [Test(Description = "Check that clicking the Virgin logo loads the Home page")]
        public void ClickVirginLogoLoadsHomePage()
        {
            GlobalNavComponent globalNav = new GlobalNavComponent(driver);
            globalNav.ClickVirginLogo();

            HomePage homePage = new HomePage(driver);
            Assert.AreEqual(homePage.GetPageHeaderText(), "Welcome to Virgin Money");
        }

    }
}
