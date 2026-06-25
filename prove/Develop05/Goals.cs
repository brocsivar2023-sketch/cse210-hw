using System.Drawing;
using System.Globalization;

class Goals
{
    private List<BaseGoal> _goals;

    public Goals()
    {
        _goals = new List<BaseGoal>();
    }

    public void AddGoal(BaseGoal goal)
    {
        _goals.Add(goal);
    }

    public void LoadGoals(string fileName)
    {
        try
        {
            string[] lines = System.IO.File.ReadAllLines(fileName);

            foreach (string line in lines)
            {
                string[] parts = line.Split("%");
                string name = parts[0];
                string description = parts[1];
                int numberOfPoints = int.Parse(parts[2]);
                string statusString = parts[3];
                string goalType = parts[4];
                bool status = false;
                if (statusString == "true")
                {
                    status = true;
                }
                if (goalType == "Simple")
                {
                    SimpleGoal simple = new SimpleGoal(name, description, numberOfPoints, status, goalType);
                    AddGoal(simple);
                }
                else if (goalType == "Eternal")
                {
                    int numCompletions = int.Parse(parts[5]);
                    Eternal eternal = new Eternal(name, description, numberOfPoints, status, goalType, numCompletions);
                    AddGoal(eternal);
                }
                else if (goalType == "Checklist")
                {
                    int numCompletions = int.Parse(parts[5]);
                    int maxTimes = int.Parse(parts[6]);
                    int bonuspoints = int.Parse(parts[7]);
                    Checklist eternal = new Checklist(name, description, numberOfPoints, status, goalType, numCompletions, maxTimes, bonuspoints);
                    AddGoal(eternal);
                }
                else
                {
                    Console.WriteLine("There was an error in the file ");
                }

            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Error file not found");
        }
    }

    public void SaveGoals(string fileName)
    {
        try
        {
            using (StreamWriter outputFile = new StreamWriter(fileName))
            {
                foreach(BaseGoal goal in _goals)
                {
                    outputFile.WriteLine(goal.CreateFileSytemString());
                }
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Error something didn't work");
        }
    }
    public void DisplayGoals()
    {
        int num = 0;
        foreach (BaseGoal goal in _goals)
        {
            num ++;
            Console.WriteLine($"{num}. {goal.GetDisplayString()}");
        }
    }
    public int RecordEvent()
    {
        DisplayGoals();
        Console.WriteLine("Enter the index of the goal that you want to change: ");
        int index = int.Parse(Console.ReadLine());
        BaseGoal goal = _goals[index-1];
        return goal.RecordEvent();
    }
}