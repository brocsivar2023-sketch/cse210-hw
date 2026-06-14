class Menu
{
    public void RunMenu()
    {
        int var = 0;
        int breathing = 0;
        int reflection = 0;
        int lisiting = 0;
        while(var != 4)
        {
            Console.WriteLine("Menu Options: ");
            Console.WriteLine(" 1. Start Breathing Activity ");
            Console.WriteLine(" 2. Start Reflection Activity ");
            Console.WriteLine(" 3. Start Listing Activity ");
            Console.WriteLine(" 4. Quit ");
            Console.Write("Please Select a choice from the menu: ");
            var = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            if (var == 1)
            {
                Breathing myBreathing = new Breathing("This activity will help you with your breathing by walking you through how to breathe in and out slowly. Clear your mind and focus on your breathing. ");
                myBreathing.RunActivity();
                Console.Clear();
                breathing ++;
            }
            else if (var == 2)
            {
                Reflection myReflection = new Reflection("This activity will help you reflect on times in your life when youi have shown stregnth and resilience. This will help you recognize these things in other aspects of your life. ");
                myReflection.RunActivity();
                Console.Clear();
                reflection ++;
            }
            else if (var == 3)
            {
                Listing myListing = new Listing("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                myListing.RunActivity();
                Console.Clear();
                lisiting ++;
            }
            else if (var == 4)
            {
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("You did something wrong try again. Press Enter to Continue ");
                Console.ReadLine();
            }

        }
        Console.WriteLine($"You completed the Breathing Activity {breathing} times, the Reflection Activity {reflection} times, and the Listing Activity {lisiting} times ");
        Console.WriteLine("Please press enter to end program. ");
        Console.ReadLine();
        Console.WriteLine("Thanks for Participating in theses Activities!! ");
    }
}