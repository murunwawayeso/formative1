using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main()
    {
        Console.Write("Enter student name: ");
        string name = Console.ReadLine();
        DateTime now = DateTime.Now;

        double mark1 = GetValidMark("Enter mark 1: ");
        double mark2 = GetValidMark("Enter mark 2: ");
        double mark3 = GetValidMark("Enter mark 3: ");

        double total = mark1 + mark2 + mark3;
        double average = total / 3;

        string result = average >= 50 ? "PASS" : "FAIL";
        string formatted = now.ToString("dd MMMM yyyy HH:mm:ss");

        Console.WriteLine("\n--- Student Results ---");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Total: {total}");
        Console.WriteLine($"Average: {average:F2}");
        Console.WriteLine($"Result: {result}");
        Console.WriteLine("Result Issued At:" + formatted);
    }

    static double GetValidMark(string message)
    {
        double mark;
        while (true)
        {
            Console.Write(message);
            if (double.TryParse(Console.ReadLine(), out mark))
                return mark;
            else
                Console.WriteLine("Invalid input. Enter a numeric value.");
        }
    }
}