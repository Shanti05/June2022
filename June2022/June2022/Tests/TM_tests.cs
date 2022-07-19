using June2022.Utilities;
using NUnit.Framework;

namespace June2022.Tests
{
    [TestFixture]
    public class TM_Tests : CommonDriver
    {
        [SetUp]
        public void LoginSteps()
        {
            driver = new ChromeDriver();
         LoginPage LoginPageobj = new LoginPage();
         LoginPageobj.LoginActions(driver);

         HomePage HomePageObj = new HomePage();
         HomePageObj.GotoTMPage(driver);
        }
        [Test]
        public void CreateTmTest()
        {
            TMPage TMPageObj = new TMPage();
         TMPageObj.CreateTM(driver);
        }
        [Test]
        public void EditTmTest()
        {
            TMPage TMPageObj = new TMPage();
            TMPageObj.EditTM(driver);
        }
        [Test]
        public void DeleteTmTest()
        {
            TMPage TMPageObj = new TMPage();
            TMPageObj.DeleteTM(driver);
        }
        [TearDown]
        public void CloseTestRun()
        {

        }
    }
}
