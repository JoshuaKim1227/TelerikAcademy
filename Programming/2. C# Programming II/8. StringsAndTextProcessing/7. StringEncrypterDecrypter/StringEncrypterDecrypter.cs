using System;
using System.Collections.Generic;
using System.Text;

public class StringEncrypterDecrypter
{
    public static void Main()
    {
        string inputText;
        string cipher = "alabala";
        string encryptedText;
        string decryptedText;

        inputText = "Once created a string cannot be changed. A StringBuilder can be changed as many times as necessary. It yields astonishing performance improvements. It eliminates millions of string copies. And in certain loops it is essential.";
        Console.WriteLine("The initial text is:\n{0}", inputText);

        encryptedText = EncryptString(inputText, cipher);
        Console.WriteLine("\nThe encrypted text is:\n{0}", encryptedText);
        decryptedText = DecryptString(encryptedText, cipher);
        Console.WriteLine("\nThe decrypted text is:\n{0}", decryptedText);
    }

    public static string EncryptString(string text, string key)
    {
        // Initializing data types
        int charValue;
        int keyPlace = -1;
        string encryptedStr = string.Empty;
        List<char> charList = new List<char>();

        // Encrypting the string
        for (int index = 0; index < text.Length; index++)
        {
            keyPlace++;

            charValue = key[keyPlace] ^ text[index];
            charList.Add((char)charValue);
            encryptedStr = encryptedStr + charList[index].ToString();

            // Checking if the index of the key is at the end of it.
            // If so, restart the index counting.
            if (keyPlace == key.Length - 1)
            {
                keyPlace = -1;
            }
        }

        return encryptedStr;
    }

    public static string DecryptString(string text, string key)
    {
        // Initializing data types
        int charValue;
        int keyPlace = -1;
        string decryptedStr = string.Empty;
        List<char> charList = new List<char>();

        // Decrypting the string
        for (int index = 0; index < text.Length; index++)
        {
            keyPlace++;

            charValue = key[keyPlace] ^ text[index];
            charList.Add((char)charValue);
            decryptedStr = decryptedStr + charList[index].ToString();

            // Checking if the index of the key is at the end of it.
            // If so, restart the index counting.
            if (keyPlace == key.Length - 1)
            {
                keyPlace = -1;
            }
        }

        return decryptedStr;
    }
}