using OpenQA.Selenium;

namespace POM
{
    public class Params
    {
        public const string SL_NAME1 = "standard_user";
        public const string SL_NAME2 = "visual_user";
        public const string SL_PASSWORD = "secret_sauce";

        public static int WAIT_TIME_1 = 1;
        public const string URL = "http://automationexercise.com/";

        public static By CONSENT_BUTTON = By.XPath("//button[contains(@class, 'fc-cta-consent')]");
        public static By HOME_PAGE_INDICATOR = By.CssSelector("*[style=\"color: orange;\"] > .fa-home");
        public static By SIGNUP_LOGIN_BUTTON = By.CssSelector("a[href=\"/login\"]");
        public static By NEW_USER_SIGNUP_VISIBLE = By.XPath("//*[contains(text(), 'New User Signup!')]");
        public static By SIGNUP_BUTTON = By.XPath("//div[contains(@class, 'signup-form')]//button[@type='submit']");
        public static By NAME_SIGNUP_FIELD = By.XPath("//input[@name='name']");
        public static By EMAIL_SIGNUP_FIELD = By.XPath("//div[contains(@class, 'signup-form')]//input[@placeholder='Email Address']");
        public static By ENTER_ACCOUNT_INFORMATION_VISIBLE = By.XPath("//*[contains(text(), 'Enter Account Information')]");
        public static By TITLE_SIGNUP_FIELD = By.XPath("//div[contains(@class, 'radio')]//input[@id='id_gender2']");
        public static By PASSWORD_SIGNUP_FIELD = By.XPath("//div[contains(@class, 'form-group')]//input[@id='password']");
        public static By DAY_SIGNUP_FIELD = By.XPath("//div[@id='uniform-days']");
        public static By MONTH_SIGNUP_FIELD = By.XPath("//div[@id='uniform-months']");
        public static By YEAR_SIGNUP_FIELD = By.XPath("//div[@id='uniform-years']");
        public static By NEWSLETTER_CHECKBOX = By.XPath("//div[@id='uniform-newsletter']");
        public static By RECEIVE_OFFERS_CHECKBOX = By.XPath("//div[@id='uniform-optin']");
        public static By FIRSTNAME_ADDRESS_INFORMATION = By.XPath("//input[@id='first_name']");
        public static By LASTNAME_ADDRESS_INFORMATION = By.XPath("//input[@id='last_name']");
        public static By ADDRESS_ADDRESS_INFORMATION = By.XPath("//input[@id='address1']");
        public static By COUNTRY_ADDRESS_INFORMATION = By.XPath("//select[@id='country']");
        public static By STATE_ADDRESS_INFORMATION = By.XPath("//input[@id='state']");
        public static By CITY_ADDRESS_INFORMATION = By.XPath("//input[@id='city']");
        public static By ZIP_ADDRESS_INFORMATION = By.XPath("//input[@id='zipcode']");
        public static By MOBILE_ADDRESS_INFORMATION = By.XPath("//input[@id='mobile_number']");
        public static By CREATE_ACCOUNT_BUTTON = By.XPath("//*[contains(text(), 'Create Account')]");
        public static By ACCOUNT_CREATED_TEXT = By.XPath("//*[contains(text(), 'Account Created!')]");
        public static By CONTINUE_AFTER_CREATE = By.XPath("//*[contains(text(), 'Continue')]");
        public static By LOGGED_IN_AS_TEXT= By.XPath("//*[contains(text(), 'Logged in as')]");
        public static By DELETE_ACCOUNT_BUTTON = By.XPath("//*[contains(text(), 'Delete Account')]");
        public static By ACCOUNT_DELETED_TEXT = By.XPath("//*[contains(text(), 'Account Deleted!')]");
        public static By PASSWORD_SIGNIN_FIELD = By.XPath("//input[@name='password']");
        public static By EMAIL_SIGNIN_FIELD = By.XPath("//div[contains(@class, 'login-form')]//input[@placeholder='Email Address']");
        public static By LOGIN_BUTTON = By.XPath("//div[contains(@class, 'login-form')]//button[@type='submit']");
        public static By PRODUCTS_BUTTON = By.XPath("//*[contains(text(), ' Products')]");
        public static By SEARCH_FIELD = By.XPath("//input[@id='search_product']");
        public static By SEARCH_BUTTON = By.XPath("//button[@id='submit_search']");
        public static By PRODUCT_SEARCHED = By.XPath("//div[contains(@class, 'productinfo')]//*[contains(text(), 'Winter Top')]");
        public static By ADD_TO_CART_BUTTON = By.XPath("//div[contains(@class, 'productinfo')]//a[@data-product-id='1']");
        public static By ADD_TO_CART_BUTTON2 = By.XPath("//div[contains(@class, 'overlay-content')]//a[@data-product-id='1']");
        public static By CONTINUE_SHOPPING = By.XPath("//button[contains(text(), 'Continue Shopping')]");
        public static By CART = By.XPath("//a[contains(text(), 'Cart')]");
        public static By PRODUCT_IN_CART = By.XPath("//a[contains(text(), 'Blue Top')]");
        public static By PRICE_IN_CART = By.XPath("//*[contains(text(), 'Rs. 500')]");
        public static By QUANTITY_IN_CART = By.XPath("(//*[contains(@class, 'cart_quantity')])[1]");
        public static By TOTAL_PRICE__IN_CART = By.XPath("//*[contains(@class, 'cart_total_price')]");
        public static By WOMEN_CATEGORY = By.XPath("(//*[contains(@class, 'pull-right')]//*[contains(@class, 'fa-plus')])[1]");
        public static By DRESS_CATEGORY = By.XPath("//*[contains(@id, 'Women')]//a[contains(text(), 'Dress')]");
        public static By CATEGORY_TEXT = By.XPath("//*[contains(text(), 'Women - Dress Products')]");

        public const string NAME = "OZ";
        public const string PASSWORD = "1234567";
        public const string EMAIL = "oz@oz.oz";
        public const string EMAIL2 = "oz2@oz.oz";
        public const string FIRSTNAME_ADDRESS = "1";
        public const string LASTNAME_ADDRESS = "1";
        public const string ADDRESS_ADDRESS = "1";
        public const string STATE_ADDRESS = "1";
        public const string CITY_ADDRESS = "1";
        public const string ZIP_ADDRESS = "1";
        public const string MOBILE_ADDRESS = "1";
        public const string PRODUCT = "Winter Top";

        public const string SL_USERNAME = "OZ";
        public const string SL_KEY = "30a8636b-7374-4ecc-8c4d-d8222c53b433";
        public const string SL_URL = "https://" + SL_USERNAME + ":" + SL_KEY + "@ondemand.eu-central-1.saucelabs.com:443/wd/hub";

        public const string SCREEN_PATH = @"C:\Users\OlgaZhavrid\Downloads\screenshot.png";

    }
}
