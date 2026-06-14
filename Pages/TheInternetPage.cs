using NUnit.Framework;
using OpenQA.Selenium;
using TestProject1.Framework;
using TestProject1.Framework.Config;
using TestProject1.Framework.Utilities;

namespace TestProject1.Pages
{
    public class TheInternetPage
    {
        private IWebDriver driver;

        public TheInternetPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        // Locators (ONLY ONCE HERE)
        private By loginButton = By.CssSelector("button");
        private By username = By.Id("username");

        // Actions
        public void ClickLogin()
        {
            Logger.Info("Clicking Login button");
            driver.FindElement(loginButton).Click();
        }

        public void EnterUsername(string name)
        {
            Logger.Info($"Entering username : {name}");
            driver.FindElement(username).SendKeys(name);
        }
    }
}