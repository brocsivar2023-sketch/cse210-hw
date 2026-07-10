using System;

class Program
{
    static void Main(string[] args)
    {
        Order order1 = new Order();
        order1.AddProduct("Apples", "CC-VV", 3.39, 6);
        order1.AddProduct("Oranges", "CC-DD", 3.20, 3);
        order1.AddProduct("Kiwis", "GG-HH", 4.79, 10);
        order1.AddCustomer("Eden", "14th street", "Carson", "Florida", "USA");
        order1.ShippingLabel();
        order1.PackingLabel();
        order1.CalcCost();

        Console.WriteLine("");

        Order order2 = new Order();
        order2.AddCustomer("Bob", "16th Street", "Tancun", "Versailles", "Mexico");
        order2.AddProduct("Shelves", "RR-HH", 400, 2);
        order2.AddProduct("Couches", "UU-JJ", 9, 5);
        order2.AddProduct("Backpacks", "KK-OO", 70, 3);
        order2.ShippingLabel();
        order2.PackingLabel();
        order2.CalcCost();
    }
}