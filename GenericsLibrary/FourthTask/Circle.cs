namespace ForthTask;

public class Circle<T>: Figure
{
    public T? Radius { get; private set; }

    public double Square => Math.PI * Math.Pow((Convert.ToDouble(Radius)), 2);


    public Circle(T radius)
    {
        Radius = radius;
    }

    public void SetRadius<Type>(Type newRad)
    {
        Radius = (T)Convert.ChangeType(newRad, typeof(T));

    }
}