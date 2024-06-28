using OpenQA.Selenium;

namespace POM
{
    public class SignUpLogInPage : BasePage
    {
        IWebElement _nameSignUp;
        IWebElement _mailSignUp;
        IWebElement _signUpButton;
        IWebElement _passwordSignIn;
        IWebElement _mailSignIn;
        IWebElement _logInButton;

        public SignUpLogInPage(IWebDriver driver) : base(driver)
        {
            _nameSignUp = FindElementBy(Params.NAME_SIGNUP_FIELD);
            _mailSignUp = FindElementBy(Params.EMAIL_SIGNUP_FIELD);
            _signUpButton = FindElementBy(Params.SIGNUP_BUTTON);
            _passwordSignIn = FindElementBy(Params.PASSWORD_SIGNIN_FIELD);
            _mailSignIn = FindElementBy(Params.EMAIL_SIGNIN_FIELD);
            _logInButton = FindElementBy(Params.LOGIN_BUTTON);
        }

        public void ClickSignUp(string name, string mail)
        {
            _nameSignUp?.SendKeys(name);
            _mailSignUp?.SendKeys(mail);
            _signUpButton?.Click();
        }

        public void ClickLogIn(string email, string password)
        {
            _passwordSignIn?.SendKeys(password);
            _mailSignIn?.SendKeys(email);
            _logInButton?.Click();
        }
    }
}
