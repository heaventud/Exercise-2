using System;
using AutoTests.Common;
using NUnit.Framework;

namespace AutoTests.Tests
{
    public class TestBase 
    {
        protected Browser browser;

        [OneTimeSetUp]
        public void SetUp()
        {
            browser = BrowserEnvironment.GetBrowser();
        }

        protected static Random rnd = new Random();
    }
}
