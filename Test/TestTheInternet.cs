using NUnit.Framework;
using TestProject1.Framework;
using TestProject1.Framework.Config;
using TestProject1.Framework.Utilities;
using TestProject1.Pages;

namespace SeleniumDemo.Tests
{
    [TestFixture]
    public class UnitTest2 : BaseTest
    {
        private TheInternetPage page;

        [SetUp]
        public void TestSetup()
        {
            driver.Navigate().GoToUrl(ConfigReader.TheInternetUrl);

            Logger.Info("Navigated to The Internet URL");

            page = new TheInternetPage(driver);
        }

        [Test]
        public void Test2()
        {
            Logger.Info("Executing Test2");

            //page.EnterUsername("John");
            //page.ClickLogin();

            Logger.Info("Test2 Completed");
        }
    }
}