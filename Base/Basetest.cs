using NUnit.Framework;
using OpenQA.Selenium;
using TestProject1.Framework.Driver;

namespace TestProject1.Framework
{
    public class BaseTest
    {
        protected IWebDriver driver;
        private DriverManager driverManager;

        protected string url;

        [SetUp]
        public void Setup()
        {
            driverManager = new DriverManager();
            driverManager.InitializeDriver();

            driver = driverManager.Driver;

            // open application dynamically
            driver.Navigate().GoToUrl(url);
        }

        [TearDown]
        public void TearDown()
        {
            driverManager.QuitDriver();
        }
    }
}