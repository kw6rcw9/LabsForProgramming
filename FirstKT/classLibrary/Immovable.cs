namespace classLibrary;

public class Immovable: Property
{
    private float _square;
    private int _num = 0;
    public Immovable(float square, float worth): base(worth)
    {
        _square = square;
    }

    public double WorthForMetre()
    {
        return _worth / _square;
    }

    public override float TaxCalculation()
    {
        switch (_square)
        {
            case < 100:
                _num = 500;
                break;
            case >= 100 and < 300:
                _num = 350;
                break;
            default:
                _num = 250;
                break;
        }
        return _worth / _num;
    }

    public override string ToString()
    {
        return $"Стоимость - {_worth}, налог - {TaxCalculation()}, площадь - {_square} кв.м ";
    }
}