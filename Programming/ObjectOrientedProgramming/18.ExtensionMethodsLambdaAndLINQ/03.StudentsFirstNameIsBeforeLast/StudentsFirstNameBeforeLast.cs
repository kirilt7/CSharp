using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
class StudentsFirstNameBeforeLast
{
    private static Student[] FirstNameIsBeforeLast(Student[] students)
    {
        var sortedStudens =
            from student in students
            where student.FirstName.CompareTo(student.LastName) < 0
            select student;
        return sortedStudens.ToArray();
    }
    static void Main()
    {
        Student[] students = {
        new Student ("Leo","Messi" ),
        new Student ("Cristiano", "Ronaldo" ),
        new Student ("Unufri", "Georgiev" ),
        new Student ("Stamat", "Petkov"),
        new Student ("Ivan", "Petrov" )};
        Student[]  sortedStudents = FirstNameIsBeforeLast(students);
        foreach (var student in sortedStudents)
        {
            Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
        }
    }
}
