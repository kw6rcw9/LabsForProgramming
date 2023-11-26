namespace OCP;

public class OldEmployee: Employee
{
    public override string Name { get;  }
    public override string Position { get;  }
    public string Experience { get; }
    
    public string DayReport { get; }
    
    public OldEmployee(string name, string position, string experience, string dayReport)
    {
        if (dayReport == String.Empty)
            throw new NullReferenceException("Employee must have a report");
        Name = name;
        Position = position;
        Experience = experience;
        DayReport = dayReport;
    }
    
    public override void Accept(IVisitor visitor)
    {
        visitor.VisitOldEmployee(this);
    }

}