using System;
using System.Collections.Generic;
class StudentsClass : IComment
{
    private Dictionary<Teacher, int> setOfTeachers;
    private string identifier;
    private static Dictionary<string, int> identifiersList = new Dictionary<string, int>();
    private string comment;

    public StudentsClass(string identifier)
    {
        this.Identifier = identifier;
        this.setOfTeachers = new Dictionary<Teacher, int>();
    }
    public string Identifier
    {
        get
        {
            return this.identifier;
        }
        private set
        {
            int identifierValue;
            if (!identifiersList.TryGetValue(value, out identifierValue))
            {
                this.identifier = value;
                identifiersList.Add(value, 1);
            }
            else
            {
                throw new Exception("The identifier already exist.");
            }

        }
    }
    public Dictionary<Teacher, int> SetOfTeachers
    {
        get
        {
            return this.setOfTeachers;
        }
    }
    public void AddTeacher(Teacher teacher)
    {
        this.setOfTeachers.Add(teacher, 1);
    }
    public void RemoveTeacher(Teacher teacher)
    {
        int value;
        if (setOfTeachers.TryGetValue(teacher, out value))
        {
            setOfTeachers.Remove(teacher);
        }
        else
        {
            throw new ArgumentException("This teacher is not assigned to this class.");
        }
    }
    public string Comment
    {
        get
        {
            return this.comment;
        }
        private set
        {
            this.comment = value;
        }
    }
    public void AddComment(string comment)
    {
        this.Comment = comment;
    }
}