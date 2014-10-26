using System;
using System.Collections.Generic;
class Teacher : Human, IComment
{
    private Dictionary<Discipline, int> setOfDisciplines;

    public Teacher(string name)
        : base(name)
    {
        setOfDisciplines = new Dictionary<Discipline, int>();
    }
    public Dictionary<Discipline, int> SetOfDisciplines
    {
        get
        {
            return this.setOfDisciplines;
        }
    }
    public void AddDiscipline(Discipline discipline)
    {
        this.setOfDisciplines.Add(discipline, 1);
    }
    public void RemoveDiscipline(Discipline discipline)
    {
        int value;
        if (this.setOfDisciplines.TryGetValue(discipline, out value))
        {
            this.setOfDisciplines.Remove(discipline);
        }
        else
        {
            throw new ArgumentException("This discipline has not been assigned to this teacher.");
        }
    }
}