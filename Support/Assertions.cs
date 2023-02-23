using NUnit.Framework;
using OpenQA.Selenium;

namespace SeleniumVScode.Support
{
    public class Assertions
    {
        public static void AssertElementVisibility(IWebElement element)
        {
            Assert.IsTrue(element.Displayed);
        }

        public static void AssertPageUrl(IWebDriver driver, string path)
        {
            Assert.IsTrue(driver.Url.Contains(path));
        }

        public static void AssertElementText(IWebElement element, string text)
        {
            Assert.IsTrue(element.Text.Contains(text));
        }
    }
}
