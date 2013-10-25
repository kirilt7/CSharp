class Student : Human
{
    protected double grade;

    public Student(string firstName, string lastName, double grade)
        : base(firstName, lastName)
    {
        this.Grade = grade;
    }
    public double Grade
    {
        get
        {
            return this.grade;
        }
        set
        {
            this.grade = value;
        }
    }
    public override string ToString()
    {
        return string.Format("Name: {0} {1} - grade: {2}", this.FirstName, this.LastName, this.Grade);
    }
}