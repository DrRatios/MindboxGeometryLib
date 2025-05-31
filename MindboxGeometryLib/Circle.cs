namespace MindboxGeometryLib;

public class Circle : IShape
{
    public String Name=>"Circle";

    public int SidesCount => 3;
    private double _radius;

    public Circle(double radius)
    {
        this._radius = radius;
    }
    
    public double Radius
    {
        get => _radius;
        set => _radius = value>0? value : throw new ArgumentException("Radius must be greater than zero");
    }

    public double CalculateArea()
    {
        return 2 * Math.PI * _radius;
    }

    public double CalculatePerimeter()
    {
        return Math.PI * _radius * _radius;
    }
}