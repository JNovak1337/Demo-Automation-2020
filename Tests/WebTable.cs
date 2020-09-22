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

namespace DemoT
{
    [TestFixture]
    public class WebTable
    {
        public IWebDriver driver;
        [Test, Category("WebTable")]
        public void WebTableClicks()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "http://demo.automationtesting.in/WebTable.html";

            BasePage WebTable = new BasePage(driver);

            #region WebTable Steps

            WebTable.EditInfo();
            WebTable.EditChange();
            WebTable.DeleteButton();


            #endregion

            driver.Quit();

        }
    }
}