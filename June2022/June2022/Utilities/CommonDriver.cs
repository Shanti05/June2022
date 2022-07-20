using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace June2022.Utilities
{
    public class CommonDriver
    {
        public static IWebDriver driver;
        [SetUp]
        public void LoginSteps()
        {
            driver = new ChromeDriver();
            LoginPage LoginPageobj = new LoginPage();
            LoginPageobj.LoginActions(driver);

        }
        [TearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }
    }
}