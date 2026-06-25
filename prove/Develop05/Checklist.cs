class Checklist : BaseGoal
{
    private int _numCompletions;
    private int _maxGoals;
    private int _bonuspoints;

    public Checklist(): base()
    {
        _numCompletions = 0;
        _maxGoals = 0;
        _bonuspoints = 0;
    }

    public Checklist(string name, string descritpion, int points, bool status, string goaltype, int completions, int maxGoals, int bonus): base(name, descritpion, points, status, goaltype)
    {
        _numCompletions = completions;
        _maxGoals = maxGoals;
        _bonuspoints = bonus;
    }

    public override string GetDisplayString()
    {
        return base.GetDisplayString()+ $", number of compeletions {_numCompletions}/{_maxGoals}";
    }
    public override string CreateFileSytemString()
    {
        return base.CreateFileSytemString() + $"%{_numCompletions}%{_maxGoals}%{_bonuspoints}";
    }
    public override void CreateGoal()
    {
        SetGoalType("Checklist");
        SetName();
        SetDescription();
        SetNumberOfPoints();
        ObtainMaxGoal();
        ObtainBonusPoints();
    }
    public override int RecordEvent()
    {
        _numCompletions ++;
        if (_numCompletions == _maxGoals)
        {
            MarkComplete();

            return GetPoints() + _bonuspoints;
        }
        else
        {
            return GetPoints();
        }
    }

    private void ObtainMaxGoal()
    {
        Console.WriteLine("In order to recieve bonus points, how many times do you need to complete the goal? ");
        string goals = Console.ReadLine();
        if (int.TryParse(goals, out int result))
        {
            _maxGoals = int.Parse(Console.ReadLine());
        }
        else
        {
            Console.WriteLine("You didn't enter in a number try agian. Press Enter to continue ");
            Console.ReadLine();
        }
    }
    private void ObtainBonusPoints()
    {
        Console.WriteLine("If you complete it the max amount how many bonus points will you get? ");
        string points = Console.ReadLine();
        if (int.TryParse(points, out int result))
        {
            _bonuspoints = int.Parse(Console.ReadLine());
        }
        else
        {
            Console.WriteLine("You didn't enter in a number try agian. Press Enter to continue ");
            Console.ReadLine();
        }
    }
}