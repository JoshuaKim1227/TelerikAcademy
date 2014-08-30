using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SchoolSystem;
using System.Collections.Generic;

namespace TestSchool
{
    [TestClass]
    public class CourseTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NoStudentsInCourse()
        {
            Course course = new Course();

            course.AddStudent(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void StudentsCountMoreThanAllowed()
        {
            List<Student> students = new List<Student>();

            Course course = new Course();

            for (int count = 0; count < 31; count++)
            {
                students.Add(new Student("TestStudent", 10000 + count));
            }

            foreach (Student student in students)
            {
                course.AddStudent(student);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void MaxStudentInCoursePlusOneMore()
        {
            List<Student> students = new List<Student>();
            Course course = new Course();

            for (int count = 0; count < 30; count++)
            {
                students.Add(new Student("TestStudent", 10000 + count));
            }

            foreach (Student student in students)
            {
                course.AddStudent(student);
            }

            course.AddStudent(new Student("ExtraStudent", 13000));
        }

        [TestMethod]
        public void OneStudentInCourseLeaves()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("Petko", 12987));

            Course course = new Course();

            course.RemoveStudent(students[0]);
        }
    }
}