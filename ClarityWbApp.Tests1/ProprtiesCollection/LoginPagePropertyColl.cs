using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClarityWbApp.Tests1.ProprtiesCollection
{

    enum propertytype
    {
        Id,
        Name,
        LinkText,
        Xpath,
        partialLinktext,
        CSSselector,
    }
    class LoginPagePropertyColl
        {
        public static IWebDriver driver { get; set; }

    }
}
