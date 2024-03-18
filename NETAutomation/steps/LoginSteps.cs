using Microsoft.VisualStudio.TestTools.UnitTesting;
using NETAutomation.ui;
using NETAutomation.utils;
using TechTalk.SpecFlow;

namespace NETAutomation.steps
{
    [Binding]
	public class LoginSteps
	{
        private NavigationUI navigationUI = new NavigationUI();
        private LoginUI loginUI = new LoginUI();

		[BeforeScenario]
		public void Setup() {
			DriverUtils.WebDriver.Navigate().GoToUrl("https://automationexercise.com/");
			DriverUtils.WebDriver.Manage().Window.Maximize();
		}

		[AfterScenario]
		public void TearDown()
		{
			DriverUtils.EndDriver();
		}

        [Given(@"the user starts the app")]
        public void GivenTheUserStartsTheApp()
        {
            // Navigation to your application's URL
            DriverUtils.WebDriver.Navigate().GoToUrl("your_application_url");
        }

        [When(@"user navigates to ""(.*)""")]
        public void WhenUserNavigatesTo(string pageName)
        {
            navigationUI.NavigateTo(pageName);
        }

        [When(@"user set email ""(.*)""")]
        public void WhenUserSetEmail(string email)
        {
            loginUI.SetEmail(email);
        }

        [When(@"user set password ""(.*)""")]
        public void WhenUserSetPassword(string password)
        {
            // Locate and input password field
            loginUI.SetPassword(password);
        }

        [When(@"user clicks login button")]
        public void WhenUserClicksLoginButton()
        {
            // Click on the login button
            loginUI.ClickLoginButton();
        }

        [Then(@"logout is visible")]
        public void ThenLogoutIsVisible()
        {
            // Assert that the logout link is visible after successful login
            Assert.IsTrue(navigationUI.IsLogoutVisible());
        }


    }
}

