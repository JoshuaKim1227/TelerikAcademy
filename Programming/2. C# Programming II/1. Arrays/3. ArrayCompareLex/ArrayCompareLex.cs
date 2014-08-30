using System;

public class ArrayCompareLex
{
    public static void Main()
    {
        // Initializing data types
        int arrayLength;
        string firstArrayString;
        string secondArrayString;

        // Getting the content of the arrays from the user
        Console.WriteLine("Please enter the chars of the first array (on a single line): ");
        firstArrayString = Console.ReadLine();
        char[] firstArray = firstArrayString.ToCharArray();

        Console.WriteLine("Please enter the chars of the second array (on a single line): ");
        secondArrayString = Console.ReadLine();
        char[] secondArray = secondArrayString.ToCharArray();

        // Checking which array is shorter
        if (firstArray.Length < secondArray.Length)
        {
            arrayLength = firstArray.Length;
        }
        else
        {
            arrayLength = secondArray.Length;
        }

        // Iterating the arrays to check the lexicographical order
        for (int i = 0; i < arrayLength; i++)
        {
            if (firstArray[i] < secondArray[i])
            {
                Console.WriteLine("The lexicographical order is: \n 1. {0} \n 2. {1}", firstArrayString, secondArrayString);
                break;
            }

            if (secondArray[i] < firstArray[i])
            {
                Console.WriteLine("The lexicographical order is: \n 1. {0} \n 2. {1}", secondArrayString, firstArrayString);
                break;
            }

            if ((firstArray[i] == secondArray[i]) && (i == arrayLength - 1))
            {
                if (firstArray.Length < secondArray.Length)
                {
                    Console.WriteLine("The lexicographical order is: \n 1. {0} \n 2. {1}", firstArrayString, secondArrayString);
                break;
                }

                if (secondArray.Length < firstArray.Length)
                {
                    Console.WriteLine("The lexicographical order is: \n 1. {0} \n 2. {1}", secondArrayString, firstArrayString);
                break;
                }

                if (firstArray.Length == secondArray.Length)
                {
                    Console.WriteLine("The arrays can't be ordered lexicographically.");
                    break;
                }
            }
        }
    }
}