using System;

public class Student : SchoolObject
{
    private string classNumber;

    public Student(string name, string classNumber)
    {
        this.classNumber = classNumber;
        this.IdentifierOrName = name;
    }

    public string ClassNumber
    {
        get { return this.classNumber; }
        set { this.classNumber = value; }
    }
}