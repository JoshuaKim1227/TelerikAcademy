using System;

class PrintASCII
{
    static void Main()
    {
        int length = 128;

        for (int i = 0; i < length; i++)
        {   
            char c = (char)i;
            Console.WriteLine(c);
        }
    }
}