using System.Numerics;
using ForthTask;

namespace SixthTask;

public class BoundsCenterFinder<T>: Figure where T: Figure
{
    private T _figure;
    public BoundsCenterFinder(T figure)
    {
        _figure = figure;
    }

    public Vector2 GetBoundsCenter()
    {
        throw new NotImplementedException();


    }
}