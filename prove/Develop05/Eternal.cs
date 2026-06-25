class Eternal : BaseGoal
{
    private int _numCompletions;

    public Eternal(): base()
    {
        _numCompletions = 0;
    }

    public Eternal(string name, string descritpion, int points, bool status, string goaltype): base(name, descritpion, points, status, goaltype)
    {
        _numCompletions = 0;
    }

    public override string GetDisplayString()
    {
        return base.GetDisplayString()+ $", number of compeletions {_numCompletions}";
    }
    public override string CreateFileSytemString()
    {
        return base.CreateFileSytemString() + $"%{_numCompletions}";
    }
    public override void CreateGoal()
    {
        SetGoalType("Eternal");
        SetName();
        SetDescription();
        SetNumberOfPoints();
    }
    public override void RecordEvent()
    {
        _numCompletions ++;
        MarkComplete();
    }
}