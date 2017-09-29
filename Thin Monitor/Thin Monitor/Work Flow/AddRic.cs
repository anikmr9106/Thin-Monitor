using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thin_Monitor.Common;
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
            //Actions act_row = new Actions(driver);
            //act_row.MoveToElement(mon.sec_row).DoubleClick().Click().SendKeys("A").SendKeys(Keys.Enter).Build().Perform();

            //Adding RICs From List
            string part1 = "//*[@id='section1']/div/div[2]/div[";
            string part2 = "]/div";
            int i = 1;
            List<string> riclist = DataList.RICsList();
            foreach(string j in riclist)
            {
                string fullpath = part1 + i + part2;
                Actions act_rowi = new Actions(driver);
                act_rowi.MoveToElement(driver.FindElement(By.XPath(fullpath))).DoubleClick().Click().SendKeys(j).SendKeys(Keys.Enter).Build().Perform();
                i++;
            }

            //Adding Column
            Actions act_col1 = new Actions(driver);

        }
    }
}
