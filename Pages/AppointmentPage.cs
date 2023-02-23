using System.Collections.Generic;
using OpenQA.Selenium;

namespace SeleniumVScode.Pages
{
    public class AppointmentPage : BasePage
    {
        private By pageHeader = By.CssSelector("#appointment h2");
        private By appointmentForm = By.ClassName("form-horizontal");
        private By facilityContainer = By.Id("combo_facility");
        private By options = By.CssSelector("#combo_facility > option");
        private By hospitalChkBx = By.Id("chk_hospotal_readmission");
        private By programRadio = By.CssSelector(".radio-inline > input");
        private By dateField = By.CssSelector("[data-provide=\"datepicker\"]");
        private By calendar = By.ClassName("datepicker-days");
        private By commentField = By.Id("txt_comment");
        private By bookBtn = By.Id("btn-book-appointment");

        public string pagePath = "/#appointment";
        public string pageHeaderTxt = "Make Appointment";

        public AppointmentPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement GetAppointmentForm()
        {
            return this.GetWebElement(this.appointmentForm);
        }

        public IWebElement GetPageHeader()
        {
            return this.GetWebElement(this.pageHeader);
        }

        public List<IWebElement> GetFacilityOptons()
        {
            return this.GetWebElements(this.options);
        }

        public List<IWebElement> GetProgramOptions()
        {
            return this.GetWebElements(this.programRadio);
        }

        public void SelectFacility(int index)
        {
            this.ClickOnElement(this.facilityContainer);
            var facilities = this.GetFacilityOptons();
            var facility = facilities[index];
            facility.Click();
            this.ClickOnElement(this.pageHeader);
        }

        public void SelectProgram(int index)
        {
            var programs = this.GetProgramOptions();
            var program = programs[index];
            program.Click();
        }

        public void SelectHospital(bool willBeSelected)
        {
            if (willBeSelected)
            {
                this.ClickOnElement(this.hospitalChkBx);
            }
        }

        public void SelectDate(int day)
        {
            this.ClickOnElement(this.dateField);
            this.WaitForElementVisibility(this.calendar);
            this.ClickOnElement(By.XPath($"//td[@class=\"day\"][text()=\"{day}\"]"));
        }

        public void InsertComment(string comment)
        {
            this.TypeText(this.commentField, comment, false);
        }

        public void BookAppointment()
        {
            this.ClickOnElement(this.bookBtn);
        }
    }
}
