using System.IO;

public class AllGoals
{
    private int _totalScore = 0;
    private List<Goal> goalsList =  new List<Goal>();
    List<string> alreadyLoaded = new List<string>{};
    public void AddToGoals(Goal _goal)
    {
        goalsList.Add(_goal); 
    }

    public List<Goal> GetGoalList()
    {
        return goalsList;
    }

    public int GetTotalScore()
    {
        return _totalScore;
    }

    public void DisplayScore()
    {
        Console.WriteLine($"\nYou have {GetTotalScore()} points");
    }
    public void DisplayGoals()
    {
        int i = 1;
        Console.WriteLine();
        foreach (Goal goal in goalsList)
        {

            Console.Write($"{i}. ");
            goal.DisplayFormat();

            i++;
        }
        Thread.Sleep(1000);
    }

    public void RecordEvent()
    {
        bool alreadyComplete = true;

        while (alreadyComplete)
        {
            Console.WriteLine("Goals:");
            DisplayGoals();
            Console.Write("\nWhich goal did you accomplish? (Type 'back' to go back to the main menu.) ");
            string accomplished = Console.ReadLine();

            if (accomplished == "back")
            {
                break;
            }

            else if (int.Parse(accomplished)-1 > goalsList.Count())
            {
                Console.WriteLine("\nThat is not an option\n");
                Thread.Sleep(850);
                Console.Clear();
                alreadyComplete = true;
            }

            else if (goalsList[int.Parse(accomplished)-1].GetComplete() == false)
            {
                goalsList[int.Parse(accomplished)-1].RecordEvent();
                _totalScore += goalsList[int.Parse(accomplished)-1].GetEarnedPoints();
                
                if (goalsList[int.Parse(accomplished)-1].GetGoalType() == "Checklist" || goalsList[int.Parse(accomplished)-1].GetGoalType() == "Checklist")
                
                {goalsList[int.Parse(accomplished)-1].SetComplete();}

                Console.WriteLine($"\nYou now have {_totalScore} points");

                Thread.Sleep(800);
                Console.Clear();
                alreadyComplete = false;
            }

            else
            {

                Console.WriteLine("\nThat goal is already complete.\n");
                alreadyComplete = true;
                Thread.Sleep(850);
                Console.Clear();
            }
        }
    }

    public void SaveToFile()
    {
        Console.Write("What is the file name that you would like to save to? (Type 'back' to return to the main menu.) ");
        string fileName = Console.ReadLine();

        if (fileName.ToLower() != "back" && !File.Exists(fileName))
        {

            using (StreamWriter outputFile = new StreamWriter(fileName))
            {
                outputFile.WriteLine($"{_totalScore}|");

                foreach(Goal goal in goalsList)
                {
                    outputFile.WriteLine(goal.SaveFormat());
                }
            }

            Console.WriteLine("\nFile Saved!\n");
            Thread.Sleep(1000);
            Console.Clear();
        }

        else if (fileName.ToLower() != "back" && File.Exists(fileName))
        {   
            string answer = "";

            while (answer != "yes" && answer != "no")
            {
                Console.Write("\nThat file already exists. Would you like to overwrite? ");
                answer = Console.ReadLine().ToLower();
            }

            if (answer == "yes")
            {
                using (StreamWriter outputFile = new StreamWriter(fileName))
                {
                    outputFile.WriteLine($"{_totalScore}|");

                    foreach(Goal goal in goalsList)
                    {
                        outputFile.WriteLine(goal.SaveFormat());
                    }
                }

                Console.WriteLine("\nFile Saved!\n");    
                
            }

            Thread.Sleep(1000);
            Console.Clear();
        }
    }

    public void LoadFromFile()
    {
        bool exists = false;
        while(exists == false)
        { 
            Console.Write("What is the file name that you would like to load from? (Type 'back' to go back to the main menu.) ");
            string fileName = Console.ReadLine();

            int i = 0;
            if (fileName.ToLower() == "back")
            {
                break;
            }
            else if (File.Exists(fileName) && !alreadyLoaded.Contains(fileName))
            {
                exists = true;
                string[] LoadedFile = System.IO.File.ReadAllLines(fileName);

                foreach (string line in LoadedFile)
                {   
                    string[] parts = line.Split("|");

                    if (i < 1)
                    {
                        int score = int.Parse(parts[0]);

                        _totalScore += score;
                        i++;
                    }

                    else
                    {
                        string _goalType = parts[0];
                        switch(_goalType)
                        {
                            case "SimpleGoal":

                            SimpleGoal simpleGoal = new SimpleGoal("SimpleGoal", parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]));
                            if (bool.Parse(parts[4]) == true)
                            {
                                simpleGoal.SetComplete();
                            }
                            AddToGoals(simpleGoal);
                            break;

                            case "EternalGoal":

                            EternalGoal eternalGoal = new EternalGoal("EternalGoal", parts[1], parts[2], int.Parse(parts[3]));
                            AddToGoals(eternalGoal);
                            break;

                            case "ChecklistGoal":
                            ChecklistGoal checklistGoal = new ChecklistGoal("ChecklistGoal", parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6]), bool.Parse(parts[7]));
                            if (bool.Parse(parts[7]) == true)
                            {
                                checklistGoal.SetComplete();
                            }
                            AddToGoals(checklistGoal);
                            break;
                        }  
                    }
                }

                Console.WriteLine("\nLoading...");
                Thread.Sleep(1000);
                Console.WriteLine("\nFile Loaded!");
                Thread.Sleep(2000);
                Console.Clear(); 

                alreadyLoaded.Add(fileName);   
            }
            
            else if (alreadyLoaded.Contains(fileName))
            {
                Console.WriteLine("\nThat file has already been loaded.\n");
                Thread.Sleep(850);
                Console.Clear();
                exists = false;
            }
            else
            {
                Console.WriteLine("\nThat file doesn't exist.\n");
                Thread.Sleep(850);
                Console.Clear();
                exists = false;
            }
        }
    }
}
