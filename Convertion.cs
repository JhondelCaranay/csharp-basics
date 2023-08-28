using System;

namespace Basics
{
    public class Conversion
    {
        public void ConversionSamnple()
        {
            // Implicit conversion (Widening Conversion)
            int num1 = 10;
            long num2 = num1; // int to long

            Console.WriteLine($"Implicit Conversion: int to long - num2 = {num2}");

            // Explicit conversion (Narrowing Conversion)
            double x = 123.45;
            int y = (int)x; // double to int (fractional part truncated)

            Console.WriteLine($"Explicit Conversion: double to int - y = {y}");

            // Type casting
            double pi = 3.14159265359;
            int roundedPi = (int)pi; // double to int (fractional part truncated)

            Console.WriteLine($"Type Casting: double to int - roundedPi = {roundedPi}");

            // Parse and TryParse
            string numberStr = "42";
            int number;
            if (int.TryParse(numberStr, out number))
            {
                Console.WriteLine($"Parsing: String to int - number = {number}");
            }
            else
            {
                Console.WriteLine("Parsing failed.");
            }


            // use parse only when you are sure that the string is a valid number
            int number2 = int.Parse(numberStr);


            // Using the Convert class
            int intValue = 42;
            double doubleValue = Convert.ToDouble(intValue); // int to double

            Console.WriteLine($"Using Convert class: int to double - doubleValue = {doubleValue}");
        }
    }
}
