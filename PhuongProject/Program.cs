using PhuongProject;

Calculator cal = new Calculator();
Console.WriteLine("-- Code input data --");
Console.WriteLine("Sum of 10 and 20 is: " + cal.Calculate(Calculator.Operator.sum, 10, 20));
Console.WriteLine("Subtract of 10 and 20 is: " + cal.Calculate( Calculator.Operator.subtract, 10, 20));
Console.WriteLine("Multiply of 10 and 20 is: " + cal.Calculate(Calculator.Operator.multiply, 10, 20));
Console.WriteLine("Dividend of 10 and 20 is: " + cal.Calculate( Calculator.Operator.divide, 10, 20));
Console.WriteLine("-- User input data --");
Console.WriteLine("Result of user input data is: " + cal.Calculate(Validator.InputOperator(), Validator.InputNumber("first number"), Validator.InputNumber("second number")));



