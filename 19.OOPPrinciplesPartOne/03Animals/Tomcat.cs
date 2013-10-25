using System;
class Tomcat : Cat
{
    public Tomcat(string name, int age, Gender gender)
        : base(name, age, gender)
    {
        if (gender != Gender.Male)
        {
            throw new ArgumentException("Tomcats are male!");
        }
    }
}