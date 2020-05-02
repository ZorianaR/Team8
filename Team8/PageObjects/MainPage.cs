using OpenQA.Selenium;


namespace Team8.PageObjects
{
    public class MainPage: Base
    {

        private static readonly By addressButton = By.XPath("//*[@id='footer_account_list']/li[4]/a");
        private static readonly By contacts = By.XPath("//*[@id='link-static-page-contact-2']");

        public MainPage(IWebDriver driver) : base(driver) { }

        public AddressPage ClickOnAddress()
        {
            Driver.FindElement(addressButton).Click();
            return new AddressPage(Driver);
        }

        public ContactUsPage ClickOnContacts()
        {
            Driver.FindElement(contacts).Click();
            return new ContactUsPage(Driver);
        }

    }
}
