using POM;

namespace TEST
{
    public class TC4_AddToCart : BaseTest
    {
        [OneTimeSetUp]
        public void Setup()
        {
            string browser = TestContext.Parameters.Get("browser", "chrome");
            string environment = TestContext.Parameters.Get("environment", "local");
            InitializeDriver(browser, environment);
            driver.Url = Params.URL;
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(Params.WAIT_TIME_1);
        }

        [Test]
        [TestCase(Params.EMAIL2, Params.PASSWORD)]
        public void AddToCart(string email, string password)
        {
            try
            {
                HomePage homePage = new HomePage(driver);
                homePage.GoToSignupLogin();

                SignUpLogInPage signUpLogInPage = new SignUpLogInPage(driver);
                signUpLogInPage.ClickLogIn(email, password);

                UserLoggedInPage userLoggedInPage = new UserLoggedInPage(driver);
                userLoggedInPage.ClickProducts();

                ProductsPage productsPage = new ProductsPage(driver);
                productsPage.ScrollDown(3000);
                ProductsPage productsPage2 = new ProductsPage(driver);
                productsPage2.AddToCart();

                ProductsPage productsPage3 = new ProductsPage(driver);
                productsPage3.GoToCart();

                CartPage cartPage = new CartPage(driver);
                string actualProduct = cartPage.GetProductInCartText();
                string expectedProduct = "Blue Top";
                Assert.AreEqual(expectedProduct, actualProduct);

                string actualPrice = cartPage.GetPriceInCartText();
                string expectedPrice = "Rs. 500";
                Assert.AreEqual(expectedPrice, actualPrice);

                string actualQuantity = cartPage.GetQuantityInCartText();
                string expectedQuantity = "1";
                Assert.AreEqual(expectedQuantity, actualQuantity);

                string actualTotal = cartPage.GetTotalInCartText();
                string expectedTotal= "Rs. 500";
                Assert.AreEqual(expectedTotal, actualTotal);
            }
            catch (Exception ex)
            {
                CaptureFailureDetails(ex);
                throw;
            }
        }
    }
}