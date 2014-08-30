using System;
using System.Collections.Generic;

public class Class : SchoolObject
{
    private List<Teacher> teachers;
    private List<Student> students;

    public Class(string classIdentifier)
    {
        this.IdentifierOrName = classIdentifier;
        this.teachers = new List<Teacher>();
        this.students = new List<Student>();
    }

    public List<Teacher> Teachers
    {
        get { return this.teachers; }
        set { this.teachers = value; }
    }

    public List<Student> Students
    {
        get { return this.students; }
        set { this.students = value; }
    }
}