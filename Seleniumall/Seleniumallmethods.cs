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
       //This method is for Enter text in inputbox
        public static void Entersampletext(IWebElement element, String text)
        {
            element.Clear();
            element.SendKeys(text);

        }


        //This method is use for Click on Buttons
        public static void Click(IWebElement element)
        {
            element.Click();

        }

        //This method is use for scrolldown screen  
        public static void Scrollscreen(IWebDriver driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0,1000);");
        }
      
    }
}
