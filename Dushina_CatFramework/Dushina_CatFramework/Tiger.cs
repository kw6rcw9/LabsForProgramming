namespace Dushina_CatFramework;

public class Tiger:Cat
{
    public override int Fluffiness { get; }
    public double Weight { get; }

    public Tiger(double weight = 50, int fluffiness = 50)
    {
        if ((weight is < 75 or > 140) && (fluffiness is < 0 or > 100))
        {
            throw new CatException($"Unable to create a tiger with weight: {weight} and fluffiness: {fluffiness}");
            
        }
        if (weight is < 75 or > 140)
        {
            throw new CatException($"Unable to create a tiger with weight: {weight}");
        }
        if (fluffiness is < 0 or > 100)
        {
            throw new CatException($"Unable to create a tiger with fluffiness: {fluffiness}");
        }
        
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