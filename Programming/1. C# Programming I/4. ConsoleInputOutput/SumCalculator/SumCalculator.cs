using System;

class SumCalculator
{
    static void Main()
    {
        double result = 1;
        double target = 0;
        double devider = 2;

        while (target != result)
        {
            if (devider % 2 == 0)
            {
                target = result;
                result = result + (1 / devider);
            }
            if (devider % 2 != 0)
            {
                target = result;
                result = result + (-1 / devider);
            }
            devider++;
            target = Math.Round(target, 3);
            result = Math.Round(result, 3);
            Console.WriteLine(result);
        }
        Console.WriteLine("\nThe end number is {0}", target);
    }
}
