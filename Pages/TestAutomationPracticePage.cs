using NUnit.Framework;
using OpenQA.Selenium;
using TestProject1.Framework;
using TestProject1.Framework.Config;

namespace TestProject1.Pages
{
    public class TestAutomationPage
    {
        private IWebDriver driver;

        public TestAutomationPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        // Locators (ONLY ONCE HERE)
        private By searchBox = By.Name("q");
        private By alertButton = By.Id("alertBtn");

        // Actions
        public void EnterText(string text)
        {
            driver.FindElement(searchBox).SendKeys(text);
        }

        public void ClickAlert()
        {
            driver.FindElement(alertButton).Click();
        }
    }
}