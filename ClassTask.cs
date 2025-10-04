using System;

// 1️⃣ Even or Odd Checker
class EvenOddChecker
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num % 2 == 0)
            Console.WriteLine($"{num} is Even.");
        else
            Console.WriteLine($"{num} is Odd.");
    }
}

// 2️⃣ Simple Calculator
class SimpleCalculator
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Choose operation (+, -, *, /): ");
        char op = Convert.ToChar(Console.ReadLine());

        switch (op)
        {
            case '+': Console.WriteLine($"Result: {num1 + num2}"); break;
            case '-': Console.WriteLine($"Result: {num1 - num2}"); break;
            case '*': Console.WriteLine($"Result: {num1 * num2}"); break;
            case '/':
                if (num2 != 0)
                    Console.WriteLine($"Result: {num1 / num2}");
                else
                    Console.WriteLine("Error! Division by zero.");
                break;
            default: Console.WriteLine("Invalid operation."); break;
        }
    }
}

// 3️⃣ Grade Evaluator
class GradeEvaluator
{
    static void Main()
    {
        Console.Write("Enter marks (0–100): ");
        int marks = Convert.ToInt32(Console.ReadLine());

        if (marks >= 85)
            Console.WriteLine("Grade: A");
        else if (marks >= 70)
            Console.WriteLine("Grade: B");
        else if (marks >= 55)
            Console.WriteLine("Grade: C");
        else if (marks >= 40)
            Console.WriteLine("Grade: D");
        else
            Console.WriteLine("Grade: F");
    }
}

// 4️⃣ Sum of Natural Numbers
class SumOfNumbers
{
    static void Main()
    {
        Console.Write("Enter a number n: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        for (int i = 1; i <= n; i++) sum += i;
        Console.WriteLine($"Sum of numbers from 1 to {n} = {sum}");
    }
}

// 5️⃣ Multiplication Table
class MultiplicationTable
{
    static void Main()
    {
        Console.Write("Enter a number for its multiplication table: ");
        int num = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= 10; i++)
            Console.WriteLine($"{num} x {i} = {num * i}");
    }
}

// 6️⃣ Factorial Calculator
class FactorialCalculator
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        long fact = 1;
        int i = 1;
        while (i <= num)
        {
            fact *= i;
            i++;
        }
        Console.WriteLine($"Factorial of {num} = {fact}");
    }
}

// 7️⃣ Reverse a Number
class ReverseNumber
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int reversed = 0;
        while (num > 0)
        {
            int digit = num % 10;
            reversed = reversed * 10 + digit;
            num /= 10;
        }
        Console.WriteLine($"Reversed number = {reversed}");
    }
}

// 8️⃣ Array - Find Maximum and Minimum
class ArrayMaxMin
{
    static void Main()
    {
        int[] arr = new int[10];
        Console.WriteLine("Enter 10 numbers:");
        for (int i = 0; i < 10; i++)
            arr[i] = Convert.ToInt32(Console.ReadLine());

        int max = arr[0], min = arr[0];
        foreach (int num in arr)
        {
            if (num > max) max = num;
            if (num < min) min = num;
        }
        Console.WriteLine($"Maximum = {max}, Minimum = {min}");
    }
}

// 9️⃣ Array - Count Even and Odd Numbers
class CountEvenOdd
{
    static void Main()
    {
        int[] arr = new int[10];
        int even = 0, odd = 0;

        Console.WriteLine("Enter 10 numbers:");
        for (int i = 0; i < 10; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
            if (arr[i] % 2 == 0) even++;
            else odd++;
        }
        Console.WriteLine($"Even numbers: {even}, Odd numbers: {odd}");
    }
}

// 🔟 Array - Search Element
class ArraySearch
{
    static void Main()
    {
        int[] arr = new int[10];
        Console.WriteLine("Enter 10 numbers:");
        for (int i = 0; i < 10; i++)
            arr[i] = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter number to search: ");
        int key = Convert.ToInt32(Console.ReadLine());

        bool found = false;
        foreach (int num in arr)
        {
            if (num == key)
            {
                found = true;
                break;
            }
        }

        if (found)
            Console.WriteLine($"{key} is found in the array.");
        else
            Console.WriteLine($"{key} is not found in the array.");
    }
}
