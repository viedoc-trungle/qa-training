namespace BasicTraining
{
    public class Lesson3_Validate
    {
        //Validate input numbers
        public static int ReadAndValidateNumber()
        {
            bool checkNumber = false;
            int readValue = 0;
            while (!checkNumber)
            {
                Console.WriteLine("Enter the integer number: ");
                var number = Console.ReadLine();
                checkNumber = Int32.TryParse(number, out readValue);
            }

            return readValue;
        }

        // Validate input operators
        public static string ValidateOperator()
        {
            string[] arrOperations = new string[] { "+", "-", "*", "/" };
            Console.WriteLine(" Enter operator: ");
            string operation = Console.ReadLine();

            while (!arrOperations.Contains(operation))
            {
                Console.WriteLine(" Wrong!!Enter operator again  +  -  *  / : ");
                operation = Console.ReadLine();
            }

            return operation;

        }


    }
}


