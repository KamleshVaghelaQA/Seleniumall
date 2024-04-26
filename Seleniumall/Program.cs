using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.DevTools.V122.Console;

namespace Seleniumall
{
    class Program
    {
        //Webdriver initlize 
        IWebDriver driver = new ChromeDriver();
        public static void Main(String[] args)
        {
        }

        [SetUp]
        //Method is use for openbrowser
        public void OpenBrowser()
        {
            driver.Navigate().GoToUrl("https://www.google.com/");
            Console.WriteLine("Chrome browser open successfully");
        }

        [Test]
        //Method is use for perform all operation 
        public void Function1()
        {

            //Search Text
            IWebElement element = driver.FindElement(By.Id("APjFqb"));
            Seleniumallmethods.Entersampletext(element, "dummy sites for automation testing");
            OpenQA.Selenium.Interactions.Actions actions = new OpenQA.Selenium.Interactions.Actions(driver);
            actions.SendKeys(Keys.Enter).Build().Perform();
            Console.WriteLine("Search Success");

            //Open Search Link
            IWebElement lnk = driver.FindElement(By.XPath("//*[text()='Demo Testing Site']"));
            Seleniumallmethods.Click(lnk);
            Console.WriteLine("Register Link open successfull");

            //Open Sample Link
            IWebElement sample = driver.FindElement(By.XPath("//*[text()='SamplePage']"));
            Seleniumallmethods.Click(sample);
            Console.WriteLine("Sample page Link open successfull");

            //Scrolldown screen 
            Seleniumallmethods.Scrollscreen(driver);
            Console.WriteLine("Page scroll successfull");

        }

     
        [TearDown]
        public void Stop()
        {
           driver.Quit();
            Console.WriteLine("Chrome browser close successfully");

        }


    }
}
