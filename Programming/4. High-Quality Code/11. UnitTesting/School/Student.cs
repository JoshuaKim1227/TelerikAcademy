using System;

namespace SchoolSystem
{
    public class Student
    {
        private string name;
        private int idNum;

        public Student(string name, int idNum)
        {
            Name = name;
            IdNum = idNum;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Name", "The student must have name.");
                }

                if (value == string.Empty)
                {
                    throw new ArgumentNullException("Name", "The student must have name.");
                }

                this.name = value;
            }
        }

        public int IdNum
        {
            get
            {
                return this.idNum;
            }

            set
            {
                if (value < 10000 || value > 99999)
                {
                    throw new ArgumentOutOfRangeException("IdNum", "Student's IdNum must be between 10 000 and 99 999");
                }

                this.idNum = value;
            }
        }
    }
}