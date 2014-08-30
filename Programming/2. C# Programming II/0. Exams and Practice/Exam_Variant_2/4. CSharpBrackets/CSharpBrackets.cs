using System;
using System.Text;
using System.Text.RegularExpressions;

class CSharpBrackets
{
    static void Main()
    {
        int numberOfLines = int.Parse(Console.ReadLine());
        string indentationStr = Console.ReadLine();
        StringBuilder builder = new StringBuilder();

        for (int line = 0; line < numberOfLines; line++)
        {
            builder.Append(Console.ReadLine());
        }

        string joroCode = builder.ToString();

        Console.WriteLine(joroCode);

        string result = ProcessCode(joroCode, indentationStr);

        Console.WriteLine(result);
    }

    static string ProcessCode(string joroCode, string indentationStr)
    {
        int bracketCounter = 0;
        int indexOfBracket = 0;
        string newLine = "\n";
        StringBuilder codeBuilder = new StringBuilder();
        StringBuilder readyCode = new StringBuilder();

        // Whitespaces fix
        Regex regex = new Regex(@"\s{2,}");
        joroCode = regex.Replace(joroCode, " ");

        codeBuilder.Append(joroCode);

        while (joroCode.IndexOf("{", indexOfBracket) != -1)
        {
            bracketCounter++;

            for (int indentationCount = 1; indentationCount < bracketCounter; indentationCount++)
            {
                indexOfBracket = codeBuilder.ToString().IndexOf("{", indexOfBracket);

                if (indentationCount == 1)
                {
                    codeBuilder.Insert(indexOfBracket, "\n" + indentationStr);
                }
                else
                {
                    codeBuilder.Insert(indexOfBracket, indentationStr);
                }
            }

            indexOfBracket = codeBuilder.ToString().IndexOf("{", indexOfBracket);
            codeBuilder.Insert(indexOfBracket + 1, newLine);

            if (bracketCounter <= 1)
            {
                Console.WriteLine(codeBuilder.Insert(indexOfBracket, newLine));
            }

            if (true)
            {
                
            }
            for (int indentationCount = 0; indentationCount < bracketCounter; indentationCount++)
            {
                indexOfBracket = codeBuilder.ToString().IndexOf("{", indexOfBracket);
                Console.WriteLine(codeBuilder.Insert(indexOfBracket + 2, indentationStr));
            }

            indexOfBracket++;
            joroCode = codeBuilder.ToString();
        }

        while (joroCode.IndexOf("}", indexOfBracket) != joroCode.Length - 1)
        {
            bracketCounter--;

            for (int indentationCount = 0; indentationCount < bracketCounter; indentationCount++)
            {
                indexOfBracket = codeBuilder.ToString().IndexOf("}", indexOfBracket);

                if (indentationCount == 0)
                {
                    Console.WriteLine(codeBuilder.Insert(indexOfBracket, "\n" + indentationStr));
                }
                else
                {
                    Console.WriteLine(codeBuilder.Insert(indexOfBracket, indentationStr));
                }
            }

            indexOfBracket = codeBuilder.ToString().IndexOf("}", indexOfBracket);
            Console.WriteLine(codeBuilder.Insert(indexOfBracket + 1, newLine));

            if (bracketCounter > 1)
            {
                for (int indentationCount = bracketCounter; indentationCount >= 1; indentationCount--)
                {
                    indexOfBracket = codeBuilder.ToString().IndexOf("}", indexOfBracket);
                    codeBuilder.Insert(indexOfBracket + 2, indentationStr);
                }
            }

            indexOfBracket++;
            joroCode = codeBuilder.ToString();
        }

        return joroCode;
    }
}

