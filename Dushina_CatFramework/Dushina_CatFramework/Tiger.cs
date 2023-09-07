namespace Dushina_CatFramework;

public class Tiger:Cat
{
    public override int Fluffiness { get; }
    public double Weight { get; }

    public Tiger(double weight, int fluffiness = 50)
    {
        Fluffiness = fluffiness;
        Weight = weight;

    }

    public override string FluffinessCheck()
    {
        return "Kucb!";
    }

    public override string ToString()
    {
        return $"A tiger with weight: {Weight} fluffiness: {Fluffiness}";

    }
}