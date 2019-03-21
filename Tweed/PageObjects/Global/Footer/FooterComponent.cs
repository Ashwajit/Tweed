using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Tweed.PageObjects.Global.Footer
{
    class FooterComponent : BasePage
    {
        public FooterComponent(IWebDriver driver) : base(driver)
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
