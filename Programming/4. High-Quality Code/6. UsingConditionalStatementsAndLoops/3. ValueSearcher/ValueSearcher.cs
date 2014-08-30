using System;

public class ValueSearcher
{
    static void Main()
    {
        bool isFound = false;

        for (int index = 0; index < 100; index++)
        {
            if (index % 10 == 0)
            {
                Console.WriteLine(array[index]);

                if (array[index] == expectedValue)
                {
                    isFound = true;
                }
            }
            else
            {
                Console.WriteLine(array[index]);
            }
        }

        // More code here

        if (isFound)
        {
            Console.WriteLine("Value Found");
        }
    }
}