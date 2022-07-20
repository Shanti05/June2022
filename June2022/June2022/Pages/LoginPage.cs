using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace June2022.Pages
{
    public class LoginPage
    {
        public void LoginActions(IWebDriver driver)
        {
            
            driver.Manage().Window.Maximize();

            //Launch the turnup portal
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
            Thread.Sleep(1000);

            try
            {
                //Identify username textbox and enter valid username
                IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
                usernameTextbox.SendKeys("hari");

                //Identify password textbox and enter valid password
                IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
                passwordTextbox.SendKeys("123123");

                //Identify login button and click on it
                IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
                loginButton.Click();

               
            }
            catch(Exception ex)
            {
                Assert.Fail("Turnup portal homepage did not launch", ex.Message);
            }

            
        }
    }
}
