using NETAutomation.pages;
using NETAutomation.utils;

namespace NETAutomation.ui
{
    public class LoginUI
	{
		private LoginPage loginPage;

		public LoginUI()
		{
			loginPage = new LoginPage();
		}

		public void SetEmail(string email) => DriverUtils.waitForElement(loginPage.LoginEmailLocator).SendKeys(email);
		public void SetPassword(string password) => DriverUtils.waitForElement(loginPage.LoginPasswordLocator).SendKeys(password);
		public void ClickLoginButton() => DriverUtils.waitForElement(loginPage.LoginButtonLocator).Click();

	}
}

