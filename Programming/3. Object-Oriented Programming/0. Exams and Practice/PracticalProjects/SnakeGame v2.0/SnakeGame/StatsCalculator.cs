using System.Collections.Generic;

namespace SnakeGame
{
    public static class StatsCalculator
    {
        private static int score = -50;
        private static int eatenFoodCounter = -1;
        private static int level = 1;
        private static int levelUpCounter = 2000;

        public static int Score
        {
            get
            {
                return score;
            }
        }

        public static int EatenFoodcounter
        {
            get
            {
                return eatenFoodCounter;
            }
        }

        public static int Level
        {
            get
            {
                return level;
            }
        }

        public static void CalculateEatenFoodScore()
        {
            score += 50;
        }

        public static void CalculateEatenFoodCount()
        {
            eatenFoodCounter += 1;
        }

        public static void CalculateLevel()
        {
            levelUpCounter--;

            if (levelUpCounter % 200 == 0)
            {
                level++;
            }
        }

        public static void FinalizeScore(string userName)
        {
            int lineToEdit = 1;

            List<string> fileLines = FileOperator.ReadHighScoreFile();

            foreach (var line in fileLines)
            {
                string[] parts = line.Split(' ');

                int lastBestScore = int.Parse(parts[0]);

                if (lastBestScore < score)
                {
                    break;
                }

                lineToEdit++;
            }

            string scoreInfo = string.Format("{0,-4} {1}", score, userName);

            for (int currentLine = 0; currentLine < fileLines.Count; currentLine++)
            {
                if (currentLine + 1 == lineToEdit)
                {
                    fileLines.Insert(currentLine, scoreInfo);
                    fileLines.RemoveAt(3);
                }
            }

            FileOperator.WriteHighScoreFile(fileLines);
        }
    }
}