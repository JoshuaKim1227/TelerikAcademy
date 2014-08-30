using System;

class ArraysOf20x5
{
    static void Main()
    {
        int[] arrayOf20 = new int[20];

        for (int index = 0; index < arrayOf20.Length; index++)
        {
            arrayOf20[index] = index * 5;
            Console.WriteLine(arrayOf20[index]);
        }
    }
}