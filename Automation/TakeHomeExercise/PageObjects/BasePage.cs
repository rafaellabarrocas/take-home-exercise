using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace TakeHomeExercise.PageObjects
{
    public class BasePage
    {
        private readonly IWebDriver driver;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
        }
        
        public void Click(By locator, int timeout)
        {
            FindElement(locator, timeout).Click();
        }

        public void FillIn(By locator, string text, int timeout)
        {
            FindElement(locator, timeout).SendKeys(text);
        }

        public IWebElement FindElement(By locator, int timeout)
        {
            return new WebDriverWait(driver, TimeSpan.FromSeconds(timeout))
                        .Until(d => d.FindElement(locator));
        }
    }
}
