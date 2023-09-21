namespace classLibrary;

public abstract class Property
{
    protected float _worth;

    protected Property(float worth) => _worth = worth;

    public abstract float TaxCalculation();

}