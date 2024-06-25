using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;

namespace POM
{
    public class BasePage
    {
        protected IWebDriver _driver;

        public BasePage(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement FindElementByClassName(string className)
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(20));
            return wait.Until(driver => driver.FindElement(By.ClassName(className)));
        }

        public IWebElement FindElementByXPath(string xPath)
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(20));
            return wait.Until(driver => driver.FindElement(By.XPath(xPath)));
        }

        public IWebElement FindElementByCSS(string cssSelector)
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(20));
            return wait.Until(driver => driver.FindElement(By.CssSelector(cssSelector)));
        }

        public IWebElement FindElementBy(By Selector)
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(20));
            return wait.Until(driver => driver.FindElement(Selector));
        }
    }
}
