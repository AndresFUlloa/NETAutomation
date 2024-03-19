using NETAutomation.Pages;
using NETAutomation.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETAutomation.UIs
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
