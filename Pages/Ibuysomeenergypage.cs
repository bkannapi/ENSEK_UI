using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.WaitHelpers;

namespace ENSEK.Pages
{
    public class Ibuysomeenergypage
    {
        private readonly IWebDriver _driver;
        private readonly WebDriverWait _wait;

        public Ibuysomeenergypage(IWebDriver driver)
        {
            this._driver = driver;
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
        }

    
        private IWebElement BuyEnergyButton => _driver.FindElement(By.CssSelector("body > div.container.body-content > div.row > div:nth-child(1) > p:nth-child(3) > a"));
        private IWebElement TableElement => _driver.FindElement(By.XPath("//table"));
        private IEnumerable<IWebElement> TableRows => TableElement.FindElements(By.TagName("tr")).Skip(1); 
        private IWebElement SaleConfirmationMessage =>_driver.FindElement(By.ClassName("well"));
        private By energyTable = By.CssSelector("table tbody tr");

        public void ClickBuyEnergyButton()
        {
            BuyEnergyButton.Click();
        }

        public void BuyEnergyFromTable(string energyType, string numberOfUnits)
        {
            
            IWebElement table = _driver.FindElement(By.CssSelector("table.table")); 

            IWebElement row = table.FindElements(By.TagName("tr")).FirstOrDefault(r => r.Text.Contains(energyType));

            if (row == null)
            {
                throw new Exception($"No row found for energy type: {energyType}");
            }
         
            IWebElement quantityInput = row.FindElement(By.CssSelector("input[name$='.AmountPurchased']"));
            quantityInput.Clear();
            quantityInput.SendKeys(numberOfUnits);

            
            IWebElement buyButton = row.FindElement(By.CssSelector("input[type='submit'][value='Buy']"));
            buyButton.Click();
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("div.well")));
        }

        public string GetConfirmationMessage()
        {            
            var confirmationMessage = _driver.FindElement(By.CssSelector("div.well")).Text;
            return confirmationMessage;
        }

      

    }
}
