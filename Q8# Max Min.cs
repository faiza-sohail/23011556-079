using System;

class ArrayMaxMin
{
    static void Main()
    {
        int[] arr = new int[10];
        Console.WriteLine("Enter 10 integers:");

        for (int i = 0; i < 10; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        int max = arr[0];
        int min = arr[0];

        for (int i = 1; i < 10; i++)
        {
            if (arr[i] > max)
                max = arr[i];
            if (arr[i] < min)
                min = arr[i];
        }

        Console.WriteLine("Maximum number = " + max);
        Console.WriteLine("Minimum number = " + min);
    }
}
