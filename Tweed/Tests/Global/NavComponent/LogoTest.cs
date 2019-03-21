using NUnit.Framework;
using Tweed.PageObjects.Global.NavComponent;
using Tweed.PageObjects.Home;

namespace Tweed.Tests.Global.NavComponent
{
    //[TestFixture]
    public class LogoTest : BaseTest
    {
        [Test(Description = "Validate the company logo icon URL path")]
        public void CheckVirginLogoUrlPath()
        {
            Logo logo = new Logo(driver);
            Assert.AreEqual(logo.GetVirginLogoHref(), "/virgin/");
        }

        [Test(Description = "Check that clicking the Virgin logo loads the Home page")]
        public void ClickVirginLogoLoadsHomePage()
        {
            Logo logo = new Logo(driver);
            logo.ClickVirginLogo();

            HomePage homePage = new HomePage(driver);
            Assert.AreEqual(homePage.GetPageHeaderText(), "Welcome to Virgin Money");
        }

    }
}
