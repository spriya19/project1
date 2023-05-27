using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using project1.utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace project1.page
{
    public class TMPage : CommonDriver
    {
        /*public static IWebElement createnewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
        public static IWebElement typeCodeDropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
        public static IWebElement option = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
        public static IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
        public static IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
        public static IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
        public static IWebElement priceTextbox = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
        public static IWebElement createnewButton4Material = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
        public static IWebElement typeCodeDropdown4Material = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
        public static IWebElement saveRecord = driver.FindElement(By.Id("SaveButton"));
        public static IWebElement createM = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[1]"));
        public static IWebElement newtimecode = driver.FindElement(By.XPath(".//td[contains(.,'3ES')]"));
        public static IWebElement newMaterialcode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
        */
        public void ClickCreateNew(IWebDriver driver)
        {
            IWebElement createnewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createnewButton.Click();
        }

        public void SelectTimeTypeCode(IWebDriver driver)
        {
            IWebElement typeCodeDropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
            typeCodeDropdown.Click();
            IWebElement option = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
            Thread.Sleep(1000);
            option.Click();
        }

        public void EnterTimeCode(IWebDriver driver)
        {
            IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
            codeTextbox.SendKeys("3ES");
        }
        public void EnterTimedescription(IWebDriver driver)
        {
            IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
            descriptionTextbox.SendKeys("RAJA");
        }

        public void EnterTimePrice(IWebDriver driver)
        {
            IWebElement priceTextbox = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            priceTextbox.SendKeys("66");
            Thread.Sleep(2000);
        }
        public void SaveRecord(IWebDriver driver)
        {
            IWebElement saveRecord = driver.FindElement(By.Id("SaveButton"));
            saveRecord.Click();
            Thread.Sleep(4000);
        }
        public void GoToLastPage(IWebDriver driver)
        {
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//span[@class='k-icon k-i-seek-e']"));
            goToLastPageButton.Click();
            Thread.Sleep(4000);
        }

        //*************** Check Time Record present in the Table**********
        public void VerifyTimeecordCreation(IWebDriver driver)
        {
            //check if the record is present in the table
            IWebElement newcode = driver.FindElement(By.XPath("//tbody/tr[5]/td[1]"));
            if (newcode.Text == "3ES")
            {
                Assert.Pass("Time record has created succesfully");
            }
            else
            {
                Assert.Fail("Time record has not been created successfully");
            }
        }

    }
}
