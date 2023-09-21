namespace classLibrary;

public class Appartment: Immovable
{
    public Appartment(float square, float worth) : base(square, worth){}
    
    public override string ToString()
    {
        return "Квартира: " + base.ToString();
    }
}