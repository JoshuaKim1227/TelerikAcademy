using System;

class BonusScores
{
    static void Main()
    {
        int userDigit;
        Console.WriteLine("Enter a digit between 1 and 9: ");
        userDigit = int.Parse(Console.ReadLine());

        switch (userDigit)
        {
            case 1:
            case 2:
            case 3:
                userDigit = userDigit * 10;
                Console.WriteLine("The final scores are: {0}", userDigit);
                break;
            case 4:
            case 5:
            case 6:
                userDigit = userDigit * 100;
                Console.WriteLine("The final scores are: {0}", userDigit);
                break;
            case 7:
            case 8:
            case 9:
                userDigit = userDigit * 1000;
                Console.WriteLine("The final scores are: {0}", userDigit);
                break;
            default:
                Console.WriteLine("Error! Input is out of range!");
                break;
        }
    }
}

