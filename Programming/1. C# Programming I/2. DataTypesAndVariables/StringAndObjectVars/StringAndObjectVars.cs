using System;

class StringAndObjectVars
{
    static void Main()
    {
        string firstString = "Hello";
        string secondString = "World";
        object helloWorld = firstString + " " + secondString;
        string castingTest = (string)helloWorld;

        Console.WriteLine(castingTest);
    }
}

