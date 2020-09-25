using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DemoT
{

    public class RegistrationPage
    {
        IWebDriver webdriver;

        By FirstNameBox = By.XPath("//input[@placeholder='First Name']");
        By LastNameBox = By.XPath("//input[@placeholder='Last Name']");
        By AddressBox = By.XPath("//html//body//section//div//div//div//form//div//div//textarea");
        By EmailBox = By.XPath("//div[3]//div[1]//input[1]");
        By PhoneBox = By.XPath("//div[4]//div[1]//input[1]");
        By GenderPickMale = By.XPath("//label[1]//input[1]");
        By GenderPickFemale = By.XPath("//label[2]//input[1]");
        By HobbyPickOne = By.Id("checkbox1");
        By HobbyPickTwo = By.Id("checkbox2");
        By HobbyPickThree = By.Id("checkbox3");
        By LanguageClick = By.XPath("//div[@id='msdd']");
        By LanguageSelect = By.XPath("//section[@id='section']//li[5]//a[1]");
        By SkillSelect = By.XPath("//select[@id='Skills']");
        By CountrySelect = By.XPath("//select[@id='countries']");
        By CountrySelector = By.XPath("//span[@class='select2-selection select2-selection--single']");
        By YearBoxSelect = By.XPath("//select[@id='yearbox']");
        By MonthBoxSelect = By.XPath("//select[@placeholder='Month']");
        By DayBoxSelect = By.XPath("//select[@id='daybox']");
        By Password = By.XPath("//input[@id='firstpassword']");
        By PasswordConfirm = By.XPath("//input[@id='secondpassword']");
        By SubmitClick = By.XPath("//button[@id='submitbtn']");
        By RefreshButtonClick = By.XPath("/html[1]/body[1]/section[1]/div[1]/div[1]/div[2]/form[1]/div[14]/div[1]/button[2]");


        public RegistrationPage(IWebDriver driver)
        {
            this.webdriver = driver;
        }

        public void FirstName()
        {
            webdriver.FindElement(FirstNameBox).SendKeys("Jan");
        }
        public void LastName()
        {
            webdriver.FindElement(LastNameBox).SendKeys("Novak");
        }
        public void Address()
        {
            webdriver.FindElement(AddressBox).SendKeys("Adress");
        }
        public void EmailBoxInput()
        {
            webdriver.FindElement(EmailBox).SendKeys("randomail@mail.com");
        }
        public void PhoneBoxInput()
        {
            webdriver.FindElement(PhoneBox).SendKeys("+420720200300");
        }
        public void GenderPickM()
        {
            webdriver.FindElement(GenderPickMale).Click();
        }
        public void GenderPickF()
        {
            webdriver.FindElement(GenderPickFemale).Click();
        }
        public void HobbyClickOne()
        {
            webdriver.FindElement(HobbyPickOne).Click();
        }
        public void HobbyClickTwo()
        {
            webdriver.FindElement(HobbyPickTwo).Click();
        }
        public void HobbyClickThree()
        {
            webdriver.FindElement(HobbyPickThree).Click();
        }
        public void LanguagePerformClick()
        {
            webdriver.FindElement(LanguageClick).Click();
        }
        public void LanguageSelection()
        {
            webdriver.FindElement(LanguageSelect).Click();
        }
        public void SkillSelection()
        {
            webdriver.FindElement(SkillSelect).SendKeys("C");
        }
        public void CountrySelection()
        {
            webdriver.FindElement(CountrySelect).SendKeys("Cz");
        }
        public void CountrySelectClick()
        {
            webdriver.FindElement(CountrySelector).SendKeys("Jap");
        }
        public void YearSelection()
        {
            webdriver.FindElement(YearBoxSelect).SendKeys("1996");
        }
        public void MonthSelection()
        {
            webdriver.FindElement(MonthBoxSelect).SendKeys("May");
        }
        public void DaySelection()
        {
            webdriver.FindElement(DayBoxSelect).SendKeys("16");
        }
        public void PasswordInput()
        {
            webdriver.FindElement(Password).SendKeys("Heslo01");
        }
        public void PasswordConfirmation()
        {
            webdriver.FindElement(PasswordConfirm).SendKeys("Heslo01");
        }
        public void Submit()
        {
            webdriver.FindElement(SubmitClick).Click();
        }
        public void RefreshButton()
        {
            webdriver.FindElement(RefreshButtonClick).Click();
        }
    }
}




