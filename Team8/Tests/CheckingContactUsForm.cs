using NUnit.Framework;
using Team8.PageObjects;

namespace Team8.Tests
{
    [TestFixture]
    public class CheckingContactUsForm: BaseTest
    {
        private MainPage main;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            main = new MainPage(Driver);
        }

        [TestCase(false, "testc@case","Something")]
        [TestCase(false, "testc@case.com", " ")]
        [TestCase(true, "testc@case.com", "Something")]
        public void CheckForm(bool isPositive, string email, string message)
        {
            bool isWork = main
                .ClickOnContacts()
                .ChooseCustomService()
                .PutEmail(email)
                .PutMessage(message)
                .ClickOnSend()
                .IsWork();
            Assert.That(isWork, Is.EqualTo(isPositive),
                $"Form {(isWork ? "was worked" : "wasn't worked")}");
        }
    }
}
