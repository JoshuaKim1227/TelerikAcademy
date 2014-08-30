using System;

class DeclaringVariables
{
    static void Main()
    {
        byte unsignedByteVar = 97;
        sbyte signedByteVar = -115;
        short signedShortVar = -10000;
        ushort unsignedShortVar = 53130;
        int signedIntVar = 4825932;

        Console.WriteLine("This is Unsigned Byte Variable: {0}",unsignedByteVar);
        Console.WriteLine("This is Signed Byte Variable: {0}", signedByteVar);
        Console.WriteLine("This is Signed Short Variable: {0}", signedShortVar); 
        Console.WriteLine("This is Unsigned Short Variable: {0}", unsignedShortVar);
        Console.WriteLine("This is Signed Integer Variable: {0}", signedIntVar);
    }
}

