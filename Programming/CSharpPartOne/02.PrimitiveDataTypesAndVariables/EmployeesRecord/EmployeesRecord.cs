using System;
class EmployeesRecord
{
    static void Main()
    {
        string firstName = "Ivan", familyName = "Ivanov";
        byte age = 22;
        char gender = 'm';
        int idNumber = 69;
        ushort uniqueEmpNumber = 69;
        Console.WriteLine("Personal Information about {0} {1}:\n\nFirst Name: {0}\nFamily Name: {1}\nAge: {2}\nGender: {3}\nID Number: {4}\nUnique Employee Number: {5}", firstName, familyName, age, gender, idNumber, 27560000 + uniqueEmpNumber);
    }
}
