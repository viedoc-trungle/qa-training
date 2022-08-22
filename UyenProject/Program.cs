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
        //string str1 = Lesson4.CheckStringIsEmpty();
        //string str2 = Lesson4.CheckStringIsEmpty();
        //int test = Lesson4.IsSubstringAndCount(str1, str2);
        //if (test > 0)
        //    Console.WriteLine("string 1 is sub of string2");
        //else
        //    Console.WriteLine("string 1 is not sub of string2");
        //Console.WriteLine("Number time substring appear in string2 is: " + test);

        //Lesson5- working with Array

        int[] array1 = new int[] { 1263, 345, 4596, 234, 456, 234, 456, 56, 324, 234, 456, 3234 };
        int[] array2 = new int[] { 11, 6, 8, 3, 7, 9, 4, 5, 2, 1, 10, 11, 9, 10, 8, 6, 5, 7, 3, 4, 0, 1, 5, 7, 8, 10, 2, 9 };
        Lesson5.UpdateDataForThe1stArray(array1, array2);
        

    }

}