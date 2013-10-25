using System;
using System.Collections.Generic;
using System.Linq;
public class Student : Human, IComment
{
    private int classNumber;
    private static Dictionary<int, int> classNumbersList = new Dictionary<int, int>();

    public Student(string name, int classNumber)
        : base(name)
    {
        this.ClassNumber = classNumber;
    }
    public int ClassNumber
    {
        get
        {
            return this.classNumber;
        }
        private set
        {
            int numberValue;
            if (!classNumbersList.TryGetValue(value, out numberValue))
            {
                this.classNumber = value;
                classNumbersList.Add(value, 1);
            }
            else
            {
                throw new Exception("This class number already exist.");
            }

        }
    }
}
