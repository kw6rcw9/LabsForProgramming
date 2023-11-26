namespace SRP;

public class Circle: Shape
{
    private float _radius;
    private const double _pi = Math.PI;

    public Circle(float radius)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        return Math.Round(_pi * Math.Pow(_radius, 2), 2);
    }

    public double GetCircleLength()
    {
        return Math.Round((_pi * _radius * 2), 2);
    }
}