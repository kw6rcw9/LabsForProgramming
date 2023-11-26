namespace OCP;

public class NewEmployee: Employee
{
    public override string Name { get;  }
    public override string Position { get;  }

    public string DayReport { get; }
    
    
    
    public NewEmployee(string name, string position, string report = "")
    {
        Name = name;
        Position = position;
        DayReport = report;
    }
    
    public override void Accept(IVisitor visitor)
    {
        visitor.VisitNewEmployee(this);
    }

}