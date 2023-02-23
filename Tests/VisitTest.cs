using NUnit.Framework;
using static SeleniumVScode.Support.Assertions;

namespace SeleniumVScode.Tests
{
    [TestFixture]
    public class VisitTest : BaseTest
    {
        [OneTimeSetUp]
        public void BeforeAll()
        {
            this.SetUp();
        }

        [OneTimeTearDown]
        public void AfterAll()
        {
            this.TearDown();
        }

        [Test]
        public void ShouldVisitTheLandingPage()
        {
            AssertElementVisibility(landingPage.GetAppointmentBtn());
        }

        [Test]
        public void ShouldLogin()
        {
            landingPage.NavigateToLoginPage();
            AssertPageUrl(this.driver, loginPage.pagePath);
            loginPage.DoLogin("John Doe", "ThisIsNotAPassword");
            AssertPageUrl(this.driver, appointmentPage.pagePath);
            AssertElementVisibility(appointmentPage.GetAppointmentForm());
        }
    }
}
