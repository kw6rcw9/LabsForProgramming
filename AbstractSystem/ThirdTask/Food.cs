using System.Globalization;

namespace ThirdTask;

public class Food: Product
{
    private string _type;

    public Food(string type, float pricePerOne, string text, int amount) : base(text, pricePerOne, amount)
    {
        _type = type;
    }
    
    public override void GetDescription()
    {
        Console.WriteLine("Name: Clothes\n" +
                          $"Description: {_text}\n" +
                          $"Type: {_type}\n" +
                          $"Price: {_pricePerOne.ToString("C", new CultureInfo("en-US"))}\n" +
                          $"Amount: {_amount}");
    }
}