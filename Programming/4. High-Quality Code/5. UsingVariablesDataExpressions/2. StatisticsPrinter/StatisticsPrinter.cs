using System;

public class StatisticsPrinter
{
    public static void Main()
    {
    }

    public void PrintStatistics(double[] arr, int count)
    {
        double maxNumber = double.MinValue;

        for (int index = 0; index < count; index++)
        {
            if (arr[index] > maxNumber)
            {
                maxNumber = arr[index];
            }
        }

        this.PrintMax(maxNumber);

        double minNumber = double.MaxValue;

        for (int index = 0; index < count; index++)
        {
            if (arr[index] < minNumber)
            {
                minNumber = arr[index];
            }
        }

        this.PrintMin(minNumber);

        double sumOfNumbers = 0;

        for (int i = 0; i < count; i++)
        {
            sumOfNumbers += arr[i];
        }

        this.PrintAverage(sumOfNumbers, arr.Length);
    }

    public void PrintMax(double maxNumber)
    {
        Console.WriteLine("The biggest number is: {0}", maxNumber);
    }

    public void PrintMin(double minNumber)
    {
        Console.WriteLine("The smallest number is: {0}", minNumber);
    }

    public void PrintAverage(double sumOfNumbers, int numbersCount)
    {
        double averageNumber = sumOfNumbers / numbersCount;

        Console.WriteLine("The average number is: {0}", averageNumber);
    }
}