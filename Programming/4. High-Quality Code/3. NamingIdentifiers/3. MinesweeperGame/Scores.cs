namespace MinesweeperGame
{
    using System;

    public class Scores
    {
        private string name;
        private int score;

        public Scores()
        {
        }

        public Scores(string name, int score)
        {
            this.name = name;
            this.score = score;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.name = value;
            }
        }

        public int Score
        {
            get
            {
                return this.score;
            }

            set
            {
                this.score = value;
            }
        }
    }
}