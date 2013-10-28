using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    class GenericTest
    {
        static void Main()
        {
            Console.WriteLine("Hello World.");
            Console.WriteLine("Make new List.");
            GenericList<float> newList = new GenericList<float>(20);
            Console.WriteLine("Add some numbers to the List - 5.3, 6.27, 7.55, 8, 9.09");
            newList.AddElement(5.3f);
            newList.AddElement(6.27f);
            newList.AddElement(7.55f);
            newList.AddElement(8f);
            newList.AddElement(9.09f);
            Console.WriteLine("Print Max element: {0}", newList.Max());
            Console.WriteLine("Print Min element: {0}", newList.Min());
            Console.WriteLine("Add 10 in the biggining.");
            newList.InsertElement(0, 10);
            Console.WriteLine("Print Max element again: {0}", newList.Max());
            Console.WriteLine("Print the List.");
            Console.WriteLine(newList);
            Console.WriteLine("Remove the fourth element.");
            newList.RemoveElement(3);
            Console.WriteLine("Print the List.");
            Console.WriteLine(newList);
            Console.WriteLine("Remove the fourth element.");
            newList.RemoveElement(3);
            Console.WriteLine("Print the List.");
            Console.WriteLine(newList);
            Console.WriteLine("Remove the fourth element.");
            newList.RemoveElement(3);
            Console.WriteLine("Print the List.");
            Console.WriteLine(newList);
            Console.WriteLine("Add 15.56 in the end.");
            newList.InsertElement(3, 15.56f);
            Console.WriteLine("Print the List.");
            Console.WriteLine(newList);
        }
    }
}
