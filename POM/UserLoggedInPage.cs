using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;

namespace POM
{
    public class UserLoggedInPage : BasePage
    {
        IWebElement _loggedInAs;
        IWebElement _productsButton;


        public UserLoggedInPage(IWebDriver driver) : base(driver)
        {
            _loggedInAs = FindElementBy(Params.LOGGED_IN_AS_TEXT);
            _productsButton = FindElementBy(Params.PRODUCTS_BUTTON);
        }
        public bool CheckThatLoggedInAsVisible()
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            var result = wait.Until(condition =>
            {
                try
                {
                    var elementToBeDisplayed = _loggedInAs;
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

        public void ClickProducts()
        {
            _productsButton?.Click();
        }
    }
}
