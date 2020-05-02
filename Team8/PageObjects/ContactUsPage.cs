using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Team8.Framework;

namespace Team8.PageObjects
{
    public class ContactUsPage:Base
    {

        private static readonly By topic = By.XPath("//*[@id='content']/section/form/section/div[2]/div/select");
        private static readonly By email = By.XPath("//*[@id='content']/section/form/section/div[3]/div/input");
        private static readonly By message = By.XPath("//*[@id='content']/section/form/section/div[5]/div/textarea");
        private static readonly By send = By.XPath("//*[@id='content']/section/form/footer/input[3]");
        private static readonly By isWorkdiv = By.ClassName("alert-success");

        public ContactUsPage(IWebDriver Driver) : base(Driver) { }

        public ContactUsPage ChooseCustomService()
        {
            IWebElement selectElem = Driver.FindElement(topic);
            SelectElement select = new SelectElement(selectElem);
            select.SelectByValue("2");
            return this;
        }

        public ContactUsPage PutEmail(string _email)
        {
            Driver.FindElement(email).Click();
            Driver.FindElement(email).Clear();
            Driver.FindElement(email).SendKeys(_email);
            return this;
        }

        public ContactUsPage PutMessage(string _message)
        {
            Driver.FindElement(message).Click();
            Driver.FindElement(message).Clear();
            Driver.FindElement(message).SendKeys(_message);
            return this;
        }

        public ContactUsPage ClickOnSend()
        {
            Driver.FindElement(send).Click();
            return this;
        }

        public bool IsWork()
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.Zero;
            bool isOk = Wait.WaitFor(() => Driver.FindElements(isWorkdiv).Any());
            Driver.Manage().Timeouts().ImplicitWait = Settings.ImplicitWait;
            return isOk;
        }

    }
}
