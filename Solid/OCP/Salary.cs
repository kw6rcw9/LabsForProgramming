namespace OCP;

public class Salary: IVisitor
{
    private const float _tax = 0.13f;
    private const decimal _rate = 1000;
    public void VisitOldEmployee(OldEmployee employee)
    {
        Console.WriteLine($"Old Employee`s salary is {_rate * (decimal)_tax * 2}");
        
    }

    public void VisitNewEmployee(NewEmployee employee)
    {
        Console.WriteLine($"New Employee`s salary is {_rate * (decimal)_tax}");
    }
}