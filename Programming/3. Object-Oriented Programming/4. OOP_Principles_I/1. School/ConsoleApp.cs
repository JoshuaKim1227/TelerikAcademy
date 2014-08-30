using System;
using System.Collections.Generic;

public class ConsoleApp
{
    public static void Main()
    {
        Class mathClass = new Class("0013");

        Student studentKircho = new Student("Kircho", "0013");
        Student studentNasko = new Student("Nasko", "0013");

        Teacher teacherPencho = new Teacher("Pencho");
        Teacher teacherIvan = new Teacher("Ivan");

        mathClass.Teachers.Add(teacherPencho);
        mathClass.Teachers.Add(teacherIvan);
        mathClass.Students.Add(studentKircho);
        mathClass.Students.Add(studentNasko);
        mathClass.Comments = "This is a comment for the class";

        teacherPencho.Disciplines.Add(new Disciplines("Math", 3, 5));
        teacherPencho.Disciplines.Add(new Disciplines("Biology", 2, 3));
        teacherPencho.Disciplines.Add(new Disciplines("Literature", 6, 3));
        teacherPencho.Comments = "This is a comments for the teacher";

        teacherIvan.Disciplines.Add(new Disciplines("Informatics", 5, 10));
        teacherIvan.Disciplines.Add(new Disciplines("Robotics", 3, 5));
        teacherIvan.Disciplines.Add(new Disciplines("Networking", 7, 5));
    }
}
