using OpenQA.Selenium;

namespace NETAutomation.pages
{
    public class LoginPage
	{
		public By LoginEmailLocator { get; } = By.CssSelector("input[data-qa='login-email']");
		public By LoginPasswordLocator { get; } = By.CssSelector("input[data-qa='login-password']");
		public By LoginButtonLocator { get; } = By.CssSelector("button[data-qa='login-button']");

        public LoginPage()
		{
		}
	}
}

