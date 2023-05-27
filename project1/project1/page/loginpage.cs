using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using project1.utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1.page
{
    public class LoginPage:CommonDriver
    { 
        private static IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
        private static IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
        private static IWebElement remembermeLable = driver.FindElement(By.Id("RememberMe"));
        private static IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
        public void LoginSteps(IWebDriver driver)
        {
            // Launch the turnup Portal
           driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
           driver.Manage().Window.Maximize();
           driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
             
            Wait.WaitToExist(driver,"Id","UserName",4);
            try
            {
                usernameTextbox.SendKeys("hari");
                passwordTextbox.SendKeys("123123");
                remembermeLable.Click();
                loginButton.Click();
            }
            catch (Exception ex)
            {
                Assert.Fail("Turnup Protal Page did not open",ex);
            }
            
        }
    }
}
