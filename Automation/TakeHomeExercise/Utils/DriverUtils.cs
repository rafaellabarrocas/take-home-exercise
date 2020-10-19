using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TakeHomeExercise.Utils
{
    public class DriverUtils
    {
        public IWebDriver GetDriver()
        {
            IWebDriver driver = new ChromeDriver("C:/Users/rafae/ChromeDriver");
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://dev-www.lawnstarter.com/");
            return driver;
        }
    }
}
