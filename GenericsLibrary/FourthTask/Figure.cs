using System.Numerics;

namespace ForthTask;

public class Figure
{
    protected Vector2 _center;

    public Figure(Vector2 center)
    {
        _center = center;
    }
    public Figure(){}
}