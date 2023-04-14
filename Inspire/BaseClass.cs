using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inspire
{
    public class BaseClass
    {

        private static IWebDriver GetChromeDriver()
        {
            IWebDriver driver = new ChromeDriver();
            ChromeOptions ops = new ChromeOptions();
            ops.AddArguments("--remote-allow-origins=*");
            driver.Manage().Window.Maximize();
            return driver;
        }

        private static IWebDriver GetFireFoxDriver()
        {
            IWebDriver driver = new FirefoxDriver();
            return driver;
        }
    }
}
