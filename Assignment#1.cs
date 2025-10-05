using System;

// 1. Even or Odd Checker
class EvenOddChecker
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num % 2 == 0)
            Console.WriteLine("The number is even.");
        else
            Console.WriteLine("The number is odd.");
    }
}

// 2. Simple Calculator
class SimpleCalculator
{
    // Uncomment this Main() when testing this program
    /*
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
    */
}

// 3. Grade Evaluator
class GradeEvaluator
{
    /*
    static void Main()
    {
        Console.WriteLine("Enter your marks (0 - 100):");
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
    */
}

// 4. Sum of Natural Numbers
class SumOfNaturalNumbers
{
    /*
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
    */
}

// 5. Multiplication Table
class MultiplicationTable
{
    /*
    static void Main()
    {
        Console.WriteLine("Enter a number to print its multiplication table:");
        int num = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(num + " x " + i + " = " + (num * i));
        }
    }
    */
}

// 6. Factorial Calculator
class FactorialCalculator
{
    /*
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
    */
}

// 7. Reverse a Number
class ReverseNumber
{
    /*
    static void Main()
    {
        Console.WriteLine("Enter an integer:");
        int num = Convert.ToInt32(Console.ReadLine());
        int reversed = 0;

        while (num != 0)
        {
            int digit = num % 10;
            reversed = reversed * 10 + digit;
            num = num / 10;
        }

        Console.WriteLine("Reversed number = " + reversed);
    }
    */
}

// 8. Array - Find Maximum and Minimum
class ArrayMaxMin
{
    /*
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
    */
}

// 9. Array - Count Even and Odd Numbers
class CountEvenOdd
{
    /*
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
    */
}

// 10. Array - Search Element
class SearchElement
{
    /*
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
    */
}
