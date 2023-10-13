using System;
using System.Collections.Generic;

// Define the Job class
public class Job
{
    // Member variables
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    // Constructor to initialize the job details
    public Job(string company, string jobTitle, int startYear, int endYear)
    {
        _company = company;
        _jobTitle = jobTitle;
        _startYear = startYear;
        _endYear = endYear;
    }

    // Method to display job information
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}

// Define the Resume class
public class Resume
{
    // Member variables
    public string _personName;
    public List<Job> _jobs;

    // Constructor to initialize the person's name and job list
    public Resume(string personName)
    {
        _personName = personName;
        _jobs = new List<Job>();
    }

    // Method to add a job to the resume
    public void AddJob(Job job)
    {
        _jobs.Add(job);
    }

    // Method to display the resume using a for loop
    public void Display()
    {
        Console.WriteLine($"Name: {_personName}");
        Console.WriteLine("Jobs:");
        for (int i = 0; i < _jobs.Count; i++)
        {
            Job job = _jobs[i];
            job.Display();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create instances of Job
        Job job1 = new Job("Microsoft", "Software Engineer", 2019, 2022);
        Job job2 = new Job("Apple", "Manager", 2022, 2023);

        // Create an instance of Resume
        Resume myResume = new Resume("Allison Rose");

        // Add jobs to the resume
        myResume.AddJob(job1);
        myResume.AddJob(job2);

        // Display the resume
        myResume.Display();
    }
}
