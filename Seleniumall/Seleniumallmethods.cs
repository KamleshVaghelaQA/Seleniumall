using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seleniumall
{
    class Seleniumallmethods
    {
       
        public static void Entersampletext(IWebElement element, String text)
        {
            element.Clear();
            element.SendKeys(text);

        }

        public static void Click(IWebElement element)
        {
            element.Click();

        }

        public static void Scrollscreen(IWebDriver driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0,1000);");
        }
      
    }
}
