using System;
using System.IO;
using System.Text;

public class CompareFileLineByLine
{
    public static void Main()
    {
        string firstFileContent;
        string secondFileContent;

        int sameLinesCounter = 0;
        int differentLinesCounter = 0;

        StreamReader readerForFile1 = new StreamReader("text1.txt");
        StreamReader readerForFile2 = new StreamReader("text2.txt");

        using (readerForFile1)
        {
            using (readerForFile2)
            {
                firstFileContent = readerForFile1.ReadToEnd();
                secondFileContent = readerForFile2.ReadToEnd();
            }
        }

        string[] linesOfFile1 = firstFileContent.Split('\n');
        string[] linesOfFile2 = secondFileContent.Split('\n');

        Console.WriteLine("Same Lines are:\n");
        for (int linesCounter = 0; linesCounter < linesOfFile1.Length; linesCounter++)
        {
            if (linesOfFile1[linesCounter] == linesOfFile2[linesCounter])
            {
                Console.WriteLine(linesOfFile1[linesCounter]);
                sameLinesCounter++;
            }
        }

        Console.WriteLine("Different Lines are:\n");
        for (int linesCounter = 0; linesCounter < linesOfFile1.Length; linesCounter++)
        {
            if (linesOfFile1[linesCounter] != linesOfFile2[linesCounter])
            {
                Console.WriteLine(linesOfFile2[linesCounter]);
                differentLinesCounter++;
            }
        }

        Console.WriteLine("\nNumber of same lines ==> {0}", sameLinesCounter);

        Console.WriteLine("Number of different lines ==> {0}", differentLinesCounter);
    }
}