using June2022.Utilities;
using NUnit.Framework;

namespace June2022.Pages
{
    public class HomePage
    {
        public void GotoTMPage(IWebDriver driver)
        {
            try
            {
                //Click on administration tab
                Thread.Sleep(1000);
                IWebElement administrationTab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
                administrationTab.Click();
                Waithelpers.WaitToBeClickable(driver, 5, "XPath ", "/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a");

            }
            catch(Exception ex)
            {
                Assert.Fail("TM option not available",ex.Message);
            }
            //Select time and material tab from dropdown list
            IWebElement tmoption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            tmoption.Click();
            Thread.Sleep(1500);
        }
        public void GoToEmployeePage(IWebDriver driver)
        {

        }
    }
}
