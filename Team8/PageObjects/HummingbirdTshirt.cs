using System;
using System.Linq;
using OpenQA.Selenium;
using Team8.Framework;

namespace Team8.PageObjects
{
    public class HummingbirdTshirt: Base
    {
        public static readonly By toCart = By.XPath("//*[@id='add-to-cart-or-refresh']/div[2]/div/div[2]/button");
        public static readonly By continueShopping = By.XPath("//*[@id='blockcart-modal']/div/div/div[1]/button/span/i");
        public static readonly By myStore = By.XPath("//*[@id='_desktop_logo']/a");


        public HummingbirdTshirt(IWebDriver Driver) : base(Driver) { }

        public HummingbirdTshirt ClickOnAddToCart()
        {
            Driver.FindElement(toCart).Click();
            return this;
        }

        public HummingbirdTshirt ClickOnContinueShopping()
        {
            Driver.FindElement(continueShopping).Click();
            return this;
        }

        public Headr ClickOnMyStore()
        {
            Driver.FindElement(myStore).Click();
            return new Headr(Driver);
        }
    }
}
