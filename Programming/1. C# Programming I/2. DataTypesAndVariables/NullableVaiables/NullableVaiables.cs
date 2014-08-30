using System;

class NullableVaiables
{
    static void Main()
    {
        int? nullInt = 0;
        double? nullDouble = 0;
        Console.WriteLine(nullInt + " " + nullDouble);

        nullInt = null;
        nullDouble = null;
        Console.WriteLine(nullInt + " " + nullDouble);
    }
}