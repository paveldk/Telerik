using System;

class CompanyManagerInfo
{
    static void Main()
    {
        //A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number. Write a program that reads the information about a company and its manager and prints them on the console.


        Console.Write("Input company name: ");
        string companyName = Console.ReadLine();

        Console.Write("Input company address: ");
        string companyAddress = Console.ReadLine();

        Console.Write("Input phone number: ");
        string companyPhoneNumber = Console.ReadLine();

        Console.Write("Input fax number: ");
        string companyFaxNumber = Console.ReadLine();

        Console.Write("Input company website: ");
        string companyWebsite = Console.ReadLine();

        Console.Write("Input manager first name: ");
        string managerFirstName = Console.ReadLine();

        Console.Write("Input manager last name: ");
        string managerLastName = Console.ReadLine();

        Console.Write("Input manager age: ");
        string managerAge = Console.ReadLine();

        Console.Write("Input manager phone number: ");
        string managerPhoneNumber = Console.ReadLine();

        Console.WriteLine("Company information:");
        Console.WriteLine("Name: {0} \nAdress: {1} \nPhone number: {2} \nFax number: {3} \nWebsite: {4} \n", companyName, companyAddress, companyPhoneNumber, companyFaxNumber, companyWebsite);
        Console.WriteLine("Manager information:");
        Console.WriteLine("First name: {0} \nLast name: {1} \nAge: {2} \nPhone number: {3}", managerFirstName, managerLastName, managerAge, managerPhoneNumber);
    }
}
