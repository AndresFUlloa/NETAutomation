using OpenQA.Selenium;

namespace NETAutomation.pages
{
    public class NavigationPage
	{

		private Dictionary<string, By> _navigationLocators = new Dictionary<string, By>();
        public By LogoutLocator { get; } = By.CssSelector("a[href='/logout']");

		public NavigationPage()
		{
            _navigationLocators.Add("Home", By.CssSelector("a[href='/']"));
            _navigationLocators.Add("Products", By.CssSelector("a[href='/products']"));
            _navigationLocators.Add("Cart", By.CssSelector("a[href='/view_cart']"));
            _navigationLocators.Add("Signup/Login", By.CssSelector("a[href='/login']"));
            _navigationLocators.Add("Test Cases", By.CssSelector("a[href='/test_cases']"));
            _navigationLocators.Add("API Testing", By.CssSelector("a[href='/api_list']"));
            _navigationLocators.Add("Video Tutorials", By.CssSelector("a[href='https://www.youtube.com/c/AutomationExercise']"));
            _navigationLocators.Add("Contact us", By.CssSelector("a[href='/contact_us']"));
        }

        public By GetLocator(string pageName)
        {
            if (_navigationLocators.ContainsKey(pageName))
                return _navigationLocators[pageName];

            throw new ArgumentException($"Navigation page '{pageName}' not found");
        }

	}
}

