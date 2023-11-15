using System.Globalization;

namespace SecondTask;

public class FoodProduct: IProduct
{
    private string _name;
    private float _price;
    private string _description;
    private const float _deliveryIndex = 0.3f;
    private const float _tax = 0.13f;
    public FoodProduct(string name, float price, string desc)
    {
        _name = name;
        _price = price;
        _description = desc;
    }

    public void GetInfo()
    {
        Console.WriteLine($"Type: Food\n" +
                          $"Name: {_name}\n" +
                          $"Price: {_price.ToString("C", new CultureInfo("en-US"))}\n" +
                          $"Description: {_description}\n" +
                          $"Delivery Price: {DeliveryCalculation().ToString("C", new CultureInfo("en-US"))}");
    }

    public float DeliveryCalculation()
    {
        return _price * _deliveryIndex * _tax;
    }
}