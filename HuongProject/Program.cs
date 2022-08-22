using BasicTraining;
using HuongProject;
using Microsoft.VisualBasic.CompilerServices;


// Initial values for 1st Array
Console.WriteLine("Input length of 1st array: ");
int length_1st_array = Int32.Parse(Console.ReadLine());
Console.WriteLine("Input max value of element in 1st array: ");
int maxValue = Int32.Parse(Console.ReadLine());

ArraysActions arrayAct = new ArraysActions();
int[] _1stArray = arrayAct.createArray(maxValue, length_1st_array);


// Initial values for 2nd array
Console.WriteLine("Input length of second array: ");
int length_2nd_array = Int32.Parse(Console.ReadLine());
int[] _2ndArray = arrayAct.createArray(length_1st_array, length_2nd_array);

//Update value of 1st array
int[] updateArray = arrayAct.updateArray(_1stArray, _2ndArray);

Console.WriteLine("First Array:");
arrayAct.printArray(_1stArray);
Console.WriteLine("Second Array:");
arrayAct.printArray(_2ndArray);
Console.WriteLine("Updated Array:");
arrayAct.printArray(updateArray);



/*
 * Calculate 2 integer numbers
 * Input Operator, first number, second number
 * Output result
 */
/*
string operatr = InputAndValidate.GetOperator();
int number1 = InputAndValidate.InputAndValidateIntegerNumber();
int number2 = InputAndValidate.InputAndValidateIntegerNumber();
if(operatr == "divide" && number2 == 0)
    Console.WriteLine("Cannot divide by 0.");
else
    Console.WriteLine("Result: " + CalculateTwoNumbers.calculate2Numbers(operatr,number1,number2));
*/


/*
 * Input 2 strings
 * Check whether 1st string include 2nd string
 * output the number of appear times of 2nd string in 1st string
 */

/*Console.WriteLine("First String: ");
string firstString = Console.ReadLine();
Console.WriteLine("Second String: ");
string secondString = Console.ReadLine();

int count = StringActions.Is_1stString_include_2ndString(firstString, secondString);
if (count > 0)
    Console.WriteLine("Yeap 1st string include 2nd string! Appear time of 1st string in 2nd string is " + count);
else Console.WriteLine("1st string does not include 2nd string !");
*/