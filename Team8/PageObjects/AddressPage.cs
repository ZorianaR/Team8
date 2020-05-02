using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Team8.Framework;

namespace Team8.PageObjects
{
    public class AddressPage: Base
    {
        private static readonly By email = By.XPath("//*[@id='login-form']/section/div[1]/div[1]/input");
        private static readonly By password = By.XPath("//*[@id='login-form']/section/div[2]/div[1]/div/input");
        private static readonly By enter = By.Id("submit-login");
        private static readonly By CreateNewAddressSpan = By.PartialLinkText("Create new address");
        private static readonly By address = By.XPath("//*[@id='content']/div/div/form/section/div[6]/div[1]/input");
        private static readonly By city = By.XPath("//*[@id='content']/div/div/form/section/div[9]/div[1]/input");
        private static readonly By zip = By.XPath("//*[@id='content']/div/div/form/section/div[8]/div[1]/input");
        private static readonly By save = By.XPath("//*[@id='content']/div/div/form/footer/button");
        private static readonly By IsAddressAddArticle = By.ClassName("alert-success");

        public AddressPage(IWebDriver Driver) : base(Driver) { }

        public AddressPage EnterToAccount(string _email,string _password)
        {
            Driver.FindElement(email).Click();
            Driver.FindElement(email).Clear();
            Driver.FindElement(email).SendKeys(_email);

            Driver.FindElement(password).Click();
            Driver.FindElement(password).Clear();
            Driver.FindElement(password).SendKeys(_password);

            Driver.FindElement(enter).Click();
            return this;
        }

        public AddressPage ClickOnCreateNewAddress()
        {
            Driver.FindElement(CreateNewAddressSpan).Click();
            return this;
        }

        public AddressPage SendData(string _address,string _city, string _zip)
        {
            Driver.FindElement(address).Click();
            Driver.FindElement(address).Clear();
            Driver.FindElement(address).SendKeys(_address);

            Driver.FindElement(city).Click();
            Driver.FindElement(city).Clear();
            Driver.FindElement(city).SendKeys(_city);

            Driver.FindElement(zip).Click();
            Driver.FindElement(zip).Clear();
            Driver.FindElement(zip).SendKeys(_zip);

            Driver.FindElement(save).Click();
            return this;
        }

        public bool isAddressAdded()
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.Zero;
            bool isOk = Wait.WaitFor(() => Driver.FindElements(IsAddressAddArticle).Any());
            Driver.Manage().Timeouts().ImplicitWait = Settings.ImplicitWait;
            return isOk;
        }
    }
}
