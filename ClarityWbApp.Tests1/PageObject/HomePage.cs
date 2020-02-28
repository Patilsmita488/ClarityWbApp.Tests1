using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClarityWbApp.Tests1.PageObject
{
    public class HomePage
    {
        IWebDriver driver;
        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.XPath, Using = "/html/body")]
        public IWebElement clickLogin { get; set; }

        public LoginPage clickToLogin()
        {
            clickLogin.Click();
            return new LoginPage(driver);
        }

    }
}
