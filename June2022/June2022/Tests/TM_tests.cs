using June2022.Utilities;
using NUnit.Framework;

namespace June2022.Tests
{
    [TestFixture]
    [Parallelizable]
    public class TM_Tests : CommonDriver
    {
        //page object initialization

        HomePage HomePageObj = new HomePage();
        TMPage TMPageObj = new TMPage();

        [Test, Order(1), Description("Check if user is able to create login data") ]
        public void CreateTmTest()
        {
            
            HomePageObj.GotoTMPage(driver);
            TMPageObj.CreateTM(driver);
        }
        [Test, Order(2), Description("Check if user is able to edit login data")]
        public void EditTmTest()
        {
            
            HomePageObj.GotoTMPage(driver);
            TMPageObj.EditTM(driver,"nskjd","jfrnij","kdsfjnk");
        }
        [Test, Order(3), Description("Check if user is able to delete login data")]
        public void DeleteTmTest()
        {
           
            HomePageObj.GotoTMPage(driver);
            TMPageObj.DeleteTM(driver);
        }
        
    }
}
