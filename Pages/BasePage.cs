using System;
using System.Linq;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace SeleniumVScode.Pages
{
    public abstract class BasePage
    {
        protected IWebDriver driver;

        protected WebDriverWait wait;

        protected void WaitForElementVisibility(By by)
        {
            this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(ExpectedConditions.ElementIsVisible(by));
        }

        protected IWebElement GetWebElement(By by)
        {
            this.WaitForElementVisibility(by);
            return driver.FindElement(by);
        }

        protected List<IWebElement> GetWebElements(By by) {
            return driver.FindElements(by).ToList();
        }

        protected void ClickOnElement(By by)
        {
            this.GetWebElement(by).Click();
        }

        protected void TypeText(By by, string text, bool hasValue)
        {
            IWebElement inputField = this.GetWebElement(by);
            if (hasValue)
            {
                inputField.Click();
                inputField.Clear();
                inputField.SendKeys(text);
            }
            else
            {
                inputField.Click();
                inputField.SendKeys(text);
            }
        }
    }
}
