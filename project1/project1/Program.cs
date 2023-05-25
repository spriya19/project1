using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V111.IndexedDB;
using OpenQA.Selenium.Support.UI;
using project1.page;

public class Program
{
    private static void Main(string[] args)
    {
        // Open Chrome Browser
        IWebDriver driver = new ChromeDriver();
        
        //Login page object identified and defined
        LoginPage loginpageObj = new LoginPage();
        loginpageObj.LoginSteps(driver);

        // Homepage object identified and defined
        Homepage homepageObj = new Homepage();
        homepageObj.GoToTMPage(driver);
       
        // Timepage object identified and create time record
        TMPage TimePageObj = new TMPage();
        TimePageObj.CreateTime(driver);
        
        // clear Time record and edit time record
        TMPage timePageObj = new TMPage();
        timePageObj.EditTime(driver);
      
        // Material page object Identified and create material record
        TMPage materialPageObj = new TMPage();
        materialPageObj.CreateMaterial(driver);

        // clear Material record and edit Material record
        TMPage editMaterialPageObj = new TMPage();
        editMaterialPageObj.EditMaterial(driver);
       
        // Deleteobject Identified and delete the last record
        TMPage deleteLastRecordObj = new TMPage();
        deleteLastRecordObj.DeleteLastRecord(driver);

       
    }
}
        


        
        
        
        
       