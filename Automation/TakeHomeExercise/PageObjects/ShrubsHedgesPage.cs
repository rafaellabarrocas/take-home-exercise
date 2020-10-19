using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace TakeHomeExercise.PageObjects
{
    public class ShrubsHedgesPage : BasePage
    {
        public ShrubsHedgesPage(IWebDriver driver)
            : base(driver)
        {
        }

        private IWebDriver driver;

        #region elements

        private By FIVE_FT_SELECT = By.XPath("//select[@name='bushes_0ft_5ft_count']");
        private By FIVE_FT_VALUE = By.XPath("//select/option[@value='1']");
        private By TEN_FT_SELECT = By.XPath("//select[@name='bushes_0ft_5ft_count']");
        private By TEN_FT_VALUE = By.XPath("//select/option[@value='2']");
        private By OVER_TEN_FT_SELECT = By.XPath("//select[@name='bushes_0ft_5ft_count']");
        private By OVER_TEN_FT_VALUE = By.XPath("//select/option[@value='3']");
        private By SUBMIT_BUTTON = By.CssSelector("has-text-white");
        private By CONTINUE_BUTTON = By.XPath("//span[text()='continue to my services']");

        #endregion

        #region methods

        /*TODO: 
         * Add a boolean validation to yes or no question: if true = yes, if false = no
         * Add parameters so the user can choose what bushes he/she wants
         */
        public MyServicePage SelectBushes()
        {
            Click(FIVE_FT_SELECT, 10);
            Click(FIVE_FT_VALUE, 10);
            Click(TEN_FT_SELECT, 10);
            Click(TEN_FT_VALUE, 10);
            Click(OVER_TEN_FT_SELECT, 10);
            Click(OVER_TEN_FT_VALUE, 10);
            Click(SUBMIT_BUTTON, 10);
            Click(CONTINUE_BUTTON, 10);

            return new MyServicePage(driver);
        }

        #endregion
    }
}
