using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Thin_Monitor.Page_Object;
using Thin_Monitor.Work_Flow;

namespace Thin_Monitor
{
    [TestFixture]
    public class TestClass
    {
        static IWebDriver driver = new ChromeDriver();
        [Test]
        public void A_Installisation()
        {
            driver.Url = "https://apac1.apps.cp.thomsonreuters.com/web/apps/thinmonitor";
        }


        [Test]
        public void B_Login()
        {
            Eikon_Login login = new Eikon_Login();
            login.eikonlogin(driver);

            driver.Manage().Window.Maximize();

            IWait<IWebDriver> wait = new WebDriverWait(driver, TimeSpan.FromMinutes(1));
            wait.Until(driver1 => ((IJavaScriptExecutor)driver).ExecuteScript("return document.readyState").Equals("complete"));
            Thread.Sleep(TimeSpan.FromSeconds(10));
            driver.SwitchTo().Frame("AppFrame");
            //driver.SwitchTo().Frame("EikonNowMarker");
            driver.SwitchTo().Frame("internal");
            driver.SwitchTo().Frame("AppFrame");
            driver.SwitchTo().Frame("EikonNowMarker");
            driver.SwitchTo().Frame("AppFrame");
        }


        [Test]
        public void C_EnteringRICs()
        {
            AddRic addric = new AddRic();
            addric.add_ric(driver);
        }

        [Test]
        public void D_Confidence_1()
        {
            Confidence_1 con = new Confidence_1();
            con.addcolumn(driver);
        }

    }
}
