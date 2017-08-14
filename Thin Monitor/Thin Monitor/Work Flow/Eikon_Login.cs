using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thin_Monitor.Page_Object;

namespace Thin_Monitor.Work_Flow
{
    class Eikon_Login
    {
        public void eikonlogin(IWebDriver driver)
        {
            Login login = new Login(driver);
            try
            {
                login.UserId.SendKeys("anilkumar3@thomsonreuters.com");
                login.Password.SendKeys("Eikon123");
                login.SignInbtn.Click();
            }
            catch
            {
                Console.WriteLine("Unable to Login");
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
        }

    }
}
