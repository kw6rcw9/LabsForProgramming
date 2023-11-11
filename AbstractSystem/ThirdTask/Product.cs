namespace ThirdTask;

public abstract class Product
{
    protected int _amount;
    protected string _text;
    protected float _pricePerOne;
    public Product(string text, float pricePerOne,int amount)
    {
        _amount = amount;
        _text = text;
        _pricePerOne = pricePerOne;
    }
    public abstract void GetDescription();
}