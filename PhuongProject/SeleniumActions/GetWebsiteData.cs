using ClosedXML.Excel;
using PhuongProject.SeleniumActions;
using PhuongProject.SeleniumPages;

namespace PhuongProject
{
    internal class GetWebsiteData : TestBase
    {
        public static void GetWebsiteDataToExcel()
        {
            var homePage = GoToHomePage();
            
            var xlsWorkBook = new XLWorkbook();
            var xlsSheet = xlsWorkBook.Worksheets.Add("Articles");
            xlsSheet.Cell("A1").Value = "Category";
            xlsSheet.Cell("B1").Value = "Title";
            xlsSheet.Cell("C1").Value = "Date";
            xlsSheet.Cell("D1").Value = "Author";
            xlsSheet.Cell("E1").Value = "Content";
            int excelRow = 2;

            for (int i = 0; i < homePage.TimeLinePages.Count; i++)
            {
                var timeLinePage = homePage.GoToTimeLinePage(i);
                for (int j = 0; j < timeLinePage.ArticleList.Count; j++)
                {
                    var detailPage = timeLinePage.GoToDetailPage(j);
                    GetArticleDataToExcel(xlsSheet, excelRow, detailPage);
                    excelRow++;
                    homePage.GoToTimeLinePage(i);
                }
            }

            xlsWorkBook.SaveAs("C:\\Users\\PhuongChuQuynh\\Downloads\\Test.xlsx");

        }

        public static void GetArticleDataToExcel(IXLWorksheet xlsSheet,int excelRow, DetailPage detailPage)
        {
            string allCategories = null;
            foreach (var category in detailPage.Categories)
            {
                allCategories += category.Text;
                allCategories += " ";
            }
            xlsSheet.Cell(excelRow,1).Value = allCategories;
            xlsSheet.Cell(excelRow, 2).Value = detailPage.Title.Text;
            xlsSheet.Cell(excelRow, 3).Value = detailPage.Date.Text;
            xlsSheet.Cell(excelRow , 4).Value = detailPage.Author.Text;
            string content = null;
            foreach (var paragraph in detailPage.ContentParagraphs)
            {
                content += paragraph.Text;
                content += "\n";
            }
            xlsSheet.Cell(excelRow, 5).Value = content;
        }
    }
}
