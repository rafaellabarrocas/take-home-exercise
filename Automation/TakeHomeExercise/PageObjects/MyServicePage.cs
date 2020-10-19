using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace TakeHomeExercise.PageObjects
{
    public class MyServicePage : BasePage
    {
        public MyServicePage(IWebDriver driver) : base(driver)
        {
        }

        private IWebDriver driver;

        #region elements

        private By USER_BUTTON = By.XPath("//button[@test-id='user-name']");
        private By YOUR_PROFILE_LINK = By.CssSelector("a[href$='/profile']");
        private By SIGN_OUT_BUTTON = By.ClassName("sign-out");

        #endregion

        #region methods

        public MyServicePage ViewProfile()
        {
            Click(USER_BUTTON, 10);
            Click(YOUR_PROFILE_LINK, 10);

            return this;
        }

        public WelcomeBackPage SignOut()
        {
            Click(USER_BUTTON, 10);
            Click(SIGN_OUT_BUTTON, 10);

            return new WelcomeBackPage(driver);
        }

        #endregion
    }
}
