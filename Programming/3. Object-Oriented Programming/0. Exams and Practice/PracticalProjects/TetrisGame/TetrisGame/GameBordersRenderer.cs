namespace TetrisGame
{
    using System;

    public class GameBordersRenderer
    {
        private GameCoords playFieldSize;
        private GameCoords infoFieldSize;

        private int infoFieldWidth = 10;

        private int consoleWindowWidth;
        private int consoleWindowHeight;

        public GameBordersRenderer(int rows, int cols)
        {
            this.Rows = rows + 1;
            this.Cols = cols + 1;

            this.playFieldSize = new GameCoords(this.Rows, this.Cols);
            this.infoFieldSize = new GameCoords(this.Rows, this.infoFieldWidth);

            this.consoleWindowWidth = this.playFieldSize.Col + this.infoFieldSize.Col + 6;
            this.consoleWindowHeight = this.playFieldSize.Row + 3;

            this.SetConsoleWindowSize(this.consoleWindowWidth, this.consoleWindowHeight);

            this.RenderBorders();
        }

        public int Rows { get; private set; }

        public int Cols { get; private set; }

        public void RenderBorders()
        {
            this.RenderVerticalGameBorders();
            this.RenderHorizontalGameBorders();
        }

        private void RenderVerticalGameBorders()
        {
            int playFieldCursorColPos = this.playFieldSize.Col + 2;
            int infoFieldCursorColPos = this.playFieldSize.Col + this.infoFieldSize.Col + 3;

            for (int row = 1; row <= this.playFieldSize.Row; row++)
            {
                Console.SetCursorPosition(2, row);
                Console.Write("|");

                Console.SetCursorPosition(playFieldCursorColPos, row);
                Console.Write("|");

                Console.SetCursorPosition(infoFieldCursorColPos, row);
                Console.Write("|");
            }
        }

        private void RenderHorizontalGameBorders()
        {
            int horizontalLineLenght = this.playFieldSize.Col + this.infoFieldSize.Col + 3;

            for (int col = 2; col <= horizontalLineLenght; col++)
            {
                Console.SetCursorPosition(col, 0);
                Console.Write("-");

                Console.SetCursorPosition(col, this.playFieldSize.Row);
                Console.Write("-");
            }

            Console.WriteLine();   
        }

        private void SetConsoleWindowSize(int width, int height)
        {
            Console.WindowWidth = width;
            Console.WindowHeight = height;

            Console.BufferWidth = Console.WindowWidth;
            Console.BufferHeight = Console.WindowHeight;
        }
    }
}