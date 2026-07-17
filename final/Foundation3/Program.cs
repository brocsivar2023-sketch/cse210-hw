using System;

class Program
{
    static void Main(string[] args)
    {
        // Address address1 = new Address("14 Road 2894", "Aztec", "New Mexico", "USA");

        // Console.WriteLine(address1.AddressString());

        // Events event1 = new Events("Popcorn Party", "A party where everyone makes a different type of popcorn", "5/14/2027", "6:00");
        // event1.SetAddress("14 Road 2894", "Aztec", "New Mexico", "USA");
        // Console.WriteLine(event1.StandardDetails());
        // Console.WriteLine(event1.ShortDetails());

        Lectures lecture1 = new Lectures("Physics", "We will discuss the basics behind physics", "5/17/2027", "6:00", "Prof. Newton", 25);
        lecture1.SetAddress("28 Road 2794", "Dongrol", "New Jersey", "USA");
        Console.WriteLine(lecture1.ShortDetails());
        Console.WriteLine(lecture1.StandardDetails());
        Console.WriteLine(lecture1.FullDetails());

        Receptions receptions1 = new Receptions("Wedding", "Kyle's and Sandra's Wedding ", "8/23/2026", "8:00", 100);
        receptions1.SetAddress("30 Street Apache", "Cheapskate", "Illinois", "USA");
        Console.WriteLine(receptions1.ShortDetails());
        Console.WriteLine(receptions1.StandardDetails());
        Console.WriteLine(receptions1.FullDetails());

    }
}