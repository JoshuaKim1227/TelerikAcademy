using System;

class Laser
{
    static void Main()
    {
        int[] cuboidSize = GetCuboidSize();
        int[] laserStartPos = GetLaserStartPos();
        int[] laserDirection = GetLaserDirection();
        bool[, ,] cuboid = InitializeCuboid(cuboidSize, laserStartPos);

        int[] laserCurrentPos = laserStartPos;

        int[] laserFinalPosition = MoveLaserRay(cuboid, laserCurrentPos, laserDirection);

        Console.WriteLine(laserFinalPosition[0] + " " + laserFinalPosition[1] + " " + laserFinalPosition[2]);
    }

    static int[] GetCuboidSize()
    {
        string userInput = Console.ReadLine();
        string[] sizeStr = userInput.Split(' ');
        int[] size = new int[3];

        for (int index = 0; index < sizeStr.Length; index++)
        {
            size[index] = int.Parse(sizeStr[index]);
        }

        return size;
    }

    static int[] GetLaserStartPos()
    {
        string userInput = Console.ReadLine();
        string[] startPosStr = userInput.Split(' ');
        int[] startPos = new int[3];

        for (int index = 0; index < startPosStr.Length; index++)
        {
            startPos[index] = int.Parse(startPosStr[index]);
        }

        return startPos;
    }

    static int[] GetLaserDirection()
    {
        string userInput = Console.ReadLine();
        string[] directionStr = userInput.Split(' ');
        int[] direction = new int[3];

        for (int index = 0; index < directionStr.Length; index++)
        {
            direction[index] = int.Parse(directionStr[index]);
        }

        return direction;
    }

    static bool[, ,] InitializeCuboid(int[] cuboidSize, int[] laserStartPos)
    {
        bool[, ,] cuboid = new bool[cuboidSize[0], cuboidSize[1], cuboidSize[2]];

        cuboid[laserStartPos[0], laserStartPos[1], laserStartPos[2]] = true;

        for (int width = 0; width < cuboid.GetLength(0); width++)
        {
            for (int height = 0; height < cuboid.GetLength(1); height++)
            {
                for (int depth = 0; depth < cuboid.GetLength(2); depth++)
                {
                    cuboid[width, height, depth] = false;

                    if ((width == 0 || width == cuboid.GetLength(0) - 1) &&
                        (height == 0 || height == cuboid.GetLength(1) - 1))
                    {
                        cuboid[width, height, depth] = true;
                    }

                    if ((width == 0 || width == cuboid.GetLength(0) - 1) &&
                       (depth == 0 || depth == cuboid.GetLength(2) - 1))
                    {
                        cuboid[width, height, depth] = true;
                    }

                    if ((height == 0 || height == cuboid.GetLength(1) - 1) &&
                       (depth == 0 || depth == cuboid.GetLength(2) - 1))
                    {
                        cuboid[width, height, depth] = true;
                    }

                    //Console.Write(cuboid[width, height, depth] + " ");
                }
                //Console.WriteLine();
            }
            //Console.WriteLine();
        }

        return cuboid;
    }

    static int[] MoveLaserRay(bool[,,] cuboid, int[] laserCurrentPos, int[] laserDirection)
    {
        int[] laserNextPos = new int[3];

        while (true)
        {
            // Initialize data types
            bool directionChanged = false;
            int[] laserLastPos = new int[3];

            // Move laser ray to next position
            for (int axis = 0; axis < laserCurrentPos.Length; axis++)
            {
                laserNextPos[axis] = laserCurrentPos[axis] + laserDirection[axis];
                laserLastPos[axis] = laserCurrentPos[axis] - laserDirection[axis];
            }

            // If the laser ray hits wall - reverse direction
            if (laserNextPos[0] == -1 || laserNextPos[0] == cuboid.GetLength(0))
            {
                laserDirection = ChangeLaserDirection(laserDirection, 0);
                directionChanged = true;
            }

            if (laserNextPos[1] == -1 || laserNextPos[1] == cuboid.GetLength(1))
            {
                laserDirection = ChangeLaserDirection(laserDirection, 1);
                directionChanged = true;
            }

            if (laserNextPos[2] == -1 || laserNextPos[2] == cuboid.GetLength(2))
            {
                laserDirection = ChangeLaserDirection(laserDirection, 2);
                directionChanged = true;
            }

            // If the direction of the laser ray is changed (hits wall) don't move to next position
            if (directionChanged)
            {
                laserNextPos = (int[])laserCurrentPos.Clone();
            }
            
            else
            {
                // If laser ray reaches burned cube - return position
                if (cuboid[laserNextPos[0], laserNextPos[1], laserNextPos[2]] == true)
                {
                    for (int axis = 0; axis < laserNextPos.Length; axis++)
                    {
                        if (laserLastPos[axis] == -1)
                        {
                            laserLastPos[axis] = Math.Abs(laserLastPos[axis]);
                        }
                    }
                    return laserLastPos;
                }

                // Set the current cube to fire
                cuboid[laserCurrentPos[0], laserCurrentPos[1], laserCurrentPos[2]] = true;

                // Move to next position
                laserCurrentPos = (int[])laserNextPos.Clone();
            }
        }
    }

    static int[] ChangeLaserDirection(int[] currentDirection, int axis)
    {
        int[] newDirection = currentDirection;

        if (currentDirection[axis] < 0)
	    {
            newDirection[axis] = Math.Abs(currentDirection[axis]);
	    }
        else
	    {
            newDirection[axis] = currentDirection[axis] * -1;
	    }

        return newDirection;
    }
}

