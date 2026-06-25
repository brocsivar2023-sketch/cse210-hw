using System.Runtime.InteropServices;

class SimpleGoal : BaseGoal
{
    public SimpleGoal(): base()
    {
        
    }
    public SimpleGoal(string name, string descritpion, int points, bool status, string goaltype): base(name, descritpion, points, status, goaltype)
    {
        
    }

    public override void CreateGoal()
    {
        SetGoalType("Simple");
        SetName();
        SetDescription();
        SetNumberOfPoints();
    }
    public override int RecordEvent()
    {
        MarkComplete();
        return GetPoints();
    }
}