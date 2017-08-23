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
    class AutoHide
    {
        static ExtentTest test = ExtentReport.ReportStart("Auto Hide", "Validating Auto Hide Functionality");

        public void auto_hide(IWebDriver driver)
        {
            Page_Object.Monitor mon = new Page_Object.Monitor(driver);

            try
            {
                mon.main_combobox.Click();
                Actions act_port = new Actions(driver);
                act_port.MoveToElement(mon.mon_new).Click().Build().Perform();
                Thread.Sleep(TimeSpan.FromSeconds(7));
                DataTable table = Excellib.ExceltoDataTable(MyPath.loginDataFile);
                int count = Excellib.getrowcount(table);
                Excellib.popuateInCollection(MyPath.loginDataFile);
                string part1 = "//*[@id='section1']/div/div[2]/div[";
                string part2 = "]/div";
                for (int i = 1; i <= 20; i++)
                {
                    string fullpath = part1 + i + part2;
                    Actions act_rowi = new Actions(driver);
                    act_rowi.MoveToElement(driver.FindElement(By.XPath(fullpath))).DoubleClick().Click().SendKeys(Excellib.ReadData(i, "RIC")).SendKeys(Keys.Enter).Build().Perform();
                }

                Thread.Sleep(TimeSpan.FromSeconds(5));
                mon.setting_btn.Click();
                mon.perference.Click();
                mon.perference_miscellaneous.Click();
                mon.autohide_checkbox.Click();
                mon.perference_okbtn.Click();
                ExtentReport.ReportLog(test, "Pass", "Command bar Auto hide successfully", driver);
            }
            catch
            {
                ExtentReport.ReportLog(test, "Fail", "Fail to Auto Hide", driver);
            }

            try
            {
                Actions act = new Actions(driver);
                act.MoveToElement(mon.autohide_bar).Build().Perform();
                Thread.Sleep(TimeSpan.FromSeconds(5));
                mon.setting_btn.Click();
                mon.perference.Click();
                mon.perference_miscellaneous.Click();
                mon.autohide_checkbox.Click();
                mon.perference_okbtn.Click();
                ExtentReport.ReportLog(test, "Pass", "Command bar Auto hide successfully", driver);
            }

            catch
            {
                ExtentReport.ReportLog(test, "Fail", "Fail to Auto Hide", driver);
            }

            ExtentReport.ReportStop(test);
        }
    }

}
