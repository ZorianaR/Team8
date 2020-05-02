using NUnit.Framework;
using Team8.PageObjects;

namespace Team8.Tests
{
    [TestFixture]
    public class CheckingAddAddressAbility:BaseTest
    {
        private MainPage main;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            main = new MainPage(Driver);
        }

        [Test]
        public void TestForm()
        {
            bool isAddressAdd = main.ClickOnAddress()
                .EnterToAccount("test@dom.com", "252525")
                .ClickOnCreateNewAddress()
                .SendData("Abc", "Def", "12345").isAddressAdded();
            Assert.That(isAddressAdd, "Address not add");

        }
    }
}
