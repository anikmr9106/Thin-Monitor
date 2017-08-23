using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
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

            Page_Object.Monitor mon = new Page_Object.Monitor(driver);

            try
            {
                // Adding 11th Column
                mon.plus_btn.Click();
                Actions act_col11 = new Actions(driver);
                act_col11.MoveToElement(mon.Col_11).DoubleClick().Click().SendKeys("TR.PricePctChgYTD ").SendKeys(Keys.Enter).Build().Perform();
                ExtentReport.ReportLog(test, "Pass", "Add Column With " + mon.Col_11.Text, driver);
            }
            catch
            {
                ExtentReport.ReportLog(test, "Fail", "Not Able to Add Column 11", driver);
            }

            try
            {
                // Adding 12th Column
                mon.plus_btn.Click();
                Actions act_col12 = new Actions(driver);
                act_col12.MoveToElement(mon.Col_12).DoubleClick().Click().SendKeys("TR.Price52WeekHighDate").SendKeys(Keys.Enter).Build().Perform();
                ExtentReport.ReportLog(test, "Pass", "Add Column With " + mon.Col_12.Text, driver);
            }
            catch
            {
                ExtentReport.ReportLog(test, "Fail", "Not Able to Add Column 12", driver);
            }


            try
            {
                // Adding 13th Column
                mon.plus_btn.Click();
                Actions act_col13 = new Actions(driver);
                act_col13.MoveToElement(mon.Col_13).DoubleClick().Click().SendKeys("TR.CompanyMarketCap").SendKeys(Keys.Enter).Build().Perform();
                ExtentReport.ReportLog(test, "Pass", "Add Column With " + mon.Col_13.Text, driver);
            }
            catch
            {
                ExtentReport.ReportLog(test, "Fail", "Not Able to Add Column 13", driver);
            }

            try
            {
                // Adding 14th Column
                mon.plus_btn.Click();
                Actions act_col14 = new Actions(driver);
                act_col14.MoveToElement(mon.Col_14).DoubleClick().Click().SendKeys("CF_VOLUME").SendKeys(Keys.Enter).Build().Perform();
                ExtentReport.ReportLog(test, "Pass", "Add Column With " + mon.Col_14.Text, driver);
            }

            catch
            {
                ExtentReport.ReportLog(test, "Fail", "Not Able to Add Column 14", driver);
            }

            try
            {
                //Adding RICs
                Actions act_row0 = new Actions(driver);
                act_row0.MoveToElement(mon.sec_row).DoubleClick().Click().SendKeys("BNPP.PA").SendKeys(Keys.Enter).Build().Perform();
                ExtentReport.ReportLog(test, "Pass", " Add RIC" + mon.sec_row.Text, driver);
            }

            catch
            {
                ExtentReport.ReportLog(test, "Fail", "Not Able to Add RIC", driver);
            }

            try
            {
                //Adding RICs
                Actions act_row1 = new Actions(driver);
                act_row1.MoveToElement(mon.third_row).DoubleClick().Click().SendKeys("FB.O").SendKeys(Keys.Enter).Build().Perform();
                ExtentReport.ReportLog(test, "Pass", "Add RIC " + mon.third_row.Text, driver);

            }
            catch
            {
                ExtentReport.ReportLog(test, "Fail", "Not Able to Add RIC", driver);
            }

            try
            {
                //Adding Chain
                Actions act_row2 = new Actions(driver);
                act_row2.MoveToElement(mon.Fourth_row).DoubleClick().Click().SendKeys(".FTSE").SendKeys(Keys.Enter).Build().Perform();
                ExtentReport.ReportLog(test, "Pass", "Add Chain" + mon.Fourth_row.Text, driver);
            }

            catch
            {
                ExtentReport.ReportLog(test, "Fail", "Not Able to Add Chain", driver);
            }

            try
            {
                //Adding Chain
                Actions act_row3 = new Actions(driver);
                act_row3.MoveToElement(mon.Fifth_row).DoubleClick().Click().SendKeys(".FCHI").SendKeys(Keys.Enter).Build().Perform();
                ExtentReport.ReportLog(test, "Pass", "Add Chain" + mon.Fifth_row.Text, driver);

            }
            catch
            {
                ExtentReport.ReportLog(test, "Fail", "Not Able to Add Chain", driver);
            }

            try
            {
                //Expanding Chain
                Actions act_row4 = new Actions(driver);
                Thread.Sleep(TimeSpan.FromSeconds(3));
                act_row4.MoveToElement(mon.Fifth_row_Expand).Click().Build().Perform();
                ExtentReport.ReportLog(test, "Pass", ".FCHI Expanded", driver);
            }

            catch
            {
                ExtentReport.ReportLog(test, "Fail", "Not Able to Expand the Chain", driver);
            }

            try
            {
                //Expanding Chain
                Actions act_row5 = new Actions(driver);
                act_row5.MoveToElement(mon.fourth_row_Expand).Click().Build().Perform();
                ExtentReport.ReportLog(test, "Pass", ".FTSE Chain Expanded", driver);
            }
            catch
            {
                ExtentReport.ReportLog(test, "Fail", "Not Able to Expand the Chain", driver);
            }

            try
            {
                //Adding Multi Table
                mon.setting_btn.Click();
                Actions act_Multi = new Actions(driver);
                act_Multi.MoveToElement(mon.Multitable).MoveToElement(mon.twotable).Click().Build().Perform();

                ExtentReport.ReportLog(test, "Pass", "Table Two Added", driver);
            }
            catch
            {
                ExtentReport.ReportLog(test, "Fail", "Not Able to Added Table Two", driver);
            }

            try
            {
                //Adding Group Header and adding RICs
                Actions act_row = new Actions(driver);
                act_row.MoveToElement(mon.table2_row_3).DoubleClick().Click().SendKeys("'Group Header").SendKeys(Keys.Enter).Build().Perform();
                ExtentReport.ReportLog(test, "Pass", "Addded Header by name " + mon.table2_row_3.Text, driver);
                DataTable table = Excellib.ExceltoDataTable(MyPath.loginDataFile);
                int count = Excellib.getrowcount(table);
                Excellib.popuateInCollection(MyPath.loginDataFile);
                string part1 = "//*[@id='section3']/div/div[2]/div[";
                string part2 = "]/div";
                for(int i=4;i<count;i++)
                {
                    string fullpath = part1 + i + part2;
                    Actions act_rowi = new Actions(driver);
                    act_rowi.MoveToElement(driver.FindElement(By.XPath(fullpath))).DoubleClick().Click().SendKeys(Excellib.ReadData(i,"RIC")).SendKeys(Keys.Enter).Build().Perform();
                }

                ExtentReport.ReportLog(test, "Pass", "Added RICs Under the"+mon.table2_row_3.Text, driver);
            }
            catch
            {
               ExtentReport.ReportLog(test, "Fail", "Did not added Header", driver);
            }

            try
            {
                //Adding Portfolio
                mon.main_combobox.Click();
                Actions act_port = new Actions(driver);
                act_port.MoveToElement(mon.main_addportfoliolist).Click().Build().Perform();
                Thread.Sleep(TimeSpan.FromSeconds(7));
                mon.portfolio_search_textbox.SendKeys("test_portfolio_sharing");
                mon.portfoilio_result_1.Click();
                mon.portfoilio_okbtn.Click();

                ExtentReport.ReportLog(test, "Pass", "Portfolio Added", driver);
            }

            catch
            {
                ExtentReport.ReportLog(test, "Fail", "Not Added Portfolio", driver);
            }

            ExtentReport.ReportStop(test);
        }
    }
}
