using System;

public class HexadecimalToBinary
{
    public static void Main()
    {
        Console.Write("Enter a hexadecimal number: ");
        char[] charArray = GetUserInput();
        string binaryResult = HexToBinary(charArray);

        Console.WriteLine("The number is binary is: {0}", binaryResult);
    }

    public static char[] GetUserInput()
    {
        string input = Console.ReadLine();

        char[] charArray = input.ToCharArray();

        return charArray;
    }

    public static string HexToBinary(char[] hexToConvert)
    {
        string result = null;
        string space = " ";

        for (int index = 0; index < hexToConvert.Length; index++)
        {
            switch (hexToConvert[index])
            {
                case '0':
                    result = result + "0000";
                    break;
                case '1':
                    result = result + "0001";
                    break;
                case '2':
                    result = result + "0010";
                    break;
                case '3':
                    result = result + "0011";
                    break;
                case '4':
                    result = result + "0100";
                    break;
                case '5':
                    result = result + "0101";
                    break;
                case '6':
                    result = result + "0110";
                    break;
                case '7':
                    result = result + "0111";
                    break;
                case '8':
                    result = result + "1000";
                    break;
                case '9':
                    result = result + "1001";
                    break;
                case 'A':
                    result = result + "1010";
                    break;
                case 'B':
                    result = result + "1011";
                    break;
                case 'C':
                    result = result + "1100";
                    break;
                case 'D':
                    result = result + "1101";
                    break;
                case 'E':
                    result = result + "1110";
                    break;
                case 'F':
                    result = result + "1111";
                    break;
                default:
                    break;
            }

            result = result + space;
        }

        return result;
    }
}