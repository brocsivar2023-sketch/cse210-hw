public class Menu
{
    string _title = "Welcome, to the Journal Program! ";
    string _description = 
     "Please choose one of the following options \n 1. Write a new entry \n 2. Display entries \n 3. Load journal file \n 4. Save new journal file \n 5. Deletes a Entry \n 6. Quit program. ";

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