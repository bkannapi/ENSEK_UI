using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using ENSEK.Configuration;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace ENSEK.Pages
{
    public class Homepagemenu
    {
        IWebDriver _driver;

        public Homepagemenu(IWebDriver driver) 
        {
            this._driver = driver;        
        }

        IWebElement aboutmenu => _driver.FindElement(By.CssSelector("body > div.navbar.navbar-inverse.navbar-fixed-top > div > div.navbar-collapse.collapse > ul:nth-child(1) > li:nth-child(2) > a"));
        IWebElement contactmenu => _driver.FindElement(By.CssSelector("body > div.navbar.navbar-inverse.navbar-fixed-top > div > div.navbar-collapse.collapse > ul:nth-child(1) > li:nth-child(3) > a"));
        IWebElement RegisterLink => _driver.FindElement(By.Id("registerLink"));
        IWebElement Login => _driver.FindElement(By.Id("loginLink"));
        IWebElement aboutheading => _driver.FindElement(By.CssSelector("body > div.container.body-content > h2"));
       

        public void Homepage()
        {
            _driver.Navigate().GoToUrl(ReadConfig.WebUrl);
            
        }

        public void Verifyhomepage()
        {            
            string actualtitle = _driver.Title;
            string expectedtitle = "ENSEK Energy Corp. - Candidate Test";
            Assert.AreEqual(expectedtitle, actualtitle);
            Console.WriteLine($"I have successfully landed on the homepage {actualtitle}.");
        }

        public void Aboutpage()
        {
            aboutmenu.Click();
            WebDriverWait wait=new WebDriverWait(_driver,TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("body > div.container.body-content > h2")));
            
        }

        public void Verifyaboutpage()
        {            
            string expectedheading = aboutheading.Text;
            string actualheading = "About ENSEK Energy Corp..";
            Assert.AreEqual(expectedheading, actualheading);
            Console.WriteLine($"I have successfully landed on the about page {expectedheading}.");
        }

        public void Contactpage()
        {
            contactmenu.Click();
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("body > div.container.body-content > h2")));
            
        }

        public void Verifycontactpage()
        {            
            string actualtitle = _driver.Title;
            string expectedtitle = "Contact - Candidate Test";
            Assert.AreEqual(expectedtitle, actualtitle);
            Console.WriteLine($"I have successfully landed on the contact page {actualtitle}.");
        }

        public void Registerpage()
        {
            RegisterLink.Click();
            WebDriverWait wait = new WebDriverWait(_driver,TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("body > div.container.body-content > h2")));
            
        }

        public void Verifyregisterpage()
        {           
            string actualtitle = _driver.Title;
            string expectedtitle = "Register - Candidate Test";
            Assert.AreEqual(expectedtitle, actualtitle);
            Console.WriteLine($"I have successfully landed on the register page {actualtitle}.");
        }

        public void Loginpage()
        {
           Login.Click();
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("body > div.container.body-content > h2")));
            
        }
        public void Verifyloginpage()
        {            
            string actualtitle = _driver.Title;
            string expectedtitle = "Log in - Candidate Test";
            Assert.AreEqual(expectedtitle, actualtitle);
            Console.WriteLine($"I have successfully landed on the login page {actualtitle}.");
        }

    }
}
