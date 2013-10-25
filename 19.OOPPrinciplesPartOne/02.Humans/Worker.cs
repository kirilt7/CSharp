class Worker : Human
{
    private decimal weeklySalary;
    private double workHoursPerDay;

    public Worker(string firstName, string lastName, decimal salary, double workingHours)
        : base(firstName, lastName)
    {
        this.WeeklySalary = salary;
        this.WorkHoursPerDay = workingHours;
    }
    public decimal WeeklySalary
    {
        get
        {
            return this.weeklySalary;
        }
        set
        {
            this.weeklySalary = value;
        }
    }
    public double WorkHoursPerDay
    {
        get
        {
            return this.workHoursPerDay;
        }
        set
        {
            this.workHoursPerDay = value;
        }
    }
    public decimal MoneyPerHour()
    {
        return this.WeeklySalary / (decimal)(WorkHoursPerDay * 5);
    }
    public override string ToString()
    {
        return string.Format("Name: {0} {1} - Money per hour: {2:F2}", this.FirstName, this.LastName, this.MoneyPerHour());
    }
}