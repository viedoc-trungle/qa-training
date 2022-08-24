using PhuongProject;

//Lesson3
//Calculator cal = new Calculator();
//Console.WriteLine("Result of user input data is: " + cal.Calculate(Validator.InputOperator(), Validator.InputNumber("first number"), Validator.InputNumber("second number")));

//Lesson4
//Console.WriteLine(StringComparator.SubStringOccurrences("hellohe hehe hehe", "ll"));

//Lesson5
int[] array1 = { 1263, 345, 4596, 234, 456, 234, 456, 56, 324, 234, 456, 3234 };
int[] array2 = { 1, 3, 4, 6, 3, 7, 11, 10, 0, 8, 5, 3, 11, 10, 0, 8, 5, 3 };
int[] updatedArray1 = ArrayCalculation.ArrayCalculate(array1, array2);
Console.Write("The new array is: ");
foreach (int i in updatedArray1)
{
    Console.Write(i);
    Console.Write(" ");
}