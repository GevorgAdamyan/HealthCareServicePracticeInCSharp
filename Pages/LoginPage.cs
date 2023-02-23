using OpenQA.Selenium;

namespace SeleniumVScode.Pages
{
    public class LoginPage : BasePage
    {
        private By usernameField = By.Id("txt-username");
        private By passwordField = By.Id("txt-password");
        private By loginBtn = By.Id("btn-login");

        public string pagePath = "/profile.php#login";

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void DoLogin(string username, string password)
        {
            this.TypeText(this.usernameField, username, false);
            this.TypeText(this.passwordField, password, false);
            this.ClickOnElement(this.loginBtn);
        }
    }
}
