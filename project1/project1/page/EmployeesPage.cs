using NUnit.Framework;
using OpenQA.Selenium;
using project1.utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1.page
{
    public class EmployeesPage:CommonDriver
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
        /*public void EditContact(IWebDriver driver)
        {
            // Edit Contacts detail
            IWebElement editContact = driver.FindElement(By.Id("EditContactButton"));
            editContact.Click();
            driver.SwitchTo().Frame(editContact);
            Thread.Sleep(2000);
            
            IWebElement firstnameameTextbox = driver.FindElement(By.Id("FirstName"));
            firstnameameTextbox.SendKeys("Test");
            
            IWebElement lastnameTextbox = driver.FindElement(By.Id("LastName"));
            lastnameTextbox.SendKeys("Project");
            
            IWebElement preferednameTextbox = driver.FindElement(By.Id("PreferedName"));
            preferednameTextbox.SendKeys("Jet");
            
            IWebElement phoneTextbox = driver.FindElement(By.Id("Phone"));
            phoneTextbox.SendKeys("0123456");

            IWebElement saveButton = driver.FindElement(By.Id("submitButton"));
            saveButton.Click();
        }*/
        public void EnterPassword(IWebDriver driver)
        {
            // Enter Password
            IWebElement EnterPassword = driver.FindElement(By.Id("Password"));
            EnterPassword.SendKeys("121212");
            Thread.Sleep(1000);
        }
        public void ReTypePassword(IWebDriver driver)
        {
            //Re Enter Password
            IWebElement RetypePassword = driver.FindElement(By.Id("RetypePassword"));
            RetypePassword.SendKeys("121212");
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
            Thread.Sleep(5000);                
        }
        //*************** Check Employee Record present in the Table**********
       /* public void VerifyEmployeeRecordCreation(IWebDriver driver)
        {
            //check if the record is present in the table
            IWebElement name = driver.FindElement(By.XPath("//td[normalize-space()='ss']"));
            if (name.Text == "Project")
            {
                Assert.Pass("Employee record has created succesfully");
            }
            else
            {
                Assert.Fail("Employee record has not been created successfully");
            }
        }*/
    }
}
