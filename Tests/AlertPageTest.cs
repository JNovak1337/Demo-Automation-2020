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

namespace Tests
{
    [TestFixture]
    public class Test2
    {
        public IWebDriver driver;
        [Test, Category("AlertPage")]

        public void AlertDefaultFirst()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "http://demo.automationtesting.in/Alerts.html";
            AlertPage alertdo = new AlertPage(driver);

            alertdo.AlertWithOkayChoose();
            alertdo.DisplayAlertButtonClick();
            IAlert alert = driver.SwitchTo().Alert();
            alert.Accept();
            driver.Close();

        }
        [Test, Category("AlertPage")]

        public void AlertOkOrCancelPressOk()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "http://demo.automationtesting.in/Alerts.html";
            AlertPage alertdo = new AlertPage(driver);

            alertdo.AlertWithOkayAndCancelChoose();
            alertdo.DisplayConfirmButtonClick();
            IAlert alert = driver.SwitchTo().Alert();
            alert.Accept();

            IWebElement AlertResponse = driver.FindElement(By.Id("demo"));
            try
            {
                Assert.IsTrue(AlertResponse.Text.Contains("You pressed Ok"));
                Debug.Write("You pressed Ok - is Displayed");
            }
            catch (Exception except)
            {
                Debug.Write(except);
                throw;
            }
            Thread.Sleep(2500);
            driver.Close();
        }
        [Test, Category("AlertPage")]
        public void AlertOkOrCancelPressCancel()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "http://demo.automationtesting.in/Alerts.html";
            AlertPage alertdo = new AlertPage(driver);

            alertdo.AlertWithOkayAndCancelChoose();
            alertdo.DisplayConfirmButtonClick();
            IAlert alert = driver.SwitchTo().Alert();
            alert.Dismiss();

            IWebElement AlertResponse = driver.FindElement(By.Id("demo"));
            try
            {
                Assert.IsTrue(AlertResponse.Text.Contains("You Pressed Cancel"));
                Debug.Write("You Pressed Cancel - is Displayed");
            }
            catch (Exception except)
            {
                Debug.Write(except);
                throw;
            }
            Thread.Sleep(2500);
            driver.Close();
        }

        [Test, Category("AlertPage")]

        public void AlertWithTextBox()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "http://demo.automationtesting.in/Alerts.html";
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
                Debug.Write("Your custom text in Alert Box was correctly displayed.");
            }
            catch (Exception except)
            {
                Debug.Write(except);
                throw;
            }
            Thread.Sleep(2500);
            driver.Close();
        }

        [Test, Category("AlertPage")]
        public void VerifyAlertWithOkayButton()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "http://demo.automationtesting.in/Alerts.html";

            try
            {
                Assert.IsTrue(driver.FindElement(By.XPath("//div[@class='container center']//li[1]//a[1]")).Displayed);
                Debug.Write("Alert with OK - is Displayed");
            }
            catch (Exception except)
            {
                Debug.Write(except);
                throw;
            }

            Thread.Sleep(4500);
            driver.Close();
        }
        [Test, Category("AlertPage")]
        public void VerifyAlertWithOkayAndCancelButton()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "http://demo.automationtesting.in/Alerts.html";

            try
            {
                Assert.IsTrue(driver.FindElement(By.XPath("//div[@class='container center']//li[2]//a[1]")).Displayed);
                Debug.Write("Alert with OK & Cancel - is Displayed");
            }
            catch (Exception except)
            {
                Debug.Write(except);
                throw;
            }

            Thread.Sleep(4500);
            driver.Close();
        }
        [Test, Category("AlertPage")]
        public void VerifyAlertWithTextboxButton()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "http://demo.automationtesting.in/Alerts.html";

            try
            {
                Assert.IsTrue(driver.FindElement(By.XPath("//button[@class='btn btn-info']")).Displayed);
                Debug.Write("Alert with OK - is Displayed");
            }
            catch (Exception except)
            {
                Debug.Write(except);
                throw;
            }

            Thread.Sleep(4500);
            driver.Close();
        }
    }
}