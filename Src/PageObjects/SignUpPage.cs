using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitDemo.Src.PageObjects
{
    public class SignUpPage
    {
        private IWebDriver driver;

        public SignUpPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "name")]
        [CacheLookup]
        private IWebElement first_name_textbox;

        [FindsBy(How = How.Id, Using = "last_name")]
        [CacheLookup]
        private IWebElement last_name_textbox;

        [FindsBy(How = How.Id, Using = "email")]
        [CacheLookup]
        private IWebElement email_textbox;

        [FindsBy(How = How.Id, Using = "password")]
        [CacheLookup]
        private IWebElement password_textbox;

        [FindsBy(How = How.Id, Using = "password_confirmation")]
        [CacheLookup]
        private IWebElement confirm_password_textbox;

        [FindsBy(How = How.XPath, Using = " //input[@value=\"Sign Up\"]")]
        [CacheLookup]
        private IWebElement sign_up_button;

        public MyCoursesPage signUp(string first_name, string last_name, string email, string password, string confirm_password) {
            first_name_textbox.SendKeys(first_name);
            last_name_textbox.SendKeys(last_name);
            email_textbox.SendKeys(email);
            password_textbox.SendKeys(password);
            confirm_password_textbox.SendKeys(confirm_password);
            sign_up_button.Click();
            return new MyCoursesPage(driver);
        }
    }
}
