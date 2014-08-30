using System;

class CompanyInfo
{
    static void Main()
    {
        string companyName;
        string companyAddress;
        string companyWebSite;
        long companyPhone;
        long companyFax;

        string managerNames;
        int managerAge;
        long managerPhone;

        Console.WriteLine("Enter the name of the company: ");
        companyName = Console.ReadLine();
        Console.WriteLine("Enter the address of the company: ");
        companyAddress = Console.ReadLine();
        Console.WriteLine("Enter the phone number of the company: ");
        companyPhone = long.Parse(Console.ReadLine());
        Console.WriteLine("Enter the fax number of the company: ");
        companyFax = long.Parse(Console.ReadLine());
        Console.WriteLine("Enter the website of the company: ");
        companyWebSite = Console.ReadLine();

        Console.WriteLine("\nEnter the manager's first name and last name: ");
        managerNames = Console.ReadLine();
        Console.WriteLine("Enter the manager's age: ");
        managerAge = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the manager's phone number: ");
        managerPhone = long.Parse(Console.ReadLine());

        Console.WriteLine("\nCompany name: {0} \nCompany address: {1} \nCompany website: {2}", companyName, companyAddress, companyWebSite);
        Console.WriteLine("\nCompany phone number: {0} \nCompany fax number: {1}", companyPhone, companyFax);

        Console.WriteLine("\nManager's name: {0} \nManager's age: {1}", managerNames, managerAge);
        Console.WriteLine("\nManager's phone number: {0} ", managerPhone);
    }
}

