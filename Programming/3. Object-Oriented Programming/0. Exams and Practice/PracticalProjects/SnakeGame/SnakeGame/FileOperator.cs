using System;
using System.Collections.Generic;
using System.IO;

namespace SnakeGame
{
    public static class FileOperator
    {
        private static List<string> fileLines = new List<string>();

        public static List<string> ReadHighScoreFile()
        {
            StreamReader fileReader;

            fileLines.Clear();

            fileReader = new StreamReader("../../high_scores.txt");

            using (fileReader)
            {
                for (int counter = 0; counter < 3; counter++)
                {
                    fileLines.Add(fileReader.ReadLine());
                }
            }

            return fileLines;
        }

        public static void WriteHighScoreFile(List<string> scoreInfo)
        {
            using (StreamWriter fileWriter = new StreamWriter("../../high_scores.txt"))
            {
                foreach (string line in scoreInfo)
                {
                    fileWriter.WriteLine(line);
                }
            }
        }
    }
}