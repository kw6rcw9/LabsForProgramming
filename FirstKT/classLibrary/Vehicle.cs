namespace classLibrary;

public class Vehicle: Property
{
    private float _engineCapacity;
    private const int Num = 3000;

    protected Vehicle(float engineCapacity, float worth): base(worth)
    {
        _engineCapacity = engineCapacity;
    }

    public override float TaxCalculation()
    {
        return _worth * _engineCapacity / Num;
    }
    
    public override string ToString()
    {
        return $"Стоимость - {_worth}, налог - {TaxCalculation()},  объём двигателя - {_engineCapacity} см.куб ";
    }
}