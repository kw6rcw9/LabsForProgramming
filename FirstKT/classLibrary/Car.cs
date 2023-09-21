namespace classLibrary;

public class Car: Vehicle
{
    public Car(float engineCapacity, float worth) : base(engineCapacity, worth){}
    
    public override string ToString()
    {
        return "Автомобиль: " + base.ToString();
    }
}