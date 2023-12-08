using System;

class SwimmingActivity : Activity
{
    private int laps;

    public SwimmingActivity(DateTime date, int durationMinutes, int laps)
        : base(date, durationMinutes)
    {
        this.laps = laps;
    }

    public override double GetDistance()
    {
        return laps * 50.0 / 1000.0; // Convert laps to kilometers
    }

    public override double GetSpeed()
    {
        return (GetDistance() / durationMinutes) * 60.0;
    }

    public override double GetPace()
    {
        return durationMinutes / GetDistance();
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Swimming ({durationMinutes} min) - {laps} laps, Distance {GetDistance():F2} km, Speed {GetSpeed():F1} kph, Pace: {GetPace():F1} min per km";
    }
}
