using System;

public class Kukata
{
    public static int posRow { get; set; }
    public static int posCol { get; set; }
}

enum SquareColor
{
    GREEN,
    RED,
    BLUE
};

enum Direction
{
    North,
    East,
    South,
    West
};

class KukataIsDancing
{
    // Initializing data types
    static Direction direction = 0;
    static SquareColor[,] danceCube = new SquareColor[3, 3];

    static void Main()
    {
        string[] dances = GetInput();

        InitializeCubeColors(danceCube);

        for (int dance = 0; dance < dances.Length; dance++)
        {
            Console.WriteLine(Dance(dances[dance]));
        }
    }

    static string[] GetInput()
    {
        // Get number of dances (lines)
        int danceCount = int.Parse(Console.ReadLine());

        // Initialize string array for the dances (lines)
        string[] dances = new string[danceCount];

        // Reading input
        for (int dance = 0; dance < dances.Length; dance++)
        {
            dances[dance] = Console.ReadLine();
        }

        return dances;
    }

    static void InitializeCubeColors(SquareColor[,] danceCube)
    {
        // Set counter to 0
        int counter = 0;

        // Iterate through the cube, setting the appropriate color
        for (int squareRow = 0; squareRow < danceCube.GetLength(0); squareRow++)
        {
            for (int squareCol = 0; squareCol < danceCube.GetLength(1); squareCol++)
            {
                if (counter % 2 == 0)
                {
                    danceCube[squareRow, squareCol] = SquareColor.RED;
                }
                else
                {
                    danceCube[squareRow, squareCol] = SquareColor.BLUE;
                }

                counter++;
            }
        }

        // Set the middle square color to Green
        danceCube[1, 1] = SquareColor.GREEN;
    }

    static string Dance(string input)
    {
        Kukata.posRow = 1;
        Kukata.posCol = 1;

        for (int move = 0; move < input.Length; move++)
        {
            if (input[move] == 'R')
            {
                MoveRight();
            }
            else if (input[move] == 'L')
            {
                MoveLeft();
            }
            else if (input[move] == 'W')
            {
                Walk();
            }
        }

        return danceCube[Kukata.posRow, Kukata.posCol].ToString();
    }

    static void MoveRight()
    {
        // Checking if current direction is at the end of the enumeration
        if ((int)direction < 3)
        {
            direction++;
        }
        else
        {
            direction = Direction.North;
        }
    }

    static void MoveLeft()
    {
        // Checking if current direction is at the end of the enumeration
        if ((int)direction > 0)
        {
            direction--;
        }
        else
        {
            direction = Direction.West;
        }
    }

    static void Walk()
    {
        // Checking the direction
        if (direction == Direction.North)
        {
            // Checking if the move gets outside the current side of the cube
            if (Kukata.posRow > 0)
            {
                Kukata.posRow--;
            }
            else
            {
                Kukata.posRow = 2;
            }
        }

        // Checking the direction
        else if (direction == Direction.East)
        {
            // Checking if the move gets outside the current side of the cube
            if (Kukata.posCol < 2)
            {
                Kukata.posCol++;
            }
            else
            {
                Kukata.posCol = 0;
            }
        }

        // Checking the direction
        else if (direction == Direction.South)
        {
            // Checking if the move gets outside the current side of the cube
            if (Kukata.posRow < 2)
            {
                Kukata.posRow++;
            }
            else
            {
                Kukata.posRow = 0;
            }
        }

        // Checking the direction
        else if (direction == Direction.West)
        {
            // Checking if the move gets outside the current side of the cube
            if (Kukata.posCol > 0)
            {
                Kukata.posCol--;
            }
            else
            {
                Kukata.posCol = 2;
            }
        }
    }
}

