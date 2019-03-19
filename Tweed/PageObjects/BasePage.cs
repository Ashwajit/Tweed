using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;

namespace Tweed.PageObjects
{
    class BasePage
    {
        private readonly IWebDriver driver;
        private readonly WebDriverWait wait;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver,
               System.TimeSpan.FromSeconds(15));
        }
    }
}
