// See https://aka.ms/new-console-template for more information

using System.ComponentModel.Design;
using BasicTraining;
using Microsoft.VisualBasic.CompilerServices;

Console.WriteLine("Input 2 numbers and operator(add, subtract, multiply, divide): ");
var num1 = Console.ReadLine();
var num2 = Console.ReadLine();
string operatr = Console.ReadLine().ToLower();

List<string> operators = new List<string>() { "add", "subtract", "multiply", "divide" };

bool num1IsInt = int.TryParse(num1, out int number1);
bool num2IsInt = int.TryParse(num2, out int number2);
bool correctOperator = operators.Contains(operatr);

while (!num1IsInt || !num2IsInt || !correctOperator) 
{
    Console.WriteLine("Input 2 numbers and correct operator(add, subtract, multiply, divide) again: ");
    num1 = Console.ReadLine();
    num2 = Console.ReadLine();
    operatr = Console.ReadLine().ToLower();

    correctOperator = operators.Contains(operatr);
    num1IsInt = int.TryParse(num1, out number1);
    num2IsInt = int.TryParse(num2, out number2);
}

CalculateTwoNumbers cal = new CalculateTwoNumbers();
if(operatr == "divide" && number2 == 0)
    Console.WriteLine("Cannot divide by 0.");
else
{
    double result = cal.calculate2Numbers(operatr, number1, number2);
    result = System.Math.Round(result, 2);
    Console.WriteLine("Result of " + operatr + " 2 numbers is: " + result);
}
   
