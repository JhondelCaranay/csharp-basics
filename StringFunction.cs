using System;

namespace Basics;
class StringFunction
{
    public void Sample()
    {
        // Creating strings
        string greeting = "Hello, World!";
        string name = "Alice";
        string emptyString = string.Empty;

        // Concatenation
        string concatenated = greeting + " My name is " + name;
        Console.WriteLine("Concatenation: " + concatenated);

        // String Length
        int length = greeting.Length;
        Console.WriteLine("Length of greeting: " + length);

        // Substring
        // string substring = greeting[..5];;  // C# 8.0 and later
        string substring = greeting.Substring(0, 5);
        Console.WriteLine("Substring: " + substring);

        // IndexOf
        int indexOfWorld = greeting.IndexOf("World");
        Console.WriteLine("Index of 'World': " + indexOfWorld);

        // ToUpper and ToLower
        string upperCase = greeting.ToUpper();
        string lowerCase = greeting.ToLower();
        Console.WriteLine("Uppercase: " + upperCase);
        Console.WriteLine("Lowercase: " + lowerCase);

        // Replace
        string replaced = greeting.Replace("World", "Universe");
        Console.WriteLine("Replace: " + replaced);

        // Contains
        bool containsAlice = greeting.Contains("Alice");
        Console.WriteLine("Contains 'Alice': " + containsAlice);

        // compare strings , -1 , 0 , 1
        string str1 = "Hello";
        string str2 = "HelloB";
        int result = string.Compare(str1, str2);
        Console.WriteLine("Compare: " + result);

        // IsNullOrEmpty and IsNullOrWhiteSpace
        bool isNullOrEmpty = string.IsNullOrEmpty(emptyString);
        bool isNullOrWhiteSpace = string.IsNullOrWhiteSpace(emptyString);
        Console.WriteLine("IsNullOrEmpty: " + isNullOrEmpty);
        Console.WriteLine("IsNullOrWhiteSpace: " + isNullOrWhiteSpace);

        // insert
        string insert = greeting.Insert(5, "there ");
        Console.WriteLine("Insert: " + insert);

        // remove
        string remove = greeting.Remove(5, 7);
        Console.WriteLine("Remove: " + remove);

        // padding
        string padding = "Hello";
        Console.WriteLine("PadLeft: " + padding.PadLeft(10));
        Console.WriteLine("PadRight: " + padding.PadRight(10));
        Console.WriteLine("PadLeft with char: " + padding.PadLeft(10, '-'));
        Console.WriteLine("PadRight with char: " + padding.PadRight(10, '-'));


        // trim 
        string trim = "   Hello   ";
        Console.WriteLine("Trim: " + trim.Trim());
        Console.WriteLine("TrimStart: " + trim.TrimStart());
        Console.WriteLine("TrimEnd: " + trim.TrimEnd());


        // Using escape characters in a string
        string escapeString = "This is a string with escape characters:\nNew Line\tTab\\Backslash\"Double Quotes";
        Console.WriteLine(escapeString);

        // Creating a new variable with escape characters
        string newVariableWithEscapes = "First Line\nSecond Line\nThird Line";
        Console.WriteLine(newVariableWithEscapes);

        // using @ symbol to ignore escape characters
        string atString = @"This is a string with escape characters:\nNew Line\tTab\\Backslash""Double Quotes";
        Console.WriteLine(atString);
    }
}