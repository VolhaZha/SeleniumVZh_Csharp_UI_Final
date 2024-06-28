using OpenQA.Selenium;

namespace POM
{
    public class CartPage : BasePage
    {
        IWebElement _productCart;
        IWebElement _priceCart;
        IWebElement _quantityCart;
        IWebElement _totalCart;

        public CartPage(IWebDriver driver) : base(driver)
        {
            _productCart = FindElementBy(Params.PRODUCT_IN_CART);
            _priceCart = FindElementBy(Params.PRICE_IN_CART);
            _quantityCart = FindElementBy(Params.QUANTITY_IN_CART);
            _totalCart = FindElementBy(Params.TOTAL_PRICE__IN_CART);
        }
        public string GetProductInCartText()
        {
            return _productCart.Text;
        }
        public string GetPriceInCartText()
        {
            return _priceCart.Text;
        }
        public string GetQuantityInCartText()
        {
            return _quantityCart.Text;
        }
        public string GetTotalInCartText()
        {
            return _totalCart.Text;
        }
    }
}
