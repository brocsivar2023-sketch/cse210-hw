class ListingActivity : BaseActivity
{
    public ListingActivity(string description) : base("Listing", description)
    {
        
    }
    public void RunListingActivity()
    {
        StartActivity();
        Console.WriteLine("List as many responses you can to the following prompt: \n ---When have you felt the Holy Ghost in the last Month?---");
        RunCountdown("You may begin", 5);

    }
}