using June2022.Utilities;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace June2022.Tests
{
    [TestFixture]
    [Parallelizable]
    public class Employee_Tests : CommonDriver
    {
        HomePage homePageObj = new HomePage();
        EmployeePage employeePageObj = new EmployeePage();

        [Test]
        public void CreateEmployee()
        {
            
            homePageObj.GotoEmployeePage(driver);
            employeePageObj.CreateEmployee(driver);
        }
        [Test]
        public void EditEmployee()
        {
            
            homePageObj.GotoEmployeePage(driver);
            employeePageObj.EditEmployee(driver);
        }
        [Test]
        public void DeleteEmployee()
        {

            homePageObj.GotoEmployeePage(driver);
            employeePageObj.DeleteEmployee(driver);
        }
        [TearDown]
        public void ClosingSteps()
        {
            driver.Quit();
        }
    }
            
}
