using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace TakeHomeExercise.PageObjects
{
    public class PoliciesPage : BasePage
    {
        public PoliciesPage(IWebDriver driver)
            : base(driver)
        {
        }

        private IWebDriver driver;

        #region Elements

        private By AGREE_BUTTON = By.ClassName("has-text-white");
        private By CREW_AVAIL_BUTTON = By.XPath("//button[@test-id='yes']");

        #endregion

        #region methods

        /*TODO: 
         * Add a boolean validation to yes or no question: if true = yes, if false = no
         */
        public ShrubsHedgesPage AgreeAndContinue()
        {
            Click(AGREE_BUTTON, 10);
            Click(CREW_AVAIL_BUTTON, 10);

            return new ShrubsHedgesPage(driver);
        }

        #endregion
    }
}
