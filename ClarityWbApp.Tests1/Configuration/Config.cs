using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClarityWbApp.Tests1.Configuration
{
    public class Config
    {
        public static string IntializeTest()
        {
            return ConfigurationManager.AppSettings["AUT"].ToString();

        }
        public static string GetAppSetting(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }
        public object Searcht{get; private set;}

    }
}
