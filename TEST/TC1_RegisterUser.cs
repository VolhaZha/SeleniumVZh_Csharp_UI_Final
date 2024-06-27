using POM;

namespace TEST
{
    public class TC1_RegisterUser : BaseTest
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
        [TestCase(Params.PASSWORD, Params.FIRSTNAME_ADDRESS, Params.LASTNAME_ADDRESS, Params.ADDRESS_ADDRESS, Params.STATE_ADDRESS, Params.CITY_ADDRESS, Params.ZIP_ADDRESS, Params.MOBILE_ADDRESS)]
        public void TestSignUpAndDeleteSuccess(string password, string firstname, string lastname, string address, string state, string city, string zip, string mobile)
        {
           try
           { 
            HomePage homePage = new HomePage(driver);
            homePage.GoToSignupLogin();

            SignUpLogInPage signUpLogInPage = new SignUpLogInPage(driver);
            signUpLogInPage.ClickSignUp(Params.NAME, Params.EMAIL);

            SignUpEnterAccountInfoPage signUpEnterAccountInfoPage = new SignUpEnterAccountInfoPage(driver);
            signUpEnterAccountInfoPage.СreateAccount(password, firstname, lastname, address, state, city, zip, mobile);

            AccountCreatedPage accountCreatedPage = new AccountCreatedPage(driver);
            Assert.That(accountCreatedPage.CheckThatAccountCreatedVisible());

            accountCreatedPage.ClickContinue();

            HomePage homePage2 = new HomePage(driver);
            homePage2.DeleteAccount();
           }
           catch (Exception ex)
           {
           CaptureFailureDetails(ex);
           throw;
           }
        }
    }
}