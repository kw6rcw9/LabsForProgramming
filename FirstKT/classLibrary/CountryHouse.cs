namespace classLibrary;

public class CountryHouse: Immovable
{
    public CountryHouse(float square, float worth) : base(square, worth){}

    public override string ToString()
    {
        return "Дача: " + base.ToString();
    }
}