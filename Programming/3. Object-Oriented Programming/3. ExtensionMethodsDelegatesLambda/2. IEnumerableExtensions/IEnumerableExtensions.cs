using System;
using System.Collections.Generic;

public static class IEnumerableExtensions
{
    public static T Sum<T>(this IEnumerable<T> input) where T : IComparable
    {
        dynamic sum = 0;

        foreach (var item in input)
        {
            sum += item;
        }

        return sum;
    }

    public static T Product<T>(this IEnumerable<T> input) where T : IComparable
    {
        dynamic product = 1;

        foreach (var item in input)
        {
            product *= item;
        }

        return product;
    }

    public static T Min<T>(this IEnumerable<T> input) where T : IComparable
    {
        dynamic minValue = int.MaxValue;

        foreach (var item in input)
        {
            if (minValue > item)
            {
                minValue = item;
            }
        }

        return minValue;
    }

    public static T Max<T>(this IEnumerable<T> input) where T : IComparable
    {
        dynamic maxValue = int.MinValue;

        foreach (var item in input)
        {
            if (maxValue < item)
            {
                maxValue = item;
            }
        }

        return maxValue;
    }

    public static T Average<T>(this IEnumerable<T> input) where T : IComparable
    {
        int elementsCounter = 0;
        dynamic sum = 0;
        dynamic averageValue;

        foreach (var item in input)
        {
            sum += item;
            elementsCounter++;
        }

        return averageValue = sum / elementsCounter;
    }
}
