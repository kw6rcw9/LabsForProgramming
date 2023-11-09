namespace AbstractSystem;

public class Manager: Employee
{
    private const float _coefficient = 1.5f;
    public Manager(float amount) : base(amount)
    {
        
    }
    public override void CalculateSalary()
    {
        Console.WriteLine($"Managers`s salary is: {_primaryAmount * _coefficient * _tax}");
    }
}
