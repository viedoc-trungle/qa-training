using BasicTraining;
using HuongProject;
using Microsoft.VisualBasic.CompilerServices;


/*
 * Get first ten digits of total all elements of an Array which has element is string of 50 random number from 0 to 9 
 */

 string[] Arr =
{
    "34481519222841168335179283619606515065600290734112",
    "64675037005515242369580904950058793711838643029211",
    "03808880036514980215626857715233096766950425417910",
    "00279640478557387717978581324888040560649297268632",
    "45289904961900228567619055522427162181786091716922",
    "81827521178436097581702309895870088300534540504827",
    "89362605901370105980666752644003978595224283072354",
    "25781268084026236316120240677836694483579058075604",
    "01556871363720018822716013737228815309475500832593",
    "70087675855811056554561936532353661857015086464198"
};

 AddLongNumberString a = new AddLongNumberString();
Console.WriteLine("First ten digits of total all elements in array is: " + a.getFirstTenDigit(Arr));




/*
ArraysActions arrayAct = new ArraysActions();
// Initial values for 1st Array
Console.WriteLine("Input length of 1st array: ");
int length_1st_array = Int32.Parse(Console.ReadLine());
Console.WriteLine("Input max value of element in 1st array: ");
int maxValue = Int32.Parse(Console.ReadLine());


int[] _1stArray = arrayAct.createArray(maxValue, length_1st_array);

// Initial values for 2nd array
Console.WriteLine("Input length of second array: ");
int length_2nd_array = Int32.Parse(Console.ReadLine());
int[] _2ndArray = arrayAct.createArray(length_1st_array, length_2nd_array);

Console.WriteLine("First Array:");
arrayAct.printArray(_1stArray);
Console.WriteLine("Second Array:");
arrayAct.printArray(_2ndArray);
Console.WriteLine("Updated Array:");
arrayAct.printArray(arrayAct.updateArray(_1stArray, _2ndArray));

*/

//Test
//int[] array1 = new int[5] {1,2,5,7,8};
//int[] array2 = new int[4]{1, 1,2,3};
//int[] updateArray2 = arrayAct.updateArray(array1, array2);

//Console.WriteLine("Updated Array:");
//arrayAct.printArray(updateArray2);
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