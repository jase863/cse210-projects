using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activitiesList = new List<Activity>();

        Running running = new Running("25 May 2023", 27, "Running", 3.25);
        activitiesList.Add(running);
        
        Cycling cycling = new Cycling("28 May 2023", 73, "Cycling", 12.8);
        activitiesList.Add(cycling);

        Swimming swimming = new Swimming("31 May 2023", 42, "Swimming", 58);
        activitiesList.Add(swimming);

        foreach(Activity activity in activitiesList)
        {
            activity.GetSummary();
        }
    }
}
