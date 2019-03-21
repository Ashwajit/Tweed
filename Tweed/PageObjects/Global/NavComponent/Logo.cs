using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Tweed.PageObjects.Global.NavComponent
{
    class Logo : BasePage
    {        
        public Logo(IWebDriver driver) : base(driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "global-nav")]
        public IWebElement GlobalNav { get; set;  }

        [FindsBy(How = How.ClassName, Using = "navbar-brand")]
        public IWebElement VirginLogoContainer { get; set; }

        [FindsBy(How = How.ClassName, Using = "signin-icon")]
        public IWebElement SignInIcon { get; set; }

        [FindsBy(How = How.ClassName, Using = "signin-text")]
        public IWebElement SignInText { get; set; }

        public string GetVirginLogoHref()
        {
            return VirginLogoContainer.GetAttribute("pathname");
        }

        public void ClickVirginLogo()
        {
            VirginLogoContainer.Click();
        }
    }
}
