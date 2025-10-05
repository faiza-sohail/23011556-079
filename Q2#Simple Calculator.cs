using System;

class SimpleCalculator
{
    static void Main()
    {
        Console.WriteLine("Enter first number:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter second number:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Choose an operation (+, -, *, /):");
        char op = Convert.ToChar(Console.ReadLine());

        switch (op)
        {
            case '+':
                Console.WriteLine("Result = " + (num1 + num2));
                break;
            case '-':
                Console.WriteLine("Result = " + (num1 - num2));
                break;
            case '*':
                Console.WriteLine("Result = " + (num1 * num2));
                break;
            case '/':
                if (num2 != 0)
                    Console.WriteLine("Result = " + (num1 / num2));
                else
                    Console.WriteLine("Division by zero is not allowed.");
                break;
            default:
                Console.WriteLine("Invalid operation.");
                break;
        }
    }
}
