using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace PhuongProject.SeleniumPages
{
    public class PageBase
    {
        public static WebDriver _driver;
        public IList<IWebElement> TimeLinePages => _driver.FindElements(By.XPath("//nav[@aria-label='Lưu trữ']//li/a"));

        public static void ScrollToElement(IWebElement element)
        {
            (_driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);
        }
    }
}
