using System;

public class Student : Human
{
    private int grade;

    public Student(string firstName, string lastName, int grade)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Grade = grade;
    }

    public int Grade
    {
        get { return this.grade; }
        set { this.grade = value; }
    }

    public override string ToString()
    {
        return string.Format("Name of student: {0} {1}\nGrade: {2}", this.FirstName, this.LastName, this.Grade);
    }
}