using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inspire
{
    public abstract class BasePage
    {
        public BasePage()
        {
            PageFactory.InitElements(TestDriver.Driver, this);
        }
    }
}
