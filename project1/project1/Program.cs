using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using project1.page;

public class Program
{
    private static void Main(string[] args)
    {
        // Open Chrome Browser
        IWebDriver driver = new ChromeDriver();
        //Login page object identified and definitio
        LoginPage loginpageObj = new LoginPage();
        loginpageObj.LoginSteps(driver);

        Homepage homepageObj = new Homepage();
        homepageObj.GoToTMPage(driver);
        TMPage TimePageObj = new TMPage();
        TimePageObj.CreateTime(driver);
        // create Material
        TMPage MaterialPageObj = new TMPage();
        MaterialPageObj.CreateMaterial(driver);

    }
}
        


        
        
        
        
       