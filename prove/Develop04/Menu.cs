class Menu
{
    public void RunMenu()
    {
        int var = 0;
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
            }
            else if (var == 2)
            {
                Reflection myReflection = new Reflection("This activity will help you reflect on times in your life when youi have shown stregnth and resilience. This will help you recognize these things in other aspects of your life. ");
                myReflection.RunActivity();
            }
            else if (var == 3)
            {
                Listing myListing = new Listing("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                myListing.RunActivity();
            }
            else if (var == 4)
            {
                break;
            }
            else
            {
                Console.WriteLine("You did something wrong try again ");
            }

        }
    }
}