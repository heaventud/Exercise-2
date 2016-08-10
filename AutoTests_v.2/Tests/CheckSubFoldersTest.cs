using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


namespace AutoTests.Tests
{
    [TestFixture]
    public class CheckSubFolders : FolderHelper
    {
        private const string Folder = "Kendo UI";

        [Test]
        public void CheckSubFoldersTest()
        {
            var folder = GetFolderByName(Folder);
            var subfolders = GetSubFolders(folder);

            WebDriverWait wait = new WebDriverWait(browser.Driver, TimeSpan.FromSeconds(3));

            for (var i=0; i < subfolders.Count; i++)
            {
                var location = By.XPath("//table[@id='ctl00_MainContent_messages_ctl00']/tbody/tr");
                var element = browser.FindElement(location);
                subfolders[i].Click();
                wait.Until(ExpectedConditions.StalenessOf(element));
                wait.Until(ExpectedConditions.ElementIsVisible(location));
            }
        }
    }
}
