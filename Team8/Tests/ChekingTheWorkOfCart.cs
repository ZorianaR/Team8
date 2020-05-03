using NUnit.Framework;
using Team8.PageObjects;

namespace Team8.Tests
{
    [TestFixture]
    class ChekingTheWorkOfCart: BaseTest
    {
        private MainPage main;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            main = new MainPage(Driver);
        }

        [Test]
        public void CheckCart()
        {
            bool isCartWork = main
                .ClickOnItem()
                .ClickOnAddToCart()
                .ClickOnContinueShopping()
                .ClickOnMyStore()
                .ClicOnCart()
                .isProdactInCart();
            Assert.That(isCartWork, "Cart don't work");
        }
    }
}
