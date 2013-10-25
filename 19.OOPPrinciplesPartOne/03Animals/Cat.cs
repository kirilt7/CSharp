﻿using System;
class Cat : Animal
{
    public Cat(string name, int age, Gender gender) : base(name, age, gender) { }
    public override void MakeSound()
    {
        Console.WriteLine("Miyaaaayyyy!");
    }
}