namespace Basics;

public class Loops
{
    public void Sample()
    {
        // While Loop Example
        Console.WriteLine("While Loop Example:");
        int i = 1;
        while (i <= 5)
        {
            Console.WriteLine(i);
            i++;
        }

        // For Loop Example
        Console.WriteLine("\nFor Loop Example:");
        for (int j = 1; j <= 5; j++)
        {
            Console.WriteLine(j);
        }

        // ForEach Loop Example
        Console.WriteLine("\nForEach Loop Example:");
        int[] numbers = { 1, 2, 3, 4, 5 };
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        // Map, Filter, and Reduce Examples
        Console.WriteLine("\nMap, Filter, and Reduce Examples:");

        // Map: Doubling each element
        List<int> doubledNumbers = numbers.Select(n => n * 2).ToList();
        Console.WriteLine("Map (Doubling): " + string.Join(", ", doubledNumbers));

        // Filter: Selecting even numbers
        List<int> evenNumbers = numbers.Where(n => n % 2 == 0).ToList();
        Console.WriteLine("Filter (Evens): " + string.Join(", ", evenNumbers));

        // Reduce: Sum of all elements
        int sum = numbers.Aggregate((acc, n) => acc + n);
        Console.WriteLine("Reduce (Sum): " + sum);
    }
}