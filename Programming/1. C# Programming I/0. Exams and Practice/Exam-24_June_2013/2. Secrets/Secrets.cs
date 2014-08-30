using System;
using System.Collections.Generic;

public class Secrets
{
    public static void Main()
    {
        // PART I - Special Sum

        // Getting input
        int specialSum = 0;
        string number = Console.ReadLine();
        List<int> digitsList = new List<int>();

        // Converting to int list
        foreach (char digit in number)
        {
            if (Char.GetNumericValue(digit) < 0)
            {
                continue;
            }
            else
            {
                digitsList.Add((int)Char.GetNumericValue(digit));
            }
        }
        
        // Initializing new Array of ints
        int[] digitsArray = new int[digitsList.Count];
        digitsArray = digitsList.ToArray();

        // Reversing the array
        Array.Reverse(digitsArray);

        for (int position = 1; position <= digitsArray.Length; position++)
        {
            if (position % 2 != 0) // If position in the number is odd
            {
                specialSum += digitsArray[position - 1] * (position * position);
            }
            else // If position in the number is even
            {
                specialSum += (digitsArray[position - 1] * digitsArray[position - 1]) * position;
            }
        }

        // Printing the special number
        Console.WriteLine(specialSum);


        // PART II - Secret Alpha-sequence

        int remainder = specialSum % 26;
        int firstLetterPosition = remainder + 1;
        string alphaSequence = string.Empty;
        
        // Finding the length of the sequence
        int lengthOfSequence = specialSum % 10;
        int currentLetterPosition = 0;

        // Finding the alpha-sequence
        if (lengthOfSequence != 0)
        {
            for (int position = 0; position < lengthOfSequence; position++)
            {
                currentLetterPosition = firstLetterPosition + 64 + position;

                if (currentLetterPosition < 91)
                {
                    alphaSequence += (char)currentLetterPosition;
                }
                else
                {
                    alphaSequence += (char)(currentLetterPosition - 26);
                }
            }
        }
        else
        {
            Console.WriteLine(number + " has no secret alpha-sequence");
        }

        Console.WriteLine(alphaSequence);
    }
}