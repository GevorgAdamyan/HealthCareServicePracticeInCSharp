using OpenQA.Selenium;

namespace SeleniumVScode.Pages
{
    public class ConfirmationPage : BasePage
    {
        private By pageHeader = By.CssSelector("#summary h2");
        private By facilityField = By.Id("facility");
        private By hospitalField = By.Id("hospital_readmission");
        private By programField = By.Id("program");
        private By vistDateField = By.Id("visit_date");
        private By commentField = By.Id("comment");

        public string pagePath = "/appointment.php#summary";
        public string pageHeaderTxt = "Appointment Confirmation";

        public ConfirmationPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement GetPageHeader()
        {
            return this.GetWebElement(this.pageHeader);
        }

        public IWebElement GetFacilityField()
        {
            return this.GetWebElement(this.facilityField);
        }

        public IWebElement GetHospitalField()
        {
            return this.GetWebElement(this.hospitalField);
        }

        public IWebElement GetProgramField()
        {
            return this.GetWebElement(this.programField);
        }

        public IWebElement GetVistDateField()
        {
            return this.GetWebElement(this.vistDateField);
        }

        public IWebElement GetCommentField()
        {
            return this.GetWebElement(this.commentField);
        }

    }
}
