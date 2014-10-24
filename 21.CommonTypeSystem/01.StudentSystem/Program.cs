// Ex2 and Ex3 are also here...
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.StudentSystem
{
    
}
class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student("kk", "kk", "kk", "141210037", 4, "kk", "kk", "kk", University.TUSofia, Faculty.Transport, Specialty.AeronauticalEngeneering);
            Student st2 = st;
            Console.WriteLine( Student.Equals(st, st2));
            Console.WriteLine( st.Equals(st2));
            Student st3 = st.Clone() as Student;
            st2.Phone = "33";
            Console.WriteLine(st);
            Console.WriteLine(st2);
            Console.WriteLine(st3);
            Console.WriteLine(st.CompareTo(st3));
        }
    }