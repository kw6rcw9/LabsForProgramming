namespace Dushina_CatFramework;

public class CuteCat: Cat
{
    public override int Fluffiness { get; }

    public CuteCat(int fluffiness = 50)
    {
        if (fluffiness is < 0 or > 140)
        {
            throw new CatException($"Unable to create a cute cat with fluffiness: {fluffiness}");
        }
        Fluffiness = fluffiness;
    }

    public override string FluffinessCheck()
    {
        switch (Fluffiness)
        {
            case 0:
                return "Sphynx";
            case >= 1 and <= 20:
                return "Slightly";
            case <= 50:
                return "Medium";
            case <= 75:
                return "Heavy";
            case > 75:
                return "OwO";
        }
    }

    public override string ToString()
    {
        return $"A cute cat with fluffiness: {Fluffiness}";
    }
}