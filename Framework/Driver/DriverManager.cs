using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestProject1.Framework.Driver
{
    public class DriverManager
    {
        public IWebDriver Driver { get; private set; }

        public void InitializeDriver()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
        }

        public void QuitDriver()
        {
            Driver?.Quit();
            Driver?.Dispose();
        }
    }
}