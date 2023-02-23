using OpenQA.Selenium;

namespace SeleniumVScode.Pages
{
    public class LandingPage : BasePage
    {
        By menuBtn = By.Id("menu-toggle");
        By loginBtn = By.CssSelector("a[href=\"profile.php#login\"]");
        By makeAnAppointmnetBtn = By.Id("btn-make-appointment");

        public LandingPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement GetAppointmentBtn()
        {
           return this.GetWebElement(this.makeAnAppointmnetBtn);
        }
        private void OpenMenu()
        {
            this.ClickOnElement(this.menuBtn);
        }

        public void NavigateToLoginPage()
        {
            this.OpenMenu();
            this.ClickOnElement(this.loginBtn);
        }
    }
}
