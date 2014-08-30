using System;
using System.Collections.Generic;

namespace SchoolSystem
{
    public class Course
    {
        private const int maxStudents = 30;
        private List<Student> students;

        public Course()
        {
            students = new List<Student>();
        }

        public List<Student> Students
        {
            get
            {
                return this.students;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Students", "There must be at least one student.");
                }

                if (this.students.Count > maxStudents)
                {
                    throw new ArgumentOutOfRangeException("Students", "Students can't be more than 30.");
                }

                this.students = value;
            }
        }

        public void AddStudent(Student student)
        {
            if (!CheckStudentIdUniqueness(student))
            {
                throw new ArgumentException("Student", "Student's Id Numbers must be unique.");
            }
            else if (student == null)
            {
                throw new ArgumentNullException("Student", "Student cannot be null.");
            }
            else if (students.Count + 1 >= maxStudents)
            {
                throw new ArgumentOutOfRangeException("Student", "Students cannot be more than 30.");
            }
            else
            {
                this.Students.Add(student);
            }
        }

        public void RemoveStudent(Student student)
        {
            this.Students.Remove(student);
        }

        private bool CheckStudentIdUniqueness(Student newStudent)
        {
            foreach (Student student in students)
            {
                if (student.IdNum == newStudent.IdNum)
                {
                    return false;
                }
            }

            return true;
        }
    }
}