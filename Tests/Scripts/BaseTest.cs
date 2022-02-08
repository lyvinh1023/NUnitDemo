using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitDemo.Tests.Scripts
{
    public class BaseTest
    {
        public IWebDriver driver;

        [SetUp]
        public void setup()
        {
            driver = new ChromeDriver("D:\\poc");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }


        [TearDown]
        public void teardown()
        {
            driver.Quit();
        }
    }
}
