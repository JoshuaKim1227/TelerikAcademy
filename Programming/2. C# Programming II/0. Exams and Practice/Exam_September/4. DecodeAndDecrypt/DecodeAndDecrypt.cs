using System;
using System.IO;
using System.Text;

public class DecodeAndDecrypt
{
    private static string inputMessage;
    private static string message;
    private static string cypher;
    private static int numberStartingIndex = 0;

    public static void Main()
    {
        Console.SetIn(new StreamReader(Console.OpenStandardInput(8192)));
        inputMessage = Console.ReadLine();

        string decodedMessage = Decode(inputMessage);

        SeparateMessageFromCypher(decodedMessage);

        string encryptedMessage = Decrypt();

        Console.WriteLine(encryptedMessage);
    }

    public static string Decode(string message)
    {
        StringBuilder builder = new StringBuilder();
        int symbolRepetitionCount = 1;

        for (int index = inputMessage.Length - 1; index >= 0; index--)
        {
            if (char.IsDigit(inputMessage[index]))
            {
                numberStartingIndex = index;
            }
            else
            {
                break;
            }
        }

        for (int index = 0; index < numberStartingIndex; index++)
        {
            if (!char.IsDigit(message[index]))
            {
                for (int symbol = 0; symbol < symbolRepetitionCount; symbol++)
                {
                    builder.Append(message[index]);
                }

                symbolRepetitionCount = 1;
            }
            else
            {
                StringBuilder numberStr = new StringBuilder();
                int digitCount = index;

                while (char.IsDigit(message[digitCount]))
                {
                    numberStr.Append(message[digitCount]);
                    symbolRepetitionCount = int.Parse(numberStr.ToString());
                    digitCount++;
                }

                index += numberStr.Length - 1;
            }
        }

        return builder.ToString();
    }

    public static void SeparateMessageFromCypher(string decodedMessage)
    {
        int cypherLength;
        int cypherStartIndex;

        cypherLength = int.Parse(inputMessage.Substring(numberStartingIndex));
        cypherStartIndex = (decodedMessage.Length) - cypherLength;

        message = decodedMessage.Substring(0, cypherStartIndex);
        cypher = decodedMessage.Substring(cypherStartIndex, cypherLength);
    }

    public static string Decrypt()
    {
        StringBuilder builder = new StringBuilder();

        for (int messageIndex = 0; messageIndex < message.Length; messageIndex++)
        {
            if (message.Length >= cypher.Length)
            {
                builder = DecryptSymbolCypherShorter(builder, messageIndex);
            }
            else
            {
                builder = DecryptSymbolCypherLonger(builder, messageIndex);
            }
        }

        return builder.ToString();
    }

    private static StringBuilder DecryptSymbolCypherShorter(StringBuilder builder, int messageIndex)
    {
        int cypherIndex = 0;

        if (messageIndex > cypher.Length - 1)
        {
            int multiplier = messageIndex / cypher.Length;

            cypherIndex = messageIndex - (cypher.Length * multiplier);
        }
        else
        {
            cypherIndex = messageIndex;
        }

        int cypherCode = ((int)cypher[cypherIndex] - 65);
        char resultingCode = (char)((int)message[messageIndex] - 65);

        char decryptedSymbol = (char)((cypherCode ^ resultingCode) + 65);

        builder.Append(decryptedSymbol);

        return builder;
    }

    private static StringBuilder DecryptSymbolCypherLonger(StringBuilder builder, int messageIndex)
    {
        char? decryptedSymbol = null;

        for (int cypherIndex = messageIndex; cypherIndex < cypher.Length; cypherIndex += message.Length)
        {
            if (decryptedSymbol == null)
            {
                decryptedSymbol = (char)((int)message[messageIndex] - 65);
            }
            else
            {
                decryptedSymbol = (char)(decryptedSymbol - 65);
            }

            int cypherCode = ((int)cypher[cypherIndex] - 65);

            decryptedSymbol = (char)((cypherCode ^ decryptedSymbol) + 65);
        }

        builder.Append(decryptedSymbol);

        return builder;
    }
}