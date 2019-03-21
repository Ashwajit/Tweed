using NUnit.Framework;
using Tweed.PageObjects.Global.Nav;
using Tweed.PageObjects.Pages;

namespace Tweed.Tests.Global.Nav
{
    [TestFixture]
    [Parallelizable]
    public class LogoComponentTest : BaseTest
    {
        [Test(Description = "Validate the company logo icon URL path")]
        public void CheckVirginLogoUrlPath()
        {
            LogoComponent logo = new LogoComponent(driver);
            Assert.AreEqual(logo.GetVirginLogoHref(), "/virgin/");
        }

        [Test(Description = "Check that clicking the Virgin logo loads the Home page")]
        public void ClickVirginLogoLoadsHomePage()
        {
            LogoComponent logo = new LogoComponent(driver);
            logo.ClickVirginLogo();

            Home homePage = new Home(driver);
            Assert.AreEqual(homePage.GetPageHeaderText(), "Welcome to Virgin Money");
        }

        [Test(Description = "Check the Investments home page title")]
        public void VerifyInvestmentsHomePageThroughNav()
        {
            OurProductsComponent ourproducts = new OurProductsComponent(driver);
            ourproducts.ClickOurProductsLink();


            InvestmentsComponent investmentscomponent = new InvestmentsComponent(driver);
            investmentscomponent.ClickInvestmentsLink();

            InvestmentsHomePage investmenthome = new InvestmentsHomePage(driver);
            investmenthome.ClickInvestmentshomeLink();

           Assert.AreEqual(investmenthome.GetPageHeaderText(), "INVESTMENTS");
        }

    }
}
