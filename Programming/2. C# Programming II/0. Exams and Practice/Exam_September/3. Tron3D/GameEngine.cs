using System;
using System.Text;

public class GameEngine
{
    private bool[,] gameField;
    private Position[] playersPosition;
    private Direction[] playersDirection;

    private string[] playersMoveList;

    public string FinalResult { get; private set; }

    public int StartToEndDistance { get; private set; }

    public GameEngine(bool[,] gameField, Position[] playersPosition, string[] playersMoveList)
    {
        this.gameField = gameField;
        this.playersPosition = playersPosition;
        this.playersDirection = new Direction[2];
        this.playersMoveList = new string[2];

        this.playersDirection[0] = Direction.East;
        this.playersDirection[1] = Direction.West;

        this.playersMoveList[0] = playersMoveList[0];
        this.playersMoveList[1] = playersMoveList[1];
    }

    public void RunGame()
    {
        int playersCount = 2;
        bool[] alreadyMoved = new bool[2];
        bool playerOneCrashed = false;
        bool playerTwoCrashed = false;
        Position redPlayerStartPos = this.playersPosition[0];

        StringBuilder builder = new StringBuilder();
        for (int move = 0; move < playersMoveList[0].Length; move++)
        {
            for (int player = 0; player < playersCount; player++)
            {
                if (alreadyMoved[player] == true)
                {
                    alreadyMoved[player] = false;
                    builder.Append(this.playersMoveList[player][move]);
                    continue;
                }

                if (this.playersMoveList[player][move] == 'L')
                {
                    ChangeDirectionLeft(player);
                    MovePlayer(player);
                    alreadyMoved[player] = true;
                }
                else if (this.playersMoveList[player][move] == 'R')
                {
                    ChangeDirectionRight(player);
                    MovePlayer(player);
                    alreadyMoved[player] = true;
                }
                else if (this.playersMoveList[player][move] == 'M')
                {
                    MovePlayer(player);
                }

                if (this.gameField[this.playersPosition[player].Row, this.playersPosition[player].Col] == false)
                {
                    this.gameField[this.playersPosition[player].Row, this.playersPosition[player].Col] = true;
                }
                else
                {
                    if (player == 0)
                    {
                        playerOneCrashed = true;
                    }
                    if (player == 1)
                    {
                        playerTwoCrashed = true;
                    }
                }

                builder.Append(this.playersMoveList[player][move]);
            }

            if (playerOneCrashed && playerTwoCrashed)
            {
                break;
            }
        }

        this.StartToEndDistance = FindStartToEndDistance(redPlayerStartPos, playersPosition[0]);
        this.FinalResult = CheckForWinner(playerOneCrashed, playerTwoCrashed);
    }

    private int FindStartToEndDistance(Position redPlayerStartPos, Position redPlayerEndPos)
    {
        int distanceCouter = -1;

        if (redPlayerStartPos.Row > redPlayerEndPos.Row)
        {
            while (redPlayerStartPos.Row != redPlayerEndPos.Row)
            {
                redPlayerEndPos.Row++;
                distanceCouter++;
            }
        }
        else if (redPlayerStartPos.Row < redPlayerEndPos.Row)
        {
            while (redPlayerStartPos.Row != redPlayerEndPos.Row)
            {
                redPlayerEndPos.Row--;
                distanceCouter++;
            }
        }

        if (redPlayerStartPos.Col > redPlayerEndPos.Col)
        {
            while (redPlayerStartPos.Col != redPlayerEndPos.Col)
            {
                redPlayerEndPos.Col++;
                distanceCouter++;
            }
        }
        else if (redPlayerStartPos.Col < redPlayerEndPos.Col)
        {
            while (redPlayerStartPos.Col != redPlayerEndPos.Col)
            {
                redPlayerEndPos.Col--;
                distanceCouter++;
            }
        }

        return distanceCouter;
    }

    private static string CheckForWinner(bool playerOneCrashed, bool playerTwoCrashed)
    {
        if (playerOneCrashed && playerTwoCrashed)
        {
            return "DRAW";
        }
        else if (playerOneCrashed)
        {
            return "BLUE";
        }
        else if (playerTwoCrashed)
        {
            return "RED";
        }
        else
        {
            return "DRAW";
        }
    }

    private void ChangeDirectionRight(int player)
    {
        if (this.playersDirection[player] < Direction.North)
        {
            this.playersDirection[player] += 1;
        }
        else
        {
            this.playersDirection[player] = Direction.East;
        }
    }

    private void ChangeDirectionLeft(int player)
    {
        if (this.playersDirection[player] > 0)
        {
            this.playersDirection[player] -= 1;
        }
        else
        {
            this.playersDirection[player] = Direction.North;
        }
    }

    private void MovePlayer(int player)
    {
        if (this.playersDirection[player] == Direction.East)
        {
            this.playersPosition[player].Col++;
        }
        else if (this.playersDirection[player] == Direction.South)
        {
            this.playersPosition[player].Row++;
        }
        else if (this.playersDirection[player] == Direction.West)
        {
            this.playersPosition[player].Col--;
        }
        else if (this.playersDirection[player] == Direction.North)
        {
            this.playersPosition[player].Row--;
        }
    }
}