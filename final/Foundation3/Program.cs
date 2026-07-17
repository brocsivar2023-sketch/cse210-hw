using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("14 Road 2894", "Aztec", "New Mexico", "USA");

        Console.WriteLine(address1.AddressString());
    }
}