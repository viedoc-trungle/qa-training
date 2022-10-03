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
        public IList<IWebElement> Categories => _driver.FindElements(By.XPath("//a[@rel='category tag']"));
        public IWebElement Title => _driver.FindElement(By.XPath("//h1[@class='entry-title']"));
        public IWebElement Date => _driver.FindElement(By.XPath("//span[@class = 'entry-date']"));
        public IWebElement Author => _driver.FindElement(By.XPath("//a[@rel='author']"));
        public IList<IWebElement> ContentParagraphs => _driver.FindElements(By.XPath("//div[@class = 'entry-content']/p"));

    }
}
