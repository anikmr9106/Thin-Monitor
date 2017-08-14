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

        // 1st Row   
        [FindsBy(How = How.XPath, Using = "//*[@id='section1']/div/div[2]/div[2]/div")]
        public IWebElement first_row { get; set; }

        // Pluse Button  
        [FindsBy(How = How.Id, Using = "plusButton")]
        public IWebElement plus_btn { get; set; }

        // 11rd Column   
        [FindsBy(How = How.XPath, Using = "//*[@id='section0']/div[11]/div/div[2]")]
        public IWebElement Coll_11 { get; set; }

        // 12rd Column   
        [FindsBy(How = How.XPath, Using = "//*[@id='section0']/div[12]/div/div[2]")]
        public IWebElement Coll_12 { get; set; }

        // 13rd Column   
        [FindsBy(How = How.XPath, Using = "//*[@id='section0']/div[13]/div/div[2]")]
        public IWebElement Coll_13 { get; set; }

        // 14rd Column   
        [FindsBy(How = How.XPath, Using = "//*[@id='section0']/div[14]/div/div[2]")]
        public IWebElement Coll_14 { get; set; }
    }
}
