using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;

namespace NUnitDemo.Src.PageObjects
{
    public class HomePage
    {
        String test_url = "https://courses.letskodeit.com";

        private IWebDriver driver;

        public HomePage(IWebDriver driver) {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.ClassName, Using = "img-fluid")]
        [CacheLookup]
        private IWebElement logo_image;

        [FindsBy(How = How.XPath, Using = "//a[.=\"Sign up now\"]")]
        [CacheLookup]
        private IWebElement sign_up_now_button;

        [FindsBy(How=How.XPath, Using = "//a[text()=\"Sign In\"]")]
        [CacheLookup]
        private IWebElement sign_in_link;

        public void load()
        {
            driver.Url = test_url;
        }

        public String getPageTitle()
        {
            return driver.Title;
        }

        public SignUpPage goToSignUp() {
            sign_up_now_button.Click();
            return new SignUpPage(driver);
        }

        public SignInPage goToSignIn()
        {
            sign_in_link.Click();
            return new SignInPage(driver);
        }

        public void verifyLogo()
        {
           // logo_image.;
        }
    }
}
