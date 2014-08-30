using System;

public abstract class Cat : Animal, ISound
{
    private string sound;

    public string Sound
    {
        get { return this.sound; }
        set { this.sound = value; }
    }

    public abstract void ProduceSound();
}