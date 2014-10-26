using System;
public class Human : IComment
{
    protected string name;
    protected string comment;

    public Human(string name)
    {
        this.Name = name;
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
    public void AddComment(string comment)
    {
        this.Comment = comment;
    }
}