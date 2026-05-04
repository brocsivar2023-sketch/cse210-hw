class Program
{
    public static void Main(string[] args)
    {
        // Console.WriteLine("Hello world");

        Circle myCircle = new Circle();
        myCircle.SetRadius(10);
        Console.WriteLine(myCircle.GetArea());

        Circle myCircle2 = new Circle();
        myCircle2._radius = 30;
        Console.WriteLine(myCircle2.GetCircumference());

        Cylinder myCylinder = new Cylinder();
        myCylinder._circle = new Circle();
        myCylinder._circle._radius = 10;
        myCylinder._height = 30;
        Console.WriteLine(myCylinder.GetCylinderVolume());

    }
}