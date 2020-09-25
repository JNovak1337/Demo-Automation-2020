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
    public class Test
    {
        public IWebDriver driver;
        [Test, Category("Registration")]

        #region Registration Steps
        public void TestingRegistration()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "http://demo.automationtesting.in/Register.html";
            RegistrationPage register = new RegistrationPage(driver);

            register.FirstName();
            register.LastName();
            register.Address();
            register.EmailBoxInput();
            register.PhoneBoxInput();
            register.GenderPickM();
            register.GenderPickF();
            register.HobbyClickOne();
            register.HobbyClickTwo();
            register.HobbyClickThree();
            register.LanguagePerformClick();
            register.LanguageSelection();
            register.SkillSelection();
            register.CountrySelection();
            register.CountrySelectClick();
            register.YearSelection();
            register.MonthSelection();
            register.DaySelection();
            register.PasswordInput();
            register.PasswordConfirmation();
            register.Submit();
            Thread.Sleep(4000);
            driver.Close();

        }
        #endregion

        [Test, Category("Registration")]

        #region Photo Upload Button Assertion
        public void VerifyButtonPhotoUpload()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "http://demo.automationtesting.in/Register.html";

            try
            {
                Assert.IsTrue(driver.FindElement(By.Id("imagesrc")).Displayed);
                Debug.Write("Upload photo button is displayed");
            }
            catch (Exception except)
            {
                Debug.Write(except);
                throw;
            }

            Thread.Sleep(4500);
            driver.Close();
        }

        #endregion

        [Test, Category("Registration")]

        #region Submit Button Assertion

        public void VerifyButtonSubmit()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "http://demo.automationtesting.in/Register.html";

            try
            {
                Assert.IsTrue(driver.FindElement(By.Id("submitbtn")).Displayed);
                Debug.Write("Submit button is displayed");
            }
            catch (Exception except)
            {
                Debug.Write(except);
                throw;
            }
            Thread.Sleep(4500);
            driver.Close();
        }

        #endregion

        [Test, Category("Registration")]

        #region Refresh Button Assertion
        public void VerifyButtonRefresh()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "http://demo.automationtesting.in/Register.html";

            try
            {
                Assert.IsTrue(driver.FindElement(By.Id("submitbtn")).Displayed);
                Debug.Write("Refresh button is displayed");
            }
            catch (Exception except)
            {
                Debug.Write(except);
                throw;
            }
            Thread.Sleep(4500);
            driver.Close();
        }
        #endregion

        [Test, Category("Registration")]

        #region Refresh Button Click Test
        public void ClickButtonRefresh()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "http://demo.automationtesting.in/Register.html";
            RegistrationPage register = new RegistrationPage(driver);
            register.RefreshButton();
            Thread.Sleep(4500);
            driver.Close();
        }
        #endregion

    }
}