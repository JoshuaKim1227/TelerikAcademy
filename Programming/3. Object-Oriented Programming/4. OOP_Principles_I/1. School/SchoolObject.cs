using System;
using System.Collections.Generic;

public abstract class SchoolObject
{
    private string identifierOrName;
    private string comments;

    public string IdentifierOrName
    {
        get { return this.identifierOrName; }
        set { this.identifierOrName = value; }
    }

    public string Comments
    {
        get { return this.comments; }
        set { this.comments = value; }
    }
}