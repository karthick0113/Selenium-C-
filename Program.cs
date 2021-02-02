using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Selenium2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Started");
            Thread.Sleep(3000);
            IWebDriver driver = new ChromeDriver();
            Thread.Sleep(3000);
            driver.Navigate().GoToUrl("https://www.facebook.com/");
            Thread.Sleep(3000);
            IWebElement user = driver.FindElement(By.Id("email"));
            user.SendKeys("balakarthi13@gmail.com");
            Thread.Sleep(3000);
            IWebElement pass = driver.FindElement(By.Id("pass"));
            pass.SendKeys("Karthick13@@");
            Thread.Sleep(3000);
            IWebElement log = driver.FindElement(By.Name("login"));
            log.Click();
            Console.Write("Ended");
            driver.Close();
            

        }
    }
}
