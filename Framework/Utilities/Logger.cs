using System;
using System.IO;
using NUnit.Framework;

namespace TestProject1.Framework.Utilities
{
    public static class Logger
    {
        //private static readonly string LogDirectory =
        //    Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Logs");

        //private static readonly string LogFilePath =
        //    Path.Combine(LogDirectory, "ExecutionLog:.txt");
        private static readonly string LogDirectory =
     Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Logs");

        private static string LogFilePath;

        static Logger()
        {
            if (!Directory.Exists(LogDirectory))
                Directory.CreateDirectory(LogDirectory);
        }

        public static void SetLogFile(string testName)
        {
            string safeName = testName.Replace(":", "").Replace(" ", "_");

            string timeStamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");

            LogFilePath = Path.Combine(LogDirectory, $"{safeName}_{timeStamp}.txt");
        }


        //static Logger()
        //{
        //    // Create Logs folder if it doesn't exist
        //    if (!Directory.Exists(LogDirectory))
        //    {
        //        Directory.CreateDirectory(LogDirectory);
        //    }
        //}

        public static void Info(string message)
        {
            string logMessage =
                $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} [INFO] {message}";

            Console.WriteLine(logMessage);

            File.AppendAllText(LogFilePath, logMessage + Environment.NewLine);
        }

        public static void Error(string message)
        {
            string logMessage =
                $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} [ERROR] {message}";

            Console.WriteLine(logMessage);

            File.AppendAllText(LogFilePath, logMessage + Environment.NewLine);
        }
    }
}