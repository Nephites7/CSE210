using System;
using System.Collections.Generic;

class ExerciseTracker
{
    static void Main()
    {
        List<Activity> activities = new List<Activity>();

        DateTime activityDate = new DateTime(2022, 11, 3);

        RunningActivity running = new RunningActivity(activityDate, 30, 3.0);
        CyclingActivity cycling = new CyclingActivity(activityDate, 30, 20.0);
        SwimmingActivity swimming = new SwimmingActivity(activityDate, 30, 10);

        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
