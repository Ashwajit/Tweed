using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using Tweed.PageObjects.Pages;

namespace Tweed.PageObjects.Global.Footer
{
    class FooterComponent : BasePage
    {
        public FooterComponent(IWebDriver driver) : base(driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "link-contact")]
        public IWebElement ContactUsLink { get; set; }

        [FindsBy(How = How.Id, Using = "link-ask")]
        public IWebElement HelpSupportLink { get; set; }

        public void ClickContactUsLink()
        {
            ContactUsLink.Click();
        }

        public void ClickHelpSupportLink()
        {
            HelpSupportLink.Click();
        }

        public IWebElement ConctactUsChild()
        {
            IWebElement child = ContactUsLink.FindElement(By.ClassName("site-footer__link"));
            return child;
        }

    }
}
