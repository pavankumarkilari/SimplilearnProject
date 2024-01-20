using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UIPrototypeLib
{

    public class UserLogin
    {
        protected IWebDriver Driver;

        [SetUp]
        public void Setup()
        {
            // Set up the ChromeDriver
            Driver = new ChromeDriver();
        }

        [Test]
        public string Login(string userName, string userPwd)
        {
            // Your test logic for login

            string result = "";
            if (userName == "Sam1256" && userPwd == "sam@1256")
            {
                result = "Login Success";
                result = "Dashboard";
            }
            else
            {
                result = "Login Failed";
            }
            return result;

        }

        [TearDown]
        public void Teardown()
        {
            // Close the WebDriver after each test
            Driver.Quit();
        }
    }
}

