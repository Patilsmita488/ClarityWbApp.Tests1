using ClarityWbApp.Tests1.Configuration;
using ClarityWbApp.Tests1.PageObject;
using ClarityWbApp.Tests1.TestDataAcces;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Safari;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClarityWbApp.Tests1.TestScript
{
    [TestFixture]
    [Parallelizable]
    public class BaseTest
    {
        public IWebDriver driver;
        [SetUp]
        public void LaunchBrowser()
        {
            driver = new ChromeDriver();
            //Calling URL from App config file
            driver.Url = Config.IntializeTest();
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void LoginPageChrome_01()
        {
            var homePage = new PageObject.HomePage(driver);
            homePage.clickToLogin();
            //Intialize the page with its Refrences
            Thread.Sleep(5000);
            //Reading Data i.e UN and Pass from Excel file
            ExcelDataAcces.PopulateInCollection(@"C:\Users\Focusprism\Documents\TestData.xlsx");
            var Loginppage = homePage.clickToLogin();
            //throw invalid Credential Username and password

            Thread.Sleep(8000);
            Loginppage.LoginToApplication(ExcelDataAcces.ReadData(1, "UserName"), ExcelDataAcces.ReadData(1, "Password"));
        }
    
   /*
        [TearDown]
        public void CloseBrowser()
        {
            driver.Close();
        }
        */
    }              }
    


    

