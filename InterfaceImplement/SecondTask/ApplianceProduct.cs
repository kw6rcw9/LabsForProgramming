using System.Globalization;

namespace SecondTask;

public class ApplianceProduct: IProduct
{
    private string _name;
    private float _price;
    private string _description;
    private float _power;
    private const float _deliveryIndex = 0.5f;
    private const float _tax = 0.13f;
    public ApplianceProduct(string name, float price, string desc, float power)
    {
        _name = name;
        _price = price;
        _description = desc;
        _power = power;
    }

    public void GetInfo()
    {
        Console.WriteLine($"Type: Food\n" +
                          $"Name: {_name}\n" +
                          $"Price: {_price.ToString("C", new CultureInfo("en-US"))}\n" +
                          $"Power: {_power}W\n" +
                          $"Description: {_description}\n" +
                          $"Delivery Price: {DeliveryCalculation().ToString("C", new CultureInfo("en-US"))}");
    }

    public float DeliveryCalculation()
    {
        return _price * _deliveryIndex * _tax;
    }
}