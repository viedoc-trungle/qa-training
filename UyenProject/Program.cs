using UyenProject;
public class Program
{
    public static void Main(string[] args)
    {     
       
        // Lesson6
        double[] myArray = Lesson61.ReadAndWriteAnArray();
        Console.WriteLine("------------------------");
        //Lesson61.SumArrayElements(myArray);
        double sum=Lesson61.SumArrayElements(myArray);
        Lesson61.Print10Digits(sum, 10);
    }
}