using NETAutomation.pages;
using NETAutomation.utils;

namespace NETAutomation.ui
{
    public class NavigationUI
	{
		private NavigationPage navigationPage;

		public NavigationUI()
		{
			navigationPage = new NavigationPage();
		}

		public void NavigateTo(string pageName) => DriverUtils.waitForElement(navigationPage.GetLocator(pageName)).Click();

		public bool IsLogoutVisible() => DriverUtils.waitForElement(navigationPage.LogoutLocator).Displayed;

	}
}

