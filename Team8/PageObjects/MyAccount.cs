using System;
using OpenQA.Selenium;


namespace Team8.PageObjects
{
    public class MyAccount : Base
    {
        private static readonly By createAccount = By.XPath("//*[@id='content']/div/a");

        public MyAccount(IWebDriver Driver) : base(Driver) { }

        public CreateAccountPage ClickOnCreateNewAccount()
        {
            Driver.FindElement(createAccount).Click();
            return new CreateAccountPage(Driver);
        }
    }
}