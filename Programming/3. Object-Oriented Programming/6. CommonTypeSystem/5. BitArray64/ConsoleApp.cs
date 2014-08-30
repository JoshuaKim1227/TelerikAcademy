using System;
using System.Collections;

public class ConsoleApp
{
    public static void Main()
    {
        // Initializing data types
        BitArray64 num1 = new BitArray64(212);
        BitArray64 num2 = new BitArray64(212);

        // Testing indexer
        int index = 7;
        Console.WriteLine("The bit at position {0} is:", index);
        Console.WriteLine(num1[index] + "\n");

        // Testing enumaration
        Console.WriteLine("Enumeration");
        foreach (var item in num1)
        {
            Console.Write(item);
        }

        Console.WriteLine();

        // Testing ToString()
        Console.WriteLine("\nToString()");
        Console.WriteLine(num1);

        // Testing comparing
        Console.WriteLine("num1 Equals num2 --> {0}", num1.Equals(num2));
        Console.WriteLine("num1 == num2 --> {0}", num1 == num2);
        Console.WriteLine("num1 != num2 --> {0}", num1 != num2);
    }
}