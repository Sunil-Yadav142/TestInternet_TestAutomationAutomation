using NUnit.Framework;
using OpenQA.Selenium;
using TestProject1.Framework.Driver;
using TestProject1.Framework.Utilities;
using System;

namespace TestProject1.Framework
{
    public class BaseTest
    {
        protected IWebDriver driver;
        private DriverManager driverManager;

        [SetUp]
        public void Setup()
        {
            // 1. Get test name or description
            var method = TestContext.CurrentContext.Test.MethodName;

            var description = TestContext.CurrentContext.Test.Properties.Get("Description")?.ToString();

            string testName = description ?? method;

            // 2. Set logger FIRST (IMPORTANT FIX)
            Logger.SetLogFile(testName);
            Logger.Info("Test Started");

            // 3. Initialize driver
            driverManager = new DriverManager();
            driverManager.InitializeDriver();

            driver = driverManager.Driver;
        }

        [TearDown]
        public void TearDown()
        {
            Logger.Info("Test Finished");
            driverManager?.QuitDriver();
        }
    }
}

//==============================BELOW CODE WAS GIVING ERROR WHILE CHANGING LOG FILE NAME SO INTROUDECED ABOVE CHANGES AND METHOD IN LOGGER.CS FILE from line no 14 to 35=================================

//using NUnit.Framework;
 //using OpenQA.Selenium;
 //using TestProject1.Framework.Driver;
 //using TestProject1.Framework.Utilities;
 //using System.Reflection;

//namespace TestProject1.Framework
//{
//    public class BaseTest
//    {
//        protected IWebDriver driver;
//        private DriverManager driverManager;

//        [SetUp]
//        public void Setup()
//        {
//            Logger.Info("Test Started");

//            driverManager = new DriverManager();
//            driverManager.InitializeDriver();

//            driver = driverManager.Driver;
//        }

//        [TearDown]
//        public void TearDown()
//        {
//            driverManager.QuitDriver();

//            Logger.Info("Test Finished");
//        }

//        [SetUp]
//        public void Setup()
//        {
//            var method = TestContext.CurrentContext.Test.MethodName;

//            var description = TestContext.CurrentContext.Test.Properties.Get("Description")?.ToString();

//            string testName = description ?? method;

//            Logger.SetLogFile(testName);

//            Logger.Info("Test Started");
//        }
//    }
//}