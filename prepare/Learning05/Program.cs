using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> myShapes = new List<Shape>();
        
        Square mySquare = new Square("Red", 14);
        Rectangle myRectangle = new Rectangle("Blue", 10, 5);
        Circle myCircle = new Circle("Yellow", 10);

        myShapes.Add(mySquare);
        myShapes.Add(myRectangle);
        myShapes.Add(myCircle);

        foreach(Shape shape in myShapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }

    }
}