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
            //IWebElement goToLastPageButton = driver.FindElement(By.XPath("//span[@class='k-icon k-i-seek-e']"));
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[4]/a[4]/span"));
            goToLastPageButton.Click();
            Thread.Sleep(4000);
        }

        //*************** Check Time Record present in the Table**********
        public void VerifyTimeRecordCreation(IWebDriver driver)
        {
            //check if the record is present in the table
            IWebElement newcode = driver.FindElement(By.XPath("//tbody/tr[last()]/td[1]"));
            if (newcode.Text == "3ES")
            {
                Assert.Pass("Time record has created succesfully");
            }
            else
            {
                Assert.Fail("Time record has not been created successfully");
            }
        }
        /*
        // **********Edit time Record Creation************
        public void EditGoToLastPage(IWebDriver driver)
        {
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[4]/a[4]/span"));
            goToLastPageButton.Click();
            Thread.Sleep(4000);
        }
        public void EditTimeLastRecord(IWebDriver driver)
        {
            //IWebElement editTimeLastRecord = driver.FindElement(By.XPath("//a[normalize-space()='Edit']"));
            IWebElement editTimeLastRecord = driver.FindElement(By.XPath("//tbody/tr[last()]/td[5]/a[1]"));
            editTimeLastRecord.Click();
        }
       
        public void EditTimeCode(IWebDriver driver)
        {
            //clear code value and update new value

            IWebElement editCode = driver.FindElement(By.Id("Code"));
            editCode.Clear();
            editCode.SendKeys("3ES80");
        }
        public void EditTimeDescriptionCode(IWebDriver driver)
        {
            //clear description value and update new value

            IWebElement editDescription = driver.FindElement(By.Id("Description"));
            editDescription.Clear();
            editDescription.SendKeys("RAJA40");
        }
       
        public void VerifyEditTimeRecordCreation(IWebDriver driver)
        {
            //check if the record is present in the table
            IWebElement EditTimecode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            if (EditTimecode.Text == "3ES80")
            {
                Assert.Pass("Edit Time record has created succesfully");
            }
            else
            {
                Assert.Fail("Edit Time record has not been created successfully");
            }
        }*/
        public void SelectMaterialTypeCode(IWebDriver driver)
        {
            IWebElement typeCodeDropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
            typeCodeDropdown.Click();
            IWebElement option = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[1]"));
            Thread.Sleep(1000);
            option.Click();
        }

        public void EnterMaterialCode(IWebDriver driver)
        {
            IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
            codeTextbox.SendKeys("MAT");
        }
        public void EnterMaterialdescription(IWebDriver driver)
        {
            IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
            descriptionTextbox.SendKeys("DES");
        }

        public void EnterMaterialPrice(IWebDriver driver)
        {
            IWebElement priceTextbox = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            priceTextbox.SendKeys("24");
            Thread.Sleep(2000);
        }
       public string GetCode(IWebDriver driver)
       {
            IWebElement newcode = driver.FindElement(By.XPath("//tbody/tr[last()]/td[1]"));
            return newcode.Text;
       }
        public string GetDescription(IWebDriver driver) 
        {
            IWebElement newDescription = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[3]"));
            return newDescription.Text;
        }
        public string GetPrice(IWebDriver driver) 
        {
            IWebElement newPrice = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[4]"));
            return newPrice.Text;
        }
        public void EditTMRecord(IWebDriver driver, string Code, string Description, string Price)
        {
            Thread.Sleep(2000);
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[4]/a[4]/span"));
            goToLastPageButton.Click();

            IWebElement editTimeLastRecord = driver.FindElement(By.XPath("//tbody/tr[last()]/td[5]/a[1]"));
            editTimeLastRecord.Click();

            IWebElement editCode = driver.FindElement(By.Id("Code"));
            editCode.Clear();
            editCode.SendKeys(Code);

            IWebElement editDescription = driver.FindElement(By.Id("Description"));
            editDescription.Clear();
            editDescription.SendKeys(Description);
            
           
           IWebElement editPriceTextboxOverlap = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
           IWebElement editPrice = driver.FindElement(By.Id("Price"));
           editPriceTextboxOverlap.Click();
           editPrice.Clear();
           editPriceTextboxOverlap.Click();
           editPrice.SendKeys(Price);
           Thread.Sleep(3000);
            

            IWebElement saveRecord = driver.FindElement(By.Id("SaveButton"));
            saveRecord.Click();
            Thread.Sleep(4000);
            Thread.Sleep(2000);
            IWebElement goToLastPage = driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[4]/a[4]/span"));
            goToLastPage.Click();

            /* //check if the Edit record is present in the table
             IWebElement editcode = driver.FindElement(By.XPath("//tbody/tr[last()]/td[1]"));
             if (editcode.Text == "EDITCODE")
             {
                 Assert.Pass("Edit last record has created succesfully");
             }
             else
             {
                 Assert.Fail("Edit last record has not been created successfully");
             }*/
        }
        public string GetEditedCode(IWebDriver driver)
        {
            IWebElement Createcode = driver.FindElement(By.XPath("//tbody/tr[last()]/td[1]"));
            return Createcode.Text;

        }
        public string GetEditedDescription(IWebDriver driver)
        {
            IWebElement CreateDescription = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[3]"));
            return CreateDescription.Text;

        }
        public string GetEditedPrice(IWebDriver driver)
        {
            IWebElement CreatePrice = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[4]"));
            return CreatePrice.Text;

        }
        public void DeletTMRecord(IWebDriver driver)
        {
            Thread.Sleep(2000);
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[4]/a[4]/span"));
            goToLastPageButton.Click();


            // click delete last record
            Thread.Sleep(3000);
            IWebElement deleteTMRecord = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            deleteTMRecord.Click();
            Thread.Sleep(3000);

            // To Click OK in altert window
            driver.SwitchTo().Alert().Accept();

            // To Click Cancel in alert window, if you dont want to delete
            //driver.SwitchTo().Alert().Dismiss();
            
            IWebElement lastRecordCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            Assert.That(lastRecordCode.Text != "EDITCODE", "Record has  been deleted");

        }
    }
}
   

