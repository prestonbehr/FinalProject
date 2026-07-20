class Activity
{
    private string _date;
    private int _minutes;

    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public string GetDate()
    {
        return _date;
    }

    public int GetMinutes()
    {
        return _minutes;
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }

    public virtual string GetActivityType()
    {
        return "Activity";
    }

    public string GetSummary()
    {
        return _date + " " +
               GetActivityType() + " (" +
               _minutes + " min) - Distance " +
               GetDistance() + " miles, Speed " +
               GetSpeed() + " mph, Pace " +
               GetPace() + " min per mile";
    }
}