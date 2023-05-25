using OpenQA.Selenium;
using project1.utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1.page
{
    public class Homepage
    {
        public void GoToTMPage(IWebDriver driver)
        {
            // =========navigate to time and mateial page========
            IWebElement administrationTab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            administrationTab.Click();
            
            Wait.WaitToBeClickable(driver, "XPath","/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a", 7);
            
            IWebElement tmoptionTab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            tmoptionTab.Click();
        }
        
               
         
    }
}
