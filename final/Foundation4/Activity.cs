public abstract class Activity
{
    private DateTime date;
    private int minutes;

    public DateTime Date
    {
        get { return date; }
        set { date = value; }
    }

    public int Minutes
    {
        get { return minutes; }
        set { minutes = value; }
    }

    public Activity(DateTime date, int minutes)
    {
        this.date = date;
        this.minutes = minutes;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{Date.ToString("dd MMM yyyy")} {this.GetType().Name} ({Minutes} min): Distance {GetDistance():0.0} miles, Speed {GetSpeed():0.0} mph, Pace: {GetPace():0.0} min per mile";
    }
}