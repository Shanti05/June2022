using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace June2022.Pages
{
    public class HomePage
    {
        public void GotoTMPage(IWebDriver driver)
        {
            //Click on administration tab
            Thread.Sleep(1000);
            IWebElement administrationTab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            administrationTab.Click();

            //Select time and material tab from dropdown list
            IWebElement tmoption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            tmoption.Click();
            Thread.Sleep(1500);
        }
    }
}
