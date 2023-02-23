using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumVScode.Pages;
using static SeleniumVScode.Support.Data;

namespace SeleniumVScode.Tests
{
    public class BaseTest
    {
        protected IWebDriver driver;
        protected LandingPage landingPage;
        protected LoginPage loginPage;
        protected AppointmentPage appointmentPage;
        protected ConfirmationPage confirmationPage;

        private string baseUrl = "https://katalon-demo-cura.herokuapp.com/";

        protected string GetCurrentUrl()
        {
            return driver.Url;
        }

        protected string GetPageTitle()
        {
            return driver.Title;
        }

        protected void SetUp()
        {
            this.driver = new ChromeDriver();
            this.landingPage = new LandingPage(driver);
            this.loginPage = new LoginPage(driver);
            this.appointmentPage = new AppointmentPage(driver);
            this.confirmationPage = new ConfirmationPage(driver);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(this.baseUrl);

        }

        protected void Login()
        {
            landingPage.NavigateToLoginPage();
            loginPage.DoLogin(username, password);
        }

        protected void TearDown()
        {
            driver.Quit();
        }
    }
}
