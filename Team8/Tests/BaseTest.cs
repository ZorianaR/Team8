using NUnit.Framework;
using OpenQA.Selenium;
using Team8.Framework;

namespace Team8.Tests
{

    public abstract class BaseTest
    {
        protected readonly IWebDriver Driver;
        protected BaseTest()
        {
            Driver = Selenium.GetDriver(Settings.Driver);
            Driver.Navigate().GoToUrl(Settings.url);
        }

        [OneTimeTearDown]
        public void OneTimeTearDown() => Driver.Quit();

    }
}
