using ENSEK.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using TechTalk.SpecFlow;

namespace ENSEK.StepDefinitions
{
    [Binding]
    public class IbuyenergyStepDefinitions
    {

        private readonly IWebDriver _driver;
        private readonly Homepagemenu _Home;
        private readonly Ibuysomeenergypage _energyPage;

        public IbuyenergyStepDefinitions(IWebDriver driver)
        {
            _driver = driver;
            _energyPage = new Ibuysomeenergypage(_driver);
            _Home = new Homepagemenu(_driver);
        }
        [Given(@"I am in Ensek Home page")]
        public void GivenIAmInEnsekHomePage()
        {
            _Home.Homepage();
            _Home.Verifyhomepage();
        }

        [When(@"I click Buy energy button")]
        public void WhenIClickBuyEnergyButton()
        {
            _energyPage.ClickBuyEnergyButton();
        }

        [Then(@"I should be shown with buy energy screen")]
        public void ThenIShouldBeShownWithBuyEnergyScreen()
        {
            //WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            //wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("body > div.container.body - content > h2")));               
                
        }
       

        [Then(@"I buy ""([^""]*)"" quantity (.*)")]
        public void ThenIBuyQuantity(string EachEnergyType, string NumberOfUnits)
        {
            _energyPage.BuyEnergyFromTable(EachEnergyType, NumberOfUnits);
        }


        [Then(@"I should be shown with sale confirmed message")]
        public void ThenIShouldBeShownWithSaleConfirmedMessage()
        {
            Assert.IsNotNull(_energyPage.GetConfirmationMessage(), "Sale confirmation message not displayed.");
        }

        [Then(@"I should verfiy the confirmation message showing the correct unit ordered and remaining unit")]
        public void ThenIShouldVerfiyTheConfirmationMessageShowingTheCorrectUnitOrderedAndRemainingUnit()
        {

            var confirmationMessage =_energyPage.GetConfirmationMessage();
            Console.WriteLine("Confirmation Message: " + confirmationMessage);

            Assert.IsTrue(confirmationMessage.Contains("Thank you for your purchase"), "Confirmation message format is incorrect.");
        }
    }
}
