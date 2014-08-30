using System;

class Carpets
{
    static void Main()
    {
        // Inizializing variables
        int length = 0;
        int stripeCounter = 0;

        // Getting input
        length = int.Parse(Console.ReadLine());

        // Printing Top-Left Part
        for (int row = 0; row < length / 2; row++)
        {
            stripeCounter = 0;
            for (int col = 1; col <= length / 2; col++)
            {
                if (col < length / 2 - row)
                {
                    Console.Write(".");
                }
                else
                {
                    stripeCounter++;
                    if (stripeCounter % 2 != 0)
                    {
                        Console.Write("/");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
            }
            stripeCounter = 0;

            // Printing Top-Right Part
            for (int col = length; col >= length / 2 + 1; col--)
            {
                if (col < length - row)
                {
                    Console.Write(".");
                }
                else
                {
                    stripeCounter++;
                    if (stripeCounter % 2 != 0 && row % 2 == 0)
                    {
                        Console.Write("\\");
                    }
                    else if (stripeCounter % 2 == 0 && row % 2 != 0)
                    {
                        Console.Write("\\");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
            }
            Console.WriteLine();
        }

        // Printing Bottom-Left Part
        for (int row = length / 2 - 1; row >= 0; row--)
        {
            stripeCounter = 0;
            for (int col = 1; col <= length / 2; col++)
            {
                if (col < length / 2 - row)
                {
                    Console.Write(".");
                }
                else
                {
                    stripeCounter++;
                    if (stripeCounter % 2 != 0)
                    {
                        Console.Write("\\");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
            }
            stripeCounter = 0;

            // Printing Bottom-Right Part
            for (int col = length; col >= length / 2 + 1; col--)
            {
                if (col < length - row)
                {
                    Console.Write(".");
                }
                else
                {
                    stripeCounter++;
                    if (stripeCounter % 2 != 0 && row % 2 == 0)
                    {
                        Console.Write("/");
                    }
                    else if (stripeCounter % 2 == 0 && row % 2 != 0)
                    {
                        Console.Write("/");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}