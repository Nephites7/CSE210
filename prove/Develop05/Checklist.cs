public class ChecklistGoal : Goal
{
    private int targetCount;
    private int completedCount;

    public int TargetCount
    {
        get { return targetCount; }
        set { targetCount = value; }
    }

    public ChecklistGoal(string name, int points, int targetCount) : base(name, points)
    {
        TargetCount = targetCount;
        completedCount = 0;
    }

    public override void RecordEvent()
    {
        completedCount++;
        Points += 50;

        if (completedCount == TargetCount)
        {
            Points += 500;
            IsCompleted = true;
        }
    }

    public override string DisplayStatus()
    {
        return $"Completed {completedCount}/{TargetCount} times";
    }
}
