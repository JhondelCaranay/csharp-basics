namespace Basics;
class Formatting
{
    public void Sample()
    {
        // String Interpolation (C# 6.0 and later)
        string name = "Alice";
        int age = 30;
        Console.WriteLine($"My name is {name} and I am {age} years old.");

        // Composite Formatting (String.Format)
        string formattedString = string.Format("Hello, {0}! Your score is {1}.", "Bob", 95);
        Console.WriteLine(formattedString);

        // Formatting with Placeholders and Concatenation
        string fruit = "apple";
        int quantity = 3;
        string output = "I have " + quantity + " " + fruit + "s.";
        Console.WriteLine(output);

        // Using Format Specifiers
        double price = 12.3456;
        Console.WriteLine($"Price: {price:C}"); // Currency format
        Console.WriteLine($"Price: {price:F2}"); // Fixed-point format with 2 decimal places

        // String Alignment
        string item = "Apple";
        string priceText = "1.50";
        Console.WriteLine($"{item,-10}{priceText,10}");

        // DateTime Formatting
        DateTime now = DateTime.Now;
        Console.WriteLine($"Long Date: {now:dddd, MMMM dd, yyyy}");
        Console.WriteLine($"Short Date: {now:d}");
    }
}