using System.Numerics;
using ForthTask;

namespace FifthTask;

public class Rectangle<T,TR>: Figure
{
    private T _width;
    private TR _height;
    
    public Rectangle( T width, TR height, Vector2 center):base(center)
    {
        _center = center;
        _width = width;
        _height = height;
    }
    public override Vector2 MinPoint => new(_center.X - Convert.ToSingle(_width) / 2, _center.Y - Convert.ToSingle(_height) / 2);
    public override Vector2 MaxPoint => new(_center.X + Convert.ToSingle(_width) / 2, _center.Y + Convert.ToSingle(_height) / 2);

}