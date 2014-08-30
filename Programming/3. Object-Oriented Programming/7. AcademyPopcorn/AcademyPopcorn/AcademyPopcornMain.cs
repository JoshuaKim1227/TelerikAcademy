using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Use 'A' and 'D' to move the racket and 'Space' to shoot if available
namespace AcademyPopcorn
{
    public static class AcademyPopcornMain
    {
        public static int WorldRows = 23;
        const int WorldCols = 40;
        const int RacketLength = 12;

        public static int startCol = 2;
        public static int endCol = WorldCols - 2;

        static void Initialize(Engine engine)
        {
            int startRow = 3;
            int startCol = 2;
            int endCol = WorldCols - 2;

            for (int i = startCol; i < endCol; i++)
            {
                Block currBlock = new Block(new MatrixCoords(startRow, i));

                engine.AddObject(currBlock);
            }

            for (int i = startCol; i < endCol; i++)
            {
                Block currBlock = new Block(new MatrixCoords(startRow + 1, i));
                engine.AddObject(currBlock);
            }

            for (int i = startCol; i < endCol; i++)
            {
                if (i % 4 == 0)
                {
                    GiftBlock giftBlock = new GiftBlock(new MatrixCoords(startRow + 2, i));
                    engine.AddObject(giftBlock);
                }
                else
                {
                    Block currBlock = new Block(new MatrixCoords(startRow + 2, i));
                    engine.AddObject(currBlock);
                }
            }

            // [Task 1] Adding left and right wall
            for (int row = startRow - 1; row < WorldRows; row++)
            {
                IndestructibleBlock leftWall = new IndestructibleBlock(new MatrixCoords(row, startCol - 1));
                engine.AddObject(leftWall);

                IndestructibleBlock rightWall = new IndestructibleBlock(new MatrixCoords(row, endCol));
                engine.AddObject(rightWall);
            }

            // [Task 1] Adding ceiling wall
            for (int col = startCol - 1; col < endCol; col++)
            {
                IndestructibleBlock topWall = new IndestructibleBlock(new MatrixCoords(startRow - 1, col));
                engine.AddObject(topWall);
            }

            Ball theBall = new Ball(new MatrixCoords(WorldRows / 2, 1),
                new MatrixCoords(-1, 1));

            engine.AddObject(theBall);

            //UnstoppableBall unstoppableBall = new UnstoppableBall(new MatrixCoords(WorldRows / 2, 1),
            //    new MatrixCoords(-1, 1));

            //engine.AddObject(unstoppableBall);

            //Racket theRacket = new Racket(new MatrixCoords(WorldRows - 1, WorldCols / 2), RacketLength);

            //engine.AddObject(theRacket);

            ShootingRacket shootingRacket = new ShootingRacket(new MatrixCoords(WorldRows - 1, WorldCols / 2), RacketLength);

            engine.AddObject(shootingRacket);

            //Gift testGift = new Gift(new MatrixCoords(7, 15));
            //engine.AddObject(testGift);

            //Bullet testBullet = new Bullet(new MatrixCoords(20, 15));
            //engine.AddObject(testBullet);
        }

        static void Main(string[] args)
        {
            IRenderer renderer = new ConsoleRenderer(WorldRows, WorldCols);
            IUserInterface keyboard = new KeyboardInterface();

            ExtendedEngine gameEngine = new ExtendedEngine(renderer, keyboard, 150);

            keyboard.OnLeftPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketLeft();
            };

            keyboard.OnRightPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketRight();
            };

            keyboard.OnActionPressed += (sender, eventInfo) =>
            {
                gameEngine.ShootPlayerRacket();
            };

            Initialize(gameEngine);

            //

            gameEngine.Run();
        }
    }
}
