using System;

class UserChosenVariable
{
    static void Main()
    {
        int userVarChoice;
        Console.WriteLine("Choose a variable to enter:\n1. Int\n2. Double\n3. String");
        userVarChoice = int.Parse(Console.ReadLine());

        switch (userVarChoice)
        {
            case 1:
                int userInt;
                Console.WriteLine("You have chosen an Int. Enter the value: ");
                userInt = int.Parse(Console.ReadLine());
                userInt++;
                Console.WriteLine("The final value is: {0}", userInt);
                break;
            case 2:
                double userDouble;
                Console.WriteLine("You have chosen a Double. Enter the value: ");
                userDouble = int.Parse(Console.ReadLine());
                userDouble++;
                Console.WriteLine("The final value is: {0}", userDouble);
                break;
            case 3:
                string userString;
                Console.WriteLine("You have chosen a String. Enter the value: ");
                userString = Console.ReadLine();
                userString = userString + "*";
                Console.WriteLine("The final value is: {0}", userString);
                break;
            default:
                Console.WriteLine("Invalid Input!");
                break;
        }
    }
}

