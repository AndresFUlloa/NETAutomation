using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETAutomation.Utils
{
    public class DriverUtils
    {
        public static IWebDriver WebDriver { get; }
        private static WebDriverWait wait;
        private static int waitSeconds;

        static DriverUtils()
        {
            WebDriver = new ChromeDriver();
            wait = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(10));
            waitSeconds = 10;

        }

        private static void startWait(int timeoutInSeconds)
        {
            if (wait == null || waitSeconds != timeoutInSeconds)
                wait = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(timeoutInSeconds));
        }

        public static IWebElement waitForElement(By by, int timeoutInSeconds = 10)
        {
            startWait(timeoutInSeconds);
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(by));
            return WebDriver.FindElement(by);
        }

        public static IWebElement waitForVisbleElement(By by, int timeoutInSeconds = 10)
        {
            startWait(timeoutInSeconds);
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(by));
            return WebDriver.FindElement(by);
        }

        public static void EndDriver() => WebDriver.Quit();
    }
}
