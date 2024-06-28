using OpenQA.Selenium;

namespace POM
{
    public class HomePage : BasePage
    {
        IWebElement _signUpLogInButton;
        IWebElement _consentButton;
        IWebElement _deleteButton;
        IWebElement _womenCategory;
        IWebElement _dressCategory;

        public HomePage(IWebDriver driver) : base(driver)
        {
        }

        public void GoToSignupLogin()
        {
            _signUpLogInButton = FindElementBy(Params.SIGNUP_LOGIN_BUTTON);
            _consentButton = FindElementBy(Params.CONSENT_BUTTON);
            _consentButton.Click();
            _signUpLogInButton.Click();
        }

        public void TakeScreen()
        {
            Screenshot screenshot = (_driver as ITakesScreenshot).GetScreenshot();
            screenshot.SaveAsFile(@"C:\Users\OlgaZhavrid\Downloads\screenshot.png");
        }

        public void DeleteAccount()
        {
            _deleteButton = FindElementBy(Params.DELETE_ACCOUNT_BUTTON);
            _deleteButton.Click();
        }

        public void CategoryClicking()
        {
            _womenCategory = FindElementBy(Params.WOMEN_CATEGORY);
            _womenCategory.Click();
            _dressCategory = FindElementBy(Params.DRESS_CATEGORY);
            _dressCategory.Click();
        }
    }
}

