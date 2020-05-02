using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Team8.PageObjects
{
    public class MainPage: Base
    {

        private static readonly By addressButton = By.XPath("//*[@id='footer_account_list']/li[4]/a");

        public MainPage(IWebDriver driver) : base(driver) { }

        public AddressPage ClickOnAddress()
        {
            Driver.FindElement(addressButton).Click();
            return new AddressPage(Driver);
        }
    }
}
