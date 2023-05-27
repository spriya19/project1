using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using project1.page;
using project1.utilities;
using System.Text.Json.Serialization;

namespace project1.test
{
    [TestFixture]
    public class TM_Tests : CommonDriver
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
            homepageObj.GoToTMPage(driver);
        }
        [Test, Order(1)]
        public void CreatTime_Test()
        {
            // Timepage object identified and create time record
            TMPage TimePageObj = new TMPage();
            TimePageObj.ClickCreateNew(driver);
            TimePageObj.SelectTimeTypeCode(driver);
            TimePageObj.EnterTimeCode(driver);
            TimePageObj.EnterTimedescription(driver);
            TimePageObj.EnterTimePrice(driver);
            TimePageObj.SaveRecord(driver);
            TimePageObj.GoToLastPage(driver);
            TimePageObj.VerifyTimeecordCreation(driver);
        }
        [TearDown]
        public void CloseTestRun()
        {
            driver.Close();
            driver.Quit();
        }
    }
}
        
