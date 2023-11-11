using System.Globalization;

namespace ThirdTask;

public class Electronic: Product
{
    private float _power;

    public Electronic(float power, float pricePerOne, string text, int amount) : base(text, pricePerOne, amount)
    {
        _power = power;
    }
    
    public override void GetDescription()
    {
        Console.WriteLine("Name: Electronic\n" +
                          $"Description: {_text}\n" +
                          $"Power: {_power}W\n" +
                          $"Price: {_pricePerOne.ToString("C", new CultureInfo("en-US"))}\n" +
                          $"Amount: {_amount}");
    }
}
