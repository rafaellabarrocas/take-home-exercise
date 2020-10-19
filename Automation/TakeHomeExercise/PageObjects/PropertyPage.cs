using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace TakeHomeExercise.PageObjects
{
    public class PropertyPage : BasePage
    {
        public PropertyPage(IWebDriver driver)
            : base(driver)
        {
        }

        private IWebDriver driver;

        #region Elements

        private By YES_GATE_BUTTON = By.XPath("(//input[@value='true'])[1]"); // Yes
        private By ACCESS_CODE_INPUT = By.XPath("((//div[@class='control is-clearfix'])[2]");
        private By WIDE_SELECT = By.XPath("//span[@aria-label='wide_gate_input-under_24']");
        private By MULTI_FAM_SELECT = By.XPath("(//input[@value='false'])[2]"); // No
        private By LAWN_MAIN_SELECT = By.CssSelector("input[value='frontonly']"); // Front yard only
        private By ACCESS_RESTRIC_BUTTON = By.XPath("(//input[@value='false'])[3]");
        private By SAVE_BUTTON = By.XPath("//button[@type='submit']");

        #endregion

        #region methods

        /*TODO: 
         * Add a boolean validation to yes or no questions: if true = yes, if false = no
         * Add a parameter so the user can pick gate height
         * Add a parameter so the user can choose what lawn maintenance he/she wants
         */
        public PoliciesPage ConfigureProperties(string gateCode)
        {
            Click(YES_GATE_BUTTON, 10);
            FillIn(ACCESS_CODE_INPUT, gateCode, 10);
            Click(WIDE_SELECT, 10);
            Click(MULTI_FAM_SELECT, 10);
            Click(LAWN_MAIN_SELECT, 10);
            Click(ACCESS_RESTRIC_BUTTON, 10);
            Click(SAVE_BUTTON, 10);

            return new PoliciesPage(driver);
        }

        #endregion
    }
}
