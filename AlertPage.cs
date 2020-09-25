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

    public class AlertPage
    {
        IWebDriver webdriver;

        #region Alert

        By AlertWithOkayBox = By.XPath("//li[@class='active']//a[@class='analystic']");
        By DisplayAnAlertButton = By.XPath("//button[@class='btn btn-danger']");
        By AlertWithOkayAndCancel = By.XPath("//div[@class='container center']//li[2]//a[1]");
        By DisplayConfirmButton = By.XPath("//button[@class='btn btn-primary']");
        By AlertWithTextBox = By.XPath("//div[@class='container center']//li[3]//a[1]");
        By DisplayThePromptBox = By.XPath("//button[@class='btn btn-info']");

        public AlertPage(IWebDriver driver)
        {
            this.webdriver = driver;
        }

        public void AlertWithOkayChoose()
        {
            webdriver.FindElement(AlertWithOkayBox).Click();
        }
        public void DisplayAlertButtonClick()
        {
            webdriver.FindElement(DisplayAnAlertButton).Click();
        }
        public void AlertWithOkayAndCancelChoose()
        {
            webdriver.FindElement(AlertWithOkayAndCancel).Click();
        }
        public void DisplayConfirmButtonClick()
        {
            webdriver.FindElement(DisplayConfirmButton).Click();
        }
        public void AlertWithTextBoxChoose()
        {
            webdriver.FindElement(AlertWithTextBox).Click();
        }
        public void DisplayThePromptBoxClick()
        {
            webdriver.FindElement(DisplayThePromptBox).Click();
        }

        #endregion
    }
}




