using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using PhuongProject.SeleniumPages;

namespace PhuongProject.SeleniumActions
{
    public class TestBase
    {
        protected static WebDriver _driver;

        internal static void CreateDriver()
        {
            _driver = new ChromeDriver("C:\\Work Data\\Automation\\ChromeDriver");
            _driver.Manage().Timeouts().AsynchronousJavaScript = TimeSpan.FromSeconds(10);
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _driver.Manage().Window.Maximize();
        }

        public static HomePage GoToHomePage(string url = "https://toidicodedao.com/")
        {
            if (_driver == null)
                CreateDriver();

            _driver.Navigate().GoToUrl(url);
            return new HomePage(_driver);
        }
    }
}
