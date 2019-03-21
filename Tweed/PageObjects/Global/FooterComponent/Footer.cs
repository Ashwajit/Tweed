using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Tweed.PageObjects.Global.FooterComponent
{
    class Footer : BasePage
    {
        public Footer(IWebDriver driver) : base(driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.ClassName, Using = "site-footer__link")]
        public IWebElement ContactUsLink { get; set; }

        public void ClickContactUsLink()
        {
            ContactUsLink.Click();
        }
    }
}
