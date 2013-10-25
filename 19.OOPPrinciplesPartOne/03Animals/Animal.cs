using System;
using System.Linq;
public enum Gender
{
    Male,
    Female
}
abstract class Animal : ISound
    {
        public string Name { get; set;}
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public Animal(string name, int age, Gender gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }
        public abstract void MakeSound();
        public static double AverageAge(Animal[] animals)
        {
            return animals.Average(x => x.Age);
        }
    }
