using System;

public interface ISound
{
    string Sound
    {
        get;
        set;
    }

    void ProduceSound();
}