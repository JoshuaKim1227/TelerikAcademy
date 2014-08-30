using System;

public class VariationsOfK
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

        Console.WriteLine("\nCombinations are:");
        NestedLoops(0);
    }

    public static void NestedLoops(int currentIndex)
    {
        if (currentIndex == endIndex)
        {
            PrintLoops();
            return;
        }

        for (int counter = 1; counter <= numberOfIterations; counter++)
        {
            loops[currentIndex] = counter;
            NestedLoops(currentIndex + 1);
        }
    }

    public static void PrintLoops()
    {
        for (int i = 0; i < endIndex; i++)
        {
            Console.Write("{0} ", loops[i]);
        }

        Console.WriteLine();
    }
}