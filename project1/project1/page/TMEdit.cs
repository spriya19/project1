using NUnit.Framework;
using OpenQA.Selenium;
using project1.utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace project1.page
{
    public class TMEdit : CommonDriver
    {
        public static IWebElement lastRecord = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
        public static IWebElement editTimeCode = driver.FindElement(By.Id("Code"));
        public static IWebElement EditTimeDescription = driver.FindElement(By.Id("Description"));
        public static IWebElement TimepriceOverlap = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
        public static IWebElement editTimePrice = driver.FindElement(By.Id("Price"));
        public static IWebElement saveRecord = driver.FindElement(By.Id("SaveButton"));
        public static IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
        public static IWebElement editMaterialcode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
        public static IWebElement EditMaterialDescription = driver.FindElement(By.Id("Description"));
        public static IWebElement MaterialpriceOverlap = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
        public static IWebElement editMaterialPrice = driver.FindElement(By.Id("Price"));

        
        public void goTolastPage(IWebDriver driver)
        {
            goToLastPageButton.Click();
        }
        
        public void EditLastRecord(IWebDriver driver)
        {
            lastRecord.Click();
        }

        public void EnterEditTimeCode(IWebDriver driver)
        {
            editTimeCode.Clear();
            editTimeCode.SendKeys("3ESP80");
        }
        public void EnterEditTimeDescription(IWebDriver driver)
        {
            EditTimeDescription.Clear();
            EditTimeDescription.SendKeys("RAJA40");

        }
        public void EnterEditTimePrice(IWebDriver driver)
        {
            TimepriceOverlap.Click();
            editTimePrice.Clear();
            TimepriceOverlap.Click();
            editTimePrice.SendKeys("$89");
            Thread.Sleep(2000);
        }
        public void timesaveRecord(IWebDriver driver)
        {
            saveRecord.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }
        public void goToLastPage(IWebDriver driver)
        {
            Wait.WaitToBeExists(driver, "XPath", "//*[@id=\"tmsGrid\"]/div[4]/a[4]/span", 6);

            IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
            executor.ExecuteScript("arguments[0].click();", goToLastPageButton);
            Thread.Sleep(4000);
        }
        public void VerifyEditTimeCreation(IWebDriver Driver)
        {
            if (editTimeCode.Text =="3ES80")
            {
                Assert.Pass("Time Record Edited successfully");
            }
            else
            {
                Assert.Fail("Time Record has not Edited successfully");
            }
        }
    } 
}
