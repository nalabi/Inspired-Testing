using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inspire
{
    public class Actions
    {
        public static void InitializeDriver()
        {
            TestDriver.Driver = new ChromeDriver();
            TestDriver.Driver.Navigate().GoToUrl(TakelotUrls.TakelotUrl);
            TestDriver.WaitForElementUpTo(TakelotUrls.ElementsWaitingTimeout);
        }
    }
}
