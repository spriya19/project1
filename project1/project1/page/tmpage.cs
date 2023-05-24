using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace project1.page
{
    public class TMPage
    {
        public void CreateTime(IWebDriver driver)
        {
            // click create new button
            IWebElement createnewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createnewButton.Click();
            
            // select Time from dropdown List
            IWebElement typeCodeDropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
            typeCodeDropdown.Click();
            Thread.Sleep(1000);
            
            IWebElement timeOption = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
            timeOption.Click();
            
            // input code
            IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
            codeTextbox.SendKeys("3ES");
            
            // input description
            IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
            descriptionTextbox.SendKeys("RAJA");
            
            // input price per unit
            IWebElement priceTextbox = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            priceTextbox.SendKeys("66");
            Thread.Sleep(2000);
           
            // click on save button
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            
            // check Time Record created successfully
            Console.WriteLine("Record saved successfully...");
            
            // navige to last page
            Thread.Sleep(3000);
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goToLastPageButton.Click();
            Thread.Sleep(4000);
            
            //=======check if the Time record is present in the table======
            IWebElement newcode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            if (newcode.Text == "3ES")
            {
                Console.WriteLine("Time record has created succesfully");
            }
            else
            {
                Console.WriteLine("Time record has not been created successfully");
            }
        }
        public void CreateMaterial(IWebDriver driver)
        {
            // ======================= Create Material Record ======================= 
            IWebElement createnewButton4Material = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createnewButton4Material.Click();
            
            // select dropdown List
            IWebElement typeCodeDropdown4Material = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
            typeCodeDropdown4Material.Click();
           
            // select Material from dropdown List
            Thread.Sleep(1000);
            IWebElement createM = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[1]"));
            createM.Click();

            // input code
            IWebElement mcodeTextbox = driver.FindElement(By.Id("Code"));
            mcodeTextbox.SendKeys("MAT");
            
            // input description
            IWebElement mdescriptionTextbox = driver.FindElement(By.Id("Description"));
            mdescriptionTextbox.SendKeys("ESP");
            // input price per unit
            IWebElement mpriceTextbox = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            mpriceTextbox.SendKeys("2479");
            Thread.Sleep(2000);
            
            // click on save button
            IWebElement msaveButton = driver.FindElement(By.Id("SaveButton"));
            msaveButton.Click();

            // check material record saved
            Console.WriteLine("Material record saved...");
            Thread.Sleep(3000);
            IWebElement GoToLastPageButtonAfterAddMaterial = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            GoToLastPageButtonAfterAddMaterial.Click();
            
            //check if the Material record is present in the table
            IWebElement newMaterialcode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            if (newMaterialcode.Text == "MAT")
            {
                Console.WriteLine("Material record has created and verified succesfully");
            }
            else
            {
                Console.WriteLine("Material record has not been created successfully");
            }
        }

        public void EditMaterial(IWebDriver driver)
        {
            // click Edit the last  Record
            IWebElement lastmaterialRecordButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            lastmaterialRecordButton.Click();
            
            IWebElement editMaterialCodeTextbox = driver.FindElement(By.Id("Code"));
            editMaterialCodeTextbox.Clear();
            editMaterialCodeTextbox.SendKeys("MAT20");

            IWebElement editDescriptionTextbox = driver.FindElement(By.Id("Description"));
            editDescriptionTextbox.Clear();
            editDescriptionTextbox.SendKeys("ELAN");

            IWebElement editPriceTextbox = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            editPriceTextbox.Clear();
            editPriceTextbox.SendKeys("100");
            Thread.Sleep(2000);
            
            // click on save button
            IWebElement editMaterialSaveButton = driver.FindElement(By.Id("SaveButton"));
            editMaterialSaveButton.Click();
            Console.WriteLine("Editing a record is done");
            
            // Click last Page Button (after editing)
            Thread.Sleep(3000);
            IWebElement afterEditmaterialGoToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            afterEditmaterialGoToLastPageButton.Click();
            
            //check if the  edit record is present in the table
            IWebElement editmCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            if (editmCode.Text == "MAT20")
            {
                Console.WriteLine("Material edit record has created and verified succesfully");
            }
            else
            {
                Console.WriteLine("Material edit record has not been created successfully");
            }
        }

        public void DeleteLastRecord(IWebDriver driver)
        {
            // click delete last record
            Thread.Sleep(3000);
            IWebElement deleteRecord = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            deleteRecord.Click();
            Thread.Sleep(3000);
            
            // To Click OK in altert window
            driver.SwitchTo().Alert().Accept();
            
            // To Click Cancel in alert window, if you dont want to delete
            driver.SwitchTo().Alert().Dismiss();
            Console.WriteLine("Last record from the table has been deleted successfully.");
        }
        public void EditTime(IWebDriver driver)
        {
            // click Edit Time the last Record
            IWebElement lastRecordButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            lastRecordButton.Click();
            
            IWebElement editCodeTextbox = driver.FindElement(By.Id("Code"));
            editCodeTextbox.Clear();
            editCodeTextbox.SendKeys("3ESPEDIT");

            IWebElement editDescriptionTextbox = driver.FindElement(By.Id("Description"));
            editDescriptionTextbox.Clear();            
            editDescriptionTextbox.SendKeys("RAJA40");

            \\IWebElement priceTextboxOverlap = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            \\priceTextboxOverlap.Click();
            \\IWebElement editPriceTextbox = driver.FindElement(By.Id("Price"));
            editPriceTextbox.Clear();
            editPriceTextbox.SendKeys("89");
            Thread.Sleep(2000);
           
            // click on save button
            IWebElement editSaveButton = driver.FindElement(By.Id("SaveButton"));
            editSaveButton.Click();
            Console.WriteLine("Editing a record is done");
            
            // Click last Page Button (after editing)
            Thread.Sleep(3000);
            IWebElement afterEditGoToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            afterEditGoToLastPageButton.Click();
            
            //check if the  edit record is present in the table
            IWebElement editCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            if (editCode.Text == "3ESEDIT")
            {
                Console.WriteLine("Time edit record has created and verified succesfully");
            }
            else
            {
                Console.WriteLine("Time edit record has not been created successfully");
            }
        }
    }
}
