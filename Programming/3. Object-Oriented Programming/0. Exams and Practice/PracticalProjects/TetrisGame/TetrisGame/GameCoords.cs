namespace TetrisGame
{
    using System;

    public class GameCoords
    {
        public GameCoords(int row, int col)
        {
            this.Row = row;
            this.Col = col;
        }

        public int Row { get; set; }

        public int Col { get; set; }
    }
}