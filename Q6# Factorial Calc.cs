using System;

class FactorialCalculator
{
    static void Main()
    {
        Console.WriteLine("Enter a number to find its factorial:");
        int num = Convert.ToInt32(Console.ReadLine());
        int fact = 1;
        int i = 1;

        while (i <= num)
        {
            fact = fact * i;
            i++;
        }

        Console.WriteLine("Factorial of " + num + " = " + fact);
    }
}
