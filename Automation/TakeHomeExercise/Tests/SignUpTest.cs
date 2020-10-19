using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using TakeHomeExercise.PageObjects;
using TakeHomeExercise.Utils;

namespace TakeHomeExercise.Tests
{
    [TestClass]
    public class SignUpTest
    {
        private IWebDriver driver;
        private readonly DriverUtils driverUtils = new DriverUtils();

        [TestInitialize]
        public void SetUpTest()
        {
            driver = driverUtils.GetDriver();
        }

        [TestMethod]
        public void SignUp()
        {
            HomePage home = new HomePage(driver);

            home.EnterAddress("1234 South Lamar Blvd")
                .EnterName("Rafaella")
                .EnterPhone("5555555555")
                .ClickSubmit()
                .SelectBiWeekly()
                .SelectStartDate()
                .EnterEmail("take_home_exercise@ubiminds.com")
                .EnterCreditCardInfo("4111111111111111", "111")
                .SelectHowDidYouHearAboutUs()
                .ClickSubmit()
                .ConfigureProperties("3333")
                .AgreeAndContinue()
                .SelectBushes()
                .ViewProfile()
                .SignOut();
        }

        [TestCleanup]
        public void CleanUpTest()
        {
            driver.Quit();
        }
    }
}
