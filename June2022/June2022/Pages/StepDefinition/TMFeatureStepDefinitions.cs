using June2022.Utilities;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace June2022.Pages.StepDefinition
{
    [Binding]
    public class TMFeatureStepDefinitions : CommonDriver
    {
        LoginPage LoginPageobj = new LoginPage();
        HomePage HomePageObj = new HomePage();
        TMPage TMPageObj = new TMPage();
        

        [Given(@"I logged into turnup portal successfully")]
        public void GivenILoggedIntoTurnupPortalSuccessfully()
        {
            driver = new ChromeDriver();
            LoginPageobj.LoginActions(driver);

        }

        [When(@"I navigate to time and material page")]
        public void WhenINavigateToTimeAndMaterialPage()
        {

            HomePageObj.GotoTMPage(driver);
        }

        [When(@"I create a new material record")]
        public void WhenICreateANewMaterialRecord()
        {
            
            TMPageObj.CreateTM(driver);
        }

        [Then(@"The record should be created successfully")]
        public void ThenTheRecordShouldBeCreatedSuccessfully()
        {

            string newCode = TMPageObj.GetCode(driver);
            string newDescription = TMPageObj.GetCode(driver);
            string newPrice = TMPageObj.GetCode(driver);

            Assert.That(newCode == "June2022", "Acutal code and expected code do not match");
            Assert.That(newDescription == "June2022", "Acutal description and expected description do not match");
            Assert.That(newPrice == "20", "Acutal Price and expected Price do not match");

        }
        [When(@"I update '([^']*)','([^']*)','([^']*)' of existing material record")]
        public void WhenIUpdateOfExistingMaterialRecord(string p0, string black, string p2)
        {
            TMPage tmPageObj = new TMPage;
            tmPageObj.EditTM(driver);
        }

        [Then(@"The record should have the '([^']*)','([^']*)','([^']*)' updated")]
        public void ThenTheRecordShouldHaveTheUpdated(string p0, string p1, string p2)
        {
            string editedCode = TMPageObj.GetEditedCode(driver);
            string editedDescription = TMPageObj.GetEditedDescription(driver);
            string editedPrice = TMPageObj.GetEditedCode(driver);

            Assert.That(editedCode == "p0", "Acutal code and expected code do not match");
            Assert.That(editedDescription == "p1", "Acutal description and expected description do not match");
            Assert.That(editedPrice == "p2", "Acutal Price and expected Price do not match");

        }

        [When(@"I deleted an existing time and material record")]
        public void WhenIDeletedAnExistingTimeAndMaterialRecord()
        {
            TMPage tmPageObj = new TMPage();
            tmPageObj.DeleteTM(driver);

        }

        [Then(@"The record deleted successfully")]
        public void ThenTheRecordDeletedSuccessfully()
        {
            TMPage tmPageObj = new TMPage();
            tmPageObj.DeletedCodeAssertion(driver);

        }


    }


}
