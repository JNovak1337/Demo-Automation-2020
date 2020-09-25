// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using DemoT;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace Tests
{
    [TestFixture]
    public class Test2
    {
        IWebDriver driver = new ChromeDriver();

        [SetUp]
        public void Initialize()
        {
            driver.Navigate().GoToUrl("http://demo.automationtesting.in/Alerts.html");
            driver.Manage().Window.Maximize();
        }

        [Test, Category("AlertPage")]

        public void AlertDefaultFirst()
        {
            AlertPage alertdo = new AlertPage(driver);

            alertdo.AlertWithOkayChoose();
            alertdo.DisplayAlertButtonClick();
            IAlert alert = driver.SwitchTo().Alert();
            alert.Accept();
        }

        [Test, Category("AlertPage")]

        public void AlertOkOrCancelPressOk()
        {
            AlertPage alertdo = new AlertPage(driver);

            alertdo.AlertWithOkayAndCancelChoose();
            alertdo.DisplayConfirmButtonClick();
            IAlert alert = driver.SwitchTo().Alert();
            alert.Accept();

            IWebElement AlertResponse = driver.FindElement(By.Id("demo"));
            try
            {
                Assert.IsTrue(AlertResponse.Text.Contains("You pressed Ok"));
            }
            catch
            {
                throw;
            }
        }

        [Test, Category("AlertPage")]
        public void AlertOkOrCancelPressCancel()
        {
            AlertPage alertdo = new AlertPage(driver);

            alertdo.AlertWithOkayAndCancelChoose();
            alertdo.DisplayConfirmButtonClick();
            IAlert alert = driver.SwitchTo().Alert();
            alert.Dismiss();

            IWebElement AlertResponse = driver.FindElement(By.Id("demo"));
            try
            {
                Assert.IsTrue(AlertResponse.Text.Contains("You Pressed Cancel"));
            }
            catch
            {
                throw;
            }
        }

        [Test, Category("AlertPage")]

        public void AlertWithTextBox()
        {
            AlertPage alertdo = new AlertPage(driver);

            alertdo.AlertWithTextBoxChoose();
            alertdo.DisplayThePromptBoxClick();
            IAlert alert = driver.SwitchTo().Alert();
            alert.SendKeys("Testing Alert Box");
            alert.Accept();

            IWebElement AlertResponse = driver.FindElement(By.Id("demo1"));
            try
            {
                Assert.IsTrue(AlertResponse.Text.Contains("Hello Testing Alert Box How are you today"));
            }
            catch
            {
                throw;
            }
            driver.Close();
        }

        [Test, Category("AlertPage")]
        public void VerifyAlertWithOkayButton()
        {
            try
            {
                Assert.IsTrue(driver.FindElement(By.XPath("//div[@class='container center']//li[1]//a[1]")).Displayed);
            }
            catch
            {
                throw;
            }
        }

        [Test, Category("AlertPage")]
        public void VerifyAlertWithOkayAndCancelButton()
        {
            try
            {
                Assert.IsTrue(driver.FindElement(By.XPath("//div[@class='container center']//li[2]//a[1]")).Displayed);
            }
            catch
            {
                throw;
            }
        }

        [Test, Category("AlertPage")]
        public void VerifyAlertWithTextboxButton()
        {
            try
            {
                Assert.IsTrue(driver.FindElement(By.XPath("//button[@class='btn btn-info']")).Displayed);
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