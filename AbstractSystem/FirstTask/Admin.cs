namespace AbstractSystem;

public class Admin: Employee
{
    private const float _coefficient = 2;
    public Admin(float amount) : base(amount)
    {
    }
    public override void CalculateSalary()
    {
        Console.WriteLine($"Admin`s salary is: {_primaryAmount * _coefficient * _tax}");
    }
}