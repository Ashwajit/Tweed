using NUnit.Framework;
using Tweed.PageObjects.Global.Nav;
using Tweed.PageObjects.Pages;

namespace Tweed.Tests.EndToEnd
{
    [TestFixture]
    [Parallelizable]
    public class VerifyInvestmentsHomePageTest : BaseTest
    {
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
