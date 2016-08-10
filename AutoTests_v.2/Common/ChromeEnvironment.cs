using System;
using System.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AddressbookWebTests
{
    public class ChromeEnvironment
    {
        private static IWebDriver driver;

        public static IWebDriver Driver()
        {
            if (driver == null)
            {
                driver = new ChromeDriver(ConfigurationManager.AppSettings["ChromeDriverPath"]);
                driver.Manage().Window.Maximize();
                //driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds());
                driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["baseUrl"]);
            }
            return driver;
        }
    }
}
