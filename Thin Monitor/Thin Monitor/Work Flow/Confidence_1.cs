using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thin_Monitor.Common;
using Thin_Monitor.Page_Object;

namespace Thin_Monitor.Work_Flow
{
    class Confidence_1
    {
        static ExtentTest test = ExtentReport.ReportStart("Confidences Phase-1", " Adding Column ");

        public void addcolumn(IWebDriver driver)
        {

            Monitor mon = new Monitor(driver);


            // Adding 11th Column
            mon.plus_btn.Click();
            Actions act_col11 = new Actions(driver);
            act_col11.MoveToElement(mon.Coll_11).DoubleClick().Click().SendKeys("TR.PricePctChgYTD ").SendKeys(Keys.Enter).Build().Perform();
            ExtentReport.ReportLog(test, "Pass", "Add Column With " + mon.Coll_11.Text, driver);





            // Adding 12th Column
            mon.plus_btn.Click();
            Actions act_col12 = new Actions(driver);
            act_col12.MoveToElement(mon.Coll_12).DoubleClick().Click().SendKeys("TR.Price52WeekHighDate").SendKeys(Keys.Enter).Build().Perform();
            ExtentReport.ReportLog(test, "Pass", "Add Column With " + mon.Coll_12.Text, driver);




            // Adding 13th Column
            mon.plus_btn.Click();
            Actions act_col13 = new Actions(driver);
            act_col13.MoveToElement(mon.Coll_13).DoubleClick().Click().SendKeys("TR.CompanyMarketCap").SendKeys(Keys.Enter).Build().Perform();
            ExtentReport.ReportLog(test, "Pass", "Add Column With " + mon.Coll_13.Text, driver);



            // Adding 14th Column
            mon.plus_btn.Click();
            Actions act_col14 = new Actions(driver);
            act_col14.MoveToElement(mon.Coll_14).DoubleClick().Click().SendKeys("CF_VOLUME").SendKeys(Keys.Enter).Build().Perform();
            ExtentReport.ReportLog(test, "Pass", "Add Column With " + mon.Coll_14.Text, driver);



            ExtentReport.ReportStop(test);
        }
    }
}
