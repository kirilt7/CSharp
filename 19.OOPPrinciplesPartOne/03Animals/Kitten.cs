using System;
class Kitten : Cat
{
    public Kitten(string name, int age, Gender gender) : base(name, age, gender) 
    {
        if (gender != Gender.Female)
        {
            throw new ArgumentException("Kittens are female!");
        }
    }
}