using System;

class CountEvenOdd
{
    static void Main()
    {
        int[] arr = new int[10];
        int even = 0, odd = 0;

        Console.WriteLine("Enter 10 integers:");

        for (int i = 0; i < 10; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());

            if (arr[i] % 2 == 0)
                even++;
            else
                odd++;
        }

        Console.WriteLine("Total Even Numbers: " + even);
        Console.WriteLine("Total Odd Numbers: " + odd);
    }
}
