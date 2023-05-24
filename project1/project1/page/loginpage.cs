using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1.page
{
    public class LoginPage
    {
        public void LoginSteps(IWebDriver driver)
        {
            // === Lanuch Turnup portal ===
           driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
           driver.Manage().Window.Maximize();
           Thread.Sleep(1000);
           
           // identify username textbox enter valid username
           IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
           usernameTextbox.SendKeys("hari");
           
            // Identify password textbox enter valid password
           IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
           passwordTextbox.SendKeys("123123");
           Thread.Sleep(1000);
            
            // check user has checked successfully
            IWebElement remembermeLable = driver.FindElement(By.Id("RememberMe"));
            remembermeLable.Click();
            
            // click longin button
            IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
            loginButton.Click();
        }
    }
}
