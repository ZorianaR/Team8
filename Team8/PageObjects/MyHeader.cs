using OpenQA.Selenium;
using Team8.Framework;
using System;
using System.Linq;


namespace Team8.PageObjects
{
    public class MyHeader : Base
    {
        private static readonly By cart = By.ClassName("header");
        private static readonly By signIn = By.XPath("//*[@id='_desktop_user_info']/div/a/span");
        private static readonly By user = By.XPath("//*[@id='_desktop_user_info']/div/a[2]/span");


        public MyHeader(IWebDriver Driver) : base(Driver) { }

        public MyAccount ClickOnSignIn()
        {
            Driver.FindElement(signIn).Click();
            return new MyAccount(Driver);
        }

        public bool isRegistrationWork()
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.Zero;
            bool isWork = Wait.WaitFor(() => Driver.FindElements(user).Any());
            Driver.Manage().Timeouts().ImplicitWait = Settings.ImplicitWait;
            return isWork;
        }

    }
}