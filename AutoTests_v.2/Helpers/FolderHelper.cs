using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using AutoTests.Common;

namespace AutoTests.Tests
{
    public class FolderHelper : TestBase
    {
        protected Browser browser = BrowserEnvironment.GetBrowser();

        protected ReadOnlyCollection<IWebElement> GetFolders()
        {
            return browser.FindElements(By.XPath("//div[contains(@class, 'RadTreeView')]/ul/li"));
        }

        protected IWebElement GetFolderByName(string Name)
        {
            var folders = GetFolders();
            for (var i = 0; i <= folders.Count; i++)
            {
                if (folders[i].FindElement(By.XPath(".//div/span[@class='rtIn']")).Text.Contains(Name))
                {
                    return folders[i];
                }
            }
            throw new NoSuchElementException("Column with given name doesn't exist");
        }

        protected ReadOnlyCollection<IWebElement> GetSubFolders(IWebElement folder)
        {
            var icon = folder.FindElement(By.XPath(".//div/span[2]"));
            if (icon.GetAttribute("class") == "rtPlus")
            {
                icon.Click();
            }

            var subfolders = folder.FindElements(By.XPath(".//ul[@class='rtUL']/li"));
            if (subfolders.Count == 0)
            {
                throw new Exception("No subfolders are found");
            }
            return subfolders;
        }
    }
}
