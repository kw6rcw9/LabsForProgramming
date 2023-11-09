namespace AbstractSystem;

public abstract class Employee
{
    protected const float _tax = 0.13f;
    protected float _primaryAmount;
    public Employee(float primaryAmount)
    {
        _primaryAmount = primaryAmount;
    }
    public abstract void CalculateSalary();
}