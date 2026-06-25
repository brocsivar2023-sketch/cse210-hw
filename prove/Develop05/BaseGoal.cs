using System.ComponentModel;
using System.Dynamic;

abstract class BaseGoal
{
    private string _name;
    private string _description;
    private int _numberOfPoints;
    private bool _status;
    private string _goalType;
    public BaseGoal()
    {
        _name = "";
        _description = "";
        _numberOfPoints = 0;
        _status = false;
        _goalType = "";
    }
    public BaseGoal(string name, string descritpion, int points, bool status, string goaltype)
    {
        _name = name;
        _description = descritpion;
        _numberOfPoints = points;
        _status = status;
        _goalType = goaltype;
    }
    public void SetGoalType(string name)
    {
        _goalType = name;
    }

    public string GetGoalType()
    {
        return _goalType;
    }

    protected void SetName()
    {
        Console.WriteLine("What is the name of your goal? ");
        _name = Console.ReadLine();
    }

    protected void SetDescription()
    {
        Console.WriteLine($"Enter the descirption for {_name} goal: ");
        _description = Console.ReadLine();
    }

    protected void SetNumberOfPoints()
    {
        Console.WriteLine($"Enter the number of points this is worth: ");
        _numberOfPoints = int.Parse(Console.ReadLine());
    }

    public int GetPoints()
    {
        return _numberOfPoints;
    }
    public virtual string GetDisplayString()
    {
        char statusMarker = ' ';
        if (_status)
        {
            statusMarker = 'X';
        } 
        return $"[{statusMarker}] Name: {_name}, Description: {_description}, points earned: {_numberOfPoints}";
    }

    /*
    MarkComplete will set the stateus to true, which means that it 
    retruns the number of points for comleteing the goal. 
    */

    protected int MarkComplete()
    {
        _status = true;
        return _numberOfPoints;
    }
    public virtual string CreateFileSytemString()
    {
        return $"{_name}%{_description}%{_numberOfPoints}%{_status}%{_goalType}";
    }

    public abstract void CreateGoal();

    public abstract int RecordEvent();
}