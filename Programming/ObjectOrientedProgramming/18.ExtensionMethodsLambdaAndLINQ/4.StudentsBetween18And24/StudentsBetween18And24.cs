using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
class StudentsBetween18And24
{
    static void Main()
    {
        Student[] students = {
        new Student ("Leo","Messi",27 ),
        new Student ("Cristiano", "Ronaldo",28 ),
        new Student ("Unufri", "Georgiev",19 ),
        new Student ("Stamat", "Petkov",22),
        new Student ("Ivan", "Petrov",105 )};
        var sortedStudens =
            from student in students
            where student.Age > 18 && student.Age < 25
            select student;
        foreach (var student in sortedStudens)
        {
            Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
        }
    }
}
