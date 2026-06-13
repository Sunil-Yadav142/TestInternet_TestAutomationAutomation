using NUnit.Framework;
using TestProject1.Framework;
using TestProject1.Framework.Config;
using TestProject1.Pages;

namespace SeleniumDemo.Tests
{
    [TestFixture]
    public class UnitTest2 : BaseTest
    {
        TheInternetPage page;

        [SetUp]
        public void TestSetup()
        {
            url = ConfigReader.TheInternetUrl;

            page = new TheInternetPage(driver);
        }

        [Test]
        public void Test2()
        {
            page.EnterUsername("John");
            page.ClickLogin();
        }
    }
}