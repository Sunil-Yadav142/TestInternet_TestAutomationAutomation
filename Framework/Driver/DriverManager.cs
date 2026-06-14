using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TestProject1.Framework.Utilities;

namespace TestProject1.Framework.Driver
{
    public class DriverManager
    {
        public IWebDriver Driver { get; private set; }

        public void InitializeDriver()
        {
            Driver = new ChromeDriver();
            Logger.Info("Launching Chrome Browser");
            Driver.Manage().Window.Maximize();
        }

        public void QuitDriver()
        {
            Driver?.Quit();
            Logger.Info("Closing Browser");
            Driver?.Dispose();
        }
    }
}