using System;

class BitsExchanger
{
    static void Main()
    {
        int userInput;
        uint numberToManipulate;
        uint maskOne = 7;
        uint maskTwo = 7;
        uint setBitsToZero1;
        uint setBitsToZero2;
        uint getBits1;
        uint getBits2;
        uint setNewBits1;
        uint setNewBits2;

        // Getting the number from the user.
        Console.WriteLine("Please enter a positive number: ");
        userInput = int.Parse(Console.ReadLine());

        // Checking if the input number is positive
        // to avoid crashes.
        if (userInput >= 0)
        {
            numberToManipulate = (uint)userInput;

            Console.Write("Your number's bits are:         ");
            Console.WriteLine(Convert.ToString(numberToManipulate, 2).PadLeft(32, '0'));

            // Getting and swapping the bits from the number.
            getBits1 = numberToManipulate & (maskOne << 3);
            setNewBits2 = getBits1 << 20;
            getBits2 = numberToManipulate & (maskTwo << 23);
            setNewBits1 = getBits2 >> 20;

            // Setting the bits in the number to 0.
            setBitsToZero1 = ~(maskOne << 3);
            numberToManipulate = numberToManipulate & setBitsToZero1;
            setBitsToZero2 = ~(maskTwo << 23);
            numberToManipulate = numberToManipulate & setBitsToZero2;

            // Setting the bits in the number to the swapped values.
            numberToManipulate = numberToManipulate | setNewBits1;
            numberToManipulate = numberToManipulate | setNewBits2;

            Console.Write("The modified number's bits are: ");
            Console.WriteLine(Convert.ToString(numberToManipulate, 2).PadLeft(32, '0'));
        }

        else
        {
            Console.WriteLine("Invalid Input!");
        }
    }
}

