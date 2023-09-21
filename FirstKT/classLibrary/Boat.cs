namespace classLibrary;

public class Boat: Vehicle
{
    public Boat(float engineCapacity, float worth) : base(engineCapacity, worth){}
   
    public override string ToString()
    {
        return "Лодка: " + base.ToString();
    }
}