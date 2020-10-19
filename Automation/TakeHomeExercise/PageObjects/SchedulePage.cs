using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace TakeHomeExercise.PageObjects
{
    public class SchedulePage : BasePage
    {
        public SchedulePage(IWebDriver driver)
            : base(driver)
        {
        }

        private IWebDriver driver;

        #region Elements

        private By FREQUENCY_BUTTON = By.XPath("//*[contains(text(),' Bi-Weekly ')]");
        private By CAL_DATE_PICKER = By.ClassName("ls-input");
        private By DAY_DATE_PICKER = By.XPath("//span[contains(text(), '30')]");
        private By LAST_NAME_INPUT = By.Id("lname");
        private By EMAIL_INPUT = By.Id("email");
        private By CCARD_INPUT = By.Id("ccnumber");
        private By MONTH_EXP_DATE_PICKER = By.Id("exp_month");
        private By MONTH_VALUE = By.XPath("//select/option[@value='3']");
        private By YEAR_DATE_PICKER = By.Id("exp_year");
        private By YEAR_VALUE = By.XPath("//select/option[@value='30']");
        private By CVC_INPUT = By.Id("cvv2");
        private By HOW_DID_YOU_DROPDOWN = By.Id("leadSource");
        private By HOW_DID_YOU_VALUE = By.XPath("//select/option[@value='google']");
        private By AGREE_TO_TERM_SELECT = By.CssSelector("ls-billing-information-form--tos");
        private By SUBMIT_BUTTON = By.XPath("//span[contains(text(), 'Reserve Your Booking')]");

        #endregion

        #region methods

        public SchedulePage SelectBiWeekly()
        {
            Click(FREQUENCY_BUTTON, 10);

            return this;
        }

        //TODO: Add the date as a parameter
        public SchedulePage SelectStartDate()
        {
            Click(CAL_DATE_PICKER, 10);
            Click(DAY_DATE_PICKER, 10);

            return this;
        }

        public SchedulePage EnterLastName(string lastName)
        {
            FillIn(LAST_NAME_INPUT, lastName, 10);

            return this;
        }

        public SchedulePage EnterEmail(string email)
        {
            FillIn(EMAIL_INPUT, email, 10);

            return this;
        }

        //TODO: Add the expiration date as a parameter
        public SchedulePage EnterCreditCardInfo(string ccNumber, string cvcNumber)
        {
            FillIn(CCARD_INPUT, ccNumber, 10);
            Click(MONTH_EXP_DATE_PICKER, 10);
            Click(MONTH_VALUE, 10);
            Click(YEAR_DATE_PICKER, 10);
            Click(YEAR_VALUE, 10);
            FillIn(CVC_INPUT, cvcNumber, 10);

            return this;
        }

        //TODO: Change to a Select element
        public SchedulePage SelectHowDidYouHearAboutUs()
        {
            Click(HOW_DID_YOU_DROPDOWN, 10);
            Click(HOW_DID_YOU_VALUE, 10);

            return this;
        }

        public PropertyPage ClickSubmit()
        {
            Click(AGREE_TO_TERM_SELECT, 10);
            Click(SUBMIT_BUTTON, 10);

            return new PropertyPage(driver);
        }

        #endregion
    }
}
