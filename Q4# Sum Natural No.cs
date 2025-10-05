using System;

class SumOfNaturalNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter a number (n):");
        int n = Convert.ToInt32(Console.ReadLine());
        int sum = 0;

        for (int i = 1; i <= n; i++)
        {
            sum = sum + i;
        }

        Console.WriteLine("Sum of natural numbers from 1 to " + n + " = " + sum);
    }
}
