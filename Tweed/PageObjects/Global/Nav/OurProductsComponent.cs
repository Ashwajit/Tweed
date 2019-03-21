using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Tweed.PageObjects.Global.Nav
{
    class OurProductsComponent : BasePage
    {
        public OurProductsComponent(IWebDriver driver) : base(driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.ClassName, Using = "nav-section-header")]
        public IWebElement OurProductsLink { get; set; }

        public void ClickOurProductsLink()
        {
            OurProductsLink.Click();

        }

    }
}
