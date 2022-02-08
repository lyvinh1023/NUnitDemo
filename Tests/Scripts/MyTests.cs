using NUnit.Framework;
using NUnitDemo.Src.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitDemo.Tests.Scripts
{
    public class MyTests : BaseTest
    {
        private HomePage home_page;

        [SetUp]
        public void loadHomePage() {
            home_page = new HomePage(driver);
            home_page.load();
        }

        [Test]
        public void loginWithValidAccount()
        {
            SignInPage sign_in_page = home_page.goToSignIn();
            MyCoursesPage my_course_page = sign_in_page.signIn("lyvinh1023@gmail.com", "VinhLy1023");
            my_course_page.assertMyCouresPageDisplays();
        }

        [Test]
        public void signUpNewAccount()
        {
            HomePage home_page = new HomePage(driver);
            home_page.load();
            SignUpPage sign_up_page = home_page.goToSignUp();
            MyCoursesPage my_course_page = sign_up_page.signUp("User", "One", "user2@mailinator.com", "123456", "123456");
            my_course_page.assertMyCouresPageDisplays();
        }
    }
}
