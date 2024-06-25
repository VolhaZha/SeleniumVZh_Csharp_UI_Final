using POM;

namespace TEST
{
    public class TC5_ViewCategory : BaseTest
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
        public void ViewCategory(string email, string password)
        {
            try
            {
                HomePage homePage = new HomePage(driver);
                homePage.GoToSignupLogin();

                SignUpLogInPage signUpLogInPage = new SignUpLogInPage(driver);
                signUpLogInPage.ClickLogIn(email, password);

                HomePage homePage2 = new HomePage(driver);
                homePage.CategoryClicking();

                ProductsPage productsPage = new ProductsPage(driver);
                productsPage.CheckThatCategoryTextVisible();
            }
            catch (Exception ex)
            {
                CaptureFailureDetails(ex);
                throw;
            }
        }
    }
}