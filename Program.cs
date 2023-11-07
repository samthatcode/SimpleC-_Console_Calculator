using System;

class Calculator
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Simple Calculator");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Quit");
            Console.Write("Enter your choice (1-5): ");

            int choice = int.Parse(Console.ReadLine());

            if (choice == 5)
            {
                Console.WriteLine("Calculator exiting. Goodbye!");
                break;
            }

            Console.Write("Enter the first number: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double num2 = double.Parse(Console.ReadLine());

            double result = 0;

            switch (choice)
            {
                case 1:
                    result = num1 + num2;
                    break;
                case 2:
                    result = num1 - num2;
                    break;
                case 3:
                    result = num1 * num2;
                    break;
                case 4:
                    if (num2 == 0)
                    {
                        Console.WriteLine("Error: Division by zero");
                    }
                    else
                    {
                        result = num1 / num2;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;
            }

            Console.WriteLine($"Result: {result}");
        }
    }
}
