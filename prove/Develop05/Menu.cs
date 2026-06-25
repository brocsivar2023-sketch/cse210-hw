class Menu
{
    public int DisplayMenu()
    {
        Console.WriteLine("Menu Options: ");
        Console.WriteLine("  1. Create a new Goal ");
        Console.WriteLine("  2. List Goals ");
        Console.WriteLine("  3. Save Goals ");
        Console.WriteLine("  4. Load Goals ");
        Console.WriteLine("  5. Record Event ");
        Console.WriteLine("  6. Quit ");
        Console.WriteLine("Select a choice from menu: ");
        return int.Parse(Console.ReadLine());
    }

    public int DisplayGoalMenu()
    {
        Console.WriteLine("The types of goals are: ");
        Console.WriteLine("  1. Simple Goals ");
        Console.WriteLine("  2. Eternal Goals ");
        Console.WriteLine("  3. Checklist Goals ");
        Console.WriteLine("Which type of goal would you like to create? ");
        return int.Parse(Console.ReadLine());
    }
}