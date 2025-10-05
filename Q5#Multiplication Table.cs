using System;

class MultiplicationTable
{
    static void Main()
    {
        Console.WriteLine("Enter a number to print its multiplication table:");
        int num = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(num + " x " + i + " = " + (num * i));
        }
    }
}
