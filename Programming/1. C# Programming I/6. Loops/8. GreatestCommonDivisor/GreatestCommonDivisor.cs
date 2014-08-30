using System;

class GreatestCommonDivisor
{
    static void Main()
    {
        int a;
        int b;
        int temp;
        int result = 0;

        Console.WriteLine("Enter two positive numbers: ");
        string userInput1 = Console.ReadLine();
        string userInput2 = Console.ReadLine();
        if (int.TryParse(userInput1, out a) && int.TryParse(userInput2, out b))
        {
            if (a > 0)
            {
                if (b != 0)
                {
                    if (a < b)
                    {
                        while (a % b != 0)
                        {
                            temp = a % b;
                            a = b;
                            b = temp;
                            result = temp;
                        }
                    }
                    else
                    {
                        while (b % a != 0)
                        {
                            temp = b % a;
                            b = a;
                            a = temp;
                            result = temp;
                        }
                    }
                    Console.WriteLine("The GCD of the numbers is: {0}", result);
                }
                else
                {
                    Console.WriteLine("The Greatest common divisor is: {0}", a);
                }
            }
            else
            {
                Console.WriteLine("First number must be greater than 0!");
            }
        }
        else
        {
            Console.WriteLine("Invalid Input!");
        }
    }
}

