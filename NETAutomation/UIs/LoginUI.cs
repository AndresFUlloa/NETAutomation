using NETAutomation.Pages;
using NETAutomation.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETAutomation.UIs
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
