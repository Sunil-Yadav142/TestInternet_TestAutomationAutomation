using Microsoft.Extensions.Configuration;
using System.IO;

namespace TestProject1.Framework.Config
{
    public static class ConfigReader
    {
        private static IConfiguration config;

        static ConfigReader()
        {
            config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
        }

        public static string TestAutomationUrl =>
            config["TestAutomationPracticeUrl"];

        public static string TheInternetUrl =>
            config["TheInternetUrl"];
    }
}