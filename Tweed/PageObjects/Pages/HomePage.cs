using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Tweed.PageObjects.Pages
{
    class Home : BasePage
    {
        public Home(IWebDriver driver) : base(driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "h1")]
        public IWebElement PageHeader { get; set; }           

        public string GetPageHeaderText()
        {
            return PageHeader.GetAttribute("innerText");
        }
    }
}

