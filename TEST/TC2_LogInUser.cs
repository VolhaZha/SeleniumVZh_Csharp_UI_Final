using POM;

namespace TEST
{
    public class TC2_LogInUser : BaseTest
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
        public void TestSignUpAndDeleteSuccess(string email, string password)
        {
           try
           { 
            HomePage homePage = new HomePage(driver);
            homePage.GoToSignupLogin();

            SignUpLogInPage signUpLogInPage = new SignUpLogInPage(driver);
            signUpLogInPage.ClickLogIn(email, password);

            UserLoggedInPage userLoggedInPage = new UserLoggedInPage(driver);
            Assert.That(userLoggedInPage.CheckThatLoggedInAsVisible());

           }
           catch (Exception ex)
           {
           CaptureFailureDetails(ex);
           throw;
           }
        }
    }
}