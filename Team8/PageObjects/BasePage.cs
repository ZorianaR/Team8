using OpenQA.Selenium;


namespace Team8.PageObjects
{
    public abstract class Base
    {
        protected readonly IWebDriver Driver;
        protected Base(IWebDriver driver) => Driver = driver;

    }
}
