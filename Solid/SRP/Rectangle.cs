namespace SRP;

public class Rectangle: Shape
{
    private float _sideA;
    private float _sideB;
    private const double _pi = Math.PI;

    public Rectangle(float sideA, float sideB)
    {
        _sideA = sideA;
        _sideB = sideB;
    }
    public override double GetArea()
    {
        return Math.Round(_sideA * _sideB);
    }
}