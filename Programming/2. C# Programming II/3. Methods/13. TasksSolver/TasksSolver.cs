using System;

public class TasksSolver
{
    public static void Main()
    {
        int choice = GetTaskChoice();

        if (choice == 1) // Reverse digits
        {
            int num = GetDecimalNumber();
            int reveredNumber = DigitsReverser.ReverseDigits(num);
            PrintResult(reveredNumber, choice);
        }
        else if (choice == 2) // Calculate average of sequence
        {
            int[] sequenceOfInts = GetSequenceOfInts();
            decimal averageOfSequence = CalculateAverage(sequenceOfInts);
            PrintResult(averageOfSequence, choice);
        }
        else if (choice == 3) // Solve linear equation
        {
            SolveLinearEqation();
        }
    }

    public static int GetTaskChoice()
    {
        // Inizializing data types
        int taskChoice = 0;

        // Printing the possible choices on the screen
        Console.WriteLine("Please select the task you want to be solved:");
        Console.WriteLine();
        Console.WriteLine("1. Reverse the digits of a number");
        Console.WriteLine("2. Calculate the average of a sequence of integers");
        Console.WriteLine("3. Solve a linear equation [a * x + b = 0]");
        Console.WriteLine();
        Console.WriteLine("(Choose 1, 2 or 3)");
        Console.Write("Your Choice: ");

        // General validation and getting user choice
        while (!int.TryParse(Console.ReadLine(), out taskChoice) || (taskChoice < 1 || taskChoice > 3))
        {
            Console.WriteLine("\nInvalid Input!");
            Console.WriteLine("(Choose 1, 2 or 3) ");
            Console.Write("Your Choice: ");
        }

        return taskChoice;
    }

    public static int GetDecimalNumber()
    {
        // Inizializing data types
        int number;

        // General validation and getting user choice
        Console.Write("Enter a positive integer: ");
        while (!int.TryParse(Console.ReadLine(), out number) || number < 1)
        {
            Console.WriteLine("\nInvalid Input!");
            Console.Write("Enter a positive integer: ");
        }

        return number;
    }

    public static int[] GetSequenceOfInts()
    {
        // Inizializing data types
        int arrayLength;

        // Getting the length of the sequence and validating the input
        Console.Write("\nEnter a positive number (higher than 1) for the length of the sequence: ");

        while (!int.TryParse(Console.ReadLine(), out arrayLength) || arrayLength < 1)
        {
            Console.WriteLine("\nInvalid Input!");
            Console.Write("Enter a positive number: ");
        }

        // Inizializing the sequence (array) with the given length
        int[] arrayOfInts = new int[arrayLength];

        // Getting the numbers for the sequence and validating the input
        Console.WriteLine("\nYou should enter {0} integer numbers for the sequence", arrayLength);

        for (int numPlace = 1; numPlace <= arrayLength; numPlace++)
        {
            Console.Write("Enter a num for the {0}-th place: ", numPlace);

            while (!int.TryParse(Console.ReadLine(), out arrayOfInts[numPlace - 1]) || arrayOfInts[numPlace - 1] < 1)
            {
                Console.WriteLine("\nInvalid Input!");
                Console.Write("Enter a num for the {0}-th place: ", numPlace);
            }
        }

        return arrayOfInts;
    }

    public static decimal CalculateAverage(int[] sequence)
    {
        decimal sum = 0;
        decimal average;

        for (int index = 0; index < sequence.Length; index++)
        {
            sum = sum + (decimal)sequence[index];
        }

        average = sum / sequence.Length;

        return average;
    }

    public static void SolveLinearEqation()
    {
        // Getting user input
        Console.Write("a=");
        decimal a = decimal.Parse(Console.ReadLine());

        // Solving the equation
        if (a != 0)
        {
            Console.Write("b=");
            decimal b = decimal.Parse(Console.ReadLine());
            decimal x = b / a;
            Console.WriteLine();
            Console.WriteLine("a * x + b = 0");
            Console.WriteLine("x={0}", x);
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Input 'a' can NOT be Zero!");
        }
    }

    public static void PrintResult(decimal result, int taskNumber)
    {
        if (taskNumber == 1) // Reverse digits
        {
            Console.Write("\nThe reversed digit is: {0}\n", result);
        }
        else if (taskNumber == 2) // Calculate average of sequence
        {
            Console.Write("\nThe average of the sequence is: {0}\n", result);
        }
        else if (taskNumber == 3) // Solve linear equation
        {
            Console.Write("\nThe result of the equation [a * x + b = 0] is: {0}\n", result);
        }
    }
}