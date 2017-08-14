using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thin_Monitor.Page_Object;

namespace Thin_Monitor.Work_Flow
{
    class AddRic
    {
        public void add_ric(IWebDriver driver)
        {
            Monitor mon = new Monitor(driver);
            mon.setting_btn.Click();

            //Adding Ric
            Actions act_row = new Actions(driver);
            act_row.MoveToElement(mon.first_row).DoubleClick().Click().SendKeys("A").SendKeys(Keys.Enter).Build().Perform();

            //Adding Column
            Actions act_col1 = new Actions(driver);

        }
    }
}
