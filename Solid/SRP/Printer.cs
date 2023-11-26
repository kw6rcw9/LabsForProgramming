namespace SRP;

public class Printer
{
    public void PrintArea(Shape shape)
    {
        Console.WriteLine($"Square: {shape.GetArea()}");
    }

    public void PrintCircleLength(Circle circle) 
    {
        Console.WriteLine($"Circle length: {circle.GetCircleLength()}");
    }
}