using System;

class GradeEvaluator
{
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
}
