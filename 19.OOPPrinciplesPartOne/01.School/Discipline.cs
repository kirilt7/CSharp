class Discipline : IComment
{
    private string name;
    private int numberOfLectures;
    private int numberOfExercises;
    private string comment;

    public Discipline(string name, int numberOfLectures, int numberOfExercises)
    {
        this.Name = name;
        this.NumberOfLectures = numberOfLectures;
        this.NumberOfExercises = numberOfExercises;
    }
    public string Name
    {
        get
        {
            return this.name;
        }
        set
        {
            this.name = value;
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
    public int NumberOfLectures
    {
        get
        {
            return this.numberOfLectures;
        }
        set
        {
            this.numberOfLectures = value;
        }
    }
    public int NumberOfExercises
    {
        get
        {
            return this.numberOfExercises;
        }
        set
        {
            this.numberOfExercises = value;
        }
    }
    public void AddComment(string comment)
    {
        this.Comment = comment;
    }
}