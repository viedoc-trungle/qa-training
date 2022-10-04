using System.Collections.ObjectModel;
using OpenQA.Selenium;

namespace PhuongProject.SeleniumPages
{
    public class DetailPage : PageBase
    {
        public DetailPage(WebDriver driver)
        {
            _driver = driver;
        }
        public IList<IWebElement> Categories => _driver.FindElements(By.XPath("//span[@class = 'cat-links']/a"));
        public IWebElement Title => _driver.FindElement(By.XPath("//h1[@class='entry-title']"));
        public IWebElement Date => _driver.FindElement(By.XPath("//span[@class = 'entry-date']"));
        public IWebElement Author => _driver.FindElement(By.XPath("//span[@class = 'author vcard']/a"));
        public IList<IWebElement> ContentParagraphs => _driver.FindElements(By.XPath("//div[@class = 'entry-content']/p"));

    }
}
