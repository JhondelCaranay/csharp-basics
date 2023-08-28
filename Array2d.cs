namespace Basics;

public class Arrays2d
{
    public void Sample()
    {
        int[,] matrix = new int[3, 3]
        {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        Console.WriteLine("Example 1: Creating a 2D Array");
        Print2DArray(matrix);

        // Example 2: Accessing Elements
        int element = matrix[1, 2]; // Access the element at row 1, column 2 (6)
        Console.WriteLine("\nExample 2: Accessing Elements");
        Console.WriteLine("Element at matrix[1, 2]: " + element);

        // Example 3: Modifying Elements
        matrix[0, 0] = 99; // Change the element at row 0, column 0 to 99
        Console.WriteLine("\nExample 3: Modifying Elements");
        Print2DArray(matrix);

        // Example 4: Iterating Through a 2D Array with Nested Loops
        Console.WriteLine("\nExample 4: Iterating Through a 2D Array");
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write(matrix[row, col] + "\t");
            }
            Console.WriteLine();
        }
    }

    // Helper method to print a 2D array
    static void Print2DArray(int[,] array)
    {
        for (int row = 0; row < array.GetLength(0); row++)
        {
            for (int col = 0; col < array.GetLength(1); col++)
            {
                Console.Write(array[row, col] + "\t");
            }
            Console.WriteLine();
        }
    }
}