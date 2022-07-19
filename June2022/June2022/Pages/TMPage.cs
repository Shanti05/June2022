using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace June2022.Pages
{
   public class TMPage
    {
        public void CreateTM(IWebDriver driver)
        {
            //Create a new time and material record//

            //Click on create new
            IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            createNewButton.Click();
            Thread.Sleep(1500);

            //Input code
            IWebElement codeTextBox = driver.FindElement(By.Id("Code"));
            codeTextBox.SendKeys("June2022");

            //Input description
            IWebElement DescriptionTextbox = driver.FindElement(By.Id("Description"));
            DescriptionTextbox.SendKeys("June2022");

            //Input price tag interactable
            IWebElement priceTag = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            priceTag.Click();

            //Input price 
            IWebElement priceTextbox = driver.FindElement(By.Id("Price"));
            priceTextbox.SendKeys("20");


            //Click on save button 
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Thread.Sleep(3000);

            //go to last page button
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            goToLastPageButton.Click();

            //Check if the material record has been created successfully
            IWebElement newCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            //ASSERTION NO1
            Assert.That(newCode.Text == "June2022", "Actual code and expected code do not match");

            //Assertion no2
            //if (newCode.Text == "June2022")
            //{
            //    Assert.Pass("New material record created successfully.");
            //}
            //else
            //{
            //    Assert.Fail("New material record hasn't been created");

            //}
        }

        public void EditTM(IWebDriver driver)
        {
            //Edit time and material functionality//

            //Identify edit textbox
            IWebElement editTextbox = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last]/td[5]/a[1]"));
            editTextbox.Click();

            //Input new code text box
            IWebElement newcodeTextbox = driver.FindElement(By.Id("Code"));
            newcodeTextbox.Clear();
            newcodeTextbox.SendKeys("Edited");

            //Input newdescription text box
            IWebElement newdescriptionTextbox = driver.FindElement(By.Id("Description"));
            newdescriptionTextbox.Clear();
            newdescriptionTextbox.SendKeys("Edited1");

            //Input new price tag interactable
            IWebElement newpriceTag = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            IWebElement newpriceTextbox = driver.FindElement(By.Id("Price"));

            newpriceTag.Click();
            newpriceTextbox.Clear();
            newpriceTag.Click();
            newpriceTextbox.SendKeys("1990");

            //click on new save button
            IWebElement newSaveButton = driver.FindElement(By.Id("SaveButton"));
            newSaveButton.Click();

            //go to last page button
            IWebElement goToLastPage = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            goToLastPage.Click();
            Thread.Sleep(1500);
        }
        public void DeleteTM(IWebDriver driver)
        {
            //delete the record
            IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last]/td[5]/a[2]"));
            deleteButton.Click();

            //click on delete ok button
            driver.SwitchTo().Alert().Accept();

        }
    }
}
