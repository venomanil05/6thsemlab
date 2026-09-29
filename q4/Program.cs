using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Create a list of numbers
        List<int> numbers = new List<int>
        {
            1, 2, 3, 4, 5,
            6, 7, 8, 9, 10
        };

        // Lambda expression to find even numbers
        var evenNumbers = numbers.Where(n => n % 2 == 0);

        // Lambda expression to find square of numbers
        var squares = numbers.Select(n => n * n);

        // Display original numbers
        Console.WriteLine("Original Numbers:");

        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }

        Console.WriteLine("\n");

        // Display even numbers
        Console.WriteLine("Even Numbers:");

        foreach (int number in evenNumbers)
        {
            Console.Write(number + " ");
        }

        Console.WriteLine("\n");

        // Display square of numbers
        Console.WriteLine("Square of Numbers:");

        foreach (int square in squares)
        {
            Console.Write(square + " ");
        }

        Console.WriteLine();
    }
}
