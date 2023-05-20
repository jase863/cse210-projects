using System;

/* IN ORDER TO EXCEED REQUIREMENTS, I ADDED QUITE A FEW THINGS. FIRST, I ALLOWED FOR THE OPTION OF GOING BACK TO THE MAIN MENU ON BOTH THE SAVE AND LOAD SCREENS.
I ADDED AN ANIMATION WHEN SOMEONE COMPLETES A CHECKLIST GOAL A REQUIRED NUMBER OF TIMES. I ADDED A CHECK TO SEE IF A FILE HAS ALREADY BEEN LOADED, WHICH HELPS TO AVOID
DUPLICATING GOALS FROM LOADING. I ALSO ADDED A CHECK TO SEE IF A FILE EXISTS BEFORE SAVING, GIVING THE PERSON THE OPTION OF OVERWRITING THE FILE. IF THEY CHOOSE NOT TO
THEY MAY SAY NO, WHICH TAKES THEM BACK TO THE MAIN MENU.*/

class Program
{
    static void Main(string[] args)
    {   
        UserInterface interfaceType = new UserInterface();
        AllGoals allGoals = new AllGoals();
        Goal goal = new Goal();
        Console.WriteLine("Welcome to Goal Setter!");
        

        string choice = "";

        while (choice.ToLower() != "quit" && choice != "6")
        {   
            allGoals.DisplayScore();

            choice = interfaceType.MainInterface();

            // Creating a new goal
            if (choice == "1")
            {
                string typeOfGoalCreated = interfaceType.OptionOne();

                // simple goal
                if (typeOfGoalCreated == "1")
                {
                    SimpleGoal simpleGoal = new SimpleGoal();
                    allGoals.AddToGoals(simpleGoal.CreateNewGoal("SimpleGoal"));

                }

                // eternal Goal
                else if (typeOfGoalCreated == "2")
                {
                    EternalGoal eternalGoal = new EternalGoal();
                    allGoals.AddToGoals(eternalGoal.CreateNewGoal("EternalGoal"));
                } 
                

                else if (typeOfGoalCreated == "3")
                {
                    ChecklistGoal checklistGoal = new ChecklistGoal();
                    allGoals.AddToGoals(checklistGoal.CreateNewGoal("ChecklistGoal"));
                } 
                
                allGoals.DisplayGoals();
                // foreach (Goal goalType in allGoals.GetGoalList())
                // {
                //     goalType.DisplayFormat();
                // }
            }
            

            else if (choice == "2")
            {   
                allGoals.DisplayGoals();
            }

            else if (choice == "3")
            {
                allGoals.SaveToFile();
            }

            else if (choice == "4")
            {
                allGoals.LoadFromFile();
            }




            else if (choice == "5")
            {
                allGoals.RecordEvent();
                // allGoals.SetTotalScore(allGoals.GetTotalScore(), goal.RecordEvent());
                // allGoals.DisplayScore();
            }
    
        }
    }
}
