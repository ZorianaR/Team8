using System;
using System.Linq;
using OpenQA.Selenium;
using Team8.Framework;

namespace Team8.PageObjects
{
    public class CartPage: Base
    {
        private static readonly By cartItem = By.ClassName("cart-item");

        public CartPage(IWebDriver Driver) : base(Driver) { }

        public bool isProdactInCart()
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.Zero;
            bool isOk = Wait.WaitFor(() => Driver.FindElements(cartItem).Any());
            Driver.Manage().Timeouts().ImplicitWait = Settings.ImplicitWait;
            return isOk;
        }

    }
}
