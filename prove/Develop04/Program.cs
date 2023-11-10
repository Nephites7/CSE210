using System;

class Program
{
    static void Main()
    {
        int choice = 0;
        while (choice != 4)
        {
            Console.Clear();
            Console.WriteLine("Hello! Welcome To The Mindfulness Activity! Please Choose An Option From The Menu:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");
            Console.Write("Select an activity (1-4): ");

            if (int.TryParse(Console.ReadLine(), out choice))
            {
                if (choice == 4)
                    break;
                Console.Write("How long would you like this activity to be?: ");
                if (int.TryParse(Console.ReadLine(), out int duration) && duration > 0)
                {
                    MindfulnessActivity activity = null;
                    switch (choice)
                    {
                        case 1:
                            activity = new BreathingActivity(duration);
                            break;
                        case 2:
                            activity = new ReflectionActivity(duration);
                            break;
                        case 3:
                            activity = new ListingActivity(duration);
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please select a valid activity.");
                            continue;
                    }
                    activity.PerformActivity();
                }
                else
                {
                    Console.WriteLine("Invalid duration. Please enter a positive number.");
                }
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select a valid activity.");
            }
        }
    }
}
