using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace UIPrototypeLib.Steps
{
    [Binding]
    public class LoginSteps
    {
        private readonly IWebDriver _driver;

        public LoginSteps(IWebDriver driver)
        {
            _driver = driver;
        }

        [Given("the user is on the login page")]
        public void GivenTheUserIsOnTheLoginPage()
        {
            _driver.Navigate().GoToUrl("http://localhost/login");
        }

        [When("the user enters valid credentials")]
        public void WhenTheUserEntersValidCredentials()
        {
            _driver.FindElement(By.Id("username")).SendKeys("Pavan");
            _driver.FindElement(By.Id("password")).SendKeys("Pavan@1234");
        }

        [When("clicks on the \"Login\" button")]
        public void WhenClicksOnTheLoginButton()
        {
            _driver.FindElement(By.Id("loginButton")).Click();
        }

        [Then("the user should be redirected to the dashboard page")]
        public void ThenTheUserShouldBeRedirectedToTheDashboardPage()
        {
            Assert.IsTrue(_driver.Url.Contains("dashboard"));
        }

        [When("the user enters invalid credentials")]
        public void WhenTheUserEntersInvalidCredentials()
        {
            _driver.FindElement(By.Id("username")).SendKeys("username");
            _driver.FindElement(By.Id("password")).SendKeys("password");
        }

        [Then("an error message should be displayed")]
        public void ThenAnErrorMessageShouldBeDisplayed()
        {
            Assert.IsTrue(_driver.FindElement(By.Id("errorMessage")).Displayed);
        }
    }
}
