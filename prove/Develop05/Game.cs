using System.ComponentModel;

class Game
{
    private int _tpoints;
    private List<string> _animals;
    private string _animal;

    public Game()
    {
        _animals = new List<string>();
        _tpoints = 0;
    }
    public void PlayGame(Goals goals)
    {
        _animals.AddRange(["Fly", "Rat", "Lizard", "Snake", "Chicken", "Cat", "Dog", "Goat", "Cow", "Donkey", "Horse", "Wolf", "Mountain Lion", "Black Bear", "Moose", "Grizzly Bear", "Polar Bear", "Dragon"]);

        _tpoints = goals.GetPoints();
        double point = _tpoints / 1000;
        int newPoint = (int)point;
        if (newPoint > 17)
        {
            newPoint = 17;
        }
        _animal = _animals[newPoint];
        Console.WriteLine($"Based on the amount of points you have you are a {_animal}");
        Console.WriteLine("The more points you get the cooler the animal you become! ");
        Console.WriteLine("Press Enter to continue");
        Console.ReadLine();
    }
}
