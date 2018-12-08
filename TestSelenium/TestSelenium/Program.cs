using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestSelenium
{
    [TestFixture]
    class Program
    {
        [Test]
        public void TestGoogle()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com/");
            Thread.Sleep(5000);
            driver.Close();

        }
        [Test]
        public void TestEditBox()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com/");
            IWebElement ele = driver.FindElement(By.Name("q"));
            ele.SendKeys("Hello");
            Thread.Sleep(5000);
            driver.Close();
        }
       public static void Main()
        {

        }
    }
}
