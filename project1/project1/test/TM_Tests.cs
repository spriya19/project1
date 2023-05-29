using Microsoft.VisualBasic;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using project1.page;
using project1.utilities;
using System.Text.Json.Serialization;
using static System.Net.Mime.MediaTypeNames;

namespace project1.test
{
    [Parallelizable]
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
        public void CreatTimeRecord_Test()
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
            TimePageObj.VerifyTimeRecordCreation(driver);
        }
        [Test, Order(2)]
        public void EditTMRecord_test()
        {
            // Timepage object identified and Edit time record
            TMPage TimePageObj = new TMPage();
            /*TimePageObj.EditGoToLastPage(driver);
            //edit last record;
            TimePageObj.EditTimeLastRecord(driver);
            TimePageObj.SelectTimeTypeCode(driver);
            
            //clear code value and update new value
            TimePageObj.EditTimeCode(driver);
            //clear discription value and update new value
            TimePageObj.EditTimeDescriptionCode(driver);
            //clear price value and update new value
            TimePageObj.EditTimePriceValue(driver);
            Thread.Sleep(1000);
            //click save button
            TimePageObj.SaveRecord(driver);
            //go to the last page and verify edit record present in the table
            TimePageObj.GoToLastPage(driver);
            Thread.Sleep(4000);
            TimePageObj.VerifyEditTimeRecordCreation(driver);
            */
            TimePageObj.EditLastRecord(driver);
        }
        [Test, Order(3)]
        public void CreateMaterialRecord_Test()
        {
            // Materialpage object identified and create material record
            TMPage MaterialPageObj = new TMPage();
            MaterialPageObj.ClickCreateNew(driver);
            MaterialPageObj.SelectMaterialTypeCode(driver);
            MaterialPageObj.EnterMaterialCode(driver);
            MaterialPageObj.EnterMaterialdescription(driver);
            MaterialPageObj.EnterMaterialPrice(driver);
            MaterialPageObj.SaveRecord(driver);
            MaterialPageObj.GoToLastPage(driver);
            MaterialPageObj.VerifyMaterialRecordCreation(driver);
        }
        [Test, Order(4)]
        public void DeleteTM_Test()
        {
            //DeleteTM Record
            TMPage TMPageObj = new TMPage();
            TMPageObj.DeletTMRecord(driver);

        }

        [TearDown]
        public void CloseTestRun()
        {
            driver.Close();
            driver.Quit();
        }
    }
}
        
