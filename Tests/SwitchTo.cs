// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using DemoT;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace YahooAutomate
{
    [TestFixture]
    public class Test2
    {
        public IWebDriver driver;
        [TestFixtureSetUp]
        public void SwitchToClicks()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "http://demo.automationtesting.in/Register.html";

        }
    }
}