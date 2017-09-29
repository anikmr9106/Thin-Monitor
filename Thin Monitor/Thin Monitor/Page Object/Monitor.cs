using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thin_Monitor.Page_Object
{
    class Monitor
    {
        public Monitor(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        // dropdown Field   
        [FindsBy(How = How.Id, Using = "main-menu-combo-box")]
        public IWebElement dropdown { get; set; }

        // Setting Button  
        [FindsBy(How = How.Id, Using = "button-menu")]
        public IWebElement setting_btn { get; set; }

        // 2st Row table 1   
        [FindsBy(How = How.XPath, Using = "//*[@id='section1']/div/div[2]/div[2]/div")]
        public IWebElement sec_row { get; set; }

        // 3st Row   
        [FindsBy(How = How.XPath, Using = "//*[@id='section1']/div/div[2]/div[3]/div")]
        public IWebElement third_row { get; set; }

        // 4st Row   
        [FindsBy(How = How.XPath, Using = "//*[@id='section1']/div/div[2]/div[4]/div")]
        public IWebElement Fourth_row { get; set; }


        // 4st Row Expand
        [FindsBy(How = How.XPath, Using = "//*[@id='section1']/div/div[2]/div[4]/div/span/span[1]")]
        public IWebElement fourth_row_Expand { get; set; }

        // Column7 Row1 Field
        [FindsBy(How = How.XPath, Using = "//*[@id='section1']/div/div[7]/div[1]/div")]
        public IWebElement row1_col7 { get; set; }

        // Column7 Row2 Field
        [FindsBy(How = How.XPath, Using = "//*[@id='section1']/div/div[7]/div[2]/div")]
        public IWebElement row2_col7 { get; set; }

        // 5st Row   
        [FindsBy(How = How.XPath, Using = "//*[@id='section1']/div/div[2]/div[5]/div")]
        public IWebElement Fifth_row { get; set; }

        // 5st Row Expand  
        [FindsBy(How = How.XPath, Using = "//*[@id='section1']/div/div[2]/div[5]/div/span/span[1]")]
        public IWebElement Fifth_row_Expand { get; set; }

        // Pluse Button  
        [FindsBy(How = How.Id, Using = "plusButton")]
        public IWebElement plus_btn { get; set; }

        // New Monitor
        [FindsBy(How = How.Id, Using = "main-menu-new")]
        public IWebElement mon_new { get; set; }

        // Multi Table field
        [FindsBy(How = How.Id, Using = "cog-menu-multiTables")]
        public IWebElement Multitable { get; set; }

        // Two Table field
        [FindsBy(How = How.Id, Using = "cog-menu-2table")]
        public IWebElement twotable { get; set; }

        // 11rd Column   
        [FindsBy(How = How.XPath, Using = "//*[@id='section0']/div[11]/div/div[2]")]
        public IWebElement Col_11 { get; set; }

        // 12rd Column   
        [FindsBy(How = How.XPath, Using = "//*[@id='section0']/div[12]/div/div[2]")]
        public IWebElement Col_12 { get; set; }

        // 13rd Column   
        [FindsBy(How = How.XPath, Using = "//*[@id='section0']/div[13]/div/div[2]")]
        public IWebElement Col_13 { get; set; }

        // 14rd Column    
        [FindsBy(How = How.XPath, Using = "//*[@id='section0']/div[14]/div/div[2]")]
        public IWebElement Col_14 { get; set; }

        // Table-2 Row-3     
        [FindsBy(How = How.XPath, Using = "//*[@id='section3']/div/div[2]/div[3]/div")]
        public IWebElement table2_row_3 { get; set; }

        // Main Combo Box    main-menu-addList
        [FindsBy(How = How.Id, Using = "main-menu-combo-box")]
        public IWebElement main_combobox { get; set; }

        // main-menu-addList   
        [FindsBy(How = How.Id, Using = "main-menu-addList")]
        public IWebElement main_addportfoliolist { get; set; }

        // Portfolio Search Textbox     
        [FindsBy(How = How.Id, Using = "list-loading-search")]
        public IWebElement portfolio_search_textbox { get; set; }

        // 1st Search Result in Portfolio popup   
        [FindsBy(How = How.XPath, Using = "//*[@id='section4']/div/svg/svg/div[2]/div/div")]
        public IWebElement portfoilio_result_1 { get; set; }

        // Portfolio ok button    
        [FindsBy(How = How.Id, Using = "list-loading-ok")]
        public IWebElement portfoilio_okbtn { get; set; }

        // Coloumn 7 Header              
        [FindsBy(How = How.XPath, Using = "//*[@id='section0']/div[7]/div")]
        public IWebElement Col_7 { get; set; }

        // Context click on coloumn ascending sorting field    
        [FindsBy(How = How.CssSelector, Using = "div[id='itemContainer'] eikon-layout-menu-item[item-id='sortAsc']")]
        public IWebElement contextclick_sort_asce { get; set; }

        // Context click on coloumn descending sorting field    
        [FindsBy(How = How.CssSelector, Using = "div[id='itemContainer'] eikon-layout-menu-item[item-id='sortDesc']")]
        public IWebElement contextclick_sort_desc { get; set; }

        // Context click on coloumn ascending sorting on everyone update field
        [FindsBy(How = How.XPath, Using = "//*[@item-id='sortAscEveryUpdate']")]
        public IWebElement contextclick_sort_asce_everyone { get; set; }

        // Context click on coloumn ascending sorting on everyone update field
        [FindsBy(How = How.XPath, Using = "//*[@item-id='sortDescEveryUpdate']")]
        public IWebElement contextclick_sort_desc_everyone { get; set; }

        // Auto Hide Bar
        [FindsBy(How = How.Id, Using = "drawer")]
        public IWebElement autohide_bar { get; set; }

        // Perferences
        [FindsBy(How = How.Id, Using = "cog-menu-preference")]
        public IWebElement perference { get; set; }

        // Perferences-Miscellaneous   
        [FindsBy(How = How.Id, Using = "tab-miscellaneous")]
        public IWebElement perference_miscellaneous { get; set; }

        // Auto Hide Checkbox
        [FindsBy(How = How.XPath, Using = "//div[contains(@id,'dialog')]/div/div/div[2]/div/div[1]/div[5]/div[1]/label")]
        public IWebElement autohide_checkbox { get; set; }

        // Perference Ok Button
        [FindsBy(How = How.XPath, Using = "//div[contains(@id,'dialog')]/div/div/div[2]/div/div[2]/div/div[2]/button[2]")]
        public IWebElement perference_okbtn { get; set; }

        //Templates Elements
        // Default Template 
        [FindsBy(How = How.Id, Using = "cog-menu-template-default")]
        public IWebElement cog_menu_template_default { get; set; }

        // Default Template 
        [FindsBy(How = How.Id, Using = "cog-menu-columnTemplate")]
        public IWebElement cog_menu_columnTemplate { get; set; }

        // Asset_Management Template
        [FindsBy(How = How.Id, Using = "cog-menu-template-folder-Asset_Management")]
        public IWebElement cog_menu_Asset_Management { get; set; }

        // Banking_&_Research Template
        [FindsBy(How = How.Id, Using = "cog-menu-template-folder-Banking_&_Research")]
        public IWebElement cog_menu_Banking_Research { get; set; }

        // Bonds Template
        [FindsBy(How = How.Id, Using = "cog-menu-template-folder-Bonds")]
        public IWebElement cog_menu_Bonds { get; set; }

        // Equity Template
        [FindsBy(How = How.Id, Using = "cog-menu-template-folder-Equity")]
        public IWebElement cog_menu_Equity { get; set; }

        // Funds Template
        [FindsBy(How = How.Id, Using = "cog-menu-template-folder-Funds")]
        public IWebElement cog_menu_Funds { get; set; }

        // Futures Template
        [FindsBy(How = How.Id, Using = "cog-menu-template-en-US.Root.Futures.Futures.monitor-template")]
        public IWebElement cog_menu_Futures { get; set; }

        // FXMM Template
        [FindsBy(How = How.Id, Using = "cog-menu-template-en-US.Root.FXMM.FXMM.monitor-template")]
        public IWebElement cog_menu_FXMM { get; set; }

        // Options Template
        [FindsBy(How = How.Id, Using = "cog-menu-template-en-US.Root.Options.Options.monitor-template")]
        public IWebElement cog_menu_Options { get; set; }

        // All Template
        [FindsBy(How = How.Id, Using = "cog-menu-all-templates")]
        public IWebElement cog_menu_All_Template { get; set; }

        //Template Under Asset Management
        // Portfolio Template
        [FindsBy(How = How.Id, Using = "cog-menu-template-en-US.Root.Asset Management.Portfolio.Portfolio.monitor-template")]
        public IWebElement cog_menu_Asset_Management_Portfolio { get; set; }

        // Portfolio (Cost Basis) Template
        [FindsBy(How = How.Id, Using = "cog-menu-template-en-US.Root.Asset Management.Portfolio (Cost Basis).PortfolioCostBasis.monitor-template")]
        public IWebElement cog_menu_Asset_Management_Portfolio_Cost_Basis { get; set; }

        // Prop Data - Price Performance Template
        [FindsBy(How = How.Id, Using = "cog-menu-template-en-US.Root.Asset Management.Prop Data - Price Performance.Prop-PricePerformance.monitor-template")]
        public IWebElement cog_menu_Asset_Management_Prop_Data_Price { get; set; }

        // Prop Data - Earning Template
        [FindsBy(How = How.Id, Using = "cog-menu-template-en-US.Root.Asset Management.Prop Data - Earnings.Prop-Earnings.monitor-template")]
        public IWebElement cog_menu_Asset_Management_Prop_Data_Earning { get; set; }

        //Templates Under Banking and Research
        // Comprehensive Template
        [FindsBy(How = How.Id, Using = "cog-menu-template-en-US.Root.Banking & Research.Comprehensive.Banking-General.monitor-template")]
        public IWebElement cog_menu_Banking_Research_Comprehensive { get; set; }

        // Comparables Template
        [FindsBy(How = How.Id, Using = "cog-menu-template-en-US.Root.Banking & Research.Comparables.Banking-Comparables.monitor-template")]
        public IWebElement cog_menu_Banking_Research_Comparables { get; set; }

        // Asset Management Template
        [FindsBy(How = How.Id, Using = "cog-menu-template-en-US.Root.Banking & Research.Asset Managers.Banking-AssetManagers.monitor-template")]
        public IWebElement cog_menu_Banking_Asset_Management { get; set; }

        // Banks And Specialist Finance Template
        [FindsBy(How = How.Id, Using = "cog-menu-template-en-US.Root.Banking & Research.Banks & Specialist Finance.Banking-BanksnSpecialistFinance.monitor-template")]
        public IWebElement cog_menu_Banking_Banks_Specialist { get; set; }

        // Financial Service Template
        [FindsBy(How = How.Id, Using = "cog-menu-template-en-US.Root.Banking & Research.Banks & Specialist Finance.Banking-BanksnSpecialistFinance.monitor-template")]
        public IWebElement cog_menu_Banking_Financial_Service { get; set; }

        // Insurnace Template
        [FindsBy(How = How.Id, Using = "cog-menu-template-en-US.Root.Banking & Research.Insurance.Banking-Insurance.monitor-template")]
        public IWebElement cog_menu_Banking_Insurance { get; set; }

        // Oil and Gas Template
        [FindsBy(How = How.Id, Using = "cog-menu-template-en-US.Root.Banking & Research.Oil & Gas.Banking-OilnGas.monitor-template")]
        public IWebElement cog_menu_Banking_Oil_Gas { get; set; }

        // Trading Multiples Template
        [FindsBy(How = How.Id, Using = "cog-menu-template-en-US.Root.Banking & Research.Trading Multiples.Banking-TradingMultiples.monitor-template")]
        public IWebElement cog_menu_Banking_Trading_Multiples { get; set; }

        //Templates Under Bonds
        // Bonds Template
        [FindsBy(How = How.Id, Using = "cog-menu-template-en-US.Root.Bonds.Bonds.Bonds.monitor-template")]
        public IWebElement cog_menu_Bonds_Bonds { get; set; }

        // CoCo Template
        [FindsBy(How = How.Id, Using = "cog-menu-template-en-US.Root.Bonds.CoCo.CoCoBonds.monitor-template")]
        public IWebElement cog_menu_Bonds_CoCo { get; set; }

        // Convertible Template
        [FindsBy(How = How.Id, Using = "cog-menu-template-en-US.Root.Bonds.Convertible.Convertible.monitor-template")]
        public IWebElement cog_menu_Bonds_Convertible { get; set; }

        //Templates Under Equity
        // Equity Template
        [FindsBy(How = How.Id, Using = "cog-menu-template-en-US.Root.Equity.Equity.Equity.monitor-template")]
        public IWebElement cog_menu_Equity_Equity { get; set; }

        // Earning Template
        [FindsBy(How = How.Id, Using = "cog-menu-template-en-US.Root.Equity.Earnings.Earnings.monitor-template")]
        public IWebElement cog_menu_Equity_Earning { get; set; }

        // HiLo Template
        [FindsBy(How = How.Id, Using = "cog-menu-template-en-US.Root.Equity.HiLo.HiLo.monitor-template")]
        public IWebElement cog_menu_Equity_HiLo { get; set; }

        // Price Perf Template
        [FindsBy(How = How.Id, Using = "cog-menu-template-en-US.Root.Equity.PricePerf.PricePerf.monitor-template")]
        public IWebElement cog_menu_Equity_PricePerf { get; set; }

        // Premarket Stats Template
        [FindsBy(How = How.Id, Using = "cog-menu-template-en-US.Root.Equity.Premarket Stats.PremarketStats.monitor-template")]
        public IWebElement cog_menu_Equity_Premarket_Stats { get; set; }

        // Regular Hours Template
        [FindsBy(How = How.Id, Using = "cog-menu-template-en-US.Root.Equity.Regular Hours.RegularHours.monitor-template")]
        public IWebElement cog_menu_Equity_Regular_Hours { get; set; }

        // Aftermkt Stats Template
        [FindsBy(How = How.Id, Using = "cog-menu-template-en-US.Root.Equity.Aftermkt Stats.AftermktStats.monitor-template")]
        public IWebElement cog_menu_Equity_Aftermkt_Stats { get; set; }

        //Templates Under Funds
        // Fund Performance CHF Template
        [FindsBy(How = How.Id, Using = "cog-menu-template-en-US.Root.Funds.Fund Performance CHF.FundPerformanceCHF.monitor-template")]
        public IWebElement cog_menu_Funds_Fund_PerformanceCHF { get; set; }

        // Fund Performance EUR Template
        [FindsBy(How = How.Id, Using = "cog-menu-template-en-US.Root.Funds.Fund Performance EUR.FundPerformanceEUR.monitor-template")]
        public IWebElement cog_menu_Funds_Fund_PerformanceEUR { get; set; }

        // Fund Performance GBP Template
        [FindsBy(How = How.Id, Using = "cog-menu-template-en-US.Root.Funds.Fund Performance GBP.FundPerformanceGBP.monitor-template")]
        public IWebElement cog_menu_Funds_Fund_PerformanceGBP { get; set; }

        // Fund Performance JPY Template
        [FindsBy(How = How.Id, Using = "cog-menu-template-en-US.Root.Funds.Fund Performance JPY.FundPerformanceJPY.monitor-template")]
        public IWebElement cog_menu_Funds_Fund_PerformanceJPY { get; set; }

        // Fund Performance USD Template
        [FindsBy(How = How.Id, Using = "cog-menu-template-en-US.Root.Funds.Fund Performance USD.FundPerformanceUSD.monitor-template")]
        public IWebElement cog_menu_Funds_Fund_PerformanceUSD { get; set; }

        // Fund Performance Fund Currency Template
        [FindsBy(How = How.Id, Using = "cog-menu-template-en-US.Root.Funds.Fund Performance Fund Currency.FundPerformanceFundCurrency.monitor-template")]
        public IWebElement cog_menu_Funds_Fund_Performance_FundCurrency { get; set; }

        // Fund 1 Year Risk Template
        [FindsBy(How = How.Id, Using = "cog-menu-template-en-US.Root.Funds.Fund - 1 Year Risk.Fund1YearRisk.monitor-template")]
        public IWebElement cog_menu_Funds_Fund_1YearRisk { get; set; }

        // Fund 3 Year Risk Template
        [FindsBy(How = How.Id, Using = "cog-menu-template-en-US.Root.Funds.Fund - 3 Year Risk.Fund3YearRisk.monitor-template")]
        public IWebElement cog_menu_Funds_Fund_3YearRisk { get; set; }

        // Fund 5 Year Risk Template
        [FindsBy(How = How.Id, Using = "cog-menu-template-en-US.Root.Funds.Fund - 5 Year Risk.Fund5YearRisk.monitor-template")]
        public IWebElement cog_menu_Funds_Fund_5YearRisk { get; set; }

        // Fund 10 Year Risk Template
        [FindsBy(How = How.Id, Using = "cog-menu-template-en-US.Root.Funds.Fund - 10 Year Risk.Fund10YearRisk.monitor-template")]
        public IWebElement cog_menu_Funds_Fund_10YearRisk { get; set; }

        // Fund Overview Template
        [FindsBy(How = How.Id, Using = "cog-menu-template-en-US.Root.Funds.Fund Overview.FundOverview.monitor-template")]
        public IWebElement cog_menu_Funds_Fund_Overview { get; set; }

        // Fund Latest Price and Total Net Assets Template
        [FindsBy(How = How.Id, Using = "cog-menu-template-en-US.Root.Funds.Fund Latest Price and Total Net Assets.FundLatestPriceTotalNetAssets.monitor-template")]
        public IWebElement cog_menu_Funds_FundLatestPriceTotalNetAssets { get; set; }

        // Fund Lipper Leader Ratings Overall Template
        [FindsBy(How = How.Id, Using = "cog-menu-template-en-US.Root.Funds.Fund Lipper Leader Ratings- Overall.FundLipperLeaderRatingsOverall.monitor-template")]
        public IWebElement cog_menu_Funds_FundLipperLeaderRatingsOverall { get; set; }

        // Fund Lipper Leader Ratings 3Year Template
        [FindsBy(How = How.Id, Using = "cog-menu-template-en-US.Root.Funds.Fund Lipper Leader Ratings- 3 Year.FundLipperLeaderRatings3Year.monitor-template")]
        public IWebElement cog_menu_Funds_FundLipperLeaderRatings3Year { get; set; }

        // Fund Lipper Leader Ratings 5Year Template
        [FindsBy(How = How.Id, Using = "cog-menu-template-en-US.Root.Funds.Fund Lipper Leader Ratings- 5 Year.FundLipperLeaderRatings5Year.monitor-template")]
        public IWebElement cog_menu_Funds_FundLipperLeaderRatings5Year { get; set; }

        // Fund Lipper Leader Ratings 10Year Template
        [FindsBy(How = How.Id, Using = "cog-menu-template-en-US.Root.Funds.Fund Lipper Leader Ratings- 10 Year.FundLipperLeaderRatings10Year.monitor-template")]
        public IWebElement cog_menu_Funds_FundLipperLeaderRatings10Year { get; set; }

        // Group Header Icon at Row 2 Table 1
        [FindsBy(How = How.XPath, Using = "//*[@id='section1']/div/div[2]/div[2]/div/span/span/span[3]")]
        public IWebElement GH_Row2_table1 { get; set; }

        // Group Header Icon at Row 2 Table 1
        [FindsBy(How = How.Id, Using = "classification-0")]
        public IWebElement GH_Classifyby_btn { get; set; }

        // Group Header Classify By Menu 
        [FindsBy(How = How.XPath, Using = "/html/body/div[8]/coral-panel/coral-list/coral-list-item[@id='item01']")]
        public IWebElement GH_Classifyby_item1 { get; set; }

        // Group Header Classify By Menu 
        [FindsBy(How = How.XPath, Using = "/html/body/div[8]/coral-panel/coral-list/coral-list-item[@id='item02']")]
        public IWebElement GH_Classifyby_item2 { get; set; }

        // Group Header Classify By Menu 
        [FindsBy(How = How.XPath, Using = "/html/body/div[8]/coral-panel/coral-list/coral-list-item[@id='item03']")]
        public IWebElement GH_Classifyby_item3 { get; set; }

        // Group Header Classify By Menu 
        [FindsBy(How = How.XPath, Using = "/html/body/div[8]/coral-panel/coral-list/coral-list-item[@id='item04']")]
        public IWebElement GH_Classifyby_item4 { get; set; }

        // Group Header Classify By Menu 
        [FindsBy(How = How.XPath, Using = "/html/body/div[8]/coral-panel/coral-list/coral-list-item[@id='item05']")]
        public IWebElement GH_Classifyby_item5 { get; set; }

        // Group Header Classify By Menu 
        [FindsBy(How = How.XPath, Using = "/html/body/div[8]/coral-panel/coral-list/coral-list-item[@id='item06']")]
        public IWebElement GH_Classifyby_item6 { get; set; }

        // Group Header Classify By Menu 
        [FindsBy(How = How.XPath, Using = "/html/body/div[8]/coral-panel/coral-list/coral-list-item[@id='item07']")]
        public IWebElement GH_Classifyby_item7 { get; set; }

        // Group Header Classify By Menu 
        [FindsBy(How = How.XPath, Using = "/html/body/div[8]/coral-panel/coral-list/coral-list-item[@id='item08']")]
        public IWebElement GH_Classifyby_item8 { get; set; }

        // Group Header Classify By Menu 
        [FindsBy(How = How.XPath, Using = "/html/body/div[8]/coral-panel/coral-list/coral-list-item[@id='item09']")]
        public IWebElement GH_Classifyby_item9 { get; set; }

        // Classify By OK Button 
        [FindsBy(How = How.XPath, Using = "//div[contains(@id,'dialog')]/div/div/div[3]/div/quartz-layout/quartz-layout[2]/coral-button[1]/button")]
        public IWebElement GH_Classifyby_okbtn { get; set; }
    }
}

