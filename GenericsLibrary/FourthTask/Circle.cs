using System.Numerics;

namespace ForthTask;

public class Circle<T>: Figure
{
    public T? Radius { get; private set; }

    public double Square => Math.PI * Math.Pow((Convert.ToDouble(Radius)), 2);
    public override Vector2 MinPoint => new(_center.X - Convert.ToSingle(Radius), _center.Y - Convert.ToSingle(Radius));

    public override Vector2 MaxPoint => new(_center.X + Convert.ToSingle(Radius), _center.Y + Convert.ToSingle(Radius));


    public Circle(T radius)
    {
        Radius = radius;
    }

    public Circle(T radius, Vector2 center):base(center)
    {
        Radius = radius;
        _center = center;
    }

    public void SetRadius<Type>(Type newRad)
    {
        Radius = (T)Convert.ChangeType(newRad, typeof(T));

    }
}