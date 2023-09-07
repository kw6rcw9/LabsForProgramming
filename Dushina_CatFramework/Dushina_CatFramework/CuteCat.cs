namespace Dushina_CatFramework;

public class CuteCat: Cat
{
    public override int Fluffiness { get; }

    public CuteCat(int fluffiness = 50)
    {
        Fluffiness = fluffiness;
    }

    public override string FluffinessCheck()
    {
        throw new NotImplementedException();
    }

    public override string ToString()
    {
        return $"A cute cat with fluffiness: {Fluffiness}";
    }
}