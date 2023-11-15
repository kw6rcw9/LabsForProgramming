namespace InterfaceImplement;

public class Car: IVehiculo
{
    private int _fuelAmount;
    public Car(int initialFuelAmount)
    {
        _fuelAmount = initialFuelAmount;
    }

    public void Drive()
    {
        if(_fuelAmount > 0)
            Console.WriteLine("Car is moving");
    }

    public bool Refuel(int newAmount)
    {
        _fuelAmount += newAmount;
        return true;

    }
}