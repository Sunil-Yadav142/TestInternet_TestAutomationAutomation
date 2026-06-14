using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.BiDi;
using OpenQA.Selenium.Support.UI;
using TestProject1.Framework;
using TestProject1.Framework.Config;
using TestProject1.Framework.Utilities;

namespace TestProject1.Pages
{
    public class TestAutomationPage
    {
        private IWebDriver driver;

    //    private IWebElement APTPageLoad =>
    //driver.FindElement(By.XPath("//h1[normalize-space(text())='Automation Testing Practice']"));

        public TestAutomationPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        // Locators (ONLY ONCE HERE)
        private By searchBox = By.Name("q");
        private By alertButton = By.Id("confirmBtn");
        private By APTPageLoad = By.XPath("//h1[normalize-space(text())='Automation Testing Practice']");
        private By ConfirmationAlertButton = By.Id("alertBtn");
        private By PromptAlertButton = By.Id("promptBtn");
        private By NewTab = By.XPath("//button[contains(text(),'New Tab')]");
        private By PopWindow = By.Id("PopUp");

        // Actions
        public void PageLoad()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(d => d.FindElement(APTPageLoad).Displayed);
            Logger.Info("Test Automation Practice Page loaded successfully");
        }
       
        public void EnterText(string text)
        {
            Logger.Info($"Entering text : {text}");
            driver.FindElement(searchBox).SendKeys(text);
        }

        public void ClickAlert()
        {
            Logger.Info("Clicking Alert button");
            driver.FindElement(alertButton).Click();
            IAlert alert = driver.SwitchTo().Alert();
            Logger.Info($"Alert text: {alert.Text}");
            Thread.Sleep(2000); // Wait for 2 seconds to see the alert
            alert.Accept();
        }
        public void ClickConfirmationAlert()
        {
            IWebElement button = driver.FindElement(ConfirmationAlertButton);
            button.Click();
            Logger.Info("Clicked Confirmation Alert button");
            IAlert alert = driver.SwitchTo().Alert();
            Logger.Info("confirmation Alert: {0}"+ alert.Text);
            Thread.Sleep(1000); // Wait for 1 second to see the alert
            alert.Dismiss();
            Logger.Info("Dismissed the confirmation alert");
            button.Click();
            Logger.Info("Clicked Confirmation Alert button again");
            alert = driver.SwitchTo().Alert();
            Thread.Sleep(1000); // Wait for 1 second to see the alert
            alert.Accept();

        }

        public void ClickOnPromptAlert()
        {
            IWebElement button = driver.FindElement(PromptAlertButton);
            button.Click();
            Logger.Info("clicked on Prompt Alert button Successfully");
            //IAlert alert = driver.SwitchTo().Alert();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IAlert alert = wait.Until(d => d.SwitchTo().Alert());
            Logger.Info("Alert Text: " + alert.Text);
            alert.SendKeys("Selenium Testing Going On");
            Thread.Sleep(2000);
            alert.Accept();

        }

        public void HandleMultipleTab()
        {
            IWebElement tab = driver.FindElement(NewTab);
            Logger.Info("Clicked on New Tab button");
            string currentHandle =  driver.CurrentWindowHandle;
            tab.Click();
            Logger.Info("New Tab opened successfully");
            var handles = driver.WindowHandles;
            foreach(var handle in handles)
            {
                if (handle != currentHandle)
                {
                    driver.SwitchTo().Window(handle);
                    Logger.Info("Switched to new tab successfully");
                    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                    wait.Until(d => d.FindElement(By.TagName("h1")).Displayed);
                    Logger.Info("New Tab loaded successfully");
                    driver.Close();
                    Logger.Info("Closed the new tab");
                    break;
                }
            }
            driver.SwitchTo().Window(currentHandle);


        }

        public void HandleThreeWindow()
        {
            IWebElement tab = driver.FindElement(NewTab);
            Logger.Info("Clicked on New Tab button");
            tab.Click();
            Logger.Info("New Tab opened successfully");
            driver.FindElement(PopWindow).Click();
            Logger.Info("Clicked on PopUp button and opended successfully");
            string currentHandle = driver.CurrentWindowHandle;
            Logger.Info("Current Window Handle: " + currentHandle);
            var allHadles = driver.WindowHandles;
            foreach (var handle in allHadles)
            {
                driver.SwitchTo().Window(handle);
                if(driver.Title.Contains("Selenium"))
                {
                    driver.Manage().Window.Maximize();
                    Thread.Sleep(2000);
                    break;
                    Logger.Info("Switched to window with handle: " + handle);
                }
                

            }
        }

    }
}