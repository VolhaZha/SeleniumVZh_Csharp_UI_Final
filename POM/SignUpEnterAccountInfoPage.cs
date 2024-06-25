using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;

namespace POM
{
    public class SignUpEnterAccountInfoPage : BasePage
    {
        IWebElement _enterAccountInfoVisible;
        IWebElement _password;
        IWebElement _firstName;
        IWebElement _lastName;
        IWebElement _address;
        IWebElement _state;
        IWebElement _city;
        IWebElement _zip;
        IWebElement _mobile;
        IWebElement _createAccountButton;
        IWebElement _country;
        IWebElement _accountCreatedVisible;

        public SignUpEnterAccountInfoPage(IWebDriver driver) : base(driver)
        {
            _enterAccountInfoVisible = FindElementBy(Params.ENTER_ACCOUNT_INFORMATION_VISIBLE);
            _password = FindElementBy(Params.PASSWORD_SIGNUP_FIELD);
            _firstName = FindElementBy(Params.FIRSTNAME_ADDRESS_INFORMATION);
            _lastName = FindElementBy(Params.LASTNAME_ADDRESS_INFORMATION);
            _address = FindElementBy(Params.ADDRESS_ADDRESS_INFORMATION);
            _state = FindElementBy(Params.STATE_ADDRESS_INFORMATION);
            _city = FindElementBy(Params.CITY_ADDRESS_INFORMATION);
            _zip = FindElementBy(Params.ZIP_ADDRESS_INFORMATION);
            _mobile = FindElementBy(Params.MOBILE_ADDRESS_INFORMATION);
            _createAccountButton = FindElementBy(Params.CREATE_ACCOUNT_BUTTON);
            _country = FindElementBy(Params.COUNTRY_ADDRESS_INFORMATION);
        }

        public bool CheckThatEnterAccountInfoPageOpens()
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            var result = wait.Until(condition =>
            {
                try
                {
                    var elementToBeDisplayed = _enterAccountInfoVisible;
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

        public void СreateAccount (string password, string firstname, string lastname, string address, string state, string city, string zip, string mobile)
        {
            _password?.SendKeys(password);
            _firstName?.SendKeys(firstname);
            _lastName?.SendKeys(lastname);
            _address?.SendKeys(address);
            _state?.SendKeys(state);
            _city?.SendKeys(city);
            _zip?.SendKeys(zip);
            _mobile?.SendKeys(mobile);

            SelectElement element = new SelectElement(_country);
            element.SelectByIndex(3);

            _createAccountButton?.Click();
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
    }
}