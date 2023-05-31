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

        }

        [Then(@"Time and Material Record has Created Successfully")]
        public void ThenTimeAndMaterialRecordHasCreatedSuccessfully()
        {
            TMPage TimePageObj = new TMPage();
            TimePageObj.GoToLastPage(driver);
            TimePageObj.VerifyTimeRecordCreation(driver);
        }
    }
}
