using System;
using System.IO;
using System.Text;

public class OddLinesFromFile
{
    public static void Main()
    {
        string fileContent;

        StreamReader reader = new StreamReader("test.txt");

        using (reader)
        {
            fileContent = reader.ReadToEnd();
        }

        string[] strLines = fileContent.Split('\n');

        for (int lineCounter = 0; lineCounter < strLines.Length; lineCounter++)
        {
            if (lineCounter % 2 != 0)
            {
                Console.WriteLine(strLines[lineCounter]);
            }
        }
    }
}