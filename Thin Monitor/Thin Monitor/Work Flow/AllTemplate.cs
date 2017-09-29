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
    class AllTemplate
    {
        static ExtentTest test = ExtentReport.ReportStart("All Template", "Validating All Template Functionality");

        public void alltemplate(IWebDriver driver)
        {
            Page_Object.Monitor mon = new Page_Object.Monitor(driver);

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

            try
            {
                //Portfolio Template
                Thread.Sleep(TimeSpan.FromSeconds(5));
                mon.setting_btn.Click();
                Actions act_template1 = new Actions(driver);
                act_template1.MoveToElement(mon.cog_menu_columnTemplate)
                    .MoveToElement(mon.cog_menu_Asset_Management).MoveToElement(mon.cog_menu_Asset_Management_Portfolio).Click().Build().Perform();

                ExtentReport.ReportLog(test, "Pass", "Portfolio Template selected Under Asset Management", driver);
            }

            catch
            {
                ExtentReport.ReportLog(test, "Fail", "Fail to add Portfolio Template selected Under Asset Management", driver);
            }

            try
            {
                //Portfolio (Cost Basis)
                Thread.Sleep(TimeSpan.FromSeconds(5));

                mon.setting_btn.Click();
                Actions act_template2 = new Actions(driver);
                act_template2.MoveToElement(mon.cog_menu_columnTemplate)
                    .MoveToElement(mon.cog_menu_Asset_Management).MoveToElement(mon.cog_menu_Asset_Management_Portfolio_Cost_Basis).Click().Build().Perform();

                ExtentReport.ReportLog(test, "Pass", "Portfolio(Cost Basis) Template selected Under Asset Management", driver);
            }

            catch
            {
                ExtentReport.ReportLog(test, "Fail", "Fail to add Portfolio(Cost Basis) Template selected Under Asset Management", driver);
            }

            try
            {
                //Prop Data - Price Performance
                Thread.Sleep(TimeSpan.FromSeconds(5));

                mon.setting_btn.Click();
                Actions act_template3 = new Actions(driver);
                act_template3.MoveToElement(mon.cog_menu_columnTemplate)
                    .MoveToElement(mon.cog_menu_Asset_Management).MoveToElement(mon.cog_menu_Asset_Management_Prop_Data_Price).Click().Build().Perform();

                ExtentReport.ReportLog(test, "Pass", "Prop Data - Price Performance Template selected Under Asset Management", driver);

            }

            catch
            {

                ExtentReport.ReportLog(test, "Fail", "Fail to add Prop Data - Price Performance Template selected Under Asset Management", driver);
            }

            try
            {
                //Prop Data - Earning
                Thread.Sleep(TimeSpan.FromSeconds(5));

                mon.setting_btn.Click();
                Actions act_template4 = new Actions(driver);
                act_template4.MoveToElement(mon.cog_menu_columnTemplate)
                    .MoveToElement(mon.cog_menu_Asset_Management).MoveToElement(mon.cog_menu_Asset_Management_Prop_Data_Earning).Click().Build().Perform();

                ExtentReport.ReportLog(test, "Pass", "Prop Data - Earning Template selected Under Asset Management ", driver);
            }

            catch
            {
                ExtentReport.ReportLog(test, "Fail", "Fail to add Prop Data - Earning Template selected Under Asset Management", driver);
            }

            try
            {
                //Banking & Research --> Comprehensive
                Thread.Sleep(TimeSpan.FromSeconds(5));

                mon.setting_btn.Click();
                Actions act_template5 = new Actions(driver);
                act_template5.MoveToElement(mon.cog_menu_columnTemplate)
                    .MoveToElement(mon.cog_menu_Banking_Research).MoveToElement(mon.cog_menu_Banking_Research_Comprehensive).Click().Build().Perform();

                ExtentReport.ReportLog(test, "Pass", "Comprehensive Template Selected Under Banking and Research", driver);
            }

            catch
            {
                ExtentReport.ReportLog(test, "Fail", "Fail to add Comprehensive Template selected Under Asset Management", driver);
            }

            try
            {
                //Banking & Research --> Comparables
                Thread.Sleep(TimeSpan.FromSeconds(5));

                mon.setting_btn.Click();
                Actions act_template6 = new Actions(driver);
                act_template6.MoveToElement(mon.cog_menu_columnTemplate)
                    .MoveToElement(mon.cog_menu_Banking_Research).MoveToElement(mon.cog_menu_Banking_Research_Comparables).Click().Build().Perform();

                ExtentReport.ReportLog(test, "Pass", "Comparables Template Selected Under Banking and Research", driver);
            }

            catch
            {
                ExtentReport.ReportLog(test, "Fail", "Fail to add Comparables Template selected Under Asset Management", driver);
            }

            try
            {
                //Banking & Research --> Asset Manager
                Thread.Sleep(TimeSpan.FromSeconds(5));

                mon.setting_btn.Click();
                Actions act_template7 = new Actions(driver);
                act_template7.MoveToElement(mon.cog_menu_columnTemplate)
                    .MoveToElement(mon.cog_menu_Banking_Research).MoveToElement(mon.cog_menu_Banking_Asset_Management).Click().Build().Perform();

                ExtentReport.ReportLog(test, "Pass", "Asset Manager Template Selected Under Banking and Research", driver);
            }

            catch
            {
                ExtentReport.ReportLog(test, "Fail", "Fail to add Asset Manager Template selected Under Asset Management", driver);
            }

            try
            {
                //Banking & Research --> Banks and Specialist Finance
                Thread.Sleep(TimeSpan.FromSeconds(5));

                mon.setting_btn.Click();
                Actions act_template8 = new Actions(driver);
                act_template8.MoveToElement(mon.cog_menu_columnTemplate)
                    .MoveToElement(mon.cog_menu_Banking_Research).MoveToElement(mon.cog_menu_Banking_Banks_Specialist).Click().Build().Perform();

                ExtentReport.ReportLog(test, "Pass", "Banks and Specialist Finance Template Selected Under Banking and Research", driver);
            }

            catch
            {
                ExtentReport.ReportLog(test, "Fail", "Fail to add Banks and Specialist Finance Template selected Under Asset Management", driver);
            }

            try
            {
                //Banking & Research --> Financial Services
                Thread.Sleep(TimeSpan.FromSeconds(5));

                mon.setting_btn.Click();
                Actions act_template9 = new Actions(driver);
                act_template9.MoveToElement(mon.cog_menu_columnTemplate)
                    .MoveToElement(mon.cog_menu_Banking_Research).MoveToElement(mon.cog_menu_Banking_Financial_Service).Click().Build().Perform();

                ExtentReport.ReportLog(test, "Pass", "Financial Services Template Selected Under Banking and Research", driver);
            }

            catch
            {
                ExtentReport.ReportLog(test, "Fail", "Fail to add Financial Services Template selected Under Asset Management", driver);
            }

            try
            {
                //Banking & Research --> Insurance
                Thread.Sleep(TimeSpan.FromSeconds(5));

                mon.setting_btn.Click();
                Actions act_template10 = new Actions(driver);
                act_template10.MoveToElement(mon.cog_menu_columnTemplate)
                    .MoveToElement(mon.cog_menu_Banking_Research).MoveToElement(mon.cog_menu_Banking_Insurance).Click().Build().Perform();

                ExtentReport.ReportLog(test, "Pass", "Insurance Template Selected Under Banking and Research", driver);
            }

            catch
            {
                ExtentReport.ReportLog(test, "Fail", "Fail to add Insurance Template selected Under Asset Management", driver);
            }

            //Banking & Research --> Oil and Gas
            Thread.Sleep(TimeSpan.FromSeconds(5));

            mon.setting_btn.Click();
            Actions act_template11 = new Actions(driver);
            act_template11.MoveToElement(mon.cog_menu_columnTemplate)
                .MoveToElement(mon.cog_menu_Banking_Research).MoveToElement(mon.cog_menu_Banking_Oil_Gas).Click().Build().Perform();

            ExtentReport.ReportLog(test, "Pass", "Oil and Gas Template Selected Under Banking and Research", driver);

            //Banking & Research --> Trading Multiples
            Thread.Sleep(TimeSpan.FromSeconds(5));

            mon.setting_btn.Click();
            Actions act_template12 = new Actions(driver);
            act_template12.MoveToElement(mon.cog_menu_columnTemplate)
                .MoveToElement(mon.cog_menu_Banking_Research).MoveToElement(mon.cog_menu_Banking_Trading_Multiples).Click().Build().Perform();

            ExtentReport.ReportLog(test, "Pass", "Trading Multiples Template Selected Under Banking and Research", driver);

            //Bonds --> Bonds
            Thread.Sleep(TimeSpan.FromSeconds(5));

            mon.setting_btn.Click();
            Actions act_template13 = new Actions(driver);
            act_template13.MoveToElement(mon.cog_menu_columnTemplate)
                .MoveToElement(mon.cog_menu_Bonds).MoveToElement(mon.cog_menu_Bonds_Bonds).Click().Build().Perform();

            ExtentReport.ReportLog(test, "Pass", "Bonds Template Selected Under Bonds", driver);

            //Bonds --> CoCo
            Thread.Sleep(TimeSpan.FromSeconds(5));

            mon.setting_btn.Click();
            Actions act_template14 = new Actions(driver);
            act_template14.MoveToElement(mon.cog_menu_columnTemplate)
                .MoveToElement(mon.cog_menu_Bonds).MoveToElement(mon.cog_menu_Bonds_CoCo).Click().Build().Perform();

            ExtentReport.ReportLog(test, "Pass", "CoCo Template Selected Under Bonds", driver);

            //Bonds --> Convertible
            Thread.Sleep(TimeSpan.FromSeconds(5));

            mon.setting_btn.Click();
            Actions act_template15 = new Actions(driver);
            act_template15.MoveToElement(mon.cog_menu_columnTemplate)
                .MoveToElement(mon.cog_menu_Bonds).MoveToElement(mon.cog_menu_Bonds_Convertible).Click().Build().Perform();

            ExtentReport.ReportLog(test, "Pass", "Convertible Template Selected Under Bonds", driver);

            //Equity --> Equity
            Thread.Sleep(TimeSpan.FromSeconds(5));

            mon.setting_btn.Click();
            Actions act_template16 = new Actions(driver);
            act_template16.MoveToElement(mon.cog_menu_columnTemplate)
                .MoveToElement(mon.cog_menu_Equity).MoveToElement(mon.cog_menu_Equity_Equity).Click().Build().Perform();

            ExtentReport.ReportLog(test, "Pass", "Equity Template Selected Under Equity", driver);

            //Equity --> Earning
            Thread.Sleep(TimeSpan.FromSeconds(5));

            mon.setting_btn.Click();
            Actions act_template17 = new Actions(driver);
            act_template17.MoveToElement(mon.cog_menu_columnTemplate)
                .MoveToElement(mon.cog_menu_Equity).MoveToElement(mon.cog_menu_Equity_Earning).Click().Build().Perform();

            ExtentReport.ReportLog(test, "Pass", "Earning Template Selected Under Equity", driver);

            //Equity --> HiLo
            Thread.Sleep(TimeSpan.FromSeconds(5));

            mon.setting_btn.Click();
            Actions act_template18 = new Actions(driver);
            act_template18.MoveToElement(mon.cog_menu_columnTemplate)
                .MoveToElement(mon.cog_menu_Equity).MoveToElement(mon.cog_menu_Equity_HiLo).Click().Build().Perform();

            ExtentReport.ReportLog(test, "Pass", "HiLo Template Selected Under Equity", driver);

            //Equity --> PricePerf
            Thread.Sleep(TimeSpan.FromSeconds(5));

            mon.setting_btn.Click();
            Actions act_template19 = new Actions(driver);
            act_template19.MoveToElement(mon.cog_menu_columnTemplate)
                .MoveToElement(mon.cog_menu_Equity).MoveToElement(mon.cog_menu_Equity_PricePerf).Click().Build().Perform();

            ExtentReport.ReportLog(test, "Pass", "PricePerf Template Selected Under Equity", driver);

            //Equity --> Premarket Stats
            Thread.Sleep(TimeSpan.FromSeconds(5));

            mon.setting_btn.Click();
            Actions act_template20 = new Actions(driver);
            act_template20.MoveToElement(mon.cog_menu_columnTemplate)
                .MoveToElement(mon.cog_menu_Equity).MoveToElement(mon.cog_menu_Equity_Premarket_Stats).Click().Build().Perform();

            ExtentReport.ReportLog(test, "Pass", "Premarket Stats Template Selected Under Equity", driver);

            //Equity --> Regular Hours
            Thread.Sleep(TimeSpan.FromSeconds(5));

            mon.setting_btn.Click();
            Actions act_template21 = new Actions(driver);
            act_template21.MoveToElement(mon.cog_menu_columnTemplate)
                .MoveToElement(mon.cog_menu_Equity).MoveToElement(mon.cog_menu_Equity_Regular_Hours).Click().Build().Perform();

            ExtentReport.ReportLog(test, "Pass", "Regular Hours Template Selected Under Equity", driver);

            //Equity --> Aftermkt Stats
            Thread.Sleep(TimeSpan.FromSeconds(5));

            mon.setting_btn.Click();
            Actions act_template22 = new Actions(driver);
            act_template22.MoveToElement(mon.cog_menu_columnTemplate)
                .MoveToElement(mon.cog_menu_Equity).MoveToElement(mon.cog_menu_Equity_Aftermkt_Stats).Click().Build().Perform();

            ExtentReport.ReportLog(test, "Pass", "Aftermkt Stats Template Selected Under Equity", driver);

            //Funds --> Fund Performance CHF
            Thread.Sleep(TimeSpan.FromSeconds(5));

            mon.setting_btn.Click();
            Actions act_template23 = new Actions(driver);
            act_template23.MoveToElement(mon.cog_menu_columnTemplate)
                .MoveToElement(mon.cog_menu_Funds).MoveToElement(mon.cog_menu_Funds_Fund_PerformanceCHF).Click().Build().Perform();

            ExtentReport.ReportLog(test, "Pass", "Fund Performance CHF Template Selected Under Funds", driver);

            //Funds --> Fund Performance EUR
            Thread.Sleep(TimeSpan.FromSeconds(5));

            mon.setting_btn.Click();
            Actions act_template24 = new Actions(driver);
            act_template24.MoveToElement(mon.cog_menu_columnTemplate)
                .MoveToElement(mon.cog_menu_Funds).MoveToElement(mon.cog_menu_Funds_Fund_PerformanceEUR).Click().Build().Perform();

            ExtentReport.ReportLog(test, "Pass", "Fund Performance EUR Template Selected Under Funds", driver);

            //Funds --> Fund Performance GBP
            Thread.Sleep(TimeSpan.FromSeconds(5));

            mon.setting_btn.Click();
            Actions act_template25 = new Actions(driver);
            act_template25.MoveToElement(mon.cog_menu_columnTemplate)
                .MoveToElement(mon.cog_menu_Funds).MoveToElement(mon.cog_menu_Funds_Fund_PerformanceGBP).Click().Build().Perform();

            ExtentReport.ReportLog(test, "Pass", "Fund Performance GBP Template Selected Under Funds", driver);

            //Funds --> Fund Performance JPY
            Thread.Sleep(TimeSpan.FromSeconds(5));

            mon.setting_btn.Click();
            Actions act_template26 = new Actions(driver);
            act_template26.MoveToElement(mon.cog_menu_columnTemplate)
                .MoveToElement(mon.cog_menu_Funds).MoveToElement(mon.cog_menu_Funds_Fund_PerformanceJPY).Click().Build().Perform();

            ExtentReport.ReportLog(test, "Pass", "Fund Performance JPY Template Selected Under Funds", driver);

            //Funds --> Fund Performance USD
            Thread.Sleep(TimeSpan.FromSeconds(5));

            mon.setting_btn.Click();
            Actions act_template27 = new Actions(driver);
            act_template27.MoveToElement(mon.cog_menu_columnTemplate)
                .MoveToElement(mon.cog_menu_Funds).MoveToElement(mon.cog_menu_Funds_Fund_PerformanceUSD).Click().Build().Perform();

            ExtentReport.ReportLog(test, "Pass", "Fund Performance USD Template Selected Under Funds", driver);

            //Funds --> Fund Performance Fund Currency
            Thread.Sleep(TimeSpan.FromSeconds(5));

            mon.setting_btn.Click();
            Actions act_template28 = new Actions(driver);
            act_template28.MoveToElement(mon.cog_menu_columnTemplate)
                .MoveToElement(mon.cog_menu_Funds).MoveToElement(mon.cog_menu_Funds_Fund_Performance_FundCurrency).Click().Build().Perform();

            ExtentReport.ReportLog(test, "Pass", "Fund Performance Fund Currency Template Selected Under Funds", driver);

            //Funds --> Fund 1 Year Risk
            Thread.Sleep(TimeSpan.FromSeconds(5));

            mon.setting_btn.Click();
            Actions act_template29 = new Actions(driver);
            act_template29.MoveToElement(mon.cog_menu_columnTemplate)
                .MoveToElement(mon.cog_menu_Funds).MoveToElement(mon.cog_menu_Funds_Fund_1YearRisk).Click().Build().Perform();

            ExtentReport.ReportLog(test, "Pass", "Fund 1 Year Risk Template Selected Under Funds", driver);

            //Funds --> Fund 3 Year Risk
            Thread.Sleep(TimeSpan.FromSeconds(5));

            mon.setting_btn.Click();
            Actions act_template30 = new Actions(driver);
            act_template30.MoveToElement(mon.cog_menu_columnTemplate)
                .MoveToElement(mon.cog_menu_Funds).MoveToElement(mon.cog_menu_Funds_Fund_3YearRisk).Click().Build().Perform();

            ExtentReport.ReportLog(test, "Pass", "Fund 3 Year Risk Template Selected Under Funds", driver);

            //Funds --> Fund 5 Year Risk
            Thread.Sleep(TimeSpan.FromSeconds(5));

            mon.setting_btn.Click();
            Actions act_template31 = new Actions(driver);
            act_template31.MoveToElement(mon.cog_menu_columnTemplate)
                .MoveToElement(mon.cog_menu_Funds).MoveToElement(mon.cog_menu_Funds_Fund_5YearRisk).Click().Build().Perform();

            ExtentReport.ReportLog(test, "Pass", "Fund 5 Year Risk Template Selected Under Funds", driver);

            //Funds --> Fund 10 Year Risk
            Thread.Sleep(TimeSpan.FromSeconds(5));

            mon.setting_btn.Click();
            Actions act_template32 = new Actions(driver);
            act_template32.MoveToElement(mon.cog_menu_columnTemplate)
                .MoveToElement(mon.cog_menu_Funds).MoveToElement(mon.cog_menu_Funds_Fund_10YearRisk).Click().Build().Perform();

            ExtentReport.ReportLog(test, "Pass", "Fund 10 Year Risk Template Selected Under Funds", driver);

            //Funds --> Fund Overview
            Thread.Sleep(TimeSpan.FromSeconds(5));

            mon.setting_btn.Click();
            Actions act_template33 = new Actions(driver);
            act_template33.MoveToElement(mon.cog_menu_columnTemplate)
                .MoveToElement(mon.cog_menu_Funds).MoveToElement(mon.cog_menu_Funds_Fund_Overview).Click().Build().Perform();

            ExtentReport.ReportLog(test, "Pass", "Fund Overview Template Selected Under Funds", driver);

            //Funds --> Fund Latesh Price and Total Net Asset
            Thread.Sleep(TimeSpan.FromSeconds(5));

            mon.setting_btn.Click();
            Actions act_template34 = new Actions(driver);
            act_template34.MoveToElement(mon.cog_menu_columnTemplate)
                .MoveToElement(mon.cog_menu_Funds).MoveToElement(mon.cog_menu_Funds_FundLatestPriceTotalNetAssets).Click().Build().Perform();

            ExtentReport.ReportLog(test, "Pass", "Fund Latesh Price and Total Net Asset Template Selected Under Funds", driver);

            //Funds --> Fund Lipper Leader Ratings Overall
            Thread.Sleep(TimeSpan.FromSeconds(5));

            mon.setting_btn.Click();
            Actions act_template35 = new Actions(driver);
            act_template35.MoveToElement(mon.cog_menu_columnTemplate)
                .MoveToElement(mon.cog_menu_Funds).MoveToElement(mon.cog_menu_Funds_FundLipperLeaderRatingsOverall).Click().Build().Perform();

            ExtentReport.ReportLog(test, "Pass", "Fund Lipper Leader Ratings Overall Template Selected Under Funds", driver);

            //Funds --> Fund Lipper Leader Ratings 3 Year
            Thread.Sleep(TimeSpan.FromSeconds(5));

            mon.setting_btn.Click();
            Actions act_template36 = new Actions(driver);
            act_template36.MoveToElement(mon.cog_menu_columnTemplate)
                .MoveToElement(mon.cog_menu_Funds).MoveToElement(mon.cog_menu_Funds_FundLipperLeaderRatings3Year).Click().Build().Perform();

            ExtentReport.ReportLog(test, "Pass", "Fund Lipper Leader Ratings - 3 Year Template Selected Under Funds", driver);

            //Funds --> Fund Lipper Leader Ratings 5 Year
            Thread.Sleep(TimeSpan.FromSeconds(5));

            mon.setting_btn.Click();
            Actions act_template37 = new Actions(driver);
            act_template37.MoveToElement(mon.cog_menu_columnTemplate)
                .MoveToElement(mon.cog_menu_Funds).MoveToElement(mon.cog_menu_Funds_FundLipperLeaderRatings5Year).Click().Build().Perform();

            ExtentReport.ReportLog(test, "Pass", "Fund Lipper Leader Ratings - 5 Year Template Selected Under Funds", driver);

            //Funds --> Fund Lipper Leader Ratings 10 Year
            Thread.Sleep(TimeSpan.FromSeconds(5));

            mon.setting_btn.Click();
            Actions act_template38 = new Actions(driver);
            act_template38.MoveToElement(mon.cog_menu_columnTemplate)
                .MoveToElement(mon.cog_menu_Funds).MoveToElement(mon.cog_menu_Funds_FundLipperLeaderRatings10Year).Click().Build().Perform();

            ExtentReport.ReportLog(test, "Pass", "Fund Lipper Leader Ratings - 10 Year Template Selected Under Funds", driver);

            //Futures Template
            Thread.Sleep(TimeSpan.FromSeconds(5));

            mon.setting_btn.Click();
            Actions act_template39 = new Actions(driver);
            act_template39.MoveToElement(mon.cog_menu_columnTemplate)
                .MoveToElement(mon.cog_menu_Futures).Click().Build().Perform();

            ExtentReport.ReportLog(test, "Pass", "Futures Template Selected ", driver);

            //FXMM Template
            Thread.Sleep(TimeSpan.FromSeconds(5));

            mon.setting_btn.Click();
            Actions act_template40 = new Actions(driver);
            act_template40.MoveToElement(mon.cog_menu_columnTemplate)
                .MoveToElement(mon.cog_menu_FXMM).Click().Build().Perform();

            ExtentReport.ReportLog(test, "Pass", "FXMM Template Selected ", driver);

            //Options Template
            Thread.Sleep(TimeSpan.FromSeconds(5));

            mon.setting_btn.Click();
            Actions act_template41 = new Actions(driver);
            act_template41.MoveToElement(mon.cog_menu_columnTemplate)
                .MoveToElement(mon.cog_menu_Options).Click().Build().Perform();

            ExtentReport.ReportLog(test, "Pass", "Options Template Selected ", driver);

            ExtentReport.ReportStop(test);

            Thread.Sleep(TimeSpan.FromSeconds(5));

        }
    }

}
