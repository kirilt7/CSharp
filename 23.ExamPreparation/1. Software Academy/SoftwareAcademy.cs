using System;
using System.Linq;
using System.Text;
using System.CodeDom.Compiler;
using Microsoft.CSharp;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace SoftwareAcademy
{
    public interface ITeacher
    {
        string Name { get; set; }
        void AddCourse(ICourse course);
        string ToString();
    }

    public interface ICourse
    {
        string Name { get; set; }
        ITeacher Teacher { get; set; }
        void AddTopic(string topic);
        string ToString();
    }

    public interface ILocalCourse : ICourse
    {
        string Lab { get; set; }
    }

    public interface IOffsiteCourse : ICourse
    {
        string Town { get; set; }
    }

    public interface ICourseFactory
    {
        ITeacher CreateTeacher(string name);
        ILocalCourse CreateLocalCourse(string name, ITeacher teacher, string lab);
        IOffsiteCourse CreateOffsiteCourse(string name, ITeacher teacher, string town);
    }
    public class Teacher : ITeacher
    {
        private string name;
        private ICollection<ICourse> courses;
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(name, "Cannot be null!");
                }
                this.name = value;
            }
        }
        public Teacher(string name)
        {
            this.Name = name;
            this.courses=new List<ICourse>();
        }
        public void AddCourse(ICourse course)
        {
            courses.Add(course);
        }
        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.AppendFormat("Teacher: Name={0}", this.Name);
            if (this.courses.Count > 0)
            {
                str.AppendFormat("; Courses=[{0}]", string.Join(", ",courses.Select(course =>course.Name)));
            }
            return str.ToString();
        }
    }
    public abstract class Course : ICourse
    {
        private string name;
        private ITeacher teacher;
        public List<string> topics;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value==null)
                {
                    throw new ArgumentNullException(value, "Cannot be null!");
                }
                name = value;
            }
        }

        public ITeacher Teacher
        {
            get
            {
                return teacher;
            }
            set
            {
                teacher = value;
            }
        }
        public Course(string name, ITeacher teacher)
        {
            this.Name = name;
            this.Teacher = teacher;
            this.topics = new List<string>();
        }
        public void AddTopic(string topic)
        {
            topics.Add(topic);
        }
        
    }
    public class LocalCourse : Course, ILocalCourse
    {
        private string lab;
        public string Lab
        {
            get
            {
                return lab;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(value, "lab is null");
                }
                lab = value;
            }
        }
        public LocalCourse(string name, ITeacher teacher, string lab)
            : base(name, teacher)
        {
            this.Lab = lab;
        }
        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.AppendFormat("{0}: Name={1}", this.GetType().Name, this.Name);
            if (this.Teacher != null)
            {
                str.AppendFormat("; Teacher={0}", this.Teacher.Name);
            }
            if (topics.Count > 0)
            {
                str.AppendFormat("; Topics=[{0}]", string.Join(", ", this.topics));
            }
            if (this.Lab!=null)
            {
                str.AppendFormat("; Lab={0}", this.Lab);
            }
            return str.ToString();
        }
    }

    public class OffsiteCourse : Course, IOffsiteCourse
    {
        private string town;
        public string Town
        {
            get
            {
                return town;
            }
            set
            {
                if (value==null)
                {
                     throw new ArgumentNullException(value, "Cannot be null!");
                }
                town = value;
            }
        }
        public OffsiteCourse(string name, ITeacher teacher, string town)
            : base(name, teacher)
        {
            this.Town = town;
        }
        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.AppendFormat("{0}: Name={1}", this.GetType().Name, this.Name);
            if (this.Teacher != null)
            {
                str.AppendFormat("; Teacher={0}", this.Teacher.Name);
            }
            if (topics.Count > 0)
            {
                str.AppendFormat("; Topics=[{0}]", string.Join(", ", this.topics));
            }
            if (this.Town != null)
            {
                str.AppendFormat("; Town={0}", this.Town);
            }
            return str.ToString();
        }
    }

    public class CourseFactory : ICourseFactory
    {
        public ITeacher CreateTeacher(string name)
        {
            return new Teacher(name);
        }

        public ILocalCourse CreateLocalCourse(string name, ITeacher teacher, string lab)
        {
            return new LocalCourse(name, teacher, lab);
        }

        public IOffsiteCourse CreateOffsiteCourse(string name, ITeacher teacher, string town)
        {
            return new OffsiteCourse(name, teacher, town);
        }
    }

    public class SoftwareAcademyCommandExecutor
    {
        static void Main()
        {
            string csharpCode = ReadInputCSharpCode();
            CompileAndRun(csharpCode);
        }

        private static string ReadInputCSharpCode()
        {
            StringBuilder result = new StringBuilder();
            string line;
            while ((line = Console.ReadLine()) != "")
            {
                result.AppendLine(line);
            }
            return result.ToString();
        }

        static void CompileAndRun(string csharpCode)
        {
            // Prepare a C# program for compilation
            string[] csharpClass =
            {
                @"using System;
                  using SoftwareAcademy;

                  public class RuntimeCompiledClass
                  {
                     public static void Main()
                     {"
                        + csharpCode + @"
                     }
                  }"
            };

            // Compile the C# program
            CompilerParameters compilerParams = new CompilerParameters();
            compilerParams.GenerateInMemory = true;
            compilerParams.TempFiles = new TempFileCollection(".");
            compilerParams.ReferencedAssemblies.Add("System.dll");
            compilerParams.ReferencedAssemblies.Add(Assembly.GetExecutingAssembly().Location);
            CSharpCodeProvider csharpProvider = new CSharpCodeProvider();
            CompilerResults compile = csharpProvider.CompileAssemblyFromSource(
                compilerParams, csharpClass);

            // Check for compilation errors
            if (compile.Errors.HasErrors)
            {
                string errorMsg = "Compilation error: ";
                foreach (CompilerError ce in compile.Errors)
                {
                    errorMsg += "\r\n" + ce.ToString();
                }
                throw new Exception(errorMsg);
            }

            // Invoke the Main() method of the compiled class
            Assembly assembly = compile.CompiledAssembly;
            Module module = assembly.GetModules()[0];
            Type type = module.GetType("RuntimeCompiledClass");
            MethodInfo methInfo = type.GetMethod("Main");
            methInfo.Invoke(null, null);
        }
    }
}
