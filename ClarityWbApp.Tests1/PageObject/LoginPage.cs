using ClarityWbApp.Tests1.TestDataAcces;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClarityWbApp.Tests1.PageObject
{
    public class LoginPage
    {



        IWebDriver driver;
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        
        //Login page Credential
        [FindsBy(How = How.Id, Using = "UserName")]
        private IWebElement UserNameTB { get; set; }
       
        [FindsBy(How = How.Id, Using = "Password")]
        private IWebElement passwordTB { get; set; }
       
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div[2]/section/div/div[2]/div/form/p[4]/input")]
        private IWebElement click { get; set; }

      
        public ClarityAdmin LoginToApplication(String UN, String PASS)
        {
            UserNameTB.SendKeys(UN);
            passwordTB.SendKeys(PASS);
            click.Submit();
            return new ClarityAdmin(driver);
            
        }
       

    }

}

