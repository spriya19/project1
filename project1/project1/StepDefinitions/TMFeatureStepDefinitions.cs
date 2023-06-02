using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using project1.page;
using project1.utilities;
using System;
using TechTalk.SpecFlow;

namespace project1.StepDefinitions
{
    [Binding]
    public class TMFeatureStepDefinitions:CommonDriver
    {
        [Given(@"I Logged in TrunupProtal Successfully")]
        public void GivenILoggedInTrunupProtalSuccessfully()
        {
            // Open Chrome Browser
            driver = new ChromeDriver();

            //Login page object identified and defined
            LoginPage loginpageObj = new LoginPage();
            loginpageObj.LoginSteps(driver);
        }

        [When(@"I Navigated to GoToTMPage")]
        public void WhenINavigatedToGoToTMPage()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            // =========navigate to time and mateial page========
            IWebElement administrationTab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            administrationTab.Click();

            Wait.WaitToBeExists(driver, "XPath", "/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a", 7);

            IWebElement tmoptionTab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            tmoptionTab.Click();

        }

        [When(@"I Create new Time and Material record")]
        public void WhenICreateNewTimeAndMaterialRecord()
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


        }

        [Then(@"Time and Material Record has Created Successfully")]
        public void ThenTimeAndMaterialRecordHasCreatedSuccessfully()
        {
            TMPage TimePageObj = new TMPage();
            string newcode = TimePageObj.GetCode(driver);
            string newDescription = TimePageObj.GetDescription(driver);
            string newPrice = TimePageObj.GetPrice(driver);

            Assert.AreEqual("3ES",newcode, "Actual code and expected code do not match");
            Assert.AreEqual("RAJA",newDescription, "Actual Description and expected code do not match");
            Assert.AreEqual("$66.00",newPrice, "Actual price and Expected price code do not match");
        }
        [When(@"I update '([^']*)', '([^']*)' and '([^']*)' an Existing Time and material record")]
        public void WhenIUpdateAndAnExistingTimeAndMaterialRecord(string Code, string Description , string Price)
        {
            TMPage TimePageObj = new TMPage();
            TimePageObj.EditTMRecord(driver, Code,Description,Price);

        }
        [Then(@"The record should be updated '([^']*)','([^']*)' and '([^']*)'")]
        public void ThenTheRecordShouldBeUpdatedAnd(string Code, string Description, string Price)
        {
                TMPage TimePageObj = new TMPage();
                string editedCode = TimePageObj.GetEditedCode(driver);
                string editedDescription = TimePageObj.GetEditedDescription(driver);
                string editedPrice = TimePageObj.GetEditedPrice(driver);

            Assert.AreEqual(Code, editedCode, "Actual EditedCode and Expected EditedCode do not Match");
            Assert.AreEqual(Description, editedDescription, "Actual EditedDescription and Expected EditedDescription do not Match");
            Assert.AreEqual(Price, editedPrice, "Actual EditedPrice and Expected EditedPrice do not Match");
        }
    }
}
