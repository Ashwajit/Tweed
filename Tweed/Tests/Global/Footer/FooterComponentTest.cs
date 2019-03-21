using NUnit.Framework;
using Tweed.PageObjects.Global.Footer;
using Tweed.PageObjects.Pages;

namespace Tweed.Tests.Global.Footer
{
    [TestFixture]
    [Parallelizable]
    public class FooterComponentTest : BaseTest
    {
        [Test(Description = "Check that clicking the Contact Us link loads the Contact Us page")]
        public void ClickContactUsLinkLoadsContactUsPage()
        {            
            FooterComponent footer = new FooterComponent(driver);
            footer.ClickContactUsLink();

            ContactUsPage contactUsPage = new ContactUsPage(driver);
            Assert.AreEqual(contactUsPage.GetPageHeaderText(), "Contact us");
        }
    }
}
