using System;

namespace Basics;
class Conditions
{
    static void Sample()
    {
        // Example 1: Basic If Statement
        int age = 25;
        if (age >= 18)
        {
            Console.WriteLine("You are an adult.");
        }

        // Example 2: If-Else Statement
        int grade = 85;
        if (grade >= 60)
        {
            Console.WriteLine("You passed.");
        }
        else
        {
            Console.WriteLine("You failed.");
        }

        // Example 3: If-Else If-Else Statement
        int score = 75;
        if (score >= 90)
        {
            Console.WriteLine("A");
        }
        else if (score >= 80)
        {
            Console.WriteLine("B");
        }
        else if (score >= 70)
        {
            Console.WriteLine("C");
        }
        else
        {
            Console.WriteLine("D");
        }


        // Example 4: Nested If Statements
        bool isSunny = true;
        bool isWarm = true;
        if (isSunny)
        {
            if (isWarm)
            {
                Console.WriteLine("It's a sunny and warm day!");
            }
            else
            {
                Console.WriteLine("It's sunny but not very warm.");
            }
        }
        else
        {
            Console.WriteLine("It's not sunny.");
        }

        // Logical Operators
        if (isSunny && isWarm)
        {
            Console.WriteLine("It's sunny and warm outside.");
        }
        else if (isSunny || isWarm)
        {
            Console.WriteLine("It's either sunny or warm outside.");
        }
        else
        {
            Console.WriteLine("It's neither sunny nor warm outside.");
        }


        // Example 5: Ternary Operator (Conditional Operator)
        int number = 7;
        string result = (number % 2 == 0) ? "Even" : "Odd";
        Console.WriteLine($"The number is {result}.");


        int number2 = 10;
        string result2;

        // Using a ternary operator to assign a value to 'result' based on the condition
        result2 = (number2 > 5) ? "Number is greater than 5" : "Number is not greater than 5";

        Console.WriteLine(result2);

        // Example 6: Switch Statement
        int dayOfWeek = 3;
        switch (dayOfWeek)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            default:
                Console.WriteLine("Other day");
                break;
        }

        // Example 7: Pattern Matching (C# 7 and later)
        object obj = "Hello";
        if (obj is string text)
        {
            Console.WriteLine($"The variable is a string: {text}");
        }
        else
        {
            Console.WriteLine("The variable is not a string.");
        }
    }
}
