namespace ISP;

public class Cat: IPet
{
    public string Name { get; }

    public string Breed { get; }

    public Cat(string name, string breed)
    {
        Name = name;
        Breed = name;
    }
    public void GetSound()
    {
        Console.WriteLine("Meow");
    }
}