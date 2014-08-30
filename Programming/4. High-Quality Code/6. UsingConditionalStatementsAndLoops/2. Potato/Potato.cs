using System;

public class Potato
{
    static void Main()
    {
        // Part I
        Potato potato;

        //...

        if (potato == null)
        {
            throw new ArgumentNullException();
        }

        if (potato.HasBeenPeeled && potato.IsGood)
        {
            Cook(potato);
        }

        // Part II
        bool inRangeX = (MIN_X <= x && x <= MAX_X);
        bool inRangeY = (MIN_Y <= y && y <= MAX_Y);

        if (inRangeX && inRangeY && shouldVisitCell)
        {
           VisitCell();
        }
    }
}