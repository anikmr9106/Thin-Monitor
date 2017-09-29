using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Thin_Monitor.Common;

namespace Thin_Monitor.Work_Flow
{
    class GroupHeader
    {
        static ExtentTest test = ExtentReport.ReportStart("Group Header", " ");

        public void groupheader(IWebDriver driver)
        {
            Page_Object.Monitor mon = new Page_Object.Monitor(driver);

            try
            {
                //Adding RICs
                mon.main_combobox.Click();
                Actions act_port = new Actions(driver);
                act_port.MoveToElement(mon.mon_new).Click().Build().Perform();
                Thread.Sleep(TimeSpan.FromSeconds(7));
                Actions GH = new Actions(driver);
                GH.MoveToElement(mon.sec_row).DoubleClick().Click().SendKeys("'Group Header").SendKeys(Keys.Enter).Build().Perform();
                string part1 = "//*[@id='section3']/div/div[2]/div[";
                string part2 = "]/div";
                int i = 3;
                foreach (string j in DataList.RICsList())
                {
                    string fullpath = part1 + i + part2;
                    Actions act_rowi = new Actions(driver);
                    act_rowi.MoveToElement(driver.FindElement(By.XPath(fullpath))).DoubleClick().Click().SendKeys(j).SendKeys(Keys.Enter).Build().Perform();
                    i++;
                }
                ExtentReport.ReportLog(test, "Pass", "RICs Added under the group header", driver);
            }
           
            catch
            {
                ExtentReport.ReportLog(test, "Fail", "Fail to add RICs", driver);
            }

            try
            {
                Thread.Sleep(TimeSpan.FromSeconds(3));
                mon.GH_Row2_table1.Click();
                Thread.Sleep(TimeSpan.FromSeconds(2));
                mon.GH_Classifyby_btn.Click();
                Thread.Sleep(TimeSpan.FromSeconds(2));
                Actions GHaction = new Actions(driver);
                GHaction.MoveToElement(mon.GH_Classifyby_item4).DoubleClick().Build().Perform();
                Thread.Sleep(TimeSpan.FromSeconds(2));
                mon.GH_Classifyby_okbtn.Click();
                ExtentReport.ReportLog(test, "Pass", "Classified Successfully", driver);
            }

            catch
            {
                ExtentReport.ReportLog(test, "Fail", "Fail to Classify", driver);
            }

            ExtentReport.ReportStop(test);

            Thread.Sleep(TimeSpan.FromSeconds(5));
        }
    }
}

