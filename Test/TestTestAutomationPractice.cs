using NUnit.Framework;
using OpenQA.Selenium;
using TestProject1.Framework;
using TestProject1.Framework.Config;
using TestProject1.Framework.Utilities;
using TestProject1.Pages;

namespace SeleniumDemo.Tests
{
    [TestFixture]
    public class UnitTest : BaseTest
    {
        private TestAutomationPage page;

        [SetUp]
        public void TestSetup()
        {
            driver.Navigate().GoToUrl(ConfigReader.TestAutomationUrl);

            Logger.Info("Navigated to Test Automation Practice URL");

            page = new TestAutomationPage(driver);
        }

        [Test]
        [Description("Test_001: HandleSimpleAlert")]
        [Category("TheTestAutomationProcess"),Category("Alert")]
        public void Test_001_HandleSimpleAlert()
        {
            page.PageLoad();
            page.ClickAlert();
        }

        [Test]
        [Description("Test_002: Confirmation_Alert")]
        [Category("TheTestAutomationProcess"), Category("Alert")]
        public void Test_002_Confirmation_Alert()
        {
            page.PageLoad();
            page.ClickConfirmationAlert();
        }

        [Test]
        [Description("Test_003: Prompt_Alert_Handelling")]
        [Category("TheTestAutomationProcess"), Category("Alert")]
        public void Test_003_Prompt_Alert_Handelling()
        {
            page.PageLoad();
            page.ClickOnPromptAlert();
        }

        [Test]
        [Description("Test_004: Multi_TAB_Handelling")]
        [Category("TheTestAutomationProcess"), Category("Alert")]
        public void Test_004_Multi_TAB_Handelling()
        {
            page.PageLoad();
            page.HandleMultipleTab();
            Thread.Sleep(2000);
            page.ClickAlert();
        }

        [Test]
        [Description("Test_005: Multi_TAB_Handelling_MoreThanThree")]
        [Category("TheTestAutomationProcess"), Category("Alert")]
        public void Test005_Multi_TAB_Handelling_MoreThanThree()
        {
            page.PageLoad();
            page.HandleThreeWindow();
        }
    }
}