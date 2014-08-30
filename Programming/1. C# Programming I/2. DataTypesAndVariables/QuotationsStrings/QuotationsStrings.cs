using System;

class QuotationsStrings
{
    static void Main()
    {
        string quotingEscape1 = "The \"use\" of quotations causes difficulties.";
        Console.WriteLine(quotingEscape1);
        string quotingEscape2 = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine(quotingEscape2);
    }
}

