namespace Basics;

public class Arrays
{
    public void Sample()
    {
        // Example 1: Creating an Array
        int[] numbers = { 1, 2, 3, 4, 5 };
        int[] number2 = new int[5];
        number2[0] = 1;
        number2[1] = 2;

        var names = new string[] { "Alice", "Bob", "Charlie" };
        object[] objects = { 1, "Alice", true };

        // Example 2: Accessing Array Elements
        int firstNumber = numbers[0]; // Access the first element (1)
        int lastNumber = numbers[numbers.Length - 1]; // Access the last element (5)

        // Example 3: Modifying Array Elements
        numbers[2] = 30; // Change the third element (3) to 30

        // Example 4: Iterating Through an Array
        Console.Write("Array elements: ");
        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }

        //  for loop
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }

        // Example 5: Sorting an Array
        Array.Sort(numbers);

        // Example 6: Reversing an Array
        Array.Reverse(numbers);

        // Example 7: Searching for an Element
        int indexOf4 = Array.IndexOf(numbers, 4);

        // Example 8: Copying an Array
        int[] copiedArray = new int[numbers.Length];
        Array.Copy(numbers, copiedArray, numbers.Length);

        // Example 9: Resizing an Array (not recommended)
        Array.Resize(ref numbers, numbers.Length + 1);
        numbers[numbers.Length - 1] = 6; // Add a new element (6) // numbers[^1] 

        // Example 10: Clearing an Array
        Array.Clear(numbers, 0, numbers.Length);

        // Print results
        Console.WriteLine("Example 1: Creating an Array");
        Console.WriteLine("Array: " + string.Join(" ", numbers));
        Console.WriteLine();

        Console.WriteLine("Example 2: Accessing Array Elements");
        Console.WriteLine("First Number: " + firstNumber);
        Console.WriteLine("Last Number: " + lastNumber);
        Console.WriteLine();

        Console.WriteLine("Example 3: Modifying Array Elements");
        Console.WriteLine("Modified Array: " + string.Join(" ", numbers));
        Console.WriteLine();

        Console.WriteLine("Example 4: Iterating Through an Array");
        Console.WriteLine("Array elements: " + string.Join(" ", numbers));
        Console.WriteLine();

        Console.WriteLine("Example 5: Sorting an Array");
        Console.WriteLine("Sorted Array: " + string.Join(" ", numbers));
        Console.WriteLine();

        Console.WriteLine("Example 6: Reversing an Array");
        Console.WriteLine("Reversed Array: " + string.Join(" ", numbers));
        Console.WriteLine();

        Console.WriteLine("Example 7: Searching for an Element");
        Console.WriteLine("Index of 4: " + indexOf4);
        Console.WriteLine();

        Console.WriteLine("Example 8: Copying an Array");
        Console.WriteLine("Copied Array: " + string.Join(" ", copiedArray));
        Console.WriteLine();

        Console.WriteLine("Example 9: Resizing an Array (not recommended)");
        Console.WriteLine("Resized Array: " + string.Join(" ", numbers));
        Console.WriteLine();

        Console.WriteLine("Example 10: Clearing an Array");
        Console.WriteLine("Cleared Array: " + string.Join(" ", numbers));
        // create instance of array 
        int[] srcArray = { 1, 2, 3, 4, 5 };
        int[] destArray = new int[5];
        int srcIndex = 0;
        int destIndex = 0;

        Array anotherArray = Array.CreateInstance(typeof(int), 5);
        Console.WriteLine("Array: " + string.Join(" ", anotherArray));
        srcArray.CopyTo(anotherArray, 0);

        foreach (int i in anotherArray)
        {
            Console.WriteLine(i);
        }

        // copy elements from source array to destination array
        Array.Copy(srcArray, srcIndex, destArray, destIndex, 5);
        Console.WriteLine("Array: " + string.Join(" ", destArray));
    }

}