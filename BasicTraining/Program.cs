// See https://aka.ms/new-console-template for more information

using System.ComponentModel.Design;
using BasicTraining;
using Microsoft.VisualBasic.CompilerServices;

Console.WriteLine("Input 2 numbers and operator(add, subtract, multiply, divide): ");
var num1 = Console.ReadLine();
var num2 = Console.ReadLine();
string operatr = Console.ReadLine().ToString().ToLower();

double result=0;
List<string> operators = new List<string>() { "add", "subtract", "multiply", "divide" };

bool num1IsInt = int.TryParse(num1, out int number1);
bool num2IsInt = int.TryParse(num2, out int number2);
bool correctOperator = operators.Contains(operatr);

while (!num1IsInt || !num1IsInt || !correctOperator) 
{
    Console.WriteLine("Input 2 numbers and correct operator(add, subtract, multiply, divide) again: ");
    num1 = Console.ReadLine();
    num2 = Console.ReadLine();
    operatr = Console.ReadLine().ToString().ToLower();

    correctOperator = operators.Contains(operatr);
    num1IsInt = int.TryParse(num1, out number1);
    num2IsInt = int.TryParse(num2, out number2);
}

CalculateTwoNumbers cal = new CalculateTwoNumbers();

    if (operatr == "add")
        result = cal.Sums(number1, number2);
    else if (operatr == "subtract")
        result = cal.Subtract(number1, number2);
    else if (operatr == "multiply")
        result = cal.multiply(number1, number2);
    else
    {
        if(number2==0)
            Console.WriteLine("Cannot divide by 0.");
        else
        {
        result = cal.divide(decimal.ToDouble(number1), decimal.ToDouble(number2));
        result = System.Math.Round(result, 2);
        }
    }
if(number2 != 0)
    Console.WriteLine("Result of "+ operatr + " 2 numbers is: " + result);
