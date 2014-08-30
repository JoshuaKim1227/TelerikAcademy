using System;
using System.Text;

public class NumberConverter
{
    public static void Main()
    {
        Console.Write("Enter a digit: ");
        int decNum = int.Parse(Console.ReadLine());
        double forPercent = decNum / 100D;

        string hexNum = string.Format("{0:X}", decNum);
        string sciNum = string.Format("{0:E}", decNum);
        string percentNum = string.Format("{0:0%}", forPercent);

        Console.WriteLine("The result is:");
        Console.WriteLine("{0, 15}", decNum);
        Console.WriteLine("{0, 15}", hexNum);
        Console.WriteLine("{0, 15}", percentNum);
        Console.WriteLine("{0, 15}", sciNum);
    }
}