using ENSEK.Pages;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace ENSEK.StepDefinitions
{
    [Binding]
    public class HomepagemenuStepDefinitions
    {

        IWebDriver _driver;
        Homepagemenu _Home;
        public HomepagemenuStepDefinitions(IWebDriver driver)
        {

            this._driver = driver;
            _Home = new Homepagemenu(_driver);         

        }       


        [Given(@"load the URL")]
        public void GivenLoadTheURL()
        {
            _Home.Homepage();
        }        

        [Then(@"verfiy the page loads successfully")]
        public void ThenVerfiyThePageLoadsSuccessfully()
        {
            _Home.Verifyhomepage();
        }

        [Then(@"click the About menu")]
        public void ThenClickTheAboutMenu()
        {
            _Home.Aboutpage();
        }

        [Then(@"verify about page loading fine")]
        public void ThenVerifyAboutPageLoadingFine()
        {
            _Home.Verifyaboutpage();
        }

        [Then(@"click the contact menu")]
        public void ThenClickTheContactMenu()
        {
            _Home.Contactpage();
        }

        [Then(@"verify contact page loading fine")]
        public void ThenVerifyContactPageLoadingFine()
        {
            _Home.Verifycontactpage();
        }

        [Then(@"click the register menu")]
        public void ThenClickTheRegisterMenu()
        {
            _Home.Registerpage();
        }

        [Then(@"verify register page loading fine")]
        public void ThenVerifyRegisterPageLoadingFine()
        {
            _Home.Verifyregisterpage();
        }

        [Then(@"click the login menu")]
        public void ThenClickTheLoginMenu()
        {
            _Home.Loginpage();
        }

        [Then(@"verify login page loading fine")]
        public void ThenVerifyLoginPageLoadingFine()
        {
            _Home.Verifyloginpage();
        }
    }
}
