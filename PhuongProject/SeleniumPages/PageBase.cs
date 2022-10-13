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
        public IList<IWebElement> TimeLineMenus => _driver.FindElements(By.XPath("//aside[@id = 'archives-8']//li/a"));

        public static void ScrollToElement(IWebElement element)
        {
            (_driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);
        }
    }
}
