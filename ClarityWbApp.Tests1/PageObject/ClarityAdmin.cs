using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace ClarityWbApp.Tests1.PageObject
{
    public class ClarityAdmin
    {
        private IWebDriver driver;

        public ClarityAdmin(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
