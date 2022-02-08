using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitDemo.Src.PageObjects
{
    public class MyCoursesPage
    {
        private IWebDriver driver;

        public MyCoursesPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//h1[text()=\"My Courses \"]")]
        [CacheLookup]
        private IWebElement my_course_header;

        

        public void assertMyCouresPageDisplays() {
            Assert.True(my_course_header.Displayed);
            StringAssert.AreEqualIgnoringCase("My Courses", driver.Title);
        }
    }
}
