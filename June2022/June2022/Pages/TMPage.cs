using NUnit.Framework;

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

            //go to last page
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            goToLastPageButton.Click();
            Thread.Sleep(2500);

        }

        public string GetCode(IWebDriver driver)
        {
            IWebElement newCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            return newCode.Text;
        }
        public string GetDescription(IWebDriver driver)
        {
            IWebElement newDescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
            return newDescription.Text;
        }
        public string GetPrice(IWebDriver driver)
        {
            IWebElement newPrice = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));
            return newPrice.Text;
        }

        //Assertion no2
        //if (newCode.Text == "June2022")
        //{
        //    Assert.Pass("New material record created successfully.");
        //}
        //else
        //{
        //    Assert.Fail("New material record hasn't been created");

        //}


        public void EditTM(IWebDriver driver, string code,string description,string price)
        {
            //Edit time and material functionality//

            //go to last page button
            Thread.Sleep(2000);
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            goToLastPageButton.Click();
            Thread.Sleep(3000);
            //Identify edit textbox
            IWebElement findCodeRecordCreated = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            
            IWebElement editTextBox = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            Thread.Sleep(1000);
            editTextBox.Click();
           

            //Input edit code text box
            IWebElement editCodeTextbox = driver.FindElement(By.Id("Code"));
            editCodeTextbox.Click();
            editCodeTextbox.Clear();
            editCodeTextbox.SendKeys("code");
            Thread.Sleep(2000);

            //Input edit description text box
            IWebElement editDescriptionTextbox = driver.FindElement(By.Id("Description"));
            editDescriptionTextbox.Click();
            editDescriptionTextbox.Clear();
            editDescriptionTextbox.SendKeys("Edited1");
            Thread.Sleep(2000);

            //Input edit price tag interactable
            IWebElement editPriceTag = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            IWebElement editPriceTextbox = driver.FindElement(By.Id("Price"));

            editPriceTag.Click();
            editPriceTextbox.Clear();
            editPriceTag.Click();
            editPriceTextbox.SendKeys(price);
            Thread.Sleep(3000);

            //click on edit save button
            IWebElement editSaveButton = driver.FindElement(By.Id("SaveButton"));
            editSaveButton.Click();
            Thread.Sleep(2000);

            //go to last page button to see changes
            IWebElement goToLastPage = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            goToLastPage.Click();
            Thread.Sleep(3000);
    

        }
        public string GetEditedCode(IWebDriver driver)
        {
            Thread.Sleep(2000);
            IWebElement editedCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            return editedCode.Text;
        }
        public string GetEditedDescription(IWebDriver driver)
        {
            Thread.Sleep(2000);
            IWebElement editedDescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
            return editedDescription.Text;
        }
        public string GetEditedPrice(IWebDriver driver)
        {
            Thread.Sleep(2000);
            IWebElement editedPrice = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));
            return editedPrice.Text;
        }
        public void DeleteTM(IWebDriver driver)
        {
            Thread.Sleep(2000);
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            goToLastPageButton.Click();
            Thread.Sleep(2000);

            //delete the record
            IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last]/td[5]/a[2]"));
            Thread.Sleep(2500);
            deleteButton.Click();
            Thread.Sleep(3000);

            //click on delete ok button
            Thread.Sleep(2000);
            driver.SwitchTo().Alert().Accept();
            driver.Navigate().Refresh();
            Thread.Sleep(3000);

        }
        public void DeletedCodeAssertion(IWebDriver driver)
        {
            Thread.Sleep(2000);
            IWebElement deletedCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            Assert.That(deletedCode.Text != "Guitar", "Record has not been deleted");
        }
        public void DeletedDescriptionAssertion(IWebDriver driver)
        {
            Thread.Sleep(2000);
            IWebElement deletedDescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
            Assert.That(deletedDescription.Text != "White", "Record has not been deleted");
        }
        public void DeletedPriceAssertion(IWebDriver driver)
        {
            Thread.Sleep(2000);
            IWebElement deletedPrice = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));
            Assert.That(deletedPrice.Text != "$900.00", "Record has not been deleted");

        }
        
    }
}
