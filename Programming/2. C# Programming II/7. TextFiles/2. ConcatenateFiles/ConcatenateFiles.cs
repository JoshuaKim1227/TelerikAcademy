using System;
using System.IO;
using System.Text;

public class ConcatenateFiles
{
    public static void Main()
    {
        string part1;
        string part2;
        string finalResult;

        StreamReader readerForFile1 = new StreamReader("text1.txt");

        StreamReader readerForFile2 = new StreamReader("text2.txt");

        StreamWriter writer = new StreamWriter("final.txt");

        using (readerForFile1)
        {
            part1 = readerForFile1.ReadToEnd();
        }

        using (readerForFile2)
        {
            part2 = readerForFile2.ReadToEnd();
        }

        finalResult = part1 + Environment.NewLine + part2;

        using (writer)
        {
            writer.Write(finalResult);
        }
    }
}