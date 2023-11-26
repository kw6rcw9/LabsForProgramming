namespace ISP;

public class Bird: IAnimal
{
    public string Name { get; }

    

    public Bird(string name)
    {
        Name = name;
        

    }
    public void GetSound()
    {
        Console.WriteLine("Carr");
    }
}
