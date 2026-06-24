using System.ComponentModel;
using System.Dynamic;

class BaseGoal
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

    public void SetName()
    {
        Console.WriteLine("What is the name of your goal? ");
        _name = Console.ReadLine();
    }

    public void SetDescription()
    {
        Console.WriteLine($"Enter the descirption for {_name} goal: ");
        _description = Console.ReadLine();
    }

    public void SetNumberOfPoints()
    {
        Console.WriteLine($"Enter the number of points this is worth: ");
        _numberOfPoints = int.Parse(Console.ReadLine());
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
    
    public int MarkComplete()
    {
        _status = true;
        return _numberOfPoints;
    }
}