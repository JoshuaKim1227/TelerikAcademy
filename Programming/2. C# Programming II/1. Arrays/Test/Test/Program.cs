using System;

class MaxSum
{
    static void Main()
    {
        int n, k, s;
        Console.Write("Enter array's length:");
        n = int.Parse(Console.ReadLine());
        Console.Write("K=");
        k = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        Console.WriteLine("Enter {0} elements", n);
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 1; j < n; j++)
            {
                if (array[j - 1] < array[j])
                {
                    s = array[j - 1];
                    array[j - 1] = array[j];
                    array[j] = s;
                }
            }
        }
        for (int i = 0; i < k - 1; i++)
        {
            Console.Write(array[i] + ", ");
        }
        Console.WriteLine(array[k - 1]);
    }
}