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

        // 2st Row   
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

       
    }
}

