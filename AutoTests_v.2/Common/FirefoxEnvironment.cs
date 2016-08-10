using System;
using System.Threading;
using Bumblebee.Setup;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.Events;

namespace AutoTests.Common
{
    /// <summary>
    /// The local firefox environment.
    /// </summary>
    public class LocalFirefoxEnvironment : ThreadLocal<IWebDriver>, IDriverEnvironment
    {
        /// <summary>
        /// The create web driver.
        /// </summary>
        /// <returns>
        /// The <see cref="IWebDriver"/>.
        /// </returns>
        public IWebDriver CreateWebDriver()
        {
            IWebDriver driver = new FirefoxDriver();
            //driver = new EventFiringDriver(driver);
            driver.Manage().Window.Maximize();
            //driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            return driver;
        }
    }
}
