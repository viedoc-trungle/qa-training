using UyenProject;
public class Program
{
    public static void Main(string[] args)
    {
        //Lesson3
        //int num1 = Lesson3_Validate.ReadAndValidateNumber();
        //int num2 = Lesson3_Validate.ReadAndValidateNumber();
        //string operation = Lesson3_Validate.ValidateOperator();
        //Lesson3_Calculate.Calculator(operation, num1, num2);



        //Lesson4
        string str1 = Lesson4.checkStringEmpty();
        string str2 = Lesson4.checkStringEmpty();
        
        int test = Lesson4.isSubstringAndCount(str1, str2);

        if (test > 0)
            Console.WriteLine("string 1 is sub of string2");
        else
            Console.WriteLine("string 1 is not sub of string2");

        Console.WriteLine("Number time substring appear in string2 is: " + test);
    }

}