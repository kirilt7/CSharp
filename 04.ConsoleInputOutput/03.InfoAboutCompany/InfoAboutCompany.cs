using System;

class InfoAboutCompany
{
    static void Main()
    {
        Console.WriteLine("Please enter a name of company:");
        string nameOfCompany = Console.ReadLine();
        Console.WriteLine("Please enter a adress of company:");
        string adress = Console.ReadLine();
        Console.WriteLine("Please enter a web site of company:");
        string webSite = Console.ReadLine();
        Console.WriteLine("Please enter a phone of company:");
        string phone = Console.ReadLine();
        Console.WriteLine("Please enter a fax number of company:");
        string faxNumber = Console.ReadLine();
        Console.WriteLine("Please neter first name of manager:");
        string firstName = Console.ReadLine();
        Console.WriteLine("Please neter last name of manager:");
        string lastName = Console.ReadLine();
        Console.WriteLine("Please enter age of manager:");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter a phone number of manager:");
        string phoneOfManager = Console.ReadLine();
        Console.WriteLine("Company name:{0}\nAdress: {1}\nWeb site: {2}", nameOfCompany, adress, webSite);
        Console.WriteLine("Phone: {0}\nFax: {1}",phone, faxNumber);
        Console.WriteLine("Manager: {0} {1}, Age: {2}\nPhone: {3}", firstName, lastName, age, phoneOfManager);
    }
}
