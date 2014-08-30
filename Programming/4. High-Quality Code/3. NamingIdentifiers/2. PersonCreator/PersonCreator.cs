using System;

public class PersonCreator
{
    public enum Gender
    {
        Male,
        Female
    }

    public static void Main()
    {
    }

    public void CreatePerson(int age)
    {
        Person person = new Person();
        person.Age = age;

        if (age % 2 == 0)
        {
            person.Name = "Batkata";
            person.Gender = Gender.Male;
        }
        else
        {
            person.Name = "Maceto";
            person.Gender = Gender.Female;
        }
    }

    public class Person
    {
        public Gender Gender { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }
    }
}