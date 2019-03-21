using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Tweed.PageObjects.Global.Nav
{
    class InvestmentsComponent : BasePage
    {
        public InvestmentsComponent(IWebDriver driver) : base(driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "navbarDropdownInvestments")]
        public IWebElement InvestmentsLink { get; set; }

        public void ClickInvestmentsLink()
        {
            InvestmentsLink.Click();

        }
    }
}
