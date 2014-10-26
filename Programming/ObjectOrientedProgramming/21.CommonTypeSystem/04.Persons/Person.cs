using System;
using System.Text;

public class Person
{
    private string name;
    private int? age;

    public Person(string name)
        : this(name, null)
    {
    }

    public Person(string name, int? age)
    {
        this.name = name;
        this.age = age;
    }

    public string Name
    {
        get
        {
            return this.name;
        }

        set
        {
            this.name = value;
        }
    }

    public int? Age
    {
        get
        {
            return this.age;
        }

        set
        {
            this.age = value;
        }
    }

    public override string ToString()
    {
        return String.Format("Name: {0} \nAge: {1}\n", this.Name, this.Age == null ? "Not specified!" : this.Age.ToString());
    }
}