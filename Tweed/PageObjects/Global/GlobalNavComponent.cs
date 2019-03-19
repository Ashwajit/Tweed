using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Tweed.PageObjects
{
    class GlobalNavComponent : BasePage
    {
        
        public GlobalNavComponent(IWebDriver driver) : base(driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "global-nav")]
        public IWebElement globalNav { get; set; }

        [FindsBy(How = How.ClassName, Using = "navbar-brand")]
        public IWebElement virginIconContainer { get; set; }

        [FindsBy(How = How.ClassName, Using = "signin-icon")]
        public IWebElement signInIcon { get; set; }

        [FindsBy(How = How.ClassName, Using = "signin-text")]
        public IWebElement signInText { get; set; }


    }
}
