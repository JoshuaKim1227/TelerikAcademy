using System;
using System.Collections.Generic;

namespace SnakeGame
{
    public class ConsoleRenderer : IRenderer
    {
        private char[,] gameField;

        private GameFieldCoords gameFieldSize;
        private GameFieldCoords consoleSize;

        private List<string> highScores;

        private CursorPosition levelInfoPosition;
        private CursorPosition scoreInfoPosition;
        private CursorPosition foodInfoPosition;
        private CursorPosition gameOverInfoPosition;
        private CursorPosition finalPosition;
        private CursorPosition highScoreTitlePosition;
        private CursorPosition firstPlaceScorePosition;
        private CursorPosition secondPlaceScorePosition;
        private CursorPosition thirdPlaceScorePosition;

        public ConsoleRenderer(GameFieldCoords size)
        {
            this.InitializeGameField(size);
            this.gameFieldSize = size;

            this.consoleSize = new GameFieldCoords(this.gameFieldSize.Row + 2, this.gameFieldSize.Col + 21);

            this.highScores = FileOperator.ReadHighScoreFile();

            Console.CursorVisible = false;

            Console.WindowHeight = this.consoleSize.Row;
            Console.BufferHeight = Console.WindowHeight;

            Console.WindowWidth = this.consoleSize.Col;
            Console.BufferWidth = Console.WindowWidth;

            this.InitializeCursorPostions();
        }

        public GameFieldCoords GameFieldSize
        {
            get
            {
                return this.gameFieldSize;
            }
        }

        public void EnqueueForRendering(IRenderable objForRendering)
        {
            List<GameFieldCoords> objPosition = objForRendering.GetPosition();

            foreach (GameFieldCoords position in objPosition)
            {
                this.gameField[position.Row, position.Col] = objForRendering.RenderingSymbol;
            }
        }

        public void RenderAll()
        {
            Console.SetCursorPosition(0, 0);

            // Render upper border
            Console.Write(" ");
            for (int borderCounter = 0; borderCounter < this.gameFieldSize.Col + 2; borderCounter++)
            {
                Console.Write("-");
            }

            Console.WriteLine();

            for (int row = 0; row < this.gameField.GetLength(0); row++)
            {
                // Render left border
                Console.Write(" |");

                // Render game field
                for (int col = 0; col < this.gameField.GetLength(1); col++)
                {
                    Console.Write(this.gameField[row, col]);
                    this.gameField[row, col] = ' ';
                }

                // Render right border
                Console.Write("|");

                Console.WriteLine();
            }

            // Render bottom border
            Console.Write(" ");
            for (int borderCounter = 0; borderCounter < this.gameFieldSize.Col + 2; borderCounter++)
            {
                Console.Write("-");
            }

            this.RenderScores();
        }

        public void RenderScores()
        {
            Console.SetCursorPosition(this.levelInfoPosition.Col, this.levelInfoPosition.Row);
            Console.Write("LEVEL {0}", InfoCalculator.Level);

            Console.SetCursorPosition(this.scoreInfoPosition.Col, this.scoreInfoPosition.Row);
            Console.Write("Score: {0}", InfoCalculator.Score);

            Console.SetCursorPosition(this.foodInfoPosition.Col, this.foodInfoPosition.Row);
            Console.Write("Food eaten: {0}", InfoCalculator.EatenFoodcounter);

            Console.SetCursorPosition(this.highScoreTitlePosition.Col, this.highScoreTitlePosition.Row);
            Console.Write("High Score:");
            Console.SetCursorPosition(this.firstPlaceScorePosition.Col, this.firstPlaceScorePosition.Row);
            Console.Write("{0}", this.highScores[0]);
            Console.SetCursorPosition(this.secondPlaceScorePosition.Col, this.secondPlaceScorePosition.Row);
            Console.Write("{0}", this.highScores[1]);
            Console.SetCursorPosition(this.thirdPlaceScorePosition.Col, this.thirdPlaceScorePosition.Row);
            Console.Write("{0}", this.highScores[2]);
        }

        public void EndGame()
        {
            this.RenderScores();

            Console.SetCursorPosition(this.gameOverInfoPosition.Col, this.gameOverInfoPosition.Row);
            Console.WriteLine("GAME OVER!");
            Console.SetCursorPosition(this.finalPosition.Col, this.finalPosition.Row);
        }

        public void RenderUserRequest()
        {
            Console.WriteLine("Welcome to Snake by N. Donchev\n");
            Console.Write("Plese enter your User Name: ");
        }

        private void InitializeGameField(GameFieldCoords size)
        {
            Console.Title = "Snake Game";

            this.gameField = new char[size.Row, size.Col];

            for (int row = 0; row < this.gameField.GetLength(0); row++)
            {
                for (int col = 0; col < this.gameField.GetLength(1); col++)
                {
                    this.gameField[row, col] = ' ';
                }
            }
        }

        private struct CursorPosition
        {
            public int Row;
            public int Col;
        }

        private void InitializeCursorPostions()
        {
            this.levelInfoPosition.Col = Console.WindowWidth - 17;
            this.levelInfoPosition.Row = Console.WindowHeight - 21;

            this.scoreInfoPosition.Col = Console.WindowWidth - 17;
            this.scoreInfoPosition.Row = Console.WindowHeight - 17;

            this.foodInfoPosition.Col = Console.WindowWidth - 17;
            this.foodInfoPosition.Row = Console.WindowHeight - 15;

            this.gameOverInfoPosition.Col = Console.WindowWidth - 17;
            this.gameOverInfoPosition.Row = Console.WindowHeight - 11;

            this.highScoreTitlePosition.Col = Console.WindowWidth - 17;
            this.highScoreTitlePosition.Row = Console.WindowHeight - 7;

            this.firstPlaceScorePosition.Col = Console.WindowWidth - 17;
            this.firstPlaceScorePosition.Row = Console.WindowHeight - 5;

            this.secondPlaceScorePosition.Col = Console.WindowWidth - 17;
            this.secondPlaceScorePosition.Row = Console.WindowHeight - 4;

            this.thirdPlaceScorePosition.Col = Console.WindowWidth - 17;
            this.thirdPlaceScorePosition.Row = Console.WindowHeight - 3;

            this.finalPosition.Col = 0;
            this.finalPosition.Row = Console.WindowHeight - 1;
        }
    }
}