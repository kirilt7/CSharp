using System;


class bankAccount
{
    static void Main()
    {
        string firstName = "Ivan", middleName = "Ivanov", lastName = "Georgiev";
        decimal moneyBalance = 1255.53m;
        string bankName = "Bank DSK", IBAN = "9990 9990 1234 1234", BIC = "12345678";
        string CC1 = "12345 12345 67", CC2 = "12345 12345 68", CC3 = "12345 12345 69";
        Console.WriteLine("{0} {1} {2}",firstName,middleName,lastName);
        Console.WriteLine("Balance:{0}",moneyBalance);
        Console.WriteLine("Bank: {0}",bankName);
        Console.WriteLine("IBAN:{0}",IBAN);
        Console.WriteLine("BIC:{0}",BIC);
        Console.WriteLine("Card numbers:{0}, {1}, {2}",CC1,CC2,CC3);

    }
}
