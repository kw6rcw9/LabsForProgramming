namespace LSP;

public class Rectangle: IFigure
{
    private float _sideA;
    private float _sideB;
    public Rectangle(float sideA, float sideB)
    {
        _sideA = sideA;
        _sideB = sideB;
    }
    public double GetArea()
    {
        return _sideA * _sideB;
    }
}