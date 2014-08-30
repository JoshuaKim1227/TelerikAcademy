using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class TrueOrFalsePrinter
{
    private const int MaxCount = 6;

    public static void Main()
    {
        TrueOrFalsePrinter printer = new TrueOrFalsePrinter();

        printer.PrintTrueOrFalse(true);
    }

    public void PrintTrueOrFalse(bool trueOrFalse)
    {
        string trueOrFalseString = trueOrFalse.ToString();

        Console.WriteLine(trueOrFalseString);
    }
}