public class Rectangle : Shape
{
    
    private double _length;
    private double _width;
    public Rectangle(string color, double length, double witdth): base()
    {
        SetColor(color);
        _length = length;
        _width = witdth;
    }
    public override double GetArea()
    {
        return _length * _width;
    }
}