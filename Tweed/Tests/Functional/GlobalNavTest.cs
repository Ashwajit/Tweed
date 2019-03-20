using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Tweed.PageObjects;

namespace Tweed.Tests
{
    [TestFixture]
    public class GlobalNavTest : BaseTest
    {

        [Test(Description = "Check Global Nav contains the company logo")]
        public void GlobalNavContainsCorrectElements()
        {
            GlobalNavComponent globalNavComponent = new GlobalNavComponent(driver);

            Assert.AreEqual(1, 2);
        }


        
    }
}
