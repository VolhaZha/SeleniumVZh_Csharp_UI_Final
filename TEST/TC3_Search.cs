using POM;

namespace TEST
{
    public class TC3_Search : BaseTest
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
        public void TestSearch(string email, string password)
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
            productsPage.ClickSearch(Params.PRODUCT);

            ProductsPage productsPage2 = new ProductsPage(driver);
            Assert.IsTrue(productsPage2.CheckThatProductVisible());

            }
            catch (Exception ex)
           {
           CaptureFailureDetails(ex);
           throw;
           }
        }
    }
}