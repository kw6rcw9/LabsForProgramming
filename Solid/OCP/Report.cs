namespace OCP;

public class Report: IVisitor
{
    public void VisitOldEmployee(OldEmployee employee)
    {
        Console.WriteLine($"Old Employee`s report: {employee.DayReport}");
    }

    public void VisitNewEmployee(NewEmployee employee)
    {
        if(employee.DayReport != String.Empty)
            Console.WriteLine($"New Employee`s report: {employee.DayReport}");
    }

    
}