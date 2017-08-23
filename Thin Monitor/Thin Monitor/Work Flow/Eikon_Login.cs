using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
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
    class Eikon_Login
    {
        static ExtentTest test = ExtentReport.ReportStart("Login", "Checking Login Functionality ");

        public void eikonlogin(IWebDriver driver)
        {
            Login login = new Login(driver);
            try
            {
                login.UserId.SendKeys("anilkumar3@thomsonreuters.com");
                login.Password.SendKeys("Eikon123");
                login.SignInbtn.Click();
                ExtentReport.ReportLog(test, "Pass", "Login Successfully", driver);
            }
            catch
            {
                ExtentReport.ReportLog(test, "Fail", "Login Failed", driver);
            }

            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromMinutes(1));
                wait.Until(ExpectedConditions.ElementExists(By.Id("AAA-AS-SI2-SE009")));
                if (login.Signin.Displayed)
                {
                    login.Signin.Click();
                }
            }

            catch
            {
                Console.WriteLine("No");
            }

            ExtentReport.ReportStop(test);
        }

    }
}
