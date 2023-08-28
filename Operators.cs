using System;


namespace Basics;


class Operators
{
    public static void Sample()
    {
        int a = 5, b = 10;
        bool isTrue = true, isFalse = false;

        // Relational Operators
        Console.WriteLine("Relational Operators:");
        Console.WriteLine($"a == b: {a == b}");   // Equal to
        Console.WriteLine($"a != b: {a != b}");   // Not equal to
        Console.WriteLine($"a < b: {a < b}");     // Less than
        Console.WriteLine($"a > b: {a > b}");     // Greater than
        Console.WriteLine($"a <= b: {a <= b}");   // Less than or equal to
        Console.WriteLine($"a >= b: {a >= b}");   // Greater than or equal to

        // Logical Operators
        Console.WriteLine("\nLogical Operators:");
        Console.WriteLine($"isTrue && isFalse: {isTrue && isFalse}"); // Logical AND
        Console.WriteLine($"isTrue || isFalse: {isTrue || isFalse}"); // Logical OR
        Console.WriteLine($"!isTrue: {!isTrue}");                     // Logical NOT

        // Arithmetic Operators
        Console.WriteLine("\nArithmetic Operators:");
        Console.WriteLine($"a + b: {a + b}");   // Addition
        Console.WriteLine($"a - b: {a - b}");   // Subtraction
        Console.WriteLine($"a * b: {a * b}");   // Multiplication
        Console.WriteLine($"a / b: {a / b}");   // Division
        Console.WriteLine($"a % b: {a % b}");   // Modulus

        // Assignment Operators
        Console.WriteLine("\nAssignment Operators:");
        int x = 20;
        x += 5; // Equivalent to x = x + 5
        Console.WriteLine($"x += 5: {x}");
        x -= 3; // Equivalent to x = x - 3
        Console.WriteLine($"x -= 3: {x}");
        x *= 2; // Equivalent to x = x * 2
        Console.WriteLine($"x *= 2: {x}");
        x /= 4; // Equivalent to x = x / 4
        Console.WriteLine($"x /= 4: {x}");
        x %= 5; // Equivalent to x = x % 5
        Console.WriteLine($"x %= 5: {x}");

        // Conditional Operator (Ternary Operator)
        Console.WriteLine("\nConditional Operator:");
        int number = 7;
        string result = (number % 2 == 0) ? "Even" : "Odd";
        Console.WriteLine($"The number is {result}.");





    }
}