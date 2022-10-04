using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace PhuongProject.SeleniumPages
{
    public class TimeLinePage : PageBase
    {

        public TimeLinePage(WebDriver driver)
        {
            _driver = driver;
        }
        public IList<IWebElement> ArticleList => _driver.FindElements(By.XPath("//a[@class = 'more-link']"));

        public DetailPage GoToDetailPage(int i)
        {
            ArticleList[i].Click();
            return new DetailPage(_driver);
        }

    }
}
