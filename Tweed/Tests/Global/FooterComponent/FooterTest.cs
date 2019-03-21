using NUnit.Framework;
using Tweed.PageObjects.Global.FooterComponent;

namespace Tweed.Tests.Global.FooterComponent
{
    //[TestFixture]
    public class FooterTest : BaseTest
    {
        [Test(Description = "Check that clicking the Contact Us link loads the Home page")]
        public void ClickContactUsLinkLoadsContactUsPage()
        {            
            Footer footer = new Footer(driver);
            footer.ClickContactUsLink();
            
        }
    }
}
