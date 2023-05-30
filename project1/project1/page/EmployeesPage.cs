﻿using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using project1.utilities;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace project1.page
{
    public class EmployeesPage : CommonDriver
    {
        public void ClickCreateNew(IWebDriver driver)
        {
            IWebElement createnewButton = driver.FindElement(By.XPath("//a[normalize-space()='Create']"));
            createnewButton.Click();
        }
        public void EnterName(IWebDriver driver)
        {
            // Enter Employee name
            IWebElement EnterName = driver.FindElement(By.Id("Name"));
            EnterName.SendKeys("Project");
            Thread.Sleep(1000);
        }
        public void EnterUsername(IWebDriver driver)
        {
            // Enter username
            IWebElement EnterUsername = driver.FindElement(By.Id("Username"));
            EnterUsername.SendKeys("Jet");
            Thread.Sleep(1000);
        }
        public void EnterContact(IWebDriver driver)
        {
            //Enter contact
            IWebElement EnterContact = driver.FindElement(By.Id("ContactDisplay"));
            EnterContact.SendKeys("0123456");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

        }

        public void EditContact(IWebDriver driver)
        {
            // Edit Contacts detail
            IWebElement editContact = driver.FindElement(By.Id("EditContactButton"));
            editContact.Click();
            //driver.SwitchTo().Frame("EditContact"); 
            //Thread.Sleep(2000);

            new WebDriverWait(driver, TimeSpan.FromSeconds(20)).Until(ExpectedConditions.FrameToBeAvailableAndSwitchToIt(By.CssSelector("iframe[title='Edit Contact']")));

            IWebElement firstnameameTextbox = driver.FindElement(By.Id("FirstName"));
            //firstnameameTextbox.Click();
            firstnameameTextbox.SendKeys("Test");

            IWebElement lastnameTextbox = driver.FindElement(By.Id("LastName"));
            lastnameTextbox.SendKeys("Project");

            IWebElement preferednameTextbox = driver.FindElement(By.Id("PreferedName"));
            preferednameTextbox.SendKeys("Jet");

            IWebElement phoneTextbox = driver.FindElement(By.Id("Phone"));
            phoneTextbox.SendKeys("0123456");

            Thread.Sleep(2000);
            IWebElement saveButton = driver.FindElement(By.Id("submitButton"));
            saveButton.Click();
        }
        public void EnterPassword(IWebDriver driver)
        {
            driver.SwitchTo().DefaultContent();
            // Enter Password
            IWebElement EnterPassword = driver.FindElement(By.Id("Password"));
            EnterPassword.SendKeys("Qwerty@1234");
            Thread.Sleep(1000);
        }
        public void ReTypePassword(IWebDriver driver)
        {
            //Re Enter Password
            IWebElement RetypePassword = driver.FindElement(By.Id("RetypePassword"));
            RetypePassword.SendKeys("Qwerty@1234");
            Thread.Sleep(1000);
        }
        public void CheckAdmin(IWebDriver driver)
        {
            // Click admin checkbox
            IWebElement CheckAdmin = driver.FindElement(By.Id("IsAdmin"));
            CheckAdmin.Click();
            Thread.Sleep(1000);
        }
        public void vehicleName(IWebDriver driver)
        {
            // Enter vehicle detail
            IWebElement VehicleName = driver.FindElement(By.Name("VehicleId_input"));
            VehicleName.SendKeys("TESLA");
            Thread.Sleep(1000);
        }
        /* public void SelectGroup(IWebDriver driver)
         {
             IWebElement groupTextbox = driver.FindElement(By.XPath("//div[@class='k-multiselect-wrap k-floatwrap']"));
             groupTextbox.Click();
         }*/
        public void SaveEmployeeRecord(IWebDriver driver)
        {
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Console.WriteLine("Employee Record has been Created successfully");
        }
        public void BacktoList(IWebDriver driver)
        {
            IWebElement backtoList = driver.FindElement(By.XPath("//a[normalize-space()='Back to List']"));
            backtoList.Click();
            Thread.Sleep(2000);
        }
        public void GoToLastPage(IWebDriver driver)
        {
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span"));
            goToLastPageButton.Click();
            Thread.Sleep(4000);
        }
        //*************** Check Employee Record present in the Table**********
        public void VerifyEmployeeRecordCreation(IWebDriver driver)
        {
            //check if the record is present in the table
            IWebElement name = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            if (name.Text == "Project")
            {
                Assert.Pass("Employee record has created succesfully");
            }
            else
            {
                Assert.Fail("Employee record has not been created successfully");
            }
        }
        public void EditLastEmployee(IWebDriver driver)
        {
            // Navigate to Last Page
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span"));
            goToLastPageButton.Click();
            Thread.Sleep(4000);

             IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[3]/a[1]"));
             editButton.Click();
             Thread.Sleep(3000);
           
        }
        public void EditEmployeeDetail(IWebDriver driver)
        {
            IWebElement editname = driver.FindElement(By.Id("Name"));
            editname.Clear();
            editname.SendKeys("Japan");

            IWebElement editusername = driver.FindElement(By.Id("Username"));
            editusername.Clear();
            editusername.SendKeys("Japan55");
        }
        //*************** Check Edit Employee Record present in the Table**********
        public void VerifyEditEmployeeRecordCreation(IWebDriver driver)
        {
            //check if the record is present in the table
            IWebElement editname = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            if (editname.Text == "Japan")
            {
                Assert.Pass("Employee record has created succesfully");
            }
            else
            {
                Assert.Fail("Employee record has not been created successfully");
            }
            
        }
        public void DeletEmployeeRecord(IWebDriver driver)
        {
            Thread.Sleep(2000);
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span"));
            goToLastPageButton.Click();


            // click delete last record
            Thread.Sleep(3000);
            IWebElement deletelastEmployeeRecord = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[3]/a[2]"));
            deletelastEmployeeRecord.Click();
            Thread.Sleep(3000);

            // To Click OK in altert window
            driver.SwitchTo().Alert().Accept();

            IWebElement lastEmployeeName = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            Console.WriteLine("Employee Last record has been deleted successfully");
        }
    }
}
