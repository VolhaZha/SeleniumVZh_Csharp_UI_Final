using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using Allure.NUnit;
using OpenQA.Selenium.Remote;
using POM;
using Allure.Net.Commons;
using Allure.NUnit.Attributes;

namespace TEST
{
    [AllureNUnit]
    public abstract class BaseTest
    {
        protected WebDriver driver;
        protected AllureLifecycle allure;

        public BaseTest()
        {
            allure = AllureLifecycle.Instance;
        }

        public void InitializeDriver(string browser, string environment)
        {
            switch (environment.ToLower())
            {
                case "local":
                    InitializeLocalDriver(browser);
                    break;
                case "saucelabs":
                    InitializeSauceLabsDriver(browser);
                    break;
                default:
                    throw new ArgumentException($"Unsupported environment: {environment}");
            }
        }

        public void InitializeLocalDriver(string browser)
        {
            if (browser.ToLower() == "chrome")
            {
                driver = new ChromeDriver();
            }
            else if (browser.ToLower() == "firefox")
            {
                driver = new FirefoxDriver();
            }
            else
            {
                throw new ArgumentException($"Unsupported browser: {browser}");
            }
        }

        public void InitializeSauceLabsDriver(string browser)
        {
            var sauceOptions = new Dictionary<string, object>
            {
                ["username"] = Params.SL_USERNAME,
                ["accessKey"] = Params.SL_KEY
            };

            RemoteWebDriver driver = null;

            if (browser.ToLower() == "chrome")
            {
                ChromeOptions chromeOptions = new ChromeOptions();
                chromeOptions.PlatformName = "Windows 10";
                chromeOptions.BrowserVersion = "latest";
                chromeOptions.AddAdditionalOption("sauce:options", sauceOptions);
                driver = new RemoteWebDriver(new Uri(Params.SL_URL), chromeOptions);
            }
            else if (browser.ToLower() == "firefox")
            {
                FirefoxOptions firefoxOptions = new FirefoxOptions();
                firefoxOptions.PlatformName = "Windows 10";
                firefoxOptions.BrowserVersion = "latest";
                firefoxOptions.AddAdditionalOption("sauce:options", sauceOptions);
                driver = new RemoteWebDriver(new Uri(Params.SL_URL), firefoxOptions);
            }
            else
            {
                throw new ArgumentException($"Unsupported browser: {browser}");
            }

            this.driver = driver;
        }

        [AllureStep("Add data to report")]
        public void CaptureFailureDetails(Exception ex)
        {
            Screenshot screenshot = (driver as ITakesScreenshot).GetScreenshot();

            string screenshotPath = Params.SCREEN_PATH;
            screenshot.SaveAsFile(screenshotPath);

/*            allure.AddTestAttachment("Failure Screenshot", "image/png", screenshotPath);

            allure.AddAttachment("Exception Details", "text/plain", ex.ToString());

            AllureLifecycle.AddAttachment("DebugLog", "application/json", log, "json");*/
        }

        /*        public string SaveScreen ()
                {
                    Screenshot screenshot = (driver as ITakesScreenshot).GetScreenshot();

                    string screenshotPath = Params.SCREEN_PATH;
                    screenshot.SaveAsFile(screenshotPath);

                    return screenshotPath;

                }

                public void CaptureFailureDetails(Exception ex)
                {
                    BaseTest baseTest = null;
                    var screenshot = baseTest.SaveScreen();
                    TestContext.AddTestAttachment(screenshot);
                    AllureLifecycle.Instance.AddAttachment("Ending test", "image/png", SaveScreen);
                }*/


        [TearDown]
        public void TearDown()
        {
            driver.Close();
            driver.Dispose();
        }
    }
}


