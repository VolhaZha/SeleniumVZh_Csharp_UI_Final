using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;

namespace POM
{
    public class AccountCreatedPage
    : BasePage
    {
        IWebElement _accountCreatedVisible;
        IWebElement _continueAfterCreate;


        public AccountCreatedPage(IWebDriver driver) : base(driver)
        {
            _accountCreatedVisible = FindElementBy(Params.ACCOUNT_CREATED_TEXT);
            _continueAfterCreate = FindElementBy(Params.CONTINUE_AFTER_CREATE);
        }
        public bool CheckThatAccountCreatedVisible()
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            var result = wait.Until(condition =>
            {
                try
                {
                    var elementToBeDisplayed = _accountCreatedVisible;
                    return elementToBeDisplayed.Displayed;
                }
                catch (StaleElementReferenceException)
                {
                    return false;
                }
                catch (NoSuchElementException)
                {
                    return false;
                }
            });
            return result;
        }

        public void ClickContinue()
        {
            _continueAfterCreate.Click();
        }
    }
}
