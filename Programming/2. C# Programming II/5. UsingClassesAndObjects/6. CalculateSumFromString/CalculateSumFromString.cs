using System;

public class CalculateSumFromString
{
    static int[] nums;
    static int sum;

    public static void Main()
    {
        nums = GetUserInput();
        sum = CalculateSum(nums);
        Console.WriteLine("\nThe sum of the numbers is: {0}", sum);
    }

    public static int[] GetUserInput()
    {
        // Inizializing data types
        string userInput;

        // Getting user input
        Console.Write("Enter a few positive numbers on a single line, separated by space.\n");
        Console.Write("==> ");
        userInput = Console.ReadLine();

        // Splitting the user string into array of ints
        string[] part = userInput.Split(' ');

        int[] numbers = new int[part.Length];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(part[i]);
        }

        return numbers;
    }

    public static int CalculateSum(int[] arrayOfNums)
    {
        // Inizializing data types
        int result = 0;

        // Calculating the sum
        for (int i = 0; i < arrayOfNums.Length; i++)
        {
            result = result + arrayOfNums[i];
        }

        return result;
    }
}