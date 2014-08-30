using System;
using System.Collections.Generic;

public class Teacher : SchoolObject
{
    private List<Disciplines> disciplines;

    public Teacher(string name)
    {
        this.IdentifierOrName = name;
        this.Disciplines = new List<Disciplines>();
    }

    public List<Disciplines> Disciplines 
    {
        get { return this.disciplines; }
        set { this.disciplines = value; }
    }
}