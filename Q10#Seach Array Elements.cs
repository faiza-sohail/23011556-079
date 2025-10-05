using System;

class SearchElement
{
    static void Main()
    {
        int[] arr = new int[10];
        Console.WriteLine("Enter 10 integers:");

        for (int i = 0; i < 10; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Enter the number to search:");
        int search = Convert.ToInt32(Console.ReadLine());

        bool found = false;
        for (int i = 0; i < 10; i++)
        {
            if (arr[i] == search)
            {
                found = true;
                break;
            }
        }

        if (found)
            Console.WriteLine("Number found in the array.");
        else
            Console.WriteLine("Number not found in the array.");
    }
}
