using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitDemo.Src.PageObjects
{
    public class SignInPage
    {
        private IWebDriver driver;

        public SignInPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "email")]
        [CacheLookup]
        private IWebElement email_textbox;

        [FindsBy(How = How.Id, Using = "password")]
        [CacheLookup]
        private IWebElement password_textbox;

        [FindsBy(How = How.XPath, Using = "//input[@value=\"Login\"]")]
        [CacheLookup]
        private IWebElement login_button;

        public MyCoursesPage signIn(string email, string password) {
            email_textbox.SendKeys(email);
            password_textbox.SendKeys(password);
            login_button.Click();
            return new MyCoursesPage(driver);
        }
    }
}
