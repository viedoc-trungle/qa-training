using BasicTraining;
using HuongProject;

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
Console.WriteLine("First String: ");
string firstString = Console.ReadLine();
Console.WriteLine("Second String: ");
string secondString = Console.ReadLine();

int count = StringActions.Is_1stString_include_2ndString(firstString, secondString);
if (count > 0)
    Console.WriteLine("Yeap 1st string include 2nd string! Appear time of 1st string in 2nd string is " + count);
else Console.WriteLine("1st string does not include 2nd string !");