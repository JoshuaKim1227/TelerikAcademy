using System;

public class VariationsOfKDistinct
{
    static int endIndex;
    static int numberOfIterations;
    static int[] loops;

    public static void Main()
    {
        // Inizializing data types and getting user input
        Console.WriteLine("Please enter two numbers (N) and (K) [on separate lines]:");
        numberOfIterations = int.Parse(Console.ReadLine());
        endIndex = int.Parse(Console.ReadLine());

        loops = new int[endIndex];

        Console.WriteLine("\nDistinct combinations are:");
        NestedLoops(loops, 0, 1);
    }

    // Recursively counting the numbers
    public static void NestedLoops(int[] array, int currentIndex, int currentNumber)
    {
        // If Current Index is outside the boundaries of the array
        // prints the result and terminates the execution of the method
        if (currentIndex == loops.Length)
        {
            PrintLoops(array);
            return;
        }

        // Here the recursion takes place. Assigning a value to the Current Index
        // and recursively calls itself again. At each recursive call the method gets
        // Current Index + 1 and Current value of counter + 1
        for (int counter = currentNumber; counter <= numberOfIterations; counter++)
        {
            loops[currentIndex] = counter;
            NestedLoops(loops, currentIndex + 1, counter + 1);
        }
    }

    // Printing the result
    public static void PrintLoops(int[] array)
    {
        for (int i = 0; i < loops.Length; i++)
        {
            Console.Write("{0} ", array[i]);
        }

        Console.WriteLine();
    }
}