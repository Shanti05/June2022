using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace June2022.Pages
{
    public class EmployeePage
    { 
        public void CreateEmployee(IWebDriver driver)
        {
            //Create New Employee details

            //Click on Create new Employee

            IWebElement CreateNewEmployee = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            CreateNewEmployee.Click();
            Thread.Sleep(2000);
            
            //Input Name 
            IWebElement EmployeeName = driver.FindElement(By.Id("Name"));
            EmployeeName.Click();
            Thread.Sleep(2000);

            //Input Username 
            IWebElement UserName = driver.FindElement(By.Id("Username"));
            UserName.Click();
            Thread.Sleep(2000);

            //Input Contact details
            IWebElement Contact = driver.FindElement(By.Id("ContactDisplay"));
            Contact.Click();

            //Input Edited contact details
            IWebElement EditContact = driver.FindElement(By.Id("EditContactButton"));
            EditContact.Click();
            Thread.Sleep(3500);

            //Input First Name 
            IWebElement FirstName = driver.FindElement(By.Id("FirstName"));
            FirstName.Click();
            Thread.Sleep(1500);

            //Click on Last name button
            IWebElement LastName = driver.FindElement(By.Id("LastName"));
            LastName.Click();
            Thread.Sleep(2000);

            //Click on prefered Name
            IWebElement PreferedName = driver.FindElement(By.Id("PreferedName"));
            PreferedName.Click();

            
        }
        public void EditEmployee(IWebDriver driver)
        {

        }
        public void DeleteEmployee(IWebDriver driver)
        {

        }
    }
}