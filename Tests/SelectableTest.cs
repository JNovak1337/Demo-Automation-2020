// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using DemoT;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace DemoT
{
    [TestFixture]
    public class SelectableTest
    {
        IWebDriver driver = new ChromeDriver();

        [SetUp]
        public void Initialize()
        {
            driver.Navigate().GoToUrl("http://demo.automationtesting.in/Selectable.html");
            driver.Manage().Window.Maximize();
        }

        [Test, Category("Selectable Serialize")]

        public void VerifyReadability()
        {         
            SelectablePage selectable = new SelectablePage(driver);
            selectable.SerializeChooseClick();
            selectable.ReadabilityClick();
            IWebElement AlertResponse = driver.FindElement(By.Id("feedback"));
            try
            {
                Assert.IsTrue(AlertResponse.Text.Contains("You've selected: Readability"));
            }
            catch
            {
                throw;
            }
        }

        [Test, Category("Selectable Serialize")]
        public void VerifySingleLineCoding()
        {
            SelectablePage selectable = new SelectablePage(driver);

            selectable.SerializeChooseClick();
            selectable.SingleLineCodingClick();

            IWebElement AlertResponse = driver.FindElement(By.Id("feedback"));
            try
            {
                Assert.IsTrue(AlertResponse.Text.Contains("You've selected: Single Line Coding"));
            }
            catch
            {
                throw;
            }
        }

        [Test, Category("Selectable Serialize")]
        public void VerifyMethodChaining()
        {
            SelectablePage selectable = new SelectablePage(driver);

            selectable.SerializeChooseClick();
            selectable.MethodChainingClick();

            IWebElement AlertResponse = driver.FindElement(By.Id("feedback"));
            try
            {
                Assert.IsTrue(AlertResponse.Text.Contains("You've selected: Method Chaining"));
            }
            catch
            {
                throw;
            }
        }

        [Test, Category("Selectable Serialize")]
        public void VerifyCrossBrowserTesting()
        {
            SelectablePage selectable = new SelectablePage(driver);
            selectable.SerializeChooseClick();
            selectable.CrossBrowserTestingClick();
            IWebElement AlertResponse = driver.FindElement(By.Id("feedback"));
            try
            {
                Assert.IsTrue(AlertResponse.Text.Contains("You've selected: Cross Browser Testing"));
            }
            catch
            {
                throw;
            }
        }

        [Test, Category("Selectable Serialize")]
        public void VerifyExtentReports()
        {
            SelectablePage selectable = new SelectablePage(driver);
            selectable.SerializeChooseClick();
            selectable.ExtentReportsClick();

            IWebElement AlertResponse = driver.FindElement(By.Id("feedback"));
            try
            {
                Assert.IsTrue(AlertResponse.Text.Contains("You've selected: Extent Reports"));
            }
            catch
            {
                throw;
            }
        }

        [Test, Category("Selectable Serialize")]
        public void VerifyDataDrivenTesting()
        {
            SelectablePage selectable = new SelectablePage(driver);

            selectable.SerializeChooseClick();
            selectable.DataDrivenTestingClick();

            IWebElement AlertResponse = driver.FindElement(By.Id("feedback"));
            try
            {
                Assert.IsTrue(AlertResponse.Text.Contains("You've selected: Data Driven Testing"));
            }
            catch
            {
                throw;
            }
        }

        [Test, Category("Selectable Serialize")]
        public void VerifyFunctionalTesting()
        {
            SelectablePage selectable = new SelectablePage(driver);
            selectable.SerializeChooseClick();
            selectable.FunctionalTestingClick();

            IWebElement AlertResponse = driver.FindElement(By.Id("feedback"));
            try
            {
                Assert.IsTrue(AlertResponse.Text.Contains("You've selected: Functional Testing"));
            }
            catch
            {
                throw;
            }
        }

        [TearDown]
        public void CleanUp()
        {
            driver.Close();
        }
    }
}