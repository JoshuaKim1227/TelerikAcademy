using System;
using System.Collections.Generic;
using System.Text;

public class MultiverseCommunication
{
    public static void Main()
    {
        string encodedMessage = GetInput();

        string[] digits = SplitDigitsInMessage(encodedMessage);

        long decodedNumber = DecodeDigits(digits);

        Console.WriteLine(decodedNumber);
    }

    public static string GetInput()
    {
        string inputMessage = Console.ReadLine();

        return inputMessage;
    }

    public static string[] SplitDigitsInMessage(string message)
    {
        StringBuilder builder = new StringBuilder();
        List<string> digitsInMessage = new List<string>();

        for (int count = 0; count < message.Length; count++)
        {
            builder.Append(message[count]);

            if ((count + 1) % 3 == 0)
            {
                digitsInMessage.Add(builder.ToString());
                builder.Clear();
            }
        }

        digitsInMessage.Reverse();

        return digitsInMessage.ToArray();
    }

    public static long DecodeDigits(string[] encodedDigits)
    {
        long finalNumber = 0;

        for (int digitPlace = 0; digitPlace < encodedDigits.Length; digitPlace++)
        {
            int decimalDigit = ConvertMessageDigitToDecimalNumber(encodedDigits[digitPlace]);

            finalNumber += decimalDigit * (long)Math.Pow(13, digitPlace);
        }

        return finalNumber;
    }

    private static int ConvertMessageDigitToDecimalNumber(string messageDigit)
    {
        int decimalNumber;

        switch (messageDigit)
        {
            case "CHU":
                decimalNumber = 0;
                break;
            case "TEL":
                decimalNumber = 1;
                break;
            case "OFT":
                decimalNumber = 2;
                break;
            case "IVA":
                decimalNumber = 3;
                break;
            case "EMY":
                decimalNumber = 4;
                break;
            case "VNB":
                decimalNumber = 5;
                break;
            case "POQ":
                decimalNumber = 6;
                break;
            case "ERI":
                decimalNumber = 7;
                break;
            case "CAD":
                decimalNumber = 8;
                break;
            case "K-A":
                decimalNumber = 9;
                break;
            case "IIA":
                decimalNumber = 10;
                break;
            case "YLO":
                decimalNumber = 11;
                break;
            case "PLA":
                decimalNumber = 12;
                break;
            default:
                throw new ArgumentException("messageDigit");
        }

        return decimalNumber;
    }
}