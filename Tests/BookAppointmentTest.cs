using NUnit.Framework;
using static SeleniumVScode.Support.Utils;
using static SeleniumVScode.Support.Data;
using static SeleniumVScode.Support.Assertions;

namespace SeleniumVScode.Tests
{
    [TestFixture]
    public class BookAppointmentTest : BaseTest
    {

        [OneTimeSetUp]
        public void BeforeAll()
        {
            this.SetUp();
        }

        [SetUp]
        public void BeforeEach()
        {
            this.Login();
        }

        [Test]
        public void ShouldSuccessfullyBookAppointment()
        {
            bool willBeSelected = GenerateRandomBoolean();
            string comment = GenerateRandomText();
            int facilityIndex = GenerateRandomNumber(0, appointmentPage.GetFacilityOptons().Count, false);
            int programIndex = GenerateRandomNumber(0, appointmentPage.GetProgramOptions().Count, false);
            int startDay = GetCurrentDate().Day + 1;
            int day = GenerateRandomNumber(startDay, 28, true);
            appointmentPage.SelectFacility(facilityIndex);
            appointmentPage.SelectHospital(willBeSelected);
            appointmentPage.SelectProgram(programIndex);
            appointmentPage.SelectDate(day);
            appointmentPage.InsertComment(comment);
            appointmentPage.BookAppointment();
            AssertPageUrl(this.driver, confirmationPage.pagePath);
            AssertElementText(confirmationPage.GetPageHeader(), confirmationPage.pageHeaderTxt);
            AssertElementText(confirmationPage.GetFacilityField(), facilityNames[facilityIndex]);
            if (willBeSelected)
                AssertElementText(confirmationPage.GetHospitalField(), "Yes");
            else
                AssertElementText(confirmationPage.GetHospitalField(), "No");
            AssertElementText(confirmationPage.GetProgramField(), programs[programIndex]);
            AssertElementText(confirmationPage.GetVistDateField(), day.ToString());
            AssertElementText(confirmationPage.GetCommentField(), comment);
        }

        [OneTimeTearDown]
        public void AfterAll()
        {
            this.TearDown();
        }
    }
}
