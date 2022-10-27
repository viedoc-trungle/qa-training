// See https://aka.ms/new-console-template for more information

using System.Web;
using ClosedXML.Excel;
using HtmlAgilityPack;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

//Create driver
ChromeDriver driver = new ChromeDriver("C:\\Work Data\\Automation\\ChromeDriver");

//Open the webpage
driver.Navigate().GoToUrl("https://travel.com.vn/du-lich-gio-chot.aspx");
driver.Manage().Window.Maximize();

//Get all tours' links
IList<IWebElement> allTourElements = driver.FindElements(By.XPath("//p[contains(@class, 'card-text tour-item__title')]/a"));
List<string> hrefs = new List<string>();
foreach (var element in allTourElements)
{
    hrefs.Add(element.GetAttribute("href"));
}

//Create excel file
IXLWorkbook workbook = new XLWorkbook();
IXLWorksheet sheet = workbook.Worksheets.Add("Tour information");
sheet.Cell(1, 1).Value = "Code";
sheet.Cell(1, 2).Value = "Title";
sheet.Cell(1, 3).Value = "Price";
sheet.Cell(1, 4).Value = "Departure Date";
sheet.Cell(1, 5).Value = "Departure Location";
sheet.Cell(1, 6).Value = "Duration";
sheet.Cell(1, 7).Value = "Available Slot";

//Write each tour information to excel file
int row = 2;
var web = new HtmlWeb();
foreach (var href in hrefs)
{
    var doc = web.Load(href).DocumentNode;
    sheet.Cell(row, 1).Value = doc.SelectSingleNode("//div[@class = 'warp-mark']//label").InnerText;
    sheet.Cell(row, 2).Value = HttpUtility.HtmlDecode(doc.SelectSingleNode("//h1[@class = 'title']").InnerText);
    sheet.Cell(row, 3).Value = doc.SelectSingleNode("//div[@class = 'entry-head']//span[@class = 'price']").InnerText;
    sheet.Cell(row, 4).Value = doc.SelectSingleNode("//p[contains(text(), 'Khởi hành')]/b").InnerText;
    sheet.Cell(row, 5).Value = HttpUtility.HtmlDecode(doc.SelectSingleNode("//p[contains(text(), 'Nơi khởi hành')]/b").InnerText);
    sheet.Cell(row, 6).Value = doc.SelectSingleNode("//p[contains(text(), 'Thời gian')]/b").InnerText;
    sheet.Cell(row, 7).Value = doc.SelectSingleNode("//p[contains(text(), 'Số chỗ còn nhận')]/b").InnerText;
    row++;
}

//Save excel file
workbook.SaveAs(".\\File\\Tour.xlsx");

