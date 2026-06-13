using NUnit.Framework;
using TestProject1.Framework;
using TestProject1.Framework.Config;
using TestProject1.Pages;

namespace SeleniumDemo.Tests
{
    [TestFixture]
    public class UnitTest : BaseTest
    {
        TestAutomationPage page;

        [SetUp]
        public void TestSetup()
        {
            url = ConfigReader.TestAutomationUrl;  // 👈 controlled from JSON

            page = new TestAutomationPage(driver);
        }

        [Test]
        public void Test1()
        {
            page.EnterText("Hello App1");
            page.ClickAlert();
        }
    }
}