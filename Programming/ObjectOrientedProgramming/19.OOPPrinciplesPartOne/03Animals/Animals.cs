using System;
using System.Collections.Generic;
using System.Linq;
class Animals
{
    static void Main(string[] args)
    {
        Animal[] myZoo = 
        {
            new Cat("Ivanka", 12, Gender.Female),
            new Kitten("Ivanka", 13, Gender.Female),
            new Frog("Ivanka", 20, Gender.Female),
            new Frog("Ivanka", 10, Gender.Female),
            new Dog("Ivanka", 15, Gender.Female),
            new Cat("Ivanka", 12, Gender.Female),
            new Kitten("Ivanka", 12, Gender.Female),
            new Frog("Ivanka", 21, Gender.Female),
            new Frog("Ivanka", 10, Gender.Female),
            new Dog("Ivanka", 12, Gender.Female),
            new Cat("Ivanka", 12, Gender.Female),
            new Kitten("Ivanka", 12, Gender.Female),
            new Frog("Ivanka", 20, Gender.Female),
            new Frog("Ivanka", 10, Gender.Female),
            new Dog("Ivanka", 12, Gender.Female),
            new Cat("Ivanka", 12, Gender.Female),
            new Kitten("Ivanka", 12, Gender.Female),
            new Frog("Ivanka", 20, Gender.Female),
            new Frog("Ivanka", 10, Gender.Female),
            new Dog("Ivanka", 12, Gender.Female),
        };
        var animalGroups =
               from animal in myZoo
               group animal by animal.GetType().Name into g
               select g.ToArray();
        foreach (var group in animalGroups)
        {
            Console.WriteLine("{0, 9}s  - Average age: {1}", group[0].GetType(), Animal.AverageAge(group));
        }
    }
}
