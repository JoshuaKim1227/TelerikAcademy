using System;
using System.Text;

public class Student : ICloneable, IComparable<Student>
{
    private string firstName;
    private string middleName;
    private string lastName;
    private long ssn;
    private string address;
    private int mobilePhone;
    private string email;
    private int course;
    private Specialty specialty;
    private University university;
    private Faculty faculty;

    public Student(
        string firstName, 
        string middleName, 
        string lastName, 
        long ssn, 
        string address, 
        int mobilePhone, 
        string email, 
        int course, 
        Specialty specialty, 
        University university, 
        Faculty faculty)
    {
        this.FirstName = firstName;
        this.MiddleName = middleName;
        this.LastName = lastName;
        this.Ssn = ssn;
        this.Address = address;
        this.MobilePhone = mobilePhone;
        this.Email = email;
        this.Course = course;
        this.Specialty = specialty;
        this.University = university;
        this.Faculty = faculty;
    }

    public string FirstName
    {
        get { return this.firstName; }
        private set { this.firstName = value; }
    }

    public string MiddleName
    {
        get { return this.middleName; }
        private set { this.middleName = value; }
    }

    public string LastName
    {
        get { return this.lastName; }
        private set { this.lastName = value; }
    }

    public long Ssn
    {
        get { return this.ssn; }
        private set { this.ssn = value; }
    }

    public string Address
    {
        get { return this.address; }
        private set { this.address = value; }
    }

    public int MobilePhone
    {
        get { return this.mobilePhone; }
        private set { this.mobilePhone = value; }
    }

    public string Email
    {
        get { return this.email; }
        private set { this.email = value; }
    }

    public int Course
    {
        get { return this.course; }
        private set { this.course = value; }
    }

    public Specialty Specialty
    {
        get { return this.specialty; }
        private set { this.specialty = value; }
    }

    public University University
    {
        get { return this.university; }
        private set { this.university = value; }
    }

    public Faculty Faculty
    {
        get { return this.faculty; }
        private set { this.faculty = value; }
    }

    public static bool operator ==(Student student1, Student student2)
    {
        return student1.Ssn.Equals(student2.Ssn);
    }

    public static bool operator !=(Student student1, Student student2)
    {
        return !student1.Ssn.Equals(student2.Ssn);
    }

    // Conparing students by SSN
    public override bool Equals(object obj)
    {
        Student student = obj as Student;

        if (this.Ssn == student.Ssn)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override int GetHashCode()
    {
        return this.LastName.GetHashCode() ^ this.Ssn.GetHashCode();
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();

        sb.Append(string.Format("\nStudent name: {0} {1} {2}\n", this.FirstName, this.MiddleName, this.LastName));
        sb.Append(string.Format("SSN: {0}\n", this.Ssn));
        sb.Append(string.Format("Address: {0}\n", this.Address));
        sb.Append(string.Format("Mobile Phone: {0}\n", this.MobilePhone));
        sb.Append(string.Format("E-mail: {0}\n", this.Email));
        sb.Append(string.Format("Course: {0}\n", this.Course));
        sb.Append(string.Format("Specialty: {0}\n", this.Specialty));
        sb.Append(string.Format("University: {0}\n", this.University));
        sb.Append(string.Format("Faculty: {0}\n", this.Faculty));
        
        return sb.ToString();
    }

    public Student Clone()
    {
        Student clonedStudent = new Student(
            string.Copy(this.FirstName),
            string.Copy(this.MiddleName),
            string.Copy(this.LastName),
            this.Ssn,
            string.Copy(this.Address),
            this.MobilePhone,
            string.Copy(this.Email),
            this.Course,
            this.Specialty,
            this.University,
            this.Faculty);

        return clonedStudent;
    }

    object ICloneable.Clone()
    {
        return this.Clone();
    }

    public int CompareTo(Student other)
    {
        if (this.FirstName != other.FirstName)
        {
            return this.FirstName.CompareTo(other.FirstName);
        }
        else if (this.MiddleName != other.MiddleName)
        {
            return this.MiddleName.CompareTo(other.MiddleName);
        }
        else if (this.LastName != other.LastName)
        {
            return this.LastName.CompareTo(other.LastName);
        }
        else if (this.Ssn != other.Ssn)
        {
            return (int)(this.Ssn - other.Ssn);
        }
        else
        {
            return 0;
        }
    }
}