namespace Basics;


class Functions
{
    public void Sample()
    {
        // Example 1: Function with No Parameters and No Return Value
        void SayHello()
        {
            Console.WriteLine("Hello, World!");
        }

        // Calling the function
        SayHello();

        // Example 2: Function with Parameters and No Return Value
        void Greet(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }

        // Calling the function with an argument
        Greet("Alice");

        // Example 3: Function with Parameters and Return Value
        int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        // Calling the function and storing the result
        int result = Add(5, 3);
        Console.WriteLine("Result of addition: " + result);

        // Example 4: Function with Multiple Parameters and Return Value
        double CalculateArea(double radius, double pi)
        {
            return pi * radius * radius;
        }

        // Calling the function with multiple arguments
        double area = CalculateArea(2.5, 3.14159);
        Console.WriteLine("Area of the circle: " + area);

        // Example 5: Function with Default Parameter Value
        void PrintMessage(string message = "Default Message")
        {
            Console.WriteLine(message);
        }

        // Calling the function without providing an argument
        PrintMessage(); // Outputs "Default Message"

        // Calling the function with an argument
        PrintMessage("Custom Message"); // Outputs "Custom Message"

        // Example 6: Function with Variable Number of Parameters (Params)
        int Sum(params int[] numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            return sum;
        }

        // Calling the function with varying numbers of arguments
        int total1 = Sum(1, 2, 3, 4, 5); // Sum of 1 + 2 + 3 + 4 + 5
        int total2 = Sum(10, 20); // Sum of 10 + 20

        // Example 7: Function with Reference Parameters
        void ModifyValue(ref int number)
        {
            number += 10;
        }

        // Calling the function with a reference argument
        int value = 5;
        ModifyValue(ref value);
        Console.WriteLine("Modified Value: " + value); // Outputs "Modified Value: 15"

        // Example 8: Function with Output Parameters
        void GetValues(out int x, out int y)
        {
            x = 10;
            y = 20;
        }

        // Calling the function with output parameters
        int a, b;
        GetValues(out a, out b);
        Console.WriteLine($"a = {a}, b = {b}"); // Outputs "a = 10, b = 20"
    }

}

// ref Parameters:

// The variable passed as a ref parameter must be initialized before it's passed to the method.
// The method can read and modify the value of the ref parameter.
// You can use a ref parameter for both input and output purposes.
// out Parameters:

// The variable passed as an out parameter doesn't need to be initialized before it's passed to the method. It can be uninitialized.
// The method is required to assign a value to the out parameter before it exits the method.
// out parameters are typically used for output values; the method initializes the variable with the result.
// Here's an example that illustrates the difference between ref and out parameters:

// csharp
// using System;

// class Program2
// {
//     static void ModifyValueWithRef(ref int number)
//     {
//         // Method can read and modify the ref parameter
//         number += 10;
//     }

//     static void GetValueWithOut(out int value)
//     {
//         // Method must assign a value to the out parameter
//         value = 42;
//     }

//     static void Main()
//     {
//         // Example with ref parameter
//         int x = 5;
//         ModifyValueWithRef(ref x);
//         Console.WriteLine("Using ref: " + x); // Outputs "Using ref: 15"

//         // Example with out parameter
//         int y;
//         GetValueWithOut(out y);
//         Console.WriteLine("Using out: " + y); // Outputs "Using out: 42"
//     }
// }