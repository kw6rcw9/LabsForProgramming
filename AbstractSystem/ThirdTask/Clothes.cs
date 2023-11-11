using System.Globalization;
using System.Reflection;

namespace ThirdTask;

public class Clothes: Product
{
    private string _color;

    public Clothes(string color, float pricePerOne, string text, int amount) : base(text, pricePerOne, amount)
    {
        _color = color;
    }
    
    public override void GetDescription()
    {
        Console.WriteLine("Name: Clothes\n" +
                          $"Description: {_text}\n" +
                          $"Color: {_color}\n" +
                          $"Price: {_pricePerOne.ToString("C", new CultureInfo("en-US"))}\n" +
                          $"Amount: {_amount}");
    }
}