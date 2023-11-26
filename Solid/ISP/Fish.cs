namespace ISP;

public class Fish: IFish
{
    public string Name { get; }
    

    public string TypeOfWater { get; }

    public Fish(string name, string typeOfWater)
    {
        Name = name;
        TypeOfWater = typeOfWater;
    }
    
    public void GetSound()
    {
        Console.WriteLine("Bubble");
    }
}