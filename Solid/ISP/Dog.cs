namespace ISP;

public class Dog: IPet
{
    public string Name { get; }

    public string Breed { get; }

    public Dog(string name, string breed)
    {
        Name = name;
        Breed = breed;
    }
    public void GetSound()
    {
        Console.WriteLine("Woof");
    }
}