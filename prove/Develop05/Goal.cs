public class Goal
{
    private string name;
    protected int points;
    private bool isCompleted;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Points
    {
        get { return points; }
        set { points = value; }
    }

    public bool IsCompleted
    {
        get { return isCompleted; }
        set { isCompleted = value; }
    }

    public Goal(string name, int points)
    {
        Name = name;
        Points = points;
        IsCompleted = false;
    }

    public virtual void RecordEvent()
    {
        IsCompleted = true;
    }

    public virtual string DisplayStatus()
    {
        return IsCompleted ? "[X]" : "[ ]";
    }
}
