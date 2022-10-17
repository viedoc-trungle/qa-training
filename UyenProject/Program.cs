using UyenProject;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
public class Program
{
    public static void Main(string[] args)
    {

        //// Lesson6
        //double[] myArray = Lesson61.ReadAndWriteAnArray();
        //Console.WriteLine("------------------------");
        ////Lesson61.SumArrayElements(myArray);
        //double sum=Lesson61.SumArrayElements(myArray);
        //Lesson61.Print10Digits(sum, 10);

        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl("https://www.w3schools.com/");

        var exercisesButton = driver.FindElement(By.Id("navbtn_exercises"));
        exercisesButton.Click();

        var collections = driver.FindElements(By.XPath("//*[@id=\"nav_exercises\"]/div/div/div"));

        foreach (var collection in collections)
        {
            Console.WriteLine(collection.Text);
        }

    }
}