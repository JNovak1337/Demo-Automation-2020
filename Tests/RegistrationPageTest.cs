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
    public class Test
    {
        IWebDriver driver = new ChromeDriver();

        [SetUp]
        public void Initialize()
        {
            driver.Navigate().GoToUrl("http://demo.automationtesting.in/Register.html");
            driver.Manage().Window.Maximize();
        }

        [Test, Category("Registration")]
        public void FullRegistration()
        {
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

        [Test, Category("Registration")]
        public void VerifyButtonPhotoUpload()
        {
            try
            {
                Assert.IsTrue(driver.FindElement(By.Id("imagesrc")).Displayed);
            }
            catch
            {
                throw;
            }
        }

        [Test, Category("Registration")]

        public void VerifyButtonSubmit()
        {
            try
            {
                Assert.IsTrue(driver.FindElement(By.Id("submitbtn")).Displayed);
            }
            catch (Exception except)
            {
                Debug.Write(except);
                throw;
            }
        }

        [Test, Category("Registration")]
        public void VerifyButtonRefresh()
        {
            try
            {
                Assert.IsTrue(driver.FindElement(By.Id("submitbtn")).Displayed);
            }
            catch
            {
                throw;
            }
        }

        [Test, Category("Registration")]
        public void ClickButtonRefresh()
        {
            RegistrationPage register = new RegistrationPage(driver);
            register.RefreshButton();
            Thread.Sleep(4500);
        }

        [TearDown]
        public void CleanUp()
        {
            driver.Close();
        }
    }
}