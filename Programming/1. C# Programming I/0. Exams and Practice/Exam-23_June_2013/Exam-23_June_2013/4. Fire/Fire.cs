using System;

public class Fire
{
    public static void Main()
    {
        int width = int.Parse(Console.ReadLine());
        int halfWidth = width / 2;

        // Upper part
        for (int row = 1; row <= halfWidth; row++)
        {
            // Upper-left lart
            for (int symbol = 0; symbol < halfWidth; symbol++)
            {
                if (symbol != halfWidth - row)
                {
                    Console.Write(".");
                }
                else
                {
                    Console.Write("#");
                }
            }
            // Upper-right part
            for (int symbol = 0; symbol < halfWidth; symbol++)
            {
                if (symbol != row - 1)
                {
                    Console.Write(".");
                }
                else
                {
                    Console.Write("#");
                }
            }

            Console.WriteLine();
        }

        // Middle part
        for (int row = 1; row <= halfWidth / 2; row++)
        {
            // Middle-left part
            for (int symbol = 0; symbol < halfWidth; symbol++)
            {
                if (symbol != row - 1)
                {
                    Console.Write(".");
                }
                else
                {
                    Console.Write("#");
                }
            }

            // Middle-right part
            for (int symbol = 0; symbol < halfWidth; symbol++)
            {
                if (symbol != halfWidth - row)
                {
                    Console.Write(".");
                }
                else
                {
                    Console.Write("#");
                }
            }

            Console.WriteLine();
        }

        for (int border = 0; border < width; border++)
        {
            Console.Write("-");
        }
        Console.WriteLine();

        // Bottom part
        int dot = 0;

        for (int row = 1; row <= halfWidth; row++)
        {
            // Bottom-left part
            dot = row - 1;

            for (int symbol = 0; symbol < halfWidth; symbol++)
            {
                if (dot > 0)
                {
                    Console.Write(".");
                    dot--;
                }
                else
                {
                    Console.Write("\\");
                }
            }

            // Bottom-right part
            int lineCount = halfWidth - row + 1;

            for (int symbol = 0; symbol < halfWidth; symbol++)
            {
                if (lineCount > 0)
                {
                    Console.Write("/");
                    lineCount--;
                }
                else
                {
                    Console.Write(".");
                }
            }

            Console.WriteLine();
        }
    }
}