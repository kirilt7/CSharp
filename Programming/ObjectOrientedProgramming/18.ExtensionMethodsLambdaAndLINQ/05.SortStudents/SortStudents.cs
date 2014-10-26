using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
class SortStudents
{
    static void Main()
    {
       Student[] students = {        new Student ("Leo","Messi" ),
        new Student ("Cristiano", "Ronaldo" ),
        new Student ("Unufri", "Georgiev" ),
        new Student ("Stamat", "Petkov"),
        new Student ("Ivan", "Ivanov" ),
        new Student ("Ivan", "Petrov" )};
        
        var  sortedStudents = students.OrderByDescending(x=>x.FirstName).ThenBy(x=>x.LastName);
        foreach (var student in sortedStudents)
        {
            Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
        }
        Console.WriteLine();
        //now with LINQ
        var sortedStudentsWithLINQ =
            from student in students
            orderby student.LastName descending
            orderby student.FirstName descending
            select student;
        foreach (var student in sortedStudentsWithLINQ)
        {
            Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
        }
    }
}
