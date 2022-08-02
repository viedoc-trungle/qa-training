// See https://aka.ms/new-console-template for more information

using System.ComponentModel.Design;
using BasicTraining;
using Microsoft.VisualBasic.CompilerServices;

Console.WriteLine("Input 1st number: ");
var num1 = Console.ReadLine();
int number1;

while (!int.TryParse(num1, out number1))
{
    Console.WriteLine("Input an integer number:");
    num1 = Console.ReadLine();
}
Console.WriteLine("Input 2nd number: ");
var num2 = Console.ReadLine();
int number2;
while (!int.TryParse(num2, out number2))
{
    Console.WriteLine("Input an integer number:");
    num2 = Console.ReadLine();
}

Console.WriteLine("Input Operator (add,subtract,multiply,divide): ");
List<string> operators = new List<string>() {"add", "subtract", "multiply", "divide"};
string sign = Console.ReadLine();

float result=0;
SumOfTwoNumbers sss = new SumOfTwoNumbers();

while (!operators.Contains(sign.ToString().ToLower()) || sign == null)
{
    Console.WriteLine("Please input Operator (add,subtract,multiply,divide): ");
    sign = Console.ReadLine();
}

string LowerCaseSign = sign.ToString().ToLower();
    if (LowerCaseSign == "add")
        result = sss.Sums(number1, number2);
    else if (LowerCaseSign == "subtract")
        result = sss.Subtract(number1, number2);
    else if (LowerCaseSign == "multiply")
        result = sss.multiply(number1, number2);
    else
    {
        try
        {
            result = sss.divide(number1, number2);
            result = (float) System.Math.Round(result, 2);
        }
        catch (Exception e)
        {
            Console.WriteLine("Cannot divide by 0");
        }
    }
if(number2 != 0)
    Console.WriteLine("Result of "+sign+" 2 numbers is: " + result);
