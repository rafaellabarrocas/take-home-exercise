using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading;
using TakeHomeExercise.Tests;

namespace TakeHomeExercise.PageObjects
{
    public class HomePage : BasePage
    {
        private IWebDriver driver;

        public HomePage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        #region page locators

        private By ADDRESS_INPUT = By.ClassName("js-addressInput");
        private By NAME_INPUT = By.ClassName("js-fullNameInput");
        private By PHONE_INPUT = By.ClassName("js-phoneInput");
        private By SEE_PRICE_SUBMIT = By.ClassName("js-submitButton");

        #endregion

        #region methods

        public HomePage EnterAddress(string address)
        {
            FillIn(ADDRESS_INPUT, address, 10);

            return this;
        }

        public HomePage EnterName(string name)
        {
            FillIn(NAME_INPUT, name, 10);

            return this;
        }

        public HomePage EnterPhone(string phone)
        {
            FillIn(PHONE_INPUT, phone, 10);

            return this;
        }

        public SchedulePage ClickSubmit()
        {
            Click(SEE_PRICE_SUBMIT, 10);

            return new SchedulePage(driver);
        }

        #endregion
    }
}
