using UyenProject;

public class Program
{
    public static void Main(string[] args)
    {
        //Lesson1.Sum();
        //Lesson2.Operator();

        //Lesson3
        int num1 = Lesson3_Validate.ReadAndValidateNumber();
        int num2 = Lesson3_Validate.ReadAndValidateNumber();
        string operation = Lesson3_Validate.ValidateOperator();
        Lesson3_Calculate.Calculator(operation, num1, num2);

        //Lesson4

        //string fullstring = Lesson4.readAndcheckSubstring();
        //string substring = Lesson4.readAndcheckSubstring();

       

    }

}