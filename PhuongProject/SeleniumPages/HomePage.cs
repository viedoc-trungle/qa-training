using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace PhuongProject.SeleniumPages
{
    public class HomePage : PageBase
    {
        public HomePage(WebDriver driver)
        {
            _driver = driver;
        }

        public TimeLinePage GoToTimeLinePage(int i)
        {
            ScrollToElement(TimeLinePages[i]);
            TimeLinePages[i].Click();
            return new TimeLinePage(_driver);
        }
    }
}
