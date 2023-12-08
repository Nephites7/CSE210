using System;

class CyclingActivity : Activity
{
    private double speed;

    public CyclingActivity(DateTime date, int durationMinutes, double speed)
        : base(date, durationMinutes)
    {
        this.speed = speed;
    }

    public override double GetSpeed()
    {
        return speed;
    }

    public override double GetDistance()
    {
        return speed * (durationMinutes / 60.0);
    }

    public override double GetPace()
    {
        return 60.0 / speed;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Cycling ({durationMinutes} min) - Speed {speed:F1} kph, Distance {GetDistance():F1} kilometers, Pace: {GetPace():F1} min per km";
    }
}
