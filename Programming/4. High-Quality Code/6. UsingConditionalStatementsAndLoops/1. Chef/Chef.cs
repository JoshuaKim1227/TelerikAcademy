using System;

public class Chef
{
    static void Main()
    {
    }

    public void Cook()
    {
        Potato potato = GetPotato();
        Peel(potato);
        Cut(potato);

        Carrot carrot = GetCarrot();
        Peel(carrot);
        Cut(carrot);

        Bowl bowl = GetBowl();

        bowl.Add(potato);
        bowl.Add(carrot);
    }

    private Potato GetPotato()
    {
        //...
    }

    private Carrot GetCarrot()
    {
        //...
    }

    private void Cut(Vegetable potato)
    {
        //...
    }

    private Bowl GetBowl()
    {
        //... 
    }
}