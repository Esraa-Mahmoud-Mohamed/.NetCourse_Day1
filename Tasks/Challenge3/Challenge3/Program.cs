using System;

class BasicCalculator
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter an operation (+, -, *, /): ");
            char operation = Console.ReadLine()[0];

            switch (operation)
            {
                case '+':
                    Console.WriteLine($"Result: {num1} + {num2} = {num1 + num2}");
                    break;

                case '-':
                    Console.WriteLine($"Result: {num1} - {num2} = {num1 - num2}");
                    break;

                case '*':
                    Console.WriteLine($"Result: {num1} * {num2} = {num1 * num2}");
                    break;

                case '/':
                    if (num2 != 0)
                    {
                        Console.WriteLine($"Result: {num1} / {num2} = {num1 / num2}");
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                    }
                    break;

                default:
                    Console.WriteLine("Error: Invalid operation. Please use +, -, *, or /.");
                    break;
            }
        }
    }
}
