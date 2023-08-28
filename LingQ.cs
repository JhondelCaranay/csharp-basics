using System;
using System.Collections.Generic;
using System.Linq;

namespace Basics;

class LingQ
{
    public void Sample()
    {
        // Example 1: Using Select to project elements
        Console.WriteLine("Example 1: Using Select");
        var numbers = new int[] { 1, 2, 3, 4, 5 };
        var squares = numbers.Select(n => n * n);
        Console.WriteLine("Squares: " + string.Join(", ", squares));
        Console.WriteLine();

        // Example 2: Using Where to filter elements
        Console.WriteLine("Example 2: Using Where");
        var evens = numbers.Where(n => n % 2 == 0);
        Console.WriteLine("Even numbers: " + string.Join(", ", evens));
        Console.WriteLine();

        // Example 3: Using Aggregate to calculate the sum
        Console.WriteLine("Example 3: Using Aggregate");
        var sum = numbers.Aggregate((acc, n) => acc + n);
        Console.WriteLine("Sum: " + sum);
        Console.WriteLine();

        // Example 4: Using Select with anonymous types
        Console.WriteLine("Example 4: Using Select with Anonymous Types");
        var people = new List<Person>
        {
            new Person { Name = "Alice", Age = 30 },
            new Person { Name = "Bob", Age = 25 },
            new Person { Name = "Charlie", Age = 35 }
        };

        var namesAndAges = people.Select(p => new { p.Name, p.Age });
        foreach (var person in namesAndAges)
        {
            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
        }
    }
}

class Person
{
    public required string Name { get; set; }
    public int Age { get; set; }
}