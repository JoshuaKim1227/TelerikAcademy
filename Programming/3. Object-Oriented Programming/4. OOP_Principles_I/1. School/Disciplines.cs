using System;

public class Disciplines : SchoolObject
{
    private int numberOfLectures;
    private int numberOfExercises;

    public Disciplines(string name, int numberOfLectures, int numberOfExercises)
    {
        this.IdentifierOrName = name;
        this.NumberOfLectures = numberOfLectures;
        this.numberOfExercises = numberOfExercises;
    }

    public int NumberOfLectures
    {
        get { return this.numberOfLectures; }
        set { this.numberOfLectures = value; }
    }

    public int NumberOfExercises
    {
        get { return this.numberOfLectures; }
        set { this.numberOfLectures = value; }
    }
}