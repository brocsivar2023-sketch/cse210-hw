public class Menu
{
    string _title = "Welcome, to the Journal Program! ";
    string _description = 
     "Please choose one of the follwoing options \n 1. Write \n 2. Display \n 3. Load \n 4. Save \n 5. Quit";

    public void DisplayTitle()
    {
        Console.WriteLine(_title);
    }
    public int ProcessMenu()
    {
        Console.WriteLine(_description);
        int _menuItem = int.Parse(Console.ReadLine());
        return _menuItem;
    }
}