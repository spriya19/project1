using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using project1.page;
using project1.utilities;



namespace project1.test
{
    [Parallelizable]
    [TestFixture]
    public class Employees_Tests : CommonDriver
    {
        [SetUp]
        public void SetUpAction()
        {
            // Open Chrome Browser
            driver = new ChromeDriver();

            //Login page object identified and defined
            LoginPage loginpageObj = new LoginPage();
            loginpageObj.LoginSteps(driver);

            // Homepage object identified and defined
            Homepage homepageObj = new Homepage();
            homepageObj.GoToEmployeesPage(driver);
        }
        [Test, Order(1)]
        public void CreateEmployeeRecord_Test()
        {
            // Employee pageobject identified and create Employee record
            EmployeesPage EmployeePageObj = new EmployeesPage();
            EmployeePageObj.ClickCreateNew(driver);
            EmployeePageObj.EnterName(driver);
            EmployeePageObj.EnterUsername(driver);
            EmployeePageObj.EnterContact(driver);
            EmployeePageObj.EditContact(driver);
            EmployeePageObj.EnterPassword(driver);
            EmployeePageObj.ReTypePassword(driver);
            EmployeePageObj.CheckAdmin(driver);
            EmployeePageObj.vehicleName(driver);
            EmployeePageObj.SaveEmployeeRecord(driver);
            EmployeePageObj.BacktoList(driver);
            EmployeePageObj.GoToLastPage(driver);
            EmployeePageObj.VerifyEmployeeRecordCreation(driver);
        }
        [Test, Order(2)]
        public void EditLastEmployeeRecord_Test()
        {
            EmployeesPage EmployeePageObj = new EmployeesPage();
            EmployeePageObj.EditLastEmployee(driver);
            EmployeePageObj.EditEmployeeDetail(driver);
            EmployeePageObj.SaveEmployeeRecord(driver);
            EmployeePageObj.BacktoList(driver);
            EmployeePageObj.GoToLastPage(driver);
            EmployeePageObj.VerifyEditEmployeeRecordCreation(driver);
        }
        [Test, Order(3)]
        public void DeleteLastEmployeeRecord_Test()
        {
            EmployeesPage EmployeePageObj = new EmployeesPage();
            EmployeePageObj.DeletEmployeeRecord(driver);
        }
        [TearDown]
        public void closetestRun()
        {
            driver.Quit();
        }
        
    }
        
}

