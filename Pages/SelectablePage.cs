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

    public class SelectablePage
    {
        IWebDriver webdriver;

        By SerializeChoose = By.XPath("//div[@class='container center']//li[2]//a[1]");
        By ReadabilityBox = By.XPath("//div[@id='Serialize']//li[1]");
        By SingleLineCoding = By.XPath("//div[@id='Serialize']//li[2]");
        By MethodChaining = By.XPath("//div[@id='Serialize']//li[3]");
        By CrossBrowserTesting = By.XPath("//div[@id='Serialize']//li[4]");
        By ExtentReports = By.XPath("//div[@id='Serialize']//li[5]");
        By DataDrivenTesting = By.XPath("//div[@id='Serialize']//li[6]");
        By FunctionalTesting = By.XPath("//div[@id='Serialize']//li[7]");

        public SelectablePage(IWebDriver driver)
        {
            this.webdriver = driver;
        }
        public void SerializeChooseClick()
        {
            webdriver.FindElement(SerializeChoose).Click();
        }
        public void ReadabilityClick()
        {
            webdriver.FindElement(ReadabilityBox).Click();
        }
        public void SingleLineCodingClick()
        {
            webdriver.FindElement(SingleLineCoding).Click();
        }
        public void MethodChainingClick()
        {
            webdriver.FindElement(MethodChaining).Click();
        }
        public void CrossBrowserTestingClick()
        {
            webdriver.FindElement(CrossBrowserTesting).Click();
        }
        public void ExtentReportsClick()
        {
            webdriver.FindElement(ExtentReports).Click();
        }
        public void DataDrivenTestingClick()
        {
            webdriver.FindElement(DataDrivenTesting).Click();
        }
        public void FunctionalTestingClick()
        {
            webdriver.FindElement(FunctionalTesting).Click();
        }
    }
}




