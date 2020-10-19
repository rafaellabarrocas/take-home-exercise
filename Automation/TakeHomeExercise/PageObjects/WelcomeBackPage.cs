using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace TakeHomeExercise.PageObjects
{
    public class WelcomeBackPage : BasePage
    {
        public WelcomeBackPage(IWebDriver driver) : base(driver)
        {
        }

        private string sigIn = "//span[contains(text(), 'sign in')]";
        private IWebDriver driver;

        #region methods

        public void ValidateSignInPage()
        {
            Assert.IsTrue(IsElementPresent(By.XPath(sigIn)));
        }

        //TODO: Add this method in a extension class
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        #endregion
    }
}
