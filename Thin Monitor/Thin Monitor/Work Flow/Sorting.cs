using NUnit.Framework;
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
    class Sorting
    {
        static ExtentTest test = ExtentReport.ReportStart("Sorting Column", " ");

        public void sort_column(IWebDriver driver)
        {
            Page_Object.Monitor mon = new Page_Object.Monitor(driver);

            Thread.Sleep(TimeSpan.FromSeconds(5));
            try
            {
                //Adding RICs
                mon.main_combobox.Click();
                Actions act_port = new Actions(driver);
                act_port.MoveToElement(mon.mon_new).Click().Build().Perform();
                Thread.Sleep(TimeSpan.FromSeconds(7));
                string part1 = "//*[@id='section1']/div/div[2]/div[";
                string part2 = "]/div";
                int i = 1;
                foreach (string j in DataList.RICsList())
                {
                    string fullpath = part1 + i + part2;
                    Actions act_rowi = new Actions(driver);
                    act_rowi.MoveToElement(driver.FindElement(By.XPath(fullpath))).DoubleClick().Click().SendKeys(j).SendKeys(Keys.Enter).Build().Perform();
                    i++;
                }

                // Ascending Order Sorting 
                Actions act_sort = new Actions(driver);
                act_sort.MoveToElement(mon.Col_7).ContextClick().Build().Perform();
                Thread.Sleep(TimeSpan.FromSeconds(5));
                driver.SwitchTo().DefaultContent();
                Thread.Sleep(TimeSpan.FromSeconds(5));
                driver.SwitchTo().Frame("AppFrame");
                driver.SwitchTo().Frame("internal");
                driver.SwitchTo().Frame("AppFrame");
                Actions act_sort1 = new Actions(driver);
                act_sort1.MoveToElement(mon.contextclick_sort_asce).Build().Perform();
                act_sort1.Click();
                Thread.Sleep(TimeSpan.FromSeconds(2));
                Actions act_sort2 = new Actions(driver);
                act_sort2.MoveToElement(mon.contextclick_sort_asce_everyone).Build().Perform();
                act_sort2.Click().Build().Perform();
                Thread.Sleep(TimeSpan.FromSeconds(5));
                driver.SwitchTo().DefaultContent();
                driver.SwitchTo().Frame("AppFrame");
                driver.SwitchTo().Frame("internal");
                driver.SwitchTo().Frame("AppFrame");
                driver.SwitchTo().Frame("EikonNowMarker");
                driver.SwitchTo().Frame("AppFrame");
                Assert.Greater(mon.row1_col7.Text, mon.row2_col7.Text);
                ExtentReport.ReportLog(test, "Pass", "Sorted in Ascending order", driver);
            }

            catch
            {
                ExtentReport.ReportLog(test, "Fail", "Selected Column is Sorted in Ascending order Failed", driver);
            }

            try
            {
                Actions act_sort = new Actions(driver);
                act_sort.MoveToElement(mon.Col_7).ContextClick().Build().Perform();
                Thread.Sleep(TimeSpan.FromSeconds(5));
                driver.SwitchTo().DefaultContent();
                Thread.Sleep(TimeSpan.FromSeconds(5));
                driver.SwitchTo().Frame("AppFrame");
                driver.SwitchTo().Frame("internal");
                driver.SwitchTo().Frame("AppFrame");
                Actions act_sort1 = new Actions(driver);
                act_sort1.MoveToElement(mon.contextclick_sort_desc).Build().Perform();
                act_sort1.Click();
                Thread.Sleep(TimeSpan.FromSeconds(2));
                Actions act_sort2 = new Actions(driver);
                act_sort2.MoveToElement(mon.contextclick_sort_desc_everyone).Build().Perform();
                act_sort2.Click().Build().Perform();
                Thread.Sleep(TimeSpan.FromSeconds(5));
                driver.SwitchTo().DefaultContent();
                driver.SwitchTo().Frame("AppFrame");
                driver.SwitchTo().Frame("internal");
                driver.SwitchTo().Frame("AppFrame");
                driver.SwitchTo().Frame("EikonNowMarker");
                driver.SwitchTo().Frame("AppFrame");
                Assert.Less(mon.row1_col7.Text, mon.row2_col7.Text);
                ExtentReport.ReportLog(test, "Pass", "Column is Sorted in Descending order", driver);
            }

            catch
            {
                ExtentReport.ReportLog(test, "Fail", "Sorted in Descending order Failed", driver);
            }

            ExtentReport.ReportStop(test);

            Thread.Sleep(TimeSpan.FromSeconds(5));
        }

        }
    }
