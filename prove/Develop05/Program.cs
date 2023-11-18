using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Goal> goals = new List<Goal>
        {
            new SimpleGoal("Run a marathon", 1000),
            new EternalGoal("Read scriptures", 100),
            new ChecklistGoal("Attend the temple", 50, 10)
        };

        goals[0].RecordEvent();
        goals[1].RecordEvent();
        goals[2].RecordEvent();

        foreach (var goal in goals)
        {
            Console.WriteLine($"{goal.Name} {goal.DisplayStatus()} - Points: {goal.Points}");
        }
    }
}
