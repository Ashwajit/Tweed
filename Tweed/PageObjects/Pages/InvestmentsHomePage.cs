using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Tweed.PageObjects.Pages
{
    class InvestmentsHomePage : BasePage
    {
        public InvestmentsHomePage(IWebDriver driver) : base(driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Investments home')]")]
        public IWebElement InvestmenthomeLink { get; set; }

        [FindsBy(How = How.CssSelector, Using = "h1")]
        public IWebElement PageHeader { get; set; }

        public void ClickInvestmentshomeLink()
        {
            InvestmenthomeLink.Click();
        }

        public string GetPageHeaderText()
        {
            return PageHeader.GetAttribute("innerText");

        }

    }
}
