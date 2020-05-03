using NUnit.Framework;
using Team8.PageObjects;

namespace Team8.Tests
{
    [TestFixture]
    class PossibilityOfRegistrationTest : BaseTest
    {
        private MyHeader MyHeader;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            MyHeader = new MyHeader(Driver);
        }

        [TestCase(false, "", "Something", "some@thing.com", "11111")]
        [TestCase(false, "Somehow", "Something", "some@thingcom", "11111")]
        [TestCase(true, "Somehow", "Something", "some11@thing11.com", "11111")]
        public void RegistrationTest(bool isPositive, string firstName, string lastName, string email, string password)
        {
            bool isRegistrationWork = MyHeader.ClickOnSignIn()
                 .ClickOnCreateNewAccount()
                 .ChooseGender()
                 .PutFirstName(firstName)
                 .PutLastName(lastName)
                 .PutEmail(email)
                 .PutPassword(password)
                 .ClickOnAgreement()
                 .ClickOnSave()
                 .isRegistrationWork();
            Assert.That(isPositive, Is.EqualTo(isRegistrationWork),
                $"Form {(isRegistrationWork ? "was worked" : "wasn't worked")}");


        }
    }
}