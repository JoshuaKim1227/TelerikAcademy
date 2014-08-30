using System;
using System.IO;
using System.Text;

public class LineNumbersInFile
{
    public static void Main()
    {
        int lineCounter = 1;

        StreamReader reader = new StreamReader("input.txt");

        StreamWriter writer = new StreamWriter("output.txt");

        using (reader)
        {
            using (writer)
            {
                string line = reader.ReadLine();

                while (line != null)
                {
                    writer.WriteLine("Line {0}: " + line, lineCounter);
                    line = reader.ReadLine();
                    lineCounter++;
                }
            }
        }
    }
}