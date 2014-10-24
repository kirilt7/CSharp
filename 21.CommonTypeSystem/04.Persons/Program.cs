using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Persons
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Ivan", 18);
            Person p2 = new Person("Dragan");
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            p2.Age = 20;
            Console.WriteLine(p2);
        }
    }
}
