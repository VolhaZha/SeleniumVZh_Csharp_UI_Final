using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace POM
{
    public class ProductsPage : BasePage
    {
        IWebElement _loggedInAs;
        IWebElement _productsButton;
        IWebElement _searchField;
        IWebElement _searchButtonn;
        IWebElement _productSearched;
        IWebElement _addToCart;
        IWebElement _addToCart2;
        IWebElement _continueShopping;
        IWebElement _cartButton;
        IWebElement _categoryText;

        public ProductsPage(IWebDriver driver) : base(driver)
        {
            _loggedInAs = FindElementBy(Params.LOGGED_IN_AS_TEXT);
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
            _productsButton = FindElementBy(Params.PRODUCTS_BUTTON);
            _productsButton?.Click();
            Thread.Sleep(1000);
        }

        public void ClickSearch(string product)
        {
            _searchField = FindElementBy(Params.SEARCH_FIELD);
            _searchButtonn = FindElementBy(Params.SEARCH_BUTTON);
            _searchField.SendKeys(product);
            _searchButtonn?.Click();
        }

        public bool CheckThatProductVisible()
        {
            _productSearched = FindElementBy(Params.PRODUCT_SEARCHED);

            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            var result = wait.Until(condition =>
            {
                try
                {
                    var elementToBeDisplayed = _productSearched;
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

        public void AddToCart()
        {
            Thread.Sleep(7000);
            _addToCart = FindElementBy(Params.ADD_TO_CART_BUTTON);
            Actions actions = new Actions(_driver);
            actions.MoveToElement(_addToCart).Perform();
            _addToCart2 = FindElementBy(Params.ADD_TO_CART_BUTTON2);
            _addToCart2?.Click();
            _continueShopping = FindElementBy(Params.CONTINUE_SHOPPING);
            _continueShopping?.Click();
        }

        public void GoToCart()
        {
            _cartButton = FindElementBy(Params.CART);
            _cartButton?.Click();
        }

        public void ScrollDown(int pixels)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)_driver;
            js.ExecuteScript($"window.scrollBy(0, {pixels});");
        }

        public bool CheckThatCategoryTextVisible()
        {
            _categoryText = FindElementBy(Params.CATEGORY_TEXT);

            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            var result = wait.Until(condition =>
            {
                try
                {
                    var elementToBeDisplayed = _categoryText;
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
