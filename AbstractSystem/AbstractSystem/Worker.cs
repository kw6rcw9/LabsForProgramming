namespace AbstractSystem;

public class Worker: Employee
{
    private const float _coefficient = 0.5f;
    public Worker(float amount) : base(amount)
    {
    }
    public override void CalculateSalary()
    {
        Console.WriteLine($"Worker`s salary is: {_primaryAmount * _coefficient * _tax / 2}");
    }
}